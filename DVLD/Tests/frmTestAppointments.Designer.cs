namespace DVLD
{
    partial class frmTestAppointments
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
            this.cmsAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.pbTestType = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTestType = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.tcTestAppointments = new Guna.UI2.WinForms.Guna2TabControl();
            this.PageApplicationDetails = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlApplicationDetails1 = new DVLD.ctrlApplicationDetails();
            this.PageManageTestAppointments = new System.Windows.Forms.TabPage();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvAppointments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblRowsCount = new System.Windows.Forms.Label();
            this.btnAddAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.cmsAppointments.SuspendLayout();
            this.guna2Panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestType)).BeginInit();
            this.tcTestAppointments.SuspendLayout();
            this.PageApplicationDetails.SuspendLayout();
            this.PageManageTestAppointments.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsAppointments
            // 
            this.cmsAppointments.BackColor = System.Drawing.Color.DarkGray;
            this.cmsAppointments.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cmsAppointments.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEdit,
            this.cmsTakeTest});
            this.cmsAppointments.Name = "cmsAppointments";
            this.cmsAppointments.Size = new System.Drawing.Size(162, 80);
            this.cmsAppointments.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.cmsAppointments_Closing);
            this.cmsAppointments.Opening += new System.ComponentModel.CancelEventHandler(this.cmsAppointments_Opening);
            // 
            // cmsEdit
            // 
            this.cmsEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsEdit.Image = global::DVLD.Properties.Resources.edit;
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(161, 38);
            this.cmsEdit.Text = "Edit";
            this.cmsEdit.Click += new System.EventHandler(this.cmsEdit_Click);
            // 
            // cmsTakeTest
            // 
            this.cmsTakeTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsTakeTest.Image = global::DVLD.Properties.Resources.test_write;
            this.cmsTakeTest.Name = "cmsTakeTest";
            this.cmsTakeTest.Size = new System.Drawing.Size(161, 38);
            this.cmsTakeTest.Text = "Take Test";
            this.cmsTakeTest.Click += new System.EventHandler(this.cmsTakeTest_Click);
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel11.BorderRadius = 50;
            this.guna2Panel11.BorderThickness = 1;
            this.guna2Panel11.Controls.Add(this.pbTestType);
            this.guna2Panel11.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2Panel11.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Panel11.Location = new System.Drawing.Point(540, 7);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Size = new System.Drawing.Size(125, 110);
            this.guna2Panel11.TabIndex = 96;
            // 
            // pbTestType
            // 
            this.pbTestType.BackColor = System.Drawing.Color.Transparent;
            this.pbTestType.BorderRadius = 50;
            this.pbTestType.FillColor = System.Drawing.Color.Transparent;
            this.pbTestType.Image = global::DVLD.Properties.Resources.eye__1_;
            this.pbTestType.ImageRotate = 0F;
            this.pbTestType.Location = new System.Drawing.Point(9, 5);
            this.pbTestType.Name = "pbTestType";
            this.pbTestType.Size = new System.Drawing.Size(107, 97);
            this.pbTestType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTestType.TabIndex = 94;
            this.pbTestType.TabStop = false;
            // 
            // lblTestType
            // 
            this.lblTestType.AutoSize = true;
            this.lblTestType.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestType.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTestType.Location = new System.Drawing.Point(453, 113);
            this.lblTestType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestType.Name = "lblTestType";
            this.lblTestType.Size = new System.Drawing.Size(260, 37);
            this.lblTestType.TabIndex = 95;
            this.lblTestType.Text = "Test Appointments";
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
            // tcTestAppointments
            // 
            this.tcTestAppointments.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcTestAppointments.Controls.Add(this.PageApplicationDetails);
            this.tcTestAppointments.Controls.Add(this.PageManageTestAppointments);
            this.tcTestAppointments.ItemSize = new System.Drawing.Size(185, 40);
            this.tcTestAppointments.Location = new System.Drawing.Point(7, 153);
            this.tcTestAppointments.Name = "tcTestAppointments";
            this.tcTestAppointments.SelectedIndex = 0;
            this.tcTestAppointments.Size = new System.Drawing.Size(1206, 570);
            this.tcTestAppointments.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcTestAppointments.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcTestAppointments.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcTestAppointments.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcTestAppointments.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcTestAppointments.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcTestAppointments.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcTestAppointments.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcTestAppointments.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcTestAppointments.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcTestAppointments.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcTestAppointments.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcTestAppointments.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcTestAppointments.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcTestAppointments.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcTestAppointments.TabButtonSize = new System.Drawing.Size(185, 40);
            this.tcTestAppointments.TabIndex = 97;
            this.tcTestAppointments.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // PageApplicationDetails
            // 
            this.PageApplicationDetails.Controls.Add(this.btnNext);
            this.PageApplicationDetails.Controls.Add(this.ctrlApplicationDetails1);
            this.PageApplicationDetails.Location = new System.Drawing.Point(189, 4);
            this.PageApplicationDetails.Name = "PageApplicationDetails";
            this.PageApplicationDetails.Padding = new System.Windows.Forms.Padding(3);
            this.PageApplicationDetails.Size = new System.Drawing.Size(1013, 562);
            this.PageApplicationDetails.TabIndex = 0;
            this.PageApplicationDetails.Text = "Application Details";
            this.PageApplicationDetails.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 12;
            this.btnNext.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.Cyan;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnNext.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnNext.Image = global::DVLD.Properties.Resources.next;
            this.btnNext.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNext.Location = new System.Drawing.Point(891, 515);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnNext.Size = new System.Drawing.Size(115, 38);
            this.btnNext.TabIndex = 97;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlApplicationDetails1
            // 
            this.ctrlApplicationDetails1.Location = new System.Drawing.Point(6, 6);
            this.ctrlApplicationDetails1.Name = "ctrlApplicationDetails1";
            this.ctrlApplicationDetails1.Size = new System.Drawing.Size(990, 502);
            this.ctrlApplicationDetails1.TabIndex = 2;
            // 
            // PageManageTestAppointments
            // 
            this.PageManageTestAppointments.Controls.Add(this.guna2GroupBox1);
            this.PageManageTestAppointments.Controls.Add(this.btnBack);
            this.PageManageTestAppointments.Location = new System.Drawing.Point(189, 4);
            this.PageManageTestAppointments.Name = "PageManageTestAppointments";
            this.PageManageTestAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.PageManageTestAppointments.Size = new System.Drawing.Size(1013, 562);
            this.PageManageTestAppointments.TabIndex = 1;
            this.PageManageTestAppointments.Text = "Manage Test Appointments";
            this.PageManageTestAppointments.UseVisualStyleBackColor = true;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.Controls.Add(this.dgvAppointments);
            this.guna2GroupBox1.Controls.Add(this.lblRowsCount);
            this.guna2GroupBox1.Controls.Add(this.btnAddAppointment);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 6);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1004, 366);
            this.guna2GroupBox1.TabIndex = 112;
            this.guna2GroupBox1.Text = "Appointments";
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointments.ColumnHeadersHeight = 40;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAppointments.ContextMenuStrip = this.cmsAppointments;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppointments.GridColor = System.Drawing.Color.Gray;
            this.dgvAppointments.Location = new System.Drawing.Point(16, 97);
            this.dgvAppointments.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.RowTemplate.Height = 35;
            this.dgvAppointments.Size = new System.Drawing.Size(975, 229);
            this.dgvAppointments.TabIndex = 115;
            this.dgvAppointments.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppointments.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dgvAppointments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.dgvAppointments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAppointments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAppointments.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvAppointments.ThemeStyle.ReadOnly = true;
            this.dgvAppointments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gray;
            this.dgvAppointments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAppointments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAppointments.ThemeStyle.RowsStyle.Height = 35;
            this.dgvAppointments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvAppointments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            // 
            // lblRowsCount
            // 
            this.lblRowsCount.AutoSize = true;
            this.lblRowsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowsCount.ForeColor = System.Drawing.Color.Indigo;
            this.lblRowsCount.Location = new System.Drawing.Point(11, 330);
            this.lblRowsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRowsCount.Name = "lblRowsCount";
            this.lblRowsCount.Size = new System.Drawing.Size(181, 25);
            this.lblRowsCount.TabIndex = 113;
            this.lblRowsCount.Text = "# Number of Rows :";
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BorderRadius = 15;
            this.btnAddAppointment.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.btnAddAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddAppointment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddAppointment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAddAppointment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddAppointment.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnAddAppointment.Image = global::DVLD.Properties.Resources.order_add;
            this.btnAddAppointment.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddAppointment.Location = new System.Drawing.Point(919, 44);
            this.btnAddAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(72, 45);
            this.btnAddAppointment.TabIndex = 112;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 12;
            this.btnBack.CheckedState.FillColor = System.Drawing.Color.Orange;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnBack.Image = global::DVLD.Properties.Resources.back;
            this.btnBack.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBack.Location = new System.Drawing.Point(891, 517);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBack.Size = new System.Drawing.Size(115, 38);
            this.btnBack.TabIndex = 107;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.btnClose.Location = new System.Drawing.Point(1173, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(39, 31);
            this.btnClose.TabIndex = 98;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 730);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcTestAppointments);
            this.Controls.Add(this.guna2Panel11);
            this.Controls.Add(this.lblTestType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTestAppointments";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Appointments";
            this.Load += new System.EventHandler(this.frmTestAppointments_Load);
            this.cmsAppointments.ResumeLayout(false);
            this.guna2Panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestType)).EndInit();
            this.tcTestAppointments.ResumeLayout(false);
            this.PageApplicationDetails.ResumeLayout(false);
            this.PageManageTestAppointments.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ctrlApplicationDetails ctrlApplicationDetails1;
        private System.Windows.Forms.ContextMenuStrip cmsAppointments;
        private System.Windows.Forms.ToolStripMenuItem cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsTakeTest;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel11;
        private Guna.UI2.WinForms.Guna2PictureBox pbTestType;
        private System.Windows.Forms.Label lblTestType;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TabControl tcTestAppointments;
        private System.Windows.Forms.TabPage PageApplicationDetails;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.TabPage PageManageTestAppointments;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAppointments;
        private System.Windows.Forms.Label lblRowsCount;
        private Guna.UI2.WinForms.Guna2Button btnAddAppointment;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}