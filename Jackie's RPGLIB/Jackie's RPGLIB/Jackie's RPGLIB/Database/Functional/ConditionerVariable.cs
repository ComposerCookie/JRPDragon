using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Jackie_s_RPGLIB.Database.Core;

namespace Jackie_s_RPGLIB.Database.Functional
{
    public class ConditionerVariable : Conditioner
    {
        int _reqVariable;
        int _reqValue;

        public ConditionerVariable()
        {
            _reqVariable = 0;
            _reqValue = 0;
            Type = 4;
        }

        public ConditionerVariable(int var, int value)
        {
            _reqVariable = var;
            _reqValue = value;
            Type = 4;
        }

        public int ReqVariable
        {
            get { return _reqVariable; }
            set { _reqVariable = value; }
        }

        public int ReqValue
        {
            get { return _reqValue; }
            set { _reqValue = value; }
        }

        public override bool CheckRequirement()
        {
            return _reqValue == GameRunner.Instance.CurGame.ThePlayer.MyVariable[_reqVariable].Value;
        }
    }
}
