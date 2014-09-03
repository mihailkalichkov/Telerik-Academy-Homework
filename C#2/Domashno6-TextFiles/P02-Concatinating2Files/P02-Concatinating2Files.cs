﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P02_Concatinating2Files
{
    

    class Program
    {
        static void WriteToFile(StreamWriter output, string file)
        {
            using (StreamReader input = new StreamReader(file))
                for (string line; (line = input.ReadLine()) != null; )
                    output.WriteLine(line);
        }

        static void Main()
        {
            string[] files = { "../../Program.cs", "../../Program.cs" };

            using (StreamWriter output = new StreamWriter("../../output.txt"))
                foreach (string file in files)
                    WriteToFile(output, file);
        }
    }
}
