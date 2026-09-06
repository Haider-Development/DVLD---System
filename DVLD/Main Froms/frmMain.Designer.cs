namespace DVLD
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmsApplications = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.drivingLicensesServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsNewLocalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsNewInternationalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRenewLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsReplaceLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAppReleaseLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRetakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsManageLocalLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsManageInternationalLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDetaines = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.cmsManageDetainedLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDetainLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsReleaseDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDetainedLicenses = new Guna.UI2.WinForms.Guna2Button();
            this.btnApplications = new Guna.UI2.WinForms.Guna2Button();
            this.btnDrivers = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnPeople = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnUserOptionsMenu = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MainContentPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.cmsUserMenu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.cmsCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmsApplications.SuspendLayout();
            this.cmsDetaines.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.cmsUserMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsApplications
            // 
            this.cmsApplications.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmsApplications.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmsApplications.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicensesServicesToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem1,
            this.cmsManageApplicationTypes,
            this.cmsManageTestTypes});
            this.cmsApplications.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmsApplications.Name = "cmsApplications";
            this.cmsApplications.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsApplications.RenderStyle.BorderColor = System.Drawing.Color.Transparent;
            this.cmsApplications.RenderStyle.ColorTable = null;
            this.cmsApplications.RenderStyle.RoundedEdges = true;
            this.cmsApplications.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsApplications.RenderStyle.SelectionBackColor = System.Drawing.Color.Teal;
            this.cmsApplications.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsApplications.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsApplications.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsApplications.Size = new System.Drawing.Size(346, 196);
            // 
            // drivingLicensesServicesToolStripMenuItem
            // 
            this.drivingLicensesServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem1,
            this.cmsRenewLicense,
            this.cmsReplaceLicense,
            this.cmsAppReleaseLicense,
            this.cmsRetakeTest});
            this.drivingLicensesServicesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.drivingLicensesServicesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.drivingLicensesServicesToolStripMenuItem.Image = global::DVLD.Properties.Resources.drivers_license;
            this.drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
            this.drivingLicensesServicesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.drivingLicensesServicesToolStripMenuItem.Size = new System.Drawing.Size(353, 48);
            this.drivingLicensesServicesToolStripMenuItem.Text = "   Driving Licenses Services";
            // 
            // newDrivingLicenseToolStripMenuItem1
            // 
            this.newDrivingLicenseToolStripMenuItem1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.newDrivingLicenseToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsNewLocalLicense,
            this.cmsNewInternationalLicense});
            this.newDrivingLicenseToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.newDrivingLicenseToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.newDrivingLicenseToolStripMenuItem1.Image = global::DVLD.Properties.Resources.license_agreement;
            this.newDrivingLicenseToolStripMenuItem1.Name = "newDrivingLicenseToolStripMenuItem1";
            this.newDrivingLicenseToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.newDrivingLicenseToolStripMenuItem1.Size = new System.Drawing.Size(415, 42);
            this.newDrivingLicenseToolStripMenuItem1.Text = "   New Driving License";
            // 
            // cmsNewLocalLicense
            // 
            this.cmsNewLocalLicense.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmsNewLocalLicense.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmsNewLocalLicense.ForeColor = System.Drawing.Color.White;
            this.cmsNewLocalLicense.Image = global::DVLD.Properties.Resources.shop_local;
            this.cmsNewLocalLicense.Name = "cmsNewLocalLicense";
            this.cmsNewLocalLicense.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cmsNewLocalLicense.Size = new System.Drawing.Size(292, 42);
            this.cmsNewLocalLicense.Text = "   Local License";
            this.cmsNewLocalLicense.Click += new System.EventHandler(this.cmsNewLocalLicense_Click);
            // 
            // cmsNewInternationalLicense
            // 
            this.cmsNewInternationalLicense.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmsNewInternationalLicense.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmsNewInternationalLicense.ForeColor = System.Drawing.Color.White;
            this.cmsNewInternationalLicense.Image = global::DVLD.Properties.Resources.international;
            this.cmsNewInternationalLicense.Name = "cmsNewInternationalLicense";
            this.cmsNewInternationalLicense.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cmsNewInternationalLicense.Size = new System.Drawing.Size(292, 42);
            this.cmsNewInternationalLicense.Text = "   International License";
            this.cmsNewInternationalLicense.Click += new System.EventHandler(this.cmsNewInternationalLicense_Click);
            // 
            // cmsRenewLicense
            // 
            this.cmsRenewLicense.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmsRenewLicense.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmsRenewLicense.ForeColor = System.Drawing.Color.White;
            this.cmsRenewLicense.Image = global::DVLD.Properties.Resources.renewable_energy;
            this.cmsRenewLicense.Name = "cmsRenewLicense";
            this.cmsRenewLicense.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cmsRenewLicense.Size = new System.Drawing.Size(415, 42);
            this.cmsRenewLicense.Text = "   Renew Driving License";
            this.cmsRenewLicense.Click += new System.EventHandler(this.cmsRenewLicense_Click);
            // 
            // cmsReplaceLicense
            // 
            this.cmsReplaceLicense.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmsReplaceLicense.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmsReplaceLicense.ForeColor = System.Drawing.Color.White;
            this.cmsReplaceLicense.Image = global::DVLD.Properties.Resources.replace;
            this.cmsReplaceLicense.Name = "cmsReplaceLicense";
            this.cmsReplaceLicense.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cmsReplaceLicense.Size = new System.Drawing.Size(415, 42);
            this.cmsReplaceLicense.Text = "   Replacement For Lost Or Damaged";
            this.cmsReplaceLicense.Click += new System.EventHandler(this.cmsReplaceLicense_Click);
            // 
            // cmsAppReleaseLicense
            // 
            this.cmsAppReleaseLicense.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmsAppReleaseLicense.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmsAppReleaseLicense.ForeColor = System.Drawing.Color.White;
            this.cmsAppReleaseLicense.Image = global::DVLD.Properties.Resources.lock_open__2_;
            this.cmsAppReleaseLicense.Name = "cmsAppReleaseLicense";
            this.cmsAppReleaseLicense.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cmsAppReleaseLicense.Size = new System.Drawing.Size(415, 42);
            this.cmsAppReleaseLicense.Text = "   Release Detained License";
            this.cmsAppReleaseLicense.Click += new System.EventHandler(this.cmsAppReleaseLicense_Click);
            // 
            // cmsRetakeTest
            // 
            this.cmsRetakeTest.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmsRetakeTest.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmsRetakeTest.ForeColor = System.Drawing.Color.White;
            this.cmsRetakeTest.Image = global::DVLD.Properties.Resources.checklist__1_;
            this.cmsRetakeTest.Name = "cmsRetakeTest";
            this.cmsRetakeTest.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cmsRetakeTest.Size = new System.Drawing.Size(415, 42);
            this.cmsRetakeTest.Text = "   Retake Test";
            this.cmsRetakeTest.Click += new System.EventHandler(this.cmsRetakeTest_Click);
            // 
            // manageApplicationsToolStripMenuItem1
            // 
            this.manageApplicationsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsManageLocalLicenses,
            this.cmsManageInternationalLicenses});
            this.manageApplicationsToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.manageApplicationsToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.manageApplicationsToolStripMenuItem1.Image = global::DVLD.Properties.Resources.services;
            this.manageApplicationsToolStripMenuItem1.Name = "manageApplicationsToolStripMenuItem1";
            this.manageApplicationsToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.manageApplicationsToolStripMenuItem1.Size = new System.Drawing.Size(353, 48);
            this.manageApplicationsToolStripMenuItem1.Text = "   Manage Applications";
            // 
            // cmsManageLocalLicenses
            // 
            this.cmsManageLocalLicenses.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmsManageLocalLicenses.ForeColor = System.Drawing.Color.White;
            this.cmsManageLocalLicenses.Image = global::DVLD.Properties.Resources.shop_local;
            this.cmsManageLocalLicenses.Name = "cmsManageLocalLicenses";
            this.cmsManageLocalLicenses.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cmsManageLocalLicenses.Size = new System.Drawing.Size(478, 42);
            this.cmsManageLocalLicenses.Text = "   Local Driving License Applications";
            this.cmsManageLocalLicenses.Click += new System.EventHandler(this.cmsManageLocalLicenses_Click);
            // 
            // cmsManageInternationalLicenses
            // 
            this.cmsManageInternationalLicenses.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmsManageInternationalLicenses.ForeColor = System.Drawing.Color.White;
            this.cmsManageInternationalLicenses.Image = global::DVLD.Properties.Resources.international;
            this.cmsManageInternationalLicenses.Name = "cmsManageInternationalLicenses";
            this.cmsManageInternationalLicenses.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cmsManageInternationalLicenses.Size = new System.Drawing.Size(478, 42);
            this.cmsManageInternationalLicenses.Text = "   International Driving License Applications";
            this.cmsManageInternationalLicenses.Click += new System.EventHandler(this.cmsManageInternationalLicenses_Click);
            // 
            // cmsManageApplicationTypes
            // 
            this.cmsManageApplicationTypes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmsManageApplicationTypes.ForeColor = System.Drawing.Color.White;
            this.cmsManageApplicationTypes.Image = global::DVLD.Properties.Resources.service;
            this.cmsManageApplicationTypes.Name = "cmsManageApplicationTypes";
            this.cmsManageApplicationTypes.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cmsManageApplicationTypes.Size = new System.Drawing.Size(353, 48);
            this.cmsManageApplicationTypes.Text = "   Manage Application Types";
            this.cmsManageApplicationTypes.Click += new System.EventHandler(this.cmsManageApplicationTypes_Click);
            // 
            // cmsManageTestTypes
            // 
            this.cmsManageTestTypes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmsManageTestTypes.ForeColor = System.Drawing.Color.White;
            this.cmsManageTestTypes.Image = global::DVLD.Properties.Resources.checklist;
            this.cmsManageTestTypes.Name = "cmsManageTestTypes";
            this.cmsManageTestTypes.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cmsManageTestTypes.Size = new System.Drawing.Size(353, 48);
            this.cmsManageTestTypes.Text = "   Manage Test Types";
            this.cmsManageTestTypes.Click += new System.EventHandler(this.cmsManageTestTypes_Click);
            // 
            // cmsDetaines
            // 
            this.cmsDetaines.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmsDetaines.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmsDetaines.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsDetaines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsManageDetainedLicenses,
            this.cmsDetainLicense,
            this.cmsReleaseDetainedLicense});
            this.cmsDetaines.Name = "cmsDetaines";
            this.cmsDetaines.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsDetaines.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsDetaines.RenderStyle.ColorTable = null;
            this.cmsDetaines.RenderStyle.RoundedEdges = true;
            this.cmsDetaines.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsDetaines.RenderStyle.SelectionBackColor = System.Drawing.Color.Teal;
            this.cmsDetaines.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsDetaines.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsDetaines.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsDetaines.Size = new System.Drawing.Size(346, 136);
            // 
            // cmsManageDetainedLicenses
            // 
            this.cmsManageDetainedLicenses.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmsManageDetainedLicenses.ForeColor = System.Drawing.Color.White;
            this.cmsManageDetainedLicenses.Image = global::DVLD.Properties.Resources.project_management1;
            this.cmsManageDetainedLicenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmsManageDetainedLicenses.Name = "cmsManageDetainedLicenses";
            this.cmsManageDetainedLicenses.Padding = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.cmsManageDetainedLicenses.Size = new System.Drawing.Size(358, 44);
            this.cmsManageDetainedLicenses.Text = "   Manage Detained Licenses";
            this.cmsManageDetainedLicenses.Click += new System.EventHandler(this.cmsManageDetainedLicenses_Click);
            // 
            // cmsDetainLicense
            // 
            this.cmsDetainLicense.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmsDetainLicense.ForeColor = System.Drawing.Color.White;
            this.cmsDetainLicense.Image = global::DVLD.Properties.Resources.lock_closed;
            this.cmsDetainLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmsDetainLicense.ImageTransparentColor = System.Drawing.Color.White;
            this.cmsDetainLicense.Name = "cmsDetainLicense";
            this.cmsDetainLicense.Padding = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.cmsDetainLicense.Size = new System.Drawing.Size(353, 44);
            this.cmsDetainLicense.Text = "   Detain License";
            this.cmsDetainLicense.Click += new System.EventHandler(this.cmsDetainLicense_Click);
            // 
            // cmsReleaseDetainedLicense
            // 
            this.cmsReleaseDetainedLicense.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmsReleaseDetainedLicense.ForeColor = System.Drawing.Color.White;
            this.cmsReleaseDetainedLicense.Image = global::DVLD.Properties.Resources.lock_open__2_;
            this.cmsReleaseDetainedLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmsReleaseDetainedLicense.Name = "cmsReleaseDetainedLicense";
            this.cmsReleaseDetainedLicense.Padding = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.cmsReleaseDetainedLicense.Size = new System.Drawing.Size(358, 44);
            this.cmsReleaseDetainedLicense.Text = "   Release Detained License";
            this.cmsReleaseDetainedLicense.Click += new System.EventHandler(this.cmsReleaseDetainedLicense_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnDetainedLicenses);
            this.guna2Panel1.Controls.Add(this.btnApplications);
            this.guna2Panel1.Controls.Add(this.btnDrivers);
            this.guna2Panel1.Controls.Add(this.btnUsers);
            this.guna2Panel1.Controls.Add(this.btnPeople);
            this.guna2Panel1.Controls.Add(this.btnDashboard);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(228, 500);
            this.guna2Panel1.TabIndex = 3;
            // 
            // btnDetainedLicenses
            // 
            this.btnDetainedLicenses.Animated = true;
            this.btnDetainedLicenses.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDetainedLicenses.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.btnDetainedLicenses.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDetainedLicenses.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetainedLicenses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetainedLicenses.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetainedLicenses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetainedLicenses.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnDetainedLicenses.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetainedLicenses.ForeColor = System.Drawing.Color.White;
            this.btnDetainedLicenses.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnDetainedLicenses.Image = global::DVLD.Properties.Resources.license;
            this.btnDetainedLicenses.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDetainedLicenses.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDetainedLicenses.Location = new System.Drawing.Point(3, 408);
            this.btnDetainedLicenses.Name = "btnDetainedLicenses";
            this.btnDetainedLicenses.Size = new System.Drawing.Size(219, 45);
            this.btnDetainedLicenses.TabIndex = 5;
            this.btnDetainedLicenses.Text = "Manage Licenses";
            this.btnDetainedLicenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDetainedLicenses.Click += new System.EventHandler(this.btnDetainedLicenses_Click);
            // 
            // btnApplications
            // 
            this.btnApplications.Animated = true;
            this.btnApplications.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnApplications.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.btnApplications.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnApplications.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApplications.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApplications.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApplications.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApplications.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnApplications.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnApplications.ForeColor = System.Drawing.Color.White;
            this.btnApplications.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnApplications.Image = global::DVLD.Properties.Resources.feature;
            this.btnApplications.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnApplications.ImageSize = new System.Drawing.Size(40, 40);
            this.btnApplications.Location = new System.Drawing.Point(4, 357);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnApplications.Size = new System.Drawing.Size(219, 45);
            this.btnApplications.TabIndex = 4;
            this.btnApplications.Text = "Applications";
            this.btnApplications.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnApplications.TextOffset = new System.Drawing.Point(-40, 0);
            this.btnApplications.Click += new System.EventHandler(this.btnApplications_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.Animated = true;
            this.btnDrivers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDrivers.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.btnDrivers.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDrivers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDrivers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDrivers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDrivers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDrivers.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnDrivers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDrivers.ForeColor = System.Drawing.Color.White;
            this.btnDrivers.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnDrivers.Image = global::DVLD.Properties.Resources.people__1_;
            this.btnDrivers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDrivers.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDrivers.Location = new System.Drawing.Point(4, 306);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDrivers.Size = new System.Drawing.Size(219, 45);
            this.btnDrivers.TabIndex = 3;
            this.btnDrivers.Text = "Drivers";
            this.btnDrivers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDrivers.TextOffset = new System.Drawing.Point(-40, 0);
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Animated = true;
            this.btnUsers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUsers.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.btnUsers.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsers.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnUsers.Image = global::DVLD.Properties.Resources.group;
            this.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUsers.Location = new System.Drawing.Point(4, 255);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(219, 45);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.TextOffset = new System.Drawing.Point(-40, 0);
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.Animated = true;
            this.btnPeople.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPeople.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.btnPeople.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnPeople.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPeople.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPeople.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPeople.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPeople.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnPeople.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPeople.ForeColor = System.Drawing.Color.White;
            this.btnPeople.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnPeople.Image = global::DVLD.Properties.Resources.multiple_users_silhouette;
            this.btnPeople.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPeople.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPeople.Location = new System.Drawing.Point(4, 204);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnPeople.Size = new System.Drawing.Size(219, 45);
            this.btnPeople.TabIndex = 1;
            this.btnPeople.Text = "People";
            this.btnPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPeople.TextOffset = new System.Drawing.Point(-40, 0);
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Animated = true;
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnDashboard.Image = global::DVLD.Properties.Resources.dashboard;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDashboard.Location = new System.Drawing.Point(0, 153);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(219, 45);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.TextOffset = new System.Drawing.Point(-37, 0);
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 15;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.lblDateTime);
            this.guna2Panel2.Controls.Add(this.guna2Panel11);
            this.guna2Panel2.Controls.Add(this.btnUserOptionsMenu);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(228, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1158, 63);
            this.guna2Panel2.TabIndex = 4;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDateTime.Location = new System.Drawing.Point(436, 21);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(100, 25);
            this.lblDateTime.TabIndex = 85;
            this.lblDateTime.Text = "Date Time";
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel11.BorderRadius = 20;
            this.guna2Panel11.BorderThickness = 2;
            this.guna2Panel11.Controls.Add(this.pbImage);
            this.guna2Panel11.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2Panel11.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Panel11.Location = new System.Drawing.Point(878, 7);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Size = new System.Drawing.Size(55, 50);
            this.guna2Panel11.TabIndex = 84;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.BorderRadius = 20;
            this.pbImage.FillColor = System.Drawing.Color.Transparent;
            this.pbImage.ImageRotate = 0F;
            this.pbImage.Location = new System.Drawing.Point(3, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(49, 44);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 94;
            this.pbImage.TabStop = false;
            // 
            // btnUserOptionsMenu
            // 
            this.btnUserOptionsMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnUserOptionsMenu.BorderRadius = 18;
            this.btnUserOptionsMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserOptionsMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserOptionsMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserOptionsMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserOptionsMenu.FillColor = System.Drawing.Color.Transparent;
            this.btnUserOptionsMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserOptionsMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUserOptionsMenu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUserOptionsMenu.Image = global::DVLD.Properties.Resources.arrow_down;
            this.btnUserOptionsMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnUserOptionsMenu.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUserOptionsMenu.Location = new System.Drawing.Point(942, 12);
            this.btnUserOptionsMenu.Name = "btnUserOptionsMenu";
            this.btnUserOptionsMenu.Size = new System.Drawing.Size(182, 45);
            this.btnUserOptionsMenu.TabIndex = 2;
            this.btnUserOptionsMenu.Text = "Username";
            this.btnUserOptionsMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserOptionsMenu.Click += new System.EventHandler(this.btnUserOptionsMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "DVLD - Driver License System";
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.BorderRadius = 15;
            this.MainContentPanel.BorderThickness = 1;
            this.MainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContentPanel.Location = new System.Drawing.Point(228, 63);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Size = new System.Drawing.Size(1158, 437);
            this.MainContentPanel.TabIndex = 5;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 300;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // cmsUserMenu
            // 
            this.cmsUserMenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmsUserMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsUserMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsUserMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCurrentUserInfo,
            this.cmsChangePassword,
            this.toolStripMenuItem3,
            this.cmsLogOut});
            this.cmsUserMenu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmsUserMenu.Name = "cmsUserMenu";
            this.cmsUserMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsUserMenu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsUserMenu.RenderStyle.ColorTable = null;
            this.cmsUserMenu.RenderStyle.RoundedEdges = true;
            this.cmsUserMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsUserMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsUserMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsUserMenu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsUserMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsUserMenu.Size = new System.Drawing.Size(241, 160);
            // 
            // cmsCurrentUserInfo
            // 
            this.cmsCurrentUserInfo.ForeColor = System.Drawing.Color.White;
            this.cmsCurrentUserInfo.Image = global::DVLD.Properties.Resources.information_button;
            this.cmsCurrentUserInfo.Name = "cmsCurrentUserInfo";
            this.cmsCurrentUserInfo.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cmsCurrentUserInfo.Size = new System.Drawing.Size(248, 50);
            this.cmsCurrentUserInfo.Text = "    Current User Info";
            this.cmsCurrentUserInfo.Click += new System.EventHandler(this.cmsCurrentUserInfo_Click);
            // 
            // cmsChangePassword
            // 
            this.cmsChangePassword.ForeColor = System.Drawing.Color.White;
            this.cmsChangePassword.Image = global::DVLD.Properties.Resources.password__2_;
            this.cmsChangePassword.Name = "cmsChangePassword";
            this.cmsChangePassword.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cmsChangePassword.Size = new System.Drawing.Size(248, 50);
            this.cmsChangePassword.Text = "    Change Password";
            this.cmsChangePassword.Click += new System.EventHandler(this.cmsChangePassword_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(237, 6);
            // 
            // cmsLogOut
            // 
            this.cmsLogOut.ForeColor = System.Drawing.Color.White;
            this.cmsLogOut.Image = global::DVLD.Properties.Resources.sign_out;
            this.cmsLogOut.Name = "cmsLogOut";
            this.cmsLogOut.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cmsLogOut.Size = new System.Drawing.Size(248, 50);
            this.cmsLogOut.Text = "    Log Out";
            this.cmsLogOut.Click += new System.EventHandler(this.cmsLogOut_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1386, 500);
            this.Controls.Add(this.MainContentPanel);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Goudy Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "DVLD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.cmsApplications.ResumeLayout(false);
            this.cmsDetaines.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.cmsUserMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmsManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmsRenewLicense;
        private System.Windows.Forms.ToolStripMenuItem cmsReplaceLicense;
        private System.Windows.Forms.ToolStripMenuItem cmsAppReleaseLicense;
        private System.Windows.Forms.ToolStripMenuItem cmsRetakeTest;
        private System.Windows.Forms.ToolStripMenuItem cmsManageTestTypes;
        private System.Windows.Forms.ToolStripMenuItem cmsManageLocalLicenses;
        private System.Windows.Forms.ToolStripMenuItem cmsManageInternationalLicenses;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsDetaines;
        private System.Windows.Forms.ToolStripMenuItem cmsManageDetainedLicenses;
        private System.Windows.Forms.ToolStripMenuItem cmsDetainLicense;
        private System.Windows.Forms.ToolStripMenuItem cmsReleaseDetainedLicense;
        private System.Windows.Forms.ToolStripMenuItem cmsNewLocalLicense;
        private System.Windows.Forms.ToolStripMenuItem cmsNewInternationalLicense;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnPeople;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnDrivers;
        private Guna.UI2.WinForms.Guna2Button btnApplications;
        private Guna.UI2.WinForms.Guna2Button btnDetainedLicenses;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel MainContentPanel;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnUserOptionsMenu;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel11;
        private Guna.UI2.WinForms.Guna2PictureBox pbImage;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsUserMenu;
        private System.Windows.Forms.ToolStripMenuItem cmsCurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem cmsChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cmsLogOut;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
    }
}

