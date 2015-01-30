using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    class Teacher : Person
    {
        private List<Discipline> disciplines;

        public Teacher(string details, string name, List<Discipline> disciplines)
            : base(details, name)
        {
            this.Disciplines = disciplines;
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                this.disciplines = value;
            }
        }
    }
}
