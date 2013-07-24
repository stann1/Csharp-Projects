using System;
using System.Linq;
using System.Xml.Linq;

namespace _06.ExtractWithLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument doc = XDocument.Load("../../../catalog.xml");
            var songs =
                from song in doc.Descendants("song")
                select song.Element("title").Value;

            foreach (var song in songs)
            {
                Console.WriteLine(song);
            }
        }
    }
}
