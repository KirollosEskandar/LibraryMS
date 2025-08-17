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

            user = user._GetUserByUserName("MyTest");
            Console.WriteLine(user.UserName);
            Console.WriteLine(user.Password);
            Console.WriteLine(user.Person_id);
            Console.WriteLine(user.Mode);
            user._Save("ChangeTest");
           
        }
    }
}
