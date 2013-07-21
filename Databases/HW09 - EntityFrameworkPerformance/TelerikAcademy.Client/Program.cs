using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikAcademy.Data;

namespace TelerikAcademy.Client
{
    class Program
    {
        static TelerikAcademyEntities dbContext = new TelerikAcademyEntities();

        static void Main(string[] args)
        {           

            //ExecuteQueryWithoutInclude();          //results in over 300 transactions and 0.7 sec speed
            ExecuteQueryWithInclude();              //results in 1 transaction and 0.5 speed
            
        }
       
        private static void ExecuteQueryWithoutInclude()
        {
            using (dbContext)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                foreach (var employee in dbContext.Employees)
                {
                    Console.WriteLine("Employee: {0}, department: {1}, town: {2}",
                        employee.FirstName + " " + employee.LastName, employee.Department.Name, employee.Address.Town.Name);
                }
                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }            
        }

        private static void ExecuteQueryWithInclude()
        {
            using (dbContext)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                foreach (var employee in dbContext.Employees.Include("Address.Town").Include("Department"))
                {
                    Console.WriteLine("Employee: {0}, department: {1}, town: {2}",
                        employee.FirstName + " " + employee.LastName, employee.Department.Name, employee.Address.Town.Name);
                }
                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
            
        }

    }
}
