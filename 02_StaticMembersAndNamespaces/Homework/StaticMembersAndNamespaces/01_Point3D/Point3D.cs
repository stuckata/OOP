using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Point3D
{
    public class Point3D
    {
        private float coordinateX;
        private float coordinateY;
        private float coordinateZ;
        private static readonly Point3D StartingPoint = new Point3D( 0, 0, 0 );

        public Point3D(float coordinateX, float coordinateY, float coordinateZ)
        {
            this.CoordinateX = coordinateX;
            this.CoordinateY = coordinateY;
            this.CoordinateZ = coordinateZ;
        }

        public float CoordinateX
        {
            get
            {
                return coordinateX;
            }
            set
            {
                coordinateX = value;
            }
        }

        public float CoordinateY
        {
            get
            {
                return coordinateY;
            }
            set
            {
                coordinateY = value;
            }
        }

        public float CoordinateZ
        {
            get
            {
                return coordinateZ;
            }
            set
            {
                coordinateZ = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            string startingPointCoordinates = String.Format(
                "The Starting Point of 3D coordinate system is: Center({0}, {1}, {2})", 
                StartingPoint.CoordinateX, StartingPoint.CoordinateY, StartingPoint.CoordinateZ);
            result.AppendLine(startingPointCoordinates);
            string point3DCoordinates = String.Format("Point3D({0}, {1}, {2})", 
                this.CoordinateX, this.CoordinateY, this.CoordinateZ);
            return result.ToString();
        }
    }
}
