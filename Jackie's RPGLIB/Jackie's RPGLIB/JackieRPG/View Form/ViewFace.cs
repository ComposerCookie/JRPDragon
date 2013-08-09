using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SFML.Graphics;
using SFML.Window;

using Jackie_s_RPGLIB.Database.Character;

namespace JackieRPG
{
    public class ViewFace
    {
        RenderWindow _faceViewer;
        Actor _actor;

        public ViewFace(IntPtr handle)
        {
            _faceViewer = new RenderWindow(handle);
        }

        public void ChangeActor(Actor actor)
        {
            _actor = actor;
        }

        public void Render()
        {
            if (_actor == null)
                return;

            if (_actor.Face < 0)
                return;

            _faceViewer.Clear();

            Sprite sp = new Sprite(Editor.Instance.curGame.GM.myResource[Editor.Instance.curGame.AM.MyFace[_actor.Face].ID].myTexture);
            _faceViewer.Draw(sp);
            _faceViewer.Display();
        }
    }
}
