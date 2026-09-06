using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DVLD_BusinessLayer
{
    public class clsLDLApplicationView
    {
        public string ClassName { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicationStatus { get; set; }
        public int PassedTestCount { get; set; }

        private clsLDLApplicationView(string ClassName, string ApplicantName, string ApplicationStatus, int PassedTestCount)
        {
            this.ClassName = ClassName;
            this.ApplicantName = ApplicantName;
            this.ApplicationStatus = ApplicationStatus;
            this.PassedTestCount = PassedTestCount;
        }

        public static clsLDLApplicationView FindLDLApplication(int LDLApplicationID)
        {
            string ClassName = "", ApplicantName = "", ApplicationStatus = "";

            int PassedTestCount = -1;

            if (clsLDLApplicationsViewDataAccess.FindLDLApplication(LDLApplicationID, ref ClassName, ref ApplicantName, ref ApplicationStatus, ref PassedTestCount))
                return new clsLDLApplicationView(ClassName, ApplicantName, ApplicationStatus, PassedTestCount);

            else
                return null;
        }

        public static DataTable LDLApplciationsList_View()
        {
            return clsLDLApplicationsViewDataAccess.LDLApplicationsList_View();
        }

        public static bool IsLDLApplicationExist(string NationalNumber, string LicenseClassName)
        {
            return clsLDLApplicationsViewDataAccess.IsLDLApplicationExist(NationalNumber, LicenseClassName);
        }

        public static int GetLDLApplicationID(string NationalNumber, string LicenseClassName)
        {
            return clsLDLApplicationsViewDataAccess.GetLDLApplicationID(NationalNumber, LicenseClassName);
        }
    }
}
