using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CompanyHierarchy.Interfaces;
using _04_CompanyHierarchy.Enumerations;

namespace _04_CompanyHierarchy.Models
{
    abstract class Employee : IEmployee
    {
        private decimal salary;
        private DepartmentType.Department department;

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = value;
            }
        }

        public DepartmentType.Department Department
        {
            get
            {
                return this.department;
            }
            set
            {
                this.department = value;
            }
        }
    }
}
