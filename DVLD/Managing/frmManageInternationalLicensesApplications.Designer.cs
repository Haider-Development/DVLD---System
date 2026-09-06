namespace DVLD
{
    partial class frmManageInternationalLicensesApplications
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
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbIsActive = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvInternationalLicenes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsViewPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsViewLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsViewPersonLicensesHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRowsCount = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddInternationalLicense = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenes)).BeginInit();
            this.cmsSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.guna2Panel11.SuspendLayout();
            this.SuspendLayout();
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
            "Int.License ID",
            "Application ID",
            "Driver ID",
            "L.License ID",
            "Is Active"});
            this.cbFilter.Location = new System.Drawing.Point(111, 251);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(143, 36);
            this.cbFilter.TabIndex = 120;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // cbIsActive
            // 
            this.cbIsActive.BackColor = System.Drawing.Color.Transparent;
            this.cbIsActive.BorderColor = System.Drawing.Color.Silver;
            this.cbIsActive.BorderRadius = 15;
            this.cbIsActive.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsActive.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsActive.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsActive.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbIsActive.ItemHeight = 30;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(283, 251);
            this.cbIsActive.Margin = new System.Windows.Forms.Padding(4);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(156, 36);
            this.cbIsActive.TabIndex = 121;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // dgvInternationalLicenes
            // 
            this.dgvInternationalLicenes.AllowUserToAddRows = false;
            this.dgvInternationalLicenes.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvInternationalLicenes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternationalLicenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInternationalLicenes.ColumnHeadersHeight = 40;
            this.dgvInternationalLicenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvInternationalLicenes.ContextMenuStrip = this.cmsSettings;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternationalLicenes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInternationalLicenes.GridColor = System.Drawing.Color.Gray;
            this.dgvInternationalLicenes.Location = new System.Drawing.Point(15, 300);
            this.dgvInternationalLicenes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvInternationalLicenes.Name = "dgvInternationalLicenes";
            this.dgvInternationalLicenes.ReadOnly = true;
            this.dgvInternationalLicenes.RowHeadersVisible = false;
            this.dgvInternationalLicenes.RowTemplate.Height = 35;
            this.dgvInternationalLicenes.Size = new System.Drawing.Size(1115, 229);
            this.dgvInternationalLicenes.TabIndex = 119;
            this.dgvInternationalLicenes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvInternationalLicenes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInternationalLicenes.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dgvInternationalLicenes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.dgvInternationalLicenes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInternationalLicenes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvInternationalLicenes.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvInternationalLicenes.ThemeStyle.ReadOnly = true;
            this.dgvInternationalLicenes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gray;
            this.dgvInternationalLicenes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInternationalLicenes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvInternationalLicenes.ThemeStyle.RowsStyle.Height = 35;
            this.dgvInternationalLicenes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvInternationalLicenes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            // 
            // cmsSettings
            // 
            this.cmsSettings.BackColor = System.Drawing.Color.DarkGray;
            this.cmsSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsSettings.ImageScalingSize = new System.Drawing.Size(38, 38);
            this.cmsSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsViewPersonDetails,
            this.toolStripMenuItem1,
            this.cmsViewLicenseDetails,
            this.cmsViewPersonLicensesHistory});
            this.cmsSettings.Name = "contextMenuStrip1";
            this.cmsSettings.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsSettings.Size = new System.Drawing.Size(314, 142);
            // 
            // cmsViewPersonDetails
            // 
            this.cmsViewPersonDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cmsViewPersonDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsViewPersonDetails.Image = global::DVLD.Properties.Resources.view_details;
            this.cmsViewPersonDetails.Name = "cmsViewPersonDetails";
            this.cmsViewPersonDetails.Size = new System.Drawing.Size(313, 44);
            this.cmsViewPersonDetails.Text = "View Details";
            this.cmsViewPersonDetails.Click += new System.EventHandler(this.cmsViewPersonDetails_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.DimGray;
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(310, 6);
            // 
            // cmsViewLicenseDetails
            // 
            this.cmsViewLicenseDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsViewLicenseDetails.Image = global::DVLD.Properties.Resources.view_detail;
            this.cmsViewLicenseDetails.Name = "cmsViewLicenseDetails";
            this.cmsViewLicenseDetails.Size = new System.Drawing.Size(313, 44);
            this.cmsViewLicenseDetails.Text = "View License Details";
            this.cmsViewLicenseDetails.Click += new System.EventHandler(this.cmsViewLicenseDetails_Click);
            // 
            // cmsViewPersonLicensesHistory
            // 
            this.cmsViewPersonLicensesHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsViewPersonLicensesHistory.Image = global::DVLD.Properties.Resources.view_details_big;
            this.cmsViewPersonLicensesHistory.Name = "cmsViewPersonLicensesHistory";
            this.cmsViewPersonLicensesHistory.Size = new System.Drawing.Size(313, 44);
            this.cmsViewPersonLicensesHistory.Text = "View Person Licenses History";
            this.cmsViewPersonLicensesHistory.Click += new System.EventHandler(this.cmsViewPersonLicensesHistory_Click);
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
            this.txtFilter.Location = new System.Drawing.Point(283, 253);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.Size = new System.Drawing.Size(246, 32);
            this.txtFilter.TabIndex = 122;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.BorderRadius = 50;
            this.pbImage.FillColor = System.Drawing.Color.Transparent;
            this.pbImage.Image = global::DVLD.Properties.Resources.world;
            this.pbImage.ImageRotate = 0F;
            this.pbImage.Location = new System.Drawing.Point(10, 5);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.guna2Panel11.Location = new System.Drawing.Point(498, 16);
            this.guna2Panel11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Size = new System.Drawing.Size(152, 137);
            this.guna2Panel11.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(356, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 37);
            this.label1.TabIndex = 117;
            this.label1.Text = "Manage International Licenses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(15, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 116;
            this.label3.Text = "Filter By :";
            // 
            // lblRowsCount
            // 
            this.lblRowsCount.AutoSize = true;
            this.lblRowsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowsCount.ForeColor = System.Drawing.Color.Indigo;
            this.lblRowsCount.Location = new System.Drawing.Point(18, 550);
            this.lblRowsCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRowsCount.Name = "lblRowsCount";
            this.lblRowsCount.Size = new System.Drawing.Size(181, 25);
            this.lblRowsCount.TabIndex = 115;
            this.lblRowsCount.Text = "# Number of Rows :";
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
            this.btnClose.Location = new System.Drawing.Point(1031, 537);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(99, 38);
            this.btnClose.TabIndex = 114;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddInternationalLicense
            // 
            this.btnAddInternationalLicense.BorderRadius = 15;
            this.btnAddInternationalLicense.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddInternationalLicense.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddInternationalLicense.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddInternationalLicense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddInternationalLicense.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddInternationalLicense.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddInternationalLicense.ForeColor = System.Drawing.Color.White;
            this.btnAddInternationalLicense.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddInternationalLicense.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnAddInternationalLicense.Image = global::DVLD.Properties.Resources.order_add;
            this.btnAddInternationalLicense.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddInternationalLicense.Location = new System.Drawing.Point(1058, 247);
            this.btnAddInternationalLicense.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddInternationalLicense.Name = "btnAddInternationalLicense";
            this.btnAddInternationalLicense.Size = new System.Drawing.Size(72, 45);
            this.btnAddInternationalLicense.TabIndex = 113;
            this.btnAddInternationalLicense.Click += new System.EventHandler(this.btnAddNewInternationalLicense_Click);
            // 
            // frmManageInternationalLicensesApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 591);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.dgvInternationalLicenes);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.guna2Panel11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRowsCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddInternationalLicense);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageInternationalLicensesApplications";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List International Licenses Applications";
            this.Load += new System.EventHandler(this.frmManageInternationalLicensesApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenes)).EndInit();
            this.cmsSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.guna2Panel11.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbIsActive;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInternationalLicenes;
        private System.Windows.Forms.ContextMenuStrip cmsSettings;
        private System.Windows.Forms.ToolStripMenuItem cmsViewPersonDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmsViewLicenseDetails;
        private System.Windows.Forms.ToolStripMenuItem cmsViewPersonLicensesHistory;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private Guna.UI2.WinForms.Guna2PictureBox pbImage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRowsCount;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnAddInternationalLicense;
    }
}