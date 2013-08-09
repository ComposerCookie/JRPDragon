using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SFML.Window;
using SFML.Graphics;

using Jackie_s_RPGLIB.Database.Character;

namespace JackieRPG
{
    class ViewSprite
    {
        RenderWindow _spriteViewer;
        Actor _actor;
        View _view;

        public ViewSprite(IntPtr handle)
        {
            _spriteViewer = new RenderWindow(handle);
        }

        public void SetView(int width, int height)
        {
            _view = new View(new FloatRect(0, 0, width, height));
            _spriteViewer.SetView(_view);
        }

        public void UpdateView(int x, int y)
        {
            _view.Center = new Vector2f(x + ((int)_view.Size.X / 2), y + ((int)_view.Size.Y / 2));
            _spriteViewer.SetView(_view);
        }

        public void ChangeActor(Actor actor)
        {
            _actor = actor;
        }

        public void Render()
        {
            if (_actor == null)
                return;

            if (_actor.Sprite < 0)
                return;

            _spriteViewer.Clear();

            Sprite sp = new Sprite(Editor.Instance.curGame.GM.myResource[Editor.Instance.curGame.AM.MySprite[_actor.Sprite].ID].myTexture);
            _spriteViewer.Draw(sp);
            _spriteViewer.Display();
        }
    }
}
