using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Jackie_s_RPGLIB.Database.Tile_Engine;

namespace JackieRPG
{
    public class LayerCache
    {
        TileLayer _tl;

        List<int[,]> _myMiniLayer;
        int[,] _myLayer;

        public LayerCache(int x, int y, TileLayer t)
        {
            _tl = t;

            _myLayer = new int[x, y];
            _myMiniLayer = new List<int[,]>();
            for (int i = 0; i < _tl.MiniLayer.Count; i++ )
            {
                int[,] l = new int[x, y];
                _myMiniLayer.Add(l);
            }
            Initialization();
        }

        public int[,] MyLayer
        {
            get { return _myLayer; }
        }

        public List<int[,]> MyMiniLayer
        {
            get { return _myMiniLayer; }
        }

        public void InitLayer()
        {
            for (int x = 0; x < _myLayer.GetLength(0); x++)
            {
                for (int y = 0; y < _myLayer.GetLength(1); y++)
                {
                    _myLayer.SetValue(-1, x, y);
                }
            }
        }

        public void InitMiniLayer()
        {
            foreach (int[,] i in _myMiniLayer)
            {
                for (int x = 0; x < i.GetLength(0); x++)
                {
                    for (int y = 0; y < i.GetLength(1); y++)
                    {
                        i.SetValue(-1, x, y);
                    }
                }
            }
        }

        public void InitMiniLayer(int loc)
        {
            for (int x = 0; x < _myMiniLayer[loc].GetLength(0); x++)
            {
                for (int y = 0; y < _myMiniLayer[loc].GetLength(1); y++)
                {
                    _myMiniLayer[loc].SetValue(-1, x, y);
                }
            }
        }

        public void InitMiniLayer(int[,] loc)
        {
            for (int x = 0; x < loc.GetLength(0); x++)
            {
                for (int y = 0; y < loc.GetLength(1); y++)
                {
                    loc.SetValue(-1, x, y);
                }
            }
        }

        public void InputDataToLayer()
        {
            for (int i = 0; i < _tl.myTile.Count; i++)
            {
                _myLayer.SetValue(i, _tl.myTile[i].plcX, _tl.myTile[i].plcY);
            }
        }

        public void InputDataToMiniLayer()
        {
            for (int l = 0; l < _tl.MiniLayer.Count; l++)
            {
                for (int i = 0; i < _tl.MiniLayer[l].myTile.Count; i++)
                {
                    _myMiniLayer[l].SetValue(i, _tl.MiniLayer[l].myTile[i].plcX, _tl.MiniLayer[l].myTile[i].plcY);
                }
            }
        }

        public void Initialization()
        {
            InitLayer();
            InitMiniLayer();

            InputDataToLayer();
            InputDataToMiniLayer();
        }

        public void CheckMissingMini()
        {
            if (_tl.MiniLayer.Count > _myMiniLayer.Count)
            {
                for (int i = 0; i < (_tl.MiniLayer.Count - _myMiniLayer.Count); i++)
                {
                    int[,] newint = new int[_myLayer.GetLength(0), _myLayer.GetLength(1)];
                    InitMiniLayer(newint);
                    _myMiniLayer.Add(newint);
                }
            }
        }
    }
}
