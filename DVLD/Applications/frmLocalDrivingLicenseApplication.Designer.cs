namespace DVLD
{
    partial class frmLocalDrivingLicenseApplication
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.tcSubmitLicense = new Guna.UI2.WinForms.Guna2TabControl();
            this.PagePersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.PageApplicationInfo = new System.Windows.Forms.TabPage();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.gbFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbLicenseClasses = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox7 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel15 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox15 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel12 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox12 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox9 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblCreatedByUserID = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRenew = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlPersonCardWithFilter1 = new DVLD.ctrlPersonCardWithFilter();
            this.tcSubmitLicense.SuspendLayout();
            this.PagePersonInfo.SuspendLayout();
            this.PageApplicationInfo.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2Panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox7)).BeginInit();
            this.guna2Panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox15)).BeginInit();
            this.guna2Panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox12)).BeginInit();
            this.guna2Panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox9)).BeginInit();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(841, 629);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(115, 38);
            this.btnClose.TabIndex = 105;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tcSubmitLicense
            // 
            this.tcSubmitLicense.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcSubmitLicense.Controls.Add(this.PagePersonInfo);
            this.tcSubmitLicense.Controls.Add(this.PageApplicationInfo);
            this.tcSubmitLicense.ItemSize = new System.Drawing.Size(150, 40);
            this.tcSubmitLicense.Location = new System.Drawing.Point(4, 4);
            this.tcSubmitLicense.Name = "tcSubmitLicense";
            this.tcSubmitLicense.SelectedIndex = 0;
            this.tcSubmitLicense.Size = new System.Drawing.Size(1091, 621);
            this.tcSubmitLicense.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcSubmitLicense.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcSubmitLicense.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcSubmitLicense.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcSubmitLicense.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcSubmitLicense.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcSubmitLicense.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcSubmitLicense.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcSubmitLicense.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcSubmitLicense.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcSubmitLicense.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcSubmitLicense.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcSubmitLicense.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcSubmitLicense.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcSubmitLicense.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcSubmitLicense.TabButtonSize = new System.Drawing.Size(150, 40);
            this.tcSubmitLicense.TabIndex = 102;
            this.tcSubmitLicense.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcSubmitLicense.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcSubmitLicense_Selecting);
            // 
            // PagePersonInfo
            // 
            this.PagePersonInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.PagePersonInfo.Controls.Add(this.btnNext);
            this.PagePersonInfo.Location = new System.Drawing.Point(154, 4);
            this.PagePersonInfo.Name = "PagePersonInfo";
            this.PagePersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PagePersonInfo.Size = new System.Drawing.Size(933, 613);
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
            this.btnNext.Location = new System.Drawing.Point(814, 568);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnNext.Size = new System.Drawing.Size(115, 38);
            this.btnNext.TabIndex = 97;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // PageApplicationInfo
            // 
            this.PageApplicationInfo.Controls.Add(this.btnBack);
            this.PageApplicationInfo.Controls.Add(this.gbFilter);
            this.PageApplicationInfo.Location = new System.Drawing.Point(154, 4);
            this.PageApplicationInfo.Name = "PageApplicationInfo";
            this.PageApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PageApplicationInfo.Size = new System.Drawing.Size(933, 613);
            this.PageApplicationInfo.TabIndex = 1;
            this.PageApplicationInfo.Text = "Application Info";
            this.PageApplicationInfo.UseVisualStyleBackColor = true;
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
            this.btnBack.Location = new System.Drawing.Point(811, 568);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBack.Size = new System.Drawing.Size(115, 38);
            this.btnBack.TabIndex = 107;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbFilter
            // 
            this.gbFilter.BorderColor = System.Drawing.Color.DimGray;
            this.gbFilter.BorderRadius = 15;
            this.gbFilter.Controls.Add(this.cbLicenseClasses);
            this.gbFilter.Controls.Add(this.guna2Panel1);
            this.gbFilter.Controls.Add(this.guna2Panel7);
            this.gbFilter.Controls.Add(this.guna2Panel15);
            this.gbFilter.Controls.Add(this.guna2Panel12);
            this.gbFilter.Controls.Add(this.guna2Panel9);
            this.gbFilter.Controls.Add(this.lblCreatedByUserID);
            this.gbFilter.Controls.Add(this.lblFees);
            this.gbFilter.Controls.Add(this.lblDate);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.lblApplicationID);
            this.gbFilter.Controls.Add(this.label5);
            this.gbFilter.Controls.Add(this.label4);
            this.gbFilter.Controls.Add(this.label3);
            this.gbFilter.Controls.Add(this.label2);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.gbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbFilter.Location = new System.Drawing.Point(6, 6);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(915, 422);
            this.gbFilter.TabIndex = 56;
            this.gbFilter.Text = "Application Details";
            // 
            // cbLicenseClasses
            // 
            this.cbLicenseClasses.BackColor = System.Drawing.Color.Transparent;
            this.cbLicenseClasses.BorderRadius = 15;
            this.cbLicenseClasses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLicenseClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClasses.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLicenseClasses.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLicenseClasses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLicenseClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLicenseClasses.ItemHeight = 30;
            this.cbLicenseClasses.Location = new System.Drawing.Point(252, 165);
            this.cbLicenseClasses.Name = "cbLicenseClasses";
            this.cbLicenseClasses.Size = new System.Drawing.Size(262, 36);
            this.cbLicenseClasses.TabIndex = 143;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(192, 166);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(46, 36);
            this.guna2Panel1.TabIndex = 142;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::DVLD.Properties.Resources.id;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(0, 1);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(47, 34);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 41;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.guna2Panel7.BorderRadius = 12;
            this.guna2Panel7.BorderThickness = 2;
            this.guna2Panel7.Controls.Add(this.guna2CirclePictureBox7);
            this.guna2Panel7.Location = new System.Drawing.Point(192, 220);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(46, 36);
            this.guna2Panel7.TabIndex = 141;
            // 
            // guna2CirclePictureBox7
            // 
            this.guna2CirclePictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox7.Image = global::DVLD.Properties.Resources.money;
            this.guna2CirclePictureBox7.ImageRotate = 0F;
            this.guna2CirclePictureBox7.Location = new System.Drawing.Point(0, 1);
            this.guna2CirclePictureBox7.Name = "guna2CirclePictureBox7";
            this.guna2CirclePictureBox7.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox7.Size = new System.Drawing.Size(47, 34);
            this.guna2CirclePictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox7.TabIndex = 41;
            this.guna2CirclePictureBox7.TabStop = false;
            // 
            // guna2Panel15
            // 
            this.guna2Panel15.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.guna2Panel15.BorderRadius = 12;
            this.guna2Panel15.BorderThickness = 2;
            this.guna2Panel15.Controls.Add(this.guna2CirclePictureBox15);
            this.guna2Panel15.Location = new System.Drawing.Point(192, 273);
            this.guna2Panel15.Name = "guna2Panel15";
            this.guna2Panel15.Size = new System.Drawing.Size(46, 36);
            this.guna2Panel15.TabIndex = 142;
            // 
            // guna2CirclePictureBox15
            // 
            this.guna2CirclePictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox15.Image = global::DVLD.Properties.Resources.user;
            this.guna2CirclePictureBox15.ImageRotate = 0F;
            this.guna2CirclePictureBox15.Location = new System.Drawing.Point(0, 1);
            this.guna2CirclePictureBox15.Name = "guna2CirclePictureBox15";
            this.guna2CirclePictureBox15.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox15.Size = new System.Drawing.Size(47, 34);
            this.guna2CirclePictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox15.TabIndex = 41;
            this.guna2CirclePictureBox15.TabStop = false;
            // 
            // guna2Panel12
            // 
            this.guna2Panel12.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.guna2Panel12.BorderRadius = 12;
            this.guna2Panel12.BorderThickness = 2;
            this.guna2Panel12.Controls.Add(this.guna2CirclePictureBox12);
            this.guna2Panel12.Location = new System.Drawing.Point(192, 111);
            this.guna2Panel12.Name = "guna2Panel12";
            this.guna2Panel12.Size = new System.Drawing.Size(46, 36);
            this.guna2Panel12.TabIndex = 136;
            // 
            // guna2CirclePictureBox12
            // 
            this.guna2CirclePictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox12.Image = global::DVLD.Properties.Resources.calendar_week;
            this.guna2CirclePictureBox12.ImageRotate = 0F;
            this.guna2CirclePictureBox12.Location = new System.Drawing.Point(0, 1);
            this.guna2CirclePictureBox12.Name = "guna2CirclePictureBox12";
            this.guna2CirclePictureBox12.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox12.Size = new System.Drawing.Size(47, 34);
            this.guna2CirclePictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox12.TabIndex = 41;
            this.guna2CirclePictureBox12.TabStop = false;
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.guna2Panel9.BorderRadius = 12;
            this.guna2Panel9.BorderThickness = 2;
            this.guna2Panel9.Controls.Add(this.guna2CirclePictureBox9);
            this.guna2Panel9.Location = new System.Drawing.Point(192, 58);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Size = new System.Drawing.Size(46, 36);
            this.guna2Panel9.TabIndex = 135;
            // 
            // guna2CirclePictureBox9
            // 
            this.guna2CirclePictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox9.Image = global::DVLD.Properties.Resources.page_number;
            this.guna2CirclePictureBox9.ImageRotate = 0F;
            this.guna2CirclePictureBox9.Location = new System.Drawing.Point(0, 1);
            this.guna2CirclePictureBox9.Name = "guna2CirclePictureBox9";
            this.guna2CirclePictureBox9.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox9.Size = new System.Drawing.Size(47, 34);
            this.guna2CirclePictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox9.TabIndex = 41;
            this.guna2CirclePictureBox9.TabStop = false;
            // 
            // lblCreatedByUserID
            // 
            this.lblCreatedByUserID.AutoSize = true;
            this.lblCreatedByUserID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUserID.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedByUserID.Location = new System.Drawing.Point(248, 282);
            this.lblCreatedByUserID.Name = "lblCreatedByUserID";
            this.lblCreatedByUserID.Size = new System.Drawing.Size(31, 21);
            this.lblCreatedByUserID.TabIndex = 87;
            this.lblCreatedByUserID.Text = "???";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.ForeColor = System.Drawing.Color.Black;
            this.lblFees.Location = new System.Drawing.Point(248, 230);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(31, 21);
            this.lblFees.TabIndex = 86;
            this.lblFees.Text = "???";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(248, 120);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 21);
            this.lblDate.TabIndex = 85;
            this.lblDate.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(88, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 84;
            this.label1.Text = "Created By :";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationID.Location = new System.Drawing.Point(248, 68);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(31, 21);
            this.lblApplicationID.TabIndex = 79;
            this.lblApplicationID.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(74, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 78;
            this.label5.Text = "License Class :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(46, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 21);
            this.label4.TabIndex = 77;
            this.label4.Text = "Application Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(47, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 21);
            this.label3.TabIndex = 76;
            this.label3.Text = "Application Fees :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 75;
            this.label2.Text = "L.D.LApplication ID :";
            // 
            // btnRenew
            // 
            this.btnRenew.BorderRadius = 12;
            this.btnRenew.CheckedState.FillColor = System.Drawing.Color.Green;
            this.btnRenew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRenew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRenew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRenew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRenew.FillColor = System.Drawing.Color.Lime;
            this.btnRenew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRenew.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnRenew.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnRenew.Image = global::DVLD.Properties.Resources.diskette;
            this.btnRenew.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRenew.Location = new System.Drawing.Point(964, 628);
            this.btnRenew.Margin = new System.Windows.Forms.Padding(4);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRenew.Size = new System.Drawing.Size(115, 38);
            this.btnRenew.TabIndex = 106;
            this.btnRenew.Text = "Submit";
            this.btnRenew.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.AutoSize = true;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.FilterSelectedIndex = -1;
            this.ctrlPersonCardWithFilter1.FilterText = "";
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(6, 6);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(920, 462);
            this.ctrlPersonCardWithFilter1.TabIndex = 98;
            // 
            // frmLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 680);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcSubmitLicense);
            this.Controls.Add(this.btnRenew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLocalDrivingLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Local Driving License Application";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplication_Load);
            this.tcSubmitLicense.ResumeLayout(false);
            this.PagePersonInfo.ResumeLayout(false);
            this.PagePersonInfo.PerformLayout();
            this.PageApplicationInfo.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2Panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox7)).EndInit();
            this.guna2Panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox15)).EndInit();
            this.guna2Panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox12)).EndInit();
            this.guna2Panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2TabControl tcSubmitLicense;
        private System.Windows.Forms.TabPage PagePersonInfo;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.TabPage PageApplicationInfo;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2GroupBox gbFilter;
        private System.Windows.Forms.Label lblCreatedByUserID;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnRenew;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel12;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox12;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel15;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox15;
        private Guna.UI2.WinForms.Guna2ComboBox cbLicenseClasses;
    }
}