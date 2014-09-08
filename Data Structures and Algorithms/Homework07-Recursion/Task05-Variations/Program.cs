using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05_Combinations
{
    class Program
    {
        private static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            string[] set = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} element: ", i + 1);
                set[i] = Console.ReadLine();
            }

            string[] output = new string[k];
            FindCombinations(0, n, set, output);
        }

        private static void FindCombinations(int index, int n, string[] set, string[] output)
        {
            if (index == output.Length)
            {
                Console.WriteLine(string.Join(" ", output));
                return;
            }

            for (int i = 0; i < set.Length; i++)
            {
                output[index] = set[i];
                FindCombinations(index + 1, n, set, output);
            }
        }
    }
}
