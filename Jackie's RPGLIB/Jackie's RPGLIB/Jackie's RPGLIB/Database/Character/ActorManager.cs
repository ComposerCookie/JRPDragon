using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jackie_s_RPGLIB.Database.Character
{
    public class ActorManager
    {
        List<Actor> _myActor;
        List<Sprites> _mySprite;
        List<Face> _myFace;

        public ActorManager()
        {
            _myActor = new List<Actor>();
            _mySprite = new List<Sprites>();
            _myFace = new List<Face>();
        }

        public List<Actor> MyActor
        {
            get { return _myActor; }
        }

        public List<Sprites> MySprite
        {
            get { return _mySprite; }
        }

        public List<Face> MyFace
        {
            get { return _myFace; }
        }
    }
}
