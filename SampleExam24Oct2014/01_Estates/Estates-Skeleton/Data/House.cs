using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data
{
    public class House : Estate, IHouse
    {
        private int floors;

        public House(EstateType type, string name, double area, string location, bool isFurnished, int floors)
            : base(type, name, area, location, isFurnished)
        {
            this.Floors = floors;
        }

        public int Floors
        {
            get
            {
                return this.floors;
            }

            set
            {
                this.floors = value;
            }
        }
    }
}
