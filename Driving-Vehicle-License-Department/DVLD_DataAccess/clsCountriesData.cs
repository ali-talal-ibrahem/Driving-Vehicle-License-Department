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

            SqlConnection conn = new SqlConnection(clsDataAccessString.ConnectionString);
            string query = "SELECT * FROM Countries";
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
  
    
    }
}
