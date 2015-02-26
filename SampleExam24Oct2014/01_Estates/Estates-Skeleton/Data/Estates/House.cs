using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data.Estates
{
    public class House : Estate, IHouse
    {
        private int floors;

        public House(EstateType type, string name, double area, string location, bool isFurnished, int floors)
            : base(type, name, area, location, isFurnished)
        {
            this.Floors = floors;
        }

        public House()
        {
        }

        public int Floors
        {
            get
            {
                return this.floors;
            }

            set
            {
                Validators.AssertValueIsInRange(value, 0, 10, "Floors");
                this.floors = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}, Floors: {1}", base.ToString(), this.Floors);
        }
    }
}
