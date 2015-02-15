using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_ClassStudent;

namespace _14_StudentsJoinedToSpecialties
{
    public class StudentsJoinedToSpecialtiesTest
    {
        static void Main(string[] args)
        {
            IList<Student> students = StudentsList.GetStudents();
            IList<StudentSpecialty> specialties = new List<StudentSpecialty>()
            {
                new StudentSpecialty("Web Developer", "123314"),
                new StudentSpecialty("Web Developer", "245415"),
                new StudentSpecialty("PHP Developer", "789214"),
                new StudentSpecialty("QA Engineer", "666815"),
                new StudentSpecialty(".NET Developer", "007714"),
                new StudentSpecialty(".NET Developer", "846615"),
            };

            var studentsWithSpecialties =
                from student in students
                join specialty in specialties on student.FacultyNumber equals specialty.FacultyNumber
                orderby student.FirstName
                select new {
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    FacultyNumber = student.FacultyNumber,
                    Specialty = specialty.SpecialtyName
                };
            Console.WriteLine("STUDENTS WITH SPECIALTIES: ");
            Console.WriteLine();

            foreach (var student in studentsWithSpecialties)
            {
                Console.WriteLine("STUDENT: {0} {1} | FACULTY NUMBER: {2} | SPECIALTY: {3}", 
                    student.FirstName, student.LastName, student.FacultyNumber, student.Specialty);
                Console.WriteLine();
            }
        }
    }
}
