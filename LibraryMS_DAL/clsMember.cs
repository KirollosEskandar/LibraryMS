using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS_DAL
{
    public class clsMember
    {
        public static int AddMember(int Person_id, int Registration_date)
        {
            int id = -1;
            string queryString = "insert Member(Person_id,Registration_date) Values(@Person_id,Registration_date);select SCOPE_IDENTITY();";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Person_id", Person_id);
                cmd.Parameters.AddWithValue("@Registration_date", Registration_date);
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
        public static bool DeleteMember(int Member_id)
        {
            int isDelete = 0;
            string queryString = "delete from Member where Member_id = @Member_id";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Member_id", Member_id);
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
        public static DataTable GetAllMember()
        {
            DataTable dt = new DataTable();
            string queryString = "Select * from Member";

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

        public static bool UpdateMember(int Member_id, int Person_id, int Registration_date)
        {
            int id = 0;
            string queryString = "Update Member set Registration_date = @Registration_date, Person_id = @Person_id where Member_id = @Member_id;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Person_id", Person_id);
                cmd.Parameters.AddWithValue("@Member_id", Member_id);
                cmd.Parameters.AddWithValue("@Registration_date", Registration_date);
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
