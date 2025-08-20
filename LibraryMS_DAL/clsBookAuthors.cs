using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS_DAL
{
    public class clsBookAuthors
    {
        static public bool isExist
    (int bookAuthorID)
        {
            int isFound = 0;
            string queryString = "select 1 from BookAuthors where bookAuthorID = @bookAuthorID;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@bookAuthorID", bookAuthorID);
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
    (int Book_id, int Author_id)
        {
            int isFound = 0;
            string queryString = "select 1 from BookAuthors where Book_id = @Book_id and Author_id = @Author_id;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Author_id", Author_id);
                cmd.Parameters.AddWithValue("@Book_id", Book_id);
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

        static public DataTable GetAuthorByIdBook
(int Book_id)
        {
            DataTable dt = new DataTable();
            string queryString = "select *from BookAuthors where Book_id = @Book_id;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Book_id", Book_id);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    ///
                }
            }
            return dt;
        }

        static public bool GetAuthorByBookAuthorID
(int BookAuthorID, ref int Book_id, ref int Author_id)
        {
            bool isGet = false;
            string queryString = "select *from BookAuthors where BookAuthorID = @BookAuthorID;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@BookAuthorID", BookAuthorID);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    Book_id = (int)reader["Book_id"];
                    Author_id = (int)reader["Author_id"];
                    isGet = true;
                    reader.Close();
                }
                catch (Exception ex)
                {
                    ///
                }
            }
            return isGet;
        }
        static public int AddBookAuthor
    (int Book_id, int Author_id)
        {
            int id = 0;
            string queryString = "insert into BookAuthors(Book_id,Author_id) Values(@Book_id, @Author_id);select SCOPE_IDENTITY()";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Author_id", Author_id);
                cmd.Parameters.AddWithValue("@Book_id", Book_id);
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

        static public bool DeleteAuthor
    (int Book_id, int Author_id)
        {
            int id = 0;
            string queryString = "Delete from BookAuthors where Book_id =@Book_id and Author_id =@Author_id;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Author_id", Author_id);
                cmd.Parameters.AddWithValue("@Book_id", Book_id);
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
        static public bool DeleteAuthor
    (int BookAuthorID)
        {
            int id = 0;
            string queryString = "Delete from BookAuthors where BookAuthorID =@BookAuthorID;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@BookAuthorID", BookAuthorID);
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
        static public bool UpdateAuthorId
    (int Book_id, int OldAuthor_id, int NewAuthor_id)
        {
            int id = 0;
            string queryString = "Update BookAuthors Set Author_id = @NewAuthor_id where Book_id = @Book_id and Author_id = OldAuthor_id";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@OldAuthor_id", OldAuthor_id);
                cmd.Parameters.AddWithValue("@NewAuthor_id", NewAuthor_id);
                cmd.Parameters.AddWithValue("@Book_id", Book_id);
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
    }
}
