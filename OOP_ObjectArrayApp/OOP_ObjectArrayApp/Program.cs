using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ObjectArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];

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
            students[0] = astudent1;
students[1] = astudent2;
            students[2] = astudent3;

            foreach (Student astudent in students)
            {
                Console.WriteLine(astudent.regNo+" "+astudent.GetFullName());
            }
            Console.ReadKey();

        }
    }
}
