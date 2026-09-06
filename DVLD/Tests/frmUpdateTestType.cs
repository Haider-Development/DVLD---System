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
    public partial class frmUpdateTestType : Form
    {
        private int _TestTypeID;
        private clsTestType _TestType;

        public frmUpdateTestType(int TestTypeID)
        {
            InitializeComponent();

            _TestTypeID = TestTypeID;
        }

        private void _LoadData()
        {
            _TestType = clsTestType.FindTestType(_TestTypeID);

            if (_TestType != null)
            {
                lblID.Text = _TestType.TestTypeID.ToString();
                txtTitle.Text = _TestType.TestTypeTitle.ToString();
                txtDescription.Text = _TestType.TestTypeDescription;
                txtFees.Text = _TestType.TestFees.ToString();
            }

            else
                clsMessageDialog.Show($"Couldn't find Test Type With LDLApplicationID : [{_TestTypeID}]", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        private void frmUpdateTestType_Load(object sender, EventArgs e)
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

            _TestType.TestTypeTitle = txtTitle.Text.Trim();
            _TestType.TestTypeDescription = txtDescription.Text.Trim();
            _TestType.TestFees = Convert.ToDecimal(txtFees.Text.Trim());

            if (_TestType.Save())
                clsMessageDialog.Show("Test Type has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                clsMessageDialog.Show("An error occured while saving data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
