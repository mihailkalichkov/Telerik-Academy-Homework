using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P21_Combinations
{
    class Program
    {
        private static void GenerateCombinations(int[] arr, int numbers,int i, int next)
        {
            if (i==arr.Length)
            {
                Printresult(arr);
                return;
            }

            for (int j = next; j < numbers; j++)
            {
                arr[i] = j;

                GenerateCombinations(arr, numbers, i + 1, j + 1);
            }
        }
        static void Printresult(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] +1 + (i==arr.Length-1?"\n":" "));  
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter set N:");
            int numbers = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements K:");
            int[] arr = new int[int.Parse(Console.ReadLine())];
            GenerateCombinations(arr, numbers, 0, 0);
        }
    }
}