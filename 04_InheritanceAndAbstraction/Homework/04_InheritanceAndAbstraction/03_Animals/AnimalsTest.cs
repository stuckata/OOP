using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animals
{
    class AnimalsTest
    {
        static void Main(string[] args)
        {
            string separator = "===============================================================================";

            List<Animal> animals = new List<Animal>
            {
                new Dog("Pirata", 6, GenderType.Gender.Male),
                new Dog("Sharo", 12, GenderType.Gender.Male),
                new Dog("Mara", 4, GenderType.Gender.Female),
                new Frog("Kichka", 3, GenderType.Gender.Female),
                new Frog("Myrla", 1, GenderType.Gender.Female),
                new Frog("Kikoran", 2, GenderType.Gender.Male),
                new Kitten("Mimka", 7),
                new Kitten("Klera", 1),
                new Kitten("Zlatka", 2),
                new Tomcat("Tom", 7),
                new Tomcat("Burningrom", 10),
                new Tomcat("Floppy", 3),
            };

            Console.WriteLine(separator);

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                animal.ProduceSound();
                Console.WriteLine(separator);
            }

            double dogsAverageAge = animals.FindAll(a => a.GetType() == typeof(Dog)).Average(a => a.Age);
            double frogsAverageAge = animals.FindAll(a => a.GetType() == typeof(Frog)).Average(a => a.Age);
            double kittensAverageAge = animals.FindAll(a => a.GetType() == typeof(Kitten)).Average(a => a.Age);
            double tomcatsAverageAge = animals.FindAll(a => a.GetType() == typeof(Tomcat)).Average(a => a.Age);

            Console.WriteLine("Dogs average age is: {0}", dogsAverageAge);
            Console.WriteLine("Frogs average age is: {0}", frogsAverageAge);
            Console.WriteLine("Kittens average age is: {0}", kittensAverageAge);
            Console.WriteLine("Tomcats average age is: {0}", tomcatsAverageAge);
        }
    }
}
