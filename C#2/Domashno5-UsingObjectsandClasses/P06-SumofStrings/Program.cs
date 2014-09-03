using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_SumofStrings
{
    class Program
    {
        static void Main()
        {
            string input = "43 68 9 23 318";          
            int sum = 0;
            string[] strNums = input.Split(' ');
            for (int i = 0; i < strNums.Length; i++)
            {
                sum = sum + int.Parse(strNums[i]);
            }
            Console.WriteLine(sum);
            
        }
    }
}