using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data
{
    public abstract class BuildingEstate : Estate, IBuildingEstate
    {
        private int rooms;
        private bool hasElevator;    

        public BuildingEstate(EstateType type, string name, double area, string location, bool isFurnished, int rooms, bool hasElevator)
            : base(type, name, area, location, isFurnished)
        {
            this.Rooms = rooms;
            this.HasElevator = hasElevator;
        }

        public int Rooms
        {
            get
            {
                return this.rooms;
            }

            set
            {
                this.rooms = value;
            }
        }

        public bool HasElevator
        {
            get
            {
                return this.hasElevator;
            }

            set
            {
                this.hasElevator = value;
            }
        }
    }
}
