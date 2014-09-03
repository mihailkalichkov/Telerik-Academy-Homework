using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_NumberCounter
{
    class Program
    {
        public static int count;
        public static int Number;
        public static int ArrayLength;
       public static void NumberCount(int[] array, int ArrayLength,int Number)
        {
            for (int i = 0; i <ArrayLength; i++)
            {
                if (array[i] == Number)
                {
                    count++;
                }

            }
            Console.WriteLine(count);

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
            Console.Write("Enter number:");
            int Number = int.Parse(Console.ReadLine());

            NumberCount(Array, ArrayLength, Number);

        }
    }
}
