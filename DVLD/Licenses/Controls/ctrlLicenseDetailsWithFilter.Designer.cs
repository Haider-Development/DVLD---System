namespace DVLD
{
    partial class ctrlLicenseDetailsWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlLicenseDetails1 = new DVLD.ctrlLicenseDetails();
            this.btnFindLicense = new Guna.UI2.WinForms.Guna2Button();
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(62, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "License ID :";
            // 
            // ctrlLicenseDetails1
            // 
            this.ctrlLicenseDetails1.LicenseClassID = 0;
            this.ctrlLicenseDetails1.Location = new System.Drawing.Point(3, 110);
            this.ctrlLicenseDetails1.Name = "ctrlLicenseDetails1";
            this.ctrlLicenseDetails1.PersonID = 0;
            this.ctrlLicenseDetails1.Size = new System.Drawing.Size(960, 452);
            this.ctrlLicenseDetails1.TabIndex = 0;
            // 
            // btnFindLicense
            // 
            this.btnFindLicense.BackColor = System.Drawing.Color.Transparent;
            this.btnFindLicense.BorderRadius = 15;
            this.btnFindLicense.CheckedState.FillColor = System.Drawing.Color.Aqua;
            this.btnFindLicense.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindLicense.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindLicense.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindLicense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindLicense.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFindLicense.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindLicense.ForeColor = System.Drawing.Color.White;
            this.btnFindLicense.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFindLicense.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnFindLicense.Image = global::DVLD.Properties.Resources.id__4_;
            this.btnFindLicense.ImageSize = new System.Drawing.Size(45, 45);
            this.btnFindLicense.Location = new System.Drawing.Point(534, 46);
            this.btnFindLicense.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindLicense.Name = "btnFindLicense";
            this.btnFindLicense.Size = new System.Drawing.Size(51, 44);
            this.btnFindLicense.TabIndex = 20;
            this.btnFindLicense.Click += new System.EventHandler(this.btnFindLicense_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.Transparent;
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
            this.txtFilter.Location = new System.Drawing.Point(187, 52);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.Size = new System.Drawing.Size(296, 34);
            this.txtFilter.TabIndex = 18;
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // gbFilter
            // 
            this.gbFilter.BorderColor = System.Drawing.Color.DimGray;
            this.gbFilter.BorderRadius = 15;
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.btnFindLicense);
            this.gbFilter.Controls.Add(this.txtFilter);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.gbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(960, 101);
            this.gbFilter.TabIndex = 21;
            this.gbFilter.Text = "Filter";
            // 
            // ctrlLicenseDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlLicenseDetails1);
            this.Name = "ctrlLicenseDetailsWithFilter";
            this.Size = new System.Drawing.Size(963, 561);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlLicenseDetails ctrlLicenseDetails1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnFindLicense;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private Guna.UI2.WinForms.Guna2GroupBox gbFilter;
    }
}
