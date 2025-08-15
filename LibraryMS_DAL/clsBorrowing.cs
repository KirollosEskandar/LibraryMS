using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS_DAL
{
    public class clsBorrowing
    {
        public static int Borrowing
            (int Member_id,
             string ExpectedDate,
            int Process_Status = 1)
        {
            // "yyyy-MM-dd"
            DateTime Expected_Return_Date = DateTime.Today.AddDays(7);
            ExpectedDate = Expected_Return_Date.ToString("yyyy-MM-dd");
            int id = 0;
            string queryString = "insert into Borrowing(Member_id, Expected_Return_Date,Process_Status) Values(@Member_id,@ExpectedDate,@Process_Status);select SCOPE_IDENTITY()";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Member_id", Member_id);
                cmd.Parameters.AddWithValue("@ExpectedDate", ExpectedDate);
                cmd.Parameters.AddWithValue("@Process_Status", Process_Status);
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

        public static bool ReturnByBorrowing_ID(int Borrowing_ID)
        {
            // 0 Main Books is Return
            int Process_Status = 0;
            DateTime Actual_Return_Date = DateTime.Today;
            string Actual_Return = Actual_Return_Date.ToString("yyyy-MM-dd");
            int id = 0;
            string queryString = "Update Borrowing set Actual_Return_Date = @Actual_Return, Process_Status = @Process_Status where Borrowing_ID = @Borrowing_ID;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Borrowing_ID", Borrowing_ID);
                cmd.Parameters.AddWithValue("@Actual_Return", Actual_Return);
                cmd.Parameters.AddWithValue("@Process_Status", Process_Status);
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

        public static bool ReturnByMember_id(int Member_id)
        {
            // 0 Main Books is Return
            int Process_Status = 0;
            DateTime Actual_Return_Date = DateTime.Today;
            string Actual_Return = Actual_Return_Date.ToString("yyyy-MM-dd");
            int id = 0;
            string queryString = "Update Borrowing set Actual_Return_Date = @Actual_Return, Process_Status = @Process_Status where Member_id = @Member_id;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Member_id", Member_id);
                cmd.Parameters.AddWithValue("@Actual_Return", Actual_Return);
                cmd.Parameters.AddWithValue("@Process_Status", Process_Status);
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

        public static bool DeleteByBorrowing_ID(int Borrowing_ID)
        {
            int id = 0;
            string queryString = "Delete from Borrowing where Borrowing_ID = @Borrowing_ID;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
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

        public static DataTable GetAllBorrowing()
        {
            DataTable dt = new DataTable();
            string queryString = "Select * from Borrowing;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
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


    }
}
