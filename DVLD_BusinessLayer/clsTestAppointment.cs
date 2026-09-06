using System;
using System.Data;
using DVLD_DataAccessLayer;

namespace DVLD_BusinessLayer
{
    public class clsTestAppointment
    {
        private enum enMode : sbyte { enAddNewMode = 1, enUpdateMode = 2 }
        private enMode _Mode = enMode.enAddNewMode;

        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LDLApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; }

        private bool _AddNew()
        {
            this.TestAppointmentID = clsTestAppointmentsDataAccess.AddNewTestAppointment(this.TestTypeID, this.LDLApplicationID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);

            return this.TestAppointmentID != -1;
        }

        private bool _Update()
        {
            return clsTestAppointmentsDataAccess.UpdateTestAppointment(this.TestAppointmentID, this.AppointmentDate, this.IsLocked);
        }

        public clsTestAppointment()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = -1;
            this.LDLApplicationID = -1;
            this.AppointmentDate = new DateTime();
            this.PaidFees = -1;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestApplicationID = -1;

            _Mode = enMode.enAddNewMode;
        }

        protected clsTestAppointment(int TestAppointmentID, int TestTypeID, int LDLApplicationID, DateTime AppointmentDate,
            decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LDLApplicationID = LDLApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;

            _Mode = enMode.enUpdateMode;
        }

        public static clsTestAppointment FindTestAppointment(int TestAppointmentID)
        {

            int TestTypeID = -1, LDLApplicationID = -1, CreatedByUserID = -1, RetakeTestApplicationID = -1;

            DateTime AppointmentDate = DateTime.Now;

            decimal PaidFees = -1;
            bool IsLocked = false;

            if (clsTestAppointmentsDataAccess.FindTestAppointment(TestAppointmentID, ref TestTypeID, ref LDLApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
            {
                return new clsTestAppointment(TestAppointmentID, TestTypeID, LDLApplicationID, AppointmentDate,
                    PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            }

            else
            {
                return null;
            }
        }

        public static bool DeleteTestAppointment(int TestAppointmentID)
        {
            return clsTestAppointmentsDataAccess.DeleteTestAppointment(TestAppointmentID);
        }

        public static DataTable TestAppointmentsList(int LDLApplicationID, int TestTypeID)
        {
            return clsTestAppointmentsDataAccess.TestAppointmentsList(LDLApplicationID, TestTypeID);
        }

        public static bool IsAppointmentExist(int TestAppointmentID)
        {
            return clsTestAppointmentsDataAccess.IsTestAppointmentExist(TestAppointmentID);
        }

        public static bool IsTestAppointmentLocked(int TestAppointmentID)
        {
            return clsTestAppointmentsDataAccess.IsTestAppointmentLocked(TestAppointmentID);
        }

        public static int GetTestAppointmentID(int LDLApplicationID, int TestTypeID)
        {
            return clsTestAppointmentsDataAccess.GetTestAppointmentID(LDLApplicationID, TestTypeID);
        }

        public static int GetRetakeTestID(int LDLApplicationID, int TestTypeID)
        {
            return clsTestAppointmentsDataAccess.GetRetakeTestID(LDLApplicationID, TestTypeID);
        }

        public static int GetTrialsCount(int LDLApplicationID, int TestTypeID)
        {
            return clsTestAppointmentsDataAccess.GetTrialsCount(LDLApplicationID, TestTypeID);
        }

        public virtual bool Save()
        {
            switch (_Mode)
            {
                case enMode.enAddNewMode:
                    {
                        if (_AddNew())
                        {
                            _Mode = enMode.enUpdateMode;
                            return true;
                        }

                        else
                            return false;
                    }

                case enMode.enUpdateMode:
                    return _Update();
            }

            return false;
        }
    }
}
