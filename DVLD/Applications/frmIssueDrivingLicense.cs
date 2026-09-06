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
    public partial class frmIssueDrivingLicense : Form
    {
        private int _LDLApplicationID;
        private int _DriverID;

        private clsDriver _Driver;
        private clsLicense _License;
        private clsLDLApplication _LDLApplication;

        public frmIssueDrivingLicense()
        {
            InitializeComponent();
        }

        public frmIssueDrivingLicense(int LDLApplicationID)
        {
            InitializeComponent();

            _LDLApplicationID = LDLApplicationID;
        }

        private bool _LastSave()
        {
            _LDLApplication = clsLDLApplication.FindLDLApplication(_LDLApplicationID);
            _LDLApplication.ApplicationStatus = 3;
            _LDLApplication.LastStatusDate = DateTime.Now;

            if (_LDLApplication.Save())
                return true;
            else
                return false;
        }

        private void _AddNewDriverAndLicense()
        {
            if (clsMessageDialog.Show("Are you sure you want to Issue this License?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _LDLApplication = clsLDLApplication.FindLDLApplication(_LDLApplicationID);

                byte ValidityLength = clsLicenseClass.GetValidityLengthValue(_LDLApplication.LicenseClassID);

                if (!clsDriver.IsDriverExits(_LDLApplication.ApplicantPersonID))
                {
                    _Driver = new clsDriver();

                    _Driver.PersonID = _LDLApplication.ApplicantPersonID;
                    _Driver.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
                    _Driver.CreatedDate = DateTime.Now;

                    if (_Driver.Save())
                        _DriverID = _Driver.DriverID;
                    
                }

                else
                    _DriverID = clsDriver.GetDriverID(_LDLApplication.ApplicantPersonID);


                _License = new clsLicense();

                _License.ApplicationID = _LDLApplication.ApplicationID;
                _License.DriverID = _DriverID;
                _License.LicenseClass = _LDLApplication.LicenseClassID;
                _License.IssueDate = DateTime.Now;
                _License.ExpirationDate = DateTime.Now.AddYears((int)ValidityLength);
                _License.Notes = txtNotes.Text.Trim();
                _License.PaidFees = clsLicenseClass.GetLicenseClassFees(_LDLApplication.LicenseClassID);
                _License.IsActive = true;
                _License.IssueReason = 1;
                _License.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;

                if (_License.Save())
                {
                    _LastSave();
                    clsMessageDialog.Show($"License Issued successfully with License ID : [{_License.LicenseID}]", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }

                else
                    clsMessageDialog.Show($"cannot Issue a new license", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frmIssueDrivingLicense_Load(object sender, EventArgs e)
        {
            ctrlApplicationDetails1.LoadApplicationInfo(_LDLApplicationID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _AddNewDriverAndLicense();
        }
    }
}
