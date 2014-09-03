using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_CharArrayComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] FirstArray = { 'T', 'e', 'l', 'e', 'r','i'};
            char[] SecondArray= {'T', 'e', 'l', 'e', 'r','i','k'};
            int ComparisonLength, Array1isfirst=0, Array2isfirst=0;
            if (FirstArray.Length <= SecondArray.Length)
            {
                ComparisonLength = FirstArray.Length;
            }
            else
            {
                ComparisonLength = SecondArray.Length;
            }
            for (int i = 0; i < ComparisonLength; i++)
            {
                if(FirstArray[i]<SecondArray[i])
                {
                    Array1isfirst++;
                    break;
                }
                else if (FirstArray[i]>SecondArray[i])
                {
                    Array2isfirst++;
                    break;
                }               
            }
            if (Array1isfirst==1)
            {
                Console.WriteLine("First array is lexicographically first");
            }
            else if (Array2isfirst==1)
            {
                Console.WriteLine("Second array is lexicographically first");
            }
            else
            {
                if (FirstArray.Length<SecondArray.Length)
                {
                    Console.WriteLine("First array is lexicographically first");
                }
                else if(FirstArray.Length>SecondArray.Length)
                {
                    Console.WriteLine("Second array is lexicographically first");
                }
            }
        }
    }
}
