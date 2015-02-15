using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using _03_ClassStudent;

namespace _08_FilterStudentsByEmailDomain
{
    public class FilterStudentsByEmailDomain
    {
        static void Main(string[] args)
        {
            IList<Student> students = StudentsList.GetStudents();

            IEnumerable<Student> studentsQuery =
                from student in students
                where student.Email.Host == "wizards.org"
                select student;

            Console.WriteLine("STUDENTS WITH DOMAIN @wizards.org: ");
            Console.WriteLine();

            foreach (var student in studentsQuery)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }
    }
}
