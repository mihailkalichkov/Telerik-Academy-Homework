using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var index = 1;
            int Max = 1000000;
            List<int> PrimeList = Enumerable.Range(2, Max).ToList();
             
            while (index<= Math.Sqrt(Max))
            {
                int interim1 = index;
                int interim2 = PrimeList.First(number => number > interim1);
                PrimeList.RemoveAll(number => number != interim2 && number % interim2 == 0);
                index = interim2;
            }
            int[] PrimeArray = PrimeList.ToArray();
            for (int i = 0; i < PrimeArray.Length; i++)
            {
                Console.WriteLine(PrimeArray[i]);
            }
        }
    }
}
