using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Namespace3DPoint
{
    public struct Point3D
    {
        private double x;
        private double y;
        private double z;

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public double Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        public static string CoordStart
        {
            get
            {
                return string.Format("Coordinate start point:\n x = {0}\n y = {1}\n z = {2}", 0, 0, 0);
            }
        }

        public static double CoordStartX
        {
            get
            {
                return 0;
            }
        }

        public static double CoordStartY
        {
            get
            {
                return 0;
            }
        }

        public static double CoordStartZ
        {
            get
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return string.Format(" Point: \n x={0} \n y={1} \n z={2}", x, y, z);
        }
    }
}
