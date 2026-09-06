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
    public partial class frmManageUsers : Form
    {
        private DataTable _UsersDataTable;

        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void _CallAddNewForm()
        {
            frmAddEditUser Frm = new frmAddEditUser(-1);
            Frm.ShowDialog();
            _RefreshList();
        }

        private void _FilterData()
        {
            if (string.IsNullOrWhiteSpace(txtFilter.Text.Trim()) || cbFilter.Text == "None")
            {
                _UsersDataTable.DefaultView.RowFilter = "";
                lblRowsCount.Text = "# Rows : " + dgvUsers.Rows.Count.ToString();
                return;
            }

            string FilterColumn = cbFilter.Text.Trim();
            string FilterValue = txtFilter.Text.Trim();

            string ActualColumnName = FilterColumn.Replace(" ", "");

            if (ActualColumnName == "UserID" || ActualColumnName == "PersonID")
            {
                if (int.TryParse(FilterValue, out int PersonID))
                    _UsersDataTable.DefaultView.RowFilter = string.Format("[{0}] = {1}", ActualColumnName, PersonID);

                else
                    _UsersDataTable.DefaultView.RowFilter = "1 = 0";
            }

            else
                _UsersDataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", ActualColumnName, FilterValue);

            lblRowsCount.Text = "# Rows Count : " + dgvUsers.Rows.Count.ToString();
        }

        private void _RefreshList()
        {
            _UsersDataTable = clsUser.UsersList();

            dgvUsers.DataSource = _UsersDataTable;

            lblRowsCount.Text = "# Rows : " + dgvUsers.Rows.Count.ToString();

            cbFilter.SelectedIndex = 0;
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
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
            _FilterData();
            txtFilter.Visible = (cbFilter.Text != "None" && cbFilter.Text != "Is Active");
            cbIsActive.Visible = (cbFilter.Text != "None" && cbFilter.Text == "Is Active");

            if (txtFilter.Visible)
                txtFilter.Focus();

            else if (cbIsActive.Visible)
                cbIsActive.Focus();
        }
        
        private void cbIsAcitve_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ColumnName = cbFilter.Text.Trim();

            string ActualColumnName = ColumnName.Replace(" ", "");

            switch (cbIsActive.Text)
            {
                case "All":
                    {
                        _UsersDataTable.DefaultView.RowFilter = "";
                        break;
                    }

                case "Yes":
                    {
                        _UsersDataTable.DefaultView.RowFilter = string.Format("[{0}] = {1}", ActualColumnName, true);
                        break;
                    }

                case "No":
                    {
                        _UsersDataTable.DefaultView.RowFilter = string.Format("[{0}] = {1}", ActualColumnName, false);
                        break;
                    }
            }

            lblRowsCount.Text = "# Rows : " + dgvUsers.Rows.Count.ToString();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Person ID" || cbFilter.Text == "User ID")
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

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            _CallAddNewForm();
        }

        private void cmsAddNewUser_Click(object sender, EventArgs e)
        {
            _CallAddNewForm();
        }

        private void cmsEditUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser Frm = new frmAddEditUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            Frm.ShowDialog();
            _RefreshList();
        }

        private void cmsDeleteUser_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;

            if (clsUser.IsUserExistsByID(UserID))
            {
                if (clsMessageDialog.Show($"Are You Sure you want To Delete this User with ID : {UserID} ?", "Confirm",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    if (clsGlobalSettings.CurrentUser.UserID == UserID)
                    {
                        clsMessageDialog.Show($"You cannot delete the current user! you can only perform this task with another user account.", "Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (clsUser.DeleteUser(UserID))
                    {
                        clsMessageDialog.Show($"User with ID : {UserID} has been Deleted successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _RefreshList();
                    }

                    else
                        clsMessageDialog.Show($"User with ID : {UserID} Cannot be Deleted!", "Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
                clsMessageDialog.Show($"Cannot Find User with ID : {UserID}!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void NotImplementedTool_Click(object sender, EventArgs e)
        {
            clsMessageDialog.Show("This Feature isn't Implemented Yet!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cmsViewDetails_Click(object sender, EventArgs e)
        {
            frmUserDetails Frm = new frmUserDetails((int)dgvUsers.CurrentRow.Cells[0].Value);
            Frm.ShowDialog();
        }

        private void cmsChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword Frm = new frmChangePassword((int)dgvUsers.CurrentRow.Cells[0].Value);
            Frm.ShowDialog();
        }
    }
}
