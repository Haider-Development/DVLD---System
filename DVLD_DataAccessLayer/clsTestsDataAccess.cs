using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsTestsDataAccess
    {
        public static bool FindTest(int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes,
            ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM Tests WHERE TestID = @TestID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@TestID", SqlDbType.Int).Value = TestID;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    TestAppointmentID = (int)Reader["TestAppointmentID"];
                    TestResult = (bool)Reader["TestResult"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];

                    if (Reader["Notes"] != DBNull.Value)
                        Notes = (string)Reader["Notes"];

                    else
                        Notes = "";
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

        public static int AddNewTest(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int TestID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[Tests]
                             ([TestAppointmentID]
                             ,[TestResult]
                             ,[Notes]
                             ,[CreatedByUserID])
                       VALUES
                             (@TestAppointmentID
                             ,@TestResult
                             ,@Notes
                             ,@CreatedByUserID);

                            SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@TestAppointmentID", SqlDbType.Int).Value = TestAppointmentID;
            Command.Parameters.Add("@TestResult", SqlDbType.Bit).Value = TestResult;
            Command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = CreatedByUserID;

            if (!string.IsNullOrEmpty(Notes))
                Command.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = Notes;

            else
                Command.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = DBNull.Value;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedTestID))
                {
                    TestID = InsertedTestID;
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

            return TestID;
        }

        public static bool DeleteTest(int TestID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"DELETE Tests WHERE TestID = @TestID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@TestID", SqlDbType.Int).Value = TestID;

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

        public static DataTable TestsList()
        {
            DataTable TestsDataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM Tests;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    TestsDataTable.Load(Reader);

                Reader.Close();

                return TestsDataTable;
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

        public static bool IsTestExist(int TestID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Found = 1 FROM Tests WHERE TestID = @TestID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@TestID", SqlDbType.Int).Value = TestID;

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

        public static bool IsTestResultSuccess(int TestAppointmentID)
        {
            bool IsSuccess = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT TestResult FROM Tests WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@TestAppointmentID", SqlDbType.Int).Value = TestAppointmentID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && bool.TryParse(Result.ToString(), out bool GottedResult))
                    IsSuccess = GottedResult;
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

            return IsSuccess;
        }

        public static int GetTestID(int TestAppointmentID)
        {
            int TestID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT TestID FROM Tests WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@TestAppointmentID", SqlDbType.Int).Value = TestAppointmentID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int RetreivedTestID))
                    TestID = RetreivedTestID;
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

            return TestID;
        }
    }
}
