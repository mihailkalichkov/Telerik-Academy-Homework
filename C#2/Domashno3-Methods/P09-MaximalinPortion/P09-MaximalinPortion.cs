using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_MaximalinPortion
{
    class Program
    {
        static int[] SortArrayAscending(int[] array)
        {
            int[] sorted = SortArrayDescending(array);
            sorted = sorted.Reverse().ToArray();
            return sorted;
        }
        static int[] SortArrayDescending(int[] array)
        {
            int maxElementIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                maxElementIndex = GetMaximalElement(array, i);
                int swap = array[maxElementIndex];
                array[maxElementIndex] = array[i];
                array[i] = swap;
            }
            return array;
        }
        static int GetMaximalElement(int[] array, int startIndex)
        {
            int maxElement = startIndex;
            for (int i = startIndex + 1; i < array.Length; i++)
            {
                if (array[maxElement] < array[i])
                {
                    maxElement = i;
                }
            }
            return maxElement;
        }
        static void PrintArray(int[] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
        static void Main()
        {
            int[] array = {97, 62, 45, 44, 12, 256, 11, 87, 133, 22, 0, 17 };
            PrintArray(array);
            Console.WriteLine();
            Console.WriteLine(array[GetMaximalElement(array, 8)]);
            int[] sortedArray = SortArrayAscending(array);
            PrintArray(sortedArray);
            sortedArray = SortArrayDescending(array);
            PrintArray(sortedArray);
            Console.WriteLine();
        }
    }
}