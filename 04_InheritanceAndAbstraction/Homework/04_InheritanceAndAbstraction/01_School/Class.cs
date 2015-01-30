using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    class Class : School
    {
        private List<Student> students;
        private List<Teacher> teachers;
        private string textIdentifier;

        public Class(string details, List<Student> students, List<Teacher> teachers, string textIdentifier)
            : base(details)
        {
            this.Students = students;
            this.Teachers = teachers;
            this.TextIdentifier = textIdentifier;
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

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
            }
        }

        public string TextIdentifier
        {
            get
            {
                return this.textIdentifier;
            }
            set
            {
                this.textIdentifier = value;
            }
        }
    }
}
