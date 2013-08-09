using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Jackie_s_RPGLIB.Database.Core;
using Jackie_s_RPGLIB.Database.Tile_Engine;
using Jackie_s_RPGLIB.Graphic;

using SFML.Graphics;
using SFML.Window;

namespace JackieRPG
{
    class MapViewer
    {
        TileMap _map;
        RenderWindow _mapWindow;
        int _xoffset, _yoffset;
        SFML.Graphics.View _mapView;
        bool _grid;
        bool _block;

        bool _showGround;
        bool _showFringe;

        GEngine _gEngine;

        Texture[] tx;
        Sprite sp;

        public MapViewer(IntPtr obj, int objw, int objh)
        {
            _xoffset = _yoffset = 0;
            _mapWindow = new RenderWindow(obj);
            _mapWindow.SetFramerateLimit(60);
            _mapView = new View(new FloatRect(0, 0, objw, objh));
            _mapWindow.SetView(_mapView);
            _grid = true;
            _block = true;

            _showGround = true;
            _showFringe = true;

            _gEngine = new GEngine();

            LoadedNewTS();
        }

        public bool Grid
        {
            get { return _grid; }
            set { _grid = value; }
        }

        public bool ShowGround
        {
            get { return _showGround; }
            set { _showGround = value; }
        }

        public bool ShowFringe
        {
            get { return _showFringe; }
            set { _showFringe = value; }
        }

        public bool Block
        {
            get { return _block; }
            set { _block = value; }
        }

        public int xOffSet
        {
            get { return _xoffset; }
            set { _xoffset = value; }
        }

        public int yOffSet
        {
            get { return _yoffset; }
            set { _yoffset = value; }
        }

        public void changeMap(TileMap newMap)
        {
            //_map = new TileMap();
            _map = newMap;
        }

        public void LoadedNewTS()
        {
            tx = new Texture[Editor.Instance.curGame.TM.myTileset.Count];
            for (int i = 0; i < tx.Length; i++)
            {
                tx[i] = new Texture(Editor.Instance.curGame.GM.myResource[Editor.Instance.curGame.TM.myTileset[i].ID].myTexture);
            }
        }

        public void UpdateView()
        {
            _mapView.Center = new Vector2f(_xoffset + ((int)_mapView.Size.X / 2), _yoffset + ((int)_mapView.Size.Y / 2));
            _mapWindow.SetView(_mapView);
        }

        public void ResizeView(int w, int h)
        {
            _mapView.Size = new Vector2f(w, h);
        }

        public void NextAnimatedLayer(TileLayer tl)
        {
            if (tl.LastAnimated == tl.MiniLayer.Count - 1)
                tl.LastAnimated = -1;

            for (int i = 0; i < tl.MiniLayer.Count; i++ )
            {
                if (i > tl.LastAnimated)
                {
                    tl.LastAnimated = i;
                    return;
                }
            }
        }

        public void RenderGround()
        {
            int max = _map.PlayerAbove;
            if (max > _map.myLayer.Count)
                max = _map.myLayer.Count;

            for (int i = 0; i < max; i++)
            {
                NextAnimatedLayer(_map.myLayer[i]);
            }

            List<TileLayer> _toDraw = new List<TileLayer>();

            for (int i = 0; i < max; i++)
            {
                if (_map.myLayer[i].Visible == false)
                {
                    continue;
                }

                _toDraw.Add(_map.myLayer[i]);

                for (int l = 0; l < _map.myLayer[i].MiniLayer.Count; l++)
                {
                    if (l == _map.myLayer[i].LastAnimated)
                        _toDraw.Add(_map.myLayer[i].MiniLayer[l]);
                }
            }

            foreach (TileLayer tl in _toDraw)
            {
                foreach (Tile t in tl.myTile)
                {
                    sp = new Sprite(tx[t.TS], new IntRect(t.srcX * Editor.Instance.curGame.TileX, t.srcY * Editor.Instance.curGame.TileY, t.Width, t.Height));
                    sp.Position = new Vector2f(t.plcX * Editor.Instance.curGame.TileX, t.plcY * Editor.Instance.curGame.TileY);
                    _mapWindow.Draw(sp);

                }

            }
        }

        public void RenderFringe()
        {
            int max = _map.PlayerAbove;
            if (max >= _map.myLayer.Count)
                return;

            for (int i = max; i < _map.myLayer.Count; i++)
            {
                NextAnimatedLayer(_map.myLayer[i]);
            }

            List<TileLayer> _toDraw = new List<TileLayer>();

            for (int i = max; i < _map.myLayer.Count; i++)
            {
                if (_map.myLayer[i].Visible == false)
                {
                    continue;
                }

                _toDraw.Add(_map.myLayer[i]);

                for (int l = 0; l < _map.myLayer[i].MiniLayer.Count; l++)
                {
                    if (l == _map.myLayer[i].LastAnimated)
                        _toDraw.Add(_map.myLayer[i].MiniLayer[l]);
                }
            }

            foreach (TileLayer tl in _toDraw)
            {
                foreach (Tile t in tl.myTile)
                {
                    sp = new Sprite(tx[t.TS], new IntRect(t.srcX * Editor.Instance.curGame.TileX, t.srcY * Editor.Instance.curGame.TileY, t.Width, t.Height));
                    sp.Position = new Vector2f(t.plcX * Editor.Instance.curGame.TileX, t.plcY * Editor.Instance.curGame.TileY);
                    _mapWindow.Draw(sp);

                }

            }
        }

        public void Render()
        {
            _mapWindow.Clear();

            if (_showGround == true)
                RenderGround();

            if (_showFringe == true)
                RenderFringe();

            if (_grid)
            {

                for (int r = 0; r < _map.maxY; r++)
                {
                    for (int t = 0; t < _map.maxX; t++)
                    {
                        _gEngine.DrawBox(Editor.Instance.curGame.TileX, Editor.Instance.curGame.TileY, t * 32, r * 32, _mapWindow);
                    }
                }
            }

            if (_block)
            {
                for (int x = 0; x < _map.maxX; x++)
                {
                    for (int y = 0; y < _map.maxY; y++)
                    {
                        _gEngine.DrawBlock(Editor.Instance.Block, Editor.Instance.curGame.TileX, Editor.Instance.curGame.TileY, _mapWindow, _map.Block, x, y);
            
                    }
                }
            }
            _mapWindow.Display();
        }

        public void changeTile()
        {

        }

        public Vector2i getMouseLoc
        {
            get { return Mouse.GetPosition(_mapWindow); }
        }
    }
}
