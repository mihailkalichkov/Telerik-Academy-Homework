using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01_AverageAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Enter positive integers separated by Enter:");

            while (true)
            {
                string readLine = Console.ReadLine();

                if (readLine == string.Empty)
                {
                    break;
                }

                int parsedNumber = 0;

                bool isParsed = int.TryParse(readLine, out parsedNumber);

                if (isParsed)
                {
                    if (parsedNumber >= 0)
                    {
                        numbers.Add(parsedNumber);
                    }
                }
            }

            int numbersSum = numbers.Sum();
            double numbersAverage = numbers.Average();

            Console.WriteLine("Sum = " + numbersSum);
            Console.WriteLine("Average = " + numbersAverage);
        }
    }
}
