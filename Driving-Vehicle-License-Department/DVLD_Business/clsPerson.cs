using System;
using System.Data;
using System.Diagnostics;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsPerson
    {

        private enum enMode { AddNew = 0 , Update = 1 }
        private enMode _Mode = enMode.AddNew;
        
        public int _PersonID { get; set; }
        public string _FirstName { get; set; }
        public string _SecondName { get; set; }
        public string _ThirdName { get; set; }
        public string _LastName { get; set; }
        public string _NationalNO { get; set; }
        public string _PhoneNumber { get; set; }
        public string _Email { get; set; }
        public string _Address { get; set; }
        public int _NationalityCountryID { get; set; }
        public string _ImagePath { get; set; }
        public byte _Gender { get; set; }
        public DateTime _DateOfBirth { get; set; }


        public clsPerson() 
        { 
            _Mode = enMode.AddNew;
            _FirstName = "";
            _SecondName = "";
            _ThirdName = "";
            _LastName = "";
            _NationalNO = "";
            _Email = "";
            _PhoneNumber = "";
            _Address = "";
            _DateOfBirth = DateTime.Now;
            _NationalityCountryID = -1;
            _Gender = 1;
            _ImagePath = "";
        }

        private clsPerson(int PersonID , string FirstName, string SecondName, string ThirdName, string LastName, string NationalNO, string PhoneNumber, string Email, string Address, int NationalityCountryID, byte Gender, DateTime DateOfBirth, string ImagePath)
        {
            _Mode = enMode.Update;
            _PersonID = PersonID;
            _FirstName = FirstName;
            _SecondName = SecondName;
            _ThirdName = ThirdName;
            _LastName = LastName;
            _NationalNO = NationalNO;
            _PhoneNumber = PhoneNumber;
            _Email = Email;
            _Address = Address;
            _NationalityCountryID = NationalityCountryID;
            _Gender = Gender;
            _DateOfBirth = DateOfBirth;
            _ImagePath = ImagePath;
        }

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeopleFromDataBase();
        }

        public static DataTable GetAllPeopleByFilter(string FilterColumn, string FilterValue)
        {
            string TrueColumnName = string.Empty;

            switch (FilterColumn) {
                case "PersonID":
                    TrueColumnName = "PersonID";
                    break;
                case "FirstName":
                    TrueColumnName = "FirstName";
                    break;
                case "LastName":
                    TrueColumnName = "LastName";
                    break;
                case "Email":
                    TrueColumnName = "Email";
                    break;
                case "Phone":
                    TrueColumnName = "Phone";
                    break;
                case "NO.":
                    TrueColumnName = "NationalNO";
                    break;
                case "Country":
                    TrueColumnName = "Country";
                    break;
            }

            return clsPersonData.GetAllPeopleByFilterFromDataBase(TrueColumnName, FilterValue);
        }

        public static clsPerson Find(int PersonID)
        {
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            string NationalNO = "";
            string PhoneNumber = "";
            string Email = "";
            string Address = "";
            int NationalityCountryID = -1;
            byte Gender = 1;
            DateTime DateOfBirth = DateTime.Now;
            string ImagePath = "";

            if(clsPersonData.GetPerosnInfoById(PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref NationalNO, ref PhoneNumber, ref Email, ref Address, ref NationalityCountryID, ref Gender, ref DateOfBirth, ref ImagePath))
            {
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNO, PhoneNumber, Email, Address, NationalityCountryID, Gender, DateOfBirth, ImagePath);
            }

            return null;
        }


    }
}
