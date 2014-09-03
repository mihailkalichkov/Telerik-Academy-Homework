using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_SortbyLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string interim;
            string[] ArrayofStrings = { "C#", "grandma", "booooyah", "s", "ninja" };
            for (int i = 0; i < ArrayofStrings.Length; i++)
            {
                for (int j = i; j < ArrayofStrings.Length; j++)
                    if (ArrayofStrings[i].Length > ArrayofStrings[j].Length)
                    {
                        interim = ArrayofStrings[i];
                        ArrayofStrings[i] = ArrayofStrings[j];
                        ArrayofStrings[j] = interim;
                    }
            }
            for (int i = 0; i < ArrayofStrings.Length; i++)
            {
                Console.WriteLine(ArrayofStrings[i]);
            }
        }
    }
}