using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ClassStudent
{
    class StudentTest
    {
        static void Main(string[] args)
        {
            IList<Student> students = StudentsList.GetStudents();

            foreach (var student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }
    }
}
