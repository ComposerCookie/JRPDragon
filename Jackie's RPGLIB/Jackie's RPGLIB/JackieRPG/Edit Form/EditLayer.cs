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
    public partial class EditLayer : Form
    {
        TileLayer _tl;

        public EditLayer(TileLayer tl)
        {
            InitializeComponent();
            _tl = tl;

            txtName.Text = _tl.Name;
            txtOpacity.Text = _tl.Opacity.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _tl.Name = txtName.Text;
            _tl.Opacity = int.Parse(txtOpacity.Text);

            Editor.Instance.ChangeMade = true;
            Editor.Instance.UpdateTitle();

            Editor.Instance.DatabaseUpdate();

            Close();
        }
    }
}
