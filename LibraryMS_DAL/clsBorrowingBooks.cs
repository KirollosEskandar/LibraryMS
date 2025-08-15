using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS_DAL
{
    public class clsBorrowingBooks
    {
        public static bool AddBorrowingBook
    (int Book_id, int Borrowing_ID)
        {
            int id = 0;
            string queryString = "Insert into BorrowingBooks(Book_id,Borrowing_ID) Values(@Book_id, @Borrowing_ID);";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Book_id", Book_id);
                cmd.Parameters.AddWithValue("@Borrowing_ID", Borrowing_ID);
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

        public static bool isExist
(int Book_id, int Borrowing_ID)
        {
            int id = 0;
            string queryString = "select 1 from where Book_id = @Book_id and Borrowing_ID =@Borrowing_ID;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Book_id", Book_id);
                cmd.Parameters.AddWithValue("@Borrowing_ID", Borrowing_ID);
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


        public static DataTable GetAllBookByBorrowing_ID
(int Borrowing_ID)
        {
            DataTable dataTable = new DataTable();
            string queryString = "Select * from BorrowingBooks where Borrowing_ID = @Borrowing_ID;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Borrowing_ID", Borrowing_ID);
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
