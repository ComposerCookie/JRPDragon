using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Jackie_s_RPGLIB.Database.Core;

namespace Jackie_s_RPGLIB.Database.Functional.Map
{
    public class Warp : Event
    {

        int _warpX;
        int _warpY;
        int _warpMap;

        public Warp()
        {
            _warpMap = 0;
            _warpX = 0;
            _warpY = 0;

            Type = 2;
        }

        public Warp(int wm, int wx, int wy)
        {
            _warpMap = wm;
            _warpX = wx;
            _warpY = wy;

            Type = 2;
        }

        public int WarpX
        {
            get { return _warpX; }
            set { _warpX = value; }
        }

        public int WarpY
        {
            get { return _warpY; }
            set { _warpY = value; }
        }

        public int WarpMap
        {
            get { return _warpMap; }
            set { _warpMap = value; }
        }

        public override void PerformFunction()
        {
                GameRunner.Instance.CurGame.ThePlayer.CurX = _warpX;
                GameRunner.Instance.CurGame.ThePlayer.CurY = _warpY;
                GameRunner.Instance.CurGame.ThePlayer.CurMap = _warpMap;
        }

    }
}
