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
            IList<Student> students = new List<Student>
            {
                new Student("Bilbo", "Baggins", 19, "123", "245686", "bilbo@shiremail.sh",
                new List<int> { 3, 4, 5, 6 }, "2"),
                new Student("Frodo", "Baggins", 21, "245", "684578", "frodo@underhill.sh",
                new List<int> { 5, 5, 6, 6 }, "2"),
                new Student("Gandolf", "Thegray", 20, "789", "486515", "gandolf@wizards.org",
                new List<int> { 6, 6, 6, 6 }, "1"),
                new Student("Sauron", "Unnamed", 26, "666", "123546", "sauron@mordormail.md",
                new List<int> { 2, 3, 4, 2 }, "6"),
                new Student("Elrond", "Earendil", 23, "007", "888888", "elrond@rivendell.me",
                new List<int> { 2, 3, 4, 2 }, "3"),
                new Student("Aragorn", "Arathorn", 22, "846", "435487", "theking@gondor.gr",
                new List<int> { 6, 6, 5, 6 }, "3"),
            };

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
