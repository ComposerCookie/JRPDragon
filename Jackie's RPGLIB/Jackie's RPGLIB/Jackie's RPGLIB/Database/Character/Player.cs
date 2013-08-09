using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Jackie_s_RPGLIB.Database.Core;
using Jackie_s_RPGLIB.Database.Functional;


namespace Jackie_s_RPGLIB.Database.Character
{
    public class Player
    {
        // Player-specific Map data information

        int _curMap;
        int _curX;
        int _curY;

        int _dir;
        bool _moving;
        int _frame;

        int _offsetX;
        int _offsetY;

        List<Actor> _party;
        Variable[] _myVariable;
        Switch[] _mySwitch;

        public Player()
        {
            _curMap = 0;
            _curX = 3;
            _curY = 3;

            _dir = 0;
            _frame = 0;

            _offsetX = 0;
            _offsetY = 0;

            _party = new List<Actor>();

            _myVariable = new Variable[GameRunner.Instance.CurGame.MyVariable.Count];
            _mySwitch = new Switch[GameRunner.Instance.CurGame.MySwitch.Count];

            for (int i = 0; i < _myVariable.Length; i++)
                _myVariable[i] = new Variable();
            for (int i = 0; i < _mySwitch.Length; i++)
                _mySwitch[i] = new Switch();
        }

        public int CurMap
        {
            get { return _curMap; }
            set { _curMap = value; }
        }

        public int CurX
        {
            get { return _curX; }
            set { _curX = value; }
        }

        public int CurY
        {
            get { return _curY; }
            set { _curY = value; }
        }

        public int Dir
        {
            get { return _dir; }
            set { _dir = value; }
        }

        public int OffsetX
        {
            get { return _offsetX; }
            set { _offsetX = value; }
        }

        public int OffsetY
        {
            get { return _offsetY; }
            set { _offsetY = value; }
        }

        public bool IsMoving
        {
            get { return _moving; }
            set { _moving = value; }
        }

        public int Frame
        {
            get { return _frame; }
            set { _frame = value; }
        }

        public List<Actor> Party
        {
            get { return _party; }
        }

        public Variable[] MyVariable
        {
            get { return _myVariable; }
        }

        public Switch[] MySwitch
        {
            get { return _mySwitch; }
        }

        public void setInitialParty(List<int> init)
        {
            _party = new List<Actor>();

            foreach (int i in init)
            {
                Actor newA = new Actor();
                newA = (Actor)GameRunner.Instance.CurGame.AM.MyActor[i].Clone();
                _party.Add(newA);
            }
        }

        public void Turn(int dir)
        {
            if (dir > 3)
                dir = 3;
            if (dir < 0)
                dir = 0;

            _dir = dir;
        }

        public bool canMove(int dir)
        {
            switch (dir)
            {
                case 0:
                    if (_curY + 1 >= GameRunner.Instance.CurGame.TM.myMap[_curMap].maxY || GameRunner.Instance.CurGame.TM.myMap[_curMap].Block[0].MyLayer[_curX, _curY + 1] > 0 || GameRunner.Instance.CurGame.TM.myMap[_curMap].Block[1].MyLayer[_curX, _curY] > 0)
                        return false;
                    break;
                case 1:
                    if (_curX + 1 >= GameRunner.Instance.CurGame.TM.myMap[_curMap].maxX || GameRunner.Instance.CurGame.TM.myMap[_curMap].Block[0].MyLayer[_curX + 1, _curY] > 0 || GameRunner.Instance.CurGame.TM.myMap[_curMap].Block[2].MyLayer[_curX, _curY] > 0)
                        return false;
                    break;
                case 2:
                    if (_curY - 1 < 0 || GameRunner.Instance.CurGame.TM.myMap[_curMap].Block[0].MyLayer[_curX, _curY - 1] > 0 || GameRunner.Instance.CurGame.TM.myMap[_curMap].Block[3].MyLayer[_curX, _curY] > 0)
                        return false;
                    break;
                case 3:
                    if (_curX - 1 < 0 || GameRunner.Instance.CurGame.TM.myMap[_curMap].Block[0].MyLayer[_curX - 1, _curY] > 0 || GameRunner.Instance.CurGame.TM.myMap[_curMap].Block[4].MyLayer[_curX, _curY] > 0)
                        return false;
                    break;
            }

            return true;
        }

        public void Move()
        {
            if (canMove(_dir))
                _moving = true;
        }

        public void Move(int dir)
        {
            if (_moving == true)
                return;

            Turn(dir);

            if (canMove(dir) != true)
                return;
                        
            _moving = true;
        }

        public void MoveDown()
        {
            if (_offsetY > 31)
            {
                _offsetY = 0;
                _curY++;
                _frame = 0;
                _moving = false;
                GameRunner.Instance.CurGame.PerformEvent();
            }
            else
            {
                _offsetY++;
                if (_offsetY == GameRunner.Instance.CurGame.TileY / 4)
                {
                    _frame = 1;
                }

                else if (_offsetY == GameRunner.Instance.CurGame.TileY / 4 * 2)
                {
                    _frame = 0; // 0 cuz same animation
                }

                else if (_offsetY == GameRunner.Instance.CurGame.TileY / 4 * 3)
                {
                    _frame = 2;
                }
            }
        }

        public void MoveUp()
        {
            if (_offsetY < -31)
            {
                _offsetY = 0;
                _curY--;
                _frame = 0;
                _moving = false;
                GameRunner.Instance.CurGame.PerformEvent();
            }
            else
            {
                _offsetY--;

                if ((-1) * _offsetY == GameRunner.Instance.CurGame.TileY / 4)
                {
                    _frame = 1;
                }

                else if ((-1) * _offsetY == GameRunner.Instance.CurGame.TileY / 4 * 2)
                {
                    _frame = 0; // 0 cuz same animation
                }

                else if ((-1) * _offsetY == GameRunner.Instance.CurGame.TileY / 4 * 3)
                {
                    _frame = 2;
                }
            }
        }

        public void MoveLeft()
        {
            if (_offsetX < -31)
            {
                _offsetX = 0;
                _curX--;
                _frame = 0;
                _moving = false;
                GameRunner.Instance.CurGame.PerformEvent();
            }
            else
            {
                _offsetX--;
                if ((-1) * _offsetX == GameRunner.Instance.CurGame.TileX / 4)
                {
                    _frame = 1;
                }

                else if ((-1) * _offsetX == GameRunner.Instance.CurGame.TileX / 4 * 2)
                {
                    _frame = 0; // 0 cuz same animation
                }

                else if ((-1) * _offsetX == GameRunner.Instance.CurGame.TileX / 4 * 3)
                {
                    _frame = 2;
                }
            }
        }

        public void MoveRight()
        {
            if (_offsetX > 31)
            {
                _offsetX = 0;
                _curX++;
                _frame = 0;
                _moving = false;
                GameRunner.Instance.CurGame.PerformEvent();
            }
            else
            {
                _offsetX++;
                if (_offsetX == GameRunner.Instance.CurGame.TileX / 4)
                {
                    _frame = 1;
                }

                else if (_offsetX == GameRunner.Instance.CurGame.TileX / 4 * 2)
                {
                    _frame = 0; // 0 cuz same animation
                }

                else if (_offsetX == GameRunner.Instance.CurGame.TileX / 4 * 3)
                {
                    _frame = 2;
                }
            }
        }

        public void Update()
        {
            if (_moving == true)
            {
                switch (_dir)
                {
                    case 0:
                        MoveDown();
                        break;
                    case 1:
                        MoveRight();
                        break;
                    case 2:
                        MoveUp();
                        break;
                    case 3:
                        MoveLeft();
                        break;

                }
            }
        }
    }
}
