using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01_CountOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            Dictionary<double, int> occurence = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (occurence.ContainsKey(number))
                {
                    occurence[number] += 1;
                }
                else
                {
                    occurence.Add(number, 1);
                }
            }

            foreach (var entry in occurence)
            {
                Console.WriteLine("{0} -> {1} times", entry.Key, entry.Value);
            }
        }
    }
}
