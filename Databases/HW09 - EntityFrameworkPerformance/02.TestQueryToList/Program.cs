using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikAcademy.Data;

namespace _02.TestQueryToList
{
    class Program
    {
        static void Main(string[] args)
        {
            TelerikAcademyEntities dbContext = new TelerikAcademyEntities();
            using (dbContext)
            {
                //Unoptimized - over 300 requests
                //var employeesFromSofia = dbContext.Employees.ToList()
                //                                .Select(e => e.Address).ToList()
                //                                .Select(a => a.Town).ToList()
                //                                .Where(t => t.Name == "Sofia");

                //Optimized - 1 request only
                var employeesFromSofia = dbContext.Employees.Select(e => e.Address)
                                                .Select(a => a.Town)
                                                .Select(t => t.Name == "Sofia").ToList();

            }
        }
    }
}
