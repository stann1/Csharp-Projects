using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace _06.DisplayDataFromExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using JET provider for xls files, because the newer ones do not work
            DataTable table = new DataTable("scores");
            string strAccessConn = string.Format(
                    "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=Excel 8.0;",
                    "../../Table.xls");
            OleDbConnection dbCon = new OleDbConnection(strAccessConn);

            using (dbCon)
            {
                string selectSql = @"SELECT * FROM [Sheet1$]";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(selectSql, dbCon))
                {
                    adapter.FillSchema(table, SchemaType.Source);
                    adapter.Fill(table);
                }            
            }

            Console.WriteLine("Name, score:");
            foreach (DataRow row in table.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
