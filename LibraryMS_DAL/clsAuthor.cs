using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryMS_DAL
{
    public class clsAuthor
    {
        public static int AddAuthor(int Person_id)
        {
            int id = -1;
            string queryString = "insert Author(Person_id) Values(@Person_id);select SCOPE_IDENTITY();";

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
        public static bool DeleteAuthor(int author_id)
        {
            int isDelete = 0;
            string queryString = "delete from Author where author_id = @author_id";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@author_id", author_id);
                try
                {
                    conn.Open();
                    object obj = cmd.ExecuteNonQuery();
                    if (obj != null)
                    {
                        isDelete = Convert.ToInt32(obj);
                    }
                }
                catch (Exception ex)
                {
                    ///
                }
            }
            return isDelete > 0;
        }
        public static DataTable GetAllAuthor()
        {
            DataTable dt = new DataTable();
            string queryString = "Select * from Author";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                try
                {
                    conn.Open();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    dt.Load(sqlDataReader);

                    sqlDataReader.Close();
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
