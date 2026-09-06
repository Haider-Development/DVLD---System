using System;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataAccessLayer
{
    public class clsLDLApplicationsDataAccess
    {
        public static bool FindLDLApplication(int LDLApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int).Value = LDLApplicationID;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    ApplicationID = (int)Reader["ApplicationID"];
                    LicenseClassID = (int)Reader["LicenseClassID"];
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

        public static int AddNewLDLApplication(int ApplicationID, int LicenseClassID)
        {
            int LDLApplicationID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[LocalDrivingLicenseApplications]
                                    ([ApplicationID]
                                    ,[LicenseClassID])
                                VALUES
                                      (@ApplicationID,
                                      @LicenseClassID);

                                SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = ApplicationID;
            Command.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = LicenseClassID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedLDLApplicationID))
                {
                    LDLApplicationID = InsertedLDLApplicationID;
                }
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

            return LDLApplicationID;
        }

        public static bool UpdateLDLApplication(int LDLApplicationID, int LicenseClassID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE [dbo].[LocalDrivingLicenseApplications]
                              SET [LicenseClassID] = @LicenseClassID
                            WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = LicenseClassID;
            Command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int).Value = LDLApplicationID;

            try
            {
                Connection.Open();

                RowsAffected = Command.ExecuteNonQuery();

                return RowsAffected > 0;
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
        }

        public static bool DeleteLDLApplication(int LDLApplicationID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"DELETE LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int).Value = LDLApplicationID;

            try
            {
                Connection.Open();

                RowsAffected = Command.ExecuteNonQuery();

                return RowsAffected > 0;
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
        }

        public static DataTable LDLApplicationsList()
        {
            DataTable LDLApplicationsDataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM LocalDrivingLicenseApplications;";

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

        public static bool IsLDLApplicationExist(int LDLApplicationID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Found = 1 FROM LocalDrivingLicenseApplications WHERE LDLApplicationID = @LDLApplicationID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@LDLApplicationID", SqlDbType.NVarChar).Value = LDLApplicationID;

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

        public static int GetApplicationIDByLDLApplicationID(int LDLApplicationID)
        {
            int ApplicationID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT ApplicationID FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int).Value = LDLApplicationID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int SelectedLDLApplicationID))
                {
                    ApplicationID = SelectedLDLApplicationID;
                }
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

            return ApplicationID;
        }

        public static int GetPersonIDByLDLApplicationID(int LDLApplicationID)
        {
            int ApplicationID = GetApplicationIDByLDLApplicationID(LDLApplicationID);
            int PersonID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT ApplicantPersonID FROM Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = ApplicationID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int RetreivedPersonID))
                {
                    PersonID = RetreivedPersonID;
                }
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

            return PersonID;
        }
    }
}
