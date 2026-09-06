using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.IO;
using Guna.UI2.WinForms;

namespace DVLD
{
    public partial class frmLogin : Form
    {
        public static bool IsRememberMeChecked = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtSender_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox txtSender = (Guna2TextBox)sender;

            if (string.IsNullOrEmpty(txtSender.Text))
            {
                txtSender.Focus();
                errorProvider1.SetError(txtSender, "This field cannot be empty!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSender, "");
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                clsMessageDialog.Show("Please check your inputs again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string Username = txtUsername.Text.Trim(), Password = txtPassword.Text.Trim();

            clsGlobalSettings.CurrentUser = clsUser.FindUserByUsernameAndPassword(Username, Password);

            if (clsGlobalSettings.CurrentUser != null && !clsGlobalSettings.CurrentUser.IsActive)
            {
                clsMessageDialog.Show("This user is Deactivated ... Please Contact Your Admin!", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            if (clsGlobalSettings.CurrentUser != null)
            {
                clsUtil.SaveRememberMeData(Username, Password);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            else
                clsMessageDialog.Show("Invalid (Username / Password) , Check your inputs again!", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string Username = "", Password = "";

            if (clsUtil.LoadDataFromFile(ref Username, ref Password))
            {
                txtUsername.Text = Username;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
        }

        private void txtSender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSignIn.PerformClick();
            }
        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRememberMe.Checked)
                IsRememberMeChecked = true;

            else
                IsRememberMeChecked = false;
        }
    }
}
