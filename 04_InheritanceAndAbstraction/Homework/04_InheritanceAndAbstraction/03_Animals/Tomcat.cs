using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animals
{
    class Tomcat : Cat
    {
        private const GenderType.Gender GENDER = GenderType.Gender.Male;

        public Tomcat(string name, int age)
            : base(name, age)
        {

        }
    }
}
