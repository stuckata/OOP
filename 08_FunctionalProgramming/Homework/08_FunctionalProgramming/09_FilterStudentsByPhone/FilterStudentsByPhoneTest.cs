using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_ClassStudent;

namespace _09_FilterStudentsByPhone
{
    public class FilterStudentsByPhoneTest
    {
        static void Main(string[] args)
        {
            IList<Student> students = StudentsList.GetStudents();

            IEnumerable<Student> studentsQuery =
                from student in students
                where student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") ||
                student.Phone.StartsWith("+359 2")
                select student;

            Console.WriteLine("STUDENTS WITH PHONE NUMBERS STARTING WITH 02/+3592/+359 2: ");
            Console.WriteLine();

            foreach (var student in studentsQuery)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }
    }
}
