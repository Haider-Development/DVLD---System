using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManageInternationalLicensesApplications : Form
    {
        private DataTable _InternationalLicensesList;

        public frmManageInternationalLicensesApplications()
        {
            InitializeComponent();
        }

        private bool _FilterNone()
        {
            if (cbFilter.Text == "None" || string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                _InternationalLicensesList.DefaultView.RowFilter = "";
                lblRowsCount.Text = "# Rows : " + dgvInternationalLicenes.Rows.Count;
                return true;
            }

            return false;
        }

        private void _FilterIDs()
        {
            if (_FilterNone())
                return;

            string ColumnName = cbFilter.Text;
            string ColumnValue = txtFilter.Text.Trim();

            if (cbFilter.Text != "Is Active")
            {
                _InternationalLicensesList.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnName, ColumnValue);
                lblRowsCount.Text = "# Rows : " + dgvInternationalLicenes.Rows.Count;
            }
        }

        private void _FilterIsActive()
        {
            string ColumnName = "Is Active";

            if (cbIsActive.Text == "All")
            {
                _InternationalLicensesList.DefaultView.RowFilter = "";
                lblRowsCount.Text = "# Rows : " + dgvInternationalLicenes.Rows.Count;
                return;
            }

            else if (cbIsActive.Text == "Yes")
            {
                _InternationalLicensesList.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnName, true);
                lblRowsCount.Text = "# Rows : " + dgvInternationalLicenes.Rows.Count;
                return;
            }

            else
            {
                _InternationalLicensesList.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnName, false);
                lblRowsCount.Text = "# Rows : " + dgvInternationalLicenes.Rows.Count;
                return;
            }
        }

        private void _RefreshList()
        {
            _InternationalLicensesList = clsInternationalLicense.InternationalLicensesList();
            dgvInternationalLicenes.DataSource = _InternationalLicensesList;

            lblRowsCount.Text = "# Rows : " + dgvInternationalLicenes.Rows.Count;

            cbFilter.SelectedIndex = 0;
            cbIsActive.SelectedIndex = 0;
        }

        private void frmManageInternationalLicensesApplications_Load(object sender, EventArgs e)
        {
            _RefreshList();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text != "None" && cbFilter.Text != "Is Active")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterNone();

            txtFilter.Clear();

            txtFilter.Visible = (cbFilter.Text != "None" && cbFilter.Text != "Is Active") ? true : false;
            cbIsActive.Visible = (cbFilter.Text == "Is Active") ? true : false;
            cbIsActive.SelectedIndex = 0;
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterIsActive();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _FilterIDs();
        }

        private void btnAddNewInternationalLicense_Click(object sender, EventArgs e)
        {
            frmIssueInternationalLicense Frm = new frmIssueInternationalLicense();
            Frm.ShowDialog();
            _RefreshList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmsViewPersonDetails_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dgvInternationalLicenes.CurrentRow.Cells["Driver ID"].Value;
            int PersonID = clsDriver.GetPersonID(DriverID);

            frmPersonDetails Frm = new frmPersonDetails(PersonID);
            Frm.ShowDialog();
        }

        private void cmsViewLicenseDetails_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = (int)dgvInternationalLicenes.CurrentRow.Cells["Int.License ID"].Value;

            frmViewInternationalLicenseDetails Frm = new frmViewInternationalLicenseDetails(InternationalLicenseID);
            Frm.ShowDialog();
        }

        private void cmsViewPersonLicensesHistory_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dgvInternationalLicenes.CurrentRow.Cells["Driver ID"].Value;
            int PersonID = clsDriver.GetPersonID(DriverID);

            frmViewPersonLicensesHistory Frm = new frmViewPersonLicensesHistory(PersonID);
            Frm.ShowDialog();
        }
    }
}
