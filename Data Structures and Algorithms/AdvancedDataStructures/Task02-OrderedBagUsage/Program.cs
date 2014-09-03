namespace Task02_OrderedBagUsage
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using Wintellect.PowerCollections;

    class Program
    {
        static void Main(string[] args)
        {
            var products = new OrderedBag<Product>();
            Random random = new Random();

            Stopwatch watch = new Stopwatch();
            watch.Start();

            for (int i = 0; i < 500000; i++)
            {
                products.Add(new Product("Item " + 1, random.Next(100, 1000)));   
            }

            watch.Stop();
            Console.WriteLine("Added 500 000 items for {0} ", watch.Elapsed);

            var twentyElementsInRange = new List<Product>();

            watch.Restart();

            for (int i = 0; i < 10000; i++)
            {
                var minSumProduct = new Product("Low price", random.Next(100, 500));
                var maxSumProduct = new Product("High price", random.Next(500, 1000));
                twentyElementsInRange.AddRange(products.Range(minSumProduct, true, maxSumProduct, true).Take(20));
            }

            watch.Stop();
            Console.WriteLine("10 000 price searches for {0}", watch.Elapsed);
        }
    }
}
