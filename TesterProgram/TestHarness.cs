using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class TestHarness
    {
        static void Main(string[] args)
        {
            Student Bond = new Student();
            Bond.LastName = "Bond";
            Bond.FirstName = "James";

            Console.WriteLine(Bond);
            

             

            Vehicle v1 = new Vehicle();
            v1.Make = "Dodge";
            v1.Model = "Daytona";
            v1.Year = 1989;
            v1.Weight = 10000f;

            Console.WriteLine(v1);


            Login l1 = new Login();
            l1.UserName = "DSee";
            l1.Password = "StringOfChar";

            Console.WriteLine(l1);



            ContactInfo c1 = new ContactInfo();
            c1.StreetAddress = "1234 Someplace";
            c1.City = "Somewhere";
            c1.State = "ThatState";
            c1.Zip = "00000";
            c1.Phone = "1112223333";
            c1.Email = "You@me.com";


            Console.WriteLine(c1);
        }
    }
}
