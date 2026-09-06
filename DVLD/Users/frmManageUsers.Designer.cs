namespace DVLD
{
    partial class frmManageUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRowsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbIsActive = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmsViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmsSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRowsCount
            // 
            this.lblRowsCount.AutoSize = true;
            this.lblRowsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowsCount.ForeColor = System.Drawing.Color.Indigo;
            this.lblRowsCount.Location = new System.Drawing.Point(17, 544);
            this.lblRowsCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRowsCount.Name = "lblRowsCount";
            this.lblRowsCount.Size = new System.Drawing.Size(181, 25);
            this.lblRowsCount.TabIndex = 95;
            this.lblRowsCount.Text = "# Number of Rows :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(14, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 96;
            this.label3.Text = "Filter By :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(473, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 37);
            this.label1.TabIndex = 97;
            this.label1.Text = "Manage Users";
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel11.BorderRadius = 65;
            this.guna2Panel11.BorderThickness = 1;
            this.guna2Panel11.Controls.Add(this.pbImage);
            this.guna2Panel11.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2Panel11.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Panel11.Location = new System.Drawing.Point(497, 10);
            this.guna2Panel11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Size = new System.Drawing.Size(152, 137);
            this.guna2Panel11.TabIndex = 98;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsers.ColumnHeadersHeight = 40;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUsers.ContextMenuStrip = this.cmsSettings;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUsers.GridColor = System.Drawing.Color.Gray;
            this.dgvUsers.Location = new System.Drawing.Point(14, 294);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowTemplate.Height = 35;
            this.dgvUsers.Size = new System.Drawing.Size(1115, 229);
            this.dgvUsers.TabIndex = 99;
            this.dgvUsers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dgvUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.dgvUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dgvUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUsers.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvUsers.ThemeStyle.ReadOnly = true;
            this.dgvUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gray;
            this.dgvUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dgvUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUsers.ThemeStyle.RowsStyle.Height = 35;
            this.dgvUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            // 
            // cmsSettings
            // 
            this.cmsSettings.BackColor = System.Drawing.Color.DarkGray;
            this.cmsSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsSettings.ImageScalingSize = new System.Drawing.Size(38, 38);
            this.cmsSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsViewDetails,
            this.toolStripMenuItem1,
            this.cmsAddNewUser,
            this.cmsEditUser,
            this.cmsDeleteUser,
            this.cmsChangePassword,
            this.toolStripMenuItem2,
            this.cmsSendEmail,
            this.cmsPhoneCall});
            this.cmsSettings.Name = "contextMenuStrip1";
            this.cmsSettings.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsSettings.Size = new System.Drawing.Size(231, 324);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.DimGray;
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(227, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(227, 6);
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
            "User ID",
            "Person ID",
            "Full Name",
            "User Name",
            "Is Active"});
            this.cbFilter.Location = new System.Drawing.Point(110, 245);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(143, 36);
            this.cbFilter.TabIndex = 100;
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
            this.cbIsActive.Location = new System.Drawing.Point(282, 245);
            this.cbIsActive.Margin = new System.Windows.Forms.Padding(4);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(156, 36);
            this.cbIsActive.TabIndex = 101;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsAcitve_SelectedIndexChanged);
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
            this.txtFilter.Location = new System.Drawing.Point(282, 247);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.Size = new System.Drawing.Size(246, 32);
            this.txtFilter.TabIndex = 102;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // cmsViewDetails
            // 
            this.cmsViewDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cmsViewDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsViewDetails.Image = global::DVLD.Properties.Resources.view_details;
            this.cmsViewDetails.Name = "cmsViewDetails";
            this.cmsViewDetails.Size = new System.Drawing.Size(230, 44);
            this.cmsViewDetails.Text = "View Details";
            this.cmsViewDetails.Click += new System.EventHandler(this.cmsViewDetails_Click);
            // 
            // cmsAddNewUser
            // 
            this.cmsAddNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsAddNewUser.Image = global::DVLD.Properties.Resources.user_add;
            this.cmsAddNewUser.Name = "cmsAddNewUser";
            this.cmsAddNewUser.Size = new System.Drawing.Size(230, 44);
            this.cmsAddNewUser.Text = "Add New User";
            this.cmsAddNewUser.Click += new System.EventHandler(this.cmsAddNewUser_Click);
            // 
            // cmsEditUser
            // 
            this.cmsEditUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsEditUser.Image = global::DVLD.Properties.Resources.edit;
            this.cmsEditUser.Name = "cmsEditUser";
            this.cmsEditUser.Size = new System.Drawing.Size(230, 44);
            this.cmsEditUser.Text = "Edit User";
            this.cmsEditUser.Click += new System.EventHandler(this.cmsEditUser_Click);
            // 
            // cmsDeleteUser
            // 
            this.cmsDeleteUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsDeleteUser.Image = global::DVLD.Properties.Resources.user_close;
            this.cmsDeleteUser.Name = "cmsDeleteUser";
            this.cmsDeleteUser.Size = new System.Drawing.Size(230, 44);
            this.cmsDeleteUser.Text = "Delete User";
            this.cmsDeleteUser.Click += new System.EventHandler(this.cmsDeleteUser_Click);
            // 
            // cmsChangePassword
            // 
            this.cmsChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsChangePassword.Image = global::DVLD.Properties.Resources.password;
            this.cmsChangePassword.Name = "cmsChangePassword";
            this.cmsChangePassword.Size = new System.Drawing.Size(230, 44);
            this.cmsChangePassword.Text = "Change Password";
            this.cmsChangePassword.Click += new System.EventHandler(this.cmsChangePassword_Click);
            // 
            // cmsSendEmail
            // 
            this.cmsSendEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsSendEmail.Image = global::DVLD.Properties.Resources.email;
            this.cmsSendEmail.Name = "cmsSendEmail";
            this.cmsSendEmail.Size = new System.Drawing.Size(230, 44);
            this.cmsSendEmail.Text = "Send Email";
            this.cmsSendEmail.Click += new System.EventHandler(this.NotImplementedTool_Click);
            // 
            // cmsPhoneCall
            // 
            this.cmsPhoneCall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsPhoneCall.Image = global::DVLD.Properties.Resources.call_outgoing;
            this.cmsPhoneCall.Name = "cmsPhoneCall";
            this.cmsPhoneCall.Size = new System.Drawing.Size(230, 44);
            this.cmsPhoneCall.Text = "Phone Call";
            this.cmsPhoneCall.Click += new System.EventHandler(this.NotImplementedTool_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.BorderRadius = 50;
            this.pbImage.FillColor = System.Drawing.Color.Transparent;
            this.pbImage.Image = global::DVLD.Properties.Resources.users_config;
            this.pbImage.ImageRotate = 0F;
            this.pbImage.Location = new System.Drawing.Point(10, 5);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(134, 127);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 94;
            this.pbImage.TabStop = false;
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
            this.btnClose.Location = new System.Drawing.Point(1030, 531);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(99, 38);
            this.btnClose.TabIndex = 94;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BorderRadius = 15;
            this.btnAddNewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddNewUser.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnAddNewUser.Image = global::DVLD.Properties.Resources.user_add;
            this.btnAddNewUser.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddNewUser.Location = new System.Drawing.Point(1057, 241);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(72, 45);
            this.btnAddNewUser.TabIndex = 12;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 588);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.guna2Panel11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRowsCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.txtFilter);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            this.guna2Panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.cmsSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAddNewUser;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lblRowsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel11;
        private Guna.UI2.WinForms.Guna2PictureBox pbImage;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsers;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbIsActive;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private System.Windows.Forms.ContextMenuStrip cmsSettings;
        private System.Windows.Forms.ToolStripMenuItem cmsViewDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmsAddNewUser;
        private System.Windows.Forms.ToolStripMenuItem cmsEditUser;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteUser;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cmsSendEmail;
        private System.Windows.Forms.ToolStripMenuItem cmsPhoneCall;
        private System.Windows.Forms.ToolStripMenuItem cmsChangePassword;
    }
}