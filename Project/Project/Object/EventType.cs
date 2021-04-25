using Project.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Object
{
    class EventType
    {

        public string typeName { get; }
        public int typeId { get; }
        public double percent { get; set; }
        public int percentDenominator { get; set; }
        public int ctr { get; set; }

        private  EventType(int intValue,string stringValue , int percent =0)
        {
            percentDenominator = 0;
            ctr = 0;
            percent = 0;
            typeName = stringValue;
            typeId = intValue;
            this.percent = percent;
        }



        public static List<EventType> getTypes()
        {
            List<EventType> types = new List<EventType>();

            types.Add(new EventType(1,"Exam"));
            types.Add(new EventType(2, "Quiz"));
            types.Add(new EventType(3, "Assignment"));
            return types;
        }


    }
}
