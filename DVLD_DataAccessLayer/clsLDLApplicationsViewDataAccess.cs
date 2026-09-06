using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsLDLApplicationsViewDataAccess
    {
        public static DataTable LDLApplicationsList_View()
        {
            DataTable LDLApplicationsDataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT LocalDrivingLicenseApplicationID AS [L.D.LApplicationID], ClassName AS [Class Name],
                             NationalNo AS [National No.], FullName AS [Full Name], ApplicationDate AS [Application Date],
                             PassedTestCount AS [Passed Tests], Status FROM LocalDrivingLicenseApplications_View;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    LDLApplicationsDataTable.Load(Reader);

                Reader.Close();

                return LDLApplicationsDataTable;
            }

            catch (Exception ex)
            {
                return null;
            }

            finally
            {
                if (Connection != null && Connection.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static bool IsLDLApplicationExist(string NationalNumber, string LicenseClassName)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Found = 1 FROM LocalDrivingLicenseApplications_View
                             WHERE NationalNo = @NationalNumber AND ClassName = @LicenseClassName AND 
                             (Status = 'New' OR Status = 'Completed')";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@NationalNumber", SqlDbType.NVarChar).Value = NationalNumber;
            Command.Parameters.Add("@LicenseClassName", SqlDbType.NVarChar).Value = LicenseClassName;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                    IsFound = true;
            }

            catch (Exception ex)
            {
                return false;
            }

            finally
            {
                if (Connection != null && Connection.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();
                }
            }

            return IsFound;
        }

        public static int GetLDLApplicationID(string NationalNumber, string LicenseClassName)
        {
            int LDLApplicationID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT LocalDrivingLicenseApplicationID FROM LocalDrivingLicenseApplications_View
                             WHERE NationalNo = @NationalNumber AND ClassName = @LicenseClassName AND 
                             (Status = 'New' OR Status = 'Completed')";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@NationalNumber", SqlDbType.NVarChar).Value = NationalNumber;
            Command.Parameters.Add("@LicenseClassName", SqlDbType.NVarChar).Value = LicenseClassName;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int RetreivedLDLApplicationID))
                    LDLApplicationID = RetreivedLDLApplicationID;
            }

            catch (Exception ex)
            {
                return -1;
            }

            finally
            {
                if (Connection != null && Connection.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();
                }
            }

            return LDLApplicationID;
        }

        public static bool FindLDLApplication(int LDLApplicationID, ref string ClassName, ref string ApplicantName, ref string ApplicationStatus, ref int PassedTestCount)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT ClassName, FullName, Status, PassedTestCount From LocalDrivingLicenseApplications_View 
                             WHERE LocalDrivingLicenseApplicationID = @LDLApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@LDLApplicationID", SqlDbType.Int).Value = LDLApplicationID;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    ClassName = (string)Reader["ClassName"];
                    ApplicantName = (string)Reader["FullName"];
                    ApplicationStatus = (string)Reader["Status"];
                    PassedTestCount = (int)Reader["PassedTestCount"];
                }

                Reader.Close();
            }

            catch (Exception ex)
            {

            }

            finally
            {
                if (Connection != null && Connection.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();
                }
            }

            return IsFound;
        }
    }
}
