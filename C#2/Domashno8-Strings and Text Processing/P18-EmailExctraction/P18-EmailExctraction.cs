using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P18_EmailExctraction
{
    class Program
    {
        static void Main()
        {
            string input = @"Please contact us by phone (+359 222 222 222) or
                       by email at exa_mple@abv.bg or at baj.ivan@yahoo.co.uk or at baj-ivan@gmail.com
                       This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
            string[] splitted = input.Split(' ');

            for (int i = 0; i < splitted.Length; i++)
            {
                if (Regex.IsMatch(splitted[i], @"[\w.,\-]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}"))
                {
                    Console.WriteLine("{0} is a valid email", splitted[i]);
                }
            }
        }
    }
}