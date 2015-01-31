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
            IList<Student> students = new List<Student>()
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

            IList<Worker> workers = new List<Worker>()
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
        }
    }
}
