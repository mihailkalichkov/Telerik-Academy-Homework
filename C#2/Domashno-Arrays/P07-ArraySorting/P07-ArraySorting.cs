using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_ArraySorting
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter array length: ");
            int ArrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[ArrayLength];

            for (int i = 0; i < ArrayLength; i++)
            {
                Console.WriteLine("Enter member number {0}:", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < ArrayLength; i++)
            {
                int min = i;
                for (int j = i+1; j < ArrayLength; j++)
                {
                    if (array[j]<array[i])
                    {
                        min=j;
                    }
                }
                int interim = array[i];
                array[i] = array[min];
                array[min] = interim;
            }
            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < ArrayLength; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
