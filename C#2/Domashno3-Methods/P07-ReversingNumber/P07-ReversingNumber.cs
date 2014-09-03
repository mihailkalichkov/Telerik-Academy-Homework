using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_ReversingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = -9876;

            int reversed = ReverseNumber(number);
            Console.WriteLine(reversed);
        }

        static int ReverseNumber(int number)
        {
            List<int> Digits = new List<int>();
            int reversed = 0;

            for (int i = number; i != 0; i /= 10)
            {
                Digits.Add(i % 10);
            }

            for (int i = Digits.Count - 1, multiplicator = 1; i >= 0; i--, multiplicator *= 10)
            {
                reversed += Digits[i] * multiplicator;
            }

            return reversed;

        }
    }
}