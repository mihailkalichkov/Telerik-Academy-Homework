namespace AllTasks.Task1
{
    using System;

    public class Figure
    {
        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public static Figure RotateFigure(Figure currentFigure, double rotationAngleInRadians)
        {
            double rotatedWidth = (Math.Abs(Math.Cos(rotationAngleInRadians)) * currentFigure.Width) +
                                 (Math.Abs(Math.Sin(rotationAngleInRadians)) * currentFigure.Height);
            double rotatedHeight = (Math.Abs(Math.Sin(rotationAngleInRadians)) * currentFigure.Width) +
                                 (Math.Abs(Math.Cos(rotationAngleInRadians)) * currentFigure.Height);
            Figure rotatedFigure = new Figure(rotatedWidth, rotatedHeight);

            return rotatedFigure;
        }
    }
}
