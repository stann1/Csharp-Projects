using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace TestProject
{
    [assembly: log4net.Config.XmlConfigurator(Watch = true)]

    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        static void Main(string[] args)
        {
            //Normally this should work, however the output txt file does not generate. I do not know how to fix this at the moment.
            //If you do, please leave me some info when you check my homework.
            log.Info("Info logging");
        }
    }
}
