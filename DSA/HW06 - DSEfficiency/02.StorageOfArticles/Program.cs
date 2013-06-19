using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _02.StorageOfArticles
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedMultiDictionary<decimal, Article> dataBase = new OrderedMultiDictionary<decimal, Article>(true);
            Stopwatch sw = new Stopwatch();

            //The sample file articles.txt is not very good for testing, unfortunatelly I dont have time to make a better one
            sw.Start();
            FillInDataBase(dataBase);
            sw.Stop();
            Console.WriteLine("Addition time: {0}", sw.Elapsed);

            sw.Restart();
            var result = dataBase.Range(0.20m, true, 2.30m, true);
            sw.Stop();

            Console.WriteLine("Query time: {0}", sw.Elapsed);
            Console.WriteLine("Articles in price range: {0}", result.Count);

        }

        private static void FillInDataBase(OrderedMultiDictionary<decimal, Article> dataBase)
        {
            StreamReader reader = new StreamReader(@"../../articles.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] data = line.Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    decimal price = decimal.Parse(data[3]);
                    Article article = new Article(data[0], data[1], data[2], price);

                    if (dataBase.ContainsKey(price))
                    {
                        dataBase[price].Add(article);
                    }
                    else
                    {
                        dataBase.Add(price, article);
                    }

                    line = reader.ReadLine();
                }
            }
        }
    }
}
