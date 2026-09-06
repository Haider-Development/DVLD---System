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
    public partial class frmLocalDrivingLicenseApplication : Form
    {
        private enum enMode : sbyte { enAddNewMode = 1, enUpdateMode = 2 }
        private enMode _Mode = enMode.enAddNewMode;

        private int _LDLApplicationID;
        private int _PersonID = -1;
        private int _ApplicationTypeID = 1;
        private string _NationalNumber = "";
        private DateTime _ApplicationDate;
        private decimal _ApplicationFees = clsApplicationType.GetApplicationTypeFees(1);
        private byte _ApplicationStatus = 1;
        private DateTime _LastStatusDate;
        private int _RetreivedLDLApplicationID = -1;
        private int _RetreivedApplicationID = -1;
        private int _PersonAge = -1;
        private int _MinimumAllowedAge = -1;

        clsLDLApplication LDLApplication;
        DataTable LicenseClassesList = clsLicenseClass.LicenseClassesList();

        public frmLocalDrivingLicenseApplication(int LDLApplicationID)
        {
            InitializeComponent();

            _LDLApplicationID = LDLApplicationID;

            if (_LDLApplicationID != -1)
                _Mode = enMode.enUpdateMode;

            else
                _Mode = enMode.enAddNewMode;
        }

        private void _LoadData()
        {
            cbLicenseClasses.DisplayMember = "ClassName";
            cbLicenseClasses.ValueMember = "LicenseClassID";
            cbLicenseClasses.DataSource = LicenseClassesList;

            lblFees.Text = _ApplicationFees.ToString();

            if (_Mode == enMode.enAddNewMode)
            {
                LDLApplication = new clsLDLApplication();

                ctrlPersonCardWithFilter1.FilterEnabled = true;
                ctrlPersonCardWithFilter1.FilterSelectedIndex = 0;
                _ApplicationDate = DateTime.Now;
                lblDate.Text = _ApplicationDate.ToString();
                lblCreatedByUserID.Text = clsGlobalSettings.CurrentUser.Username;
                return;
            }

            LDLApplication = clsLDLApplication.FindLDLApplication(_LDLApplicationID);

            if (LDLApplication != null)
            {
                _PersonID = LDLApplication.ApplicantPersonID;
                _NationalNumber = clsPerson.GetNationalNumber(_PersonID);

                ctrlPersonCardWithFilter1.FilterEnabled = false;
                ctrlPersonCardWithFilter1.LoadPersonInfo(_PersonID);
                lblApplicationID.Text = LDLApplication.LDLApplicationID.ToString();
                lblDate.Text = LDLApplication.ApplicationDate.ToString();
                cbLicenseClasses.SelectedValue = LDLApplication.LicenseClassID;

                clsUser CreatedByUser = clsUser.FindUserByID(LDLApplication.CreatedByUserID);
                lblCreatedByUserID.Text = CreatedByUser.Username;
            }
        }

        private void frmLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private bool _IsPersonSelected()
        {
            if (_Mode == enMode.enAddNewMode)
            {
                _PersonID = ctrlPersonCardWithFilter1.PersonID;
                _NationalNumber = ctrlPersonCardWithFilter1.NationalNumber;

                return (_PersonID != -1 || _NationalNumber != "");
            }

            return true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!_IsPersonSelected())
            {
                clsMessageDialog.Show("Please select a person first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tcSubmitLicense.SelectedTab = PageApplicationInfo;
        }

        private void tcSubmitLicense_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == PageApplicationInfo && !_IsPersonSelected())
            {
                e.Cancel = true;
                clsMessageDialog.Show("Please select a person first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcSubmitLicense.SelectTab(PagePersonInfo);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            _RetreivedLDLApplicationID = clsLDLApplicationView.GetLDLApplicationID(_NationalNumber, cbLicenseClasses.Text);

            if (_RetreivedLDLApplicationID != -1)
                _RetreivedApplicationID = clsLDLApplication.GetApplicationIDByLDLApplicationID(_RetreivedLDLApplicationID);

            if (clsLicense.IsLicenseExits(_RetreivedApplicationID))
            {
                clsMessageDialog.Show("This person has already a License with this Type of License Class\nPlease Choose another Class Type ...",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_IsPersonSelected())
            {
                clsMessageDialog.Show("Please select a person first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tcSubmitLicense.SelectedTab == PagePersonInfo)
            {
                clsMessageDialog.Show("Please Move to the next page and check your Data before saving!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clsLDLApplicationView.IsLDLApplicationExist(_NationalNumber, cbLicenseClasses.Text))
            {
                clsMessageDialog.Show($"Cannot (Add / Update) an application with same License Class : {cbLicenseClasses.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _PersonAge = clsPerson.GetPersonAge(_PersonID);
            _MinimumAllowedAge=clsLicenseClass.GetMinimumAllowedAge(Convert.ToInt32(cbLicenseClasses.SelectedValue));

            if (_PersonAge < _MinimumAllowedAge)
            {
                clsMessageDialog.Show($"This person's Age doesn't Match minimum allowed age of the License with Class : [{cbLicenseClasses.Text}]"
                + Environment.NewLine + $"The Applicant Age must be at least : [{_MinimumAllowedAge}].", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_Mode == enMode.enAddNewMode)
            {
                _LastStatusDate = DateTime.Now;

                LDLApplication.ApplicantPersonID = _PersonID;
                LDLApplication.ApplicationDate = _ApplicationDate;
                LDLApplication.ApplicationTypeID = _ApplicationTypeID;
                LDLApplication.ApplicationStatus = _ApplicationStatus;
                LDLApplication.LastStatusDate = _LastStatusDate;
                LDLApplication.PaidFees = _ApplicationFees;
                LDLApplication.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
                LDLApplication.LicenseClassID = Convert.ToInt32(cbLicenseClasses.SelectedValue);

                if (LDLApplication.Save())
                {
                    clsMessageDialog.Show($"Application has been added successfully! \n New LDL.App ID : {LDLApplication.LDLApplicationID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lblApplicationID.Text = LDLApplication.LDLApplicationID.ToString();
                    _Mode = enMode.enUpdateMode;
                    ctrlPersonCardWithFilter1.FilterEnabled = false;

                    this.DialogResult = DialogResult.OK;
                    return;
                }
            }

            else
            {
                LDLApplication.LicenseClassID = Convert.ToInt32(cbLicenseClasses.SelectedValue);

                if (LDLApplication.Save())
                {
                    clsMessageDialog.Show($"Application has been Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}
