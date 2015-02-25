using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data
{
    public class Apartment : BuildingEstate, IApartment
    {
        public Apartment(EstateType type, string name, double area, string location, bool isFurnished, int rooms, bool hasElevator)
            : base(type, name, area, location, isFurnished, rooms, hasElevator)
        {                
        }
    }
}
