using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billy
{
    class EventID
    {
        static int nextID = 0;

        public static int getNewID()
        {
            int temp = nextID;
            nextID++;
            return temp;
        }
    }

    class Event
    {
        int id;

        public Event()
        {
            id = EventID.getNewID();
        }
    }
}
