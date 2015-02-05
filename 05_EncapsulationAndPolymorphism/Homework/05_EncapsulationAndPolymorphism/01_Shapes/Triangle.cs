using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    class Triangle : BasicShape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double height, double sideA, double sideB, double sideC)
            : base(height)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideB = sideC;
        }

        public double SideA
        {
            get
            {
                return this.sideA;
            }
            set
            {
                this.sideA = value;
            }
        }

        public double SideB
        {
            get
            {
                return this.sideB;
            }
            set
            {
                this.sideB = value;
            }
        }

        public double SideC
        {
            get
            {
                return this.sideC;
            }
            set
            {
                this.sideC = value;
            }
        }

        public override double CalculateArea()
        {
            double area = this.SideA * this.Height / 2;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = this.SideA + this.SideB + this.sideC;
            return perimeter;
        }

        public override string ToString()
        {
            return String.Format("Triangle | {0}", base.ToString());
        }
    }
}
