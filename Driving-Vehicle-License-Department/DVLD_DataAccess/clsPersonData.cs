using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Net;
using System.Runtime.InteropServices;
using Microsoft.SqlServer.Server;

namespace DVLD_DataAccess
{
    public class clsPersonData
    {

        public static bool GetPerosnInfoByID(int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName,
            ref string LastName, ref string NationalNO, ref string Phone, ref string Email, ref string Address,
            ref int NationalityCountryID, ref short Gendor, ref DateTime DateOfBirth, ref string ImagePath) 
        { 

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    FirstName = reader["FirstName"].ToString();
                    SecondName = reader["SecondName"].ToString();

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = reader["ThirdName"].ToString();
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    LastName = reader["LastName"].ToString();
                    NationalNO = reader["NationalNO"].ToString();
                    Phone = reader["Phone"].ToString();

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = reader["Email"].ToString();
                    }
                    else {
                        Email = "";
                    }
                    
                    Address = reader["Address"].ToString();
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    Gendor = (byte)reader["Gendor"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = reader["ImagePath"].ToString();
                    }
                    else
                    {
                        ImagePath = "";
                    }
                }
                else { 
                    isFound = false;
                }


                reader.Close();
            }
            catch(Exception ex)
            {
                // Handel Exception
            }
            finally
            {
                connection.Close();
            }


            return isFound;
        }

        public static bool GetPerosnInfoByNationalNO(string NationalNO, ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName,
           ref string LastName, ref string Phone, ref string Email, ref string Address,
           ref int NationalityCountryID, ref short Gendor, ref DateTime DateOfBirth, ref string ImagePath)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE NationalNO = @NationalNO";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNO", NationalNO);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = reader["FirstName"].ToString();
                    SecondName = reader["SecondName"].ToString();

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = reader["ThirdName"].ToString();
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    LastName = reader["LastName"].ToString();
                    Phone = reader["Phone"].ToString();

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = reader["Email"].ToString();
                    }
                    else
                    {
                        Email = "";
                    }

                    Address = reader["Address"].ToString();
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    Gendor = (byte)reader["Gendor"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = reader["ImagePath"].ToString();
                    }
                    else
                    {
                        ImagePath = "";
                    }
                }
                else
                {
                    isFound = false;
                }


                reader.Close();
            }
            catch (Exception ex)
            {
                // Handel Exception
            }
            finally
            {
                connection.Close();
            }


            return isFound;
        }

        public static int AddNewPerson(string FirstName , string SecondName ,  string ThirdName,
            string LastName,  string Phone,  string Email,  string Address,
            int NationalityCountryID,  short Gendor,  DateTime DateOfBirth,  string ImagePath) 
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO People (FirstName , SecondName , ThirdName , LastName , Phone , Email
                             Address , NationalityCountryID , Gendor , DateOfBirth , ImagePath)
                            VALUES (@FirstName , @SecondName , @ThirdName , @LastName , @Phone , @Email
                             @Address , @NationalityCountryID , @Gendor , @DateOfBirth , @ImagePath) 
                              SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);

            if (ThirdName != "" && ThirdName != null)
            {
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else {
                command.Parameters.AddWithValue("@ThirdName",System.DBNull.Value);
            }

            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);

            if (Email != "" && Email != null)
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            }

            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);


            if (ImagePath != "" && ImagePath != null)
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertID)) {
                    PersonID = InsertID;
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }



            return PersonID;
        }

        public static bool UpdatePerson(int PersonID, string FirstName, string SecondName, string ThirdName,
            string LastName, string Phone, string Email, string Address,
            int NationalityCountryID, short Gendor, DateTime DateOfBirth, string ImagePath)
        {
            int rowEffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE People
                            SET FirstName = @FirstName,
                                LastName = @LastName,
                                ThirdName = @ThirdName,
                                SecondName = @SecondName,
                                Phone = @Phone,
                                Email = @Email,
                                Address = @Address,
                                NationalityCountryID = @NationalityCountryID,
                                Gendor = @Gendor,
                                DateOfBirth = @DateOfBirth,
                                ImagePath = @ImagePath,
                            Where PersonID = @PersonID;"
                                ;

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);

            if (ThirdName != "" && ThirdName != null)
            {
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else
            {
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            }

            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);

            if (Email != "" && Email != null)
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            }

            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);


            if (ImagePath != "" && ImagePath != null)
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }


            try
            {

                connection.Open();
                rowEffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally {
                connection.Close();
            }


            return (rowEffected > 0);
        }

        public static bool DeletePerson(int PersonID) {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete People where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }
        public static DataTable GetAllPeopleFromDataBase()
        {

            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select People.PersonID ,People.NationalNo ," +
                           "People.FirstName ,People.SecondName ,People.ThirdName ,People.LastName , " +
                           "CASE WHEN People.Gendor = 0 THEN 'Male' WHEN People.Gendor = 1 THEN 'Female' END AS Gendor ," +
                           "People.DateOfBirth ,Countries.CountryName ,People.Phone ,People.Email From People INNER JOIN Countries ON Countries.CountryID = People.NationalityCountryID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {

                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {


            }
            finally
            {
                Connection.Close();
            }


            return dt;
        }
        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found = 1 WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();

            }
            catch (Exception ex)
            {
                //Handel
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }
        public static bool IsPersonExist(string NationalNO) 
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found = 1 WHERE NationalNO = @NationalNO";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNO", NationalNO);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();

            }
            catch (Exception ex)
            {
                //Handel
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
    
    
    }
}
