using DVLD_DataAccessLayer;
using System;
using System.Data;
using System.Net;

namespace DVLD_BusinessLayer
{
    public class clsPerson
    {
        private enum enMode : sbyte { enAddNewMode = 1, enUpdateMode = 2 }
        private enMode _Mode = enMode.enAddNewMode;

        public int ID { get; set; }
        public string NationalNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth {  get; set; }
        public byte Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }

        private bool _AddNew()
        {
            this.ID = clsPeopleDataAccess.AddNewPerson(this.NationalNumber, this.FirstName, this.SecondName, this.ThirdName,
                this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email,
                this.NationalityCountryID, this.ImagePath);

            return this.ID != -1;
        }

        private bool _Update()
        {
            return clsPeopleDataAccess.UpdatePerson(this.ID, this.NationalNumber, this.FirstName, this.SecondName, this.ThirdName,
                this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email,
                this.NationalityCountryID, this.ImagePath);
        }

        public clsPerson()
        {
            this.ID = -1;
            this.NationalNumber = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = new DateTime();
            this.Gender = 0;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";

            _Mode = enMode.enAddNewMode;
        }

        private clsPerson(int ID, string NationalNumber, string FirstName, string SecondName, string ThirdName,
            string LastName, DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)
        {
            this.ID = ID;
            this.NationalNumber = NationalNumber;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;

            _Mode = enMode.enUpdateMode;
        }

        public static clsPerson FindPerson(int ID)
        {
            string NationalNumber = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "",
                Phone = "", Email = "", ImagePath = "";

            DateTime DateOfBirth = DateTime.Now;

            int NationalityCountryID = -1;
            byte Gender = 0;

            if (clsPeopleDataAccess.FindPersonByID(ID, ref NationalNumber, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(ID, NationalNumber, FirstName, SecondName, ThirdName, LastName,
                DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            }

            else
            {
                return null;
            }
        }

        public static clsPerson FindPerson(string NationalNumber)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "",
                Phone = "", Email = "", ImagePath = "";

            DateTime DateOfBirth = DateTime.Now;

            int NationalityCountryID = -1;
            int ID = -1;
            byte Gender = 0;

            if (clsPeopleDataAccess.FindPersonByNationalNumber(NationalNumber, ref ID, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(ID, NationalNumber, FirstName, SecondName, ThirdName, LastName,
                DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            }

            else
            {
                return null;
            }
        }

        public static bool DeletePerson(int ID)
        {
            return clsPeopleDataAccess.DeletePerson(ID);
        }

        public static DataTable PeopleList()
        {
            return clsPeopleDataAccess.PeopleList();
        }

        public static bool IsPersonExist(int ID)
        {
            return clsPeopleDataAccess.IsPersonExistByID(ID);
        }

        public static bool IsPersonExist(string NationalNumber)
        {
            return clsPeopleDataAccess.IsPersonExistByNationalNo(NationalNumber);
        }

        public static string GetNationalNumber(int PersonID)
        {
            return clsPeopleDataAccess.GetNationalNumber(PersonID);
        }

        public static int GetPersonID(string NationalNumber)
        {
            return clsPeopleDataAccess.GetPersonID(NationalNumber);
        }

        public static int GetPersonAge(int PersonID)
        {
            return clsPeopleDataAccess.GetPersonAge(PersonID);
        }

        public static int GetTotalPeopleCount()
        {
            return clsPeopleDataAccess.GetTotalPeopleCount();
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.enAddNewMode:
                    {
                        if (_AddNew())
                        {
                            _Mode = enMode.enUpdateMode;
                            return true;
                        }

                        else
                            return false;
                    }


                case enMode.enUpdateMode:
                    return _Update();

            }

            return false;
        }
    }
}
