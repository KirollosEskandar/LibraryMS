using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryMS_DAL;
namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Done
            //Person Category Books 
            //Author Member  Users

            //BookAuthors Borrowing
            //BorrowingBooks 

            //bool id = clsBooks.UpdateBook(1,"Update", 2000, 1, 33);
            //Console.WriteLine(id);
            bool b = clsMember.UpdateMember(2, 14, 2020);
            Console.WriteLine(b);

           
        }
    }
}
