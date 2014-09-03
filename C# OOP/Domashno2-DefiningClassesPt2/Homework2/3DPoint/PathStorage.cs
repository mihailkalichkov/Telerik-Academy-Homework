using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Namespace3DPoint
{
    public class PathStorage
    {
        static private uint count = 1;

        public static Path LoadStorage(string FilePath)
        {
            var reader = new StreamReader(FilePath, true);
            using (reader)
            {
                string line;
                int[] coords = new int[3];
                Path TempPath = new Path();

                while ((line = reader.ReadLine()) != null)
                {
                    string[] PointCords = line.ToString().Trim().Split();
                    for (int i = 0; i < 3; i++)
                    {
                        coords[i] = int.Parse(PointCords[i]);
                    }
                    TempPath.AddPoints(new Point3D(coords[0], coords[1], coords[2]));
                }
                return TempPath;
            }
        }

        public static void SaveStorage(Path path)
        {
            while (File.Exists(string.Format(@"..\..\path{0}.txt", count))) count++;

            var writer = new StreamWriter(string.Format(@"..\..\path{0}.txt", count), false, Encoding.Unicode);
            using (writer)
            {
                writer.WriteLine(path);
            }
            string filePath = string.Format(@"..\..\path{0}.txt", count);
            Console.WriteLine("Path of points saved in:\n {0}", System.IO.Path.GetFullPath(filePath));

        }
    }
}