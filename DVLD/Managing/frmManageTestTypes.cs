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
    public partial class frmManageTestTypes : Form
    {
        DataTable TestTypesDataTable;

        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void _RefreshList()
        {
            TestTypesDataTable = clsTestType.TestTypesList();

            dgvTestTypes.DataSource = TestTypesDataTable;

            lblRowsCount.Text = "# Rows : " + dgvTestTypes.Rows.Count;
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshList();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmsEditTest_Click(object sender, EventArgs e)
        {
            frmUpdateTestType Frm = new frmUpdateTestType((int)dgvTestTypes.CurrentRow.Cells[0].Value);
            Frm.ShowDialog();
            _RefreshList();
        }
    }
}
