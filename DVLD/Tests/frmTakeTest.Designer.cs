namespace DVLD
{
    partial class frmTakeTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTakeTest));
            this.ctrlApplicationDetails1 = new DVLD.ctrlApplicationDetails();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.tcTakeTest = new Guna.UI2.WinForms.Guna2TabControl();
            this.PageScheduleTest = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlTestDetails1 = new DVLD.ctrlTestDetails();
            this.PageTakeTest = new System.Windows.Forms.TabPage();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.gbRetakeTest = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.rbFailed = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbPassed = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tcTakeTest.SuspendLayout();
            this.PageScheduleTest.SuspendLayout();
            this.PageTakeTest.SuspendLayout();
            this.gbRetakeTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlApplicationDetails1
            // 
            this.ctrlApplicationDetails1.Location = new System.Drawing.Point(580, 133);
            this.ctrlApplicationDetails1.Name = "ctrlApplicationDetails1";
            this.ctrlApplicationDetails1.Size = new System.Drawing.Size(8, 8);
            this.ctrlApplicationDetails1.TabIndex = 1;
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
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnSave.Image = global::DVLD.Properties.Resources.diskette;
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(721, 637);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(115, 38);
            this.btnSave.TabIndex = 134;
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
            this.btnClose.Location = new System.Drawing.Point(598, 637);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(115, 38);
            this.btnClose.TabIndex = 133;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tcTakeTest
            // 
            this.tcTakeTest.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcTakeTest.Controls.Add(this.PageScheduleTest);
            this.tcTakeTest.Controls.Add(this.PageTakeTest);
            this.tcTakeTest.ItemSize = new System.Drawing.Size(185, 40);
            this.tcTakeTest.Location = new System.Drawing.Point(8, 12);
            this.tcTakeTest.Name = "tcTakeTest";
            this.tcTakeTest.SelectedIndex = 0;
            this.tcTakeTest.Size = new System.Drawing.Size(853, 620);
            this.tcTakeTest.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcTakeTest.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcTakeTest.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcTakeTest.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcTakeTest.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcTakeTest.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcTakeTest.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcTakeTest.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcTakeTest.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcTakeTest.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcTakeTest.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcTakeTest.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcTakeTest.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcTakeTest.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcTakeTest.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcTakeTest.TabButtonSize = new System.Drawing.Size(185, 40);
            this.tcTakeTest.TabIndex = 132;
            this.tcTakeTest.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
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
            // PageTakeTest
            // 
            this.PageTakeTest.Controls.Add(this.btnBack);
            this.PageTakeTest.Controls.Add(this.gbRetakeTest);
            this.PageTakeTest.Location = new System.Drawing.Point(189, 4);
            this.PageTakeTest.Name = "PageTakeTest";
            this.PageTakeTest.Padding = new System.Windows.Forms.Padding(3);
            this.PageTakeTest.Size = new System.Drawing.Size(660, 612);
            this.PageTakeTest.TabIndex = 1;
            this.PageTakeTest.Text = "Take Test";
            this.PageTakeTest.UseVisualStyleBackColor = true;
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
            // gbRetakeTest
            // 
            this.gbRetakeTest.BorderRadius = 15;
            this.gbRetakeTest.Controls.Add(this.txtNotes);
            this.gbRetakeTest.Controls.Add(this.rbFailed);
            this.gbRetakeTest.Controls.Add(this.rbPassed);
            this.gbRetakeTest.Controls.Add(this.label1);
            this.gbRetakeTest.Controls.Add(this.label5);
            this.gbRetakeTest.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRetakeTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbRetakeTest.Location = new System.Drawing.Point(6, 6);
            this.gbRetakeTest.Name = "gbRetakeTest";
            this.gbRetakeTest.Size = new System.Drawing.Size(645, 208);
            this.gbRetakeTest.TabIndex = 128;
            this.gbRetakeTest.Text = "Take Test Details";
            // 
            // txtNotes
            // 
            this.txtNotes.Animated = true;
            this.txtNotes.BorderColor = System.Drawing.Color.DarkGray;
            this.txtNotes.BorderRadius = 15;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtNotes.ForeColor = System.Drawing.Color.Navy;
            this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Location = new System.Drawing.Point(118, 94);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderText = "";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(466, 85);
            this.txtNotes.TabIndex = 135;
            // 
            // rbFailed
            // 
            this.rbFailed.AutoSize = true;
            this.rbFailed.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFailed.CheckedState.BorderThickness = 0;
            this.rbFailed.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFailed.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbFailed.CheckedState.InnerOffset = -4;
            this.rbFailed.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rbFailed.Location = new System.Drawing.Point(212, 54);
            this.rbFailed.Name = "rbFailed";
            this.rbFailed.Size = new System.Drawing.Size(70, 25);
            this.rbFailed.TabIndex = 19;
            this.rbFailed.Text = "Failed";
            this.rbFailed.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbFailed.UncheckedState.BorderThickness = 2;
            this.rbFailed.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbFailed.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbPassed
            // 
            this.rbPassed.AutoSize = true;
            this.rbPassed.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbPassed.CheckedState.BorderThickness = 0;
            this.rbPassed.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbPassed.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbPassed.CheckedState.InnerOffset = -4;
            this.rbPassed.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rbPassed.Location = new System.Drawing.Point(118, 54);
            this.rbPassed.Name = "rbPassed";
            this.rbPassed.Size = new System.Drawing.Size(78, 25);
            this.rbPassed.TabIndex = 18;
            this.rbPassed.Text = "Passed";
            this.rbPassed.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbPassed.UncheckedState.BorderThickness = 2;
            this.rbPassed.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbPassed.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Notes :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Result :";
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 680);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcTakeTest);
            this.Controls.Add(this.ctrlApplicationDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTakeTest";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.tcTakeTest.ResumeLayout(false);
            this.PageScheduleTest.ResumeLayout(false);
            this.PageTakeTest.ResumeLayout(false);
            this.gbRetakeTest.ResumeLayout(false);
            this.gbRetakeTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ctrlApplicationDetails ctrlApplicationDetails1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2TabControl tcTakeTest;
        private System.Windows.Forms.TabPage PageScheduleTest;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private ctrlTestDetails ctrlTestDetails1;
        private System.Windows.Forms.TabPage PageTakeTest;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2GroupBox gbRetakeTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2RadioButton rbFailed;
        private Guna.UI2.WinForms.Guna2RadioButton rbPassed;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
    }
}