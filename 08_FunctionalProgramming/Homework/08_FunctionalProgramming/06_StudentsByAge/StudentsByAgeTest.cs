using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_ClassStudent;

namespace _06_StudentsByAge
{
    class StudentsByAgeTest
    {
        static void Main(string[] args)
        {
            IList<Student> students = StudentsList.GetStudents();

            IEnumerable<Student> studentQuery =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            foreach (var student in studentQuery)
            {
                Console.WriteLine("STUDENT: " + student.FirstName + " " + student.LastName + " " + student.Age);
            }
        }
    }
}
