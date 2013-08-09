using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Jackie_s_RPGLIB.Database.Tile_Engine;
using Jackie_s_RPGLIB.Graphic;
using Jackie_s_RPGLIB.Database.Character;
using Jackie_s_RPGLIB.Input;

using Jackie_s_RPGLIB.Database.Functional;

namespace Jackie_s_RPGLIB.Database.Core
{ 
    public class Game
    {
        #region Field

        // Project related stuff

        TileManager tm; // Contain information of tilesets and maps; does NOT contain graphic information except the location of the image in the Graphic Manager
        GManager gm; // Contain the ACTUAL images
        GEngine ge; // The main renderer of the game. If you need to draw something or make drawing function, fix this plz
        ActorManager am; //Manage the core actor data.
        KeyboardInput ki;
        IO io;
        string _name; // Name of the game obviously
        string _path; // Path of the game obviously
        string _author; //Who wrote the game?
        string _description; //The description?
        string _subName; // the sub name of the game, u know, like - My Little Kingdom: Jack's Story

        int _screenWidth;
        int _screenHeight;

        int _tileX; // Individual tile size
        int _tileY;

        int _startMap;
        int _startX;
        int _startY;

        int _maxStats;

        List<int> _intialParty;
        List<Variable> _myVariable;
        List<Switch> _mySwitch;

        // Actual Gaming Information goes here

        Player _player;
        

        #endregion Field

        #region Constructor

        public Game()
        {

            tm = new TileManager();
            gm = new GManager();
            ge = new GEngine();
            am = new ActorManager();
            ki = new KeyboardInput();

            _screenWidth = 600;
            _screenHeight = 480;

            _name = "";
            _path = "";

            _author = "";
            _description = "";
            _subName = "";

            _startMap = 0;
            _startX = 0;
            _startY = 0;

            _maxStats = 6;

            _intialParty = new List<int>();
            _intialParty.Add(0);

            _mySwitch = new List<Switch>();
            _myVariable = new List<Variable>();

        }

        #endregion Constructor

        #region Property

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string SubName
        {
            get { return _subName; }
            set { _subName = value; }
        }

        public int ScreenWidth
        {
            get { return _screenWidth; }
            set { _screenWidth = value; }
        }

        public int ScreenHeight
        {
            get { return _screenHeight; }
            set { _screenHeight = value; }
        }

        public int TileX
        {
            get { return _tileX; }
            set { _tileX = value; }
        }

        public int TileY
        {
            get { return _tileY; }
            set { _tileY = value; }
        }

        public int StartMap
        {
            get { return _startMap; }
            set { _startMap = value; }
        }

        public int StartX
        {
            get { return _startX; }
            set { _startX = value; }
        }

        public int StartY
        {
            get { return _startY; }
            set { _startY = value; }
        }

        public int MaxStats
        {
            get { return _maxStats; }
            set { _maxStats = value; }
        }

        public TileManager TM
        {
            get { return tm; }
        }

        public GManager GM
        {
            get { return gm; }
        }

        public GEngine GE
        {
            get { return ge; }
            set { ge = value; }
        }

        public ActorManager AM
        {
            get { return am; }
            set { am = value; }
        }

        public KeyboardInput KI
        {
            get { return ki; }
        }
        public IO IO
        {
            get { return io; }
        }

        public Player ThePlayer
        {
            get { return _player; }
        }

        public List<int> InitialParty
        {
            get { return _intialParty; }
        }

        public List<Variable> MyVariable
        {
            get { return _myVariable; }
        }

        public List<Switch> MySwitch
        {
            get { return _mySwitch; }
        }

        #endregion Property

        #region Method

        public void Init()
        {
            _player = new Player();

            if (AM.MyActor.Count > 0)
                _player.setInitialParty(_intialParty);
        }

        public void PerformEvent()
        {
            foreach (Event e in TM.myMap[_player.CurMap].EM[_player.CurX, _player.CurY].MyEvent)
                e.PerformFunction();
        }
        #endregion
    }
}
