using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using _03.EntityFramework.Data;

namespace _04.SampleConsoleApp
{
    public class SQLiteConnector
    {
        public static void CreateSQLiteDB()
        {
            //SQLiteConnection.CreateFile("SQLiteSupermarketDB.sqlite");

            var dbConnection = new SQLiteConnection("Data Source=SQLiteSupermarketDB.sqlite;Version=3;");
            dbConnection.Open();

            using (dbConnection)
            {
                //Creating main table
                string sqlStatement = "create table VendorIncomes(" +
                                      "Id integer not null," +
                                      "Vendors nvarchar(50)," +
                                      "Incomes numeric(10,5)," +
                                      "Expenses numeric(10,5)," +
                                      "Taxes numeric(10,5)," +
                                      "primary key (Id)" +
                                      ");";
                //string sqlStatement = "drop table VendorIncomes";
                SQLiteCommand createIncomes = new SQLiteCommand(sqlStatement, dbConnection);
                createIncomes.ExecuteNonQuery();

                //SQLiteCommand insert = new SQLiteCommand("insert into VendorIncomes(Vendors) values('Kamenitza'),('Zagorka');", dbConnection);
                //insert.ExecuteNonQuery();

                //SQLiteCommand select = new SQLiteCommand("select * from VendorIncomes", dbConnection);
                //var reader = select.ExecuteReader();

                //while (reader.Read())
                //{
                //    string fileNames = (string)reader["Vendors"];

                //    Console.WriteLine(fileNames);
                //}
                               

                //Creating taxes table
                string sqlStatementTaxes = "create table ProductTaxes(" +
                                      "Id integer not null," +
                                      "Name nvarchar(50)," +
                                      "Tax numeric(10,5)," +                                      
                                      "primary key (Id)" +
                                      ");";
                
                SQLiteCommand cmd = new SQLiteCommand(sqlStatementTaxes, dbConnection);
                cmd.ExecuteNonQuery();

                List<string> products;

                using (var entityDb = new NewEntitiesModel())
                {
                    products =
                        (from p in entityDb.Products
                         select p.ProductName).ToList();
                }

                StringBuilder sb = new StringBuilder();
                sb.Append("insert into ProductTaxes(Name, Tax) values");

                Random randGenerator = new Random();
                foreach (var prod in products)
                {
                    double tax = randGenerator.Next(10, 22);

                    sb.AppendFormat("('{0}','{1}'),", prod, tax);
                }
                sb.Length--;
                sb.Append(";");
                //Console.WriteLine(sb.ToString());

                var insertIntoTaxSql = sb.ToString();
                SQLiteCommand insertCmd = new SQLiteCommand(insertIntoTaxSql, dbConnection);
                insertCmd.ExecuteNonQuery();
            }

            Console.WriteLine("SQLite db created and populated");

        }

        public static void LoadMongoProducts()
        {
            var productItemsCollection = new MongoHelper<ProductItem>("Products");
            var products = productItemsCollection.LoadData<ProductItem>().ToList();

            
            //"ProductId" : 1,
            // "ProductName" : "BeerZagorka",
            // "VendorName" : "Zagorka",
            // "Quantity" : "673.00",
            // "Sum" : "609.24" 

            using (var dbConnection = new SQLiteConnection("Data Source=SQLiteSupermarketDB.sqlite;Version=3;"))
            {
                dbConnection.Open();
                //create table
                //string sqlStatement = "create table Products(" +
                //                      "Id integer not null," +
                //                      "ProductId integer," +
                //                      "ProductName nvarchar(50)," +
                //                      "VendorName nvarchar(50)," +
                //                      "Quantity numeric(10,5)," +
                //                      "Sum numeric(10,5)," +
                //                      "primary key (Id)" +
                //                      ");";
                //SQLiteCommand createTable = new SQLiteCommand(sqlStatement, dbConnection);
                //createTable.ExecuteNonQuery();

                //insert data
                StringBuilder sb = new StringBuilder();
                sb.Append("insert into Products(ProductId, ProductName, VendorName, Quantity, Sum) values");

                foreach (var prod in products)
                {
                    sb.AppendFormat("('{0}','{1}','{2}','{3}','{4}'),", prod.ProductId
                        , prod.ProductName, prod.VendorName, prod.Quantity, prod.Sum);
                }
                sb.Length--;
                sb.Append(";");

                //Console.WriteLine(sb.ToString());

                SQLiteCommand populateProducts = new SQLiteCommand(sb.ToString(), dbConnection);
                populateProducts.ExecuteNonQuery();
            }
        }

        public static void GenerateExcelReport(int month)
        {
            var dbMSSQL = new NewEntitiesModel();

            using (dbMSSQL)
            {
                var dbSQLite = new SQLiteConnection("Data Source=SQLiteSupermarketDB.sqlite;Version=3;");
                dbSQLite.Open();

                Dictionary<string, decimal> productTaxes = new Dictionary<string, decimal>();

                SQLiteCommand select = new SQLiteCommand("select * from ProductTaxes", dbSQLite);
                var reader = select.ExecuteReader();

                while (reader.Read())
                {
                    string name = (string)reader["Name"];
                    decimal tax = (decimal)reader["Tax"];
                    productTaxes[name] = tax/100;
                }                

                dbSQLite.Close();

                var salesByVendors =
                    from re in dbMSSQL.Reports
                    join p in dbMSSQL.Products on re.ProductId equals p.Id
                    join v in dbMSSQL.Vendors on p.VendorId equals v.Id                    
                    where re.Date.Value.Month == month
                    group new { v, re } by new { v.VendorName }
                        into grp
                        select new { vendor = grp.Key.VendorName, income = grp.Sum(re => re.re.Sum) };

                //foreach (var item in salesByVendors)
                //{
                //    Console.WriteLine(item.vendor + "-->" + item.income);
                //}
                var expensesByVendors =
                    from me in dbMSSQL.MonthlyExpenseReports
                    join ve in dbMSSQL.Vendors on me.VendorId equals ve.Id
                    where me.Date.Value.Month == month
                    group new { ve, me } by new { ve.VendorName }
                    into grp
                        select new { vendor = grp.Key.VendorName, expenses = grp.Sum(me => me.me.Expenses) };

                //foreach (var item in expensesByVendors)
                //{
                //    Console.WriteLine(item.vendor + "-->" + item.expenses);
                //}

                //var taxesByVendors =
                //    from re in dbMSSQL.Reports
                //    join taxes in productTaxes on re.Product.ProductName equals taxes.Key
                //    join ve in dbMSSQL.Vendors on re.ProductId equals ve.Id
                //    where re.Date.Value.Month == month
                //    group new {ve, re, taxes} by new {ve.VendorName}
                //    into grp
                //    select new {vendor = grp.Key.VendorName, totalTaxes = grp.Sum((tax,sales) => tax.taxes.Value * sales.re.Sum))};
            }
        }
                
    }
}
