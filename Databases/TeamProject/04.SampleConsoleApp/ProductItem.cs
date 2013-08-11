using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;


namespace _04.SampleConsoleApp
{
    class ProductItem
    {
        public ObjectId _id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string VendorName { get; set; }
        public decimal Quantity { get; set; }
        public decimal Sum { get; set; }
    }
}
