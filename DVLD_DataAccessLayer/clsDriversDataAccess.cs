using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsDriversDataAccess
    {
        public static bool FindDriver(int DriverID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT PersonID, CreatedByUserID, CreatedDate FROM Drivers WHERE DriverID = @DriverID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@DriverID", SqlDbType.Int).Value = DriverID;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)Reader["PersonID"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    CreatedDate = (DateTime)Reader["CreatedDate"];
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

        public static int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            int DriverID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[Drivers]
                                        ([PersonID]
                                        ,[CreatedByUserID]
                                        ,[CreatedDate])
                                  VALUES
                                        (@PersonID
                                        ,@CreatedByUserID
                                        ,@CreatedDate);

                             SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@PersonID", SqlDbType.Int).Value = PersonID;
            Command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = CreatedByUserID;
            Command.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = CreatedDate;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedDriverID))
                {
                    DriverID = InsertedDriverID;
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

            return DriverID;
        }

        public static int GetDriverID(int PersonID)
        {
            int DriverID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT DriverID FROM Drivers WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@PersonID", SqlDbType.Int).Value = PersonID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int RetreivedDriverID))
                {
                    DriverID = RetreivedDriverID;
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

            return DriverID;
        }

        public static int GetPersonID(int DriverID)
        {
            int PersonID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT PersonID FROM Drivers WHERE DriverID = @DriverID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@DriverID", SqlDbType.Int).Value = DriverID;

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

        public static bool IsDriverExist(int PersonID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Found = 1 FROM Drivers WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@PersonID", SqlDbType.Int).Value = PersonID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                    IsFound = true;
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

        public static DataTable DriversList_View()
        {
            DataTable DriversDataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM Drivers_View;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    DriversDataTable.Load(Reader);

                Reader.Close();

                return DriversDataTable;
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

        public static int GetTotalDriversCount()
        {
            int TotalDriversCount = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT count(*) AS TotalDrivers FROM Drivers";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int RetreivedDriversCount))
                    TotalDriversCount = RetreivedDriversCount;

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

            return TotalDriversCount;
        }
    }
}
