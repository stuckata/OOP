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

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            string separator = "------------------------------------------------------------";
            result.AppendLine(base.ToString());
            string employeePosition = String.Format("***Developer*** Projects:");
            result.AppendLine(employeePosition);
            result.AppendLine(separator);
            foreach (var project in this.Projects)
            {
                result.AppendLine(project.ToString());
            }
            return result.ToString();
        }
    }
}
