using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsApplicationsDataAccess
    {
        public static bool FindApplication(int ApplicationID, ref int ApplicantPersonID, ref DateTime ApplicationDate,
            ref int ApplicationTypeID, ref byte ApplicationStatus, ref DateTime LastStatusDate, ref decimal PaidFees,
            ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = ApplicationID;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    ApplicantPersonID = (int)Reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)Reader["ApplicationDate"];
                    ApplicationTypeID = (int)Reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)Reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)Reader["LastStatusDate"];
                    PaidFees = (decimal)Reader["PaidFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
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

        public static int AddNewApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
            byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            int ApplicationID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[Applications]
                                    ([ApplicantPersonID]
                                    ,[ApplicationDate]
                                    ,[ApplicationTypeID]
                                    ,[ApplicationStatus]
                                    ,[LastStatusDate]
                                    ,[PaidFees]
                                    ,[CreatedByUserID])
                                VALUES
                                      (@ApplicantPersonID,
                                      @ApplicationDate, 
                                      @ApplicationTypeID,
                                      @ApplicationStatus, 
                                      @LastStatusDate,
                                      @PaidFees,
                                      @CreatedByUserID);

                                SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@ApplicantPersonID", SqlDbType.Int).Value = ApplicantPersonID;
            Command.Parameters.Add("@ApplicationDate", SqlDbType.DateTime).Value = ApplicationDate;
            Command.Parameters.Add("@ApplicationTypeID", SqlDbType.Int).Value = ApplicationTypeID;
            Command.Parameters.Add("@ApplicationStatus", SqlDbType.TinyInt).Value = ApplicationStatus;
            Command.Parameters.Add("@LastStatusDate", SqlDbType.DateTime).Value = LastStatusDate;
            Command.Parameters.Add("@PaidFees", SqlDbType.SmallMoney).Value = PaidFees;
            Command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = CreatedByUserID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedApplicationID))
                {
                    ApplicationID = InsertedApplicationID;
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

        public static bool UpdateApplication(int ApplicationID, byte ApplicationStatus, DateTime LastStatusDate)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE [dbo].[Applications]
                              SET [ApplicationStatus] = @ApplicationStatus
                                 ,[LastStatusDate] = @LastStatusDate
                            WHERE ApplicationID = @ApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@ApplicationStatus", SqlDbType.TinyInt).Value = ApplicationStatus;
            Command.Parameters.Add("@LastStatusDate", SqlDbType.DateTime).Value = LastStatusDate;
            Command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = ApplicationID;

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

        public static bool DeleteApplication(int ApplicationID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"DELETE Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = ApplicationID;

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

        public static DataTable ApplicationsList()
        {
            DataTable ApplicationsDataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM Applications;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    ApplicationsDataTable.Load(Reader);

                Reader.Close();

                return ApplicationsDataTable;
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

        public static bool IsApplicationExist(int ApplicationID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Found = 1 FROM Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = ApplicationID;

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

        public static int GetTotalApplicationsCount()
        {
            int TotalApplicationsCount = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT count(*) AS TotalApplications FROM Applications;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int RetreivedApplicationsCount))
                    TotalApplicationsCount = RetreivedApplicationsCount;

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

            return TotalApplicationsCount;
        }

        public static DataTable GetRecentApplications()
        {
            DataTable RecentApplicationsDataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM RecentApplications_View;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    RecentApplicationsDataTable.Load(Reader);

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

            return RecentApplicationsDataTable;
        }
    }
}
