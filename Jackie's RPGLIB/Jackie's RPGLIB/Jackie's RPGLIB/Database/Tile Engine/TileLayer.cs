using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jackie_s_RPGLIB.Database.Tile_Engine
{
    public class TileLayer
    {
        // Field

        List<Tile> _myTile;
        int _opacity;
        bool _visible;
        string _name;
        int _order;

        int _lastAnimated;

        List<TileLayer> _miniLayer;

        // Constructor

        public TileLayer()
        {
            _opacity = 100;
            _myTile = new List<Tile>();
            _name = "";
            _order = 0;
            _lastAnimated = 0;

            _miniLayer = new List<TileLayer>();
        }

        public TileLayer(int order)
        {
            _order = order;
            _opacity = 100;
            _name = "";
            _visible = true;
            _lastAnimated = 0;
            _myTile = new List<Tile>();
            _miniLayer = new List<TileLayer>();
        }

        public TileLayer(int order, int opacity, string name, bool visible)
        {
            _order = order;
            _opacity = opacity;
            _name = name;
            _visible = visible;
            _lastAnimated = 0;
            _myTile = new List<Tile>();
            _miniLayer = new List<TileLayer>();
        }

        // Property

        public int Opacity
        {
            get { return _opacity; }
            set { _opacity = value; }
        }

        public bool Visible
        {
            get { return _visible; }
            set { _visible = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Order
        {
            get { return _order; }
            set { _order = value; }
        }

        public List<Tile> myTile
        {
            get { return _myTile; }
        }

        public List<TileLayer> MiniLayer
        {
            get { return _miniLayer; }
        }

        public int LastAnimated
        {
            get { return _lastAnimated; }
            set { _lastAnimated = value; }
        }

        //Method

        public void addTile(Tile tile)
        {
            _myTile.Add(tile);
        }

        public void setTile(Tile tile, int pos)
        {
            _myTile[pos] = tile;
        }

        public void removeTile(Tile tile)
        {
            _myTile.Remove(tile);
        }
    }
}
