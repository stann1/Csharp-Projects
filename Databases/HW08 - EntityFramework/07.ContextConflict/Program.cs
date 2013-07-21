using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDB.Data;


namespace _07.ContextConflict
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindEntities firstContext = new NorthwindEntities();
            NorthwindEntities secondContext = new NorthwindEntities();

            firstContext.Customers.Add(new Customer() { CustomerID = "ALABA", CompanyName = "Some company" });
            firstContext.SaveChanges();
           
            //the second command will be the final because there is no conflict resolution
            firstContext.Customers.Find("ALABA").ContactName = "Bacho Kiro";
            secondContext.Customers.Find("ALABA").ContactName = "Bai Stavri";

            firstContext.SaveChanges();
            secondContext.SaveChanges();
            

        }
    }
}
