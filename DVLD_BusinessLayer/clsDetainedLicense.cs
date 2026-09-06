using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsDetainedLicense
    {
        private enum enMode : sbyte { enAddNewMode = 1, enUpdateMode = 2 }
        private enMode _Mode = enMode.enAddNewMode;

        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }

        private bool _AddNew()
        {
            this.DetainID = clsDetainedLicensesDataAccess.AddNewDetain(this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID);

            return this.DetainID != -1;
        }

        private bool _Update()
        {
            return clsDetainedLicensesDataAccess.UpdateDetain(this.DetainID, this.IsReleased, this.ReleaseDate,
                this.ReleasedByUserID, this.ReleaseApplicationID);
        }

        public clsDetainedLicense()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = new DateTime();
            this.FineFees = -1;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = new DateTime();
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;

            _Mode = enMode.enAddNewMode;
        }

        private clsDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID,
            bool IsReleased, DateTime? ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;

            _Mode = enMode.enUpdateMode;
        }

        public static clsDetainedLicense FindDetain(int DetainID)
        {
            int LicenseID = -1, CreatedByUserID = -1, ReleasedByUserID = -1, ReleaseApplicationID = -1;

            DateTime DetainDate = new DateTime();
            DateTime? ReleaseDate = new DateTime();

            bool IsReleased = false;

            decimal FineFees = -1;

            if (clsDetainedLicensesDataAccess.FindDetain(DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID,
                ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID,
                IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }

            else
            {
                return null;
            }
        }

        public static DataTable DetainedLicensesList()
        {
            return clsDetainedLicensesDataAccess.DetainedLicensesList();
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainedLicensesDataAccess.IsLicenseDetained(LicenseID);
        }

        public static int GetDetainID(int LicenseID)
        {
            return clsDetainedLicensesDataAccess.GetDetainID(LicenseID);
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
