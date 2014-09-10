namespace Task02_SetOfBalls
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            var variations = new VariationsCounter();

            var result = variations.GetVariations(userInput);

            Console.WriteLine(result);
        }
    }
}
