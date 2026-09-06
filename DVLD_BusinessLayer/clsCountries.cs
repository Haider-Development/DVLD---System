using DVLD_DataAccessLayer;
using System;
using System.Data;
using System.Net;

namespace DVLD_BusinessLayer
{
    public class clsCountry
    {
        private enum enMode : sbyte { enAddNewMode = 1, enUpdateMode = 2 }
        private enMode _Mode = enMode.enAddNewMode;

        public int ID { get; }
        public string CountryName { get; set; }

        private bool _AddNew()
        {
            int CountryID = -1;

            CountryID = clsCountriesDataAccess.AddNewCountry(this.CountryName);

            return CountryID != -1;
        }

        private bool _Update()
        {
            return clsCountriesDataAccess.UpdateCountry(this.ID, this.CountryName);
        }

        public clsCountry()
        {
            this.ID = -1;
            this.CountryName = "";

            _Mode = enMode.enAddNewMode;
        }

        private clsCountry(int ID, string CountryName)
        {
            this.ID = ID;
            this.CountryName = CountryName;

            _Mode = enMode.enUpdateMode;
        }

        public static clsCountry FindCountryByID(int ID)
        {
            string CountryName = "";

            if (clsCountriesDataAccess.FindCountryByID(ID, ref CountryName))
            {
                return new clsCountry(ID, CountryName);
            }

            else
            {
                return null;
            }
        }

        public static clsCountry FindCountryByName(string CountryName)
        {
            int CountryID = -1;

            if (clsCountriesDataAccess.FindCountryByName(ref CountryID, CountryName))
            {
                return new clsCountry(CountryID, CountryName);
            }

            else
            {
                return null;
            }
        }

        public static bool DeleteCountry(int ID)
        {
            return clsCountriesDataAccess.DeleteCountry(ID);
        }

        public static DataTable CountriesList()
        {
            return clsCountriesDataAccess.CountriesList();
        }

        public static bool IsCountryExistByID(int ID)
        {
            return clsCountriesDataAccess.IsCountryExistByID(ID);
        }

        public static bool IsCountryExistByName(string CountryName)
        {
            return clsCountriesDataAccess.IsCountryExistByCountryName(CountryName);
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
