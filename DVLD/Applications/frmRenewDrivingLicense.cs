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
    public partial class frmRenewDrivingLicense : Form
    {
        private int _OldLicenseID = -1;
        private int _ValidityLength;
        private int _LicenseClassID;
        private int _RenewdLicenseID = -1;
        private int _ApplicationID;

        private DateTime _TodaysDate;
        private DateTime _ExpirationDate;

        private decimal _ApplicationFees = clsApplicationType.GetApplicationTypeFees(2);
        private decimal _LicenseFees;
        private decimal _TotalFees;

        private clsApplication _Application = new clsApplication();
        private clsLicense _License = new clsLicense();
        private clsLicense _OldLicense;

        public frmRenewDrivingLicense()
        {
            InitializeComponent();
        }

        private void _LicenseFound(int LicenseID)
        {
            if (LicenseID == -1)
            {
                lblOldLicense.Text = "???";
                lblLicenseFees.Text = "???";
                lblExpirationDate.Text = "???";
                lblTotalFees.Text = "???";
                _LicenseClassID = -1;
                _LicenseFees = -1;
                _TotalFees = -1;
                _ExpirationDate = DateTime.Now;
                llViewLicenseHistory.Enabled = false;
                btnRenew.Enabled = false;
                _OldLicenseID = -1;
            }

            else
            {
                _OldLicenseID = LicenseID;
                lblOldLicense.Text = _OldLicenseID.ToString();
                _LicenseClassID = ctrlLicenseDetailsWithFilter1.LicenseClassID;

                _ValidityLength = clsLicenseClass.GetValidityLengthValue(_LicenseClassID);
                _ExpirationDate = _TodaysDate.AddYears(_ValidityLength);
                lblExpirationDate.Text = _ExpirationDate.ToString();

                _LicenseFees = clsLicenseClass.GetLicenseClassFees(_LicenseClassID);
                lblLicenseFees.Text = _LicenseFees.ToString();

                _TotalFees = _ApplicationFees + _LicenseFees;
                lblTotalFees.Text = _TotalFees.ToString();

                llViewLicenseHistory.Enabled = true;
                btnRenew.Enabled = true;
            }
        }

        private void _LoadData()
        {
            _TodaysDate = DateTime.Now;
            lblApplicationDate.Text = _TodaysDate.ToShortDateString();
            lblIssueDate.Text = _TodaysDate.ToShortDateString();
            lblApplicationFees.Text = _ApplicationFees.ToString();
            lblCreatedBy.Text = clsGlobalSettings.CurrentUser.Username;

            ctrlLicenseDetailsWithFilter1.OnLicenseFound += _LicenseFound;
        }

        private void frmRenewDrivingLicense_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_OldLicenseID == -1)
            {
                clsMessageDialog.Show("Select a License First to move to next page!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tcLicenseRenew.SelectTab(PageApplicationInfo);
        }

        private void tcLicenseRenew_Selecting(object sender, TabControlCancelEventArgs e)
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
            tcLicenseRenew.SelectTab(PageOldLicenseInfo);
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (tcLicenseRenew.SelectedTab == PageOldLicenseInfo)
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

            if (!clsLicense.IsLicenseExpired(_OldLicenseID))
            {
                clsMessageDialog.Show($"This License isn't expired yet ... You can only renew for expired Licenses!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clsMessageDialog.Show($"Are You Sure you want to Renew this license?", "Confirm", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                _OldLicense = clsLicense.FindLicense(_OldLicenseID);

                if (clsLicense.IsLicenseExistAndActive(_OldLicense.DriverID, _OldLicense.LicenseClass))
                {
                    clsMessageDialog.Show($"There is already an active License with same class ID ... You cannot continue this Process!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _Application.ApplicantPersonID = ctrlLicenseDetailsWithFilter1.PersonID;
                _Application.ApplicationDate = _TodaysDate;
                _Application.ApplicationTypeID = 6;
                _Application.ApplicationStatus = 1;
                _Application.LastStatusDate = _TodaysDate;
                _Application.PaidFees = _ApplicationFees;
                _Application.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;

                if (_Application.Save())
                {
                    _License.ApplicationID = _Application.ApplicationID;
                    _License.DriverID = _OldLicense.DriverID;
                    _License.LicenseClass = _OldLicense.LicenseClass;
                    _License.IssueDate = _TodaysDate;
                    _License.ExpirationDate = _ExpirationDate;
                    _License.Notes = txtNotes.Text.Trim();
                    _License.PaidFees = _LicenseFees;
                    _License.IsActive = true;
                    _License.IssueReason = 2;
                    _License.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;

                    if (_License.Save())
                    {
                        clsMessageDialog.Show($"Old License has been Renewed successfully!\nNew License ID : [{_License.LicenseID}]",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _Application.ApplicationStatus = 3;
                        _Application.LastStatusDate = DateTime.Now;
                        _Application.Save();

                        _RenewdLicenseID = _License.LicenseID;
                        _ApplicationID = _Application.ApplicationID;

                        lblApplicationID.Text = _ApplicationID.ToString();
                        lblRenewdLicenseID.Text = _RenewdLicenseID.ToString();

                        ctrlLicenseDetailsWithFilter1.FilterEnabled = false;
                        btnRenew.Enabled = false;
                        llViewLicenseDetails.Enabled = true;

                        _OldLicense.IsActive = false;
                        _OldLicense.Save();
                    }

                    else
                    {
                        clsMessageDialog.Show($"Cannot Renew old Driving License!", "Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_RenewdLicenseID != -1)
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
            frmViewLicenseDetails Frm = new frmViewLicenseDetails(_RenewdLicenseID);
            Frm.ShowDialog();
        }
    }
}
