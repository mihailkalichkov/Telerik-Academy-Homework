using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    class Task5
    {
        static void Main(string[] args)
        {
            var number = new BitArray64(1000);
            Console.WriteLine(number.ToString());

            Console.WriteLine("Bit at position {0}: {1}", 3, number[3]);
            Console.WriteLine("Bit at position {0}: {1}", 4, number[4]);
            Console.WriteLine("Bit at position {0}: {1}", 5, number[5]);

            Console.WriteLine(number.Equals("1111101000"));
            Console.WriteLine(number == "1111101000");
            Console.WriteLine(number != "1111101000");

            foreach (var item in number)
            {
                Console.Write(number[item]);
            }
            Console.WriteLine();
        }
    }
}