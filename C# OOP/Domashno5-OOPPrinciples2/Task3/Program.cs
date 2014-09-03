using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exceptions;

namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press Enter to exit!");
            Console.ResetColor();
            int someInt;
            while (true)
            {
                try
                {
                    Console.Write("Enter integer: ");
                    bool isInt = int.TryParse(Console.ReadLine(), out someInt);
                    if (!isInt) break;
                    if (someInt < 1 || someInt > 100)
                    {
                        Console.Write(someInt + " ");
                        throw new InvalidRangeException<int>("is outside range", 1, 100);
                    }
                    else Console.WriteLine("{0} is in range [{1},{2}]", someInt, 1, 100);
                }
                catch (InvalidRangeException<int> ex)
                {
                    Console.WriteLine("{0} [{1},{2}]", ex.Message, ex.StartValue, ex.EndValue);
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press Enter to exit!");
            Console.ResetColor();
            DateTime date;
            while (true)
            {
                try
                {
                    Console.Write("Enter date: ");
                    bool someDate = DateTime.TryParse(Console.ReadLine(), out date);
                    if (!someDate) break;
                    if (date < new DateTime(1980, 1, 1) || date > new DateTime(2013, 12, 31))
                    {
                        Console.Write("{0:dd.MM.yyyy} ", date);
                        throw new InvalidRangeException<DateTime>("is outside range",
                            new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
                    }
                    else Console.WriteLine("{0:dd.MM.yyyy} is in range [{1:dd.MM.yyyy},{2:dd.MM.yyyy}]",
                        date, new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
                }
                catch (InvalidRangeException<DateTime> ex)
                {
                    Console.WriteLine("{0} [{1:dd.MM.yyyy},{2:dd.MM.yyyy}]", ex.Message, ex.StartValue, ex.EndValue);
                }
            }

        }
    }
}