namespace Task05_ExtractSongs
{
    using System;
    using System.Linq;
    using System.Xml;

    class Program
    {
        static void Main(string[] args)
        {
            using (XmlReader reader = XmlReader.Create("../../catalogue.xml"))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "title"))
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}
