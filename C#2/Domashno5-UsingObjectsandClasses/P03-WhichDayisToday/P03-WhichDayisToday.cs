using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_WhichDayisToday
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Today = DateTime.Now;
            Console.WriteLine("Today is {0}.", Today.DayOfWeek);
        }
    }
}
