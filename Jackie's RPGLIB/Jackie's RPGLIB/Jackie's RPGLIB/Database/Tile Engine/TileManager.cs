using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Jackie_s_RPGLIB.Database.Core;

namespace Jackie_s_RPGLIB.Database.Tile_Engine
{
    public class TileManager
    {
        List<Tileset> _myTileset;
        List<TileMap> _myMap;
        string _path;

        public TileManager()
        {
            _myMap = new List<TileMap>();
            _myTileset = new List<Tileset>();
            _path = "";
        }

        public List<Tileset> myTileset
        {
            get { return _myTileset; }
        }

        public List<TileMap> myMap
        {
            get { return _myMap; }
        }

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public void newTileset(string name, int id)
        {
            _myTileset.Add(new Tileset(id, name));
        }

        public void newMap()
        {
            _myMap.Add(new TileMap());
        }
    }
}
