using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02_CountOddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            Dictionary<string, int> occurence = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (occurence.ContainsKey(word))
                {
                    occurence[word] += 1;
                }
                else
                {
                    occurence.Add(word, 1);
                }
            }

            var oddWordsCount = new LinkedList<string>();

            foreach (var entry in occurence)
            {
                if ((entry.Value & 1) > 0)
                {
                    oddWordsCount.AddLast(entry.Key);
                }
            }

            foreach (var entry in oddWordsCount)
            {
                Console.WriteLine(entry);
            }
        }
    }
}
