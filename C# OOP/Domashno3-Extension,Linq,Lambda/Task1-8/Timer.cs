using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP___HW3
{
    delegate void Execute(int seconds);

    static class MyTimer
    {
        private static DateTime timer = new DateTime();

        static MyTimer()
        {
            timer = DateTime.Now;
        }

        private static void PrintEveryTSeconds(int seconds)
        {
            Console.WriteLine("{0} seconds passed.", seconds);
        }

        public static void Start(int intervalInSeconds)
        {
            Console.WriteLine("Timer started! Press any key to stop it!");
            Execute myDelegate = PrintEveryTSeconds;
            var start = DateTime.Now;
            while (!Console.KeyAvailable)
            {
                if ((DateTime.Now - timer).Seconds == intervalInSeconds)
                {
                    timer = DateTime.Now;
                    myDelegate((DateTime.Now - start).Seconds);
                }
            }
        }

        public static void Start2(int intervalInSeconds)
        {
            Console.WriteLine("Timer 2 started! Press CTRL + C to stop it!");
            var start = DateTime.Now;
            var timer2 = DateTime.Now;
            Func<int, bool> timerDelegate = (x) =>
            {
                if (x == intervalInSeconds)
                {
                    return true;
                }
                else return false;
            };

            while (true)
            {
                if (timerDelegate((DateTime.Now - timer2).Seconds))
                {
                    timer2 = DateTime.Now;
                    Console.WriteLine("{0} seconds passed.", (timer2 - start).Seconds);
                }
            }
        }
    }
}