using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.KnapsackProblem
{
    class Product
    {
        public Product(string name, int weight, int cost)
        {
            this.Name = name;
            this.Weight = weight;
            this.Cost = cost;
        }
        
        public string Name { get; set; }

        public int Weight { get; set; }

        public int Cost { get; set; }

        public override string ToString()
        {
            return String.Format("{0}: weight = {1}, cost = {2}", this.Name, this.Weight, this.Cost);
        }
    }
}
