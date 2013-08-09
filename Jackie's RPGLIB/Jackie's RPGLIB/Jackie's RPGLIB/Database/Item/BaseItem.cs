using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jackie_s_RPGLIB.Database.Item
{
    public class BaseItem
    {
        string _name;
        string _description;

        int _value;


        public BaseItem()
        {
            _name = "";
            _description = "";
            _value = 0;
        }

        public BaseItem(string name, string description, int value)
        {
            _name = name;
            _description = description;
            _value = value;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}
