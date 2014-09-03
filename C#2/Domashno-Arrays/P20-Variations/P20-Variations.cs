using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20_Variations
{
    class Program
    {
        private static void GenerateVariations(int[] array, int elements, int numbers)
        {
            if (elements == -1)
            {
                Print(array);
            }
            else
            {
                for (int i = 1; i <= numbers; i++)
                {
                    array[elements] = i;
                    GenerateVariations(array, elements - 1, numbers);
                }
            }
        }

        private static void Print(int[] array)
        {
            Console.Write("{ ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("}");
        }

        static void Main()
        {
            Console.WriteLine("Enter set N:");
            int numbers = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements K:");
            int elements = int.Parse(Console.ReadLine());

            int[] array = new int[elements];

            GenerateVariations(array, elements - 1, numbers);

        }
    }
}