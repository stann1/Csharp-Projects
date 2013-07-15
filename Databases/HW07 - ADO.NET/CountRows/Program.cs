using System;
using System.Linq;
using System.Data.SqlClient;

namespace CountRows
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection("Server=.; " +
            "Database=northwind; Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand selectRowsCount = new SqlCommand("SELECT COUNT(*) FROM Categories", dbCon);
                int categoriesCount = (int)selectRowsCount.ExecuteScalar();
                Console.WriteLine("Total categories in NorthWind: {0}", categoriesCount);
            }
        }
    }
}
