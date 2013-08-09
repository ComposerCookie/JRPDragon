using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SFML.Graphics;
using Jackie_s_RPGLIB.Database.Core;

namespace Jackie_s_RPGLIB.Graphic
{
    public class GManager
    {
        // Field

        List<GResource> _myResource;
        string _path;

        // Constructor

        public GManager()
        {
            _myResource = new List<GResource>();
            _path = "";
        }

        // Property

        public List<GResource> myResource
        {
            get { return _myResource; }
        }

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        // Add Remove Method

        public void addResource(string path)
        {
            if (checkExist(path) != false)
                return;

            Texture newTexture = new Texture(path);
            GResource newGR = new GResource(path);
            _myResource.Add(newGR);
        }

        public void removeResource(string path)
        {
            if (checkExist(path) != true)
                return;

            int o = getIndex(path);
            if (o == -1)
                return;

            _myResource.RemoveAt(o);

        }

        // Check if Exist Method

        public bool checkExist(string path)
        {
            foreach (GResource g in _myResource)
            {
                if (g.Path.Equals(path))
                    return true;
            }

            return false;
        }

        public int getIndex(string path)
        {
            int r = -1;

            if (checkExist(path) != true)
                return r;
                        
            for (int i = 0; i < _myResource.Count; i++)
            {
                if (_myResource[i].Path.Equals(path))
                    r = i;
            }

            return r;
        }

        
    }
}
