using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P04_EqualandDifferentLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstText = "../../FirstText.txt";
            string SecondText = "../../SecondText.txt"; 


            CompareTwoTexts(FirstText, SecondText);
        }

        private static void CompareTwoTexts(string firstFile, string secondFile)
        {
            int equalLines = 0;
            int differentLines = 0;

            using (StreamReader firstReader = new StreamReader(firstFile))
            {
                using (StreamReader secondReader = new StreamReader(secondFile))
                {
                    string firstLine = firstReader.ReadLine();
                    string secondLine = secondReader.ReadLine();

                    while (firstLine != null && secondLine != null)
                    {
                        if (firstLine == secondLine)
                        {
                            equalLines++;
                        }
                        else
                        {
                            differentLines++;
                        }

                        firstLine = firstReader.ReadLine();
                        secondLine = secondReader.ReadLine();
                    }
                }
            }

            Console.WriteLine("Total lines: {0}", equalLines + differentLines);
            Console.WriteLine("Equal lines: {0}", equalLines);
            Console.WriteLine("Different lines: {0}", differentLines);

        }
    }
}