using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS_BLL
{
    public class clsBorrowing
    {
        public static int Member_id { get; set; }
        public static string ExpectedDate { get; set; }
        public static int Borrowing_ID { get; set; }

        // Process_Status 1 Active 0 Not
        public static bool Borrowing
           ()
        {
            Borrowing_ID =  LibraryMS_DAL.clsBorrowing
                .Borrowing(Member_id,ExpectedDate,1);

            return Borrowing_ID > -1;
        }

        public static bool ReturnByBorrowing_ID(int Borrowing_ID)
        {
            return LibraryMS_DAL.clsBorrowing
                .ReturnByBorrowing_ID(Borrowing_ID);
        }

        public static bool DeleteByBorrowing_ID(int borrowing_ID)
        {
            return LibraryMS_DAL.clsBorrowing
                .DeleteByBorrowing_ID(borrowing_ID);
        }

        public static DataTable GetAllBorrowing()
        {
            return LibraryMS_DAL.clsBorrowing.GetAllBorrowing();
        }


    }
}
