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
using static DVLD.frmScheduleTest;

namespace DVLD
{
    public partial class frmReleaseDetainedLicense : Form
    {
        private enum enApplicationType : sbyte { enReleaseLicense = 5 }
        private static enApplicationType _ApplicationType = enApplicationType.enReleaseLicense;

        private int _LicenseID = -1;
        private int _ReleaseID = -1;
        private int _ApplicationID;
        private int _DetainID = -1;

        private decimal _ApplicationFees = clsApplicationType.GetApplicationTypeFees((int)_ApplicationType);
        private decimal _TotalFees;

        private DateTime _TodaysDate;

        private clsApplication _Application = new clsApplication();
        private clsDetainedLicense _DetainedLicense;

        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }

        private void _InitializeForm(int LicenseID)
        {
            _LicenseFound(LicenseID);

            ctrlLicenseDetailsWithFilter1.LoadLicenseData(LicenseID);
            ctrlLicenseDetailsWithFilter1.FilterEnabled = false;
        }

        public frmReleaseDetainedLicense(int LicenseID)
        {
            InitializeComponent();

            _InitializeForm(LicenseID);
        }

        private void _LicenseFound(int LicenseID)
        {
            if (LicenseID == -1)
            {
                _LicenseID = -1;
                lblLicenseID.Text = "???";
                lblDetainID.Text = "???";
                lblDetainDate.Text = "???";
                lblFineFees.Text = "???";
                lblTotalFees.Text = "???";

                llViewLicenseHistory.Enabled = false;
                btnRelease.Enabled = false;
            }

            else
            {
                _LicenseID = LicenseID;
                _DetainID = clsDetainedLicense.GetDetainID(_LicenseID);

                if (_DetainID != -1)
                    _DetainedLicense = clsDetainedLicense.FindDetain(_DetainID);

                if (_DetainedLicense != null)
                {
                    lblDetainID.Text = _DetainedLicense.DetainID.ToString();
                    lblDetainDate.Text = _DetainedLicense.DetainDate.ToShortDateString();
                    lblFineFees.Text = _DetainedLicense.FineFees.ToString();

                    _TotalFees = _ApplicationFees + _DetainedLicense.FineFees;
                    lblTotalFees.Text = _TotalFees.ToString();
                }

                lblLicenseID.Text = _LicenseID.ToString();
                llViewLicenseHistory.Enabled = true;
                btnRelease.Enabled = true;
            }
        }

        private void _LoadData()
        {
            _TodaysDate = DateTime.Now;
            lblApplicationFees.Text = _ApplicationFees.ToString();
            lblCreatedBy.Text = clsGlobalSettings.CurrentUser.Username;

            ctrlLicenseDetailsWithFilter1.OnLicenseFound += _LicenseFound;
        }
        
        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_LicenseID == -1)
            {
                clsMessageDialog.Show("Please select a License first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tcLicenseRelease.SelectedTab = PageApplicationInfo;
        }

        private void tcLicenseRelease_Selecting(object sender, TabControlCancelEventArgs e)
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
            tcLicenseRelease.SelectedTab = PageOldLicenseInfo;
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (tcLicenseRelease.SelectedTab == PageOldLicenseInfo)
            {
                clsMessageDialog.Show($"Please move to the next page first and Check Application info!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!clsDetainedLicense.IsLicenseDetained(_LicenseID))
            {
                clsMessageDialog.Show($"This License is not Detained ... You can only Release Detained Licenses!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clsMessageDialog.Show($"Are You Sure you want to Release this license?", "Confirm", MessageBoxButtons.OKCancel,
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
                    if (_DetainedLicense != null)
                    {
                        _DetainedLicense.IsReleased = true;
                        _DetainedLicense.ReleaseDate = _TodaysDate;
                        _DetainedLicense.ReleasedByUserID = clsGlobalSettings.CurrentUser.UserID;
                        _DetainedLicense.ReleaseApplicationID = _Application.ApplicationID;

                        if (_DetainedLicense.Save())
                        {
                            clsMessageDialog.Show($"License has been Released successfully!\nRelease ID : [{_DetainedLicense.ReleaseApplicationID}]",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            _Application.ApplicationStatus = 3;
                            _Application.LastStatusDate = DateTime.Now;
                            _Application.Save();

                            _ReleaseID = _DetainedLicense.ReleaseApplicationID;

                            lblReleaseID.Text = _ReleaseID.ToString();

                            ctrlLicenseDetailsWithFilter1.FilterEnabled = false;
                            btnRelease.Enabled = false;
                            llViewLicenseDetails.Enabled = true;
                        }

                        else
                        {
                            clsMessageDialog.Show($"Cannot Release This Driving License!", "Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_ReleaseID != -1)
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
            frmViewLicenseDetails Frm = new frmViewLicenseDetails(_LicenseID);
            Frm.ShowDialog();
        }

    }
}
