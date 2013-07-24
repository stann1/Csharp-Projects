using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _03.ExtractWithXpath
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../catalog.xml");
            string xPathQuery = "catalog/album";

            XmlNodeList albumList = xmlDoc.SelectNodes(xPathQuery);
            Dictionary<string, int> producerAlbums = new Dictionary<string, int>();

            foreach (XmlNode album in albumList)
            {
                string producerName = album.SelectSingleNode("producer").InnerText;
                if (!producerAlbums.ContainsKey(producerName))
                {
                    producerAlbums[producerName] = 1;
                }
                else
                {
                    producerAlbums[producerName]++;
                }
                
            }

            foreach (var pair in producerAlbums)
            {
                if (pair.Value != 0)
                {
                    Console.WriteLine("Producer {0}, albums {1} ", pair.Key, pair.Value);
                }
            }
        }
    }
}
