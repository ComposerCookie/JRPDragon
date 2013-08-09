using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SFML.Window;
using SFML.Graphics;

using Jackie_s_RPGLIB.Database.Character;

namespace JackieRPG
{
    public class ViewAnimateSprite
    {
        RenderWindow _animatedSpriteViewer;
        View _view;
        Actor _actor;
        int _curFrame;

        public ViewAnimateSprite(IntPtr handle)
        {
            _animatedSpriteViewer = new RenderWindow(handle);
            _view = new View(new FloatRect(0, 0, Editor.Instance.curGame.TileX, Editor.Instance.curGame.TileY));
            _curFrame = 0;
            _animatedSpriteViewer.SetView(_view);
        }

        public void ChangeActor(Actor actor)
        {
            _actor = actor;
        }

        public void UpdateView()
        {

            switch (_curFrame)
            {
                // The 4 basic not moving sprite

                case 0: case 2:
                    _view.Center = new Vector2f(Editor.Instance.curGame.TileX + Editor.Instance.curGame.TileX / 2, 0 + Editor.Instance.curGame.TileY / 2);
                    break;
                case 4: case 6:
                    _view.Center = new Vector2f(Editor.Instance.curGame.TileX + Editor.Instance.curGame.TileX / 2, Editor.Instance.curGame.TileY + Editor.Instance.curGame.TileY / 2);
                    break;
                case 8: case 10:
                    _view.Center = new Vector2f(Editor.Instance.curGame.TileX + Editor.Instance.curGame.TileX / 2, 2 * Editor.Instance.curGame.TileY + Editor.Instance.curGame.TileY / 2);
                    break;

                case 12: case 14:
                    _view.Center = new Vector2f(Editor.Instance.curGame.TileX + Editor.Instance.curGame.TileX / 2, 3 * Editor.Instance.curGame.TileY + Editor.Instance.curGame.TileY / 2);
                    break;

                case 1:
                    _view.Center = new Vector2f(0 + Editor.Instance.curGame.TileX / 2, 0 + Editor.Instance.curGame.TileY / 2);
                    break;
                case 3:
                    _view.Center = new Vector2f(2 * Editor.Instance.curGame.TileX + Editor.Instance.curGame.TileX / 2, 0 + Editor.Instance.curGame.TileY / 2);
                    break;
                case 5:
                    _view.Center = new Vector2f(0 + Editor.Instance.curGame.TileX / 2, Editor.Instance.curGame.TileY + Editor.Instance.curGame.TileY / 2);
                    break;
                case 7:
                    _view.Center = new Vector2f(2 * Editor.Instance.curGame.TileX + Editor.Instance.curGame.TileX / 2, Editor.Instance.curGame.TileY + Editor.Instance.curGame.TileY / 2);
                    break;
                case 9:
                    _view.Center = new Vector2f(0 + Editor.Instance.curGame.TileX / 2, 2 * Editor.Instance.curGame.TileY + Editor.Instance.curGame.TileY / 2);
                    break;
                case 11:
                    _view.Center = new Vector2f(2 * Editor.Instance.curGame.TileX + Editor.Instance.curGame.TileX / 2, 2 * Editor.Instance.curGame.TileY + Editor.Instance.curGame.TileY / 2);
                    break;
                case 13:
                    _view.Center = new Vector2f(0 + Editor.Instance.curGame.TileX / 2, 3 * Editor.Instance.curGame.TileY + Editor.Instance.curGame.TileY / 2);
                    break;
                case 15:
                    _view.Center = new Vector2f(2 * Editor.Instance.curGame.TileX + Editor.Instance.curGame.TileX / 2, 3 * Editor.Instance.curGame.TileY + Editor.Instance.curGame.TileY / 2);
                    break;
            }
        }

        public void Render()
        {
            if (_actor == null)
                return;

            if (_actor.Sprite < 0)
                return;

            _animatedSpriteViewer.Clear(new Color (255,255,255,0));

            _curFrame++;

            if (_curFrame > 15)
                _curFrame = 0;

            UpdateView();

            _animatedSpriteViewer.SetView(_view);

            Sprite sp = new Sprite(Editor.Instance.curGame.GM.myResource[Editor.Instance.curGame.AM.MySprite[_actor.Sprite].ID].myTexture);
            _animatedSpriteViewer.Draw(sp);
            _animatedSpriteViewer.Display();
        }
    }
}
