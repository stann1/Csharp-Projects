using System;
using System.Linq;
using Wintellect.PowerCollections;

namespace FormattedCode
{
    class EventHolder
    {
        private MultiDictionary<string, Event> byTitle = new MultiDictionary<string, Event>(true);
        private OrderedBag<Event> byDate = new OrderedBag<Event>();

        public void AddEvent(DateTime date, string title, string location)
        {
            if (date == null || title == null)
            {
                throw new ArgumentNullException("The date/title cannot be null!");   
            }
            Event eventToAdd = new Event(date, title, location);
            this.byTitle.Add(title.ToLower(), eventToAdd);
            this.byDate.Add(eventToAdd);
            Messages.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            if (titleToDelete == null)
            {
                throw new ArgumentNullException("The title provided cannot be null!");
            }
            string title = titleToDelete.ToLower();
            int removedCount = 0;

            foreach (var eventToRemove in this.byTitle[title])
            {
                removedCount++;
                this.byDate.Remove(eventToRemove);
            }

            this.byTitle.Remove(title);
            Messages.EventDeleted(removedCount);
        }

        public void ListEvents(DateTime date, int count)
        {
            if (date == null)
            {
                throw new ArgumentNullException("The date provided cannot be null!");
            }

            OrderedBag<Event>.View eventsToShow = byDate.RangeFrom(new Event(date, "", ""), true);
            int shown = 0;

            foreach (var eventToShow in eventsToShow)
            {
                if (shown == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);
                shown++;
            }

            if (shown == 0)
            {
                Messages.NoEventsFound();
            }
        }
    } 
}
