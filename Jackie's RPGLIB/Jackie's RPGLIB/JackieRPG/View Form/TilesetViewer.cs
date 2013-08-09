using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Jackie_s_RPGLIB.Database.Core;
using Jackie_s_RPGLIB.Database.Tile_Engine;
using Jackie_s_RPGLIB.Graphic;

using SFML.Graphics;
using SFML.Window;

namespace JackieRPG
{
    class TilesetViewer
    {
        Text _text;
            
        RenderWindow _tsWindow;
        Texture _tsTexture;
        Sprite _tsSprite;
        SFML.Graphics.View _tsView;
        int _xoffset, _yoffset;
        GEngine _gEngine;
        bool _grid;

        public TilesetViewer(IntPtr obj, int objw, int objh)
        {
            _xoffset = _yoffset = 0;
            _tsWindow = new RenderWindow(obj);
            _tsView = new View(new FloatRect(0, 0, objw, objh));
            _tsWindow.SetView(_tsView);
            _text = new Text();
            _text.Font = new Font(Editor.Instance.curGame.Path + @"\Graphic\Font\Georgia.ttf");
            _text.CharacterSize = 12;
            _gEngine = new GEngine();
            _grid = true;
        }

        public Texture TSTexture
        {
            get { return _tsTexture; }
        }

        public bool Grid
        {
            get { return _grid; }
            set { _grid = value; }
        }

        public int xOffSet
        {
            get { return _xoffset; }
            set { _xoffset = value; }
        }

        public int yOffSet
        {
            get { return _yoffset; }
            set { _yoffset = value; }
        }

        public void LoadTileset(Texture tx)
        {
            _tsTexture = new Texture(tx);
            _tsSprite = new Sprite(_tsTexture);
        }

        public void Render()
        {
           

            if (_tsTexture == null)
                return;

            _tsWindow.Clear();

            _tsSprite.Position = new Vector2f(0, 0);
            _tsSprite.TextureRect = new IntRect(0, 0, (int)_tsTexture.Size.X, (int)_tsTexture.Size.Y);
            _tsWindow.Draw(_tsSprite);

            int tilePerRow = (int)_tsTexture.Size.X / Editor.Instance.curGame.TileX;
            int totalRow = (int)_tsTexture.Size.Y / Editor.Instance.curGame.TileY;

            if (_grid)
            {
                for (int r = 0; r < totalRow; r++)
                {
                    for (int t = 0; t < tilePerRow; t++)
                    {
                        _gEngine.DrawBox(Editor.Instance.curGame.TileX, Editor.Instance.curGame.TileY, t * 32, r * 32, _tsWindow);
                    }
                }
            }

            _tsWindow.Display();
        }

        public void UpdateView()
        {
            _tsView.Center = new Vector2f(_xoffset + ((int)_tsView.Size.X / 2), _yoffset + ((int)_tsView.Size.Y / 2));
            _tsWindow.SetView(_tsView);
            Render();
        }

        public void ResizeView(int w, int h)
        {
            _tsView.Size = new Vector2f(w, h);
        }

        public Vector2i getMouseLoc
        {
            get { return Mouse.GetPosition(_tsWindow); }
        }

    }
}
