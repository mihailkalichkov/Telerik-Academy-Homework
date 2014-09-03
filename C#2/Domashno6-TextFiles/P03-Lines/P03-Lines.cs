using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace P03_Lines
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader reader = new StreamReader(@"..\..\P03-Lines.cs"))
            {
              using (StreamWriter output = new StreamWriter("../../output.txt"))
            {
                         int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;         
                output.WriteLine("Line {0}: {1}",
                lineNumber, line);
                line = reader.ReadLine();
            }
            }
            }
        }
    }
}
