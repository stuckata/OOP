using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    class Triangle : BasicShape
    {
        public Triangle(double triangleBase, double height)
            : base(triangleBase, height)
        {
        }

        public override void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public override void CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
