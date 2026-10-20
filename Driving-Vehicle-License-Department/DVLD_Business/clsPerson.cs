using System;
using System.Data;
using System.Diagnostics;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsPerson
    {

        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; } }
        public string NationalNO { get; set; }
        public DateTime DateOfBirth { get; set; }
        public short Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public clsCountry CountryInfo;
        private string _ImagePath;
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }

        public clsPerson()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";

            Mode = enMode.AddNew;
        }
        private clsPerson(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName, string NationalNO, string Phone, string Email, string Address, int NationalityCountryID, short Gendor, DateTime DateOfBirth, string ImagePath)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.NationalNO = NationalNO;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            this.NationalityCountryID = NationalityCountryID;
            this.Gendor = Gendor;
            this.DateOfBirth = DateOfBirth;
            this.ImagePath = ImagePath;
           
            CountryInfo = clsCountry.Find(NationalityCountryID);

            Mode = enMode.Update;
        }
        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonData.AddNewPerson(this.NationalNO,this.FirstName,this.SecondName,this.ThirdName,this.LastName,this.DateOfBirth,this.Gendor,this.Address,this.Phone,this.Email,this.NationalityCountryID,this.ImagePath);
            return (this.PersonID != -1);
        }
        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.PersonID,this.NationalNO,this.FirstName,this.SecondName,this.ThirdName,this.LastName,this.DateOfBirth,this.Gendor,this.Address,this.Phone,this.Email,this.NationalityCountryID,this.ImagePath);
        }
        public static clsPerson Find(int PersonID)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNO = "", Phone = "", Email = "", Address = "", ImagePath = "";
            int NationalityCountryID = -1;
            short Gendor = 0;
            DateTime DateOfBirth = DateTime.Now;

            bool IsFound = clsPersonData.GetPerosnInfoByID(PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref NationalNO, ref Phone, ref Email, ref Address, ref NationalityCountryID, ref Gendor, ref DateOfBirth, ref ImagePath);

            if (IsFound)
            {
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNO, Phone, Email, Address, NationalityCountryID, Gendor, DateOfBirth, ImagePath);
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
            switch (Mode)
            {

                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
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
        public static bool IsPersonExist(string NationalNO)
        {
            return clsPersonData.IsPersonExist(NationalNO);
        }
        public static bool IsPersonExist(int PersonID)
        {
            return clsPersonData.IsPersonExist(PersonID);
        }

    }
}
