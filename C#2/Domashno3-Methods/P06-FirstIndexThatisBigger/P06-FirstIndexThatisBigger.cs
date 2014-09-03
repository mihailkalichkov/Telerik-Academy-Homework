using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_FirstIndexThatisBigger
{
    class Program
    {
        static int IsBiggerthanNeighbours(int[] array)
        {
            for (int i = 1; i < array.Length-1; i++)
            {

                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    return i;
                }
            }
             return (-1);
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
            Console.WriteLine(IsBiggerthanNeighbours(Array));           
        }
    }
}
