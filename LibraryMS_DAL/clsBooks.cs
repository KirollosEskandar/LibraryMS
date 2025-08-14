using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS_DAL
{
    public class clsBooks
    {

        static public DataTable GetAllBooks()
        {
            DataTable Dt = new DataTable();

            string queryString = "select * from Books;";

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
        static public bool GetBookById
            (int Book_id, ref string Title,
            ref int Publication_Year, 
            ref int Category_id, ref int Available_Copies)
        {
            bool isGetBooks = false;
            string queryString = "select * from Books where Book_id = @Book_id;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Book_id", Book_id);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Title = (string)reader["Title"];
                        Publication_Year = (int)reader["Publication_Year"];
                        Category_id = (int)reader["Category_id"];
                        Available_Copies = (int)reader["Available_Copies"];
                        isGetBooks = true;
                    }
                }
                catch (Exception ex)
                {
                    ///
                }
            }
            return isGetBooks;
        }
        static public int AddBook
            (string Title, int Publication_Year,
            int Category_id, int Available_Copies)
        {
            int id = -1;
            string queryString = "insert into Books(Title, Publication_Year, Category_id, Available_Copies)values(@Title,@Publication_Year , @Category_id, @Available_Copies);select SCOPE_IDENTITY();";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Publication_Year", Publication_Year);
                cmd.Parameters.AddWithValue("@Category_id", Category_id);
                cmd.Parameters.AddWithValue("@Available_Copies", Available_Copies);
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


        static public bool UpdateBook
      (int Book_id, string Title, int Publication_Year,
      int Category_id, int Available_Copies)
        {
            int isUpdated = 0;
            string queryString = "Update  Books set Title = @Title, Publication_Year = @Publication_Year , Category_id = @Category_id, Available_Copies= @Available_Copies where Book_id = @Book_id;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Book_id", Book_id);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Publication_Year", Publication_Year);
                cmd.Parameters.AddWithValue("@Category_id", Category_id);
                cmd.Parameters.AddWithValue("@Available_Copies", Available_Copies);
                try
                {
                    conn.Open();
                    object obj = cmd.ExecuteNonQuery();
                    if (obj != null)
                    {
                        isUpdated = Convert.ToInt32(obj);
                    }
                }
                catch (Exception ex)
                {
                    ///
                }
            }
            return isUpdated > 0;
        }

        static public bool DeleteBook
    (string Title)
        {
            int isDeleted = 0;
            string queryString = "delete from Books where Title = @Title;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Title", Title);
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

        static public bool DeleteBook
    (int Book_id)
        {
            int isDeleted = 0;
            string queryString = "delete from Books where Book_id = @Book_id;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Book_id", Book_id);
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
            (string Title)
        {
            int isFound = 0;
            string queryString = "select 1 from Books where Title = @Title;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Title", Title);
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
    (int Book_id)
        {
            int isFound = 0;
            string queryString = "select 1 from Books where Book_id = @Book_id;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
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

    }
}
