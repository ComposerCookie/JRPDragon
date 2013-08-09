using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jackie_s_RPGLIB.Database.Tile_Engine
{
    public class Tile
    {
        // Field

        int _srcX, _srcY, _plcX, _plcY, _ts, _height, _width, _opacity;

        // Constructor

        public Tile()
        {
            _srcX = _srcY = _plcX = _plcY = _ts = _height = _width = _opacity = 0;
        }

        public Tile(int srcx, int srcy, int plcx, int plcy, int ts, int height, int width, int opacity)
        {
            _srcX = srcx;
            _srcY = srcy;
            _plcX = plcx;
            _plcY = plcy;
            _ts = ts;
            _height = height;
            _width = width;
            _opacity = opacity;
        }

        // Property

        public int srcX
        {
            get { return _srcX; }
            set { _srcX = value; }
        }

        public int srcY
        {
            get { return _srcY; }
            set { _srcY = value; }
        }

        public int plcX
        {
            get { return _plcX; }
            set { _plcX = value; }
        }

        public int plcY
        {
            get { return _plcY; }
            set { _plcY = value; }
        }

        public int TS
        {
            get { return _ts; }
            set { _ts = value; }
        }

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public int Opacity
        {
            get { return _opacity; }
            set { _opacity = value; }
        }
    }
}
