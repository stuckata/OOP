using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_ClassStudent;

namespace _04_StudentsByGroup
{
    class StudentsByGroupTest
    {
        static void Main(string[] args)
        {
            IList<Student> students = StudentsList.GetStudents();

            string separator = "=========================";

            Console.WriteLine("ALL STUDENTS LIST: ");
            Console.WriteLine(separator);

            foreach (var student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }

            IEnumerable<Student> studentQuery =
                from student in students
                where student.GroupNumber == "2"
                orderby student.FirstName ascending
                select student;

            Console.WriteLine("STUDENTS BY GROUP: ");
            Console.WriteLine(separator);

            foreach (var student in studentQuery)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }
    }
}
