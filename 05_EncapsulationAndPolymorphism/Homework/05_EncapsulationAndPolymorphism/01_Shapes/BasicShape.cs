using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public BasicShape(double height)
        {
            this.Height = height;
        }

        public BasicShape()
        {
        }

        public double Width 
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

        public double Height
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

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public override string ToString()
        {
            return String.Format("Area: {0} | Perimeter: {1} |", CalculateArea(), CalculatePerimeter());
        }
    }
}
