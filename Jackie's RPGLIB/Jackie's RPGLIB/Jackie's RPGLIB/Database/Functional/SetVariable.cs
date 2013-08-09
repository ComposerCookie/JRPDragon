using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Jackie_s_RPGLIB.Database.Functional;
using Jackie_s_RPGLIB.Database.Core;

namespace Jackie_s_RPGLIB.Database.Functional
{
    public class SetVariable : Event
    {
        int _variable;
        int _value;
        int _changeType;

        public SetVariable()
        {
            _variable = 0;
            _value = 0;
            Type = 7;
            _changeType = 0;
        }

        public SetVariable(int var, int value)
        {
            _variable = var;
            _value = value;
            Type = 7;
            _changeType = 0;
        }

        public int Variable
        {
            get { return _variable; }
            set { _variable = value; }
        }

        public int Value
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
            switch (_changeType)
            {
                case 0:
                    GameRunner.Instance.CurGame.ThePlayer.MyVariable[_variable].Value = _value;
                    break;
                case 1:
                    GameRunner.Instance.CurGame.ThePlayer.MyVariable[_variable].Value += _value;
                    break;
                case 2:
                    GameRunner.Instance.CurGame.ThePlayer.MyVariable[_variable].Value -= _value;
                    break;
                case 3:
                    GameRunner.Instance.CurGame.ThePlayer.MyVariable[_variable].Value *= _value;
                    break;
                case 4:
                    if (_value == 0)
                        return;
                    GameRunner.Instance.CurGame.ThePlayer.MyVariable[_variable].Value /= _value;
                    break;
                case 5:
                    if (_value == 0)
                        return;
                    GameRunner.Instance.CurGame.ThePlayer.MyVariable[_variable].Value %= _value;
                    break;
            }
        }
    }
}
