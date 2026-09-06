using System;
using System.Data;
using DVLD_DataAccessLayer;

namespace DVLD_BusinessLayer
{
    public class clsApplication
    {
        private enum enMode : sbyte { enAddNewMode = 1, enUpdateMode = 2 }
        private enMode _Mode = enMode.enAddNewMode;

        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public byte ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        private bool _AddNew()
        {
            this.ApplicationID = clsApplicationsDataAccess.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate,
                this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

            return this.ApplicationID != -1;
        }

        private bool _Update()
        {
            return clsApplicationsDataAccess.UpdateApplication(this.ApplicationID, this.ApplicationStatus, this.LastStatusDate);
        }

        public clsApplication()
        {
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = new DateTime();
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = 0;
            this.LastStatusDate = new DateTime();
            this.PaidFees = -1;
            this.CreatedByUserID = -1;

            _Mode = enMode.enAddNewMode;
        }

        protected clsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
            byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;

            _Mode = enMode.enUpdateMode;
        }

        public static clsApplication FindApplication(int ApplicationID)
        {

            int ApplicantPersonID = -1, ApplicationTypeID = -1, CreatedByUserID = -1;

            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;

            byte ApplicationStatus = 0;
            decimal PaidFees = -1;

            if (clsApplicationsDataAccess.FindApplication(ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new clsApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID,
                    ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            }

            else
            {
                return null;
            }
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            return clsApplicationsDataAccess.DeleteApplication(ApplicationID);
        }

        public static DataTable ApplciationsList()
        {
            return clsApplicationsDataAccess.ApplicationsList();
        }

        public static bool IsApplicationExist(int ApplicationID)
        {
            return clsApplicationsDataAccess.IsApplicationExist(ApplicationID);
        }

        public static int GetTotalApplicationsCount()
        {
            return clsApplicationsDataAccess.GetTotalApplicationsCount();
        }

        public static DataTable GetRecentApplications()
        {
            return clsApplicationsDataAccess.GetRecentApplications();
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
