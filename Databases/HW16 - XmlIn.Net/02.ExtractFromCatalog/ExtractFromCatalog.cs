using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _02.ExtractFromCatalog
{
    class ExtractFromCatalog
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalog.xml");

            XmlNode rootNode = doc.DocumentElement;
            Console.WriteLine("Root node: {0}", rootNode.Name);

            foreach (XmlAttribute atr in rootNode.Attributes)
            {
                Console.WriteLine("Attribute: {0}={1}",
                    atr.Name, atr.Value);
            }

            Dictionary<string, int> producers = new Dictionary<string, int>();

            foreach (XmlNode node in rootNode.ChildNodes)
            {                
                if (!producers.ContainsKey(node["producer"].InnerText))
                {
                    producers[node["producer"].InnerText] = 1;
                }
                else
                {
                    producers[node["producer"].InnerText]++;
                }
            }

            foreach (var pair in producers)
            {
                if (pair.Value != 0)
                {
                    Console.WriteLine("Producer {0}, albums {1} ", pair.Key, pair.Value);
                }
            }
        }
    }
}
