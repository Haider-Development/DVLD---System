using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsInternationalLicensesDataAccess
    {
        public static bool FindInternatioanalLicense(int InternationalLicenseID, ref int ApplicationID, ref int DriverID, 
            ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate,
            ref bool IsActive, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate,
                             IsActive, CreatedByUserID FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@InternationalLicenseID", SqlDbType.Int).Value = InternationalLicenseID;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    ApplicationID = (int)Reader["ApplicationID"];
                    DriverID = (int)Reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)Reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    IsActive = (bool)Reader["IsActive"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                }

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

        public static int AddNewInternationalLicense(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate,
            DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int InternationalLicenseID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[InternationalLicenses]
                                    ([ApplicationID]
                                    ,[DriverID]
                                    ,[IssuedUsingLocalLicenseID]
                                    ,[IssueDate]
                                    ,[ExpirationDate]
                                    ,[IsActive]
                                    ,[CreatedByUserID])
                              VALUES
                                    (@ApplicationID
                                    ,@DriverID
                                    ,@IssuedUsingLocalLicenseID
                                    ,@IssueDate
                                    ,@ExpirationDate
                                    ,@IsActive
                                    ,@CreatedByUserID);

                             SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = ApplicationID;
            Command.Parameters.Add("@DriverID", SqlDbType.Int).Value = DriverID;
            Command.Parameters.Add("@IssuedUsingLocalLicenseID", SqlDbType.Int).Value = IssuedUsingLocalLicenseID;
            Command.Parameters.Add("@IssueDate", SqlDbType.DateTime).Value = IssueDate;
            Command.Parameters.Add("@ExpirationDate", SqlDbType.DateTime).Value = ExpirationDate;
            Command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = IsActive;
            Command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = CreatedByUserID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedInternatioanlLicenseID))
                {
                    InternationalLicenseID = InsertedInternatioanlLicenseID;
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

            return InternationalLicenseID;
        }

        public static bool UpdateInternationalLicense(int InternationalLicenseID, bool IsActive)
        {
            int RowsAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE [dbo].[InternationalLicenses]
                               SET [IsActive] = @IsActive
                               WHERE InternationalLicenseID = @InternationalLicenseID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@InternationalLicenseID", SqlDbType.Int).Value = InternationalLicenseID;
            Command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = IsActive;

            try
            {
                Connection.Open();

                RowsAffected = Command.ExecuteNonQuery();
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

            return RowsAffected > 0;
        }

        public static bool IsInternationalLicenseExist(int InternationalLicenseID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Found = 1 FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@InternationalLicenseID", SqlDbType.Int).Value = InternationalLicenseID;

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

        public static bool IsInternationalLicenseExpired(int DriverID)
        {
            bool IsExpired = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT TOP 1 ExpirationDate FROM InternationalLicenses
                             WHERE DriverID = @DriverID
                             ORDER BY InternationalLicenseID DESC;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@DriverID", SqlDbType.Int).Value = DriverID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && DateTime.TryParse(Result.ToString(), out DateTime ExpirationDate))
                    IsExpired = DateTime.Now > ExpirationDate;

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

            return IsExpired;
        }

        public static bool IsInternationalLicenseExistByDriverID(int DriverID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Found = 1 FROM InternationalLicenses WHERE (DriverID = @DriverID AND IsActive = 1)";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@DriverID", SqlDbType.Int).Value = DriverID;

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

        public static DataTable ObtainedInternationalLicensesList(int DriverID)
        {
            DataTable ObtainedInternatioanlLicensesDataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT InternationalLicenseID AS [Int.License ID], ApplicationID AS [Application ID],
                             IssuedUsingLocalLicenseID AS [L.License ID], IssueDate as [Issue Date], ExpirationDate AS [Expiration Date],
                             IsActive AS [Is Active] FROM InternationalLicenses
                             WHERE DriverID = @DriverID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@DriverID", SqlDbType.Int).Value = DriverID;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    ObtainedInternatioanlLicensesDataTable.Load(Reader);

                Reader.Close();

                return ObtainedInternatioanlLicensesDataTable;
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

        public static DataTable InternationalLicensesList()
        {
            DataTable InternationalLicesesList = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT InternationalLicenseID AS [Int.License ID], ApplicationID AS [Application ID],
                             DriverID AS [Driver ID], IssuedUsingLocalLicenseID AS [L.License ID], IssueDate as [Issue Date],
                             ExpirationDate AS [Expiration Date], IsActive AS [Is Active] FROM InternationalLicenses;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    InternationalLicesesList.Load(Reader);

                Reader.Close();

                return InternationalLicesesList;
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

        public static int GetInternationalLicenseID(int DriverID)
        {
            int InternationalLicenseID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT TOP 1 InternationalLicenseID FROM InternationalLicenses
                             WHERE DriverID = @DriverID
                             ORDER BY InternationalLicenseID DESC;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@DriverID", SqlDbType.Int).Value = DriverID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int RetreivedInternationalLicenseID))
                    InternationalLicenseID = RetreivedInternationalLicenseID;

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

            return InternationalLicenseID;
        }
    }
}
