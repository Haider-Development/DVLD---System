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
    public partial class frmChangePassword : Form
    {
        int _UserID;
        clsUser _User;

        public frmChangePassword(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void _IsTextEmpty(object sender, CancelEventArgs e)
        {
            Guna2TextBox txtSender = (Guna2TextBox)sender;

            if (string.IsNullOrEmpty(txtSender.Text))
            {
                e.Cancel = true;
                txtSender.Focus();
                errorProvider1.SetError(txtSender, "this field cannot be empty!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSender, "");
            }
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            _IsTextEmpty(sender, e);

            if (txtCurrentPassword.Text != _User.Password)
            {
                e.Cancel = true;
                txtCurrentPassword.Focus();
                errorProvider1.SetError(txtCurrentPassword, "Incorrect Password!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCurrentPassword, "");
            }
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _User = clsUser.FindUserByID(_UserID);

            if (_User == null)
            {
                clsMessageDialog.Show($"This form will be closed because there is no user with User ID : [{_UserID}]", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.Close();
            }

            ctrlUserCard1.LoadUserInfo(_UserID);
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            _IsTextEmpty(sender, e);
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            _IsTextEmpty(sender, e);

            if (txtConfirmPassword.Text != txtNewPassword.Text)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                clsMessageDialog.Show("Check your inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _User.Password = txtNewPassword.Text;

            if (_User.Save())
            {
                clsMessageDialog.Show("New Password has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCurrentPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();
            }

            else
                clsMessageDialog.Show("Cannot save new password!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.PasswordChar == '*' && txtConfirmPassword.PasswordChar == '*')
            {
                txtNewPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
                btnViewPassword.Image = Properties.Resources.eye_closed;
                btnViewPassword.FillColor = Color.Violet;
            }

            else
            {
                txtNewPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
                btnViewPassword.Image = Properties.Resources.eye_open;
                btnViewPassword.FillColor = Color.DarkOrchid;
            }
        }
    }
}
