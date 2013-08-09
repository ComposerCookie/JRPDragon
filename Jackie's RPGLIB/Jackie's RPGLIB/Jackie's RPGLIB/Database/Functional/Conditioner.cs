using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jackie_s_RPGLIB.Database.Functional
{
    public class Conditioner : Event
    {
        List<Event> _if;
        List<Event> _else;

        public Conditioner()
        {
            _if = new List<Event>();
            _else = new List<Event>();

            Type = 1;
        }

        public List<Event> If
        {
            get { return _if; }
            set { _if = value; }
        }

        public List<Event> Else
        {
            get { return _else; }
            set { _else = value; }
        }

        public override void PerformFunction()
        {
            if (CheckRequirement())
                foreach (Event e in If)
                    e.PerformFunction();
            else
                foreach (Event e in Else)
                    e.PerformFunction();
        }

    }
}
