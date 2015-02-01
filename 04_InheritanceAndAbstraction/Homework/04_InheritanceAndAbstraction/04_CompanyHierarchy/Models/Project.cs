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

        public Project(string projectName, DateTime projectStartDate, string details, StateType.State state)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            this.State = state;
        }

        public string ProjectName
        {
            get
            {
                return this.projectName;
            }
            set
            {
                Validators.AssertNotEmpty(value, "Project Name");
                Validators.AssertStringSize(value, 1, "Project Name");
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
                Validators.AssertNotEmpty(value, "Details");
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
            this.state = StateType.State.Closed;
        }

        public override string ToString()
        {
            return String.Format("PROJECT: Name: {0}; Start Date: {1}; Details: {2}; State: {3}", 
                this.ProjectName, this.ProjectStartDate, this.Details, this.State);
        }
    }
}
