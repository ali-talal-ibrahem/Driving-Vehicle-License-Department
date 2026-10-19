using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsCountry
    {

        string _CountryName { get; set; }
        int _CountryID { get; set; }

        clsCountry() {
            _CountryID = -1;
            _CountryName = "";
        }

        clsCountry(int CountryID, string CountryName)
        {
            _CountryID = CountryID;
            _CountryName = CountryName;
        }

        public static clsCountry Find(int CountryID)
        {
            string CountryName = "";
            bool IsFound = clsCountriesData.GetCountryInfoByID(CountryID, ref CountryName);

            if (IsFound)
            {
                return new clsCountry(CountryID, CountryName);
            }
            else
            {
                return null;
            }
        }

        public static clsCountry Find(string CountryName)
        {
            int CountryID = -1;
            bool IsFound = clsCountriesData.GetCountryInfoByName(CountryName, ref CountryID);

            if (IsFound)
            {
                return new clsCountry(CountryID, CountryName);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllCountries()
        {
            return clsCountriesData.GetAllCountries();
        }

    }
}
