using System;
using System.Data.SqlClient;

namespace _03.RetrieveProductsByCategories
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
                SqlCommand selectCategories = new SqlCommand("SELECT c.CategoryName, p.ProductName " + 
                                                             "FROM Categories c JOIN Products p " + 
                                                             "ON p.CategoryID = c.CategoryID " +
                                                             "ORDER BY c.CategoryName", dbCon);
                SqlDataReader reader = selectCategories.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string productName = (string)reader["ProductName"];
                        Console.WriteLine("{0} --> {1}", categoryName, productName);
                    }
                }
            }
        }
    }
}
