using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsCountriesDataAccess
    {
        public static bool FindCountryByID(int ID, ref string CountryName)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT CountryName FROM Countries WHERE CountryID = @ID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    IsFound = true;
                    CountryName = Result.ToString();
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

            return IsFound;
        }

        public static bool FindCountryByName(ref int ID, string CountryName)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT CountryID FROM Countries WHERE CountryName = @CountryName";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@CountryName", SqlDbType.NVarChar).Value = CountryName;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int CountryID))
                {
                    IsFound = true;
                    ID = CountryID;
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

            return IsFound;
        }

        public static int AddNewCountry(string CountryName)
        {
            int CountryID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[Countryies]
                                    ([CountryName])
                                VALUES
                                      (@CountryName)

                                SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@CountryName", SqlDbType.NVarChar).Value = CountryName;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedCountryID))
                {
                    CountryID = InsertedCountryID;
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

            return CountryID;
        }

        public static bool UpdateCountry(int ID, string CountryName)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE [dbo].[People]
                              SET [CountryName] = @CountryName
                            WHERE CountryID = @ID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@CountryName", SqlDbType.NVarChar).Value = CountryName;

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

        public static bool DeleteCountry(int ID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"DELETE Countries WHERE CountryID = @ID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

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

        public static DataTable CountriesList()
        {
            DataTable CountriesDataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT CountryName FROM Countries;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    CountriesDataTable.Load(Reader);

                Reader.Close();

                return CountriesDataTable;
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

        public static bool IsCountryExistByID(int ID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Found = 1 FROM Countries WHERE CountryID = @ID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

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

        public static bool IsCountryExistByCountryName(string CountryName)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Found = 1 FROM Countries WHERE CountryName = @CountryName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@CountryName", SqlDbType.NVarChar).Value = CountryName;

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
    }
}
