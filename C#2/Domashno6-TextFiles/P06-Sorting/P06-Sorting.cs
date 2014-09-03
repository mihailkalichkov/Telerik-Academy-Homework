using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P06_Sorting
{
    class Program
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader("../../input.txt"))
            {
                List<string> names = new List<string>();

                for (string currentName = reader.ReadLine(); currentName != null; currentName = reader.ReadLine())
                {
                    names.Add(currentName);
                    
                }

                names.Sort();

                using (StreamWriter writer = new StreamWriter("../../output.txt"))
                {
                    foreach (string name in names) writer.WriteLine(name);
                }
            }
        }
    }
}