using System;
using Common;

namespace ShapeTests
{
    public class UnitTest1
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Triangle(2.3,5.6),
                new Triangle(102.36,96.32),
                new Triangle(41,5),
                new Rectangle(101.23,55.36),
                new Rectangle(2,69.32),
                new Rectangle(0.2,0.56),
                new Circle(1523.589),
                new Circle(85.365),
                new Circle(0.236),
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }

        }
    }
}
