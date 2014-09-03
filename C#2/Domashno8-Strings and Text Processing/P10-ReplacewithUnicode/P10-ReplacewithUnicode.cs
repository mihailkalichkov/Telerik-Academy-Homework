using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_ReplacewithUnicode
{
    class Program
    {
        static void Main()
        {
            string str = "Hi!";

            foreach (var symbol in str)
            {
                Console.Write("\\u{0:X4}", (int)symbol);
            }
        }
    }
}