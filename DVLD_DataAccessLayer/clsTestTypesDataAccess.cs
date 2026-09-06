using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsTestTypesDataAccess
    {
        public static bool FindTestType(int TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref decimal TestFees)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = TestTypeID;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    TestTypeTitle = (string)Reader["TestTypeTitle"];
                    TestTypeDescription = (string)Reader["TestTypeDescription"];
                    TestFees = (decimal)Reader["TestTypeFees"];
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

        public static bool UpdateTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestFees)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE [dbo].[TestTypes]
                              SET [TestTypeTitle] = @TestTypeTitle
                                 ,[TestTypeDescription] = @TestTypeDescription
                                 ,[TestTypeFees] = @TestFees
                            WHERE TestTypeID = @TestTypeID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@TestTypeTitle", SqlDbType.NVarChar).Value = TestTypeTitle;
            Command.Parameters.Add("@TestTypeDescription", SqlDbType.NVarChar).Value = TestTypeDescription;
            Command.Parameters.Add("@TestFees", SqlDbType.SmallMoney).Value = TestFees;
            Command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = TestTypeID;

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

        public static DataTable TestTypesList()
        {
            DataTable TestTypesDataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT     TestTypeID AS ID, TestTypeTitle AS Title, TestTypeDescription AS Description, TestTypeFees As Fees
                             FROM       TestTypes;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    TestTypesDataTable.Load(Reader);

                Reader.Close();

                return TestTypesDataTable;
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

        public static decimal GetTestTypeFees(int TestTypeID)
        {
            decimal Fees = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT TestTypeFees FROM TestTypes WHERE TestTypeID = @TestTypeID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = TestTypeID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && decimal.TryParse(Result.ToString(), out decimal GottedFees))
                    Fees = GottedFees;
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

            return Fees;
        }
    }
}
