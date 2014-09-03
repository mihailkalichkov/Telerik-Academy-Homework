using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_MaximalIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 1, 1, 3, 7, 6, 2, 3, 4, 2, 3, 3 };
            int count = 1;
            int LongestSequence = 1;
            int Position = 1;
            int BestPosition = 1;
            for (int i = 1; i <= Array.Length - 1; i++)
            {
                if (Array[i] == Array[i - 1]+1)
                {
                    count++;
                    Position = i;
                    if (count > LongestSequence)
                    {
                        LongestSequence = count;
                        BestPosition = Position;

                    }

                }
                else
                {
                    count = 1;
                }
            }
            Console.WriteLine(LongestSequence);
            Console.WriteLine(BestPosition);
            for (int i = 1; i <= LongestSequence; i++)
            {
                Console.Write(Array[BestPosition - LongestSequence + i]);
            }
            Console.WriteLine();
        }
    }
}
