using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animals
{
    abstract class Cat : Animal
    {
        public Cat(string name, int age)
            : base(name, age)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Miauuuuuuuu!");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
