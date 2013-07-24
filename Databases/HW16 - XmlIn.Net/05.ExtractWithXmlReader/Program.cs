using System;
using System.Linq;
using System.Xml;

namespace _05.ExtractWithXmlReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Songs in the catalog:");
            using (XmlReader reader = XmlReader.Create("../../../catalog.xml"))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "title"))
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }            
        }
    }
}
