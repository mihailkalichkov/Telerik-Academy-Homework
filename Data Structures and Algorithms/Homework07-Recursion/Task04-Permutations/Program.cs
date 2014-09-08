using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            bool[] isUsed = new bool[n];

            FindPermutations(vector, isUsed, 0);
        }

        private static void FindPermutations(int[] vector, bool[] isUsed, int index)
        {
            if (index == vector.Length)
            {
                Print(vector);
                return;
            }

            for (int i = 0; i < vector.Length; i++)
            {
                if (!isUsed[i])
                {
                    isUsed[i] = true;
                    vector[index] = i + 1;

                    FindPermutations(vector, isUsed, index + 1);

                    isUsed[i] = false;
                }
            }
        }

        private static void Print(int[] vector)
        {
            Console.WriteLine(string.Join(" ", vector));
        }
    }
}
