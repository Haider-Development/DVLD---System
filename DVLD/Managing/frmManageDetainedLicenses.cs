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
    public partial class frmManageDetainedLicenses : Form
    {
        private DataTable _DetainedLicensesDataTable;

        public frmManageDetainedLicenses()
        {
            InitializeComponent();
        }

        private void _FilterData()
        {
            if (string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                _DetainedLicensesDataTable.DefaultView.RowFilter = "";
                lblRowsCount.Text = "# Rows : " + dgvDetainedLicenses.Rows.Count;
                return;
            }

            string ColumnName = cbFilter.Text;
            string ColumnValue = txtFilter.Text.Trim();

            if (cbFilter.Text == "D.ID" || cbFilter.Text == "L.ID")
            {
                _DetainedLicensesDataTable.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnName, ColumnValue);
                lblRowsCount.Text = "# Rows : " + dgvDetainedLicenses.Rows.Count;
                return;
            }

            _DetainedLicensesDataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", ColumnName, ColumnValue);
            lblRowsCount.Text = "# Rows : " + dgvDetainedLicenses.Rows.Count;
        }

        private void _FilterIsReleased()
        {
            string ColumnName = "Is Released";

            switch (cbIsReleased.Text)
            {
                case "All":
                    {
                        _DetainedLicensesDataTable.DefaultView.RowFilter = "";
                        lblRowsCount.Text = "# Rows : " + dgvDetainedLicenses.Rows.Count;
                        break;
                    }

                case "Yes":
                    {
                        _DetainedLicensesDataTable.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnName, true);
                        lblRowsCount.Text = "# Rows : " + dgvDetainedLicenses.Rows.Count;
                        return;
                    }

                case "No":
                    {
                        _DetainedLicensesDataTable.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnName, false);
                        lblRowsCount.Text = "# Rows : " + dgvDetainedLicenses.Rows.Count;
                        return;
                    }
            }
        }

        private void _RefreshList()
        {
            _DetainedLicensesDataTable = clsDetainedLicense.DetainedLicensesList();

            dgvDetainedLicenses.DataSource = _DetainedLicensesDataTable;

            lblRowsCount.Text = "# Rows : " + dgvDetainedLicenses.Rows.Count;
        }

        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            _RefreshList();

            cbFilter.SelectedIndex = 0;
        }

        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense Frm = new frmReleaseDetainedLicense();
            Frm.ShowDialog();
            _RefreshList();
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense Frm = new frmDetainLicense();
            Frm.ShowDialog();
            _RefreshList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmsViewDetails_Click(object sender, EventArgs e)
        {
            string NationalNumber = dgvDetainedLicenses.CurrentRow.Cells["N.No"].Value.ToString();

            frmPersonDetails Frm = new frmPersonDetails(NationalNumber);
            Frm.ShowDialog();
        }

        private void cmsViewLicenseDetails_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells["L.ID"].Value;

            frmViewLicenseDetails Frm = new frmViewLicenseDetails(LicenseID);
            Frm.ShowDialog();
        }

        private void cmsViewLicensesHistory_Click(object sender, EventArgs e)
        {
            string NationalNumber = dgvDetainedLicenses.CurrentRow.Cells["N.No"].Value.ToString();

            int PersonID = clsPerson.GetPersonID(NationalNumber);

            frmViewPersonLicensesHistory Frm = new frmViewPersonLicensesHistory(PersonID);
            Frm.ShowDialog();
        }

        private void cmsRelease_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells["L.ID"].Value;

            frmReleaseDetainedLicense Frm = new frmReleaseDetainedLicense(LicenseID);
            Frm.ShowDialog();
            _RefreshList();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Clear();
            cbIsReleased.SelectedIndex = 0;

            txtFilter.Visible = (cbFilter.Text != "None" && cbFilter.Text != "Is Released");
            cbIsReleased.Visible = (cbFilter.Text != "None" && cbFilter.Text == "Is Released");

            if(txtFilter.Visible)
                txtFilter.Focus();

            if (cbIsReleased.Visible)
                cbIsReleased.Focus();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _FilterData();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "D.ID" || cbFilter.Text == "L.ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterIsReleased();
        }

        private void cmsSettings_Opening(object sender, CancelEventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells["L.ID"].Value;

            if (clsDetainedLicense.IsLicenseDetained(LicenseID))
                cmsRelease.Enabled = true;

            else
                cmsRelease.Enabled = false;
        }

    }
}
