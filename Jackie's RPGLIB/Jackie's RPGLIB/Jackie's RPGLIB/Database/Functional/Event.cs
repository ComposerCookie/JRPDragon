using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jackie_s_RPGLIB.Database.Functional
{
    public class Event
    {
        string _name;
        int _type;
        int _pos;

        public Event()
        {
            _name = "";
            _type = 0;
            _pos = 0;
        }

        public Event(string name, int type, int pos)
        {
            _name = name;
            _type = type;
            _pos = pos;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int Position
        {
            get { return _pos; }
            set { _pos = value; }
        }

        public virtual bool CheckRequirement()
        {
            return false;
        }

        public virtual void PerformFunction()
        {

        }
    }
}
