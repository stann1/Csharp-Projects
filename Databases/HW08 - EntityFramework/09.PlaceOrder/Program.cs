using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Client;

namespace _09.PlaceOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            DAO.InsertOrder("ALFKI", "01/11/2012", "Bulgaria");           
        }
    }
}
