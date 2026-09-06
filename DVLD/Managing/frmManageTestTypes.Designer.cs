namespace DVLD
{
    partial class frmManageTestTypes
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
            this.lblRowsCount = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTestTypes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditTest = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).BeginInit();
            this.cmsSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRowsCount
            // 
            this.lblRowsCount.AutoSize = true;
            this.lblRowsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowsCount.ForeColor = System.Drawing.Color.Indigo;
            this.lblRowsCount.Location = new System.Drawing.Point(13, 541);
            this.lblRowsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRowsCount.Name = "lblRowsCount";
            this.lblRowsCount.Size = new System.Drawing.Size(181, 25);
            this.lblRowsCount.TabIndex = 102;
            this.lblRowsCount.Text = "# Number of Rows :";
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
            this.btnClose.Location = new System.Drawing.Point(1031, 531);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(99, 38);
            this.btnClose.TabIndex = 99;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel11.BorderRadius = 65;
            this.guna2Panel11.BorderThickness = 1;
            this.guna2Panel11.Controls.Add(this.pbImage);
            this.guna2Panel11.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2Panel11.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Panel11.Location = new System.Drawing.Point(480, 12);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Size = new System.Drawing.Size(152, 137);
            this.guna2Panel11.TabIndex = 101;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.BorderRadius = 50;
            this.pbImage.FillColor = System.Drawing.Color.Transparent;
            this.pbImage.Image = global::DVLD.Properties.Resources.test_write;
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
            this.label1.Location = new System.Drawing.Point(425, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 37);
            this.label1.TabIndex = 100;
            this.label1.Text = "Manage Test Types";
            // 
            // dgvTestTypes
            // 
            this.dgvTestTypes.AllowUserToAddRows = false;
            this.dgvTestTypes.AllowUserToDeleteRows = false;
            this.dgvTestTypes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTestTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTestTypes.ColumnHeadersHeight = 40;
            this.dgvTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTestTypes.ContextMenuStrip = this.cmsSettings;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTestTypes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTestTypes.GridColor = System.Drawing.Color.Gray;
            this.dgvTestTypes.Location = new System.Drawing.Point(13, 230);
            this.dgvTestTypes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTestTypes.Name = "dgvTestTypes";
            this.dgvTestTypes.ReadOnly = true;
            this.dgvTestTypes.RowHeadersVisible = false;
            this.dgvTestTypes.RowTemplate.Height = 35;
            this.dgvTestTypes.Size = new System.Drawing.Size(1109, 291);
            this.dgvTestTypes.TabIndex = 103;
            this.dgvTestTypes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvTestTypes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTestTypes.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dgvTestTypes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.dgvTestTypes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dgvTestTypes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTestTypes.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvTestTypes.ThemeStyle.ReadOnly = true;
            this.dgvTestTypes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gray;
            this.dgvTestTypes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dgvTestTypes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTestTypes.ThemeStyle.RowsStyle.Height = 35;
            this.dgvTestTypes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvTestTypes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            // 
            // cmsSettings
            // 
            this.cmsSettings.BackColor = System.Drawing.Color.DarkGray;
            this.cmsSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsSettings.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditTest});
            this.cmsSettings.Name = "contextMenuStrip1";
            this.cmsSettings.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsSettings.Size = new System.Drawing.Size(158, 42);
            // 
            // cmsEditTest
            // 
            this.cmsEditTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmsEditTest.Image = global::DVLD.Properties.Resources.edit;
            this.cmsEditTest.Name = "cmsEditTest";
            this.cmsEditTest.Size = new System.Drawing.Size(157, 38);
            this.cmsEditTest.Text = "Edit Test";
            this.cmsEditTest.Click += new System.EventHandler(this.cmsEditTest_Click);
            // 
            // frmManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 580);
            this.Controls.Add(this.dgvTestTypes);
            this.Controls.Add(this.lblRowsCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2Panel11);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmManageTestTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Test Types";
            this.Load += new System.EventHandler(this.frmManageTestTypes_Load);
            this.guna2Panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).EndInit();
            this.cmsSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRowsCount;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel11;
        private Guna.UI2.WinForms.Guna2PictureBox pbImage;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTestTypes;
        private System.Windows.Forms.ContextMenuStrip cmsSettings;
        private System.Windows.Forms.ToolStripMenuItem cmsEditTest;
    }
}