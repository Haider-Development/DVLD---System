using System;
using System.Data;
using DVLD_DataAccessLayer;

namespace DVLD_BusinessLayer
{
    public class clsApplicationType
    {
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }

        private clsApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
        }

        public static clsApplicationType FindApplicationType(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = "";
            decimal ApplicationFees = -1;

            if (clsApplicationTypesDataAccess.FindApplicationType(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees))
                return new clsApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);

            else
                return null;
        }

        private bool _Update()
        {
            return clsApplicationTypesDataAccess.UpdateApplicationType(this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees);
        }

        public static DataTable ApplicationTypesList()
        {
            return clsApplicationTypesDataAccess.ApplicationTypesList();
        }

        public static decimal GetApplicationTypeFees(int ApplicationTypeID)
        {
            return clsApplicationTypesDataAccess.GetApplicationTypeFees(ApplicationTypeID);
        }

        public static string GetAapplicationTypeTitle(int ApplicationTypeID)
        {
            return clsApplicationTypesDataAccess.GetApplicationTypeTitle(ApplicationTypeID);
        }

        public bool Save()
        {
            return _Update();
        }
    }
}
