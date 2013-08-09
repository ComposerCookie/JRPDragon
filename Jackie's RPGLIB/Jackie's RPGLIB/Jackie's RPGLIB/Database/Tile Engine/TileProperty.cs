using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jackie_s_RPGLIB.Database.Tile_Engine
{
    public class TileProperty
    {
        byte[,] myLayer;

        public TileProperty(int x, int y)
        {
            myLayer = new byte[x, y];

            for (int _x = 0; _x < myLayer.GetLength(0); _x++)
            {
                for (int _y = 0; _y < myLayer.GetLength(1); _y++)
                {
                    myLayer[_x, _y] = 0;
                }
            }
        }

        public byte[,] MyLayer
        {
            get { return myLayer; }
            set { myLayer = value; }
        }

        public void ResizeMyLayer(int x, int y)
        {
            byte[,] temp = (byte[,])myLayer.Clone();
            myLayer = new byte[x, y];

            int maxX = temp.GetLength(0);
            int maxY = temp.GetLength(1);
            if (maxX > myLayer.GetLength(0))
                maxX = myLayer.GetLength(0);
            if (maxY > myLayer.GetLength(1))
                maxY = myLayer.GetLength(1);

            for (int _x = 0; _x < myLayer.GetLength(0); _x++)
            {
                for (int _y = 0; _y < myLayer.GetLength(1); _y++)
                {
                    myLayer[_x, _y] = 0;
                }
            }

            for (int _x = 0; _x < maxX; _x++)
            {
                for (int _y = 0; _y < maxY; _y++)
                {
                    myLayer[_x, _y] = (byte)temp.GetValue(_x, _y);
                }
            }
        }
    }
}
