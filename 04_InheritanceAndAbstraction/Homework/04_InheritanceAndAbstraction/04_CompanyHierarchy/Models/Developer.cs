using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CompanyHierarchy.Interfaces;
using _04_CompanyHierarchy.Enumerations;
using _04_CompanyHierarchy.Models;

namespace _04_CompanyHierarchy.Models
{
    class Developer : RegularEmployee, IDeveloper
    {
        private List<Project> projects;

        public Developer(string id, string firstName, string lastName, decimal salary,
            DepartmentType.Department department, List<Project> projects)
                : base(id, firstName, lastName, salary, department)
        {
            this.Projects = projects;
        }

        public List<Project> Projects
        {
            get
            {
                return this.projects;
            }
            set
            {
                this.projects = value;
            }
        }
    }
}
