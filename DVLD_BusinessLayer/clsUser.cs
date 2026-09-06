using System;
using System.Data;
using System.Runtime.CompilerServices;
using DVLD_DataAccessLayer;

namespace DVLD_BusinessLayer
{
    public class clsUser
    {
        private enum enMode : sbyte { enAddNewMode = 1, enUpdateMode = 2 }
        private enMode _Mode = enMode.enAddNewMode;

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsPerson PersonInfo;

        private bool _AddNew()
        {
            this.UserID = clsUsersDataAccess.AddNewUser(this.PersonID, this.Username, this.Password, this.IsActive);

            return this.UserID != -1;
        }

        private bool _Update()
        {
            return clsUsersDataAccess.UpdateUser(this.UserID, this.Username, this.Password, this.IsActive);
        }

        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.Username = "";
            this.Password = "";
            this.IsActive = false;
            this.PersonInfo = new clsPerson();

            _Mode = enMode.enAddNewMode;
        }

        private clsUser(int UserID, int PersonID, string Username, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;
            this.PersonInfo = clsPerson.FindPerson(PersonID);

            _Mode = enMode.enUpdateMode;
        }

        public static clsUser FindUserByID(int UserID)
        {
            int PersonID = -1;
            string Username = "", Password = "";

            bool IsActive = false;

            if (clsUsersDataAccess.FindUserByID(UserID, ref PersonID, ref Username, ref Password, ref IsActive))
                return new clsUser(UserID, PersonID, Username, Password, IsActive);


            else
                return null;
        }

        public static clsUser FindUserByUsernameAndPassword(string Username, string Password)
        {
            int UserID = -1, PersonID = -1;
            bool IsActive = false;

            if (clsUsersDataAccess.FindUserByUsernameAndPassword(ref Username, ref Password, ref UserID, ref PersonID, ref IsActive))
                return new clsUser(UserID, PersonID, Username, Password, IsActive);

            else
                return null;
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUsersDataAccess.DeleteUser(UserID);
        }

        public static DataTable UsersList()
        {
            return clsUsersDataAccess.UsersList();
        }

        public static bool IsUserExistsByID(int UserID)
        {
            return clsUsersDataAccess.IsUserExistsByID(UserID);
        }

        public static bool IsUserExistByPersonID(int PersonID)
        {
            return clsUsersDataAccess.IsUserExistsByPersonID(PersonID);
        }

        public static bool IsUserExistByNationalNumber(string NationalNumber)
        {
            return clsUsersDataAccess.IsUserExistsByNationalNumber(NationalNumber);
        }

        public static bool IsUserExistByUsername(string Username)
        {
            return clsUsersDataAccess.IsUserExistsByUsername(Username);
        }

        public static string GetUsernameByID(int UserID)
        {
            return clsUsersDataAccess.GetUsernameByID(UserID);
        }

        public static int GetTotalUsersCount()
        {
            return clsUsersDataAccess.GetTotalUsersCount();
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.enAddNewMode:
                    if (_AddNew())
                    {
                        _Mode = enMode.enUpdateMode;
                        this.PersonInfo = clsPerson.FindPerson(this.PersonID);
                        return true;
                    }

                    else
                        return false;

                case enMode.enUpdateMode:
                    return _Update();
            }

            return false;
        }
    }
}
