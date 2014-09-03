using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_HexadecimaltoDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hexadecimal number:");
            string hexNumber = Console.ReadLine();
            long NumberinDecimal = 0;
            int digit = 0;        
                for (int i = hexNumber.Length-1, power = 1; i >=0; i--, power *= 16)
                {
                    switch (hexNumber[i])
                    {

                        case 'A':
                        case 'a':
                            digit = 10; break;
                        case 'B':
                        case 'b':
                            digit = 11; break;
                        case 'C':
                        case 'c':
                            digit = 12; break;
                        case 'D':
                        case 'd':
                            digit = 13; break;
                        case 'E':
                        case 'e':
                            digit = 14; break;
                        case 'F':
                        case 'f':
                            digit = 15; break;

                        default: digit = int.Parse(Convert.ToString(hexNumber[i])); break;
                    }
                            NumberinDecimal += digit * power;
                            
                    
                }
            Console.WriteLine(NumberinDecimal);
        }
    }
}
