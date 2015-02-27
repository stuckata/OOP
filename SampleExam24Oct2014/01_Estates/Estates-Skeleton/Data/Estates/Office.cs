using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data.Estates
{
    public class Office : BuildingEstate, IOffice
    {
        public Office(EstateType type, string name, double area, string location, bool isFurnished, int rooms, bool hasElevator)
            : base(type, name, area, location, isFurnished, rooms, hasElevator)
        {
        }

        public Office()
        {
            this.Type = EstateType.Office;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
