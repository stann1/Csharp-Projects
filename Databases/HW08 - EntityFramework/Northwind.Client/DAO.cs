using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDB.Data;

namespace Northwind.Client
{
    public class DAO
    {
        public static NorthwindEntities dbContext = new NorthwindEntities();

        public static void InsertCustomer(string customerID, string companyName, string contactName = null, string contactTitle = null,
                                           string address = null, string city = null, string region = null, string postalCode = null,
                                           string country = null, string phone = null, string fax = null)
        {
            using (dbContext)
            {
                Customer customer = new Customer();
                customer.CustomerID = customerID;
                customer.CompanyName = companyName;
                customer.ContactName = contactName;
                customer.ContactTitle = contactTitle;
                customer.Address = address;
                customer.City = city;
                customer.Region = region;
                customer.PostalCode = postalCode;
                customer.Country = country;
                customer.Phone = phone;
                customer.Fax = fax;

                dbContext.Customers.Add(customer);
                dbContext.SaveChanges();
                Console.WriteLine("One row added.");
            }
        }

        public static void UpdateCustomer(string customerID, string companyName, string contactName = null, string contactTitle = null,
                                           string address = null, string city = null, string region = null, string postalCode = null,
                                           string country = null, string phone = null, string fax = null)
        {
            using (dbContext)
            {
                Customer customer = dbContext.Customers.Find(customerID);
                customer.CompanyName = companyName;
                customer.ContactName = contactName;
                customer.ContactTitle = contactTitle;
                customer.Address = address;
                customer.City = city;
                customer.Region = region;
                customer.PostalCode = postalCode;
                customer.Country = country;
                customer.Phone = phone;
                customer.Fax = fax;

                dbContext.SaveChanges();
                Console.WriteLine("One row updated.");
            }
        }

        public static void DeleteCustomer(string customerID)
        {
            using (dbContext)
            {
                Customer customer = dbContext.Customers.Find(customerID);
                dbContext.Customers.Remove(customer);
                dbContext.SaveChanges();
                Console.WriteLine("One row deleted.");
            }
        }

        // method for task 9 (I am too lazy to fill in all column names :))
        public static void InsertOrder(string customerID = null, string orderDate = null, string shipCountry = null)
        {
            using (dbContext)
            {
                Order order = new Order() { CustomerID = customerID, OrderDate = DateTime.Parse(orderDate), ShipCountry = shipCountry };
                dbContext.Orders.Add(order);
                dbContext.SaveChanges();
                Console.WriteLine("One row added.");
            }
        }
    }
}
