using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_LeapYearCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year to check if it's a leap year: ");          
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(
           "Is {0} leap year: {1}", year, DateTime.IsLeapYear(year));
        }
    }
}
