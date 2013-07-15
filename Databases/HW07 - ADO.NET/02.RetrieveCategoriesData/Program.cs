using System;
using System.Data.SqlClient;

namespace _02.RetrieveCategoriesData
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
                SqlCommand selectCategories = new SqlCommand("SELECT CategoryName, Description FROM Categories", dbCon);
                SqlDataReader reader = selectCategories.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string description = (string)reader["Description"];
                        Console.WriteLine("{0} --> {1}", categoryName, description);
                    }
                }
            }
        }
    }
}
