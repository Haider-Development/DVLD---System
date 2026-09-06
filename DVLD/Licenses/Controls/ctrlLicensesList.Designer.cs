namespace DVLD
{
    partial class ctrlLicensesList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcLicenseRenew = new Guna.UI2.WinForms.Guna2TabControl();
            this.PageLocal = new System.Windows.Forms.TabPage();
            this.dgvLDLicenses = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsLocal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsViewLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRowsCountLocal = new System.Windows.Forms.Label();
            this.lblLocalLicense = new System.Windows.Forms.Label();
            this.PageInternational = new System.Windows.Forms.TabPage();
            this.dgvIDLicenses = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsInternational = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsViewInternational = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRowsCountInternational = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tcLicenseRenew.SuspendLayout();
            this.PageLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLicenses)).BeginInit();
            this.cmsLocal.SuspendLayout();
            this.PageInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIDLicenses)).BeginInit();
            this.cmsInternational.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcLicenseRenew
            // 
            this.tcLicenseRenew.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcLicenseRenew.Controls.Add(this.PageLocal);
            this.tcLicenseRenew.Controls.Add(this.PageInternational);
            this.tcLicenseRenew.ItemSize = new System.Drawing.Size(150, 40);
            this.tcLicenseRenew.Location = new System.Drawing.Point(3, 43);
            this.tcLicenseRenew.Name = "tcLicenseRenew";
            this.tcLicenseRenew.SelectedIndex = 0;
            this.tcLicenseRenew.Size = new System.Drawing.Size(1198, 286);
            this.tcLicenseRenew.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcLicenseRenew.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcLicenseRenew.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcLicenseRenew.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcLicenseRenew.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcLicenseRenew.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcLicenseRenew.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcLicenseRenew.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcLicenseRenew.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcLicenseRenew.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcLicenseRenew.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcLicenseRenew.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcLicenseRenew.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcLicenseRenew.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcLicenseRenew.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcLicenseRenew.TabButtonSize = new System.Drawing.Size(150, 40);
            this.tcLicenseRenew.TabIndex = 26;
            this.tcLicenseRenew.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // PageLocal
            // 
            this.PageLocal.Controls.Add(this.dgvLDLicenses);
            this.PageLocal.Controls.Add(this.lblRowsCountLocal);
            this.PageLocal.Controls.Add(this.lblLocalLicense);
            this.PageLocal.Location = new System.Drawing.Point(154, 4);
            this.PageLocal.Name = "PageLocal";
            this.PageLocal.Padding = new System.Windows.Forms.Padding(3);
            this.PageLocal.Size = new System.Drawing.Size(1040, 278);
            this.PageLocal.TabIndex = 0;
            this.PageLocal.Text = "Local";
            this.PageLocal.UseVisualStyleBackColor = true;
            // 
            // dgvLDLicenses
            // 
            this.dgvLDLicenses.AllowUserToAddRows = false;
            this.dgvLDLicenses.AllowUserToDeleteRows = false;
            this.dgvLDLicenses.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLDLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLDLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLDLicenses.ColumnHeadersHeight = 40;
            this.dgvLDLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLDLicenses.ContextMenuStrip = this.cmsLocal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLDLicenses.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLDLicenses.GridColor = System.Drawing.Color.Gray;
            this.dgvLDLicenses.Location = new System.Drawing.Point(7, 33);
            this.dgvLDLicenses.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLDLicenses.Name = "dgvLDLicenses";
            this.dgvLDLicenses.ReadOnly = true;
            this.dgvLDLicenses.RowHeadersVisible = false;
            this.dgvLDLicenses.RowTemplate.Height = 35;
            this.dgvLDLicenses.Size = new System.Drawing.Size(1026, 208);
            this.dgvLDLicenses.TabIndex = 15;
            this.dgvLDLicenses.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvLDLicenses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLDLicenses.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dgvLDLicenses.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.dgvLDLicenses.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.dgvLDLicenses.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLDLicenses.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvLDLicenses.ThemeStyle.ReadOnly = true;
            this.dgvLDLicenses.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gray;
            this.dgvLDLicenses.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.dgvLDLicenses.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLDLicenses.ThemeStyle.RowsStyle.Height = 35;
            this.dgvLDLicenses.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvLDLicenses.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            // 
            // cmsLocal
            // 
            this.cmsLocal.BackColor = System.Drawing.Color.DarkGray;
            this.cmsLocal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsLocal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsLocal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsViewLocal});
            this.cmsLocal.Name = "contextMenuStrip1";
            this.cmsLocal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsLocal.Size = new System.Drawing.Size(243, 42);
            // 
            // cmsViewLocal
            // 
            this.cmsViewLocal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cmsViewLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsViewLocal.Image = global::DVLD.Properties.Resources.view_details;
            this.cmsViewLocal.Name = "cmsViewLocal";
            this.cmsViewLocal.Size = new System.Drawing.Size(242, 38);
            this.cmsViewLocal.Text = "View License Details";
            this.cmsViewLocal.Click += new System.EventHandler(this.cmsViewLocal_Click);
            // 
            // lblRowsCountLocal
            // 
            this.lblRowsCountLocal.AutoSize = true;
            this.lblRowsCountLocal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowsCountLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblRowsCountLocal.Location = new System.Drawing.Point(2, 250);
            this.lblRowsCountLocal.Name = "lblRowsCountLocal";
            this.lblRowsCountLocal.Size = new System.Drawing.Size(174, 25);
            this.lblRowsCountLocal.TabIndex = 14;
            this.lblRowsCountLocal.Text = "# Number Of Rows";
            // 
            // lblLocalLicense
            // 
            this.lblLocalLicense.AutoSize = true;
            this.lblLocalLicense.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicense.ForeColor = System.Drawing.Color.Black;
            this.lblLocalLicense.Location = new System.Drawing.Point(2, 4);
            this.lblLocalLicense.Name = "lblLocalLicense";
            this.lblLocalLicense.Size = new System.Drawing.Size(199, 25);
            this.lblLocalLicense.TabIndex = 13;
            this.lblLocalLicense.Text = "Local Licenses History";
            // 
            // PageInternational
            // 
            this.PageInternational.Controls.Add(this.dgvIDLicenses);
            this.PageInternational.Controls.Add(this.lblRowsCountInternational);
            this.PageInternational.Controls.Add(this.label2);
            this.PageInternational.Location = new System.Drawing.Point(154, 4);
            this.PageInternational.Name = "PageInternational";
            this.PageInternational.Padding = new System.Windows.Forms.Padding(3);
            this.PageInternational.Size = new System.Drawing.Size(1040, 278);
            this.PageInternational.TabIndex = 1;
            this.PageInternational.Text = "International";
            this.PageInternational.UseVisualStyleBackColor = true;
            // 
            // dgvIDLicenses
            // 
            this.dgvIDLicenses.AllowUserToAddRows = false;
            this.dgvIDLicenses.AllowUserToDeleteRows = false;
            this.dgvIDLicenses.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvIDLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIDLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvIDLicenses.ColumnHeadersHeight = 40;
            this.dgvIDLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvIDLicenses.ContextMenuStrip = this.cmsInternational;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIDLicenses.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvIDLicenses.GridColor = System.Drawing.Color.Gray;
            this.dgvIDLicenses.Location = new System.Drawing.Point(7, 40);
            this.dgvIDLicenses.Margin = new System.Windows.Forms.Padding(4);
            this.dgvIDLicenses.Name = "dgvIDLicenses";
            this.dgvIDLicenses.ReadOnly = true;
            this.dgvIDLicenses.RowHeadersVisible = false;
            this.dgvIDLicenses.RowTemplate.Height = 35;
            this.dgvIDLicenses.Size = new System.Drawing.Size(1026, 208);
            this.dgvIDLicenses.TabIndex = 18;
            this.dgvIDLicenses.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvIDLicenses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvIDLicenses.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dgvIDLicenses.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.dgvIDLicenses.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.dgvIDLicenses.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvIDLicenses.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvIDLicenses.ThemeStyle.ReadOnly = true;
            this.dgvIDLicenses.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gray;
            this.dgvIDLicenses.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.dgvIDLicenses.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvIDLicenses.ThemeStyle.RowsStyle.Height = 35;
            this.dgvIDLicenses.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvIDLicenses.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            // 
            // cmsInternational
            // 
            this.cmsInternational.BackColor = System.Drawing.Color.DarkGray;
            this.cmsInternational.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsInternational.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsInternational.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsViewInternational});
            this.cmsInternational.Name = "contextMenuStrip1";
            this.cmsInternational.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsInternational.Size = new System.Drawing.Size(243, 42);
            // 
            // cmsViewInternational
            // 
            this.cmsViewInternational.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cmsViewInternational.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsViewInternational.Image = global::DVLD.Properties.Resources.view_details_big;
            this.cmsViewInternational.Name = "cmsViewInternational";
            this.cmsViewInternational.Size = new System.Drawing.Size(242, 38);
            this.cmsViewInternational.Text = "View License Details";
            this.cmsViewInternational.Click += new System.EventHandler(this.cmsViewInternational_Click);
            // 
            // lblRowsCountInternational
            // 
            this.lblRowsCountInternational.AutoSize = true;
            this.lblRowsCountInternational.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRowsCountInternational.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblRowsCountInternational.Location = new System.Drawing.Point(2, 250);
            this.lblRowsCountInternational.Name = "lblRowsCountInternational";
            this.lblRowsCountInternational.Size = new System.Drawing.Size(174, 25);
            this.lblRowsCountInternational.TabIndex = 17;
            this.lblRowsCountInternational.Text = "# Number Of Rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "International Licenses History";
            // 
            // gbFilter
            // 
            this.gbFilter.BorderColor = System.Drawing.Color.DimGray;
            this.gbFilter.BorderRadius = 15;
            this.gbFilter.Controls.Add(this.tcLicenseRenew);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.gbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(1204, 334);
            this.gbFilter.TabIndex = 57;
            this.gbFilter.Text = "Driver\'s Licenses";
            // 
            // ctrlLicensesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilter);
            this.Name = "ctrlLicensesList";
            this.Size = new System.Drawing.Size(1212, 340);
            this.tcLicenseRenew.ResumeLayout(false);
            this.PageLocal.ResumeLayout(false);
            this.PageLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLicenses)).EndInit();
            this.cmsLocal.ResumeLayout(false);
            this.PageInternational.ResumeLayout(false);
            this.PageInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIDLicenses)).EndInit();
            this.cmsInternational.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TabControl tcLicenseRenew;
        private System.Windows.Forms.TabPage PageLocal;
        private System.Windows.Forms.TabPage PageInternational;
        private Guna.UI2.WinForms.Guna2GroupBox gbFilter;
        private System.Windows.Forms.Label lblRowsCountLocal;
        private System.Windows.Forms.Label lblLocalLicense;
        private System.Windows.Forms.Label lblRowsCountInternational;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLDLicenses;
        private Guna.UI2.WinForms.Guna2DataGridView dgvIDLicenses;
        private System.Windows.Forms.ContextMenuStrip cmsLocal;
        private System.Windows.Forms.ToolStripMenuItem cmsViewLocal;
        private System.Windows.Forms.ContextMenuStrip cmsInternational;
        private System.Windows.Forms.ToolStripMenuItem cmsViewInternational;
    }
}
