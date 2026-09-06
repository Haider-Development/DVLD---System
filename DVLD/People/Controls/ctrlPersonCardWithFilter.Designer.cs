namespace DVLD
{
    partial class ctrlPersonCardWithFilter
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
            this.ctrlPersonCard1 = new DVLD.ctrlPersonCard();
            this.gbFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnFindPerson = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewPerson = new Guna.UI2.WinForms.Guna2Button();
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonCard1.Location = new System.Drawing.Point(11, 111);
            this.ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(905, 348);
            this.ctrlPersonCard1.TabIndex = 2;
            // 
            // gbFilter
            // 
            this.gbFilter.BorderRadius = 15;
            this.gbFilter.Controls.Add(this.btnFindPerson);
            this.gbFilter.Controls.Add(this.btnAddNewPerson);
            this.gbFilter.Controls.Add(this.txtFilter);
            this.gbFilter.Controls.Add(this.cbFilter);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbFilter.Location = new System.Drawing.Point(11, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(905, 93);
            this.gbFilter.TabIndex = 3;
            this.gbFilter.Text = "Filter";
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnFindPerson.BorderRadius = 15;
            this.btnFindPerson.CheckedState.FillColor = System.Drawing.Color.Aqua;
            this.btnFindPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindPerson.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFindPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindPerson.ForeColor = System.Drawing.Color.White;
            this.btnFindPerson.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFindPerson.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnFindPerson.Image = global::DVLD.Properties.Resources.person_boy__2_;
            this.btnFindPerson.ImageSize = new System.Drawing.Size(40, 40);
            this.btnFindPerson.Location = new System.Drawing.Point(615, 42);
            this.btnFindPerson.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(50, 40);
            this.btnFindPerson.TabIndex = 19;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewPerson.BorderRadius = 15;
            this.btnAddNewPerson.CheckedState.FillColor = System.Drawing.Color.Green;
            this.btnAddNewPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewPerson.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddNewPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPerson.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddNewPerson.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnAddNewPerson.Image = global::DVLD.Properties.Resources.person_boy;
            this.btnAddNewPerson.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddNewPerson.Location = new System.Drawing.Point(673, 42);
            this.btnAddNewPerson.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(50, 40);
            this.btnAddNewPerson.TabIndex = 18;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
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
            this.txtFilter.Location = new System.Drawing.Point(334, 44);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.Size = new System.Drawing.Size(251, 34);
            this.txtFilter.TabIndex = 17;
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.BorderColor = System.Drawing.Color.Silver;
            this.cbFilter.BorderRadius = 15;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbFilter.ItemHeight = 30;
            this.cbFilter.Items.AddRange(new object[] {
            "Person ID",
            "National No"});
            this.cbFilter.Location = new System.Drawing.Point(176, 45);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(148, 36);
            this.cbFilter.TabIndex = 16;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(90, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Find By :";
            // 
            // ctrlPersonCardWithFilter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Name = "ctrlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(927, 462);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private Guna.UI2.WinForms.Guna2GroupBox gbFilter;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPerson;
        private Guna.UI2.WinForms.Guna2Button btnFindPerson;
    }
}
