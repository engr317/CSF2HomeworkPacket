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
        }
    }
}
