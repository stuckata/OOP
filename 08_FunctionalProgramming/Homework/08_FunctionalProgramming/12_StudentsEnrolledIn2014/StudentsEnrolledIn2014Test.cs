using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_ClassStudent;

namespace _12_StudentsEnrolledIn2014
{
    class StudentsEnrolledIn2014Test
    {
        static void Main(string[] args)
        {
            IList<Student> students = StudentsList.GetStudents();

            IEnumerable<Student> studentsQuery =
                from student in students
                where student.FacultyNumber.IndexOf("4") == 5
                select student;

            Console.WriteLine("STUDENTS ENROLLED IN 2014: ");
            Console.WriteLine();

            foreach (var student in studentsQuery)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }
    }
}
