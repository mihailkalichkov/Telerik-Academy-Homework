using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_IsGivenIndexinArrayBiggerthanNeighbours
{
    class Program
    {
        static bool IsBiggerthanNeighbours(int[] array,int input)
        {
            if (array[input] > array[input - 1] && array[input] > array[input + 1])
            {
                return true;
            }
            else return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length: ");
            int ArrayLength = int.Parse(Console.ReadLine());
            int[] Array = new int[ArrayLength];
            for (int i = 0; i < ArrayLength; i++)
            {
                Console.WriteLine("Enter member number {0}:", i);
                Array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter index:");
            int Index = int.Parse(Console.ReadLine());
            if (Index==0 || Index==ArrayLength-1)
            {
                Console.WriteLine("Only 1 neighbour");
            }
            else
            {
                bool IsBigger = IsBiggerthanNeighbours(Array, Index);
                if (IsBigger)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
               
            }
        }
    }
}
