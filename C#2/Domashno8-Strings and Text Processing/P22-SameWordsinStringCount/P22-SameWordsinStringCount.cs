using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22_SameWordsinStringCount
{
    class Program
    {
        static void Main()
        {
            string text = "i will try to explain, what is dictionary and how to use dictionary.";
            string[] allWordsArr = text.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (var word in allWordsArr)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word] = dictionary[word] + 1;
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }

            foreach (var word in dictionary)
            {
                Console.WriteLine("{0,-15} - {1} times", word.Key, word.Value);
            }
        }
    }
}