using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P09_ReplaceForbiddenWords
{
    class Program
    {
        public static void Main()
        {
            string message = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string[] forbidenWords = "PHP, CLR, Microsoft".Split(',');
            for (int i = 0; i < forbidenWords.Length; i++)
            {
                forbidenWords[i] = forbidenWords[i].Trim();
                message = message.Replace(forbidenWords[i], new string('*', forbidenWords[i].Length));
            }

            Console.WriteLine(message);
        }
    }
}