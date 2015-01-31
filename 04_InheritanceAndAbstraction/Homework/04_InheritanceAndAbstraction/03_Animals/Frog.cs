using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animals
{
    class Frog : Animal, ISound
    {
        public Frog(string name, int age, GenderType gender)
            : base(name, age, gender)
        {

        }

        public void ProduceSound()
        {
            Console.WriteLine("Kva-kva!");
        }
    }
}
