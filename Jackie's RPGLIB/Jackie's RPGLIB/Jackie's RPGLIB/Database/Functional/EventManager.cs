using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jackie_s_RPGLIB.Database.Functional
{
    public class EventManager
    {
        List<Event> _myEvent;

        public EventManager()
        {
            _myEvent = new List<Event>();
        }

        public List<Event> MyEvent
        {
            get { return _myEvent; }
        }
    }
}
