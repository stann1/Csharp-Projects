using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RetrieveImagesFromCategories
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
                SqlCommand command = new SqlCommand("SELECT CategoryName, Picture FROM Categories", dbCon);
                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        byte[] rawData = (byte[]) reader["Picture"];
                        string fileName = reader["CategoryName"].ToString().Replace('/', '_') + ".jpg";
                        int len = rawData.Length;
                        int header = 78;
                        byte[] imgData = new byte[len - header];
                        Array.Copy(rawData, 78, imgData, 0, len - header);
 
                        MemoryStream memoryStream = new MemoryStream(imgData);
                        System.Drawing.Image image = System.Drawing.Image.FromStream(memoryStream);
                        //images will be saved in bin/debug folder
                        image.Save(new FileStream(fileName, FileMode.Create), ImageFormat.Jpeg);
                    }
                }
            }
        }
    }
}
