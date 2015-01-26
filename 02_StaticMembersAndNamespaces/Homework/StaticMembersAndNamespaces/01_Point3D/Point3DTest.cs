using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Point3D
{
    class Point3DTest
    {
        static void Main()
        {
            List<Point3D> points = new List<Point3D>()
            {
                new Point3D(2, 4, 5),
                new Point3D(3.48, 48.56, 8.746),
                new Point3D(1, 1, 1),
                new Point3D(76.485671, 102, 87),
                new Point3D(7, 14.5897, 164.2487),
            };

            foreach (var point in points)
            {
                Console.WriteLine(point);
                Console.WriteLine();
            }
        }
    }
}
