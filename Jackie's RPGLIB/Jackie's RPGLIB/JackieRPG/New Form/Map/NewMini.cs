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
    public partial class NewMini : Form
    {
        TileLayer _layer;
        TileLayer _mini;

        public NewMini(TileLayer layer)
        {
            InitializeComponent();

            _mini = new TileLayer();

            _layer = layer;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _mini.Name = txtName.Text;
            _mini.Opacity = int.Parse(txtOpacity.Text);
            _mini.Order = _layer.MiniLayer.Count;

            _layer.MiniLayer.Add(_mini);

            Editor.Instance.ChangeMade = true;
            Editor.Instance.UpdateTitle();

            Editor.Instance.DatabaseUpdate();

            Close();
        }
    }
}
