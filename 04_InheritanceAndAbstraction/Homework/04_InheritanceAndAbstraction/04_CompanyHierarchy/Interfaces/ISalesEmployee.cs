﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CompanyHierarchy.Models;

namespace _04_CompanyHierarchy.Interfaces
{
    interface ISalesEmployee
    {
        List<Sale> Sales
        {
            get;
            set;
        }
    }
}
