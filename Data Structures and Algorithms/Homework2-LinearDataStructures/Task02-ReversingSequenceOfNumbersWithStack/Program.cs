using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02_ReversingSequenceOfNumbersWithStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Stack<int>();

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
                     numbers.Push(parsedNumber);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
