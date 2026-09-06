namespace DVLD
{
    partial class frmManageLDLApplications
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
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dgvLDLApplications = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsViewAppDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsScheduleTest = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsVision = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsWritten = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsStreet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsIssueLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsViewLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsViewPersonHS = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRowsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.guna2Panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplications)).BeginInit();
            this.cmsSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.BorderRadius = 50;
            this.pbImage.FillColor = System.Drawing.Color.Transparent;
            this.pbImage.Image = global::DVLD.Properties.Resources.local_config;
            this.pbImage.ImageRotate = 0F;
            this.pbImage.Location = new System.Drawing.Point(9, 5);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(134, 127);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 94;
            this.pbImage.TabStop = false;
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel11.BorderRadius = 65;
            this.guna2Panel11.BorderThickness = 1;
            this.guna2Panel11.Controls.Add(this.pbImage);
            this.guna2Panel11.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2Panel11.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Panel11.Location = new System.Drawing.Point(495, 13);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Size = new System.Drawing.Size(152, 137);
            this.guna2Panel11.TabIndex = 103;
            // 
            // btnClose
            // 
            this.btnClose.BorderColor = System.Drawing.Color.DimGray;
            this.btnClose.BorderRadius = 12;
            this.btnClose.BorderThickness = 1;
            this.btnClose.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.Image = global::DVLD.Properties.Resources.close;
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(1029, 530);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(99, 38);
            this.btnClose.TabIndex = 102;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            "L.D.LApplicationID",
            "National No.",
            "Full Name",
            "Status"});
            this.cbFilter.Location = new System.Drawing.Point(100, 242);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(208, 36);
            this.cbFilter.TabIndex = 101;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
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
            this.txtFilter.Location = new System.Drawing.Point(335, 242);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.Size = new System.Drawing.Size(251, 34);
            this.txtFilter.TabIndex = 100;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnAdd.Image = global::DVLD.Properties.Resources.order_add;
            this.btnAdd.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAdd.Location = new System.Drawing.Point(1056, 234);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 45);
            this.btnAdd.TabIndex = 99;
            this.btnAdd.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // dgvLDLApplications
            // 
            this.dgvLDLApplications.AllowUserToAddRows = false;
            this.dgvLDLApplications.AllowUserToDeleteRows = false;
            this.dgvLDLApplications.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLDLApplications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLDLApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLDLApplications.ColumnHeadersHeight = 40;
            this.dgvLDLApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLDLApplications.ContextMenuStrip = this.cmsSettings;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLDLApplications.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLDLApplications.GridColor = System.Drawing.Color.Gray;
            this.dgvLDLApplications.Location = new System.Drawing.Point(19, 287);
            this.dgvLDLApplications.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLDLApplications.Name = "dgvLDLApplications";
            this.dgvLDLApplications.ReadOnly = true;
            this.dgvLDLApplications.RowHeadersVisible = false;
            this.dgvLDLApplications.RowTemplate.Height = 35;
            this.dgvLDLApplications.Size = new System.Drawing.Size(1109, 229);
            this.dgvLDLApplications.TabIndex = 98;
            this.dgvLDLApplications.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvLDLApplications.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLDLApplications.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dgvLDLApplications.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.dgvLDLApplications.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dgvLDLApplications.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLDLApplications.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvLDLApplications.ThemeStyle.ReadOnly = true;
            this.dgvLDLApplications.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gray;
            this.dgvLDLApplications.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dgvLDLApplications.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLDLApplications.ThemeStyle.RowsStyle.Height = 35;
            this.dgvLDLApplications.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvLDLApplications.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            // 
            // cmsSettings
            // 
            this.cmsSettings.BackColor = System.Drawing.Color.DarkGray;
            this.cmsSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cmsSettings.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsViewAppDetails,
            this.toolStripSeparator1,
            this.cmsEdit,
            this.cmsDelete,
            this.toolStripSeparator2,
            this.cmsCancel,
            this.toolStripSeparator3,
            this.cmsScheduleTest,
            this.toolStripMenuItem3,
            this.cmsIssueLicense,
            this.toolStripMenuItem4,
            this.cmsViewLicense,
            this.toolStripMenuItem5,
            this.cmsViewPersonHS});
            this.cmsSettings.Name = "contextMenuStrip1";
            this.cmsSettings.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsSettings.Size = new System.Drawing.Size(333, 366);
            this.cmsSettings.Opening += new System.ComponentModel.CancelEventHandler(this.cmsSettigns_Opening);
            // 
            // cmsViewAppDetails
            // 
            this.cmsViewAppDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsViewAppDetails.Image = global::DVLD.Properties.Resources.view_details;
            this.cmsViewAppDetails.Name = "cmsViewAppDetails";
            this.cmsViewAppDetails.Size = new System.Drawing.Size(332, 38);
            this.cmsViewAppDetails.Text = "View Application Details";
            this.cmsViewAppDetails.Click += new System.EventHandler(this.cmsViewAppDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(329, 6);
            // 
            // cmsEdit
            // 
            this.cmsEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsEdit.Image = global::DVLD.Properties.Resources.edit;
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(332, 38);
            this.cmsEdit.Text = "Edit Application";
            this.cmsEdit.Click += new System.EventHandler(this.cmsEdit_Click);
            // 
            // cmsDelete
            // 
            this.cmsDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsDelete.Image = global::DVLD.Properties.Resources.delete__1_;
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(332, 38);
            this.cmsDelete.Text = "Delete Application";
            this.cmsDelete.Click += new System.EventHandler(this.cmsDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(329, 6);
            // 
            // cmsCancel
            // 
            this.cmsCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsCancel.Image = global::DVLD.Properties.Resources.cancel;
            this.cmsCancel.Name = "cmsCancel";
            this.cmsCancel.Size = new System.Drawing.Size(332, 38);
            this.cmsCancel.Text = "Cancel Application";
            this.cmsCancel.Click += new System.EventHandler(this.cmsCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(329, 6);
            // 
            // cmsScheduleTest
            // 
            this.cmsScheduleTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsVision,
            this.cmsWritten,
            this.cmsStreet});
            this.cmsScheduleTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsScheduleTest.Image = global::DVLD.Properties.Resources.overdue_task;
            this.cmsScheduleTest.Name = "cmsScheduleTest";
            this.cmsScheduleTest.Size = new System.Drawing.Size(332, 38);
            this.cmsScheduleTest.Text = "Schedule Test";
            // 
            // cmsVision
            // 
            this.cmsVision.Image = global::DVLD.Properties.Resources.eye;
            this.cmsVision.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsVision.Name = "cmsVision";
            this.cmsVision.Size = new System.Drawing.Size(255, 38);
            this.cmsVision.Text = "Schedule Vision Test";
            this.cmsVision.Click += new System.EventHandler(this.cmsVision_Click);
            // 
            // cmsWritten
            // 
            this.cmsWritten.Enabled = false;
            this.cmsWritten.Image = global::DVLD.Properties.Resources.exam;
            this.cmsWritten.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsWritten.Name = "cmsWritten";
            this.cmsWritten.Size = new System.Drawing.Size(255, 38);
            this.cmsWritten.Text = "Schedule Written Test";
            this.cmsWritten.Click += new System.EventHandler(this.cmsWritten_Click);
            // 
            // cmsStreet
            // 
            this.cmsStreet.Enabled = false;
            this.cmsStreet.Image = global::DVLD.Properties.Resources.car;
            this.cmsStreet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsStreet.Name = "cmsStreet";
            this.cmsStreet.Size = new System.Drawing.Size(255, 38);
            this.cmsStreet.Text = "Schedule Street Test";
            this.cmsStreet.Click += new System.EventHandler(this.cmsStreet_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(329, 6);
            // 
            // cmsIssueLicense
            // 
            this.cmsIssueLicense.Enabled = false;
            this.cmsIssueLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsIssueLicense.Image = global::DVLD.Properties.Resources.id;
            this.cmsIssueLicense.Name = "cmsIssueLicense";
            this.cmsIssueLicense.Size = new System.Drawing.Size(332, 38);
            this.cmsIssueLicense.Text = "Issue Driving License (First Time)";
            this.cmsIssueLicense.Click += new System.EventHandler(this.cmsIssueLicense_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(329, 6);
            // 
            // cmsViewLicense
            // 
            this.cmsViewLicense.Enabled = false;
            this.cmsViewLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsViewLicense.Image = global::DVLD.Properties.Resources.view_detail;
            this.cmsViewLicense.Name = "cmsViewLicense";
            this.cmsViewLicense.Size = new System.Drawing.Size(332, 38);
            this.cmsViewLicense.Text = "View License";
            this.cmsViewLicense.Click += new System.EventHandler(this.cmsViewLicense_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(329, 6);
            // 
            // cmsViewPersonHS
            // 
            this.cmsViewPersonHS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsViewPersonHS.Image = global::DVLD.Properties.Resources.view_details_big;
            this.cmsViewPersonHS.Name = "cmsViewPersonHS";
            this.cmsViewPersonHS.Size = new System.Drawing.Size(332, 38);
            this.cmsViewPersonHS.Text = "View Person License History";
            this.cmsViewPersonHS.Click += new System.EventHandler(this.cmsViewPersonHS_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(15, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 97;
            this.label3.Text = "Filter By :";
            // 
            // lblRowsCount
            // 
            this.lblRowsCount.AutoSize = true;
            this.lblRowsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowsCount.ForeColor = System.Drawing.Color.Indigo;
            this.lblRowsCount.Location = new System.Drawing.Point(14, 533);
            this.lblRowsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRowsCount.Name = "lblRowsCount";
            this.lblRowsCount.Size = new System.Drawing.Size(181, 25);
            this.lblRowsCount.TabIndex = 96;
            this.lblRowsCount.Text = "# Number of Rows :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(409, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 37);
            this.label1.TabIndex = 95;
            this.label1.Text = "Manage Local Licenses";
            // 
            // frmManageLDLApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 580);
            this.Controls.Add(this.guna2Panel11);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvLDLApplications);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRowsCount);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageLDLApplications";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Driving License Applications";
            this.Load += new System.EventHandler(this.frmManageLDLApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.guna2Panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplications)).EndInit();
            this.cmsSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pbImage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel11;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLDLApplications;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRowsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsSettings;
        private System.Windows.Forms.ToolStripMenuItem cmsViewAppDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cmsCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cmsScheduleTest;
        private System.Windows.Forms.ToolStripMenuItem cmsVision;
        private System.Windows.Forms.ToolStripMenuItem cmsWritten;
        private System.Windows.Forms.ToolStripMenuItem cmsStreet;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cmsIssueLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cmsViewLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem cmsViewPersonHS;
    }
}