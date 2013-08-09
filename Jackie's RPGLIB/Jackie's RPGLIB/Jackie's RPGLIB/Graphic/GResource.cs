using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SFML.Graphics;

namespace Jackie_s_RPGLIB.Graphic
{
    public class GResource
    {
        
        // Field

        Texture _myTexture;
        int _type;
        string _path;
        bool _loaded;

        // Constructor

        public GResource()
        {
            _path = "";
            _loaded = false;
            _myTexture = null;
            _type = 0;
        }

        public GResource(string path)
        {
            _path = path;
            _loaded = false;
            _myTexture = null;
            _type = 0;
        }

        public GResource(string path, int type)
        {
            _path = path;
            _loaded = false;
            _myTexture = null;
            _type = type;
        }

        // Property

        public Texture myTexture
        {
            get { return _myTexture; }
        }

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public bool Loaded
        {
            get { return _loaded; }
            set { _loaded = value; }
        }

        // Method

        public void changeTexture(Texture tx, string path)
        {
            _myTexture = new Texture(tx);
            _path = path;
            
        }

        public void loadTexture()
        {
            _myTexture = new Texture(_path);
            Loaded = true;
        }
    }
}
