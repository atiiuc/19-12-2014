using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Student_App
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<Student> students = new Stack<Student>();
            //String line = "Reg No     Get Full Name" + "\n";

            Student astudent1 = new Student();
            astudent1.regNo = 1234;
            astudent1.firstName = "Amena";
            astudent1.lastName = "Tasneem";
            students.Push(astudent1);

            Student astudent2 = new Student();
            astudent2.regNo = 12345;
            astudent2.firstName = "Amenas";
            astudent2.lastName = "Tasneems";
            students.Push(astudent2);
            foreach (Student aStudent in students )
            {
                Console.WriteLine(aStudent.regNo+" "+aStudent.GetFullName());
            }
            Console.ReadKey();
        }
    }
}
