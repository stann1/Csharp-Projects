using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDB.Data;

namespace Northwind.Client
{
    class TestDAO
    {
        static void Main(string[] args)
        {
            //task 2
            //DAO.InsertCustomers("BASHO", "Huskvarna", "Bai Pesho");
            //DAO.UpdateCustomer("BASHO", "Telerik");
            //DAO.DeleteCustomer("BASHO");

            //tasks 3 - 5
            //FindAllCustomersWithOrdersByYearAndDestination(1997, "Canada");
            //FindAllCustomersWithOrdersByNativeSQL(1997, "Canada");
            FindAllOrdersForPeriodAndDestination(1997, 1998, "Germany");
        }

        private static void FindAllOrdersForPeriodAndDestination(int startYear, int endYear, string destinationCountry)
        {
            using (NorthwindEntities dbContext = new NorthwindEntities())
            {
                var orders =
                    from o in dbContext.Orders
                    where o.OrderDate.Value.Year >= startYear && o.OrderDate.Value.Year <= endYear && o.ShipCountry == destinationCountry
                    select o;

                foreach (var order in orders)
                {
                    Console.WriteLine("{0} order on date: {1}", order.Customer.ContactName, order.OrderDate);
                }                    
            }
        }

        private static void FindAllCustomersWithOrdersByNativeSQL(int year, string destination)
        {
            using (NorthwindEntities dbContext = new NorthwindEntities())
            {
                string sql = "SELECT c.ContactName FROM " +
                             "Customers c JOIN Orders o " +
                             "ON c.CustomerID = o.CustomerID " +
                             "WHERE YEAR(o.OrderDate) = {0} AND o.ShipCountry = {1} " +
                             "GROUP BY c.ContactName";
                var customerList = dbContext.Database.SqlQuery<string>(sql, year, destination);

                foreach (var customer in customerList)
                {
                    Console.WriteLine(customer);
                }
            }
        }

        static void FindAllCustomersWithOrdersByYearAndDestination(int year, string destination)
        {
            using (NorthwindEntities dbContext = new NorthwindEntities())
            {
                var customerList =
                    from c in dbContext.Customers
                    join o in dbContext.Orders
                    on c.CustomerID equals o.CustomerID
                    where o.OrderDate.Value.Year == year && o.ShipCountry == destination
                    group c by c.ContactName into r
                    select r;

                //var customerList = dbContext.Orders.Where(o => o.OrderDate.Value.Year == year && o.ShipCountry == destination)
                //    .GroupBy(c => c.Customer.ContactName);
                    

                foreach (var cust in customerList)
                {
                    Console.WriteLine(cust.Key);
                }
            }
        }
    }
}
