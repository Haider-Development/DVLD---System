using DVLD_BusinessLayer;
using Guna.UI2.WinForms;
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
    public partial class frmAddEditUser : Form
    {
        private enum enMode : sbyte { enAddNewMode = 1, enUpdateMode = 2 };
        private enMode _Mode = enMode.enAddNewMode;

        private int _PersonID;
        private int _UserID;
        private string _NationalNumber;
        private clsUser _User;

        public frmAddEditUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
            _PersonID = -1;
            _NationalNumber = "";

            if (_UserID != -1)
                _Mode = enMode.enUpdateMode;
            else
                _Mode = enMode.enAddNewMode;
        }

        private bool _IsPersonSelected()
        {
            _PersonID = ctrlPersonCardWithFilter1.PersonID;
            _NationalNumber = ctrlPersonCardWithFilter1.NationalNumber;

            return (_PersonID != -1 || _NationalNumber != "");
        }

        private bool _IsUserExist()
        {
            if (clsUser.IsUserExistByNationalNumber(_NationalNumber) || clsUser.IsUserExistByPersonID(_PersonID))
                return true;

            else
                return false;
        }

        private void _LoadData()
        {
            if (_Mode == enMode.enAddNewMode)
            {
                _User = new clsUser();
                lblAddEdit.Text = "Add New User";
                ctrlPersonCardWithFilter1.FilterEnabled = true;
                ctrlPersonCardWithFilter1.FilterSelectedIndex = 0;

                return;
            }

            ctrlPersonCardWithFilter1.FilterEnabled = false;
            lblAddEdit.Text = "Update User";

            _User = clsUser.FindUserByID(_UserID);

            _PersonID = _User.PersonID;

            ctrlPersonCardWithFilter1.LoadPersonInfo(_PersonID);
            lblUserID.Text = _UserID.ToString();
            txtUsername.Text = _User.Username;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            chkIsActive.Checked = _User.IsActive;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsPersonSelected())
            {
                clsMessageDialog.Show("Please select a person first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!this.ValidateChildren())
            {
                clsMessageDialog.Show("Check Your Inputs!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.PersonID = _PersonID;
            _User.Username = txtUsername.Text;
            _User.Password = txtPassword.Text;
            _User.IsActive = chkIsActive.Checked;

            if (_User.Save())
            {
                if (clsGlobalSettings.CurrentUser.UserID == _UserID)
                {
                    clsGlobalSettings.CurrentUser = _User;
                    clsUtil.SaveRememberMeData(_User.Username, _User.Password);
                    clsGlobalSettings.TriggerCurrentUserUpdated();
                }

                    clsMessageDialog.Show("User has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                _UserID = _User.UserID;

                this.Text = "Update User";
                lblAddEdit.Text = "Update User";
                _Mode = enMode.enUpdateMode;
                lblUserID.Text = _UserID.ToString();
            }

            else
                clsMessageDialog.Show("Error with saving the user", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!_IsPersonSelected())
            {
                clsMessageDialog.Show("Please select a person first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_IsUserExist() && _Mode == enMode.enAddNewMode)
            {
                clsMessageDialog.Show("The selected person is already a user! please choose another one...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tcUserInfo.SelectedTab = PageLoginInfo;
        }

        private void tcUserInfo_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == PageLoginInfo && !_IsPersonSelected())
            {
                e.Cancel = true;
                clsMessageDialog.Show("Please select a person first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (e.TabPage == PageLoginInfo && _IsUserExist() && _Mode == enMode.enAddNewMode)
            {
                e.Cancel = true;
                clsMessageDialog.Show("The selected person is already a user! please choose another one...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*' && txtConfirmPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
                btnViewPassword.Image = Properties.Resources.eye_closed;
                btnViewPassword.FillColor = Color.Violet;
            }

            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
                btnViewPassword.Image = Properties.Resources.eye_open;
                btnViewPassword.FillColor = Color.DarkOrchid;
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "This field cannot be empty!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, "");
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "This field cannot be empty!");
                return;
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, "");
            }

            if (clsUser.IsUserExistByUsername(txtUsername.Text) && _Mode == enMode.enAddNewMode)
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "This Username is already used!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, "");
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                e.Cancel = true;
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtConfirmPassword, "Password must be the same!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, "");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcUserInfo.SelectedTab = PagePersonInfo;
        }

    }
}
