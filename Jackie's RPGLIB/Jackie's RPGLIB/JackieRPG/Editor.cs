using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Jackie_s_RPGLIB.Database.Core;
using Jackie_s_RPGLIB.Database.Tile_Engine;
using Jackie_s_RPGLIB.Graphic;

using SFML.Graphics;
using SFML.Window;

using WeifenLuo.WinFormsUI.Docking;

namespace JackieRPG
{
    public partial class Editor : Form
    {

        SFML.Graphics.Font _globalFont;
        static Editor _instance;
        bool _changeMade;
        Game _curGame;
        GraphicDatabase _graphicDatabase;
        NewGame _newGame;
        IO _IO;
        TilesetPick _tilesetPick;
        ProjectDirectory _projectDirectory;
        NewMap _newMap;
        List<MapViewerForm> _mapViewFormList;
        GameRunner _gameRunner;
        ActorManagerForm _actorManager;
        Texture _block;
        ViewVariable _viewVariable;
        ViewSwitch _viewSwitch;


        public Editor()
        {
            InitializeComponent();

            _instance = this;

            _changeMade = false;

            _curGame = new Game();

            _newGame = new NewGame();

            _IO = new IO();

            _newMap = new NewMap();

            _globalFont = new SFML.Graphics.Font("Georgia.ttf");

            _block = new Texture("block.png");

            _projectDirectory = new ProjectDirectory();

            _mapViewFormList = new List<MapViewerForm>();

            _actorManager = new ActorManagerForm();

            _gameRunner = new GameRunner(_curGame);

            _viewSwitch = new ViewSwitch();

            _viewVariable = new ViewVariable();

            DisableTool();
            
        }

        public TilesetPick tilesetPick
        {
            get { return _tilesetPick; }
        }

        public SFML.Graphics.Font GlobalFont
        {
            get { return _globalFont; }
        }

        public static Editor Instance
        {
            get { return _instance; }
        }

        public GraphicDatabase graphicDatabase
        {
            get { return _graphicDatabase; }
        }

        public ActorManagerForm actorManagerForm
        {
            get { return _actorManager; }
        }

        public ViewVariable viewVariable
        {
            get { return _viewVariable; }
        }

        public ViewSwitch viewSwitch
        {
            get { return _viewSwitch; }
        }

        public Texture Block
        {
            get { return _block; }
        }

        public bool ChangeMade
        {
            get { return _changeMade; }
            set { _changeMade = value; }
        }

        public Game curGame
        {
            get { return _curGame; }
        }

        public IO myIO
        {
            get { return _IO; }
        }

        public void LoadAllTexture()
        {
            for (int i = 0; i < curGame.GM.myResource.Count; i++)
            {
                curGame.GM.myResource[i].loadTexture();
            }
        }

        public void AddMapViewer(MapViewerForm mv)
        {
            foreach (MapViewerForm m in _mapViewFormList)
            {
                if (m.myMap == mv.myMap)
                    return;
            }

            _mapViewFormList.Add(mv);
            mv.Show(dockPanel1, DockState.Document);
        }

        public void DatabaseUpdate()
        {
            LoadAllTexture();
            _projectDirectory.RefreshTreeView();
            foreach (MapViewerForm mv in _mapViewFormList)
            {
                mv.RefreshDatabase();
                mv.SetScrollSize();
            }
        }

        public void CloseMV(TileMap map)
        {
            List<MapViewerForm> _toRemove = new List<MapViewerForm>();

            for (int i = 0; i < _mapViewFormList.Count; i++)
            {
                if (_mapViewFormList[i].myMap == map)
                {
                    _toRemove.Add(_mapViewFormList[i]);
                    _mapViewFormList[i].Close();
                }
            }

            for (int i = 0; i < _toRemove.Count; i++)
            {
                _mapViewFormList.Remove(_toRemove[i]);
            }
        }

        public void EnableTool()
        {
            graphicToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
            newToolStripMenuItem1.Enabled = true;
            actorToolStripMenuItem.Enabled = true;
            debugToolStripMenuItem.Enabled = true;

            _graphicDatabase = new GraphicDatabase();

            _projectDirectory = new ProjectDirectory();
            _projectDirectory.Show(dockPanel1, DockState.DockRight);

            _tilesetPick = new TilesetPick();
            _tilesetPick.Show(dockPanel1, DockState.DockLeft);
            _tilesetPick.RefreshDatabase();
        }

        public void DisableTool()
        {
            graphicToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
            newToolStripMenuItem1.Enabled = false;
            actorToolStripMenuItem.Enabled = false;
            debugToolStripMenuItem.Enabled = false;

            if (_tilesetPick == null)
                return;
            _tilesetPick.Visible = false;
            if (_projectDirectory == null)
                return;
            _projectDirectory.Visible = false;
        }

        public void NewProject(Game obj)
        {
            CloseProject();
            _curGame = obj;

            Directory.CreateDirectory(_curGame.Path);
            Directory.CreateDirectory(_curGame.Path + @"\Graphic");
            Directory.CreateDirectory(_curGame.Path + @"\Graphic\Tileset");
            Directory.CreateDirectory(_curGame.Path + @"\Graphic\Sprite");
            Directory.CreateDirectory(_curGame.Path + @"\Graphic\Font");

            System.IO.File.Copy(Directory.GetCurrentDirectory() + @"\Georgia.ttf", _curGame.Path + @"\Graphic\Font\Georgia.ttf", true);

            LoadAllTexture();

            SaveProject();
            UpdateTitle();

            EnableTool();
        }

        public void CloseProject()
        {
            if (_changeMade == true)
            {
                DialogResult dialogResult = MessageBox.Show("You have made unsaved change to the project, do you want to save?", "Unsaved Data", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    SaveProject();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            _curGame = new Game();
            DisableTool();
        }

        public void OpenProject()
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = @"Select game file";
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Jackie's RPG Maker\Project\";

                var result = dialog.ShowDialog(this);

                if (result != DialogResult.OK) return;

                var path = Path.GetDirectoryName(dialog.FileName);

                if (path.Equals(curGame.Path))
                {
                    MessageBox.Show(@"This game is already open.", @"Error opening game");
                    return;
                }

                if (!File.Exists(path + @"\Game.jrpg"))
                {
                    MessageBox.Show(@"Cannot find game file.", @"Error opening game");
                    return;
                }

                CloseProject();

                LoadProject(path + @"\Game.jrpg");

                if (!Directory.Exists(path + @"\Graphic"))
                    Directory.CreateDirectory(path + @"\Graphic");
                if (!Directory.Exists(path + @"\Graphic\Tileset"))
                    Directory.CreateDirectory(path + @"\Graphic\Tileset");
                if (!Directory.Exists(path + @"\Graphic\Sprite"))
                    Directory.CreateDirectory(path + @"\Graphic\Sprite");
                if (!Directory.Exists(path + @"\Graphic\Font"))
                    Directory.CreateDirectory(path + @"\Graphic\Font");
                if (!File.Exists(path + @"\Graphic\Font\Georgia.ttf"))
                    System.IO.File.Copy(Directory.GetCurrentDirectory() + @"\Georgia.ttf", _curGame.Path + @"\Graphic\Font\Georgia.ttf", true);


                LoadAllTexture();

                UpdateTitle();
                EnableTool();

            }
        }

        public void SaveProject()
        {
            _IO.SaveProject(_curGame);
            _changeMade = false;
        }

        public void LoadProject(string path)
        {
            _IO.LoadProject(path, _curGame);
        }

        private void graphicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _graphicDatabase = new GraphicDatabase();
            _graphicDatabase.Show();
        }

        public void UpdateTitle()
        {
            if (ChangeMade == true)
                this.Text = "*Jackie's RPG Maker: " + curGame.Name + ": " + curGame.SubName;
            else
                this.Text = "Jackie's RPG Maker: " + curGame.Name + ": " + curGame.SubName;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _newGame = new NewGame();
            _newGame.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenProject();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveProject();
            ChangeMade = false;
            UpdateTitle();
        }

        private void Editor_Load(object sender, EventArgs e)
        {

        }

        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseProject();
        }

        private void mapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _newMap = new NewMap();
            _newMap.ShowDialog();
        }

        private void tilesetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTileset nt = new NewTileset();
            nt.ShowDialog();
        }

        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _gameRunner = new GameRunner(_curGame);
            _gameRunner.Run();
        }

        private void actorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _actorManager = new ActorManagerForm();
            _actorManager.Show();
            
        }

        private void switchStripMenuItem_Click(object sender, EventArgs e)
        {
            _viewSwitch = new ViewSwitch();
            _viewSwitch.Show();
        }

        private void variableStripSeparator_Click(object sender, EventArgs e)
        {
            _viewVariable = new ViewVariable();
            _viewVariable.Show();
        }
    }
}
