using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length: ");
            int ArrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[ArrayLength];
            int[] BiggestSequence = new int[4];
            int sum = array[0]+array[1]+array[2]+array[3];
            for (int i = 0; i < ArrayLength; i++)
            {
                Console.WriteLine("Enter member number {0}:", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < ArrayLength-3; i++)
            {
                if(array[i]+array[i+1]+array[i+2]+array[i+3]>sum)
                {
                    sum = array[i] + array[i + 1] + array[i + 2] + array[i + 3];
                    BiggestSequence[0] = array[i];
                    BiggestSequence[1] = array[i + 1];
                    BiggestSequence[2] = array[i + 2];
                    BiggestSequence[3] = array[i + 3];
                }              
            }
            Console.WriteLine("{0}, {1}, {2}, {3}",BiggestSequence[0],BiggestSequence[1], BiggestSequence[2],BiggestSequence[3]);
        }
    }
}
