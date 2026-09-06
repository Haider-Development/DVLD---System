using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsApplicationTypesDataAccess
    {
        public static bool FindApplicationType(int ApplicationTypeID, ref string ApplicationTypeTitle, ref decimal ApplicationFees)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@ApplicationTypeID", SqlDbType.Int).Value = ApplicationTypeID;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    ApplicationTypeTitle = (string)Reader["ApplicationTypeTitle"];
                    ApplicationFees = (decimal)Reader["ApplicationFees"];
                }

                Reader.Close();
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

        public static bool UpdateApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE [dbo].[ApplicationTypes]
                              SET [ApplicationTypeTitle] = @ApplicationTypeTitle
                                 ,[ApplicationFees] = @ApplicationFees
                            WHERE ApplicationTypeID = @ApplicationTypeID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@ApplicationTypeTitle", SqlDbType.NVarChar).Value = ApplicationTypeTitle;
            Command.Parameters.Add("@ApplicationFees", SqlDbType.SmallMoney).Value = ApplicationFees;
            Command.Parameters.Add("@ApplicationTypeID", SqlDbType.Int).Value = ApplicationTypeID;

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

        public static decimal GetApplicationTypeFees(int ApplicationTypeID)
        {
            decimal ApplicationFees = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT ApplicationFees FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@ApplicationTypeID", SqlDbType.Int).Value = ApplicationTypeID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    ApplicationFees = Convert.ToDecimal(Result);
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

            return ApplicationFees;
        }

        public static string GetApplicationTypeTitle(int ApplicationTypeID)
        {
            string ApplicationTypeName = "";

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT ApplicationTypeTitle FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@ApplicationTypeID", SqlDbType.Int).Value = ApplicationTypeID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    ApplicationTypeName = Result.ToString();
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

            return ApplicationTypeName;
        }

        public static DataTable ApplicationTypesList()
        {
            DataTable ApplicationTypesDataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT     ApplicationTypeID AS ID, ApplicationTypeTitle AS Title, ApplicationFees As Fees
                             FROM       ApplicationTypes;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    ApplicationTypesDataTable.Load(Reader);

                Reader.Close();

                return ApplicationTypesDataTable;
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
