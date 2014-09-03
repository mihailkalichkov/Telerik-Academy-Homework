using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_10RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RandomGenerator = new Random();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}. {1}", i,RandomGenerator.Next());
            }
        }
    }
}
