using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data
{
    public class Garage : Estate, IGarage
    {
        private int width;
        private int height;

        public Garage(EstateType type, string name, double area, string location, bool isFurnished, int width, int height)
            : base(type, name, area, location, isFurnished)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.height = value;
            }
        }
    }
}
