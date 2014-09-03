using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_BinarytoHexadecimal
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter hexadecimal  number:");
            string hexNumber = Console.ReadLine();
            List<string> binaryResult = new List<string>();
            int index = 0;
            while (hexNumber.Length > index)
            {
                switch (hexNumber[index])
                {
                    case '0': binaryResult.Add("0000");
                        break;
                    case '1': binaryResult.Add("0001");
                        break;
                    case '2': binaryResult.Add("0010");
                        break;
                    case '3': binaryResult.Add("0011");
                        break;
                    case '4': binaryResult.Add("0100");
                        break;
                    case '5': binaryResult.Add("0101");
                        break;
                    case '6': binaryResult.Add("0110");
                        break;
                    case '7': binaryResult.Add("0111");
                        break;
                    case '8': binaryResult.Add("1000");
                        break;
                    case '9': binaryResult.Add("1001");
                        break;
                    case 'A':
                    case 'a': binaryResult.Add("1010");
                        break;
                    case 'b':
                    case 'B': binaryResult.Add("1011");
                        break;
                    case 'c':
                    case 'C': binaryResult.Add("1100");
                        break;
                    case 'd':
                    case 'D': binaryResult.Add("1101");
                        break;
                    case 'e':
                    case 'E': binaryResult.Add("1110");
                        break;
                    case 'f':
                    case 'F': binaryResult.Add("1111");
                        break;
                    default: Console.WriteLine("Error");
                        break;
                }
                index++;
            }        
            for (int i = 0; i < binaryResult.Count; i++)
            {
                if (i == 0)
                {
                    int num = int.Parse(binaryResult[i]);
                    Console.Write(num);
                }
                else
                {
                    Console.Write(binaryResult[i]);
                }
            }
            Console.WriteLine("\n");
        }
    }
}