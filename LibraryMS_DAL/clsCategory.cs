using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS_DAL
{
    public class clsCategory
    {
        static public bool isExist
    (string Name)
        {
            int isFound = 0;
            string queryString = "select 1 from Category where Name = @Name;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Name", Name);
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
    (int Category_id)
        {
            int isFound = 0;
            string queryString = "select 1 from Category where Category_id = @Category_id;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Category_id", Category_id);
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


        static public int AddCategory
    (string Name)
        {
            int id = -1;
            string queryString = "insert Category(Name) Values(@Name);select SCOPE_IDENTITY();";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Name", Name);
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


        static public bool UpdateCategory
    (int Category_id, string Name)
        {
            int isUpdate = 0;
            string queryString = "Update Category set Name = @Name  WHERE Category_id = @Category_id";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Category_id", Category_id);
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
            return isUpdate > 0;
        }


        static public bool DeleteCategory
    (int Category_id)
        {
            int isDelete = 0;
            string queryString = "Delete from Category where Category_id = @Category_id;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Category_id", Category_id);
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


        static public String GetNameCategoryById
    (int Category_id)
        {
            string Name = "";
            string queryString = "Select Name from Category where Category_id = @Category_id;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@Category_id", Category_id);
                try
                {
                    conn.Open();
                    object obj = cmd.ExecuteScalar();
                    if (obj != null)
                    {
                        Name = Convert.ToString(obj);
                    }
                }
                catch (Exception ex)
                {
                    ///
                }
            }
            return Name;
        }

        static public DataTable GetAllCategory()
        {
            DataTable dataTable = new DataTable();
            string queryString = "Select * from Category;";

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
