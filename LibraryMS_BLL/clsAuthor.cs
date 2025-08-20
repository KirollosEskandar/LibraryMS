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
        public int author_id { get; set; }
        public int Person_id { get; set; }

        public clsAuthor()
        {
            author_id = -1;
            Person_id = -1;
        }

        public bool AddAuthor()
        {
            this.author_id
                = LibraryMS_DAL.clsAuthor
                .AddAuthor(Person_id);
            return author_id > -1;
        }

        public bool DeleteAuthor()
        {
            bool isDelete = false;

            isDelete =  LibraryMS_DAL.clsAuthor
                .DeleteAuthor(this.author_id);
            
            return isDelete;
        }

        public DataTable GetAllAuthor()
        {
            return LibraryMS_DAL.clsAuthor.GetAllAuthor();
        }
    }
}
