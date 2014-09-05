namespace Task01_ExtractingArtists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new XmlDocument();
            doc.Load("../../catalogue.xml");
            var rootNode = doc.DocumentElement;
            var artistsDictionary = new Dictionary<string, int>();

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                var artistName = node["artist"].InnerText;

                if (artistsDictionary.ContainsKey(artistName))
                {
                    artistsDictionary[artistName]++;
                }
                else
                {
                    artistsDictionary.Add(artistName, 1);
                }
            }

            foreach (var item in artistsDictionary)
            {
                Console.WriteLine("{0} - {1} albums", item.Key, item.Value);
            }
        }
    }
}
