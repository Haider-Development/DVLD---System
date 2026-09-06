using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsDetainedLicensesDataAccess
    {
        public static bool FindDetain(int DetainID, ref int LicenseID, ref DateTime DetainDate, ref decimal FineFees,
            ref int CreatedByUserID, ref bool IsReleased, ref DateTime? ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@DetainID", SqlDbType.Int).Value = DetainID;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    LicenseID = (int)Reader["LicenseID"];
                    DetainDate = (DateTime)Reader["DetainDate"];
                    FineFees = (decimal)Reader["FineFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsReleased = (bool)Reader["IsReleased"];


                    if (Reader["ReleaseDate"] != DBNull.Value)
                        ReleaseDate = (DateTime)Reader["ReleaseDate"];
                    else
                        ReleaseDate = null;

                    if (Reader["ReleasedByUserID"] != DBNull.Value)
                        ReleasedByUserID = (int)Reader["ReleasedByUserID"];
                    else
                        ReleasedByUserID = -1;

                    if (Reader["ReleaseApplicationID"] != DBNull.Value)
                        ReleaseApplicationID = (int)Reader["ReleaseApplicationID"];
                    else
                        ReleaseApplicationID = -1;

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

        public static int AddNewDetain(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID)
        {
            int DetainID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[DetainedLicenses]
                                    ([LicenseID]
                                    ,[DetainDate]
                                    ,[FineFees]
                                    ,[CreatedByUserID]
                                    ,[IsReleased]
                                    ,[ReleaseDate]
                                    ,[ReleasedByUserID]
                                    ,[ReleaseApplicationID])
                                VALUES
                                      (@LicenseID,
                                      @DetainDate, 
                                      @FineFees,
                                      @CreatedByUserID, 
                                      @IsReleased,
                                      @ReleaseDate,
                                      @ReleasedByUserID,
                                      @ReleaseApplicationID);

                                SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = LicenseID;
            Command.Parameters.Add("@DetainDate", SqlDbType.DateTime).Value = DetainDate;
            Command.Parameters.Add("@FineFees", SqlDbType.SmallMoney).Value = FineFees;
            Command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = CreatedByUserID;
            Command.Parameters.Add("@IsReleased", SqlDbType.Bit).Value = 0;

            Command.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value = DBNull.Value;
            Command.Parameters.Add("@ReleasedByUserID", SqlDbType.Int).Value = DBNull.Value;
            Command.Parameters.Add("@ReleaseApplicationID", SqlDbType.Int).Value = DBNull.Value;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedDetainID))
                {
                    DetainID = InsertedDetainID;
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

            return DetainID;
        }

        public static bool UpdateDetain(int DetainID, bool IsReleased, DateTime? ReleaseDate,
            int ReleasedByUserID, int ReleaseApplicationID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE [dbo].[DetainedLicenses]
                              SET [IsReleased] = @IsReleased
                                 ,[ReleaseDate] = @ReleaseDate
                                 ,[ReleasedByUserID] = @ReleasedByUserID
                                 ,[ReleaseApplicationID] = @ReleaseApplicationID
                            WHERE DetainID = @DetainID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@IsReleased", SqlDbType.Bit).Value = IsReleased;
            Command.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value = ReleaseDate;
            Command.Parameters.Add("@ReleasedByUserID", SqlDbType.Int).Value = ReleasedByUserID;
            Command.Parameters.Add("@ReleaseApplicationID", SqlDbType.Int).Value = ReleaseApplicationID;
            Command.Parameters.Add("@DetainID", SqlDbType.Int).Value = DetainID;

            try
            {
                Connection.Open();

                RowsAffected = Command.ExecuteNonQuery();
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

            return RowsAffected > 0;
        }

        public static DataTable DetainedLicensesList()
        {
            DataTable DetainedLicensesDataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT	  DetainID AS [D.ID], DetainedLicenses.LicenseID AS [L.ID], DetainDate AS [D.Date], IsReleased AS [Is Released]
                             		  , FineFees AS [Fine Fees], ReleaseDate AS [Release Date], NationalNo AS [N.No], FirstName + ' ' + SecondName
                             		  + ' ' + IsNULL(ThirdName + ' ', '') + ' ' + LastName AS [Full Name], ReleaseApplicationID AS [Release App.ID]
                                      
                             FROM	  DetainedLicenses INNER JOIN Licenses ON
                             		  DetainedLicenses.LicenseID = Licenses.LicenseID INNER JOIN Drivers ON
                             		  Licenses.DriverID = Drivers.DriverID INNER JOIN People ON
                             		  Drivers.PersonID = People.PersonID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    DetainedLicensesDataTable.Load(Reader);

                Reader.Close();

                return DetainedLicensesDataTable;
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

        public static bool IsLicenseDetained(int LicenseID)
        {
            bool IsLicenseDetained = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT IsDetained = 1 FROM DetainedLicenses WHERE (LicenseID = @LicenseID AND IsReleased = 0);";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = LicenseID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                    IsLicenseDetained = true;
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

            return IsLicenseDetained;
        }

        public static int GetDetainID(int LicenseID)
        {
            int DetainID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT DetainID FROM DetainedLicenses WHERE (LicenseID = @LicenseID AND IsReleased = 0);";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = LicenseID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int RetreivedDetainID))
                    DetainID = RetreivedDetainID;
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

            return DetainID;
        }
    }
}
