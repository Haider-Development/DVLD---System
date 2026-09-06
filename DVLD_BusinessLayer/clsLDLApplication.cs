using DVLD_BusinessLayer;
using DVLD_DataAccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsLDLApplication : clsApplication
    {
        private enum enMode : sbyte { enAddNewMode = 1, enUpdateMode = 2 }
        private enMode _Mode = enMode.enAddNewMode;

        public int LDLApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        private bool _AddNew()
        {
            this.LDLApplicationID = clsLDLApplicationsDataAccess.AddNewLDLApplication(this.ApplicationID, this.LicenseClassID);

            return this.LDLApplicationID != -1;
        }

        private bool _Update()
        {
            return clsLDLApplicationsDataAccess.UpdateLDLApplication(this.LDLApplicationID, this.LicenseClassID);
        }

        public clsLDLApplication()
        {
            this.LDLApplicationID = -1;
            this.LicenseClassID = -1;

            _Mode = enMode.enAddNewMode;
        }

        private clsLDLApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
            byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID, int LDLApplicationID, int LicenseCLassID)
            
            : base(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID,
            ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
        {
            this.LDLApplicationID = LDLApplicationID;
            this.LicenseClassID = LicenseCLassID;

            _Mode = enMode.enUpdateMode;
        }

        public static clsLDLApplication FindLDLApplication(int LDLApplicationID)
        {
            int ApplicationID = -1, LicenseClassID = -1;

            if (clsLDLApplicationsDataAccess.FindLDLApplication(LDLApplicationID, ref ApplicationID, ref LicenseClassID))
            {
                clsApplication Application = clsApplication.FindApplication(ApplicationID);

                if (Application != null)
                    return new clsLDLApplication(Application.ApplicationID, Application.ApplicantPersonID, Application.ApplicationDate,
                        Application.ApplicationTypeID, Application.ApplicationStatus, Application.LastStatusDate, Application.PaidFees,
                        Application.CreatedByUserID, LDLApplicationID, LicenseClassID);

                else
                    return null;
            }

            else
                return null;
        }

        public static bool DeleteLDLApplication(int LDLApplicationID)
        {
            int ApplicationID = clsLDLApplicationsDataAccess.GetApplicationIDByLDLApplicationID(LDLApplicationID);

            if (ApplicationID == -1)
                return false;

            if (clsLDLApplicationsDataAccess.DeleteLDLApplication(LDLApplicationID))
                return clsApplication.DeleteApplication(ApplicationID);

            else
                return false;
        }

        public static DataTable LDLApplciationsList()
        {
            return clsLDLApplicationsDataAccess.LDLApplicationsList();
        }

        public static bool IsLDLApplicationExist(int LDLApplicationID)
        {
            return clsLDLApplicationsDataAccess.IsLDLApplicationExist(LDLApplicationID);
        }

        public static int GetPersonIDByLDLApplicationID(int LDLApplicationID)
        {
            return clsLDLApplicationsDataAccess.GetPersonIDByLDLApplicationID(LDLApplicationID);
        }

        public static int GetApplicationIDByLDLApplicationID(int LDLApplicationID)
        {
            return clsLDLApplicationsDataAccess.GetApplicationIDByLDLApplicationID(LDLApplicationID);
        }

        public override bool Save()
        {
            if (base.Save())
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

            else
                return false;
        }
    }
}
