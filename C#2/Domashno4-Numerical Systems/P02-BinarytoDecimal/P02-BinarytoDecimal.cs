using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_BinarytoDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter binary number:");
            long Number = long.Parse(Console.ReadLine());
            long NumberinDecimal = 0;
            while (Number>0)
            {
                for (int i = 0,power=1; i < 16; i++,power*=2)
                {
                    NumberinDecimal += Number % 10 * power;
                    Number /= 10;
                }
            }
            Console.WriteLine(NumberinDecimal);
        }
    }
}
