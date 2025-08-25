using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS_BLL
{
    public class clsAuthor
    {
        public static int author_id { get; set; }
        public static int Person_id { get; set; }

        public clsAuthor()
        {
            author_id = -1;
            Person_id = -1;
        }

        public static bool AddAuthor()
        {
            author_id
                = LibraryMS_DAL.clsAuthor
                .AddAuthor(Person_id);
            return author_id > -1;
        }

        public static bool DeleteAuthor()
        {
            bool isDelete = false;

            isDelete =  LibraryMS_DAL.clsAuthor
                .DeleteAuthor(author_id);
            
            return isDelete;
        }

        public static DataTable GetAllAuthor()
        {
            return LibraryMS_DAL.clsAuthor.GetAllAuthor();
        }

        static public bool isExist(int id)
        {
            return LibraryMS_DAL.
             clsAuthor.isExist(id);
        }


    }
}
