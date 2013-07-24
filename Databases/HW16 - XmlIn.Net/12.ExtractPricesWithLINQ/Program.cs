﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _12.ExtractPricesWithLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int YEARS_BACK = 20;
            int minYear = DateTime.Now.Year - YEARS_BACK;

            XDocument doc = XDocument.Load("../../../catalog.xml");

            var albumsQuery =
                from album in doc.Descendants("album")
                where int.Parse(album.Element("year").Value) <= minYear
                select new
                    {
                        AlbumName = album.Element("name").Value,
                        Price = album.Element("price").Value
                    };

            Console.WriteLine("Albums published more than {0} years ago:", YEARS_BACK);
            foreach (var album in albumsQuery)
            {
                Console.WriteLine(album.AlbumName + " price: " + album.Price);
            }
        }
    }
}
