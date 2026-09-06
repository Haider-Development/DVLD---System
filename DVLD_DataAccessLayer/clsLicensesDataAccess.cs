using System;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataAccessLayer
{
    public class clsLicensesDataAccess
    {
        public static bool FindLicense(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClass,
            ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref decimal PaidFees, ref bool IsActive,
            ref byte IssueReason, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees,
                             IsActive, IssueReason, CreatedByUserID FROM Licenses WHERE LicenseID = @LicenseID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = LicenseID;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    ApplicationID = (int)Reader["ApplicationID"];
                    DriverID = (int)Reader["DriverID"];
                    LicenseClass = (int)Reader["LicenseClass"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    PaidFees = (decimal)Reader["PaidFees"];
                    IsActive = (bool)Reader["IsActive"];
                    IssueReason = (byte)Reader["IssueReason"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];

                    if (Reader["Notes"] != DBNull.Value)
                        Notes = (string)Reader["Notes"];

                    else
                        Notes = "No Notes";
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

        public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate,
            DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            int LicenseID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[Licenses]
                                    ([ApplicationID]
                                    ,[DriverID]
                                    ,[LicenseClass]
                                    ,[IssueDate]
                                    ,[ExpirationDate]
                                    ,[Notes]
                                    ,[PaidFees]
                                    ,[IsActive]
                                    ,[IssueReason]
                                    ,[CreatedByUserID])
                              VALUES
                                    (@ApplicationID
                                    ,@DriverID
                                    ,@LicenseClass
                                    ,@IssueDate
                                    ,@ExpirationDate
                                    ,@Notes
                                    ,@PaidFees
                                    ,@IsActive
                                    ,@IssueReason
                                    ,@CreatedByUserID);

                             SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = ApplicationID;
            Command.Parameters.Add("@DriverID", SqlDbType.Int).Value = DriverID;
            Command.Parameters.Add("@LicenseClass", SqlDbType.Int).Value = LicenseClass;
            Command.Parameters.Add("@IssueDate", SqlDbType.DateTime).Value = IssueDate;
            Command.Parameters.Add("@ExpirationDate", SqlDbType.DateTime).Value = ExpirationDate;
            Command.Parameters.Add("@PaidFees", SqlDbType.SmallMoney).Value = PaidFees;
            Command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = IsActive;
            Command.Parameters.Add("@IssueReason", SqlDbType.TinyInt).Value = IssueReason;
            Command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = CreatedByUserID;

            if (Notes != "")
                Command.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = Notes;
            else
                Command.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = DBNull.Value;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedLicenseID))
                {
                    LicenseID = InsertedLicenseID;
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

            return LicenseID;
        }

        public static bool UpdateLicense(int LicenseID, bool IsActive)
        {
            int RowsAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE [dbo].[Licenses]
                             SET [IsActive] = @IsActive
                             WHERE LicenseID = @LicenseID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = IsActive;
            Command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = LicenseID;

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

        public static DataTable ObtainedLicensesList(int DriverID)
        {
            DataTable ObtainedLicensesDataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT LicenseID AS [Lic.ID], ApplicationID AS [App.ID], ClassName AS [Class Name], IssueDate AS [Issue Date],
                             ExpirationDate AS [Expiration Date], IsActive AS [Is Active] 
                             FROM Licenses INNER JOIN LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
                             WHERE DriverID = @DriverID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@DriverID", SqlDbType.Int).Value = DriverID;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    ObtainedLicensesDataTable.Load(Reader);

                Reader.Close();

                return ObtainedLicensesDataTable;
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

        public static bool IsLicenseExist(int ApplicationID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Found = 1 FROM Licenses WHERE ApplicationID = @ApplicationID";

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

        public static bool IsLicenseExistByLicenseID(int LicenseID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Found = 1 FROM Licenses WHERE LicenseID = @LicenseID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = LicenseID;

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

        public static bool IsLicenseExpired(int LicenseID)
        {
            bool IsExpired = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT ExpirationDate FROM Licenses WHERE LicenseID = @LicenseID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = LicenseID;

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

        public static bool IsLicenseValid(int LicenseID)
        {
            bool IsValid = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT IsActive FROM Licenses WHERE LicenseID = @LicenseID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = LicenseID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && bool.TryParse(Result.ToString(), out bool IsActive))
                    IsValid = IsActive;

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

            return IsValid;
        }

        public static bool IsLicenseExistAndActive(int DriverID, int LicenseClass)
        {
            bool IsExistAndActive = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Found = 1 FROM Licenses WHERE (DriverID = @DriverID AND LicenseClass = @LicenseClass AND IsActive = 1);";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@DriverID", SqlDbType.Int).Value = DriverID;
            Command.Parameters.Add("@LicenseClass", SqlDbType.Int).Value = LicenseClass;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && bool.TryParse(Result.ToString(), out bool IsActive))
                    IsExistAndActive = IsActive;

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

            return IsExistAndActive;
        }

        public static int GetLicenseIDByApplicationID(int ApplicationID)
        {
            int LicenseID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT LicenseID FROM Licenses WHERE ApplicationID = @ApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = ApplicationID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int RetreivedLicenseID))
                    LicenseID = RetreivedLicenseID;

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

            return LicenseID;
        }
    }
}
