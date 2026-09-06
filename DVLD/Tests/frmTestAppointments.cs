using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmTestAppointments : Form
    {
        private enum enMode { enAddNewMode = 1, enUpdateMode = 2 }
        private enMode _Mode = enMode.enAddNewMode;

        private enum enTestTypes { VisionTest = 1, WrittenTest = 2, StreetTest = 3 }
        private enTestTypes _TestType = enTestTypes.VisionTest;

        private int _LDLApplicationID;
        private DataTable _TestAppointmentDataTable;

        private string _TextToShow = "";

        private int _RetakeTestID = -1;

        public frmTestAppointments()
        {
            InitializeComponent();
        }

        public frmTestAppointments(int LDLApplicationID, int TestTypeID)
        {
            InitializeComponent();
            _LDLApplicationID = LDLApplicationID;
            _TestType = (enTestTypes)TestTypeID;
        }

        private void _RefreshList()
        {
            _TestAppointmentDataTable = clsTestAppointment.TestAppointmentsList(_LDLApplicationID, (int)_TestType);
            dgvAppointments.DataSource = _TestAppointmentDataTable;

            lblRowsCount.Text = "# Rows : " + dgvAppointments.Rows.Count;
        }

        private void _LoadData()
        {
            ctrlApplicationDetails1.LoadApplicationInfo(_LDLApplicationID);

            _RefreshList();

            switch (_TestType)
            {
                case enTestTypes.VisionTest:
                    {
                        _TextToShow = "Vision Test Appointments";
                        this.Text = _TextToShow;
                        lblTestType.Text = _TextToShow;
                        pbTestType.Image = Properties.Resources.eye__1_;
                        break;
                    }

                case enTestTypes.WrittenTest:
                    {
                        _TextToShow = "Written Test Appointments";
                        this.Text = _TextToShow;
                        lblTestType.Text = _TextToShow;
                        pbTestType.Image = Properties.Resources.test_write;
                        break;
                    }

                case enTestTypes.StreetTest:
                    {
                        _TextToShow = "Street Test Appointments";
                        this.Text = _TextToShow;
                        lblTestType.Text = _TextToShow;
                        pbTestType.Image = Properties.Resources.car__1_;
                        break;
                    }
            }
        }

        private void _ScheduleTest(enMode Mode, int TestAppointmentID = -1)
        {
            int Trials = clsTestAppointment.GetTrialsCount(_LDLApplicationID, (int)_TestType);

            frmScheduleTest Frm = new frmScheduleTest(_LDLApplicationID, Trials, (int)_TestType, (int)_Mode, TestAppointmentID);
            Frm.ShowDialog();
            _RefreshList();
        }

        private void frmTestAppointments_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = clsTestAppointment.GetTestAppointmentID(_LDLApplicationID, (int)_TestType);
            int TestID = clsTest.GetTestID(TestAppointmentID);

            if (TestAppointmentID != -1)
            {
                if (clsTest.IsTestExist(TestID))
                {
                    if (clsTest.IsTestResultSuccess(TestAppointmentID))
                    {
                        clsMessageDialog.Show("This person has already passed this test ... you cannot schedule another appointment!",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    else
                    {
                        _Mode = enMode.enAddNewMode;
                        _ScheduleTest(_Mode, TestAppointmentID);
                        return;
                    }
                }

                if (!clsTestAppointment.IsTestAppointmentLocked(TestAppointmentID))
                {
                    clsMessageDialog.Show("There is already an active appointment ... you cannot schedule another one!",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }

            _Mode = enMode.enAddNewMode;
            _ScheduleTest(_Mode);
        }

        private void cmsEdit_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvAppointments.CurrentRow.Cells["Appointment ID"].Value;

            _Mode = enMode.enUpdateMode;
            _ScheduleTest(_Mode, TestAppointmentID);
        }

        private void cmsTakeTest_Click(object sender, EventArgs e)
        {
            int Trials = clsTestAppointment.GetTrialsCount(_LDLApplicationID, (int)_TestType);
            int AppointmentID = (int)dgvAppointments.CurrentRow.Cells["Appointment ID"].Value;

            int RetakeTestID = clsTestAppointment.GetRetakeTestID(_LDLApplicationID, (int)_TestType);

            if (RetakeTestID != -1)
                _RetakeTestID = RetakeTestID;

            frmTakeTest Frm = new frmTakeTest(_LDLApplicationID, AppointmentID, Trials, (int)_TestType, _RetakeTestID);
            Frm.ShowDialog();
            _RefreshList();
        }

        private void cmsAppointments_Opening(object sender, CancelEventArgs e)
        {
            if ((bool)dgvAppointments.CurrentRow.Cells["Is Locked"].Value == true)
            {
                cmsEdit.Enabled = false;
                cmsTakeTest.Enabled = false;
            }
        }

        private void cmsAppointments_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            cmsEdit.Enabled = true;
            cmsTakeTest.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcTestAppointments.SelectedTab = PageManageTestAppointments;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcTestAppointments.SelectedTab = PageApplicationDetails;
        }
    }
}
