using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CollectionOfProducts
{
    class Product : IComparable<Product>
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public int CompareTo(Product other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("The product for comparison cannot be null!");
            }

            if (this.Price > other.Price)
            {
                return 1;
            }
            else if (this.Price == other.Price)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return string.Format("Product: {0}, price: {1}", this.Name, this.Price);
        }
    }
}
