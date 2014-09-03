using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_BinaryRepresentation
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number of type short (from -32768 to 32767): ");
            short number = short.Parse(Console.ReadLine());
            Console.WriteLine(DecToBin(number));
        }
        static string DecToBin(short number)
        {
            char[] bit = new char[16];
            short pos = 15;
            short i = 0;
           
            while (i < 16)
            {
                if ((number & (1 << i)) != 0)
                {
                    bit[pos] = '1';
                }
                else
                {
                    bit[pos] = '0';
                }
                pos--;
                i++;
            }
            return new string(bit);
        }
    }
}