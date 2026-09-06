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
    public partial class frmIssueInternationalLicense : Form
    {
        private int _InternationalLicenseID;
        private int _LicenseID = -1;
        private int _DriverID;
        private int _ApplicationID;

        private DateTime _TodaysDate;
        private DateTime _ExpirationDate;
        private decimal _ApplicationFees = clsApplicationType.GetApplicationTypeFees(6);

        private clsApplication _Application = new clsApplication();
        private clsInternationalLicense _InternationalLicense = new clsInternationalLicense();

        public frmIssueInternationalLicense()
        {
            InitializeComponent();
        }

        private void _DeactivateInternationalLicense(int DriverID)
        {
            int InternationalLicenseID = clsInternationalLicense.GetInternationalLicenseID(_DriverID);

            clsInternationalLicense InternationalLicense = clsInternationalLicense.FindInternatioanlLicense(InternationalLicenseID);

            InternationalLicense.IsActive = false;
            InternationalLicense.Save();
        }

        private void _LicenseFound(int LicenseID)
        {
            if (LicenseID == -1)
            {
                lblLocalLicense.Text = "???";
                llViewLicenseHistory.Enabled = false;
                btnIssue.Enabled = false;
                _LicenseID = -1;
            }

            else
            {
                lblLocalLicense.Text = LicenseID.ToString();
                llViewLicenseHistory.Enabled = true;
                btnIssue.Enabled = true;
                _LicenseID = LicenseID;
            }
        }

        private void _LoadData()
        {
            _TodaysDate = DateTime.Now;
            _ExpirationDate = _TodaysDate.AddYears(1);
            lblApplicationDate.Text = _TodaysDate.ToShortDateString();
            lblIssueDate.Text = _TodaysDate.ToShortDateString();
            lblFees.Text = _ApplicationFees.ToString();
            lblExpirationDate.Text = _ExpirationDate.ToShortDateString();
            lblCreatedBy.Text = clsGlobalSettings.CurrentUser.Username;
        }

        private void frmIssueInternationalLicense_Load(object sender, EventArgs e)
        {
            _LoadData();
            ctrlLicenseDetailsWithFilter1.OnLicenseFound += _LicenseFound;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_LicenseID == -1)
            {
                clsMessageDialog.Show("Select a License First to move to next page!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tcLicenseIssuing.SelectTab(PageApplicationInfo);
        }

        private void tcLicenseIssuing_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == PageApplicationInfo && _LicenseID == -1)
            {
                e.Cancel = true;
                clsMessageDialog.Show("Select a License First to move to next page!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcLicenseIssuing.SelectTab(PageLicenseInfo);
        }

        private void llViewLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmViewPersonLicensesHistory Frm = new frmViewPersonLicensesHistory(ctrlLicenseDetailsWithFilter1.PersonID);
            Frm.ShowDialog();
        }

        private void llViewLicenseDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmViewInternationalLicenseDetails Frm = new frmViewInternationalLicenseDetails(_InternationalLicenseID);
            Frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (tcLicenseIssuing.SelectedTab == PageLicenseInfo)
            {
                clsMessageDialog.Show($"Please move to the next page first and Check Application info!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _DriverID = clsDriver.GetDriverID(ctrlLicenseDetailsWithFilter1.PersonID);

            if (clsInternationalLicense.IsInternationalLicenseExistByDriverID(_DriverID) && clsInternationalLicense.IsInternationalLicenseExpired(_DriverID))
            {
                _DeactivateInternationalLicense(_DriverID);
            }

            if (clsInternationalLicense.IsInternationalLicenseExistByDriverID(_DriverID))
            {
                clsMessageDialog.Show($"This Person has already an Active International License!\nYou cannot apply for another one",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!clsLicenseClass.IsLicenseThirdClass(ctrlLicenseDetailsWithFilter1.LicenseClassID))
            {
                string ClassName = clsLicenseClass.GetLicenseClassName(3);

                clsMessageDialog.Show($"You can Issue an International License Only if you have Local License of Type [{ClassName}]!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clsDetainedLicense.IsLicenseDetained(_LicenseID))
            {
                clsMessageDialog.Show($"This License is Detained ... Release The License First!",
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
                _InternationalLicense.ApplicationID = _Application.ApplicationID;
                _InternationalLicense.DriverID = _DriverID;
                _InternationalLicense.IssuedUsingLocalLicenseID = _LicenseID;
                _InternationalLicense.IssueDate = _TodaysDate;
                _InternationalLicense.ExpirationDate = _ExpirationDate;
                _InternationalLicense.IsActive = true;
                _InternationalLicense.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;

                if (_InternationalLicense.Save())
                {
                    clsMessageDialog.Show($"International License has been issued successfully!\nNew License ID : [{_InternationalLicense.InternationalLicenseID}]",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _Application.ApplicationStatus = 3;
                    _Application.LastStatusDate = DateTime.Now;
                    _Application.Save();

                    _InternationalLicenseID = _InternationalLicense.InternationalLicenseID;
                    _ApplicationID = _Application.ApplicationID;

                    lblApplicationID.Text = _ApplicationID.ToString();
                    lblInternationalLicenseID.Text = _InternationalLicenseID.ToString();

                    ctrlLicenseDetailsWithFilter1.FilterEnabled = false;
                    btnIssue.Enabled = false;
                    llViewLicenseDetails.Enabled = true;

                    this.DialogResult = DialogResult.OK;
                }

                else
                {
                    clsMessageDialog.Show($"Cannot issue an International Driving License!", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
                clsMessageDialog.Show($"Cannot Save an applciation for International Driving License!", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
