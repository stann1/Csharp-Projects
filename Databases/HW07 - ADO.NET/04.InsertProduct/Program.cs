using System;
using System.Data.SqlClient;
using System.Linq;

namespace _04.InsertProduct
{
    class Program
    {
        static SqlConnection dbCon;

        static void Main(string[] args)
        {
            dbCon = new SqlConnection("Server=.; " +
            "Database=northwind; Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                InsertNewProductInDatabase("Zagorka Beer", 1, 0);
            }            
        }
  
        private static void InsertNewProductInDatabase(string prodName, int categoryId, int discontinued)
        {
            SqlCommand insertProduct = new SqlCommand("INSERT INTO Products(ProductName, CategoryID, Discontinued)" +
                                                      "VALUES (@productName, @categoryId, @discontinued)", dbCon);
            insertProduct.Parameters.AddWithValue("@productName", prodName);
            insertProduct.Parameters.AddWithValue("@categoryId", categoryId);
            insertProduct.Parameters.AddWithValue("@discontinued", discontinued);
            insertProduct.ExecuteNonQuery();
        }
    }
}
