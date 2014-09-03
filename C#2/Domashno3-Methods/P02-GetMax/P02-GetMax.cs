using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_GetMax
{
    class Program
    {
        static int GetMax(int number1, int number2)
        {
            int max = number1;
            if(number1<number2)
            {
                max = number2;
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 integers:");
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());

            Console.WriteLine("The biggest is: {0}",GetMax(GetMax(input1, input2),input3));
        }
    }
}
