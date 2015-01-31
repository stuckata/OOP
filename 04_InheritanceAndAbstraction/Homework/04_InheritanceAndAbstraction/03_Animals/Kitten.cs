using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animals
{
    class Kitten : Cat
    {
        private const GenderType.Gender GENDER = GenderType.Gender.Female;

        public Kitten(string name, int age)
            : base(name, age)
        {

        }

        public override string ToString()
        {
            return String.Format("KITTEN: {0}; Gender: {1}", base.ToString(), GENDER);
        }
    }
}
