using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentOutOfRangeException
                    ("Width or height of a rectangle cannot be negative or equal to zero!");
            }
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}