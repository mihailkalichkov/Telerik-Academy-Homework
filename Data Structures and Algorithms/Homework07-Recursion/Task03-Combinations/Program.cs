namespace Combinations
{
    using System;
    using System.Linq;

    internal class Combinations
    {
        private static int n;
        private static int k;
        private static int[] combination;

        private static void Main()
        {
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());

            combination = new int[k];

            FindCombinations(combination, 0, 1);
        }

        private static void FindCombinations(int[] combination, int index, int currentNumber)
        {
            if (index == combination.Length)
            {
                // bottom of recursion -> combination is found and printed
                Print();
            }
            else
            {
                for (int i = currentNumber; i <= n; i++)
                {
                    combination[index] = i;
                    FindCombinations(combination, index + 1, i + 1);
                }
            }
        }

        private static void Print()
        {
            Console.WriteLine(string.Join(" ", combination));
        }
    }
}