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
            Student s1 = new Student();
            s1.LastName = "Wayne";
            s1.FirstName = "Bruce";
            s1.Id = "BWayne";
            s1.Gpa = 3.75f;

            Console.WriteLine("{0} {1} with a school id of {2}, has graduated with a GPA of {3}. ", s1.FirstName, s1.LastName, s1.Id, s1.Gpa);

             

            Vehicle v1 = new Vehicle();
            v1.Make = "Dodge";
            v1.Model = "Daytona";
            v1.Year = 1989;
            v1.Weight = 10000f;

            Console.WriteLine("This is a {0} {1} {2} that weighs {3}lbs", v1.Year, v1.Make, v1.Model, v1.Weight);


            Login l1 = new Login();
            l1.UserName = "DSee";
            l1.Password = "StringOfChar";

            Console.WriteLine("{0} is your username\n{1} is your password", l1.UserName, l1.Password);



            ContactInfo c1 = new ContactInfo();
            c1.StreetAddress = "1234 Someplace";
            c1.City = "Somewhere";
            c1.State = "ThatState";
            c1.Zip = "00000";
            c1.Phone = "1112223333";
            c1.Email = "You@me.com";


            Console.WriteLine("Here is my Contact Information:\n {0},{1}\n {2}\n Zipcode:{3}\n Phone Number:{4}\n Email:{5}", c1.StreetAddress, c1.City, c1.State, c1.Zip, c1.Phone, c1.Email);
        }
    }
}
