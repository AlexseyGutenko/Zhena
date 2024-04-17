using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace женя_ушакова_проект
{
 
    internal class Journal
    {
        private List<Event> events;

        public Journal(List<Event> events)
        {
            this.events = events;
        }
        public List<Event> GetEvents()
        {
            return events;
        }

        public string DisplayAllEventsForDay(DateTime date)
        {
            string result = $"События на {date.ToShortDateString()}:   \n";
            foreach (Event ev in events)
            {
                result =result+ $"\nНазвание: {ev.Name} \n        время: {ev.StartTime}          \nОписание: {ev.Description}";
                
            }
            return result;

        }

        public void AddEvent(Event newEvent)
        {
            events.Add(newEvent);
        }

        public void SaveEventsToFile(string date)
        {
            using (StreamWriter sw = new StreamWriter(date + ".txt"))
            {
                foreach (Event ev in events)
                {
                    sw.WriteLine($"Название: {ev.Name}\nДата и время: {ev.StartTime}\nОписание: {ev.Description}");
                }
            }
        }  
    }
}