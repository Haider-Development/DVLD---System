using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsUsersDataAccess
    {
        public static bool FindUserByID(int UserID, ref int PersonID, ref string Username, ref string Password,
            ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM Users WHERE UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)Reader["PersonID"];
                    Username = (string)Reader["Username"];
                    Password = (string)Reader["Password"];
                    IsActive = (bool)Reader["IsActive"];
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

        public static bool FindUserByUsernameAndPassword(ref string Username, ref string Password, ref int UserID, ref int PersonID,
            ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT UserID, PersonID, Username, Password, IsActive FROM Users WHERE Username = @Username AND Password = @Password";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = Username;
            Command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Password;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    UserID = (int)Reader["UserID"];
                    PersonID = (int)Reader["PersonID"];
                    IsActive = (bool)Reader["IsActive"];
                    Username = (string)Reader["Username"];
                    Password = (string)Reader["Password"];
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

        public static int AddNewUser(int PersonID, string Username, string Password, bool IsActive)
        {
            int UserID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[Users]
                                    ([PersonID]
                                    ,[Username]
                                    ,[Password]
                                    ,[IsActive])
                                VALUES
                                      (@PersonID,
                                      @Username, 
                                      @Password,
                                      @IsActive);

                                SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@PersonID", SqlDbType.Int).Value = PersonID;
            Command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = Username;
            Command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Password;
            Command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = IsActive;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedUserID))
                {
                    UserID = InsertedUserID;
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

            return UserID;
        }

        public static bool UpdateUser(int UserID, string Username, string Password,
            bool IsActive)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE [dbo].[Users]
                              SET [Username] = @Username
                                 ,[Password] = @Password
                                 ,[IsActive] = @IsActive
                            WHERE UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = Username;
            Command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Password;
            Command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = IsActive;
            Command.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;

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

        public static bool DeleteUser(int UserID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"DELETE Users WHERE UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;

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

        public static DataTable UsersList()
        {
            DataTable UsersDataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT UserID, People.PersonID, FullName = FirstName + ' ' + SecondName + ' ' + ISNULL(ThirdName + ' ', '') + LastName, UserName, IsActive
                             FROM        Users INNER JOIN People ON
                                        Users.PersonID = People.PersonID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    UsersDataTable.Load(Reader);

                Reader.Close();

                return UsersDataTable;
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

        public static bool IsUserExistsByID(int UserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Found = 1 FROM Users WHERE UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;

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

        public static bool IsUserExistsByPersonID(int PersonID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Found = 1 FROM Users WHERE PersonID = @PersonID";

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

        public static bool IsUserExistsByNationalNumber(string NationalNumber)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT PersonID FROM People WHERE NationalNo = @NationalNumber";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@NationalNumber", SqlDbType.NVarChar).Value = NationalNumber;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int PersonID))
                    return IsUserExistsByPersonID(PersonID);
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

            return false;
        }

        public static bool IsUserExistsByUsername(string Username)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT IsExist = 1 FROM Users WHERE UserName = @UserName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = Username;

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

        public static string GetUsernameByID(int UserID)
        {
            string Username = "";

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Username FROM Users WHERE UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                    Username = Result.ToString();
            }

            catch (Exception ex)
            {
                return "";
            }

            finally
            {
                if (Connection != null && Connection.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();
                }
            }

            return Username;
        }

        public static int GetTotalUsersCount()
        {
            int TotalUsersCount = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT count(*) AS TotalUsers FROM Users";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int RetreivedUsersCount))
                    TotalUsersCount = RetreivedUsersCount;

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

            return TotalUsersCount;
        }
    }
}
