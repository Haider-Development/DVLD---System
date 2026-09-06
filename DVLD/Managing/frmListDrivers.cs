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
    public partial class frmListDrivers : Form
    {
        private DataTable _DriversListDataTable;

        public frmListDrivers()
        {
            InitializeComponent();
        }

        private void _FilterData()
        {
            if (string.IsNullOrWhiteSpace(txtFilter.Text.Trim()) || cbFilter.Text == "None")
            {
                _DriversListDataTable.DefaultView.RowFilter = "";
                lblRowsCount.Text = "# Rows : " + dgvDrivers.Rows.Count.ToString();
                return;
            }

            string FilterColumn = cbFilter.Text.Trim();
            string FilterValue = txtFilter.Text.Trim();

            string ActualColumnName = FilterColumn.Replace(" ", "");

            if (ActualColumnName == "PersonID" || ActualColumnName == "DriverID")
            {
                if (int.TryParse(FilterValue, out int ID))
                    _DriversListDataTable.DefaultView.RowFilter = string.Format("[{0}] = {1}", ActualColumnName, ID);

                else
                    _DriversListDataTable.DefaultView.RowFilter = "1 = 0";
            }

            else
                _DriversListDataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", ActualColumnName, FilterValue);

            lblRowsCount.Text = "# Rows : " + dgvDrivers.Rows.Count.ToString();
        }

        private void _LoadData()
        {
            _DriversListDataTable = clsDriver.DriversList_View();

            dgvDrivers.DataSource = _DriversListDataTable;

            lblRowsCount.Text = "# Rows : " + dgvDrivers.Rows.Count;

            cbFilter.SelectedIndex = 0;

            if (dgvDrivers.Rows.Count > 0)
            {
                dgvDrivers.Columns[0].HeaderText = "Driver ID";
                dgvDrivers.Columns[1].HeaderText = "Person ID";
                dgvDrivers.Columns[2].HeaderText = "National No";
                dgvDrivers.Columns[3].HeaderText = "Full Name";
                dgvDrivers.Columns[4].HeaderText = "Created Date";
                dgvDrivers.Columns[5].HeaderText = "Active Licenses Count";
            }
        }

        private void frmListDrivers_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _FilterData();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = (cbFilter.Text == "None") ? false : true;

            txtFilter.Clear();
            txtFilter.Focus();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Driver ID" || cbFilter.Text == "Person ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void cmsViewPersonDetails_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvDrivers.CurrentRow.Cells["PersonID"].Value;

            frmPersonDetails Frm = new frmPersonDetails(PersonID);
            Frm.ShowDialog();
        }

        private void cmsViewLicensesHistory_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvDrivers.CurrentRow.Cells["PersonID"].Value;

            frmViewPersonLicensesHistory Frm = new frmViewPersonLicensesHistory(PersonID);
            Frm.ShowDialog();
        }
    }
}
