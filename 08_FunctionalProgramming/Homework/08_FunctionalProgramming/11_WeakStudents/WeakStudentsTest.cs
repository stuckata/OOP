using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_ClassStudent;

namespace _11_WeakStudents
{
    public class WeakStudentsTest
    {
        static void Main(string[] args)
        {
            IList<Student> students = StudentsList.GetStudents();

            IEnumerable<Student> studentsQuery =
                from student in students
                where student.Marks.Contains(new List<int> { 2, 2 })
                select student;

            Console.WriteLine("STUDENTS WITH AT LEAST ONE EXCELLENT MARK (6): ");
            Console.WriteLine();

            foreach (var student in studentsQuery)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }
    }
}
