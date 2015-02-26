using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data.Estates
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

        public Garage()
        {
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

        public override string ToString()
        {
            return String.Format("{0}, Width: {1}, Height: {2}", base.ToString(), this.Width, this.Height);
        }
    }
}
