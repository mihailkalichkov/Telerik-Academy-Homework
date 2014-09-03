using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03_SortingNumbersWithList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Enter integers separated by Enter:");

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
                    numbers.Add(parsedNumber);
                }
            }

            numbers.Sort();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
