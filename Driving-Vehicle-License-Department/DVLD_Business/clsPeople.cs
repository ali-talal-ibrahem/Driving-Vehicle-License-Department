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

    }
}
