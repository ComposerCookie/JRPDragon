using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SFML.Window;

namespace Jackie_s_RPGLIB.Input
{
    public class KeyboardInput
    {
        Keyboard.Key _moveUp;
        Keyboard.Key _moveDown;
        Keyboard.Key _moveLeft;
        Keyboard.Key _moveRight;

        Keyboard.Key _action;
        Keyboard.Key _cancel;

        static int _dirUp;
        static int _dirDown;
        static int _dirLeft;
        static int _dirRight;

        public KeyboardInput()
        {
            _moveUp = Keyboard.Key.Up;
            _moveDown = Keyboard.Key.Down;
            _moveLeft = Keyboard.Key.Left;
            _moveRight = Keyboard.Key.Right;

            _action = Keyboard.Key.Z;
            _cancel = Keyboard.Key.X;

            _dirUp = 2;
            _dirDown = 0;
            _dirLeft = 3;
            _dirRight = 1;
        }

        public Keyboard.Key MoveUp
        {
            get { return _moveUp; }
            set { _moveUp = value; }
        }

        public Keyboard.Key MoveDown
        {
            get { return _moveDown; }
            set { _moveDown = value; }
        }

        public Keyboard.Key MoveLeft
        {
            get { return _moveLeft; }
            set { _moveLeft = value; }
        }

        public Keyboard.Key MoveRight
        {
            get { return _moveRight; }
            set { _moveRight = value; }
        }

        public Keyboard.Key Action
        {
            get { return _action; }
            set { _action = value; }
        }

        public Keyboard.Key Cancel
        {
            get { return _cancel; }
            set { _cancel = value; }
        }

        public static int DirUp
        {
            get { return _dirUp; }
        }

        public static int DirDown
        {
            get { return _dirDown; }
        }

        public static int DirLeft
        {
            get { return _dirLeft; }
        }

        public static int DirRight
        {
            get { return _dirRight; }
        }
    }
}
