using System;
using System.Linq;
using CodeJewelData;
using CodeJewelModels;
using System.Data.Entity;
using CodeJewelData.Migrations;

namespace TestClient
{
    class Program
    {
        static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CodeContext, Configuration>());
            var context = new CodeContext();
            //var cat = new Category
            //{
            //    Name="Test category"
            //};
            //context.Categories.Add(cat);
            //context.SaveChanges();

            var categories = from c in context.Categories
                       select c;
            foreach (var category in categories)
            {
                Console.WriteLine(category.Id);
                Console.WriteLine(category.Name);
            }
        }
    }
}
