using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StorageOfArticles
{
    public class Article : IComparable<Article>
    {
        public string Title { get; set; }
        public string Vendor { get; set; }
        public string Barcode { get; set; }
        public decimal Price { get; set; }

        public Article(string title, string vendor, string barcode, decimal price)
        {
            this.Title = title;
            this.Vendor = vendor;
            this.Barcode = barcode;
            this.Price = price;
        }

        public int CompareTo(Article other)
        {
            return this.Barcode.CompareTo(other.Barcode);
        }
    }
}
