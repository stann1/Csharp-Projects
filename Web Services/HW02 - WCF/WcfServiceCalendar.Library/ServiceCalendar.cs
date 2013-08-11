using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceCalendar.Library
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceCalendar : IServiceCalendar
    {
        public string GetDayOfWeek(DateTime date)
        {
            return date.ToString("dddd", new CultureInfo("bg-BG"));
        }
    }
}
