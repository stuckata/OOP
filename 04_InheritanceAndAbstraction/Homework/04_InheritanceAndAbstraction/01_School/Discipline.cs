using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    class Discipline : School
    {
        private string name;
        private int numberOfLectures;
        private List<Student> students;

        public Discipline(string details, string name, int numberOfLectures, List<Student> students)
            : base(details)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                this.numberOfLectures = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }
    }
}
