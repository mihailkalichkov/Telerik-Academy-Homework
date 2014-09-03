using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_HexadecimaltoBinary
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter hexadecimal number: ");
            string hexNumber = Console.ReadLine();
            ConvertHexToBinary(hexNumber);
        }
        static void ConvertHexToBinary(string input)
        {

            int binary = 0;
            int count = 0;
            for (int i = input.Length - 1; i >= 0; i--, count++)
            {
                switch (input[i])
                {
                    case 'A': binary = binary | (10 << 4 * count); break;
                    case 'B': binary = binary | (11 << 4 * count); break;
                    case 'C': binary = binary | (12 << 4 * count); break;
                    case 'D': binary = binary | (13 << 4 * count); break;
                    case 'E': binary = binary | (14 << 4 * count); break;
                    case 'F': binary = binary | (15 << 4 * count); break;
                    default: binary = binary | ((input[i] - 48) << 4 * count); break;
                }
            }
            Console.WriteLine(Convert.ToString(binary, 2));
        }
    }
}