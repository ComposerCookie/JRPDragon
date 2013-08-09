using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jackie_s_RPGLIB.Database.Character
{
    public class Sprites
    {
        string _name;
        int _id;
        bool _loaded;

        public Sprites()
        {
            _name = "";
            _id = 0;
            _loaded = false;
        }

        public Sprites(int id, string name)
        {
            _name = name;
            _id = id;
            _loaded = false;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public bool Loaded
        {
            get { return _loaded; }
            set { _loaded = value; }
        }
    }
}
