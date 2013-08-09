using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Jackie_s_RPGLIB.Graphic;
using Jackie_s_RPGLIB.Database.Character;

namespace JackieRPG
{
    public partial class NewFace : Form
    {
        Face _newF;
        GResource _gr;

        public NewFace()
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
                dialog.Filter = @"Image Files|*.png;*.bmp;*.jrpts;*.jrps;*.jrpf;";

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

            if (File.Exists(System.IO.Path.Combine(Editor.Instance.curGame.Path + @"\Graphic\Face\", txtName.Text + ".jrpf")))
            {
                MessageBox.Show(@"You already have a face with the same name; you must alter the name.", @"Error");
                DialogResult = DialogResult.Cancel;
                return;
            }

            if (File.Exists(txtLocation.Text) != true)
            {
                MessageBox.Show(@"No such file exist at this location.", @"Error");
                DialogResult = DialogResult.Cancel;
                return;
            }


            _newF = new Face(Editor.Instance.curGame.GM.myResource.Count, txtName.Text);

            if (txtLocation.Text != Editor.Instance.curGame.Path + @"\Graphic\Face\" + txtName.Text + ".jrpf")
            {
                System.IO.File.Copy(txtLocation.Text, Editor.Instance.curGame.Path + @"\Graphic\Face\" + txtName.Text + ".jrpf", true);
            }

            _gr = new GResource(Editor.Instance.curGame.Path + @"\Graphic\Face\" + txtName.Text + ".jrpf");
            _gr.Type = 0;

            Editor.Instance.curGame.GM.myResource.Add(_gr);

            Editor.Instance.DatabaseUpdate();

            Editor.Instance.curGame.AM.MyFace.Add(_newF);

            Editor.Instance.graphicDatabase.UpdateDatabase();

            Editor.Instance.ChangeMade = true;
            Editor.Instance.UpdateTitle();

            Close();
        }
    }
}
