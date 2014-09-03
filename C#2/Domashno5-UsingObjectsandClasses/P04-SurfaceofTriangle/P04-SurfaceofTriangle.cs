using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_SurfaceofTriangle
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("Find the surface of a triangle by given:");
            Console.WriteLine("1. Side and altitude");
            Console.WriteLine("2. Three side");
            Console.WriteLine("3. Two sides and angle between them");
            Console.Write("Choose a method(Enter 1, 2 or 3): ");
        }
        static void ReadInput()
        {
            int task = int.Parse(Console.ReadLine());
            if (task<1 || task>3)
            {
                Console.WriteLine("Please enter a number between 1 and 3");
            }
            else if (task==1)
            {
                Console.Write("Enter side of triangle:");
                double side= double.Parse(Console.ReadLine());
                Console.Write("Enter altitude:");
                double altitude = double.Parse(Console.ReadLine());
                Console.WriteLine("The surface is {0}", AreabySideandAltitude(side, altitude));
            }
            else if (task==2)
            {
                Console.WriteLine("Enter 3 sides:");
                double FirstSide = double.Parse(Console.ReadLine());
                double SecondSide = double.Parse(Console.ReadLine());
                double ThirdSide = double.Parse(Console.ReadLine());
                Console.WriteLine("The surface is {0}", Areaby3Sides(FirstSide, SecondSide, ThirdSide));
            }
            else
            {
                Console.WriteLine("Enter 2 sides:");
                double FirstSide = double.Parse(Console.ReadLine());
                double SecondSide = double.Parse(Console.ReadLine());
                Console.Write("Enter angle between them(in degrees):");
                double Angle = double.Parse(Console.ReadLine());
                Console.WriteLine("The surface is {0}", Areaby2SidesandAngle(FirstSide, SecondSide, Angle));

            }
        }
        static double AreabySideandAltitude(double side, double altitude)
        {
            double surface = (side * altitude) / 2;
            return surface;
        }
        static double Areaby3Sides(double FirstSide,double SecondSide, double ThirdSide)
        {
            double HalfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            double area = Math.Sqrt(HalfPerimeter * (HalfPerimeter - FirstSide) * (HalfPerimeter - SecondSide) * (HalfPerimeter - ThirdSide));
            return area;
        }
        static double Areaby2SidesandAngle( double FirstSide, double SecondSide, double Angle)
        {
            double Sin = Math.Sin(Angle*Math.PI/180);
            double area = (FirstSide * SecondSide * Sin) / 2;
            return area;
        }

        static void Main(string[] args)
        {
            Menu();
            ReadInput();
        }
    }
}
