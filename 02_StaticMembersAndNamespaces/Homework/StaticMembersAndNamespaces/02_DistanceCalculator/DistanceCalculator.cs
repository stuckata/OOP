using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Point3D;

namespace _02_DistanceCalculator
{
    public static class DistanceCalculator
    {
        public static double CalculateDistanceBetweenTwoPoints3D(Point3D point1, Point3D point2)
        {
            double result = Math.Sqrt(Math.Pow(point1.CoordinateX - point2.CoordinateX, 2) +
                Math.Pow(point1.CoordinateY - point2.CoordinateY, 2) + 
                Math.Pow(point1.CoordinateZ - point2.CoordinateZ, 2));
            return result;
        }
    }
}
