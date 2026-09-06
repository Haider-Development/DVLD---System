using DVLD_BusinessLayer;
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
    public partial class frmManageLDLApplications : Form
    {
        private DataTable _LDLApplicationsDataTable;

        private clsLDLApplication LDLApplication;

        public frmManageLDLApplications()
        {
            InitializeComponent();
        }

        private void _RefreshList()
        {
            _LDLApplicationsDataTable = clsLDLApplicationView.LDLApplciationsList_View();

            dgvLDLApplications.DataSource = _LDLApplicationsDataTable;
            lblRowsCount.Text = "# Rows : " + dgvLDLApplications.Rows.Count.ToString();

            cbFilter.SelectedIndex = 0;
        }

        private void frmManageLDLApplications_Load(object sender, EventArgs e)
        {
            _RefreshList();
        }

        private void _FilterData()
        {
            if (string.IsNullOrWhiteSpace(txtFilter.Text.Trim()) || cbFilter.Text == "None")
            {
                _LDLApplicationsDataTable.DefaultView.RowFilter = "";
                lblRowsCount.Text = "# Rows : " + dgvLDLApplications.Rows.Count.ToString();
                return;
            }

            string FilterColumn = cbFilter.Text.Trim();
            string FilterValue = txtFilter.Text.Trim();

            if (FilterColumn == "L.D.LApplicationID")
            {
                if (int.TryParse(FilterValue, out int PersonID))
                    _LDLApplicationsDataTable.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, PersonID);

                else
                    _LDLApplicationsDataTable.DefaultView.RowFilter = "1 = 0";
            }

            else
                _LDLApplicationsDataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, FilterValue);

            lblRowsCount.Text = "# Rows Count : " + dgvLDLApplications.Rows.Count.ToString();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplication Frm = new frmLocalDrivingLicenseApplication(-1);
            Frm.ShowDialog();
            _RefreshList();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Clear();
            txtFilter.Visible = (cbFilter.Text != "None");

            if (txtFilter.Visible)
                txtFilter.Focus();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _FilterData();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "L.D.LApplicationID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void cmsEdit_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplication Frm = new frmLocalDrivingLicenseApplication((int)dgvLDLApplications.CurrentRow.Cells[0].Value);
            Frm.ShowDialog();
            _RefreshList();
        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {
            int LDLApplicationID = (int)dgvLDLApplications.CurrentRow.Cells[0].Value;

            if (clsMessageDialog.Show($"Are You sure you want to Delete Application with ID : [{LDLApplicationID}]?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsLDLApplication.DeleteLDLApplication(LDLApplicationID))
                {
                    clsMessageDialog.Show($"Application with ID : [{LDLApplicationID}] has been Deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _RefreshList();
                }

                else
                    clsMessageDialog.Show($"Cannot Delete Application with ID : [{LDLApplicationID}]!", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmsCancel_Click(object sender, EventArgs e)
        {
            int LDLApplicationID = (int)dgvLDLApplications.CurrentRow.Cells[0].Value;

            if (clsMessageDialog.Show($"Are You sure you want to Cancel Application with ID : [{LDLApplicationID}]?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                LDLApplication = clsLDLApplication.FindLDLApplication(LDLApplicationID);

                LDLApplication.ApplicationStatus = 2;

                if (LDLApplication.Save())
                {
                    clsMessageDialog.Show($"Application with ID : [{LDLApplicationID}] has been Canceld successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _RefreshList();
                }

                else
                    clsMessageDialog.Show($"Cannot Cancel Application with ID : [{LDLApplicationID}]!", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmsViewAppDetails_Click(object sender, EventArgs e)
        {
            frmApplicationDetails Frm = new frmApplicationDetails((int)dgvLDLApplications.CurrentRow.Cells[0].Value);
            Frm.ShowDialog();
        }

        private void cmsVision_Click(object sender, EventArgs e)
        {
            frmTestAppointments Frm = new frmTestAppointments((int)dgvLDLApplications.CurrentRow.Cells[0].Value, 1);
            Frm.ShowDialog();
            _RefreshList();
        }

        private void cmsWritten_Click(object sender, EventArgs e)
        {
            frmTestAppointments Frm = new frmTestAppointments((int)dgvLDLApplications.CurrentRow.Cells[0].Value, 2);
            Frm.ShowDialog();
            _RefreshList();
        }

        private void cmsStreet_Click(object sender, EventArgs e)
        {
            frmTestAppointments Frm = new frmTestAppointments((int)dgvLDLApplications.CurrentRow.Cells[0].Value, 3);
            Frm.ShowDialog();
            _RefreshList();
        }

        private void cmsSettigns_Opening(object sender, CancelEventArgs e)
        {
            string Status = (string)dgvLDLApplications.CurrentRow.Cells["Status"].Value;

            if (Status == "Completed")
            {
                cmsEdit.Enabled = false;
                cmsDelete.Enabled = false;
                cmsCancel.Enabled = false;
                cmsScheduleTest.Enabled = false;
                cmsIssueLicense.Enabled = false;
                cmsViewLicense.Enabled = true;
                return;
            }

            else if (Status == "Cancelled")
            {
                cmsDelete.Enabled = true;
                cmsEdit.Enabled = false;
                cmsCancel.Enabled = false;
                cmsScheduleTest.Enabled = false;
                return;
            }

            else
            {
                cmsEdit.Enabled = true;
                cmsDelete.Enabled = true;
                cmsCancel.Enabled = true;
                cmsScheduleTest.Enabled = true;
                cmsIssueLicense.Enabled = false;
                cmsViewLicense.Enabled = false;
            }

            cmsVision.Enabled = false;
            cmsWritten.Enabled = false;
            cmsStreet.Enabled = false;

            int PassedTests = (int)dgvLDLApplications.CurrentRow.Cells["Passed Tests"].Value;

            switch (PassedTests)
            {
                case 0:
                    {
                        cmsVision.Enabled = true;
                        cmsWritten.Enabled = false;
                        cmsStreet.Enabled = false;
                        break;
                    }

                case 1:
                    {
                        cmsVision.Enabled = false;
                        cmsWritten.Enabled = true;
                        cmsStreet.Enabled = false;
                        break;
                    }

                case 2:
                    {
                        cmsVision.Enabled = false;
                        cmsWritten.Enabled = false;
                        cmsStreet.Enabled = true;
                        break;
                    }

                case 3:
                    {
                        cmsScheduleTest.Enabled = false;
                        cmsIssueLicense.Enabled = true;
                        break;
                    }
            }

            int LDLApplicationID = (int)dgvLDLApplications.CurrentRow.Cells["L.D.LApplicationID"].Value;
            int ApplicationID = clsLDLApplication.GetApplicationIDByLDLApplicationID(LDLApplicationID);

            if (clsLicense.IsLicenseExits(ApplicationID))
            {
                cmsIssueLicense.Enabled = false;
                cmsViewLicense.Enabled = true;
            }

            else
            {
                cmsViewLicense.Enabled = false;
            }
        }

        private void cmsIssueLicense_Click(object sender, EventArgs e)
        {
            int LDLApplicationID = (int)dgvLDLApplications.CurrentRow.Cells["L.D.LApplicationID"].Value;

            frmIssueDrivingLicense Frm = new frmIssueDrivingLicense(LDLApplicationID);
            Frm.ShowDialog();
            _RefreshList();
        }

        private void cmsViewLicense_Click(object sender, EventArgs e)
        {
            int LDLApplicationID = (int)dgvLDLApplications.CurrentRow.Cells["L.D.LApplicationID"].Value;
            clsLDLApplication _TempLDL = clsLDLApplication.FindLDLApplication(LDLApplicationID);

            int LicenseID = clsLicense.GetLicenseIDByApplicationID(_TempLDL.ApplicationID);

            frmViewLicenseDetails Frm = new frmViewLicenseDetails(LicenseID);
            Frm.ShowDialog();
        }

        private void cmsViewPersonHS_Click(object sender, EventArgs e)
        {
            int LDLApplicationID = (int)dgvLDLApplications.CurrentRow.Cells["L.D.LApplicationID"].Value;
            int PersonID = clsLDLApplication.GetPersonIDByLDLApplicationID(LDLApplicationID);

            frmViewPersonLicensesHistory Frm = new frmViewPersonLicensesHistory(PersonID);
            Frm.ShowDialog();
        }
    }
}
