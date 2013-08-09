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
    public partial class EditTileset : Form
    {
        Tileset t = new Tileset();

        public EditTileset(Tileset ts)
        {
            InitializeComponent();
            txtName.Text = ts.Name;
            t = ts;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            t.Name = txtName.Text;
            Editor.Instance.graphicDatabase.RefreshTilesetDatabase();
        }

    }
}
