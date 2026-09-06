namespace DVLD
{
    partial class frmScheduleTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleTest));
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblRetakeTestID = new System.Windows.Forms.Label();
            this.lblRetakeTestFees = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ctrlTestDetails1 = new DVLD.ctrlTestDetails();
            this.gbRetakeTest = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tcScheduleTest = new Guna.UI2.WinForms.Guna2TabControl();
            this.PageScheduleTest = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.PageRetakeTest = new System.Windows.Forms.TabPage();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.gbRetakeTest.SuspendLayout();
            this.tcScheduleTest.SuspendLayout();
            this.PageScheduleTest.SuspendLayout();
            this.PageRetakeTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(334, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Fees :";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFees.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalFees.ForeColor = System.Drawing.Color.Black;
            this.lblTotalFees.Location = new System.Drawing.Point(448, 57);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(31, 21);
            this.lblTotalFees.TabIndex = 12;
            this.lblTotalFees.Text = "???";
            // 
            // lblRetakeTestID
            // 
            this.lblRetakeTestID.AutoSize = true;
            this.lblRetakeTestID.BackColor = System.Drawing.Color.Transparent;
            this.lblRetakeTestID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblRetakeTestID.ForeColor = System.Drawing.Color.Black;
            this.lblRetakeTestID.Location = new System.Drawing.Point(172, 104);
            this.lblRetakeTestID.Name = "lblRetakeTestID";
            this.lblRetakeTestID.Size = new System.Drawing.Size(31, 21);
            this.lblRetakeTestID.TabIndex = 11;
            this.lblRetakeTestID.Text = "???";
            // 
            // lblRetakeTestFees
            // 
            this.lblRetakeTestFees.AutoSize = true;
            this.lblRetakeTestFees.BackColor = System.Drawing.Color.Transparent;
            this.lblRetakeTestFees.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblRetakeTestFees.ForeColor = System.Drawing.Color.Black;
            this.lblRetakeTestFees.Location = new System.Drawing.Point(172, 57);
            this.lblRetakeTestFees.Name = "lblRetakeTestFees";
            this.lblRetakeTestFees.Size = new System.Drawing.Size(31, 21);
            this.lblRetakeTestFees.TabIndex = 10;
            this.lblRetakeTestFees.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "R.TApp ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(31, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "R.TApp Fees  :";
            // 
            // ctrlTestDetails1
            // 
            this.ctrlTestDetails1.BoxTitle = "Test Type";
            this.ctrlTestDetails1.ChangeDateValue = new System.DateTime(2026, 8, 10, 14, 28, 20, 304);
            this.ctrlTestDetails1.DateEnabled = true;
            this.ctrlTestDetails1.Location = new System.Drawing.Point(6, 6);
            this.ctrlTestDetails1.Name = "ctrlTestDetails1";
            this.ctrlTestDetails1.Size = new System.Drawing.Size(618, 550);
            this.ctrlTestDetails1.TabIndex = 0;
            this.ctrlTestDetails1.TestFees = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ctrlTestDetails1.TestImage = ((System.Drawing.Image)(resources.GetObject("ctrlTestDetails1.TestImage")));
            this.ctrlTestDetails1.Title = "Schedule Test";
            // 
            // gbRetakeTest
            // 
            this.gbRetakeTest.BorderRadius = 15;
            this.gbRetakeTest.Controls.Add(this.label6);
            this.gbRetakeTest.Controls.Add(this.label5);
            this.gbRetakeTest.Controls.Add(this.lblTotalFees);
            this.gbRetakeTest.Controls.Add(this.label1);
            this.gbRetakeTest.Controls.Add(this.lblRetakeTestID);
            this.gbRetakeTest.Controls.Add(this.lblRetakeTestFees);
            this.gbRetakeTest.Enabled = false;
            this.gbRetakeTest.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRetakeTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbRetakeTest.Location = new System.Drawing.Point(6, 6);
            this.gbRetakeTest.Name = "gbRetakeTest";
            this.gbRetakeTest.Size = new System.Drawing.Size(645, 176);
            this.gbRetakeTest.TabIndex = 128;
            this.gbRetakeTest.Text = "Retake Test Info";
            // 
            // tcScheduleTest
            // 
            this.tcScheduleTest.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcScheduleTest.Controls.Add(this.PageScheduleTest);
            this.tcScheduleTest.Controls.Add(this.PageRetakeTest);
            this.tcScheduleTest.ItemSize = new System.Drawing.Size(185, 40);
            this.tcScheduleTest.Location = new System.Drawing.Point(12, 12);
            this.tcScheduleTest.Name = "tcScheduleTest";
            this.tcScheduleTest.SelectedIndex = 0;
            this.tcScheduleTest.Size = new System.Drawing.Size(853, 620);
            this.tcScheduleTest.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcScheduleTest.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcScheduleTest.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcScheduleTest.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcScheduleTest.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcScheduleTest.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcScheduleTest.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcScheduleTest.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcScheduleTest.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcScheduleTest.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcScheduleTest.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcScheduleTest.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcScheduleTest.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcScheduleTest.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcScheduleTest.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcScheduleTest.TabButtonSize = new System.Drawing.Size(185, 40);
            this.tcScheduleTest.TabIndex = 129;
            this.tcScheduleTest.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // PageScheduleTest
            // 
            this.PageScheduleTest.Controls.Add(this.btnNext);
            this.PageScheduleTest.Controls.Add(this.ctrlTestDetails1);
            this.PageScheduleTest.Location = new System.Drawing.Point(189, 4);
            this.PageScheduleTest.Name = "PageScheduleTest";
            this.PageScheduleTest.Padding = new System.Windows.Forms.Padding(3);
            this.PageScheduleTest.Size = new System.Drawing.Size(660, 612);
            this.PageScheduleTest.TabIndex = 0;
            this.PageScheduleTest.Text = "Schedule Test Details";
            this.PageScheduleTest.UseVisualStyleBackColor = true;
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
            this.btnNext.Location = new System.Drawing.Point(538, 567);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnNext.Size = new System.Drawing.Size(115, 38);
            this.btnNext.TabIndex = 97;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // PageRetakeTest
            // 
            this.PageRetakeTest.Controls.Add(this.btnBack);
            this.PageRetakeTest.Controls.Add(this.gbRetakeTest);
            this.PageRetakeTest.Location = new System.Drawing.Point(189, 4);
            this.PageRetakeTest.Name = "PageRetakeTest";
            this.PageRetakeTest.Padding = new System.Windows.Forms.Padding(3);
            this.PageRetakeTest.Size = new System.Drawing.Size(660, 612);
            this.PageRetakeTest.TabIndex = 1;
            this.PageRetakeTest.Text = "Retake Test Info";
            this.PageRetakeTest.UseVisualStyleBackColor = true;
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
            this.btnBack.Location = new System.Drawing.Point(538, 567);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBack.Size = new System.Drawing.Size(115, 38);
            this.btnBack.TabIndex = 107;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnSave.Image = global::DVLD.Properties.Resources.diskette;
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(725, 637);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(115, 38);
            this.btnSave.TabIndex = 131;
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
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.Image = global::DVLD.Properties.Resources.close;
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(602, 637);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(115, 38);
            this.btnClose.TabIndex = 130;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 683);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcScheduleTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScheduleTest";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Test";
            this.Load += new System.EventHandler(this.frmScheduleTest_Load);
            this.gbRetakeTest.ResumeLayout(false);
            this.gbRetakeTest.PerformLayout();
            this.tcScheduleTest.ResumeLayout(false);
            this.PageScheduleTest.ResumeLayout(false);
            this.PageRetakeTest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTestDetails ctrlTestDetails1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblRetakeTestID;
        private System.Windows.Forms.Label lblRetakeTestFees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GroupBox gbRetakeTest;
        private Guna.UI2.WinForms.Guna2TabControl tcScheduleTest;
        private System.Windows.Forms.TabPage PageScheduleTest;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.TabPage PageRetakeTest;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}