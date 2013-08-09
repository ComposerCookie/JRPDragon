using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Jackie_s_RPGLIB.Database.Character;
using Jackie_s_RPGLIB.Database.Core;

namespace Jackie_s_RPGLIB.Database.Functional.Map
{
    public class ConditionerLoc : Conditioner
    {
        int _reqMap;
        int _reqX;
        int _reqY;

        public ConditionerLoc()
        {
            _reqMap = 0;
            _reqX = 0;
            _reqY = 0;
            Type = 3;
        }

        public ConditionerLoc(int map, int x, int y)
        {
            _reqMap = map;
            _reqX = x;
            _reqY = y;
            Type = 3;
        }

        public int ReqMap
        {
            get { return _reqMap; }
            set { _reqMap = value; }
        }

        public int ReqX
        {
            get { return _reqX; }
            set { _reqX = value; }
        }

        public int ReqY
        {
            get { return _reqY; }
            set { _reqY = value; }
        }

        public override bool CheckRequirement()
        {
            if (GameRunner.Instance.CurGame.ThePlayer.CurMap != ReqMap)
                return false;

            if (GameRunner.Instance.CurGame.ThePlayer.CurX != ReqX)
                return false;

            if (GameRunner.Instance.CurGame.ThePlayer.CurY != ReqY)
                return false;

            return true;
        }

    }
}
