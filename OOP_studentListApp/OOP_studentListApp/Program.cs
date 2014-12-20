using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_studentListApp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();

            Student astudent1 = new Student();

            astudent1.regNo = 1234;
            astudent1.firstName = "Amena";
            astudent1.lastName = "tasneem";

            Student astudent2 = new Student();
            astudent2.regNo = 12345;
            astudent2.firstName = "AAmena";
            astudent2.lastName = "Tasneem";

            Student astudent3 = new Student();
            astudent3.regNo = 123456;
            astudent3.firstName = "BAmena";
            astudent3.lastName = "Etasneem";
            students.Add(astudent1);
            students.Add (astudent2);
            students.Add(astudent3); ;

            foreach (Student astudent in students)
            {
                Console.WriteLine(astudent.regNo + " " + astudent.GetFullName());
            }
            Console.ReadKey();

        }
    }
}
