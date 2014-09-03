using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class Circle : Shape
    {
        private const double pi = Math.PI;

        public Circle(double radius)
            : base(radius, radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException
                    ("Radius of a circle cannot be negative or equal to zero!");
            }
        }

        public override double CalculateSurface()
        {
            return pi * this.Width * this.Width;
        }
    }
}