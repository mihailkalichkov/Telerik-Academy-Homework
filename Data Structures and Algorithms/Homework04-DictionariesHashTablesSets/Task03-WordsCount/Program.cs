using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task03_WordsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader(@"..\\..\\text.txt");
            using (reader)
            {
                string text = reader.ReadToEnd();
                char[] separators = { ' ', ',', '!', '-', '?', '.' };// I can't understand why it can't split the ?
                string[] splittedText = text.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                var dictionary = new Dictionary<string, int>();

                foreach (var entry in splittedText)
                {
                    if (dictionary.ContainsKey(entry))
                    {
                        dictionary[entry] += 1;
                    }
                    else
                    {
                        dictionary.Add(entry, 1);
                    }
                }

                foreach (KeyValuePair<string, int> item in dictionary.OrderBy(key => key.Value))
                {
                    Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
                }
            }
        }
    }
}
