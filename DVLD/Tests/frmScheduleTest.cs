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
    public partial class frmScheduleTest : Form
    {
        public enum enMode { enAddNewMode = 1, enUpdateMode = 2 }
        private enMode _Mode = enMode.enAddNewMode;

        private enum enTestTypes { VisionTest = 1, WrittenTest = 2, StreetTest = 3 }
        private enTestTypes _TestType = enTestTypes.VisionTest;

        private int _TestAppointmentID;
        private int _LDLApplicationID;
        private int _RetakeTestID = -1;
        private int _Trials;
        private decimal _RetakeTestFees = 0;
        private decimal _TotalFees;

        private string _TextToShow;

        private clsTestAppointment _TestAppointment;
        private clsApplication _Application;
        
        public frmScheduleTest()
        {
            InitializeComponent();
        }

        public frmScheduleTest(int LDLApplicationID, int Trials, int TestTypeID, int ModeValue, int TestAppointmentID = -1)
        {
            InitializeComponent();
            _LDLApplicationID = LDLApplicationID;
            _Trials = Trials;
            _TestType = (enTestTypes)TestTypeID;
            _Mode = (enMode)ModeValue;
            _TestAppointmentID = TestAppointmentID;
        }

        private void _LoadData()
        {
            ctrlTestDetails1.LoadData(_LDLApplicationID, _Trials, (int)_TestType);

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

            switch (_Mode)
            {
                case enMode.enAddNewMode:
                    {
                        _TestAppointment = new clsTestAppointment();

                        if (_Trials > 0)
                        {
                            _Application = new clsApplication();

                            gbRetakeTest.Enabled = true;
                            _RetakeTestFees = clsApplicationType.GetApplicationTypeFees(7);
                        }

                        break;
                    }

                case enMode.enUpdateMode:
                    {
                        _TestAppointment = clsTestAppointment.FindTestAppointment(_TestAppointmentID);
                        
                        if (_TestAppointment != null)
                        {
                            if (!(_TestAppointment.AppointmentDate < ctrlTestDetails1.ChangeDateValue))
                                ctrlTestDetails1.ChangeDateValue = _TestAppointment.AppointmentDate;

                            else
                            {
                                clsMessageDialog.Show("This appointment Date has expired! ... please schedule another one", "Expierd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                clsTestAppointment.DeleteTestAppointment(_TestAppointment.TestAppointmentID);
                                this.Close();
                            }
                        }

                        if (_Trials > 0)
                        {
                            _RetakeTestID = _TestAppointment.RetakeTestApplicationID;
                            _Application = clsApplication.FindApplication(_RetakeTestID);

                            gbRetakeTest.Enabled = true;
                            _RetakeTestFees = clsApplicationType.GetApplicationTypeFees(7);
                            lblRetakeTestID.Text = _RetakeTestID.ToString();
                        }

                        break;
                    }
            }

            _TotalFees = _RetakeTestFees + ctrlTestDetails1.TestFees;
            lblRetakeTestFees.Text = _RetakeTestFees.ToString();
            lblTotalFees.Text = _TotalFees.ToString();
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tcScheduleTest.SelectedTab == PageScheduleTest)
            {
                clsMessageDialog.Show($"Please move to the next page first and Check Retake Test Details if needed!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (_Mode)
            {
                case enMode.enAddNewMode:
                    {
                        _TestAppointment.TestTypeID = (int)_TestType;
                        _TestAppointment.LDLApplicationID = _LDLApplicationID;
                        _TestAppointment.AppointmentDate = ctrlTestDetails1.ChangeDateValue;
                        _TestAppointment.PaidFees = ctrlTestDetails1.TestFees;
                        _TestAppointment.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
                        _TestAppointment.IsLocked = false;
                        
                        if (_Trials > 0)
                        {
                            _Application.ApplicantPersonID = clsLDLApplication.GetPersonIDByLDLApplicationID(_LDLApplicationID);
                            _Application.ApplicationDate = DateTime.Now;
                            _Application.ApplicationTypeID = 7;
                            _Application.ApplicationStatus = 1;
                            _Application.LastStatusDate = DateTime.Now;
                            _Application.PaidFees = _RetakeTestFees;
                            _Application.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;

                            if (!_Application.Save())
                                return;

                            _RetakeTestID = _Application.ApplicationID;
                            _TestAppointment.RetakeTestApplicationID = _RetakeTestID;
                            lblRetakeTestID.Text = _RetakeTestID.ToString();
                        }

                        if (_TestAppointment.Save())
                        {
                            _Mode = enMode.enUpdateMode;
                            clsMessageDialog.Show("Appointment has been added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        else
                        {
                            clsMessageDialog.Show("Appointment cannot be saved!", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                case enMode.enUpdateMode:
                    {
                        _TestAppointment.AppointmentDate = ctrlTestDetails1.ChangeDateValue;

                        if (_TestAppointment.Save())
                        {
                            clsMessageDialog.Show("Appointment has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        else
                        {
                            clsMessageDialog.Show("Appointment cannot be updated!", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcScheduleTest.SelectedTab = PageRetakeTest;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcScheduleTest.SelectedTab = PageScheduleTest;
        }
    }
}
