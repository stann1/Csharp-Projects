using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.GetProductsFromInputString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter product to search for:");
            string input = Console.ReadLine();
            List<string> matchedProducts = GetProductsFromInput(input);

            foreach (string product in matchedProducts)
            {
                Console.WriteLine(product);
            }
        }
  
        private static List<string> GetProductsFromInput(string input)
        {
            List<string> products = new List<string>();
            SqlConnection dbCon = new SqlConnection("Server=.; " +
            "Database=northwind; Integrated Security=true");
            dbCon.Open();

            using (dbCon)
            {
                string sql = "SELECT ProductName FROM Products where ProductName LIKE @input";
                SqlCommand getProducts = new SqlCommand(sql, dbCon);
                getProducts.Parameters.AddWithValue("@input", "%" + input + "%");

                SqlDataReader reader = getProducts.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        products.Add(reader["ProductName"].ToString());
                    }
                }
            }

            return products;
        }
    }
}
