using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace DVLD_DataAccessLayer
{
    public class clsPeopleDataAccess
    {
        public static bool FindPersonByID(int ID, ref string NationalNumber, ref string FirstName, ref string SecondName,
            ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender, ref string Address,
            ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE PersonID = @ID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    NationalNumber = (string)Reader["NationalNo"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    LastName = (string)Reader["LastName"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    Gender = (byte)Reader["Gender"];
                    Address = (string)Reader["Address"];
                    Phone = (string)Reader["Phone"];
                    NationalityCountryID = (int)Reader["NationalityCountryID"];

                    if (Reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)Reader["ThirdName"];

                    else
                        ThirdName = "";

                    if (Reader["Email"] != DBNull.Value)
                        Email = (string)Reader["Email"];

                    else
                        Email = "";
                    

                    if (Reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)Reader["ImagePath"];

                    else
                        ImagePath = "";
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

        public static bool FindPersonByNationalNumber(string NationalNumber, ref int ID, ref string FirstName, ref string SecondName,
            ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender, ref string Address,
            ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE NationalNo = @NationalNumber";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@NationalNumber", SqlDbType.NVarChar).Value = NationalNumber;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    ID = (int)Reader["PersonID"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    LastName = (string)Reader["LastName"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    Gender = (byte)Reader["Gender"];
                    Address = (string)Reader["Address"];
                    Phone = (string)Reader["Phone"];
                    NationalityCountryID = (int)Reader["NationalityCountryID"];

                    if (Reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)Reader["ThirdName"];

                    else
                        ThirdName = "";

                    if (Reader["Email"] != DBNull.Value)
                        Email = (string)Reader["Email"];

                    else
                        Email = "";


                    if (Reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)Reader["ImagePath"];

                    else
                        ImagePath = "";
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

        public static int AddNewPerson(string NationalNumber, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, byte Gender, string Address,
            string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int PersonID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[People]
                                    ([NationalNo]
                                    ,[FirstName]
                                    ,[SecondName]
                                    ,[ThirdName]
                                    ,[LastName]
                                    ,[DateOfBirth]
                                    ,[Gender]
                                    ,[Address]
                                    ,[Phone]
                                    ,[Email]
                                    ,[NationalityCountryID]
                                    ,[ImagePath])
                                VALUES
                                      (@NationalNo,
                                      @FirstName, 
                                      @SecondName,
                                      @ThirdName, 
                                      @LastName,
                                      @DateOfBirth,
                                      @Gender,
                                      @Address,
                                      @Phone,
                                      @Email,
                                      @NationalityCountryID,
                                      @ImagePath);

                                SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@NationalNo", SqlDbType.NVarChar).Value = NationalNumber;
            Command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName;
            Command.Parameters.Add("@SecondName", SqlDbType.NVarChar).Value = SecondName;
            Command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
            Command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = DateOfBirth;
            Command.Parameters.Add("@Gender", SqlDbType.TinyInt).Value = Gender;
            Command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Address;
            Command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone;
            Command.Parameters.Add("@NationalityCountryID", SqlDbType.Int).Value = NationalityCountryID;

            if (ThirdName != "")
                Command.Parameters.Add("@ThirdName", SqlDbType.NVarChar).Value = ThirdName;
            else
                Command.Parameters.Add("@ThirdName", SqlDbType.NVarChar).Value = DBNull.Value;

            if (Email != "")
                Command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email;
            else
                Command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = DBNull.Value;

            if (!string.IsNullOrEmpty(ImagePath))
                Command.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value = ImagePath;
            else
                Command.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value = DBNull.Value;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedPersonID))
                {
                    PersonID = InsertedPersonID;
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

        public static bool UpdatePerson(int ID, string NationalNumber, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, byte Gender, string Address,
            string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE [dbo].[People]
                              SET [NationalNo] = @NationalNo
                                 ,[FirstName] = @FirstName
                                 ,[SecondName] = @SecondName
                                 ,[ThirdName] = @ThirdName
                                 ,[LastName] = @LastName
                                 ,[DateOfBirth] = @DateOfBirth
                                 ,[Gender] = @Gender
                                 ,[Address] = @Address
                                 ,[Phone] = @Phone
                                 ,[Email] = @Email
                                 ,[NationalityCountryID] = @NationalityCountryID
                                 ,[ImagePath] = @ImagePath
                            WHERE PersonID = @ID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@NationalNo", SqlDbType.NVarChar).Value = NationalNumber;
            Command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName;
            Command.Parameters.Add("@SecondName", SqlDbType.NVarChar).Value = SecondName;
            Command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
            Command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = DateOfBirth;
            Command.Parameters.Add("@Gender", SqlDbType.TinyInt).Value = Gender;
            Command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Address;
            Command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone;
            Command.Parameters.Add("@NationalityCountryID", SqlDbType.Int).Value = NationalityCountryID;
            Command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;


            if (ThirdName != "")
                Command.Parameters.Add("@ThirdName", SqlDbType.NVarChar).Value = ThirdName;
            else
                Command.Parameters.Add("@ThirdName", SqlDbType.NVarChar).Value = DBNull.Value;

            if (Email != "")
                Command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email;
            else
                Command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = DBNull.Value;

            if (ImagePath != "")
                Command.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value = ImagePath;
            else
                Command.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value = DBNull.Value;

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

        public static bool DeletePerson(int ID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"DELETE People WHERE PersonID = @ID";

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

        public static DataTable PeopleList()
        {
            DataTable PeopleDataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender =
                             CASE
                                        WHEN Gender = 0 THEN 'Male'
                                        WHEN Gender = 1 THEN 'Female'
                             END,
                                    Address, Phone, Email, CountryName AS Nationality, ImagePath
                             FROM        People INNER JOIN Countries ON
                                        People.NationalityCountryID = Countries.CountryID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    PeopleDataTable.Load(Reader);

                Reader.Close();

                return PeopleDataTable;
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

        public static bool IsPersonExistByID(int ID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Found = 1 FROM People WHERE PersonID = @ID";

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

        public static bool IsPersonExistByNationalNo(string NationalNumber)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Found = 1 FROM People WHERE NationalNo = @NationalNumber";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add("@NationalNumber", SqlDbType.NVarChar).Value = NationalNumber;

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

        public static string GetNationalNumber(int PersonID)
        {
            string NationalNumber = "";

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT NationalNo FROM People WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@PersonID", SqlDbType.Int).Value = PersonID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                    NationalNumber = Result.ToString();
                
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

            return NationalNumber;
        }

        public static int GetPersonID(string NationalNumber)
        {
            int PersonID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT PersonID FROM People WHERE NationalNo = @NationalNumber";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@NationalNumber", SqlDbType.NVarChar).Value = NationalNumber;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int RetreivedPersonID))
                    PersonID = RetreivedPersonID;

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

        public static int GetPersonAge(int PersonID)
        {
            int PersonAge = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT DATEDIFF(year, DateOfBirth, SYSDATETIME()) AS Age FROM People
                             WHERE PersonID = @PersonID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add("@PersonID", SqlDbType.Int).Value = PersonID;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int RetreivedPersonAge))
                    PersonAge = RetreivedPersonAge;

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

            return PersonAge;
        }

        public static int GetTotalPeopleCount()
        {
            int TotalPeopleCount = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT count(*) AS TotalPeople FROM People";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int RetreivedPeopleCount))
                    TotalPeopleCount = RetreivedPeopleCount;

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

            return TotalPeopleCount;
        }
    }
}
