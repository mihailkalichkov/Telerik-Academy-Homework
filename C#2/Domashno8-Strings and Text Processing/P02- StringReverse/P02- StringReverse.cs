using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02__StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to reverse: ");
            string s = Console.ReadLine();           
            Console.WriteLine(ReverseString(s));
        }
        public static string ReverseString(string Example)
        {

            StringBuilder SBuilder = new StringBuilder();
            for (int i = Example.Length-1; i > 0; i--)
            {
                SBuilder.Append(Example[i]); 
            }
            return SBuilder.ToString();
        }
    }
}
