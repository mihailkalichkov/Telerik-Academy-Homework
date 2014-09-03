using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P23_IdenticalLetters
{
    class Program
    {
        static void Main()
        {
            string text = "aaaaabbbbbcdddeeeedssaa";
            StringBuilder str = new StringBuilder(text);

            for (int letter = 0; letter < str.Length - 1; letter++)
            {
                if (str[letter] == str[letter + 1])
                {
                    str.Remove(letter, 1);
                    letter--;
                }
            }
            Console.WriteLine(str);
        }
    }
}
