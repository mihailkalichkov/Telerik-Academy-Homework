using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P19_DateExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"I was born at 14.06.1980 . My sister was born at 3.7.1984. In 
            5/1999 I graduated my highschool. The law says (see section 7.3.12) that we are allowed to do this ( section 7.4.2.9).";

            foreach (var item in Regex.Matches(input, @"\w\.\w+\.\w{4}"))
            {
                Console.WriteLine("{0}", item, CultureInfo.GetCultureInfo("en-CA"));
            }
        }
    }
}