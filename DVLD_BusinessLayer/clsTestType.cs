using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsTestType
    {
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal TestFees { get; set; }

        private clsTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestFees = TestFees;
        }

        public static clsTestType FindTestType(int TestTypeID)
        {
            string TestTypeTitle = "", TestTypeDescription = "";
            decimal TestFees = -1;

            if (clsTestTypesDataAccess.FindTestType(TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestFees))
                return new clsTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestFees);

            else
                return null;
        }

        private bool _Update()
        {
            return clsTestTypesDataAccess.UpdateTestType(this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestFees);
        }

        public static DataTable TestTypesList()
        {
            return clsTestTypesDataAccess.TestTypesList();
        }

        public static decimal GetTestTypeFees(int TestTypeID)
        {
            return clsTestTypesDataAccess.GetTestTypeFees(TestTypeID);
        }

        public bool Save()
        {
            return _Update();
        }
    }
}
