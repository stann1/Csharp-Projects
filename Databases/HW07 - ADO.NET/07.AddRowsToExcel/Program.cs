using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AddRowsToExcel
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
            dbCon.Open();

            using (dbCon)
            {
                string insertSql = @"INSERT INTO [Sheet1$] (Name, Score) "+
                                    "VALUES (@name, @score)";
                OleDbCommand command = dbCon.CreateCommand();
                using (command)
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = insertSql;
                    command.Parameters.AddWithValue("@name", "John");
                    command.Parameters.AddWithValue("@score", "80");
                    command.ExecuteNonQuery();
                }
            }
            //open the file to see the changes
        }
    }
}
