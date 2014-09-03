using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_DifferentFormats
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15}", number);

            Console.WriteLine("{0,15:X}", number);

            Console.WriteLine("{0,15:P}", number);

            Console.WriteLine("{0,15:E}", number);
        }
    }
}