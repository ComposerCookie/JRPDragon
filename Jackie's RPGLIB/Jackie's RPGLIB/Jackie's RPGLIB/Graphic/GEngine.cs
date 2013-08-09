using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SFML.Graphics;
using SFML.Window;

using Jackie_s_RPGLIB.Database.Core;
using Jackie_s_RPGLIB.Database.Tile_Engine;

namespace Jackie_s_RPGLIB.Graphic
{
    public class GEngine
    {
        RenderWindow _screen;
        View _view;
        int _lastAnimatedLayer;
        Sprite _tileSprite;

        public GEngine()
        {
            
        }

        public GEngine(int width, int height, string name)
        {
            _screen = new RenderWindow(new VideoMode((uint)width, (uint)height),name);
            _view = new View(new FloatRect(0,0,width, height));
            _screen.SetView(_view);
        }

        public RenderWindow GameScreen
        {
            get { return _screen; }
        }

        public void NextAnimatedLayer(TileLayer tl)
        {
            if (tl.LastAnimated == tl.MiniLayer.Count - 1)
                tl.LastAnimated = -1;

            for (int i = 0; i < tl.MiniLayer.Count; i++)
            {
                if (i > tl.LastAnimated)
                {
                    tl.LastAnimated = i;
                    return;
                }
            }
        }

        public void UpdateView()
        {
            _view.Center = new Vector2f(GameRunner.Instance.CurGame.ThePlayer.CurX * 32 + GameRunner.Instance.CurGame.ThePlayer.OffsetX, GameRunner.Instance.CurGame.ThePlayer.CurY * 32 + GameRunner.Instance.CurGame.ThePlayer.OffsetY);
            _screen.SetView(_view);
        }

        public void UpdateScreen()
        {
        }

        public void DrawPlayer()
        {
            if (GameRunner.Instance.CurGame.ThePlayer.Party.Count == 0)
                return;

            UpdateView();

            if (GameRunner.Instance.CurGame.ThePlayer.Party[0].Sprite < 0)
                return;

            Sprite sp = new Sprite(GameRunner.Instance.CurGame.GM.myResource[GameRunner.Instance.CurGame.AM.MySprite[GameRunner.Instance.CurGame.ThePlayer.Party[0].Sprite].ID].myTexture);

            if (GameRunner.Instance.CurGame.ThePlayer.IsMoving == true)
            {
                ClipPlayer(sp, GameRunner.Instance.CurGame.ThePlayer.Frame);
            }
            else
            {
                ClipPlayer(sp);
            }

            sp.Position = new Vector2f(GameRunner.Instance.CurGame.ThePlayer.CurX * GameRunner.Instance.CurGame.TileX + GameRunner.Instance.CurGame.ThePlayer.OffsetX, GameRunner.Instance.CurGame.ThePlayer.CurY * GameRunner.Instance.CurGame.TileY + GameRunner.Instance.CurGame.ThePlayer.OffsetY);
            _screen.Draw(sp);
        }

        public void ClipPlayer(Sprite _sp)
        {
            switch (GameRunner.Instance.CurGame.ThePlayer.Dir)
            {
                case 0:
                    _sp.TextureRect = new IntRect(GameRunner.Instance.CurGame.TileX, 0, GameRunner.Instance.CurGame.TileX, GameRunner.Instance.CurGame.TileY);
                    break;
                case 1:
                    _sp.TextureRect = new IntRect(GameRunner.Instance.CurGame.TileX, GameRunner.Instance.CurGame.TileY, GameRunner.Instance.CurGame.TileX, GameRunner.Instance.CurGame.TileY);
                    break;
                case 2:
                    _sp.TextureRect = new IntRect(GameRunner.Instance.CurGame.TileX, 2 * GameRunner.Instance.CurGame.TileY, GameRunner.Instance.CurGame.TileX, GameRunner.Instance.CurGame.TileY);
                    break;
                case 3:
                    _sp.TextureRect = new IntRect(GameRunner.Instance.CurGame.TileX, 3 * GameRunner.Instance.CurGame.TileY, GameRunner.Instance.CurGame.TileX, GameRunner.Instance.CurGame.TileY);
                    break;
            }
        }

        public void ClipPlayer(Sprite _sp, int frame)
        {
            switch (GameRunner.Instance.CurGame.ThePlayer.Dir)
            {
                case 0:
                    if (frame == 1)
                        _sp.TextureRect = new IntRect(0, 0, GameRunner.Instance.CurGame.TileX, GameRunner.Instance.CurGame.TileY);
                    else if (frame == 2)
                        _sp.TextureRect = new IntRect(2 * GameRunner.Instance.CurGame.TileX, 0, GameRunner.Instance.CurGame.TileX, GameRunner.Instance.CurGame.TileY);
                    else
                        _sp.TextureRect = new IntRect(GameRunner.Instance.CurGame.TileX, 0, GameRunner.Instance.CurGame.TileX, GameRunner.Instance.CurGame.TileY);
                    break;
                case 1:
                    if (frame == 1)
                        _sp.TextureRect = new IntRect(0, GameRunner.Instance.CurGame.TileY, GameRunner.Instance.CurGame.TileX, GameRunner.Instance.CurGame.TileY);
                    else if (frame == 2)
                        _sp.TextureRect = new IntRect(2 * GameRunner.Instance.CurGame.TileX, GameRunner.Instance.CurGame.TileY, GameRunner.Instance.CurGame.TileX, GameRunner.Instance.CurGame.TileY);
                    else
                        _sp.TextureRect = new IntRect(GameRunner.Instance.CurGame.TileX, GameRunner.Instance.CurGame.TileY, GameRunner.Instance.CurGame.TileX, GameRunner.Instance.CurGame.TileY);
                    break;
                case 2:
                    if (frame == 1)
                        _sp.TextureRect = new IntRect(0, 2 * GameRunner.Instance.CurGame.TileY, GameRunner.Instance.CurGame.TileX, GameRunner.Instance.CurGame.TileY);
                    else if (frame == 2)
                        _sp.TextureRect = new IntRect(2 * GameRunner.Instance.CurGame.TileX, 2 * GameRunner.Instance.CurGame.TileY, GameRunner.Instance.CurGame.TileX, GameRunner.Instance.CurGame.TileY);
                    else
                        _sp.TextureRect = new IntRect(GameRunner.Instance.CurGame.TileX, 2 * GameRunner.Instance.CurGame.TileY, GameRunner.Instance.CurGame.TileX, GameRunner.Instance.CurGame.TileY);
                    break;
                case 3:
                    if (frame == 1)
                        _sp.TextureRect = new IntRect(0, 3 * GameRunner.Instance.CurGame.TileY, GameRunner.Instance.CurGame.TileX, GameRunner.Instance.CurGame.TileY);
                    else if (frame == 2)
                        _sp.TextureRect = new IntRect(2 * GameRunner.Instance.CurGame.TileX, 3 * GameRunner.Instance.CurGame.TileY, GameRunner.Instance.CurGame.TileX, GameRunner.Instance.CurGame.TileY);
                    else
                        _sp.TextureRect = new IntRect(GameRunner.Instance.CurGame.TileX, 3 * GameRunner.Instance.CurGame.TileY, GameRunner.Instance.CurGame.TileX, GameRunner.Instance.CurGame.TileY);
                    break;
            }
        }

        public void DrawGround()
        {
            int max = GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].PlayerAbove;
            if (max > GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer.Count)
                max = GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer.Count;

            for (int i = 0; i < max; i++)
            {
                NextAnimatedLayer(GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer[i]);
            }

            List<TileLayer> _toDraw = new List<TileLayer>();

            for (int i = 0; i < max; i++)
            {
                if (GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer[i].Visible == false)
                {
                    continue;
                }

                _toDraw.Add(GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer[i]);

                for (int l = 0; l < GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer[i].MiniLayer.Count; l++)
                {
                    if (l == GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer[i].LastAnimated)
                        _toDraw.Add(GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer[i].MiniLayer[l]);
                }
            }

            foreach (TileLayer tl in _toDraw)
            {
                foreach (Tile t in tl.myTile)
                {
                    _tileSprite = new Sprite(GameRunner.Instance.CurGame.GM.myResource[GameRunner.Instance.CurGame.TM.myTileset[t.TS].ID].myTexture, new IntRect(t.srcX * GameRunner.Instance.CurGame.TileX, t.srcY * GameRunner.Instance.CurGame.TileY, t.Width, t.Height));
                    _tileSprite.Position = new Vector2f(t.plcX * GameRunner.Instance.CurGame.TileX, t.plcY * GameRunner.Instance.CurGame.TileY);
                    _screen.Draw(_tileSprite);

                }

            }
        }

        public void DrawFringe()
        {
            int max = GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].PlayerAbove;
            if (max >= GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer.Count)
                return;

            for (int i = max; i < GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer.Count; i++)
            {
                NextAnimatedLayer(GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer[i]);
            }

            List<TileLayer> _toDraw = new List<TileLayer>();

            for (int i = max; i < GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer.Count; i++)
            {
                if (GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer[i].Visible == false)
                {
                    continue;
                }

                _toDraw.Add(GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer[i]);

                for (int l = 0; l < GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer[i].MiniLayer.Count; l++)
                {
                    if (l == GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer[i].LastAnimated)
                        _toDraw.Add(GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer[i].MiniLayer[l]);
                }
            }

            foreach (TileLayer tl in _toDraw)
            {
                foreach (Tile t in tl.myTile)
                {
                    _tileSprite = new Sprite(GameRunner.Instance.CurGame.GM.myResource[GameRunner.Instance.CurGame.TM.myTileset[t.TS].ID].myTexture, new IntRect(t.srcX * GameRunner.Instance.CurGame.TileX, t.srcY * GameRunner.Instance.CurGame.TileY, t.Width, t.Height));
                    _tileSprite.Position = new Vector2f(t.plcX * GameRunner.Instance.CurGame.TileX, t.plcY * GameRunner.Instance.CurGame.TileY);
                    _screen.Draw(_tileSprite);

                }

            }
        }

        public void DrawMap()
        {
            /*for (int i = 0; i < GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer.Count; i++)
            {
                NextAnimatedLayer(GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer[i]);
            }

            List<TileLayer> _toDraw = new List<TileLayer>();

            for (int i = 0; i < GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer.Count; i++)
            {
                if (GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer[i].Visible == false)
                {
                    continue;
                }

                _toDraw.Add(GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer[i]);

                for (int l = 0; l < GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer[i].MiniLayer.Count; l++)
                {
                    if (l == GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer[i].LastAnimated)
                        _toDraw.Add(GameRunner.Instance.CurGame.TM.myMap[GameRunner.Instance.CurGame.ThePlayer.CurMap].myLayer[i].MiniLayer[l]);
                }
            }

            foreach (TileLayer tl in _toDraw)
            {
                foreach (Tile t in tl.myTile)
                {
                    _tileSprite = new Sprite(GameRunner.Instance.CurGame.GM.myResource[GameRunner.Instance.CurGame.TM.myTileset[t.TS].ID].myTexture, new IntRect(t.srcX * GameRunner.Instance.CurGame.TileX, t.srcY * GameRunner.Instance.CurGame.TileY, t.Width, t.Height));
                    _tileSprite.Position = new Vector2f(t.plcX * GameRunner.Instance.CurGame.TileX, t.plcY * GameRunner.Instance.CurGame.TileY);
                    _screen.Draw(_tileSprite);

                }

            }
             * */

            
        }

        public void DrawTexture(Texture t)
        {
            Sprite _tsprite = new Sprite(t);
            _screen.Draw(_tsprite);
        }

        public void Update()
        {
            _screen.Clear();

            if (GameRunner.Instance.CurGame.TM.myMap.Count > 0)
                DrawGround();
            if (GameRunner.Instance.CurGame.AM.MyActor.Count > 0 && GameRunner.Instance.CurGame.ThePlayer.Party.Count > 0)
                DrawPlayer();
            if (GameRunner.Instance.CurGame.TM.myMap.Count > 0)
                DrawFringe();

            _screen.Display();
        }

        public void DrawGridToMap()
        {

        }

        public void DrawBlock(Texture t, int tilew, int tileh, RenderWindow toDraw, TileProperty[] tp, int x, int y)
        {
            Sprite sp = new Sprite(t);

            // Drawing the left most arrow)
            if (tp[4].MyLayer[x, y] != 1)
            {
                sp.TextureRect = new IntRect(0, 0, 8, 8);
                sp.Position = new Vector2f(x * tilew + 0, y * tileh + (tileh / 2) - 4);
            }
            else
            {
                sp.TextureRect = new IntRect(0, 8, 8, 8);
                sp.Position = new Vector2f(x * tilew + 0, y * tileh + (tileh / 2) - 4);
            }

            toDraw.Draw(sp);

            // Drawing the top most arrow)
            if (tp[3].MyLayer[x, y] != 1)
            {
                sp.TextureRect = new IntRect(8, 0, 8, 8);
                sp.Position = new Vector2f(x * tilew + tilew / 2 - 4, y * tileh + 0);
            }
            else
            {
                sp.TextureRect = new IntRect(8, 8, 8, 8);
                sp.Position = new Vector2f(x * tilew + tilew / 2 - 4, y * tileh + 0);
            }

            toDraw.Draw(sp);

            // Drawing the right most arrow)
            if (tp[2].MyLayer[x, y] != 1)
            {
                sp.TextureRect = new IntRect(16, 0, 8, 8);
                sp.Position = new Vector2f(x * tilew + tilew - 8, y * tileh + (tileh / 2) - 4);
            }
            else
            {
                sp.TextureRect = new IntRect(16, 8, 8, 8);
                sp.Position = new Vector2f(x * tilew + tilew - 8, y * tileh + (tileh / 2) - 4);
            }

            toDraw.Draw(sp);

            // Drawing the bottom most arrow)
            if (tp[1].MyLayer[x, y] != 1)
            {
                sp.TextureRect = new IntRect(24, 0, 8, 8);
                sp.Position = new Vector2f(x * tilew + tilew / 2 - 4, y * tileh + tileh - 8);
            }
            else
            {
                sp.TextureRect = new IntRect(24, 8, 8, 8);
                sp.Position = new Vector2f(x * tilew + tilew / 2 - 4, y * tileh + tileh - 8);
            }

            toDraw.Draw(sp);

            // Drawing the center)
            if (tp[0].MyLayer[x, y] != 1)
            {
                sp.TextureRect = new IntRect(32, 0, 8, 8);
                sp.Position = new Vector2f(x * tilew + tilew / 2 - 4, y * tileh + tileh / 2 - 4);
            }
            else
            {
                sp.TextureRect = new IntRect(32, 8, 8, 8);
                sp.Position = new Vector2f(x * tilew + tilew / 2 - 4, y * tileh + tileh / 2 - 4);
            }

            toDraw.Draw(sp);

        }

        public void DrawBox()
        {
        }

        public void DrawBox(int boxw, int boxh, int x, int y, RenderWindow toDraw)
        {
            Vertex[] line1 = 
            {
                new Vertex(new Vector2f(x, y)),
                new Vertex(new Vector2f(x + boxw, y)),
            };

            Vertex[] line2 = 
            {
                new Vertex(new Vector2f(x + boxw, y)),
                new Vertex(new Vector2f(x + boxw, y + boxh))
            };

            Vertex[] line3 = 
            {
                new Vertex(new Vector2f(x, y + boxh)),
                new Vertex(new Vector2f(x + boxw, y + boxh))
            };

            Vertex[] line4 = 
            {
                new Vertex(new Vector2f(x, y)),
                new Vertex(new Vector2f(x, y + boxh)),
            };

            toDraw.Draw(line1, SFML.Graphics.PrimitiveType.Lines);
            toDraw.Draw(line2, SFML.Graphics.PrimitiveType.Lines);
            toDraw.Draw(line3, SFML.Graphics.PrimitiveType.Lines);
            toDraw.Draw(line4, SFML.Graphics.PrimitiveType.Lines);
        }
    }
}
