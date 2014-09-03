using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Namespace3DPoint
{
    public class Path
    {
        private List<Point3D> path = new List<Point3D>();

        public void AddPoints(params Point3D[] points)
        {
            foreach (Point3D point in points)
            {
                path.Add(point);
            }
        }

        public override string ToString()
        {
            var pathToString = new StringBuilder();
            foreach (var item in path)
            {
                pathToString.AppendLine(item.ToString());
            }
            return pathToString.ToString();
        }
    }
}