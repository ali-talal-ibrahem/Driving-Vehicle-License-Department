using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsCountriesData
    {
        public static DataTable GetAllCountries() {

            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Countries Order by CountryName";
            SqlCommand command = new SqlCommand(query, conn);

            try
            {

                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }
            catch
            {

            }
            finally { 
            conn.Close();
            }

            return dt;

        }

        public static bool GetCountryInfoByID(int CountryID, ref string CountryName)
        {
            bool IsFound = false;
            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT CountryName FROM Countries WHERE CountryID = @CountryID";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    CountryName = reader["CountryName"].ToString();
                    IsFound = true;
                }
                reader.Close();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return IsFound;
        }

        public static bool GetCountryInfoByName(string CountryName, ref int CountryID)
        {
            bool IsFound = false;
            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT CountryID FROM Countries WHERE CountryName = @CountryName";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    CountryID = Convert.ToInt32(reader["CountryID"]);
                    IsFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return IsFound;

        }
    
        
    
    }
}
