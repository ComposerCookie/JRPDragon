using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Jackie_s_RPGLIB.Database.Tile_Engine;
using Jackie_s_RPGLIB.Graphic;

using WeifenLuo.WinFormsUI.Docking;

namespace JackieRPG
{
    public partial class ProjectDirectory : DockContent
    {
        public ProjectDirectory()
        {
            InitializeComponent();
            RefreshTreeView();
        }

        public void RefreshTreeView()
        {
            

            trvDirectory.Nodes.Clear();

            TreeNode TilesetNode = new TreeNode("Tileset: ");
            TilesetNode.Name = "Tileset";
            TreeNode Map = new TreeNode("Map: ");
            Map.Name = "Map";
            TreeNode parentNode = new TreeNode("Current Project: ");

            foreach (Tileset tl in Editor.Instance.curGame.TM.myTileset)
            {
                TreeNode tilesetnode = new TreeNode (tl.Name);
                TilesetNode.Nodes.Add(tilesetnode);
            }

            foreach (TileMap m in Editor.Instance.curGame.TM.myMap)
            {
                TreeNode demMap = new TreeNode(m.Name);
                foreach (TileLayer tl in m.myLayer)
                {
                    TreeNode demLayer = new TreeNode(tl.Name);
                    demMap.Nodes.Add(demLayer);
                }
                Map.Nodes.Add(demMap);
            }
            
            parentNode.Nodes.Add(TilesetNode);
            parentNode.Nodes.Add(Map);

            trvDirectory.Nodes.Add(parentNode);
        }

        private void trvDirectory_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void trvDirectory_DoubleClick(object sender, EventArgs e)
        {
            if (trvDirectory.SelectedNode.Parent == null)
                return;

            if (trvDirectory.SelectedNode.Parent.Name.Equals("Tileset"))
            {
            }
            if (trvDirectory.SelectedNode.Parent.Name.Equals("Map"))
            {
                MapViewerForm mv = new MapViewerForm(Editor.Instance.curGame.TM.myMap[trvDirectory.SelectedNode.Index]);
                Editor.Instance.AddMapViewer(mv);
                mv.RefreshDatabase();
            }
        }

        private void trvDirectory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                trvDirectory.SelectedNode = trvDirectory.GetNodeAt(e.X, e.Y);
                if (trvDirectory.SelectedNode.Parent == null)
                    return;

                if (trvDirectory.SelectedNode.Parent.Name.Equals("Map"))
                {
                    SelectedMapContextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(trvDirectory.SelectedNode.Index.ToString());
        }

        private void editMapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditMap em = new EditMap(Editor.Instance.curGame.TM.myMap[trvDirectory.SelectedNode.Index]);
            em.ShowDialog();
        }

        private void removeMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Editor.Instance.curGame.TM.myMap.Count == 0)
                return;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this map?", "Delete map?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                Editor.Instance.CloseMV(Editor.Instance.curGame.TM.myMap[trvDirectory.SelectedNode.Index]);
                Editor.Instance.curGame.TM.myMap.RemoveAt(trvDirectory.SelectedNode.Index);

                Editor.Instance.DatabaseUpdate();

                Editor.Instance.ChangeMade = true;
                Editor.Instance.UpdateTitle();
                
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
                return;
            }
        }
    }
}
