using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS_DAL
{
    public class clsUsers
    {
        static public bool ChangePassword
     (string UserName, string OldPassword,
            string NewPassword)
        {
            int isChange = 0;
            string queryString = "Update Users set Password = @NewPassword where UserName = @UserName and Password = @OldPassword;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@NewPassword", NewPassword);
                cmd.Parameters.AddWithValue("@OldPassword", OldPassword);
                try
                {
                    conn.Open();
                    object obj = cmd.ExecuteNonQuery();
                    if (obj != null)
                    {
                        isChange = Convert.ToInt32(obj);
                    }
                }
                catch (Exception ex)
                {
                    ///
                }
            }
            return isChange > 0;
        }
        public static bool AddUser
            (string UserName, 
            string Password, int Person_id)
        {
            int id = 0;
            string queryString = "insert Users(UserName,Password,Person_id) Values(@UserName,@Password, @Person_id);";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Person_id", Person_id);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);
                try
                {
                    conn.Open();
                    object obj = cmd.ExecuteNonQuery();
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
            return id > 0;
        }
        static public bool isExist
    (string UserName)
        {
            int isFound = 0;
            string queryString = "select 1 from Users where UserName = @UserName;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@UserName", UserName);
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

        static public bool Login
     (string UserName, string Password)
        {
            int isLogin = 0;
            string queryString = "select 1 from Users where UserName = @UserName and Password = @Password;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);
                try
                {
                    conn.Open();
                    object obj = cmd.ExecuteScalar();
                    if (obj != null)
                    {
                        isLogin = Convert.ToInt32(obj);
                    }
                }
                catch (Exception ex)
                {
                    ///
                }
            }
            return isLogin > 0;
        }

        static public bool GetUserByUserName
    (ref string UserName , ref string Password, ref int Person_id)
        {
            bool isFound = false;
            string queryString = "select * from Users where UserName = @UserName;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        isFound = true;

                        UserName = (string)reader["UserName"];
                        Password = (string)reader["Password"];
                        Person_id = (int)reader["Person_id"];
                    }
                }
                catch (Exception ex)
                {
                    ///
                }
            }
            return isFound;
        }
        static public bool DeleteUser
  (string UserName, string Password)
        {
            int isDeleted = 0;
            string queryString = "Delete from Users where UserName = @UserName and Password = @Password;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);
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


        static public DataTable GetAllUsers()
        {
            DataTable dataTable = new DataTable();
            string queryString = "Select * from Users;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    ///
                }
            }
            return dataTable;
        }
    }
}
