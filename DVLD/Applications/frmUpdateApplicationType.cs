using DVLD_BusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmUpdateApplicationType : Form
    {
        private int _ApplicationTypeID;
        private clsApplicationType _ApplicationType;

        public frmUpdateApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();

            _ApplicationTypeID = ApplicationTypeID;
        }

        private void _LoadData()
        {
            _ApplicationType = clsApplicationType.FindApplicationType(_ApplicationTypeID);

            if (_ApplicationType != null)
            {
                lblID.Text = _ApplicationType.ApplicationTypeID.ToString();
                txtTitle.Text = _ApplicationType.ApplicationTypeTitle.ToString();
                txtFees.Text = _ApplicationType.ApplicationFees.ToString();
            }

            else
                clsMessageDialog.Show($"Couldn't find Application Type With LDLApplicationID : [{_ApplicationTypeID}]", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void txtSender_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox txtSender = (Guna2TextBox)sender;

            if (string.IsNullOrEmpty(txtSender.Text))
            {
                e.Cancel = true;
                txtSender.Focus();
                errorProvider1.SetError(txtSender, "This field cannot be empty!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSender, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                clsMessageDialog.Show("Check Your Inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _ApplicationType.ApplicationTypeTitle = txtTitle.Text.Trim();
            _ApplicationType.ApplicationFees = Convert.ToDecimal(txtFees.Text.Trim());

            if(_ApplicationType.Save())
                clsMessageDialog.Show("Application Type has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                clsMessageDialog.Show("An error occured while saving data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
