using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using StringsTestConsumer.Console.IISServiceReference1;


namespace StringsTestConsumer.Console
{
    class StringsTestClient
    {
        static void Main(string[] args)
        {
            //Run the IISHostedService before running this program
            ServiceStringsTestClient client = new ServiceStringsTestClient();
            int countOccurances = client.FindStringRepetitionInTargetString("the", "The boy in the mud");
            System.Console.WriteLine("IIS Service reports: substring found {0} times", countOccurances);
        }
    }
}
