﻿namespace Task07_CreateXml
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml.Linq;

    class Program
    {
        static void Main()
        {
            string fileName = "../../Person.txt";

            var filestream = new FileStream(fileName,
                                FileMode.Open,
                                FileAccess.Read,
                                FileShare.ReadWrite);
            var fileReader = new StreamReader(filestream, Encoding.UTF8, true, 128);
            XElement personXml = new XElement("persons");
            string name = "";
            string address = "";

            using (fileReader)
            {
                string line;
                int count = 1;
                while ((line = fileReader.ReadLine()) != null)
                {
                    if (count % 3 == 1)
                    {
                        name = line;
                    }
                    else if (count % 3 == 2)
                    {
                        address = line;
                    }
                    else
                    {
                        var phone = line;

                        personXml.Add(new XElement("person",
                   new XElement("name", name),
                   new XElement("address", address),
                   new XElement("phone", phone)
           ));
                    }
                    count++;
                }
            }

            Console.WriteLine(personXml);
            personXml.Save("../../person.xml");
        }
    }
}
