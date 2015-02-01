using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CompanyHierarchy.Interfaces;
using _04_CompanyHierarchy.Enumerations;

namespace _04_CompanyHierarchy.Models
{
    class Project : IProject
    {
        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private StateType.State state;


        public string ProjectName
        {
            get
            {
                return this.projectName;
            }
            set
            {
                this.projectName = value;
            }
        }

        public DateTime ProjectStartDate
        {
            get
            {
                return this.projectStartDate;
            }
            set
            {
                this.projectStartDate = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                this.details = value;
            }
        }

        public StateType.State State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }

        public void CloseProject()
        {
            throw new NotImplementedException();
        }
    }
}
