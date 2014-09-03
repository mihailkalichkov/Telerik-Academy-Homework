using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_ReadNumber
{
    class Program
    {
        static int ReadNumber(int start, int end)
        {
            int n = int.Parse(Console.ReadLine());

            if (!(start < n && n < end)) throw new ArgumentOutOfRangeException();

            return n;
        }

        static void Main()
        {
            int min = 1, max = 100;
            Console.WriteLine("Enter 10 consecutive numbers between 1 and 100");

            for (int i = 0; i < 10; i++) min = ReadNumber(min, max);
        }
    }
}