using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P25_ExtractingTitleandBodyfromHTML
{
    class Program
    {
        static void Main()
        {
            string str = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn into skillful .NET software engineers.</p></body></html>";

            foreach (Match text in Regex.Matches(str, "(?<=>).*?(?=<)"))
                if (!String.IsNullOrWhiteSpace(text.Value)) Console.WriteLine(text);
        }
    }
}