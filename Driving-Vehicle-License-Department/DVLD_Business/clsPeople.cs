using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsPeople
    {

        public static DataTable GetAllPeople()
        {
            return clsPeopleData.GetAllPeopleFromDataBase();
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

            return clsPeopleData.GetAllPeopleByFilterFromDataBase(TrueColumnName, FilterValue);
        }
   
        


    }
}
