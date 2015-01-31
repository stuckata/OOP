using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animals
{
    class Dog : Animal, ISound
    {
        public Dog(string name, int age, GenderType.Gender gender)
            : base(name, age, gender)
        {

        }

        public void ProduceSound()
        {
            Console.WriteLine("Bau-bau!");
        }

        public override string ToString()
        {
            return String.Format("DOG: {0}; Gender: {1}", base.ToString(), this.Gender);
        }
    }
}
