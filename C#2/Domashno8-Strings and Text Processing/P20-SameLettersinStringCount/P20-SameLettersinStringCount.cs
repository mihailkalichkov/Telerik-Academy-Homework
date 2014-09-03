using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20_SameLettersinStringCount
{
    class Program
    {
        static void Main()
        {
            string str = "Write a program that reads a string from the console and prints all different letters, in the string along with information how many times each letter is found.";
            Dictionary<char, int> Letters = new Dictionary<char, int>();
            foreach (var item in str.ToLower())
            {
                if (Char.IsLetter(item))
                {
                    if (Letters.ContainsKey(item))
                    {
                        Letters[item]++;
                    }
                    else
                    {
                        Letters.Add(item, 1);
                    }
                }
            }

            foreach (var letter in Letters)
            {
                Console.WriteLine("{0} - {1,3} times found", letter.Key, letter.Value);
            }

            Console.WriteLine();
        }
    }
}