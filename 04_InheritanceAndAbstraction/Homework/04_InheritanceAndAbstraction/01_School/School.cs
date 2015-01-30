using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    abstract class School
    {
        private string Details;

        public School(string details = null)
        {
            this.Details = details;
        }
    }
}
