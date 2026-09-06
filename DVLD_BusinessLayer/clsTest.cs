using System;
using System.Data;
using DVLD_DataAccessLayer;
using Microsoft.SqlServer.Server;

namespace DVLD_BusinessLayer
{
    public class clsTest
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        private bool _AddNew()
        {
            this.TestID = clsTestsDataAccess.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);

            return this.TestAppointmentID != -1;
        }

        public clsTest()
        {
            this.TestAppointmentID = -1;
            this.TestID = -1;
            this.TestResult = false;
            this.Notes = "";
            this.CreatedByUserID = -1;
        }

        protected clsTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestID = TestID;
            this.Notes = Notes;
            this.TestResult = TestResult;
            this.CreatedByUserID = CreatedByUserID;
        }

        public static clsTest FindTest(int TestID)
        {

            int TestAppointmentID = -1, CreatedByUserID = -1;

            string Notes = "";
            bool TestResult = false;

            if (clsTestsDataAccess.FindTest(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new clsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }

            else
            {
                return null;
            }
        }

        public static bool DeleteTest(int TestID)
        {
            return clsTestsDataAccess.DeleteTest(TestID);
        }

        public static DataTable TestsList()
        {
            return clsTestsDataAccess.TestsList();
        }

        public static bool IsTestExist(int TestID)
        {
            return clsTestsDataAccess.IsTestExist(TestID);
        }

        public static bool IsTestResultSuccess(int TestAppointmentID)
        {
            return clsTestsDataAccess.IsTestResultSuccess(TestAppointmentID);
        }

        public static int GetTestID(int TestAppointmentID)
        {
            return clsTestsDataAccess.GetTestID(TestAppointmentID);
        }

        public virtual bool Save()
        {
            return _AddNew();
        }
    }
}
