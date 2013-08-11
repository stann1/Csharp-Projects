using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendarConsumer.Console.CalendarServiceReference;

namespace CalendarConsumer.Console
{
    class CalendarClient
    {
        static void Main(string[] args)
        {
            ServiceCalendarClient calendarClient = new ServiceCalendarClient();
            string currentDay = calendarClient.GetDayOfWeek(DateTime.Now);
            System.Console.WriteLine("WCF service reports that today is: {0}", currentDay);
        }
    }
}
