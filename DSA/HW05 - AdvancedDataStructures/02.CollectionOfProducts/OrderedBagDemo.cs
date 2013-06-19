using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _02.CollectionOfProducts
{
    class OrderedBagDemo
    {
        static void Main(string[] args)
        {
            OrderedBag<Product> bag = new OrderedBag<Product>();

            int numOfProducts = 10000;
            double highPrice = 7000;
            double lowPrice = 4000;
            int productsToDisplay = 20;

            for (double i = 0; i < numOfProducts; i++)
            {
                bag.Add(new Product(i.ToString(), i));
            }

            var selection = bag.Range(new Product("someproduct", lowPrice), true, new Product("someproduct", highPrice), true);

            Console.WriteLine("First {0} products in the price range {1} - {2}:", productsToDisplay, lowPrice, highPrice);
            for (int i = 0; i < productsToDisplay; i++)
            {
                Console.WriteLine(selection[i]);
            }
        }
    }
}
