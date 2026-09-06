using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void _LoadImageSafely(string ImagePath)
        {
            if (File.Exists(ImagePath))
            {
                using (FileStream FS = new FileStream(ImagePath, FileMode.Open, FileAccess.Read))
                {
                    pbImage.Image = Image.FromStream(FS);
                    pbImage.Tag = ImagePath;
                }
            }
        }

        private void FormLoader(Form ChildForm)
        {
            MainContentPanel.Controls.Clear();

            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.StartPosition = FormStartPosition.CenterScreen;

            MainContentPanel.AutoScroll = true;
            MainContentPanel.Controls.Add(ChildForm);
            MainContentPanel.Tag = ChildForm;
            ChildForm.Show();
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            FormLoader(new frmManagePeople());
        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            cmsApplications.Show(btnApplications, new Point(btnApplications.Width + 10, -1));
        }

        private void btnDetainedLicenses_Click(object sender, EventArgs e)
        {
            cmsDetaines.Show(btnDetainedLicenses, new Point(btnDetainedLicenses.Width + 10, -1));
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            FormLoader(new frmManageUsers());
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            FormLoader(new frmListDrivers());
        }

        private void cmsManageDetainedLicenses_Click(object sender, EventArgs e)
        {
            FormLoader(new frmManageDetainedLicenses());
        }

        private void cmsDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense Frm = new frmDetainLicense();
            Frm.ShowDialog();
        }

        private void cmsReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense Frm = new frmReleaseDetainedLicense();
            Frm.ShowDialog();

            if (Frm.DialogResult == DialogResult.OK)
                btnDashboard.PerformClick();
        }

        private void cmsManageTestTypes_Click(object sender, EventArgs e)
        {
            FormLoader(new frmManageTestTypes());
        }

        private void cmsManageApplicationTypes_Click(object sender, EventArgs e)
        {
            FormLoader(new frmManageApplicationTypes());
        }

        private void cmsManageLocalLicenses_Click(object sender, EventArgs e)
        {
            FormLoader(new frmManageLDLApplications());
        }

        private void cmsManageInternationalLicenses_Click(object sender, EventArgs e)
        {
            FormLoader(new frmManageInternationalLicensesApplications());
        }

        private void cmsRetakeTest_Click(object sender, EventArgs e)
        {
            FormLoader(new frmManageLDLApplications());
        }

        private void cmsAppReleaseLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense Frm = new frmReleaseDetainedLicense();
            Frm.ShowDialog();

            if (Frm.DialogResult == DialogResult.OK)
                btnDashboard.PerformClick();
        }

        private void cmsReplaceLicense_Click(object sender, EventArgs e)
        {
            frmReplaceLicenses Frm = new frmReplaceLicenses();
            Frm.ShowDialog();

            if (Frm.DialogResult == DialogResult.OK)
                btnDashboard.PerformClick();
        }

        private void cmsRenewLicense_Click(object sender, EventArgs e)
        {
            frmRenewDrivingLicense Frm = new frmRenewDrivingLicense();
            Frm.ShowDialog();

            if (Frm.DialogResult == DialogResult.OK)
                btnDashboard.PerformClick();
        }

        private void cmsNewLocalLicense_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplication Frm = new frmLocalDrivingLicenseApplication(-1);
            Frm.ShowDialog();

            if (Frm.DialogResult == DialogResult.OK)
                btnDashboard.PerformClick();
        }

        private void cmsNewInternationalLicense_Click(object sender, EventArgs e)
        {
            frmIssueInternationalLicense Frm = new frmIssueInternationalLicense();
            Frm.ShowDialog();

            if (Frm.DialogResult == DialogResult.OK)
                btnDashboard.PerformClick();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnDashboard.PerformClick();

            string ImagePath = clsGlobalSettings.CurrentUser.PersonInfo.ImagePath;

            if (!string.IsNullOrEmpty(ImagePath))
                _LoadImageSafely(ImagePath);

            else
                pbImage.Image = (clsGlobalSettings.CurrentUser.PersonInfo.Gender == 0) ? Properties.Resources.man : Properties.Resources.woman;

            btnUserOptionsMenu.Text = clsGlobalSettings.CurrentUser.Username;
            timer1_Tick(sender, e);

            clsGlobalSettings.OnCurrentUserUpdated += UpdateCurrentUserInfo;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormLoader(new frmDashboard());
        }

        private void btnUserOptionsMenu_Click(object sender, EventArgs e)
        {
            cmsUserMenu.Show(btnUserOptionsMenu, new Point(0, btnUserOptionsMenu.Height));
        }

        private void cmsCurrentUserInfo_Click(object sender, EventArgs e)
        {
            frmUserDetails Frm = new frmUserDetails(clsGlobalSettings.CurrentUser.UserID);
            Frm.ShowDialog();
        }

        private void cmsChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword Frm = new frmChangePassword(clsGlobalSettings.CurrentUser.UserID);
            Frm.ShowDialog();
        }

        private void cmsLogOut_Click(object sender, EventArgs e)
        {
            clsGlobalSettings.CurrentUser = null;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMM yyyy  |  hh:mm:ss tt");
        }

        private void UpdateCurrentUserInfo()
        {
            btnUserOptionsMenu.Text = clsGlobalSettings.CurrentUser.Username;
        }
    }
}
