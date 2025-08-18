using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Data;

namespace LibraryMS_DAL
{
    public class clsPerson
    {
        static public bool GetPersonById(int Person_id,
            ref string FirstName, ref string LastName, ref string Phone, ref string Email)
        {
            bool isGetPerson = false;
            string queryString = "select * from Person where Person_id = @Person_id;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Person_id", Person_id);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        FirstName = (string)reader["FirstName"];
                        LastName = (string)reader["LastName"];
                        Phone = (string)reader["Phone"];
                        Email = (string)reader["Email"];
                        isGetPerson = true;
                    }
                }
                catch (Exception ex)
                {
                    ///
                }
            }
            return isGetPerson;
        }
        static public DataTable GetAllPersons()
        {
            DataTable Dt = new DataTable();

            string queryString = "select * from Person;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                try
                {
                    conn.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader != null)
                    {
                        Dt.Load(dataReader);
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    ///
                }
            }
            return Dt;
        }
        static public int AddPerson
            (string FirstName, string LastName, string Phone, string Email)
        {
            int id = -1;
            string queryString = "insert into Person(FirstName, LastName, Phone, Email)values(@FirstName,@LastName , @Phone, @Email);select SCOPE_IDENTITY();";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@Email", Email);
                try
                {
                    conn.Open();
                    object obj = cmd.ExecuteScalar();
                    if (obj != null)
                    {
                        id = Convert.ToInt32(obj);
                    }
                }
                catch (Exception ex)
                {
                    ///
                }
            }
            return id;
        }


        static public bool UpdatePerson
    (int Person_id,string FirstName, string LastName, string Phone, string Email)
        {
            int isUpdate = -1;
            string queryString = "Update Person set FirstName = @FirstName, LastName = @LastName, Phone = @Phone ,Email = @Email where Person_id = @Person_id;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Person_id", Person_id);
                try
                {
                    conn.Open();
                    object obj = cmd.ExecuteNonQuery();
                    if (obj != null)
                    {
                        isUpdate = Convert.ToInt32(obj);
                    }
                }
                catch (Exception ex)
                {
                    ///
                }
            }
            return isUpdate > -1;
        }

        static public bool DeletePerson
    (string Email)
        {
            int isDeleted = 0;
            string queryString = "delete from Person where Email = @Email;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Email", Email);
                try
                {
                    conn.Open();
                    object obj = cmd.ExecuteNonQuery();
                    if (obj != null)
                    {
                        isDeleted = Convert.ToInt32(obj);
                    }
                }
                catch (Exception ex)
                {
                    ///
                }
            }
            return isDeleted > 0;
        }

        static public bool DeletePerson
    (int Person_id)
        {
            int isDeleted = 0;
            string queryString = "delete from Person where Person_id = @Person_id;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Person_id", Person_id);
                try
                {
                    conn.Open();
                    object obj = cmd.ExecuteNonQuery();
                    if (obj != null)
                    {
                        isDeleted = Convert.ToInt32(obj);
                    }
                }
                catch (Exception ex)
                {
                    ///
                }
            }
            return isDeleted > 0;
        }
        static public bool isExist
            (string FirstName, string LastName)
        {
            int isFound = 0;
            string queryString = "select 1 from Person where FirstName = @FirstName and LastName = @LastName;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                try
                {
                    conn.Open();
                    object obj = cmd.ExecuteScalar();
                    if (obj != null)
                    {
                        isFound = Convert.ToInt32(obj);
                    }
                }
                catch (Exception ex)
                {
                    ///
                }
            }
            return isFound > 0;
        }

        static public bool isExist
    (int  Person_id)
        {
            int isFound = 0;
            string queryString = "select 1 from Person where Person_id = @Person_id;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Person_id", Person_id);
                try
                {
                    conn.Open();
                    object obj = cmd.ExecuteScalar();
                    if (obj != null)
                    {
                        isFound = Convert.ToInt32(obj);
                    }
                }
                catch (Exception ex)
                {
                    ///
                }
            }
            return isFound > 0;
        }

       

    }
}
