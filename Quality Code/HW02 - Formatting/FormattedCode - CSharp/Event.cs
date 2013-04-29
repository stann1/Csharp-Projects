using System;
using System.Linq; 
using System.Text;

namespace FormattedCode
{
    class Event : IComparable
    {
        private DateTime date;
        private String title;
        private String location;

        public Event(DateTime date, string title, string location) 
        {
            this.date = date;		
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object existingObject)
        {
            Event other = existingObject as Event;
            int byDate = this.date.CompareTo(other.date);
            int byTitle = this.title.CompareTo(other.title);
            int byLocation = this.location.CompareTo(other.location);

            if (byDate == 0)
            {
                if (byTitle == 0)
                {
                    return byLocation;
                }
                else
                {
                    return byTitle;
                }
            }
            else
            {
                return byDate;
            }
        }

        public override string ToString()
        {
            StringBuilder stringOutput = new StringBuilder();
            stringOutput.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));			
            stringOutput.Append(" | " + title);

            if (location != null && location != string.Empty)
            {
                stringOutput.Append(" | " + location);
            }

            return stringOutput.ToString();
        }
    }
}

