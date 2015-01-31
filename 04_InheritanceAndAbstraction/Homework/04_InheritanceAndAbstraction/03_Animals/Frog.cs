using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animals
{
    class Frog : Animal
    {
        public Frog(string name, int age, GenderType.Gender gender)
            : base(name, age, gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Kva-kva!");
        }

        public override string ToString()
        {
            return String.Format("FROG: {0}; Gender: {1}", base.ToString(), this.Gender);
        }
    }
}
