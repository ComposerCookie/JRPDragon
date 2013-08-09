using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using WeifenLuo.WinFormsUI.Docking;
using Jackie_s_RPGLIB.Database.Tile_Engine;

namespace JackieRPG
{
    public partial class MapViewerForm : DockContent
    {
        MapViewer mv;
        CurrencyManager cm;
        CurrencyManager cmm;
        TileMap Map;

        List<LayerCache> _layerCache;

        Thread t;

        ViewEvent ve;

        public MapViewerForm(TileMap map)
        {
            InitializeComponent();
            Map = map;
            mv = new MapViewer(picMapViewer.Handle, picMapViewer.Width, picMapViewer.Height);
            mv.changeMap(Map);
            mv.UpdateView();

            lstLayer.DataSource = Map.myLayer;
            lstLayer.DisplayMember = "Name";

            updateLayer();
            ve = new ViewEvent();

            _layerCache = new List<LayerCache>();
            for (int i = 0; i < Map.myLayer.Count; i++ )
            {
                LayerCache lc = new LayerCache(Map.maxX, map.maxY, Map.myLayer[i]);
                _layerCache.Add(lc);
            }

            cm = (CurrencyManager)BindingContext[Map.myLayer];

            SetScrollSize();

            tmrRefresh.Interval = 180;
            tmrRefresh.Start();
        }

        public TileMap myMap
        {
            get { return Map; }
        }

        public void SetScrollSize()
        {
            hMapScroll.Maximum = Map.maxX * Editor.Instance.curGame.TileX - picMapViewer.Width;
            vMapScroll.Maximum = Map.maxY * Editor.Instance.curGame.TileY - picMapViewer.Height;
        }

        private void vMapScroll_Scroll(object sender, ScrollEventArgs e)
        {
            mv.yOffSet = vMapScroll.Value;
            mv.UpdateView();
            RefreshDatabase();
        }

        private void hMapScroll_Scroll(object sender, ScrollEventArgs e)
        {
            mv.xOffSet = hMapScroll.Value;
            mv.UpdateView();
            RefreshDatabase();
        }

        public void RefreshDatabase()
        {
            mv.Render();
            cm.Refresh();

            if (cmm != null)
                cmm.Refresh();

            _layerCache.Clear();
            for (int i = 0; i < Map.myLayer.Count; i++)
            {
                LayerCache l = new LayerCache(Map.maxX, Map.maxY, Map.myLayer[i]);
                _layerCache.Add(l);
            }
        }

        private void picMapViewer_Resize(object sender, EventArgs e)
        {
            mv.ResizeView(picMapViewer.Width, picMapViewer.Height);
            RefreshDatabase();
        }

        private void picMapViewer_Click(object sender, EventArgs e)
        {
            
        }

        private void buttAdd_Click(object sender, EventArgs e)
        {
            NewLayer _newLayer = new NewLayer(Map, _layerCache);
            _newLayer.ShowDialog();

        }

        private void MapViewerForm_Resize(object sender, EventArgs e)
        {
            mv.ResizeView(picMapViewer.Width, picMapViewer.Height);
            RefreshDatabase();
        }

        private void MapViewerForm_ResizeBegin(object sender, EventArgs e)
        {
            mv.ResizeView(picMapViewer.Width, picMapViewer.Height);
            RefreshDatabase();
        }

        private void MapViewerForm_ResizeEnd(object sender, EventArgs e)
        {
            mv.ResizeView(picMapViewer.Width, picMapViewer.Height);
            RefreshDatabase();
        }

        private void lstLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateLayer();

            lstMini.DataSource = Map.myLayer[lstLayer.SelectedIndex].MiniLayer;
            lstMini.DisplayMember = "Name";

            cmm = (CurrencyManager)BindingContext[Map.myLayer[lstLayer.SelectedIndex].MiniLayer];

            cmm.Refresh();

            chkBackground.Checked = true;

        }

        public void updateLayer()
        {
            if (Map.myLayer.Count == 0)
                return;

            lblName.Text = "Name: " + Map.myLayer[lstLayer.SelectedIndex].Name;
            lblOpacity.Text = "Opacity: " + Map.myLayer[lstLayer.SelectedIndex].Opacity.ToString();
            lblVisible.Text = "Visible " + Map.myLayer[lstLayer.SelectedIndex].Visible.ToString();

        }

        public void EventUpdate()
        {
            ve.RefreshTreeView();
        }

        private void chkConstantUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConstantUpdate.Checked == true)
            {
                tmrRefresh.Start();
            }
            else
            {
                tmrRefresh.Stop();
            }
        }

        private void MapViewerForm_Load(object sender, EventArgs e)
        {
        }

        private void MapViewerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            mv.UpdateView();
            mv.Render();
        }

        private void buttUp_Click(object sender, EventArgs e)
        {
            if (Map.myLayer.Count < 2)
                return;

            if (lstLayer.SelectedIndex == 0)
                return;

            Map.myLayer[lstLayer.SelectedIndex].Order -= 1;
            Map.myLayer[lstLayer.SelectedIndex - 1].Order += 1;

            lstLayer.SelectedIndex -= 1;

            SortLayer();
            
        }

        public void SortLayer()
        {
            Map.myLayer.Sort((x, y) => x.Order.CompareTo(y.Order));
            RefreshDatabase();
            updateLayer();

            Editor.Instance.ChangeMade = true;
            Editor.Instance.UpdateTitle();
        }

        public void SortMiniLayer()
        {
            Map.myLayer[lstLayer.SelectedIndex].MiniLayer.Sort((x, y) => x.Order.CompareTo(y.Order));
            RefreshDatabase();
            //updateLayer();

            Editor.Instance.ChangeMade = true;
            Editor.Instance.UpdateTitle();
        }

        private void buttDown_Click(object sender, EventArgs e)
        {
            if (Map.myLayer.Count < 2)
                return;

            if (lstLayer.SelectedIndex == Map.myLayer.Count - 1)
                return;

            Map.myLayer[lstLayer.SelectedIndex].Order += 1;
            Map.myLayer[lstLayer.SelectedIndex + 1].Order -= 1;

            lstLayer.SelectedIndex += 1;

            SortLayer();
        }

        private void buttModify_Click(object sender, EventArgs e)
        {
            if (Map.myLayer.Count == 0)
                return;

            EditLayer _editLayer = new EditLayer(Map.myLayer[lstLayer.SelectedIndex]);
            _editLayer.ShowDialog();
        }

        private void buttRemove_Click(object sender, EventArgs e)
        {
            if (Map.myLayer.Count == 0)
                return;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this layer?", "Delete Layer?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                for (int i = lstLayer.SelectedIndex; i < Map.myLayer.Count; i++)
                {
                    Map.myLayer[i].Order -= 1;
                }

                Map.myLayer.RemoveAt(lstLayer.SelectedIndex);
                updateLayer();

                

                SortLayer();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
                return;
            }
        }

        private void PlaceTile()
        {

            int pickedX = mv.getMouseLoc.X;
            int pickedY = mv.getMouseLoc.Y;

            if (pickedX < 0 || pickedY < 0 || pickedX > picMapViewer.Width || pickedY > picMapViewer.Height)
                return;

            pickedX = mv.getMouseLoc.X + mv.xOffSet;
            pickedY = mv.getMouseLoc.Y + mv.yOffSet;

            if (chkEvent.Checked)
                return;

            if (chkBlock.Checked != true)
            {
                if (Map.myLayer.Count <= 0)
                    return;

                if (pickedX >= Map.maxX * Editor.Instance.curGame.TileX)
                    pickedX = Map.maxX * Editor.Instance.curGame.TileX - 1;
                if (pickedY >= Map.maxY * Editor.Instance.curGame.TileY)
                    pickedY = Map.maxX * Editor.Instance.curGame.TileY - 1;

                pickedX /= Editor.Instance.curGame.TileX;
                pickedY /= Editor.Instance.curGame.TileY;



                Tile _newTile = new Tile(Editor.Instance.tilesetPick.PickedX, Editor.Instance.tilesetPick.PickedY, pickedX, pickedY, Editor.Instance.tilesetPick.CurTS, Editor.Instance.curGame.TileX, Editor.Instance.curGame.TileY, 100);

                if (chkBackground.Checked == true)
                {
                    if ((int)_layerCache[lstLayer.SelectedIndex].MyLayer.GetValue(pickedX, pickedY) > -1)
                        Map.myLayer[lstLayer.SelectedIndex].setTile(_newTile, (int)_layerCache[lstLayer.SelectedIndex].MyLayer.GetValue(pickedX, pickedY));
                    else
                    {
                        Map.myLayer[lstLayer.SelectedIndex].addTile(_newTile);
                        _layerCache[lstLayer.SelectedIndex].MyLayer.SetValue(Map.myLayer[lstLayer.SelectedIndex].myTile.Count - 1, pickedX, pickedY);
                    }
                }
                else
                {
                    if ((int)_layerCache[lstLayer.SelectedIndex].MyMiniLayer[lstMini.SelectedIndex].GetValue(pickedX, pickedY) > -1)
                        Map.myLayer[lstLayer.SelectedIndex].MiniLayer[lstMini.SelectedIndex].setTile(_newTile, (int)_layerCache[lstLayer.SelectedIndex].MyMiniLayer[lstMini.SelectedIndex].GetValue(pickedX, pickedY));
                    else
                    {
                        Map.myLayer[lstLayer.SelectedIndex].MiniLayer[lstMini.SelectedIndex].addTile(_newTile);
                        _layerCache[lstLayer.SelectedIndex].MyMiniLayer[lstMini.SelectedIndex].SetValue(Map.myLayer[lstLayer.SelectedIndex].MiniLayer[lstMini.SelectedIndex].myTile.Count - 1, pickedX, pickedY);
                    }
                }

                lbltileCount.Text = "Total tile: " + Map.myLayer[lstLayer.SelectedIndex].myTile.Count;

            }

            else
            {
                int theX = pickedX / Editor.Instance.curGame.TileX;
                int theY = pickedY / Editor.Instance.curGame.TileY;

                // Left
                if (pickedX > theX * Editor.Instance.curGame.TileX && pickedX < (theX * Editor.Instance.curGame.TileX) + 8 && pickedY > (theY * Editor.Instance.curGame.TileY) + ((Editor.Instance.curGame.TileY / 2) - 4) && pickedY < (theY * Editor.Instance.curGame.TileY) + ((Editor.Instance.curGame.TileY / 2) + 4))
                {
                    if (Map.Block[4].MyLayer[theX, theY] == 0)
                        Map.Block[4].MyLayer[theX, theY] = 1;
                    else
                        Map.Block[4].MyLayer[theX, theY] = 0;
                }

                // Top
                else if (pickedX > theX * Editor.Instance.curGame.TileX + Editor.Instance.curGame.TileX / 2 - 4 && pickedX < Editor.Instance.curGame.TileX * theX + Editor.Instance.curGame.TileX / 2 + 4 && pickedY > theY * Editor.Instance.curGame.TileY && pickedY < theY * Editor.Instance.curGame.TileY + 8)
                {
                    if (Map.Block[3].MyLayer[theX, theY] == 0)
                        Map.Block[3].MyLayer[theX, theY] = 1;
                    else
                        Map.Block[3].MyLayer[theX, theY] = 0;
                }

                // Right
                else if (pickedX > theX * Editor.Instance.curGame.TileX + Editor.Instance.curGame.TileX - 8 && pickedX < (theX + 1) * Editor.Instance.curGame.TileX && pickedY > theY * Editor.Instance.curGame.TileY + Editor.Instance.curGame.TileY / 2 - 4 && pickedY < theY * Editor.Instance.curGame.TileY + Editor.Instance.curGame.TileY / 2 + 4)
                {
                    if (Map.Block[2].MyLayer[theX, theY] == 0)
                        Map.Block[2].MyLayer[theX, theY] = 1;
                    else
                        Map.Block[2].MyLayer[theX, theY] = 0;
                }

                //Bottom
                else if (pickedX > theX * Editor.Instance.curGame.TileX + Editor.Instance.curGame.TileX / 2 - 4 && pickedX < Editor.Instance.curGame.TileX * theX + Editor.Instance.curGame.TileX / 2 + 4 && pickedY > theY * Editor.Instance.curGame.TileY + Editor.Instance.curGame.TileY - 8 && pickedY < (theY + 1) * Editor.Instance.curGame.TileY)
                {
                    if (Map.Block[1].MyLayer[theX, theY] == 0)
                        Map.Block[1].MyLayer[theX, theY] = 1;
                    else
                        Map.Block[1].MyLayer[theX, theY] = 0;
                }

                // Middle
                else if (pickedX > theX * Editor.Instance.curGame.TileX + Editor.Instance.curGame.TileX / 2 - 4 && pickedX < theX * Editor.Instance.curGame.TileX + Editor.Instance.curGame.TileX / 2 + 4 && pickedY > theY * Editor.Instance.curGame.TileY + Editor.Instance.curGame.TileY / 2 - 4 && pickedY < theY * Editor.Instance.curGame.TileY + Editor.Instance.curGame.TileY / 2 + 4)
                {
                    if (Map.Block[0].MyLayer[theX, theY] == 0)
                        Map.Block[0].MyLayer[theX, theY] = 1;
                    else
                        Map.Block[0].MyLayer[theX, theY] = 0;
                }
            }

            mv.Render();

            Editor.Instance.ChangeMade = true;
            Editor.Instance.UpdateTitle();
        }

        private void picMapViewer_MouseDown(object sender, MouseEventArgs e)
        {
            if (chkBlock.Checked || chkEvent.Checked)
            {
                PlaceTile();
                return;
            }

            t = new System.Threading.Thread(KeepPlacingTile);
            t.Start();

            //PlaceTile();

        }

        public void KeepPlacingTile()
        {

            while (true)
            {
                //you need to use Invoke because the new thread can't access the UI elements directly
                MethodInvoker mi = delegate() { PlaceTile(); };
                this.Invoke(mi);
            }
        }

        private void picMapViewer_MouseUp(object sender, MouseEventArgs e)
        {
            if (chkBlock.Checked || chkEvent.Checked)
            {
                //PlaceTile();
                return;
            }

            t.Abort();
        }

        private void chkShowGrid_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowGrid.Checked == true)
                mv.Grid = true;
            else
                mv.Grid = false;
            
        }

        private void lstMini_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkBackground.Checked = false;
        }

        private void chkBackground_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBackground.Checked == false)
                return;

            chkBlock.Checked = false;
            chkEvent.Checked = false;
        }

        private void buttAddMini_Click(object sender, EventArgs e)
        {
            if (Map.myLayer.Count == 0)
                return;

            NewMini nm = new NewMini(Map.myLayer[lstLayer.SelectedIndex]);
            nm.ShowDialog();
        }

        private void chkGround_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGround.Checked == true)
                mv.ShowGround = true;
            else
                mv.ShowGround = false;
        }

        private void chkFringe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFringe.Checked == true)
                mv.ShowFringe = true;
            else
                mv.ShowFringe = false;
        }

        private void buttMiniUp_Click(object sender, EventArgs e)
        {
            if (Map.myLayer[lstLayer.SelectedIndex].MiniLayer.Count < 2)
                return;

            if (lstMini.SelectedIndex == 0)
                return;

            Map.myLayer[lstLayer.SelectedIndex].MiniLayer[lstMini.SelectedIndex].Order -= 1;
            Map.myLayer[lstLayer.SelectedIndex].MiniLayer[lstMini.SelectedIndex - 1].Order += 1;

            lstMini.SelectedIndex -= 1;

            SortMiniLayer();
        }

        private void buttMiniDown_Click(object sender, EventArgs e)
        {
            if (Map.myLayer[lstLayer.SelectedIndex].MiniLayer.Count < 2)
                return;

            if (lstMini.SelectedIndex == Map.myLayer[lstLayer.SelectedIndex].MiniLayer.Count - 1)
                return;

            Map.myLayer[lstLayer.SelectedIndex].MiniLayer[lstMini.SelectedIndex].Order += 1;
            Map.myLayer[lstLayer.SelectedIndex].MiniLayer[lstMini.SelectedIndex + 1].Order -= 1;

            lstMini.SelectedIndex += 1;

            SortMiniLayer();
        }

        private void chkBlock_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlock.Checked == false)
                return;

            chkBackground.Checked = false;
            chkEvent.Checked = false;
            
        }

        private void chkShowBlock_CheckedChanged(object sender, EventArgs e)
        {
            mv.Block = chkShowBlock.Checked;
        }

        private void chkEvent_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEvent.Checked == false)
                return;

            chkBackground.Checked = false;
            chkBlock.Checked = false;
        }

        private void picMapViewer_DoubleClick(object sender, EventArgs e)
        {
            if (chkBlock.Checked || chkBackground.Checked || ve.Visible)
                return;

            int pickedX = mv.getMouseLoc.X;
            int pickedY = mv.getMouseLoc.Y;

            if (pickedX < 0 || pickedY < 0 || pickedX > picMapViewer.Width || pickedY > picMapViewer.Height)
                return;

            pickedX = mv.getMouseLoc.X + mv.xOffSet;
            pickedY = mv.getMouseLoc.Y + mv.yOffSet;

            pickedX /= Editor.Instance.curGame.TileX;
            pickedY /= Editor.Instance.curGame.TileY;

            ViewEvent v = new ViewEvent(Map.EM[pickedX, pickedY].MyEvent);
            v.ShowDialog();
        }
    }
}
