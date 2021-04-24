using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Event
    {
        public string name;
        public DateTime date;
        public double remainingDays;
        public int numDaysToAccomplish;
        public int numOfSessions;
        Dictionary<String,DateTime> sessions;


        public Event(string name, DateTime date, int numDaysToAccomplish, int numOfSessions)
        {
            this.name = name;
            this.date = date;
            this.remainingDays = ((date - DateTime.Today).TotalDays);
            this.numDaysToAccomplish = numDaysToAccomplish;
            this.numOfSessions = numOfSessions;
        }

        public void UpdateEventData() //update sa remaining days 
        {
            remainingDays = (date - DateTime.Today).TotalDays;
        }
    }
}
