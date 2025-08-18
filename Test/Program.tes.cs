using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryMS_BLL;
namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsUser user = new clsUser();
            Console.WriteLine(clsUser.Login("", ""));
            Console.WriteLine(clsUser.Login("Kirollos", "ddd"));
        }
    }
}
