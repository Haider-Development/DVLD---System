namespace DVLD
{
    partial class frmManageDetainedLicenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblRowsCount = new System.Windows.Forms.Label();
            this.cbIsReleased = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvDetainedLicenses = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsViewLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsViewLicensesHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsRelease = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDetainLicense = new Guna.UI2.WinForms.Guna2Button();
            this.btnReleaseLicense = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).BeginInit();
            this.cmsSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel11.BorderRadius = 65;
            this.guna2Panel11.BorderThickness = 1;
            this.guna2Panel11.Controls.Add(this.pbImage);
            this.guna2Panel11.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2Panel11.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Panel11.Location = new System.Drawing.Point(527, 11);
            this.guna2Panel11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Size = new System.Drawing.Size(152, 137);
            this.guna2Panel11.TabIndex = 100;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.BorderRadius = 50;
            this.pbImage.FillColor = System.Drawing.Color.Transparent;
            this.pbImage.Image = global::DVLD.Properties.Resources.lock__1_;
            this.pbImage.ImageRotate = 0F;
            this.pbImage.Location = new System.Drawing.Point(10, 5);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(134, 127);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 94;
            this.pbImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(429, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 37);
            this.label1.TabIndex = 99;
            this.label1.Text = "Manage Detained Licenses";
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 12;
            this.btnClose.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnClose.Image = global::DVLD.Properties.Resources.close;
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(1030, 537);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(99, 38);
            this.btnClose.TabIndex = 95;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRowsCount
            // 
            this.lblRowsCount.AutoSize = true;
            this.lblRowsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowsCount.ForeColor = System.Drawing.Color.Indigo;
            this.lblRowsCount.Location = new System.Drawing.Point(13, 550);
            this.lblRowsCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRowsCount.Name = "lblRowsCount";
            this.lblRowsCount.Size = new System.Drawing.Size(181, 25);
            this.lblRowsCount.TabIndex = 101;
            this.lblRowsCount.Text = "# Number of Rows :";
            // 
            // cbIsReleased
            // 
            this.cbIsReleased.BackColor = System.Drawing.Color.Transparent;
            this.cbIsReleased.BorderColor = System.Drawing.Color.Silver;
            this.cbIsReleased.BorderRadius = 15;
            this.cbIsReleased.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIsReleased.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsReleased.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsReleased.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsReleased.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbIsReleased.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbIsReleased.ItemHeight = 30;
            this.cbIsReleased.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsReleased.Location = new System.Drawing.Point(282, 248);
            this.cbIsReleased.Margin = new System.Windows.Forms.Padding(4);
            this.cbIsReleased.Name = "cbIsReleased";
            this.cbIsReleased.Size = new System.Drawing.Size(156, 36);
            this.cbIsReleased.TabIndex = 105;
            this.cbIsReleased.SelectedIndexChanged += new System.EventHandler(this.cbIsReleased_SelectedIndexChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.BorderColor = System.Drawing.Color.Silver;
            this.cbFilter.BorderRadius = 15;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbFilter.ItemHeight = 30;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "D.ID",
            "L.ID",
            "N.No",
            "Full Name",
            "Is Released"});
            this.cbFilter.Location = new System.Drawing.Point(110, 248);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(143, 36);
            this.cbFilter.TabIndex = 104;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(14, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 103;
            this.label3.Text = "Filter By :";
            // 
            // txtFilter
            // 
            this.txtFilter.BorderColor = System.Drawing.Color.Silver;
            this.txtFilter.BorderRadius = 15;
            this.txtFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilter.DefaultText = "";
            this.txtFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilter.Location = new System.Drawing.Point(282, 250);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.Size = new System.Drawing.Size(246, 32);
            this.txtFilter.TabIndex = 106;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // dgvDetainedLicenses
            // 
            this.dgvDetainedLicenses.AllowUserToAddRows = false;
            this.dgvDetainedLicenses.AllowUserToDeleteRows = false;
            this.dgvDetainedLicenses.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetainedLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetainedLicenses.ColumnHeadersHeight = 40;
            this.dgvDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDetainedLicenses.ContextMenuStrip = this.cmsSettings;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetainedLicenses.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetainedLicenses.GridColor = System.Drawing.Color.Gray;
            this.dgvDetainedLicenses.Location = new System.Drawing.Point(14, 300);
            this.dgvDetainedLicenses.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            this.dgvDetainedLicenses.ReadOnly = true;
            this.dgvDetainedLicenses.RowHeadersVisible = false;
            this.dgvDetainedLicenses.RowTemplate.Height = 35;
            this.dgvDetainedLicenses.Size = new System.Drawing.Size(1115, 229);
            this.dgvDetainedLicenses.TabIndex = 107;
            this.dgvDetainedLicenses.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvDetainedLicenses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dgvDetainedLicenses.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.dgvDetainedLicenses.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dgvDetainedLicenses.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDetainedLicenses.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvDetainedLicenses.ThemeStyle.ReadOnly = true;
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gray;
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.Height = 35;
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            // 
            // cmsSettings
            // 
            this.cmsSettings.BackColor = System.Drawing.Color.DarkGray;
            this.cmsSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsSettings.ImageScalingSize = new System.Drawing.Size(38, 38);
            this.cmsSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsViewDetails,
            this.toolStripSeparator1,
            this.cmsViewLicenseDetails,
            this.cmsViewLicensesHistory,
            this.toolStripMenuItem2,
            this.cmsRelease});
            this.cmsSettings.Name = "contextMenuStrip1";
            this.cmsSettings.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsSettings.Size = new System.Drawing.Size(307, 214);
            this.cmsSettings.Opening += new System.ComponentModel.CancelEventHandler(this.cmsSettings_Opening);
            // 
            // cmsViewDetails
            // 
            this.cmsViewDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cmsViewDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsViewDetails.Image = global::DVLD.Properties.Resources.view_details;
            this.cmsViewDetails.Name = "cmsViewDetails";
            this.cmsViewDetails.Size = new System.Drawing.Size(306, 44);
            this.cmsViewDetails.Text = "View Person Details";
            this.cmsViewDetails.Click += new System.EventHandler(this.cmsViewDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.DimGray;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(303, 6);
            // 
            // cmsViewLicenseDetails
            // 
            this.cmsViewLicenseDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsViewLicenseDetails.Image = global::DVLD.Properties.Resources.view_detail;
            this.cmsViewLicenseDetails.Name = "cmsViewLicenseDetails";
            this.cmsViewLicenseDetails.Size = new System.Drawing.Size(306, 44);
            this.cmsViewLicenseDetails.Text = "View License Details";
            this.cmsViewLicenseDetails.Click += new System.EventHandler(this.cmsViewLicenseDetails_Click);
            // 
            // cmsViewLicensesHistory
            // 
            this.cmsViewLicensesHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsViewLicensesHistory.Image = global::DVLD.Properties.Resources.view_details_big;
            this.cmsViewLicensesHistory.Name = "cmsViewLicensesHistory";
            this.cmsViewLicensesHistory.Size = new System.Drawing.Size(306, 44);
            this.cmsViewLicensesHistory.Text = "View Person License History";
            this.cmsViewLicensesHistory.Click += new System.EventHandler(this.cmsViewLicensesHistory_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(303, 6);
            // 
            // cmsRelease
            // 
            this.cmsRelease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsRelease.Image = global::DVLD.Properties.Resources.lock_open;
            this.cmsRelease.Name = "cmsRelease";
            this.cmsRelease.Size = new System.Drawing.Size(306, 44);
            this.cmsRelease.Text = "Release Detained License";
            this.cmsRelease.Click += new System.EventHandler(this.cmsRelease_Click);
            // 
            // btnDetainLicense
            // 
            this.btnDetainLicense.BorderRadius = 12;
            this.btnDetainLicense.CheckedState.FillColor = System.Drawing.Color.Green;
            this.btnDetainLicense.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetainLicense.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetainLicense.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetainLicense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetainLicense.FillColor = System.Drawing.Color.Peru;
            this.btnDetainLicense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDetainLicense.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDetainLicense.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnDetainLicense.Image = global::DVLD.Properties.Resources.lock_closed;
            this.btnDetainLicense.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDetainLicense.Location = new System.Drawing.Point(1052, 247);
            this.btnDetainLicense.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDetainLicense.Size = new System.Drawing.Size(72, 45);
            this.btnDetainLicense.TabIndex = 110;
            this.btnDetainLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
            // 
            // btnReleaseLicense
            // 
            this.btnReleaseLicense.BorderRadius = 12;
            this.btnReleaseLicense.CheckedState.FillColor = System.Drawing.Color.Green;
            this.btnReleaseLicense.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReleaseLicense.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReleaseLicense.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReleaseLicense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReleaseLicense.FillColor = System.Drawing.Color.Lime;
            this.btnReleaseLicense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReleaseLicense.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnReleaseLicense.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnReleaseLicense.Image = global::DVLD.Properties.Resources.lock_open__2_;
            this.btnReleaseLicense.ImageSize = new System.Drawing.Size(25, 25);
            this.btnReleaseLicense.Location = new System.Drawing.Point(972, 248);
            this.btnReleaseLicense.Margin = new System.Windows.Forms.Padding(4);
            this.btnReleaseLicense.Name = "btnReleaseLicense";
            this.btnReleaseLicense.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnReleaseLicense.Size = new System.Drawing.Size(72, 45);
            this.btnReleaseLicense.TabIndex = 111;
            this.btnReleaseLicense.Click += new System.EventHandler(this.btnReleaseLicense_Click);
            // 
            // frmManageDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 588);
            this.Controls.Add(this.btnReleaseLicense);
            this.Controls.Add(this.btnDetainLicense);
            this.Controls.Add(this.dgvDetainedLicenses);
            this.Controls.Add(this.cbIsReleased);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblRowsCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2Panel11);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageDetainedLicenses";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageDetainedLicenses";
            this.Load += new System.EventHandler(this.frmManageDetainedLicenses_Load);
            this.guna2Panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).EndInit();
            this.cmsSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel11;
        private Guna.UI2.WinForms.Guna2PictureBox pbImage;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lblRowsCount;
        private Guna.UI2.WinForms.Guna2ComboBox cbIsReleased;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDetainedLicenses;
        private Guna.UI2.WinForms.Guna2Button btnDetainLicense;
        private Guna.UI2.WinForms.Guna2Button btnReleaseLicense;
        private System.Windows.Forms.ContextMenuStrip cmsSettings;
        private System.Windows.Forms.ToolStripMenuItem cmsViewDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsViewLicenseDetails;
        private System.Windows.Forms.ToolStripMenuItem cmsViewLicensesHistory;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cmsRelease;
    }
}