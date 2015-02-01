using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CompanyHierarchy.Enumerations;

namespace _04_CompanyHierarchy.Interfaces
{
    class IEmployee
    {
        decimal Salary
        {
            get;
            set;
        }
        DepartmentType.Department Department
        {
            get;
            set;
        }
    }
}
