using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_FindingGivenSuminSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter S: ");
            int S = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array length: ");
            int ArrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[ArrayLength];
            int[] ResultArray = new int[3];
            int sum=0;
            for (int i = 0; i < ArrayLength; i++)
            {
                Console.WriteLine("Enter member number {0}:", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < ArrayLength-2; i++)
            {
                sum = array[i] + array[i + 1] + array[i + 2];
                if (sum==S)
                {
                    Console.WriteLine("{0}, {1}, {2}", array[i], array[i+1], array[i+2]);
                }
            }

        }
    }
}
