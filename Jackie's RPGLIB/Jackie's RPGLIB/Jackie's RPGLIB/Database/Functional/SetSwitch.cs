using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Jackie_s_RPGLIB.Database.Core;

namespace Jackie_s_RPGLIB.Database.Functional
{
    public class SetSwitch : Event
    {
        int _switch;
        bool _value;
        int _changeType;
        

        public SetSwitch()
        {
            _switch = 0;
            _value = false;
            Type = 6;
            _changeType = 0;
        }

        public SetSwitch(int swi, bool value)
        {
            _switch = swi;
            _value = value;
            Type = 6;
            _changeType = 0;
        }

        public int Switch
        {
            get { return _switch; }
            set { _switch = value; }
        }

        public bool Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public int ChangeType
        {
            get { return _changeType; }
            set { _changeType = value; }
        }

        public override void PerformFunction()
        {
            if (_changeType < 2)
            GameRunner.Instance.CurGame.ThePlayer.MySwitch[_switch].Value = _value;
            else if (_changeType == 2)
            {
                GameRunner.Instance.CurGame.ThePlayer.MySwitch[_switch].Value = !GameRunner.Instance.CurGame.ThePlayer.MySwitch[_switch].Value;
            }
        }
    }
}
