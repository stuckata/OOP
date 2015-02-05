using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    class ShapesTest
    {
        static void Main(string[] args)
        {
            List<BasicShape> shapes = new List<BasicShape>()
            {
                new Rectangle(12, 4),
                new Triangle(9, 8.43, 3, 5.6),
                new Circle(4.44)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
                Console.WriteLine("-----------------------------------------------------------------------");
            }
        }
    }
}
