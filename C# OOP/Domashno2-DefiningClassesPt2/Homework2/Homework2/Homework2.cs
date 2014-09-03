using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
using Namespace3DPoint;
using Generic;
using Matrix.Common;

namespace Homework2
{
    [Version("1.02")]
    class Homework2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Point3D point1 = new Point3D(2.2, -5, 10.8);
            Console.WriteLine(point1);
            Console.WriteLine(point1.X);

            Console.WriteLine();
            Console.WriteLine(Point3D.CoordStartX);
            Console.WriteLine(Point3D.CoordStartY);
            Console.WriteLine(Point3D.CoordStartZ);
            Console.WriteLine(Point3D.CoordStart);

            Console.WriteLine();
            Point3D point2 = new Point3D(1, 1, 0);
            Point3D point3 = new Point3D(4, 5, 6);
            Console.WriteLine(DistanceBetweenPoints.Calculate(point2, point3));

            Path path1 = new Path();
            path1.AddPoints(point1, point2, point3);
            Path path2 = new Path();
            path2.AddPoints(point3, point1, point2);

            Console.WriteLine();
            PathStorage.SaveStorage(path1);
            PathStorage.SaveStorage(path2);

            Console.WriteLine();
            Path loadPath = new Path();
            loadPath = PathStorage.LoadStorage(@"..\..\PathToLoad.txt");
            Console.WriteLine("Loaded path:\n{0}", loadPath);

            GenericList<int> myList = new GenericList<int>(2);
            myList.Add(10);
            myList.Add(-3);
            myList.Add(5);
            myList.Add(11);
            myList.Add(-2);
            Console.WriteLine("The min in the list="+ myList.Min());
            Console.WriteLine("The max int the lis="+ myList.Max());
            Console.WriteLine();
            Console.WriteLine("The number with index 2 is:"+ myList[2]);
            Console.WriteLine();
            myList.RemoveAt(2);
            //myList.RemoveAt(20);
            Console.WriteLine("List before insertion\n"+ myList.ToString());
            Console.WriteLine();
            myList.InsertAt(2, 100);
            Console.WriteLine("List after insertion\n"+myList.ToString());
            myList.Clear();
            Console.WriteLine();

            var myList2 = new GenericList<string>(1);
            myList2.Add("dcf");
            myList2.Add("dca");
            Console.WriteLine(myList2.ToString());
            Console.WriteLine(myList2.Min());
            Console.WriteLine(myList2.Max());
            Console.WriteLine();
            Console.WriteLine(myList2.Find("dcf"));
            Console.WriteLine(myList2.Find("nm"));

            var matrix1 = new Matrix<int>(3, 4);
            var matrix2 = new Matrix<int>(4, 3);

            if (matrix1)
            {
                Console.WriteLine("Matrix doesn't contain element equal to 0");
            }
            else Console.WriteLine("Matrix contains element equal to 0");
            matrix1[0, 0] = 2;
            matrix1[1, 0] = 5;
            matrix1[2, 0] = -1;
            matrix1[0, 3] = 4;
            matrix2[0, 0] = 4;
            matrix2[1, 1] = -2;
            matrix2[0, 1] = 5;
            matrix2[1, 2] = 7;

            Console.WriteLine(matrix1);
            Console.WriteLine();
            Console.WriteLine(matrix2);
            Console.WriteLine();
            Console.WriteLine((matrix1 * matrix2).ToString());

            var matrx3 = new Matrix<int>(3, 4);
            Console.WriteLine();
            Console.WriteLine((matrx3 - matrix1).ToString());
            matrx3[0, 0] = -20;
            Console.WriteLine();
            Console.WriteLine((matrx3 + matrix1).ToString());
            Console.WriteLine();
            Console.WriteLine((5 * matrix1).ToString());
            Console.WriteLine();

            var martrix4 = new Matrix<double>(2, 2);
            martrix4[0, 0] = 0.2;
            martrix4[0, 1] = 0.2;
            martrix4[1, 0] = 0.2;
            martrix4[1, 1] = 0.2;
            if (martrix4)
            {
                Console.WriteLine("Matrix doesn't contain element equal to 0");
            }
            else Console.WriteLine("Matrix contains element equal to 0");

            Type type = typeof(Homework2);
            object[] allAttr = type.GetCustomAttributes(false);
            foreach (Version ver in allAttr)
            {
                Console.WriteLine("Product version: {0}", ver.ProductVersion);
            }
        }
    }
}