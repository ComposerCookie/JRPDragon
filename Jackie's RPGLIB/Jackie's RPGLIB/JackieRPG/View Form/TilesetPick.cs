using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

using Jackie_s_RPGLIB.Database.Core;
using Jackie_s_RPGLIB.Database.Tile_Engine;
using Jackie_s_RPGLIB.Graphic;

using SFML.Graphics;
using SFML.Window;

namespace JackieRPG
{
    public partial class TilesetPick : DockContent
    {
        int curTS;
        int _pickedX;
        int _pickedY;
        TilesetViewer tv;

        public TilesetPick()
        {
            InitializeComponent();
            tv = new TilesetViewer(picTilesetViewer.Handle, picTilesetViewer.Width, picTilesetViewer.Height);

            tmrRefresh.Interval = 60;
            tmrRefresh.Start();
            RefreshDatabase();
        }

        public void RefreshDatabase()
        {
            //prevW = this.Width;
            //prevH = this.Height;

            if (Editor.Instance.curGame.TM.myTileset.Count != 0)
            {

                //tv.LoadTileset(new Texture(Editor.Instance.curGame.Path + @"\Graphic\Tileset\Tileset1.jrpts"));
                txtCurTS.Text = (curTS + 1) + " / " + Editor.Instance.curGame.TM.myTileset.Count;
                tv.LoadTileset(Editor.Instance.curGame.GM.myResource[Editor.Instance.curGame.TM.myTileset[curTS].ID].myTexture);
            }
            else
            {
                txtCurTS.Text =  "0 / " + Editor.Instance.curGame.TM.myTileset.Count;
            }

            SetScrollsSize();
            tv.UpdateView();
            tv.Render();
        }

        public int CurTS
        {
            get { return curTS; }
        }

        public int PickedX
        {
            get { return _pickedX; }
        }

        public int PickedY
        {
            get { return _pickedY; }
        }

        private void SetScrollsSize()
        {
            if (tv.TSTexture == null)
                return;

            if ((int)tv.TSTexture.Size.Y - picTilesetViewer.Height <= 0)
                vTilesetScroll.Enabled = false;
            else
            {
                vTilesetScroll.Enabled = true;
                vTilesetScroll.Maximum = (int)tv.TSTexture.Size.Y - picTilesetViewer.Height;
            }
            if ((int)tv.TSTexture.Size.X - picTilesetViewer.Width <= 0)
                hTilesetScroll.Enabled = false;
            else
            {
                hTilesetScroll.Enabled = true;
                hTilesetScroll.Maximum = (int)tv.TSTexture.Size.X - picTilesetViewer.Width;
            }
            
        }

        private void vTilesetScroll_Scroll(object sender, ScrollEventArgs e)
        {
            tv.yOffSet = vTilesetScroll.Value;
            tv.UpdateView();
            RefreshDatabase();
        }

        private void hTilesetScroll_Scroll(object sender, ScrollEventArgs e)
        {
            tv.xOffSet = hTilesetScroll.Value;
            tv.UpdateView();
            RefreshDatabase();
        }

        private void toRightTSbutt_Click(object sender, EventArgs e)
        {
            curTS++;
            if (curTS >= Editor.Instance.curGame.TM.myTileset.Count)
                curTS = Editor.Instance.curGame.TM.myTileset.Count - 1;

            RefreshDatabase();
        }

        private void toLeftTSbutt_Click(object sender, EventArgs e)
        {
            curTS--;
            if (curTS < 0)
                curTS = 0;

            RefreshDatabase();
        }

        private void TilesetPick_Resize(object sender, EventArgs e)
        {
            //prevW = this.Width;
            //prevH = this.Height;
            tv.ResizeView(picTilesetViewer.Width, picTilesetViewer.Height);
            RefreshDatabase();
        }

        private void TilesetPick_ResizeBegin(object sender, EventArgs e)
        {
            tv.ResizeView(picTilesetViewer.Width, picTilesetViewer.Height);
            RefreshDatabase();
        }

        private void TilesetPick_ResizeEnd(object sender, EventArgs e)
        {
            tv.ResizeView(picTilesetViewer.Width, picTilesetViewer.Height);
            RefreshDatabase();
        }

        private void picTilesetViewer_Resize(object sender, EventArgs e)
        {
            tv.ResizeView(picTilesetViewer.Width, picTilesetViewer.Height);
            RefreshDatabase();
            //picTilesetViewer.Refresh();
        }

        private void picTilesetViewer_MouseHover(object sender, EventArgs e)
        {
        }

        private void picTilesetViewer_MouseMove(object sender, MouseEventArgs e)
        {
            UpdateMouseLoc();
        }

        public void UpdateMouseLoc()
        {
            lblMouseLoc.Text = "Mouse Location: (" + tv.getMouseLoc.X + ", " + tv.getMouseLoc.Y + ")";
        }

        private void picTilesetViewer_Click(object sender, EventArgs e)
        {
            PickedATile();
        }


        public void PickedATile()
        {
            if (Editor.Instance.curGame.TM.myTileset.Count == 0)
                return;

            _pickedX = tv.getMouseLoc.X + tv.xOffSet;
            _pickedY = tv.getMouseLoc.Y + tv.yOffSet;
            if (_pickedX >= Editor.Instance.curGame.GM.myResource[Editor.Instance.curGame.TM.myTileset[curTS].ID].myTexture.Size.X)
                _pickedX = (int)Editor.Instance.curGame.GM.myResource[Editor.Instance.curGame.TM.myTileset[curTS].ID].myTexture.Size.X - 1;
            if (_pickedY >= Editor.Instance.curGame.GM.myResource[Editor.Instance.curGame.TM.myTileset[curTS].ID].myTexture.Size.Y)
                _pickedY = (int)Editor.Instance.curGame.GM.myResource[Editor.Instance.curGame.TM.myTileset[curTS].ID].myTexture.Size.Y - 1;
            _pickedX /= 32;
            _pickedY /= 32;
            lblTilePicked.Text = "Tile picked: (" + _pickedX + ", " + _pickedY + ")";
        }

        private void TilesetPick_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            tv.UpdateView();
            tv.Render();
        }

        private void chkShowGrid_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowGrid.Checked == true)
                tv.Grid = true;
            else
                tv.Grid = false;
        }
    }
}
