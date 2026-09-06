using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsTestAppointmentsDataAccess
    {
        public static bool FindTestAppointment(int TestAppointmentID, ref int TestTypeID, ref int LDLApplicationID,
            ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@TestAppointmentID", SqlDbType.Int).Value = TestAppointmentID;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    TestTypeID = (int)Reader["TestTypeID"];
                    LDLApplicationID = (int)Reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)Reader["AppointmentDate"];
                    PaidFees = (decimal)Reader["PaidFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsLocked = (bool)Reader["IsLocked"];

                    if (Reader["RetakeTestApplicationID"] != DBNull.Value)
                        RetakeTestApplicationID = (int)Reader["RetakeTestApplicationID"];

                    else
                        RetakeTestApplicationID = -1;
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

        public static int AddNewTestAppointment(int TestTypeID, int LDLApplicationID, DateTime AppointmentDate, decimal PaidFees,
            int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            int TestAppointmentID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[TestAppointments]
                             ([TestTypeID]
                             ,[LocalDrivingLicenseApplicationID]
                             ,[AppointmentDate]
                             ,[PaidFees]
                             ,[CreatedByUserID]
                             ,[IsLocked]
                             ,[RetakeTestApplicationID])
                       VALUES
                             (@TestTypeID
                             ,@LocalDrivingLicenseApplicationID
                             ,@AppointmentDate
                             ,@PaidFees
                             ,@CreatedByUserID
                             ,@IsLocked
                             ,@RetakeTestApplicationID);

                            SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = TestTypeID;
            Command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int).Value = LDLApplicationID;
            Command.Parameters.Add("@AppointmentDate", SqlDbType.DateTime).Value = AppointmentDate;
            Command.Parameters.Add("@PaidFees", SqlDbType.SmallMoney).Value = PaidFees;
            Command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = CreatedByUserID;
            Command.Parameters.Add("@IsLocked", SqlDbType.Bit).Value = IsLocked;

            if (RetakeTestApplicationID != -1)
                Command.Parameters.Add("@RetakeTestApplicationID", SqlDbType.Int).Value = RetakeTestApplicationID;
            else
                Command.Parameters.Add("@RetakeTestApplicationID", SqlDbType.Int).Value = DBNull.Value;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedTestAppointmentID))
                {
                    TestAppointmentID = InsertedTestAppointmentID;
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

            return TestAppointmentID;
        }

        public static bool UpdateTestAppointment(int TestAppointmentID, DateTime AppointmentDate, bool IsLocked)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE [dbo].[TestAppointments]
                               SET [AppointmentDate] = @AppointmentDate
                                  ,[IsLocked] = @IsLocked
                             WHERE TestAppointmentID = @TestAppointmentID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@AppointmentDate", SqlDbType.DateTime).Value = AppointmentDate;
            Command.Parameters.Add("@IsLocked", SqlDbType.Bit).Value = IsLocked;
            Command.Parameters.Add("@TestAppointmentID", SqlDbType.Int).Value = TestAppointmentID;

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

        public static bool DeleteTestAppointment(int TestAppointmentID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"DELETE TestAppointments WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@TestAppointmentID", SqlDbType.Int).Value = TestAppointmentID;

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

        public static DataTable TestAppointmentsList(int LDLApplicationID, int TestTypeID)
        {
            DataTable TestAppointmentsDataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT TestAppointmentID AS [Appointment ID], AppointmentDate AS [Appointment Date],
                             TestAppointments.PaidFees + ISNULL(Applications.PaidFees, 0) AS [Paid Fees], IsLocked AS [Is Locked] FROM TestAppointments
                             LEFT JOIN Applications ON TestAppointments.RetakeTestApplicationID = Applications.ApplicationID
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int).Value = LDLApplicationID;
            Command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = TestTypeID;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    TestAppointmentsDataTable.Load(Reader);

                Reader.Close();

                return TestAppointmentsDataTable;
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

        public static bool IsTestAppointmentExist(int TestAppointmentID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Found = 1 FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@TestAppointmentID", SqlDbType.Int).Value = TestAppointmentID;

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

        public static bool IsTestAppointmentLocked(int TestAppointmentID)
        {
            bool IsLocked = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Locked = 1 FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID AND IsLocked = 1";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@TestAppointmentID", SqlDbType.Int).Value = TestAppointmentID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                    IsLocked = true;
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

            return IsLocked;
        }

        public static int GetTestAppointmentID(int LDLApplicationID, int TestTypeID)
        {
            int TestAppointmentID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Top 1 TestAppointmentID FROM TestAppointments
                             WHERE LocalDrivingLicenseApplicationID = @LDLApplicationID AND TestTypeID = @TestTypeID
                             ORDER BY TestAppointmentID DESC;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@LDLApplicationID", SqlDbType.Int).Value = LDLApplicationID;
            Command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = TestTypeID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedTestAppointmentID))
                {
                    TestAppointmentID = InsertedTestAppointmentID;
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

            return TestAppointmentID;
        }

        public static int GetRetakeTestID(int LDLApplicationID, int TestTypeID)
        {
            int RetakeTestID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Top 1 RetakeTestApplicationID FROM TestAppointments
                             WHERE LocalDrivingLicenseApplicationID = @LDLApplicationID AND TestTypeID = @TestTypeID
                             ORDER BY TestAppointmentID DESC;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@LDLApplicationID", SqlDbType.Int).Value = LDLApplicationID;
            Command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = TestTypeID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedTestAppointmentID))
                {
                    RetakeTestID = InsertedTestAppointmentID;
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

            return RetakeTestID;
        }

        public static int GetTrialsCount(int LDLApplicationID, int TestTypeID)
        {
            int TrialsCount = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT sum(TrialsCount) FROM
                             (
                                SELECT TrialsCount = count(TestAppointmentID) FROM TestAppointments
                                WHERE LocalDrivingLicenseApplicationID = @LDLApplicationID AND TestTypeID = @TestTypeID AND IsLocked = 1
                                GROUP BY TestAppointmentID
                             )
                             R1;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@LDLApplicationID", SqlDbType.Int).Value = LDLApplicationID;
            Command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = TestTypeID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int TrialsCounted))
                {
                    TrialsCount = TrialsCounted;
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

            return TrialsCount;
        }
    }
}
