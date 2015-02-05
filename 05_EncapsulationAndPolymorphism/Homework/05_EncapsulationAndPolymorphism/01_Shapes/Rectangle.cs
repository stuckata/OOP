using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    class Rectangle : BasicShape
    {
        public Rectangle(double width, double height)
            : base(width, height)
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
