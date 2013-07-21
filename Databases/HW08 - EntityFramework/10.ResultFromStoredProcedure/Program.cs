using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDB.Data;


namespace _10.ResultFromStoredProcedure
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindEntities dbContext = new NorthwindEntities();
            using (dbContext)
            {
                var result = dbContext.usp_SelectSuppliersByIncomeAndPeriod(new DateTime(1996, 1, 1), new DateTime(1999, 1, 1), "Exotic Liquids").First();
                Console.WriteLine("Income for the period for {0} --> {1}", result.Supplier, result.Income);
            }           
        }
    }
}
