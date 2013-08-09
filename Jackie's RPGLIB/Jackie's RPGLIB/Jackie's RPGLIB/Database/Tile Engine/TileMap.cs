using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Jackie_s_RPGLIB.Database.Functional;

namespace Jackie_s_RPGLIB.Database.Tile_Engine
{
    public class TileMap
    {
        // Field

        string _name;
        string _path;
        int _maxX, _maxY;
        int _playerAbove;

        TileProperty[] _block;
        List<TileLayer> _myLayer;

        EventManager[,] _eventManager;

        // Constructor

        public TileMap()
        {
            _name = "";
            _maxX = _maxY = 0;
            _myLayer = new List<TileLayer>();
            _block = new TileProperty[5];

            for (int i = 0; i < _block.Length; i++)
                _block[i] = new TileProperty(_maxX, _maxY);

            _eventManager = new EventManager[0, 0];
            for (int x = 0; x < _eventManager.GetLength(0); x++)
            {
                for (int y = 0; y < _eventManager.GetLength(1); y++)
                {
                    _eventManager[x, y] = new EventManager();
                }
            }
            
        }

        public TileMap(int maxX, int maxY)
        {
            _name = "";
            _maxX = maxX;
            _maxY = maxY;
            _myLayer = new List<TileLayer>();
            _block = new TileProperty[5];

            for (int i = 0; i < _block.Length; i++)
                _block[i] = new TileProperty(_maxX, _maxY);

            _eventManager = new EventManager[_maxX, _maxY];
            for (int x = 0; x < _eventManager.GetLength(0); x++)
            {
                for (int y = 0; y < _eventManager.GetLength(1); y++)
                {
                    _eventManager[x, y] = new EventManager();
                }
            }
        }

        public TileMap(int maxX, int maxY, string name)
        {
            _name = name;
            _maxX = maxX;
            _maxY = maxY;

            _myLayer = new List<TileLayer>();
            _block = new TileProperty[5];

            for (int i = 0; i < _block.Length; i++)
                _block[i] = new TileProperty(_maxX, _maxY);

            _eventManager = new EventManager[_maxX, _maxY];
            for (int x = 0; x < _eventManager.GetLength(0); x++)
            {
                for (int y = 0; y < _eventManager.GetLength(1); y++)
                {
                    _eventManager[x, y] = new EventManager();
                }
            }
        }

        // Property

        public int PlayerAbove
        {
            get { return _playerAbove; }
            set { _playerAbove = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<TileLayer> myLayer
        {
            get { return _myLayer; }
        }

        public int maxX
        {
            get { return _maxX; }
            set { _maxX = value; }
        }

        public int maxY
        {
            get { return _maxY; }
            set { _maxY = value; }
        }

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public TileProperty[] Block
        {
            get { return _block; }
            set { _block = value; }
        }

        public EventManager[,] EM
        {
            get { return _eventManager; }
        }

        public void mapSizeChanged()
        {
            for (int i = 0; i < _block.Length; i++)
                _block[i].ResizeMyLayer(_maxX, _maxY);

            EventManager[,] _oldEvent = (EventManager[,])_eventManager.Clone();
            _eventManager = new EventManager[_maxX, _maxY];
            int maxX = _oldEvent.GetLength(0);
            int maxY = _oldEvent.GetLength(1);

            if (maxX > _maxX)
                maxX = _maxX;
            if (maxY > _maxY)
                maxY = _maxY;

            for (int x = 0; x < maxX; x++)
                for (int y = 0; y < maxY; y++)
                    _eventManager[x, y] = _oldEvent[x, y];

        }

        public void DeleteExceed()
        {
            List<Tile> _toRemove;

            foreach (TileLayer l in _myLayer)
            {
                _toRemove = new List<Tile>();
                foreach (Tile t in l.myTile)
                {
                    if (t.plcX >= _maxX || t.plcY >= _maxY)
                        _toRemove.Add(t);
                }

                for (int i = 0; i < _toRemove.Count; i++)
                {
                    l.removeTile(_toRemove[i]);
                }
            }
        }

        public void InitEvent()
        {
            _eventManager = new EventManager[_maxX, _maxY];
            for (int x = 0; x < _eventManager.GetLength(0); x++)
            {
                for (int y = 0; y < _eventManager.GetLength(1); y++)
                {
                    _eventManager[x, y] = new EventManager();
                }
            }
        }
    }
}
