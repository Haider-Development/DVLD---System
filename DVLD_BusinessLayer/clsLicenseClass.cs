using System;
using System.Data;
using DVLD_DataAccessLayer;

namespace DVLD_BusinessLayer
{
    public class clsLicenseClass
    {
        public static decimal GetLicenseClassFees(int LicenseClassID)
        {
            return clsLicenseCLassesDataAccess.GetLicenseClassFees(LicenseClassID);
        }

        public static byte GetValidityLengthValue(int LicenseClassID)
        {
            return clsLicenseCLassesDataAccess.GetValidityLengthValue(LicenseClassID);
        }

        public static string GetLicenseClassName(int LicenseClassID)
        {
            return clsLicenseCLassesDataAccess.GetLicenseClassName(LicenseClassID);
        }

        public static bool IsLicenseThirdClass(int LicenseClassID)
        {
            return clsLicenseCLassesDataAccess.IsLicenseThirdClass(LicenseClassID);
        }

        public static int GetMinimumAllowedAge(int LicenseClassID)
        {
            return clsLicenseCLassesDataAccess.GetMinimumAllowedAge(LicenseClassID);
        }

        public static DataTable LicenseClassesList()
        {
            return clsLicenseCLassesDataAccess.LicenseCLassesList();
        }
    }
}
