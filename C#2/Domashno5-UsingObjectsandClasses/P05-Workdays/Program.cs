using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Workdays
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input a date yyyy.mm.dd: ");
            string dateAsString = Console.ReadLine();
            DateTime date = DateTime.Parse(dateAsString);
            int numberWorkdays = GetWorkdaysFromToday(date);
            Console.WriteLine(numberWorkdays);
        }

        static int GetWorkdaysFromToday(DateTime date)
        {
            DateTime today = DateTime.Today;
            int days = 0;
            if (DateTime.Compare(today, date) < 0)
            {
                //  today before date
                do
                {
                    if (IsBuisnessDay(today) && !IsHoliday(today))
                    {
                        days++;
                    }
                    today = today.AddDays(1);
                } while (DateTime.Compare(today, date) <= 0);
            }
            else if (DateTime.Compare(today, date) > 0)
            {
                //  today after date
                do
                {
                    if (IsBuisnessDay(date) && !IsHoliday(date))
                    {
                        days++;
                    }
                    date = date.AddDays(1);
                } while (DateTime.Compare(date, today) <= 0);
            }
            else
            {
                days = 0;
            }
            return days;
        }

        static bool IsHoliday(DateTime date)
        {
            int year = date.Year;
            DateTime[] holidays =
            {
                new DateTime(year, 1, 1),
                new DateTime(year, 3, 3),
                new DateTime(year, 5, 1),
                new DateTime(year, 5, 2),
                new DateTime(year, 5, 6),
                new DateTime(year, 5, 24),
                new DateTime(year, 9, 22),
                new DateTime(year, 12, 24),
                new DateTime(year, 12, 25),
                new DateTime(year, 12, 26),
                new DateTime(year, 12, 31)
            };
            for (int i = 0; i < holidays.Length; i++)
            {
                if (DateTime.Equals(date, holidays[i]))
                {
                    return true;
                }
            }
            return false;
        }

        static bool IsBuisnessDay(DateTime date)
        {
            return date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;
        }
    }
}