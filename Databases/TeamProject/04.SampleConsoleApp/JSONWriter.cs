using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MongoDB.Bson;
using _02.EntityFramework.Model;
using _03.EntityFramework.Data;

namespace _04.SampleConsoleApp
{
    public static class JSONWriter
    {
        public static void WriteJSON(NewEntitiesModel context)
        {
            var productItemsCollection = new MongoHelper<ProductItem>("Products");
            productItemsCollection.MongoCollection.Drop();

            foreach (var product in context.Products.Include("Vendor").Include("Reports"))
            {
                int productId = product.Id;
                string vendorName = product.Vendor.VendorName;
                string productName = product.ProductName;
                decimal quantity = 0;
                decimal sum = 0;
                foreach (var report in product.Reports)
                {
                    quantity += report.Quantity.Value;
                    sum += report.Sum.Value;
                }

                // Console.WriteLine(productId + " : " + vendorName + " : " + productName + " : " + quantity + " : " + sum);
                var tempObject = new ProductItem()
                {
                    ProductId = productId,
                    ProductName = productName,
                    VendorName = vendorName,
                    Quantity = quantity,
                    Sum = sum
                };
                productItemsCollection.InsertData(tempObject);
            }

            var productList = productItemsCollection.LoadData<ProductItem>().ToJson();
            var removeId = Regex.Replace(productList, "\"_id\".*?\\,", "", RegexOptions.IgnoreCase);
            var formatedList = Regex.Replace(removeId, ",", ",\n", RegexOptions.IgnoreCase);
            var removedBracesRight = Regex.Replace(formatedList, "},", "\n},", RegexOptions.IgnoreCase);
            var removedBracesLeft = Regex.Replace(removedBracesRight, "{", "{\n", RegexOptions.IgnoreCase);
            File.Delete(@"../../../GeneratedReports/report.json");
            File.WriteAllText(@"../../../GeneratedReports/report.json", removedBracesLeft);
            Console.WriteLine("JSON report created.");
        }
    }
}
