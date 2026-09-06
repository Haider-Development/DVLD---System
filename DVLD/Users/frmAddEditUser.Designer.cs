namespace DVLD
{
    partial class frmAddEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditUser));
            this.lblAddEdit = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcUserInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.PagePersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlPersonCardWithFilter1 = new DVLD.ctrlPersonCardWithFilter();
            this.PageLoginInfo = new System.Windows.Forms.TabPage();
            this.chkIsActive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox4 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnViewPassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tcUserInfo.SuspendLayout();
            this.PagePersonInfo.SuspendLayout();
            this.PageLoginInfo.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddEdit
            // 
            this.lblAddEdit.AutoSize = true;
            this.lblAddEdit.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAddEdit.Location = new System.Drawing.Point(492, 9);
            this.lblAddEdit.Name = "lblAddEdit";
            this.lblAddEdit.Size = new System.Drawing.Size(200, 37);
            this.lblAddEdit.TabIndex = 1;
            this.lblAddEdit.Text = "Add New User";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tcUserInfo
            // 
            this.tcUserInfo.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcUserInfo.Controls.Add(this.PagePersonInfo);
            this.tcUserInfo.Controls.Add(this.PageLoginInfo);
            this.tcUserInfo.ItemSize = new System.Drawing.Size(180, 40);
            this.tcUserInfo.Location = new System.Drawing.Point(12, 68);
            this.tcUserInfo.Name = "tcUserInfo";
            this.tcUserInfo.SelectedIndex = 0;
            this.tcUserInfo.Size = new System.Drawing.Size(1121, 530);
            this.tcUserInfo.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcUserInfo.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcUserInfo.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcUserInfo.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcUserInfo.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcUserInfo.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcUserInfo.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcUserInfo.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcUserInfo.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcUserInfo.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcUserInfo.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcUserInfo.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcUserInfo.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcUserInfo.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcUserInfo.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcUserInfo.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcUserInfo.TabIndex = 5;
            this.tcUserInfo.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcUserInfo.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcUserInfo_Selecting);
            // 
            // PagePersonInfo
            // 
            this.PagePersonInfo.Controls.Add(this.btnNext);
            this.PagePersonInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.PagePersonInfo.Location = new System.Drawing.Point(184, 4);
            this.PagePersonInfo.Name = "PagePersonInfo";
            this.PagePersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PagePersonInfo.Size = new System.Drawing.Size(933, 522);
            this.PagePersonInfo.TabIndex = 0;
            this.PagePersonInfo.Text = "Person Info";
            this.PagePersonInfo.UseVisualStyleBackColor = true;
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
            this.btnNext.Location = new System.Drawing.Point(811, 477);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnNext.Size = new System.Drawing.Size(115, 38);
            this.btnNext.TabIndex = 96;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.AutoSize = true;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.FilterSelectedIndex = -1;
            this.ctrlPersonCardWithFilter1.FilterText = "";
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(7, 6);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(920, 465);
            this.ctrlPersonCardWithFilter1.TabIndex = 5;
            // 
            // PageLoginInfo
            // 
            this.PageLoginInfo.Controls.Add(this.chkIsActive);
            this.PageLoginInfo.Controls.Add(this.guna2Panel4);
            this.PageLoginInfo.Controls.Add(this.guna2Panel3);
            this.PageLoginInfo.Controls.Add(this.guna2Panel1);
            this.PageLoginInfo.Controls.Add(this.guna2Panel2);
            this.PageLoginInfo.Controls.Add(this.txtConfirmPassword);
            this.PageLoginInfo.Controls.Add(this.txtPassword);
            this.PageLoginInfo.Controls.Add(this.txtUsername);
            this.PageLoginInfo.Controls.Add(this.lblUserID);
            this.PageLoginInfo.Controls.Add(this.label5);
            this.PageLoginInfo.Controls.Add(this.label4);
            this.PageLoginInfo.Controls.Add(this.label3);
            this.PageLoginInfo.Controls.Add(this.label2);
            this.PageLoginInfo.Controls.Add(this.btnViewPassword);
            this.PageLoginInfo.Controls.Add(this.btnBack);
            this.PageLoginInfo.Location = new System.Drawing.Point(184, 4);
            this.PageLoginInfo.Name = "PageLoginInfo";
            this.PageLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PageLoginInfo.Size = new System.Drawing.Size(933, 522);
            this.PageLoginInfo.TabIndex = 1;
            this.PageLoginInfo.Text = "Login Info";
            this.PageLoginInfo.UseVisualStyleBackColor = true;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.CheckedState.BorderRadius = 0;
            this.chkIsActive.CheckedState.BorderThickness = 0;
            this.chkIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.CheckMarkColor = System.Drawing.Color.Blue;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActive.Location = new System.Drawing.Point(235, 268);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(85, 20);
            this.chkIsActive.TabIndex = 103;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkIsActive.UncheckedState.BorderRadius = 0;
            this.chkIsActive.UncheckedState.BorderThickness = 0;
            this.chkIsActive.UncheckedState.FillColor = System.Drawing.Color.LightGray;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.guna2Panel4.BorderRadius = 12;
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Controls.Add(this.guna2CirclePictureBox4);
            this.guna2Panel4.Location = new System.Drawing.Point(178, 199);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(46, 36);
            this.guna2Panel4.TabIndex = 102;
            // 
            // guna2CirclePictureBox4
            // 
            this.guna2CirclePictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox4.Image")));
            this.guna2CirclePictureBox4.ImageRotate = 0F;
            this.guna2CirclePictureBox4.Location = new System.Drawing.Point(0, 1);
            this.guna2CirclePictureBox4.Name = "guna2CirclePictureBox4";
            this.guna2CirclePictureBox4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox4.Size = new System.Drawing.Size(47, 34);
            this.guna2CirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox4.TabIndex = 41;
            this.guna2CirclePictureBox4.TabStop = false;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.guna2Panel3.BorderRadius = 15;
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.guna2CirclePictureBox3);
            this.guna2Panel3.Location = new System.Drawing.Point(178, 147);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(46, 36);
            this.guna2Panel3.TabIndex = 102;
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox3.Image")));
            this.guna2CirclePictureBox3.ImageRotate = 0F;
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(0, 1);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(47, 34);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox3.TabIndex = 41;
            this.guna2CirclePictureBox3.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox2);
            this.guna2Panel1.Location = new System.Drawing.Point(178, 38);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(46, 36);
            this.guna2Panel1.TabIndex = 102;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.Image = global::DVLD.Properties.Resources.page_number;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(0, 1);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(47, 34);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 41;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.guna2Panel2.BorderRadius = 12;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel2.Location = new System.Drawing.Point(178, 92);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(46, 36);
            this.guna2Panel2.TabIndex = 101;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::DVLD.Properties.Resources.user;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(0, 1);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(47, 34);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 41;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtConfirmPassword.BorderRadius = 15;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(234, 201);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.PlaceholderText = "";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(251, 34);
            this.txtConfirmPassword.TabIndex = 99;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(234, 149);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(251, 34);
            this.txtPassword.TabIndex = 98;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderColor = System.Drawing.Color.Silver;
            this.txtUsername.BorderRadius = 15;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(235, 94);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(251, 34);
            this.txtUsername.TabIndex = 97;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblUserID.Location = new System.Drawing.Point(233, 50);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(31, 21);
            this.lblUserID.TabIndex = 58;
            this.lblUserID.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(64, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 57;
            this.label5.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(53, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 56;
            this.label4.Text = "User Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(6, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 21);
            this.label3.TabIndex = 55;
            this.label3.Text = "Confirm Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(73, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 54;
            this.label2.Text = "User ID :";
            // 
            // btnViewPassword
            // 
            this.btnViewPassword.BorderRadius = 12;
            this.btnViewPassword.CheckedState.FillColor = System.Drawing.Color.Orange;
            this.btnViewPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewPassword.FillColor = System.Drawing.Color.Violet;
            this.btnViewPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnViewPassword.HoverState.FillColor = System.Drawing.Color.BlueViolet;
            this.btnViewPassword.Image = global::DVLD.Properties.Resources.eye_open;
            this.btnViewPassword.ImageSize = new System.Drawing.Size(25, 25);
            this.btnViewPassword.Location = new System.Drawing.Point(529, 149);
            this.btnViewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewPassword.Name = "btnViewPassword";
            this.btnViewPassword.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnViewPassword.Size = new System.Drawing.Size(42, 34);
            this.btnViewPassword.TabIndex = 100;
            this.btnViewPassword.Click += new System.EventHandler(this.btnViewPassword_Click);
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
            this.btnBack.Location = new System.Drawing.Point(811, 477);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBack.Size = new System.Drawing.Size(115, 38);
            this.btnBack.TabIndex = 96;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            // btnSave
            // 
            this.btnSave.BorderRadius = 12;
            this.btnSave.CheckedState.FillColor = System.Drawing.Color.Green;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Lime;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnSave.Image = global::DVLD.Properties.Resources.diskette;
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(996, 605);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(115, 38);
            this.btnSave.TabIndex = 95;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnClose.Image = global::DVLD.Properties.Resources.close;
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(873, 605);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(115, 38);
            this.btnClose.TabIndex = 94;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1141, 652);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcUserInfo);
            this.Controls.Add(this.lblAddEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tcUserInfo.ResumeLayout(false);
            this.PagePersonInfo.ResumeLayout(false);
            this.PagePersonInfo.PerformLayout();
            this.PageLoginInfo.ResumeLayout(false);
            this.PageLoginInfo.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddEdit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2TabControl tcUserInfo;
        private System.Windows.Forms.TabPage PagePersonInfo;
        private System.Windows.Forms.TabPage PageLoginInfo;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2Button btnViewPassword;
        private Guna.UI2.WinForms.Guna2CheckBox chkIsActive;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}