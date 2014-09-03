namespace AllTasks.Task1
{
    public class Program
    {
        public static void Main()
        {
            Figure testFigure = new Figure(1, 1);
            Figure testRotatedFigure = Figure.RotateFigure(testFigure, 1);
        }
    }
}
