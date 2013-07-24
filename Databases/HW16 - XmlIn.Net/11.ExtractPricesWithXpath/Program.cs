﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _11.ExtractPricesWithXpath
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../catalog.xml");
            string xPathQuery = "catalog/album";
            int YEARS_BACK = 20;

            XmlNodeList albumList = xmlDoc.SelectNodes(xPathQuery);

            Console.WriteLine("Albums published more than {0} years ago:", YEARS_BACK);
            foreach (XmlNode album in albumList)
            {
                string publishYear = album.SelectSingleNode("year").InnerText;
                
                if (int.Parse(publishYear) <= (DateTime.Now.Year - YEARS_BACK))
                {
                    string albumName = album.SelectSingleNode("name").InnerText;
                    string price = album.SelectSingleNode("price").InnerText;

                    Console.WriteLine("{0}, price {1}", albumName, price);
                }

            }
        }
    }
}
