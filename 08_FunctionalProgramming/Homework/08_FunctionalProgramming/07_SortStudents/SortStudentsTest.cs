using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_ClassStudent;

namespace _07_SortStudents
{
    public class SortStudentsTest
    {
        static void Main(string[] args)
        {
            IList<Student> students = StudentsList.GetStudents();

            IList<Student> studentsQueryLambda = students
                .OrderByDescending(s => s.FirstName)
                .ThenBy(s => s.LastName).ToList();

            Console.WriteLine("STUDENTS BY FIRST AND LAST NAME USING LAMBDA EXPRESSION: ");
            Console.WriteLine();

            foreach (var student in studentsQueryLambda)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }

            IEnumerable<Student> studentsQueryLinq =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            Console.WriteLine("============================================================");
            Console.WriteLine();
            Console.WriteLine("STUDENTS BY FIRST AND LAST NAME USING LINQ: ");
            Console.WriteLine();

            foreach (var student in studentsQueryLinq)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }
    }
}
