using System;
using System.Linq;
using System.Text;


namespace FormattedCode
{
    static class Messages
    {
        private static readonly StringBuilder output;

        public static void EventAdded()
        {
            output.Append("Event added");
            output.Append(Environment.NewLine);
        }

        public static void EventDeleted(int removedEventsCount)
        {
            if (removedEventsCount == 0)
            {
                NoEventsFound();
            }
            else
            {
                output.AppendFormat("{0} events deleted", removedEventsCount);
                output.Append(Environment.NewLine);
            }
        }

        public static void NoEventsFound()
        {
            output.Append("No events found");
            output.Append(Environment.NewLine);
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                output.Append(eventToPrint);
                output.Append(Environment.NewLine);
            }
        }
    }
}
