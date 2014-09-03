using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07_ElementsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            var dictionary = new Dictionary<int, int>();

            foreach (var element in list)
            {
                if (!dictionary.Keys.Contains(element))
                {
                    dictionary.Add(element, 1);
                }
                else
                {
                    dictionary[element]++;
                }
            }

            var keys = dictionary.Keys.ToList();
            keys.Sort();

            foreach (var key in keys)
            {
                Console.WriteLine(" {0} -> {1} times", key, dictionary[key]);
            }

        }
    }
}
