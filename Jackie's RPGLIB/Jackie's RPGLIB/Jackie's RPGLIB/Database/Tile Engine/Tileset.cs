using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jackie_s_RPGLIB.Database.Tile_Engine
{
    public class Tileset
    {
        // Field

        string _name;
        bool _loaded;
        int _id;

        // Constructor

        public Tileset()
        {
            _name = "";
            _loaded = false;
            _id = 0;
        }

        public Tileset(int id)
        {
            _name = "";
            _loaded = false;
            _id = id;
        }

        public Tileset(int id, string name)
        {
            _name = name;
            _loaded = false;
            _id = id;
        }

        // Property

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool Loaded
        {
            get { return _loaded; }
            set { _loaded = value; }
        }
    }
}
