using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.WorkdaysBetweenDates
{
    class Workdays
    {
        
        static DateTime[] publicHolidays = { new DateTime(2013, 3, 3), new DateTime(2013, 5, 6), new DateTime(2013, 5, 24) };

        static int GetDaysToFutureDate(DateTime today, DateTime future)
        {
            int difference = (int)(future - today).TotalDays;      //total difference in days
            int weekends = 0;
            

            for (int i = 0; i < difference; i++)
            {
                bool dayOff = VerifyDayOfWeek(today.AddDays(i));
                if (dayOff)
                {
                    weekends++;
                }
            }

            return (difference - weekends);
        }

        private static bool VerifyDayOfWeek(DateTime today)        //This verifies if it is non-working day
        {
            int startDay = 0;
            bool dayOff = false;
            for (int i = 0; i < publicHolidays.Length; i++)
            {
                if (today == publicHolidays[i])
                {
                    return true;
                }
            }
            switch (today.DayOfWeek)
            {

                case DayOfWeek.Monday: startDay = 0;
                    break;
                case DayOfWeek.Tuesday: startDay = 1;
                    break;
                case DayOfWeek.Wednesday: startDay = 2;
                    break;
                case DayOfWeek.Thursday: startDay = 3;
                    break;
                case DayOfWeek.Friday: startDay = 4;
                    break;
                case DayOfWeek.Saturday: startDay = 5;
                    break;
                case DayOfWeek.Sunday: startDay = 6;
                    break;
                default:
                    break;
            }

            if (startDay == 5 || startDay == 6)
            {
                dayOff = true; 
            }
            return dayOff;
        }

        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            DateTime future = new DateTime(2013, 6, 15);

            int workDays = GetDaysToFutureDate(today, future);
            Console.WriteLine("Working days, for period ({0:dd.MM.yyyy} - {1:dd.MM.yyyy}):", today.Date, future.Date);
            Console.WriteLine(workDays);
           
        }

        
    }
}
