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
    public partial class EditMap : Form
    {
        TileMap _map;

        public EditMap(TileMap map)
        {
            InitializeComponent();
            _map = map;

            txtName.Text = _map.Name;
            txtMaxX.Text = _map.maxX.ToString();
            txtMaxY.Text = _map.maxY.ToString();
            txtPlayerAbove.Text = _map.PlayerAbove.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _map.Name = txtName.Text;
            _map.maxX = int.Parse(txtMaxX.Text);
            _map.maxY = int.Parse(txtMaxY.Text);
            _map.PlayerAbove = int.Parse(txtPlayerAbove.Text);

            _map.DeleteExceed();
            Editor.Instance.DatabaseUpdate();

            Editor.Instance.ChangeMade = true;
            Editor.Instance.UpdateTitle();

            Close();
        }
    }
}
