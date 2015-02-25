using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data
{
    public class Estate : IEstate
    {
        private double area;
        private bool isFurnished;
        private string location;
        private string name;
        private EstateType type;

        public Estate(double area, bool isFurnished, string location, string name, EstateType type)
        {
            this.Area = area;
            this.IsFurnished = isFurnished;
            this.Location = location;
            this.Name = name;
            this.Type = type;
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
    }
}
