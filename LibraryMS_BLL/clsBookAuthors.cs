using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS_BLL
{
    public class clsBookAuthors
    {
        public enum enMode { AddBookAuthor = 0, UpdateBookAuthor = 1 };
        public int BookAuthorID { get; set; }
        public int Book_id { get; set; }
        public int Author_id { get; set; }
        public int NewAuthor_id { get; set; }
        enMode Mode = enMode.AddBookAuthor;

       
        public clsBookAuthors()
        {
            Mode = enMode.AddBookAuthor;
            BookAuthorID = -1;
            Author_id = -1;
            Book_id = -1;
            NewAuthor_id = -1;
        }
        private clsBookAuthors(int bookAuthorID, int book_id, int author_id)
        {
            BookAuthorID = bookAuthorID;
            Book_id = book_id;
            Author_id = author_id;
            Mode = enMode.UpdateBookAuthor;
        }

        public clsBookAuthors GetAuthorByBookAuthorID(
            int bookAuthorID)
        {
            int BookId = -1, AuthorId = -1;
            bool isGet = false;
            isGet = LibraryMS_DAL.clsBookAuthors.GetAuthorByBookAuthorID
                (bookAuthorID, ref BookId, ref AuthorId);
            if (isGet)
                return new clsBookAuthors(bookAuthorID, BookId, AuthorId);

            return null;
        
        }

        public static bool isExist(int bookAuthorID)
        {
            return LibraryMS_DAL.clsBookAuthors
                .isExist(bookAuthorID);
        }
        // 
        public bool DeleteAuthor()
        {
            return LibraryMS_DAL.clsBookAuthors
                .DeleteAuthor(BookAuthorID);
        }
        private bool AddBookAuthor()
        {
            bool isAdd = false;
            this.BookAuthorID = LibraryMS_DAL.clsBookAuthors.AddBookAuthor(Book_id, Author_id);

            return isAdd;
        }
        private bool UpdateAuthorId()
        {
            bool isUpdate = false;
            isUpdate = LibraryMS_DAL.clsBookAuthors.UpdateAuthorId(Book_id, Author_id, NewAuthor_id);

            if(isUpdate)
            {
                Author_id = NewAuthor_id;
            }
            return isUpdate;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddBookAuthor:
                    if(AddBookAuthor())
                        return true;
                    else
                        return false;
                case enMode.UpdateBookAuthor:
                    return UpdateAuthorId();
            }
            return false;
        }
        //  
        // 

    }
}
