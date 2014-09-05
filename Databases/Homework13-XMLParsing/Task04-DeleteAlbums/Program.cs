namespace Task04_DeleteAlbums
{
    using System;
    using System.Linq;
    using System.Xml;

    class Program
    {
        static void Main(string[] args)
        {
            var doc = new XmlDocument();
            doc.Load("../../catalogue.xml");

            foreach (XmlNode node in doc.DocumentElement)
            {
                if (decimal.Parse(node["price"].InnerText) > 20)
                {
                    XmlNode parent = node.ParentNode;
                    parent.RemoveChild(node);
                }
            }

            Console.WriteLine(doc.OuterXml);

            doc.Save("../../modifiedCatalogue.xml");

        }
    }
}
