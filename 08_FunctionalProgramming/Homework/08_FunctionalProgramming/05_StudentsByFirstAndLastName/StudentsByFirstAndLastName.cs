using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_ClassStudent;

namespace _05_StudentsByFirstAndLastName
{
    public class StudentsByFirstAndLastName
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
                where string.Compare(student.FirstName, student.LastName) == -1
                orderby student.FirstName ascending
                select student;

            Console.WriteLine("STUDENTS BY FIRST AND LAST NAME: ");
            Console.WriteLine(separator);

            foreach (var student in studentQuery)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }
    }
}
