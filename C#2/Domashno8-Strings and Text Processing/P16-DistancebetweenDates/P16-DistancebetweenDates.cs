using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_DistancebetweenDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter starting date:day.month.year: ");
            string firstDate = Console.ReadLine();
            Console.Write("Enter end date:day.month.year: ");
            string secondDate = Console.ReadLine();
            var numberOfDays = (DateTime.Parse(secondDate) - DateTime.Parse(firstDate)).TotalDays;
            Console.WriteLine("The difference between given dates is:{0} days", numberOfDays);
        }
    }
}