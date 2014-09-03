using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P01_ReadandPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (StreamReader reader = new StreamReader(@"..\..\P01.txt"))
            {
                         int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                if ((lineNumber % 2) != 0)
                {
                    Console.WriteLine("Line {0}: {1}",
                    lineNumber, line);
                }
                line = reader.ReadLine();
            }
            }
        }
    }
}
