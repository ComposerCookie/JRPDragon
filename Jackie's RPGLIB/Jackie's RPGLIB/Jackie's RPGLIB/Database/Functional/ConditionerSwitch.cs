using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Jackie_s_RPGLIB.Database.Core;

namespace Jackie_s_RPGLIB.Database.Functional
{
    public class ConditionerSwitch : Conditioner
    {
        int _reqSwitch;
        bool _reqValue;

        public ConditionerSwitch()
        {
            _reqSwitch = 0;
            _reqValue = false;
            Type = 5;
        }

        public ConditionerSwitch(int swi, int value)
        {
            _reqSwitch = swi;
            _reqValue = false;
            Type = 5;
        }

        public int ReqSwitch
        {
            get { return _reqSwitch; }
            set { _reqSwitch = value; }
        }

        public bool ReqValue
        {
            get { return _reqValue; }
            set { _reqValue = value; }
        }

        public override bool CheckRequirement()
        {
            return _reqValue == GameRunner.Instance.CurGame.ThePlayer.MySwitch[_reqSwitch].Value;
        }
    }
}
