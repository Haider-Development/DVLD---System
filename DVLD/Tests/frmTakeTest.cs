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
    public partial class frmTakeTest : Form
    {
        private enum enTestTypes { VisionTest = 1, WrittenTest = 2, StreetTest = 3 }
        private enTestTypes _TestType = enTestTypes.VisionTest;

        private clsTest _Test;
        private clsTestAppointment _Appointment;
        private clsApplication _Application;
        private clsLDLApplication _LDLApplication;

        private int _LDLApplicationID;
        private int _AppointmentID;
        private int _Trials;
        private int _RetakeTestID;

        string _TextToShow = "";

        public frmTakeTest()
        {
            InitializeComponent();
        }

        public frmTakeTest(int LDLApplicationID, int AppointmentID, int Trials, int TestTypeID, int RetakeTestID = -1)
        {
            InitializeComponent();
            _LDLApplicationID = LDLApplicationID;
            _AppointmentID = AppointmentID;
            _Trials = Trials;
            _TestType = (enTestTypes)TestTypeID;
            _RetakeTestID = RetakeTestID;
        }

        private void _LoadData()
        {
            ctrlTestDetails1.LoadData(_LDLApplicationID, _Trials, (int)_TestType);
            _Test = new clsTest();
            _Appointment = clsTestAppointment.FindTestAppointment(_AppointmentID);

            if (_Appointment != null)
            {
                if (!(_Appointment.AppointmentDate < ctrlTestDetails1.ChangeDateValue))
                    ctrlTestDetails1.ChangeDateValue = _Appointment.AppointmentDate;

                else
                {
                    clsMessageDialog.Show("This appointment Date has expired! ... please schedule another one", "Expierd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clsTestAppointment.DeleteTestAppointment(_AppointmentID);
                    this.Close();
                }
            }


            switch (_TestType)
            {
                case enTestTypes.VisionTest:
                    {
                        _TextToShow = "Vision Test";
                        ctrlTestDetails1.BoxTitle = _TextToShow;
                        ctrlTestDetails1.Title = _TextToShow;
                        ctrlTestDetails1.TestImage = Properties.Resources.eye__1_;
                        break;
                    }

                case enTestTypes.WrittenTest:
                    {
                        _TextToShow = "Written Test";
                        ctrlTestDetails1.BoxTitle = _TextToShow;
                        ctrlTestDetails1.Title = _TextToShow;
                        ctrlTestDetails1.TestImage = Properties.Resources.test_write;
                        break;
                    }

                case enTestTypes.StreetTest:
                    {
                        _TextToShow = "Street Test";
                        ctrlTestDetails1.BoxTitle = _TextToShow;
                        ctrlTestDetails1.Title = _TextToShow;
                        ctrlTestDetails1.TestImage = Properties.Resources.car__1_;
                        break;
                    }
            }

            ctrlTestDetails1.DateEnabled = false;

        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tcTakeTest.SelectedTab == PageScheduleTest)
            {
                clsMessageDialog.Show($"Please move to the next page first and Take Test First!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_Appointment != null)
            {
                if (rbPassed.Checked == false && rbFailed.Checked == false)
                {
                    clsMessageDialog.Show("Set a result to this Test first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (clsMessageDialog.Show("Are You Sure you want to save result?\nNote that you cannot edit the Test Result after saving!",
                "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    _Test.TestAppointmentID = _AppointmentID;
                    _Test.TestResult = rbPassed.Checked ? true : false;
                    _Test.Notes = txtNotes.Text.Trim();
                    _Test.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;

                    if (_Test.Save())
                    {
                        clsMessageDialog.Show("Test result has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _Appointment.IsLocked = true;
                        _Appointment.Save();

                        if (_RetakeTestID != -1)
                        {
                            _Application = clsApplication.FindApplication(_RetakeTestID);

                            _Application.ApplicationStatus = 3;
                            _Application.LastStatusDate = DateTime.Now;

                            _Application.Save();
                        }

                        this.Close();
                    }

                    else
                        clsMessageDialog.Show("An error occured while saving Test result!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
                clsMessageDialog.Show("An error occured while Retreiving appointment!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcTakeTest.SelectedTab = PageTakeTest;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcTakeTest.SelectedTab = PageScheduleTest;
        }
    }
}
