using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmReplaceLicenses : Form
    {
        private enum enApplicationType : sbyte { enLost = 3, enDamaged = 4 }
        private enApplicationType _ApplicationType;

        private int _OldLicenseID = -1;
        private int _ReplacedLicenseID = -1;
        private int _ApplicationID;

        private decimal _ApplicationFees;

        private DateTime _TodaysDate;

        private clsApplication _Application = new clsApplication();
        private clsLicense _License = new clsLicense();
        private clsLicense _OldLicense;

        public frmReplaceLicenses()
        {
            InitializeComponent();
        }

        private void _LicenseFound(int LicenseID)
        {
            if (LicenseID == -1)
            {
                _OldLicenseID = -1;
                lblOldLicenseID.Text = "???";

                llViewLicenseHistory.Enabled = false;
                btnReplace.Enabled = false;
            }

            else
            {
                _OldLicenseID = LicenseID;
                lblOldLicenseID.Text = _OldLicenseID.ToString();

                llViewLicenseHistory.Enabled = true;
                btnReplace.Enabled = true;
            }
        }

        private bool _IsReasonNotSelected()
        {
            if (rbDamaged.Checked == false && rbLost.Checked == false)
            {
                clsMessageDialog.Show("Please choose a reason for replacement first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void _LoadData()
        {
            _TodaysDate = DateTime.Now;
            lblApplicationDate.Text = _TodaysDate.ToShortDateString();
            lblCreatedBy.Text = clsGlobalSettings.CurrentUser.Username;

            ctrlLicenseDetailsWithFilter1.OnLicenseFound += _LicenseFound;
        }
        
        private void frmReplaceLicenses_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        
        private void rbDamaged_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDamaged.Checked)
            {
                _ApplicationType = enApplicationType.enDamaged;
                _ApplicationFees = clsApplicationType.GetApplicationTypeFees((int)_ApplicationType);
                lblApplicationFees.Text = _ApplicationFees.ToString();
            }
        }
        
        private void rbLost_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLost.Checked)
            {
                _ApplicationType = enApplicationType.enLost;
                _ApplicationFees = clsApplicationType.GetApplicationTypeFees((int)_ApplicationType);
                lblApplicationFees.Text = _ApplicationFees.ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_OldLicenseID == -1)
            {
                clsMessageDialog.Show("Select a License First to move to next page!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tcLicenseReplace.SelectTab(PageApplicationInfo);
        }

        private void tcLicenseReplace_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == PageApplicationInfo && _OldLicenseID == -1)
            {
                e.Cancel = true;
                clsMessageDialog.Show("Select a License First to move to next page!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcLicenseReplace.SelectTab(PageOldLicenseInfo);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (tcLicenseReplace.SelectedTab == PageOldLicenseInfo)
            {
                clsMessageDialog.Show($"Please move to the next page first and Check Application info!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clsDetainedLicense.IsLicenseDetained(_OldLicenseID))
            {
                clsMessageDialog.Show($"This License is Detained ... Release The License First!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!clsLicense.IsLicenseValid(_OldLicenseID))
            {
                clsMessageDialog.Show($"This License is Deactivated ... Please make sure about License status!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clsLicense.IsLicenseExpired(_OldLicenseID))
            {
                clsMessageDialog.Show($"This License is expired ... You can only replace for Active Licenses!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (_IsReasonNotSelected())
                return;

            if (clsMessageDialog.Show($"Are You Sure you want to Replace this license?", "Confirm", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                _Application.ApplicantPersonID = ctrlLicenseDetailsWithFilter1.PersonID;
                _Application.ApplicationDate = _TodaysDate;
                _Application.ApplicationTypeID = (int)_ApplicationType;
                _Application.ApplicationStatus = 1;
                _Application.LastStatusDate = _TodaysDate;
                _Application.PaidFees = _ApplicationFees;
                _Application.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;

                if (_Application.Save())
                {
                    _OldLicense = clsLicense.FindLicense(_OldLicenseID);
                    _License.ApplicationID = _Application.ApplicationID;
                    _License.DriverID = _OldLicense.DriverID;
                    _License.LicenseClass = _OldLicense.LicenseClass;
                    _License.IssueDate = _OldLicense.IssueDate;
                    _License.ExpirationDate = _OldLicense.ExpirationDate;
                    _License.Notes = _OldLicense.Notes;
                    _License.PaidFees = _OldLicense.PaidFees;
                    _License.IsActive = true;
                    _License.IssueReason = (byte)_ApplicationType;
                    _License.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;

                    if (_License.Save())
                    {
                        clsMessageDialog.Show($"Old License has been Replaced successfully!\nNew License ID : [{_License.LicenseID}]",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _Application.ApplicationStatus = 3;
                        _Application.LastStatusDate = DateTime.Now;
                        _Application.Save();

                        _ReplacedLicenseID = _License.LicenseID;
                        _ApplicationID = _Application.ApplicationID;

                        lblApplicationID.Text = _ApplicationID.ToString();
                        lblReplacedLicenseID.Text = _ReplacedLicenseID.ToString();

                        ctrlLicenseDetailsWithFilter1.FilterEnabled = false;
                        btnReplace.Enabled = false;
                        llViewLicenseDetails.Enabled = true;
                        gbReplacementReason.Enabled = false;

                        _OldLicense.IsActive = false;
                        _OldLicense.Save();
                    }

                    else
                    {
                        clsMessageDialog.Show($"Cannot Replace old Driving License!", "Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_ReplacedLicenseID != -1)
                this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void llViewLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmViewPersonLicensesHistory Frm = new frmViewPersonLicensesHistory(ctrlLicenseDetailsWithFilter1.PersonID);
            Frm.ShowDialog();
        }

        private void llViewLicenseDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmViewLicenseDetails Frm = new frmViewLicenseDetails(_ReplacedLicenseID);
            Frm.ShowDialog();
        }

    }
}
