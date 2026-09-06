using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsLicense
    {
        private enum enMode : sbyte { enAddNewMode = 1, enUpdateMode = 2 }
        private enMode _Mode = enMode.enAddNewMode;

        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        public clsLicense()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClass = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = -1;
            this.IsActive = false;
            this.IssueReason = 0;
            this.CreatedByUserID = -1;

            _Mode = enMode.enAddNewMode;
        }

        private clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate,
            DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;

            _Mode = enMode.enUpdateMode;
        }

        private bool _AddNew()
        {
            this.LicenseID = clsLicensesDataAccess.AddNewLicense(this.ApplicationID, this.DriverID, this.LicenseClass,
                this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason,
                this.CreatedByUserID);

            return this.LicenseID != -1;
        }

        private bool _Update()
        {
            return clsLicensesDataAccess.UpdateLicense(this.LicenseID, this.IsActive);
        }

        public static clsLicense FindLicense(int LicenseID)
        {
            int ApplicationID = -1, DriverID = -1, LicenseClass = -1, CreatedByUserID = -1;

            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;

            string Notes = "";
            decimal PaidFees = -1;
            bool IsActive = false;
            byte IssueReason = 0;

            if (clsLicensesDataAccess.FindLicense(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate,
                ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes,
                    PaidFees, IsActive, IssueReason, CreatedByUserID);

            else
                return null;
        }

        public static DataTable ObtainedLicensesList(int DriverID)
        {
            return clsLicensesDataAccess.ObtainedLicensesList(DriverID);
        }

        public static bool IsLicenseExits(int ApplicationID)
        {
            return clsLicensesDataAccess.IsLicenseExist(ApplicationID);
        }

        public static bool IsLicenseExistByLicenseID(int LicenseID)
        {
            return clsLicensesDataAccess.IsLicenseExistByLicenseID(LicenseID);
        }

        public static bool IsLicenseExpired(int LicenseID)
        {
            return clsLicensesDataAccess.IsLicenseExpired(LicenseID);
        }

        public static bool IsLicenseValid(int LicenseID)
        {
            return clsLicensesDataAccess.IsLicenseValid(LicenseID);
        }
        
        public static bool IsLicenseExistAndActive(int DriverID, int LicenseClass)
        {
            return clsLicensesDataAccess.IsLicenseExistAndActive(DriverID, LicenseClass);
        }

        public static int GetLicenseIDByApplicationID(int ApplicationID)
        {
            return clsLicensesDataAccess.GetLicenseIDByApplicationID(ApplicationID);
        }

        public bool Save()
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

                        return false;
                    }

                case enMode.enUpdateMode:
                    {
                        return _Update();
                    }
            }

            return false;
        }
    }
}
