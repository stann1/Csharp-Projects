namespace _04.SampleConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using _02.EntityFramework.Model;
    using _03.EntityFramework.Data;
    using System.Globalization;
    using System.Data.SQLite;

    public class ConsoleApp
    {
        static void Main()
        {            
            using (NewEntitiesModel context = new NewEntitiesModel())
            {
                DatabaseMover.MoveDatabase();
                ExcelReader.ParseZip(@"../../../ZIPs/Sample-Sales-Reports.zip", context);
                Console.WriteLine("Parsed excels into db");
            }

            PdfGenerator.GenerateReport();

            using (NewEntitiesModel context = new NewEntitiesModel())
            {
                XmlWriter.CreateXmlReport(context);
            }

            using (NewEntitiesModel context = new NewEntitiesModel())
            {
                XmlLoader.LoadDataFromXml(@"../../../ZIPs/Vendor-Expenses.xml", context);
            }

            using (NewEntitiesModel context = new NewEntitiesModel())
            {
                JSONWriter.WriteJSON(context);
            }


            SQLiteConnector.CreateSQLiteDB();
        }
    }
}
