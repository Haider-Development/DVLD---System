namespace DVLD
{
    partial class frmViewPersonLicensesHistory
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
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.ctrlPersonCard1 = new DVLD.ctrlPersonCard();
            this.ctrlLicensesList1 = new DVLD.ctrlLicensesList();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel11.BorderRadius = 80;
            this.guna2Panel11.BorderThickness = 1;
            this.guna2Panel11.Controls.Add(this.pbImage);
            this.guna2Panel11.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2Panel11.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Panel11.Location = new System.Drawing.Point(973, 12);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Size = new System.Drawing.Size(194, 180);
            this.guna2Panel11.TabIndex = 95;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 300;
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(12, 12);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(905, 322);
            this.ctrlPersonCard1.TabIndex = 2;
            // 
            // ctrlLicensesList1
            // 
            this.ctrlLicensesList1.Location = new System.Drawing.Point(12, 369);
            this.ctrlLicensesList1.Name = "ctrlLicensesList1";
            this.ctrlLicensesList1.Size = new System.Drawing.Size(1211, 342);
            this.ctrlLicensesList1.TabIndex = 1;
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
            this.btnClose.Location = new System.Drawing.Point(1174, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(39, 31);
            this.btnClose.TabIndex = 96;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.BorderRadius = 65;
            this.pbImage.FillColor = System.Drawing.Color.Transparent;
            this.pbImage.Image = global::DVLD.Properties.Resources.driver__2_;
            this.pbImage.ImageRotate = 0F;
            this.pbImage.Location = new System.Drawing.Point(5, 5);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(180, 170);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 94;
            this.pbImage.TabStop = false;
            // 
            // frmViewPersonLicensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 713);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2Panel11);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.ctrlLicensesList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewPersonLicensesHistory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licenses History";
            this.Load += new System.EventHandler(this.frmViewPersonLicensesHistory_Load);
            this.guna2Panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ctrlLicensesList ctrlLicensesList1;
        private ctrlPersonCard ctrlPersonCard1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel11;
        private Guna.UI2.WinForms.Guna2PictureBox pbImage;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}