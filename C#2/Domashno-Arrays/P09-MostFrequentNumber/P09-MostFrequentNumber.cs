using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length: ");
            int ArrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[ArrayLength];
            int count = 1;
            int TimesHolder = 1;
            int number;
            for (int i = 0; i < ArrayLength; i++)
            {
                Console.WriteLine("Enter member number {0}:", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < ArrayLength; i++)
            {
                for (int j = i+1; j < ArrayLength; j++)
                {
                    if(array[i]==array[j])
                    {
                        count++;
                    }
                    if (count>TimesHolder)
                    {
                        TimesHolder = count;
                        number = array[i];
                        count = 0;
                    }
                } 
            }
            Console.WriteLine(TimesHolder);
        }
    }
}
