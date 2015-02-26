using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data.Estates
{
    public abstract class Estate : IEstate
    {
        private EstateType type;
        private string name;
        private double area;
        private string location;
        private bool isFurnished;     

        public Estate(EstateType type, string name, double area, string location, bool isFurnished)
        {
            this.Type = type;
            this.Name = name;
            this.Area = area;
            this.Location = location;
            this.IsFurnished = isFurnished;        
        }

        public Estate()
        {
        }

        public EstateType Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.type = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public double Area
        {
            get
            {
                return this.area;
            }

            set
            {
                this.area = value;
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }

            set
            {
                this.location = value;
            }
        }

        public bool IsFurnished
        {
            get
            {
                return this.isFurnished;
            }

            set
            {
                this.isFurnished = value;
            }
        }

        public override string ToString()
        {
            return String.Format("  {0}: Name = {1}, Area = {2}, Location = {3}, Furnitured = {4}", 
                this.Type, this.Name, this.Area, this.Location, IsFurnished == true ? "Yes" : "No");
        }
    }
}
