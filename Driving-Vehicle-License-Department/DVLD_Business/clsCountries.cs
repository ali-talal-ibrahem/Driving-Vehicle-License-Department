using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsCountries
    {

        public static DataTable GetAllCountries()
        {
            return clsCountriesData.GetAllCountries();
        }

    }
}
