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
    public partial class frmManagePeople : Form
    {
        private DataTable _PeopleDataTable;

        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void _CallAddNewForm()
        {
            frmAddEditPerson Frm = new frmAddEditPerson(-1);
            Frm.ShowDialog();
            _RefreshList();
        }

        private void _FilterData()
        {
            if (string.IsNullOrWhiteSpace(txtFilter.Text.Trim()) || cbFilter.Text == "None")
            {
                _PeopleDataTable.DefaultView.RowFilter = "";
                lblRowsCount.Text = "# Rows : " + dgvPeople.Rows.Count.ToString();
                return;
            }

            string FilterColumn = cbFilter.Text.Trim();
            string FilterValue = txtFilter.Text.Trim();

            string ActualColumnName = FilterColumn.Replace(" ", "");

            if (ActualColumnName == "PersonID")
            {
                if (int.TryParse(FilterValue, out int PersonID))
                    _PeopleDataTable.DefaultView.RowFilter = string.Format("[{0}] = {1}", ActualColumnName, PersonID);

                else
                    _PeopleDataTable.DefaultView.RowFilter = "1 = 0";
            }

            else
                _PeopleDataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", ActualColumnName, FilterValue);

            lblRowsCount.Text = "# Rows Count : " + dgvPeople.Rows.Count.ToString();
        }

        private void _RefreshList()
        {
            _PeopleDataTable = clsPerson.PeopleList();

            dgvPeople.DataSource = _PeopleDataTable;

            if (dgvPeople.Rows.Count > 0)
            {
                dgvPeople.Columns["ImagePath"].Visible = false;
                dgvPeople.Columns["Address"].Visible = false;
            }

            lblRowsCount.Text = "# Rows : " + dgvPeople.Rows.Count.ToString();

            cbFilter.SelectedIndex = 0;
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _RefreshList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            txtFilter.Visible = (cbFilter.Text != "None");

            if (txtFilter.Visible)
                txtFilter.Focus();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Person ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _FilterData();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            _CallAddNewForm();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CallAddNewForm();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson Frm = new frmAddEditPerson((int)dgvPeople.CurrentRow.Cells[0].Value);
            Frm.ShowDialog();
            _RefreshList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;

            if (clsPerson.IsPersonExist(PersonID))
            {
                if (clsMessageDialog.Show($"Are You Sure you want To Delete this Person with Person ID : {PersonID} ?", "Confirm",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    if (clsPerson.DeletePerson(PersonID))
                    {
                        clsMessageDialog.Show($"Person with ID : {PersonID} has been Deleted successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _RefreshList();
                    }

                    else
                        clsMessageDialog.Show($"Person with ID : {PersonID} Cannot be Deleted!", "Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
                clsMessageDialog.Show($"Cannot Find Person with ID : {PersonID}!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void NotImplementedTool_Click(object sender, EventArgs e)
        {
            clsMessageDialog.Show("This Feature isn't Implemented Yet!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails Frm = new frmPersonDetails((int)dgvPeople.CurrentRow.Cells[0].Value);
            Frm.ShowDialog();
        }

    }
}
