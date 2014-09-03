using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_AZIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];
            string word = (Console.ReadLine());
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = Convert.ToChar('a' + 1);
            }
            for (int j = 0; j < word.Length; j++)
            {
                Console.WriteLine("Letter {0} with index {1}", word[j], word[j]-'a');
            }
        }
    }
}
