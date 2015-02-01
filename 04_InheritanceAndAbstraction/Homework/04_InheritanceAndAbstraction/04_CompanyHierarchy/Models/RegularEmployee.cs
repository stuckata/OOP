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
    abstract class RegularEmployee : Employee
    {
        public RegularEmployee(string id, string firstName, string lastName, decimal salary, 
            DepartmentType.Department department)
                : base(id, firstName, lastName, salary, department)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
