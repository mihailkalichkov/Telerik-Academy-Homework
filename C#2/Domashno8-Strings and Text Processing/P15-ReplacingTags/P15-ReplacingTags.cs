using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_ReplacingTags
{
    class Program
    {
        static void Main()
        {
            string text = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

            string replaced = text.Replace(@"<a href=""", "[URL=");
            replaced = replaced.Replace(@"</a>", "[/URL]");
            replaced = replaced.Replace(@""">", "]");
            Console.WriteLine(replaced);
        }
    }
}