using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jackie_s_RPGLIB.Database.Character
{
    public class Stats
    {
        string _name;
        string _description;

        public Stats()
        {
            _name = "";
            _description = "";
        }

        public Stats(string name, string description)
        {
            _name = name;
            _description = description;
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
    }
}
