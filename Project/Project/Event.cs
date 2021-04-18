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


        public Event(string name, DateTime date)
        {
            this.name = name;
            this.date = date;
            this.remainingDays = ((date - DateTime.Today).TotalDays);
        }

        public void UpdateEventData() //update sa remaining days 
        {
            remainingDays = (date - DateTime.Today).TotalDays;
        }
    }
}
