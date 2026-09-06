using System;
using System.Data;
using DVLD_DataAccessLayer;

namespace DVLD_BusinessLayer
{
    public class clsDriver
    {
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsDriver()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now;
        }

        private clsDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
        }

        private bool _AddNew()
        {
            this.DriverID = clsDriversDataAccess.AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);

            return this.DriverID != -1;
        }

        public static clsDriver FindDriver(int DriverID)
        {
            int PersonID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDriversDataAccess.FindDriver(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);

            else
                return null;
        }

        public static DataTable DriversList_View()
        {
            return clsDriversDataAccess.DriversList_View();
        }

        public static int GetDriverID(int PersonID)
        {
            return clsDriversDataAccess.GetDriverID(PersonID);
        }

        public static int GetPersonID(int DriverID)
        {
            return clsDriversDataAccess.GetPersonID(DriverID);
        }

        public static bool IsDriverExits(int PersonID)
        {
            return clsDriversDataAccess.IsDriverExist(PersonID);
        }

        public static int GetTotalDriversCount()
        {
            return clsDriversDataAccess.GetTotalDriversCount();
        }

        public bool Save()
        {
            return _AddNew();
        }
    }
}
