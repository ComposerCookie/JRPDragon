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

namespace JackieRPG
{
    public partial class NewGame : Form
    {
        Game _newGame;

        public NewGame()
        {
            InitializeComponent();

            txtLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Jackie's RPG Maker\Project\";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = @"Select folder to create game in.";
                folderDialog.SelectedPath = txtLocation.Text;

                var folderResult = folderDialog.ShowDialog();

                if (folderResult == DialogResult.OK)
                {
                    txtLocation.Text = folderDialog.SelectedPath;
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

            if (Directory.Exists(System.IO.Path.Combine(txtLocation.Text, txtName.Text)))
            {
                MessageBox.Show(@"A project with this name already exists in this directory.", @"Error");
                DialogResult = DialogResult.Cancel;
                return;
            }

            _newGame = new Game();
            _newGame.Name = txtName.Text;
            _newGame.Path = txtLocation.Text + _newGame.Name;
            _newGame.Author = txtAuthor.Text;
            _newGame.Description = txtDescription.Text;
            _newGame.SubName = txtSubName.Text;
            _newGame.TileX = int.Parse(txtMaxX.Text);
            _newGame.TileY = int.Parse(txtMaxY.Text);
            Editor.Instance.NewProject(_newGame);

            Close();
            
        }

    }
}
