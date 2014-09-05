namespace Task06_ExtractSOngsLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var doc = XDocument.Load("../../catalogue.xml");
            var songs =
                from song in doc.Descendants("song")
                select new
                {
                    Title = song.Element("title").Value
                };

            foreach (var song in songs)
            {
                Console.WriteLine(song.Title);
            }
        }
    }
}
