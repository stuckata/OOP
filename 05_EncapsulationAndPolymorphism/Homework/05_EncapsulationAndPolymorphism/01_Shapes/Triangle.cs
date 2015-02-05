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
        public double TriangleBase;

        public Triangle(double triangleBase, double height, double sideA, double sideB)
            : base(triangleBase, height)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.TriangleBase = triangleBase;
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

        public override void CalculateArea()
        {
            double area = this.SideA + this.SideB + this.TriangleBase;
        }

        public override void CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
