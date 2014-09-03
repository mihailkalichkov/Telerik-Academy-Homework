using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_DecimaltoBinary
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number:");
            int Number = int.Parse(Console.ReadLine());
            List<int> NumberinBinary = new List<int>();
            while (Number > 0)
            {
                NumberinBinary.Add(Number % 2);
                Number = Number / 2;
            }
            NumberinBinary.Reverse();
            Console.WriteLine("The number in binary is:");
            for (int i = 0; i < NumberinBinary.Count; i++)
            {
                Console.Write("{0} ", NumberinBinary[i]);
            }
            Console.WriteLine();
        }
    }
}