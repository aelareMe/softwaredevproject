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

        public string typeName { get; set; }
        public int typeId { get; set; }
        private  EventType(int intValue,string stringValue)
        {
            typeName = stringValue;
            typeId = intValue;
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
