using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_URLSplitting
{
    class Program
    {
        static void Main()
        {
            string url = "http://www.devbg.org/forum/index.php";
            string[] arguments = new string[] { "://", "/" };
            string[] parsed = url.Split(arguments, 3, StringSplitOptions.None);
            parsed[2] = "/" + parsed[2];
            Console.WriteLine("protocol: {0}\nserver: {1}\nresourse: {2}", parsed[0], parsed[1], parsed[2]);
        }
    }
}