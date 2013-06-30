using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.KnapsackProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int basketSize = 10;
            
            List<Product> products = new List<Product>();
            products.Add(new Product("beer", 3, 2));
            products.Add(new Product("vodka", 8, 12));
            products.Add(new Product("cheese", 4, 5));
            products.Add(new Product("nuts", 1, 4));
            products.Add(new Product("ham", 2, 3));
            products.Add(new Product("whiskey", 8, 13));
            products.Add(new Product("bread", 1, 2));
            products.Add(new Product("watermelon", 3, 5));

            products.Sort((a,b) => -1*a.Cost.CompareTo(b.Cost));

            int[,] costTable = new int[products.Count, basketSize + 1];
            int[,] selected = new int[products.Count, basketSize + 1];

            //Since there are no products with value 0, first col is with 0
            for (int i = 0; i < products.Count; i++)
            {
                costTable[i, 0] = 0;
                selected[i, 0] = 0;
            }

            //Fill in for the first product
            for (int i = 1; i <= basketSize; i++)
            {
                if (products[0].Weight <= i)
                {
                    costTable[0, i] = products[0].Cost;
                    selected[0, i] = 1;
                }
                else
                {
                    costTable[0, i] = 0;
                    selected[0, i] = 0;
                }
            }

            //Fill in cost table
            for (int i = 0; i < products.Count - 1; i++)
            {
                for (int j = 1; j <= basketSize; j++)
                {
                    Product current = products[i + 1];

                    if (current.Weight > j)
                    {
                        continue;
                    }

                    int accumulatedCostIfOmmited = costTable[i, j];
                    int accumulatedCostIfAdded = costTable[i, j - current.Weight] + current.Cost;

                    if (accumulatedCostIfAdded > accumulatedCostIfOmmited)
                    {
                        costTable[i + 1, j] = accumulatedCostIfAdded;
                        selected[i + 1, j] = 1;
                    }
                    else
                    {
                        costTable[i + 1, j] = accumulatedCostIfOmmited;
                        selected[i + 1, j] = 0;
                    }
                }
            }
                        
            Console.WriteLine("Optimal cost: {0}", costTable[products.Count-1, basketSize]);
            //Select optimal solution
            List<Product> optimalSelection = new List<Product>();
            
            for (int i = products.Count - 1; i >= 0; i--)
            {
                if (basketSize < 0)
                {
                    break;
                }

                if (selected[i, basketSize] == 1)
                {
                    optimalSelection.Add(products[i]);
                    basketSize -= products[i].Weight;
                }
            }

            foreach (var prod in optimalSelection)
            {
                Console.WriteLine("{0} --> weight: {1}, cost: {2}", prod.Name, prod.Weight, prod.Cost);
            }
        }
    }
}
