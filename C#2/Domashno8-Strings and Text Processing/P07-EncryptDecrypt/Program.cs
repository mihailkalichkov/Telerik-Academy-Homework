using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_EncryptDecrypt
{
    class Program
    {
        static string Encrypt(string message, string key)
        {
            var encryptedMessage = new StringBuilder(message.Length);

            for (int i = 0; i < message.Length; i++)
                encryptedMessage.Append((char)(message[i] ^ key[i % key.Length]));

            return encryptedMessage.ToString();
        }

        static string Decrypt(string message, string key)
        {
            return Encrypt(message, key);
        }

        static void Main()
        {
            string message = "Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.";
            string key = "xor";

            Console.WriteLine(Decrypt(Encrypt(message, key), key));
        }
    }
}