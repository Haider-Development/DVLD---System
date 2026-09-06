using System;
using System.Data;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using DVLD_DataAccessLayer;

namespace DVLD_BusinessLayer
{
    public class clsInternationalLicense
    {
        private enum enMode : sbyte { enAddNewMode = 1, enUpdateMode = 2 };
        private enMode _Mode = enMode.enAddNewMode;

        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public int DriverID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsInternationalLicense()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = false;
            this.CreatedByUserID = -1;

            _Mode = enMode.enAddNewMode;
        }

        private clsInternationalLicense(int InternatioanlLicenseID, int ApplicationID, int DriverID,
            int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternatioanlLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;

            _Mode = enMode.enUpdateMode;
        }

        private bool _AddNew()
        {
            this.InternationalLicenseID = clsInternationalLicensesDataAccess.AddNewInternationalLicense(this.ApplicationID,
                this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

            return this.InternationalLicenseID != -1;
        }

        private bool _Update()
        {
            return clsInternationalLicensesDataAccess.UpdateInternationalLicense(this.InternationalLicenseID, this.IsActive);
        }

        public static clsInternationalLicense FindInternatioanlLicense(int InternationalLicenseID)
        {
            int ApplicationID = -1, DriverID = -1, IssuedUsingLocalLicenseID = -1, CreatedByUserID = -1;

            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;

            bool IsActive = false;

            if (clsInternationalLicensesDataAccess.FindInternatioanalLicense(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate,
                ref ExpirationDate, ref IsActive, ref CreatedByUserID))
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID,
                    IssueDate, ExpirationDate, IsActive, CreatedByUserID);

            else
                return null;
        }

        public static DataTable ObtainedInternationalLicensesList(int DriverID)
        {
            return clsInternationalLicensesDataAccess.ObtainedInternationalLicensesList(DriverID);
        }

        public static DataTable InternationalLicensesList()
        {
            return clsInternationalLicensesDataAccess.InternationalLicensesList();
        }

        public static bool IsInternationalLicenseExist(int InternationalLicenseID)
        {
            return clsInternationalLicensesDataAccess.IsInternationalLicenseExist(InternationalLicenseID);
        }

        public static bool IsInternationalLicenseExistByDriverID(int DriverID)
        {
            return clsInternationalLicensesDataAccess.IsInternationalLicenseExistByDriverID(DriverID);
        }

        public static bool IsInternationalLicenseExpired(int DriverID)
        {
            return clsInternationalLicensesDataAccess.IsInternationalLicenseExpired(DriverID);
        }

        public static int GetInternationalLicenseID(int DriverID)
        {
            return clsInternationalLicensesDataAccess.GetInternationalLicenseID(DriverID);
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
