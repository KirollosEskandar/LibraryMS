using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS_BLL
{
    public class clsBooks
    {
        public enum enMode { AddBook = 0, UpdateBook = 1 };
        enMode Mode = enMode.AddBook;
        public int Book_id { get; set; }
        public string Title { get; set; }
        public int Publication_Year { get; set; }
        public int Category_id { get; set; }
        public int Available_Copies { get; set; }

        public clsBooks()
        {
            Book_id = -1;
            Title = string.Empty;
            Publication_Year = -1;
            Category_id = -1;
            Available_Copies = -1;
            Mode = enMode.AddBook;
        }
        private clsBooks(int book_id, string title, int publication_Year, int category_id, int available_Copies)
        {
            Mode = enMode.UpdateBook;
            Book_id = book_id;
            Title = title;
            Publication_Year = publication_Year;
            Category_id = category_id;
            Available_Copies = available_Copies;
        }

        private bool _AddBook()
        {
            this.Book_id =
                LibraryMS_DAL.clsBooks.AddBook(Title, Publication_Year, Category_id, Available_Copies);

            return Book_id > -1;
        }

        private bool _UpdateBook()
        {
            bool isUpdate = false;
            isUpdate = LibraryMS_DAL.clsBooks.UpdateBook(Book_id, Title, Publication_Year, Category_id, Available_Copies);

            return isUpdate;
        }


        public bool _Save()
        {
            switch (Mode)
            {
                case enMode.AddBook:
                    if (_AddBook())
                    {
                        Mode = enMode.UpdateBook;
                        return true;
                    }
                    else
                        return false;
                case enMode.UpdateBook:
                    return _UpdateBook();

            }
            return false;
        }

        public clsBooks GetBookById(int BookId)
        {
            string title = String.Empty;
            int publication_Year = -1;
            int category_id = -1;
            int available_Copies = -1;
            bool isGet = false;
            isGet = LibraryMS_DAL.clsBooks.GetBookById(
                    Book_id, ref title, ref publication_Year, ref category_id, ref available_Copies);

            if (isGet)
                return new clsBooks(BookId, title, publication_Year, category_id, available_Copies);
            return null;
        }

        static public bool isExist(int BookId)
        {
            return LibraryMS_DAL
                .clsBooks.isExist(BookId);
        }
        static public DataTable GetAllBooks()
        {
            return LibraryMS_DAL.clsBooks
                .GetAllBooks();
        }
        public bool DeleteBook
    (int Book_id)
        {
            return LibraryMS_DAL.clsBooks.DeleteBook(Book_id);
        }

        
    }
}
