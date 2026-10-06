using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace DVLD_DataAccess
{
    public class clsPeopleData
    {

        public static DataTable GetAllPeopleFromDataBase()
        {

            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessString.ConnectionString);
            string Query = "Select \r\nPeople.PersonID ,\r\nPeople.NationalNo ,\r\nPeople.FirstName ,\r\nPeople.SecondName ,\r\nPeople.ThirdName ,\r\nPeople.LastName , \r\nCASE \r\n    WHEN People.Gendor = 0 THEN 'Male'\r\n    WHEN People.Gendor = 1 THEN 'Female'\r\nEND AS Gendor ,\r\nPeople.DateOfBirth ,\r\nCountries.CountryName ,\r\nPeople.Phone ,\r\nPeople.Email\r\nFrom People\r\nINNER JOIN Countries ON Countries.CountryID = People.NationalityCountryID\r\n";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try {

                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if(reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }
            catch(Exception ex)
            {


            }
            finally
            {
                Connection.Close();
            }


            return dt;
        }



    }
}
