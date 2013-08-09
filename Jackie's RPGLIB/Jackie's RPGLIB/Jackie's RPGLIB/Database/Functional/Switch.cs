using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jackie_s_RPGLIB.Database.Functional
{
    public class Switch
    {
        string _name;
        bool _value;

        public Switch()
        {
            _name = "";
            _value = false;
        }

        public Switch(string name, bool value)
        {
            _name = name;
            _value = value;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}
