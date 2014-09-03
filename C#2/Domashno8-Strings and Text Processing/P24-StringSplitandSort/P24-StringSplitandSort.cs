using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P24_StringSplitandSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.";
            string[] Splitted = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(Splitted);
            foreach (var word in Splitted)
            {
                Console.WriteLine(word); 
            }

        }
    }
}
