using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jackie_s_RPGLIB.Database.Functional
{
    public class Variable
    {
        string _name;
        int _value;

        public Variable()
        {
            _name = "";
            _value = 0;
        }

        public Variable(string name, int value)
        {
            _name = name;
            _value = value;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}
