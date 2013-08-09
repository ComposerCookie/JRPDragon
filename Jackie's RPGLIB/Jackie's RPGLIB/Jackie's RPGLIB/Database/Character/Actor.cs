using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Jackie_s_RPGLIB.Database.Core;

namespace Jackie_s_RPGLIB.Database.Character
{
    public class Actor : ICloneable
    {
        // Basic Character Information

        string _name; 
        string _description;
        int _gender;
        int _job;
        int _face;
        int _sprite;
        
        // Leveling and such
        int _level;
        int _exp;
        int _joblevel;
        int _jobexp;

        // Attribute
        int[] _stats;
        int _statspt;

        public Actor()
        {
            _name = "";
            _description = "";
            _gender = 0;
            _job = 0;
            _level = 1;
            _exp = 0;
            _joblevel = 1;
            _jobexp = 0;
            _statspt = 0;
            _stats = new int[GameRunner.Instance.CurGame.MaxStats];
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public int Job
        {
            get { return _job; }
            set { _job = value; }
        }

        public int Face
        {
            get { return _face; }
            set { _face = value; }
        }

        public int Sprite
        {
            get { return _sprite; }
            set { _sprite = value; }
        }

        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public int JobLevel
        {
            get { return _joblevel; }
            set { _joblevel = value; }
        }

        public int EXP
        {
            get { return _exp; }
            set { _exp = value; }
        }

        public int JobEXP
        {
            get { return _jobexp; }
            set { _jobexp = value; }
        }

        public int[] Stat
        {
            get { return _stats; }
            set { _stats = value; }
        }

        public int StatPoints
        {
            get { return _statspt; }
            set { _statspt = value; }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
