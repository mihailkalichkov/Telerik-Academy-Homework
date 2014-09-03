using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_Dictionary
{
    class Program
    {
        static void Main()
        {
            string[] words = { ".NET", "CLR", "namespace" };
            string[] description = { "platform for applications from Microsoft",
                                 "managed execution environment for .NET",
                                 "hierarchical organization of classes" };
            string input = Console.ReadLine();

            for (int i = 0; i < words.Length; i++)
            {
                if (input == words[i])
                {
                    Console.WriteLine("{0} - {1}", words[i], description[i]);
                }
            }
        }
    }
}