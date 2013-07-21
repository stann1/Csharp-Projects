using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using NorthwindDB.Data;
using System.Data.SqlClient;
using System.IO;

namespace _06.NorthwindTwinCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindEntities dbContext = new NorthwindEntities();            
            
            string sqlGenerator = ((IObjectContextAdapter)dbContext).ObjectContext.CreateDatabaseScript();
            dbContext.Database.ExecuteSqlCommand("CREATE DATABASE NorthwindTwin");
            dbContext.Database.ExecuteSqlCommand("USE NorthwindTwin " + sqlGenerator.ToString());            
        }
    }
}
