using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Point3D;

namespace _03_Paths
{
    class PathsTest
    {
        static void Main()
        {
            string fileLocation = "D:\\Documents\\OOP\\02_StaticMembersAndNamespaces\\Homework\\StaticMembersAndNamespaces\\03_Paths\\TxtStorageFiles";
            string fileName = "Test";
            string path = "Path: ";  

            List<Point3D> points = new List<Point3D>()
            {
                new Point3D(2, 4, 5),
                new Point3D(3.48, 48.56, 8.746),
                new Point3D(1, 1, 1),
                new Point3D(76.485671, 102, 87),
                new Point3D(7, 14.5897, 164.2487),
            };

            for (int i = 0; i < points.Count; i++)
            {
                path += "(" + points[i].CoordinateX + ", " + points[i].CoordinateY + ", " + points[i].CoordinateZ + ")";
                if (i != points.Count - 1)
                {
                    path += "; ";
                }
            }

            Storage.SavePointsPathToTxtFile(path, fileLocation, fileName);
            Storage.ReadPointsPathFromTxtFile(fileLocation, fileName);
        }
    }
}
