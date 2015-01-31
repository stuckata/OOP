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
        }
    }
}
