using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Jackie_s_RPGLIB.Graphic;
using Jackie_s_RPGLIB.Input;

using SFML.Window;
using SFML.Graphics;

namespace Jackie_s_RPGLIB.Database.Core
{
    public class GameRunner 
    {
        #region Field

        static GameRunner _instance;
        Game _curGame; // The game that will be run
        

        #endregion Field

        #region Constructor

        public GameRunner()
        {
            _instance = this;
            _curGame = null;

        }

        public GameRunner(Game game)
        {
            _instance = this;
            _curGame = game;
            
            //Initalization();
            //Run();
        }

        #endregion Constructor

        #region Property

        public static GameRunner Instance
        {
            get { return _instance; }
        }

        public Game CurGame
        {
            get { return _curGame; }
        }

        #endregion Property

        #region Method

        public void Initialization()
        {
            _curGame.GE = new GEngine(_curGame.ScreenWidth, _curGame.ScreenHeight, _curGame.Name + ": " + _curGame.SubName);
            _curGame.Init();
        }

        public void Run() // Start the goddamn game
        {
            Initialization();
            _curGame.GE.GameScreen.Closed += new EventHandler(OnClose);
            _curGame.GE.GameScreen.KeyPressed += new EventHandler<KeyEventArgs>(OnKeyPressed);
            _curGame.GE.GameScreen.SetFramerateLimit(30);

            while (_curGame.GE.GameScreen.IsOpen())
            {

                _curGame.GE.GameScreen.DispatchEvents();

                _curGame.ThePlayer.Update();
                _curGame.GE.Update();
            }
        }

        static void OnClose(object sender, EventArgs e)
        {
            // Close the window when OnClose event is received
            RenderWindow window = (RenderWindow)sender;
            window.Close();
        }

        static void OnKeyPressed(object sender, KeyEventArgs e)
        {
            RenderWindow window = (RenderWindow)sender;
            if (e.Code == GameRunner.Instance.CurGame.KI.MoveDown)
                GameRunner.Instance.CurGame.ThePlayer.Move(KeyboardInput.DirDown);

            if (e.Code == GameRunner.Instance.CurGame.KI.MoveUp)
                GameRunner.Instance.CurGame.ThePlayer.Move(KeyboardInput.DirUp);

            if (e.Code == GameRunner.Instance.CurGame.KI.MoveLeft)
                GameRunner.Instance.CurGame.ThePlayer.Move(KeyboardInput.DirLeft);

            if (e.Code == GameRunner.Instance.CurGame.KI.MoveRight)
                GameRunner.Instance.CurGame.ThePlayer.Move(KeyboardInput.DirRight);
        }

        void CallEventHandler(Event e)
        {
            switch (e.Type)
            {
                case EventType.Closed:
                    _curGame.GE.GameScreen.Close();
                    break;

                case EventType.KeyPressed:
                    //_curGame.GE.GameScreen.KeyPressed();
                    break;

            }
        }

        #endregion Method
    }
}
