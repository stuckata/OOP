using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_StudentsJoinedToSpecialties
{
    public class StudentSpecialty
    {
        private string specialtyName;
        private string facultyNumber;

        public StudentSpecialty(string specialtyName, string facultyNumber)
        {
            this.SpecialtyName = specialtyName;
            this.FacultyNumber = facultyNumber;
        }

        public string SpecialtyName
        {
            get
            {
                return this.specialtyName;
            }
            set
            {
                this.specialtyName = value;
            }
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                this.facultyNumber = value;
            }
        }
    }
}
