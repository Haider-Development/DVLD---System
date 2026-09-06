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
    public partial class frmDashboard : Form
    {
        private DataTable _RecentApplicationsDataTable = new DataTable();

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            _RecentApplicationsDataTable = clsApplication.GetRecentApplications();

            dgvRecentApplications.DataSource = _RecentApplicationsDataTable;

            lblTotalPeople.Text = clsPerson.GetTotalPeopleCount().ToString();
            lblTotalUsers.Text = clsUser.GetTotalUsersCount().ToString();
            lblTotalDrivers.Text = clsDriver.GetTotalDriversCount().ToString();
            lblTotalApplications.Text = clsApplication.GetTotalApplicationsCount().ToString();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

    }
}
