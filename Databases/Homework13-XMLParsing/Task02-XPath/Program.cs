namespace Task02_XPath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;
    class Program
    {
        static void Main(string[] args)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load("../../catalogue.xml");
            var rootNode = xmlDoc.DocumentElement;
            var artistDictionary = new Dictionary<string, int>();
            string xPathQuery = "catalogue/album";
            XmlNodeList artistList = xmlDoc.SelectNodes(xPathQuery);

            foreach (XmlNode artist in artistList)
            {
                string artistName = artist.SelectSingleNode("artist").InnerText;

                if (artistDictionary.ContainsKey(artistName))
                {
                    artistDictionary[artistName]++;
                }
                else
                {
                    artistDictionary.Add(artistName, 1);
                }
            }

            foreach (var item in artistDictionary)
            {
                Console.WriteLine("{0} - {1} albums", item.Key, item.Value);
            }
        }
    }
}
