using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using Wintellect.PowerCollections;

namespace Task02_OrderedMultiDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new OrderedMultiDictionary<decimal, Article>(true);
            Random random = new Random();
            int range = 100;
            //double randomDouble = random.NextDouble() * range;
            decimal lowBorder = 40;
            decimal highBorder = 41;

            for (int i = 0; i < 1000000; i++)
            {
                var article = new Article();
                article.Barcode = i.ToString();
                article.Vendor = "Vendor" + i;
                article.Title = "Title" + i;
                article.Price = (decimal)random.NextDouble() * range;
                dictionary.Add(article.Price, article);
            }

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var selected = dictionary.Range(lowBorder, true, highBorder, true);
            stopwatch.Stop();
            Console.WriteLine("number of elements : " + dictionary.Count);
            Console.WriteLine("Number of selected items in price range: " + selected.Count);
            Console.WriteLine("Time for selecting: " + stopwatch.Elapsed);
        }

        public class Article : IComparable<Article>
        {
            public string Barcode { get; set; }
            public string Vendor  { get; set; }
            public string Title { get; set; }
            public decimal Price { get; set; }

            public int CompareTo(Article other)
            {
                return (int)(this.Price - other.Price);
            }
        }
    }
}
