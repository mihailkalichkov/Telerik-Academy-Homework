using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace P07_ReplaceStartwithFinish
{
    class Program
    {
        static void Main()
        {
            string start = "start";
            string finish = "finish";
            StreamReader read = new StreamReader("../../input.txt");
            StreamWriter write = new StreamWriter("../../output.txt");
            string line = "";

            using (read)
            {
                using (write)
                {
                    line = read.ReadLine().ToLower();
                    while (line != null)
                    {
                        line = Regex.Replace(line,@"\bstart\b", "finish");
                        write.WriteLine(line);
                        line = read.ReadLine();
                    }
                }
            }
            File.Replace("../../output.txt", "../../input.txt", "../../backup.txt");
        }
    }
}
