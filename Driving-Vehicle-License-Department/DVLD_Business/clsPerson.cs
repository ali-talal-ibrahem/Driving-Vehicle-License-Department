using System;
using System.Data;
using System.Diagnostics;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsPerson
    {

        private enum enMode { AddNew = 0, Update = 1 }
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
        public short _Gendor { get; set; }
        public DateTime _DateOfBirth { get; set; }
        public clsCountry CountryInfo;
        private string __ImagePath;
        public string _ImagePath
        {
            get { return __ImagePath; }
            set { __ImagePath = value; }
        }

        public clsPerson()
        {
            _Mode = enMode.AddNew;
            _PersonID = -1;
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
            _Gendor = 0;
            _ImagePath = "";
        }
        private clsPerson(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName, string NationalNO, string PhoneNumber, string Email, string Address, int NationalityCountryID, short Gendor, DateTime DateOfBirth, string ImagePath)
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
            _Gendor = Gendor;
            _DateOfBirth = DateOfBirth;
            _ImagePath = ImagePath;
            CountryInfo = clsCountry.Find(NationalityCountryID);

        }
        private bool _AddNewPerson()
        {
            _PersonID = clsPersonData.AddNewPerson(_FirstName, _SecondName, _ThirdName, _LastName, _PhoneNumber, _Email, _Address, _NationalityCountryID, _Gendor, _DateOfBirth, _ImagePath);
            return (_PersonID != -1);
        }
        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(_PersonID, _FirstName, _SecondName, _ThirdName, _LastName, _PhoneNumber, _Email, _Address, _NationalityCountryID, _Gendor, _DateOfBirth, _ImagePath);
        }
        public static clsPerson Find(int PersonID)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNO = "", PhoneNumber = "", Email = "", Address = "", ImagePath = "";
            int NationalityCountryID = -1;
            short Gendor = 0;
            DateTime DateOfBirth = DateTime.Now;

            bool IsFound = clsPersonData.GetPerosnInfoByID(PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref NationalNO, ref PhoneNumber, ref Email, ref Address, ref NationalityCountryID, ref Gendor, ref DateOfBirth, ref ImagePath);

            if (IsFound)
            {
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNO, PhoneNumber, Email, Address, NationalityCountryID, Gendor, DateOfBirth, ImagePath);
            }
            else
            {
                return null;
            }
        }
        public static clsPerson Find(string NationalNO)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", PhoneNumber = "", Email = "", Address = "", ImagePath = "";
            int NationalityCountryID = -1;
            int PersonID = -1;
            short Gendor = 0;
            DateTime DateOfBirth = DateTime.Now;

            bool IsFound = clsPersonData.GetPerosnInfoByNationalNO(NationalNO, ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref PhoneNumber, ref Email, ref Address, ref NationalityCountryID, ref Gendor, ref DateOfBirth, ref ImagePath);

            if (IsFound)
            {
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNO, PhoneNumber, Email, Address, NationalityCountryID, Gendor, DateOfBirth, ImagePath);
            }
            else
            {
                return null;
            }
        }
        public bool Save()
        {
            switch (_Mode)
            {

                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePerson();
            }

            return false;
        }
        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeopleFromDataBase();
        }
        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }
        public static bool IsPersonExists(string NationalNO)
        {
            return clsPersonData.IsPersonExist(NationalNO);
        }
        public static bool IsPersonExists(int PersonID)
        {
            return clsPersonData.IsPersonExist(PersonID);
        }

    }
}
