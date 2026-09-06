namespace DVLD
{
    partial class frmManageApplicationTypes
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
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.dgvApplicationTypes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRowsCount = new System.Windows.Forms.Label();
            this.guna2Panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).BeginInit();
            this.cmsSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel11.BorderRadius = 65;
            this.guna2Panel11.BorderThickness = 1;
            this.guna2Panel11.Controls.Add(this.pbImage);
            this.guna2Panel11.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2Panel11.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Panel11.Location = new System.Drawing.Point(480, 10);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Size = new System.Drawing.Size(152, 137);
            this.guna2Panel11.TabIndex = 96;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.BorderRadius = 50;
            this.pbImage.FillColor = System.Drawing.Color.Transparent;
            this.pbImage.Image = global::DVLD.Properties.Resources.order_config__1_;
            this.pbImage.ImageRotate = 0F;
            this.pbImage.Location = new System.Drawing.Point(9, 5);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(134, 127);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 94;
            this.pbImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(383, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 37);
            this.label1.TabIndex = 95;
            this.label1.Text = "Manage Application Types";
            // 
            // btnClose
            // 
            this.btnClose.BorderColor = System.Drawing.Color.DimGray;
            this.btnClose.BorderRadius = 12;
            this.btnClose.BorderThickness = 1;
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
            this.btnClose.Location = new System.Drawing.Point(1031, 529);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(99, 38);
            this.btnClose.TabIndex = 95;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvApplicationTypes
            // 
            this.dgvApplicationTypes.AllowUserToAddRows = false;
            this.dgvApplicationTypes.AllowUserToDeleteRows = false;
            this.dgvApplicationTypes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvApplicationTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicationTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApplicationTypes.ColumnHeadersHeight = 40;
            this.dgvApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvApplicationTypes.ContextMenuStrip = this.cmsSettings;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApplicationTypes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvApplicationTypes.GridColor = System.Drawing.Color.Gray;
            this.dgvApplicationTypes.Location = new System.Drawing.Point(13, 230);
            this.dgvApplicationTypes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvApplicationTypes.Name = "dgvApplicationTypes";
            this.dgvApplicationTypes.ReadOnly = true;
            this.dgvApplicationTypes.RowHeadersVisible = false;
            this.dgvApplicationTypes.RowTemplate.Height = 35;
            this.dgvApplicationTypes.Size = new System.Drawing.Size(1109, 291);
            this.dgvApplicationTypes.TabIndex = 97;
            this.dgvApplicationTypes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvApplicationTypes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvApplicationTypes.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dgvApplicationTypes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.dgvApplicationTypes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dgvApplicationTypes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvApplicationTypes.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvApplicationTypes.ThemeStyle.ReadOnly = true;
            this.dgvApplicationTypes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gray;
            this.dgvApplicationTypes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dgvApplicationTypes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvApplicationTypes.ThemeStyle.RowsStyle.Height = 35;
            this.dgvApplicationTypes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvApplicationTypes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            // 
            // cmsSettings
            // 
            this.cmsSettings.BackColor = System.Drawing.Color.DarkGray;
            this.cmsSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsSettings.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditApplication});
            this.cmsSettings.Name = "contextMenuStrip1";
            this.cmsSettings.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsSettings.Size = new System.Drawing.Size(213, 42);
            // 
            // cmsEditApplication
            // 
            this.cmsEditApplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsEditApplication.Image = global::DVLD.Properties.Resources.edit;
            this.cmsEditApplication.Name = "cmsEditApplication";
            this.cmsEditApplication.Size = new System.Drawing.Size(212, 38);
            this.cmsEditApplication.Text = "Edit Application";
            this.cmsEditApplication.Click += new System.EventHandler(this.cmsEditApplication_Click);
            // 
            // lblRowsCount
            // 
            this.lblRowsCount.AutoSize = true;
            this.lblRowsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowsCount.ForeColor = System.Drawing.Color.Indigo;
            this.lblRowsCount.Location = new System.Drawing.Point(13, 539);
            this.lblRowsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRowsCount.Name = "lblRowsCount";
            this.lblRowsCount.Size = new System.Drawing.Size(181, 25);
            this.lblRowsCount.TabIndex = 98;
            this.lblRowsCount.Text = "# Number of Rows :";
            // 
            // frmManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 580);
            this.Controls.Add(this.lblRowsCount);
            this.Controls.Add(this.dgvApplicationTypes);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2Panel11);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageApplicationTypes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Application Types";
            this.Load += new System.EventHandler(this.frmManageApplicationTypes_Load);
            this.guna2Panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).EndInit();
            this.cmsSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel11;
        private Guna.UI2.WinForms.Guna2PictureBox pbImage;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2DataGridView dgvApplicationTypes;
        private System.Windows.Forms.Label lblRowsCount;
        private System.Windows.Forms.ContextMenuStrip cmsSettings;
        private System.Windows.Forms.ToolStripMenuItem cmsEditApplication;
    }
}