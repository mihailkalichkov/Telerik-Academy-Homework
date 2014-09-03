using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_ReplacingwithStar
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            int maxLength = 20;

            if (str.Length <= maxLength)
                Console.WriteLine(str.PadRight(maxLength, '*'));
        }
    }
}