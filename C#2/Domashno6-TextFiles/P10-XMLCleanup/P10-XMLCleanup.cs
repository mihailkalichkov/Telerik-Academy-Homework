using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P10_XMLCleanup
{
    class Program
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("../../input.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                string text = "";
                while (line != null)
                {
                    for (int i = 1; i < line.Length; i++)
                    {
                        if (line[i - 1] == '>')
                        {
                            while (line[i] != '<')
                            {
                                text += line[i];
                                i++;
                            }
                            if (text != "")
                            {
                                Console.WriteLine(text);
                                text = "";
                            }
                        }
                    }
                    line = reader.ReadLine();
                }
            }
        }
    }
}