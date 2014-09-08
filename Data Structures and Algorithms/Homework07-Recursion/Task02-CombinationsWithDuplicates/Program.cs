using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02_CombinationsWithDuplicates
{
    class Program
    {
        private static int n;
        private static int k;
        private static int[] variation;

        static void Main()
        {
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());

            variation = new int[k];

            FindVariation(0);
        }

        private static void FindVariation(int currentNumber)
        {
            if (currentNumber == k)
            {
                Print();
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                variation[currentNumber] = i;
                FindVariation(currentNumber + 1);
            }
        }

        private static void Print()
        {
            Console.WriteLine(string.Join(" ", variation));
        }
    }
}
