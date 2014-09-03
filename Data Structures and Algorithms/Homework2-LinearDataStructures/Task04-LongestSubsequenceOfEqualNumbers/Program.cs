using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_LongestSubsequenceOfEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var listOfNumbers = new List<int>{ 1, 1, 3, 7, 6, 2, 2, 2, 2, 3, 3 };
                var listOfSequence = new List<int>();
                int count = 1;
                int longestSequence = 1;
                int position = 1;
                int bestPosition = 1;
                for (int i = 1; i <= listOfNumbers.Count - 1; i++)
                {
                    if (listOfNumbers[i] == listOfNumbers[i - 1])
                    {
                        count++;

                        position = i;
                        if (count > longestSequence)
                        {
                            longestSequence = count;
                            bestPosition = position;
                        }

                    }
                    else
                    {
                        count = 1;
                    }
                }

                for (int i = 1; i <= longestSequence; i++)
                {
                    listOfSequence.Add(listOfNumbers[bestPosition - longestSequence + i]);
                }
                Console.WriteLine(string.Join(" ",listOfSequence));
            }
        }
    }
}
