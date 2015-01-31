using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_HumanStudentAndWorker
{
    class HumanStudentAndWorkerTest
    {
        static void Main(string[] args)
        {
            string separator = "===============================================================================";

            List<Student> students = new List<Student>()
            {
                new Student("Kacko", "Strugarev", "ADG874234H"),
                new Student("Bater", "Brumkov", "ERG347584J"),
                new Student("Borislav", "Mihailov", "JJJ6782436"),
                new Student("Bateto", "Futbolev", "HUBS85310P"),
                new Student("Frodo", "Baggins", "RING22234H"),
                new Student("Gandolf", "Thegray", "LIGHT12345"),
                new Student("Aragorn", "Arathorn", "RANGER9876"),
                new Student("Bilbo", "Baggins", "RINGBEARER"),
                new Student("Legolas", "Greenleaf", "WOOD546287"),
                new Student("Sauron", "Thenameless", "1452TORULL"),
            };

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Gazo", "Bazov", 1000m, 20m),
                new Worker("Brymbar", "Brymbarov", 200m, 40m),
                new Worker("Ivailo", "Petev", 364m, 40m),
                new Worker("Petel", "Kokoshkov", 258m, 40m),
                new Worker("Dqdo", "Ioco", 196m, 35m),
                new Worker("Edna", "Bulgarka", 480m, 40m),
                new Worker("Agraren", "Tip", 620m, 40m),
                new Worker("Kosio", "Kartofa", 160m, 40m),
                new Worker("Mitko", "Mitev", 120m, 40m),
                new Worker("Jeanne", "dArc", 390m, 40m),
            };

            List<Student> sortedByFacultyNumberStudents = students.OrderBy(s => s.FacultyNumber).ToList();
            List<Worker> sortedByMoneyPerHourWorkers = workers.OrderByDescending(w => w.PaymentPerHour).ToList();

            Console.WriteLine("SORTED STUDENTS");
            Console.WriteLine(separator);

            foreach (var student in sortedByFacultyNumberStudents)
            {
                Console.Write(student);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("SORTED WORKERS");
            Console.WriteLine(separator);

            foreach (var worker in sortedByMoneyPerHourWorkers)
            {
                Console.Write(worker);
            }

            List<Human> people = new List<Human>();
            people.AddRange(students);
            people.AddRange(workers);
            List<Human> peopleSortedByNames = people.OrderBy(p => p.FirstName).ThenBy(p => p.LastName).ToList();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("SORTED WORKERS AND STUDENTS");
            Console.WriteLine(separator);

            foreach (var person in peopleSortedByNames)
            {
                Console.Write(person);
            }
        }
    }
}
