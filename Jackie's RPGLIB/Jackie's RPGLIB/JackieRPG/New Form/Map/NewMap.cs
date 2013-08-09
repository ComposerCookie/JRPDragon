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
    public partial class NewMap : Form
    {
        public NewMap()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TileMap map = new TileMap(int.Parse(txtMaxX.Text), int.Parse(txtMaxY.Text), txtName.Text);
            map.PlayerAbove = int.Parse(txtPlayerAbove.Text);

            Editor.Instance.curGame.TM.myMap.Add(map);
            Editor.Instance.DatabaseUpdate();

            Editor.Instance.ChangeMade = true;
            Editor.Instance.UpdateTitle();

            this.Close();
        }
    }
}
