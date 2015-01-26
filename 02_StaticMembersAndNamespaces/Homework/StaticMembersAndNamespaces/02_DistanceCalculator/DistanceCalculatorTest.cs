using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Point3D;

namespace _02_DistanceCalculator
{
    public class DistanceCalculatorTest
    {
        static void Main()
        {
            Point3D point1 = new Point3D(3.48, 48.56, 8.746);
            Point3D point2 = new Point3D(7, 14.5897, 164.2487);

            double distanceBetweenPoints = DistanceCalculator.CalculateDistanceBetweenTwoPoints3D(point1, point2);

            Console.WriteLine("Point1:");
            Console.WriteLine(point1);
            Console.WriteLine("Point2:");
            Console.WriteLine(point2);
            Console.WriteLine("Distance between them is: " + distanceBetweenPoints);
        }
    }
}
