using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ReversingaSentence
{
    class Program
    {
        static void Main()
        {
            string text = "C# is not C++, not PHP and not Delphi!";
            string[] arguments = new string[] { " ", ",", "!" };
            string[] splittedText = text.Split(arguments, StringSplitOptions.RemoveEmptyEntries);

            for (int i = splittedText.Length - 1; i >= 0; i--)
            {
                if (splittedText[i] == "C++")
                {
                    Console.Write(",");
                }
                Console.Write(splittedText[i] + " ");

            } Console.WriteLine("!");
            Console.WriteLine();
        }
    }
}