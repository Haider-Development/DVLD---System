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
    public partial class ctrlLicensesList : UserControl
    {
        private int _DriverID;

        private DataTable _LocalLicensesDataTabel;
        private DataTable _InternationalLicensesDataTable;

        public ctrlLicensesList()
        {
            InitializeComponent();
        }

        private void _LoadLocalLicenses(int DriverID)
        {
            _LocalLicensesDataTabel = clsLicense.ObtainedLicensesList(DriverID);

            dgvLDLicenses.DataSource = _LocalLicensesDataTabel;

            lblRowsCountLocal.Text = "# Rows : " + dgvLDLicenses.Rows.Count;
        }

        private void _LoadInternationalLicenses(int DriverID)
        {
            _InternationalLicensesDataTable = clsInternationalLicense.ObtainedInternationalLicensesList(DriverID);

            dgvIDLicenses.DataSource = _InternationalLicensesDataTable;

            lblRowsCountInternational.Text = "# Rows : " + dgvIDLicenses.Rows.Count;
        }

        public void LoadData(int PersonID)
        {
            _DriverID = clsDriver.GetDriverID(PersonID);

            if (_DriverID != -1)
            {
                _LoadLocalLicenses(_DriverID);
                _LoadInternationalLicenses(_DriverID);
            }
        }

        private void cmsViewLocal_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvLDLicenses.CurrentRow.Cells["Lic.ID"].Value;

            frmViewLicenseDetails Frm = new frmViewLicenseDetails(LicenseID);
            Frm.ShowDialog();
        }

        private void cmsViewInternational_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = (int)dgvIDLicenses.CurrentRow.Cells["Int.License ID"].Value;

            frmViewInternationalLicenseDetails Frm = new frmViewInternationalLicenseDetails(InternationalLicenseID);
            Frm.ShowDialog();
        }
    }
}
