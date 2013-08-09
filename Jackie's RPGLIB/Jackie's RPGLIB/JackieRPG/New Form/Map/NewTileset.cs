using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Jackie_s_RPGLIB.Database.Core;
using Jackie_s_RPGLIB.Database.Tile_Engine;
using Jackie_s_RPGLIB.Graphic;

using SFML.Graphics;

namespace JackieRPG
{
    public partial class NewTileset : Form
    {
        Tileset _newTS;
        GResource _gr;

        public NewTileset()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = @"Selected texture to import";
                dialog.Multiselect = false;
                dialog.CheckFileExists = true;
                dialog.CheckPathExists = true;
                dialog.Filter = @"Image Files|*.png;*.bmp;*.jrpts;";

                var result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtLocation.Text = dialog.FileName;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtLocation.Text))
            {
                MessageBox.Show(@"You must enter a name and location.", @"Error");
                DialogResult = DialogResult.Cancel;
                return;
            }

            if (File.Exists(System.IO.Path.Combine(Editor.Instance.curGame.Path + @"\Graphic\Tileset\", txtName.Text + ".jrpts")))
            {
                MessageBox.Show(@"You already have a tileset with the name same; you must alter the name.", @"Error");
                DialogResult = DialogResult.Cancel;
                return;
            }

            if (File.Exists(txtLocation.Text) != true)
            {
                MessageBox.Show(@"No such file exist at this location.", @"Error");
                DialogResult = DialogResult.Cancel;
                return;
            }
                        
            _newTS = new Tileset(Editor.Instance.curGame.GM.myResource.Count, txtName.Text);

            if (txtLocation.Text != Editor.Instance.curGame.Path + @"\Graphic\Tileset\" + txtName.Text + ".jrpts")
            {
                System.IO.File.Copy(txtLocation.Text, Editor.Instance.curGame.Path + @"\Graphic\Tileset\" + txtName.Text + ".jrpts", true);
            }           
            
            _gr = new GResource(Editor.Instance.curGame.Path + @"\Graphic\Tileset\" + txtName.Text + ".jrpts");
            _gr.Type = 0;

            Editor.Instance.curGame.GM.myResource.Add(_gr);

            Editor.Instance.DatabaseUpdate();

            Editor.Instance.curGame.TM.myTileset.Add(_newTS);          

            Editor.Instance.graphicDatabase.UpdateDatabase();

            Editor.Instance.ChangeMade = true;
            Editor.Instance.UpdateTitle();

            Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
