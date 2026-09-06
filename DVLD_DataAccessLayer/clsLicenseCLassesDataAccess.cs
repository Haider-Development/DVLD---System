using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsLicenseCLassesDataAccess
    {
        public static decimal GetLicenseClassFees(int LicenseClassID)
        {
            decimal ClassFees = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT ClassFees FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@LicenseClassID", SqlDbType.TinyInt).Value = LicenseClassID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && decimal.TryParse(Result.ToString(), out decimal RetreivedClassFees))
                    ClassFees = RetreivedClassFees;
            }

            catch (Exception ex)
            {
                return 0;
            }

            finally
            {
                if (Connection != null && Connection.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();
                }
            }

            return ClassFees;
        }

        public static byte GetValidityLengthValue(int LicenseClassID)
        {
            byte ValidityLength = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT DefaultValidityLength FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@LicenseClassID", SqlDbType.TinyInt).Value = LicenseClassID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && byte.TryParse(Result.ToString(), out byte RetreivedValidityLength))
                    ValidityLength = RetreivedValidityLength;
            }

            catch (Exception ex)
            {
                return 0;
            }

            finally
            {
                if (Connection != null && Connection.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();
                }
            }

            return ValidityLength;
        }

        public static string GetLicenseClassName(int LicenseClassID)
        {
            string ClassName = "";

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT ClassName FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = LicenseClassID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                    ClassName = Result.ToString();
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

            return ClassName;
        }

        public static bool IsLicenseThirdClass(int LicenseClassID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Found = 1 FROM LicenseClasses WHERE @LicenseClassID = 3;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = LicenseClassID;

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

        public static int GetMinimumAllowedAge(int LicenseClassID)
        {
            int MinimumAllowedAge = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT MinimumAllowedAge FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = LicenseClassID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int RetreivedMinimumAllowedAge))
                    MinimumAllowedAge = RetreivedMinimumAllowedAge;
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

            return MinimumAllowedAge;
        }

        public static DataTable LicenseCLassesList()
        {
            DataTable LicesnseClassDataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM LicenseClasses;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    LicesnseClassDataTable.Load(Reader);

                Reader.Close();

                return LicesnseClassDataTable;
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
    }
}
