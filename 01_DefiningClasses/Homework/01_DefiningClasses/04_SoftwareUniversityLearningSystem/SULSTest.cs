using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SoftwareUniversityLearningSystem
{
    public class SULSTest
    {
        static void Main()
        {
            List<Person> persons = new List<Person>()
            {
                new SeniorTrainer("Petko", "Petkov", 30),
                new JuniorTrainer("Goshko", "Jujev", 25),
                new SeniorTrainer("Teofil", "Stoichkov", 32),
                new JuniorTrainer("Sauron", "Mitev", 28),
                new OnlineStudent("Boris", "Mihailov", 25, "1236549874", 5.26m, "Level 2"),
                new OnsiteStudent("Mitko", "Dimitrov", 32, "4682316583", 5.15m, "Level 1", 4),
                new OnlineStudent("Nasko", "Abadjiev", 28, "4561357846", 4.21m, "Level 2"),
                new OnsiteStudent("Donio", "Petelov", 27, "3545155846", 3.78m, "Level 3", 5),
                new OnlineStudent("Krisko", "Georgiev", 25, "7846545213", 6.00m, "Level 2"),
                new OnsiteStudent("Ivan", "Angelov", 23, "6541321587", 4.68m, "Level 1", 5),
                new DropoutStudent("Krisko", "Georgiev", 28, "7846545213", 2.63m, "Poor Exam Performance."),
                new DropoutStudent("Ivan", "Angelov", 26, "6541321587", 2.41m, "Poor Exam Performance."),
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person);
                Console.WriteLine("===========================================================================");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            List<Person> currentStudents =
                persons
                    .FindAll(p => p.GetType() == typeof(OnlineStudent) || p.GetType() == typeof(OnsiteStudent));

            List<CurrentSudent> currentStudentsList = currentStudents.Cast<CurrentSudent>().ToList();

            List<CurrentSudent> currentStudentsOrderedByAverageGrade = 
                currentStudentsList
                    .OrderByDescending(x => x.AverageGrade).ToList();

            foreach (var student in currentStudentsOrderedByAverageGrade)
            {
                Console.WriteLine(student);
                Console.WriteLine("===========================================================================");
            }
        }
    }
}

