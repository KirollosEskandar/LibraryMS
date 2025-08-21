using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS_BLL
{
    public class clsBorrowingBooks
    {
        public static bool AddBorrowingBook
    (int Book_id, int Borrowing_ID)
        {
            return LibraryMS_DAL.clsBorrowingBooks
                .AddBorrowingBook(Book_id, Borrowing_ID);

        }


        public static bool isExist
(int Book_id, int Borrowing_ID)
        {
            return LibraryMS_DAL.clsBorrowingBooks
                .isExist(Book_id, Borrowing_ID);

        }

        public static DataTable GetAllBookByBorrowing_ID
(int Borrowing_ID)
        {
            return LibraryMS_DAL.clsBorrowingBooks
                .GetAllBookByBorrowing_ID(Borrowing_ID);
        }


    }
}
