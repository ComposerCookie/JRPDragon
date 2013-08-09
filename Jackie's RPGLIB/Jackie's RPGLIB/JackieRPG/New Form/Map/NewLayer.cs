using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Jackie_s_RPGLIB.Database.Tile_Engine;

namespace JackieRPG
{
    public partial class NewLayer : Form
    {
        TileMap _map;
        List<LayerCache> l;

        public NewLayer(TileMap map, List<LayerCache> _l)
        {
            InitializeComponent();
            _map = map;
            l = _l;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TileLayer tl = new TileLayer();
            tl.Name = txtName.Text;
            tl.Opacity = int.Parse(txtOpacity.Text);
            tl.Visible = true;
            tl.Order = _map.myLayer.Count;

            _map.myLayer.Add(tl);
            l.Add(new LayerCache(_map.maxX, _map.maxY, tl));

            /*int[,] yolo = new int[_map.maxX, _map.maxY];
            for (int x = 0; x < _map.maxX; x++)
            {
                for (int y = 0; y < _map.maxY; y++)
                {
                    yolo[x, y] = -1;
                }
            }

            _avail.Add(yolo); */

            Editor.Instance.ChangeMade = true;
            Editor.Instance.UpdateTitle();

            Editor.Instance.DatabaseUpdate();

            this.Close();
        }
    }
}
