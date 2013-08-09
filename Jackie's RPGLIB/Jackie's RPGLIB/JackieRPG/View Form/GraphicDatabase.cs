using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Jackie_s_RPGLIB.Database.Core;
using Jackie_s_RPGLIB.Database.Tile_Engine;
using Jackie_s_RPGLIB.Graphic;
using Jackie_s_RPGLIB.Database.Character;

using SFML.Graphics;
using SFML.Window;

namespace JackieRPG
{
    public partial class GraphicDatabase : Form
    {
        TilesetViewer tv;
        ViewSprite vs;
        ViewAnimateSprite vas;
        ViewFace vf;

        CurrencyManager cmts;
        CurrencyManager cms;
        CurrencyManager cmf;

        public GraphicDatabase()
        {
            InitializeComponent();

            tv = new TilesetViewer(picTilesetViewer.Handle, picTilesetViewer.Width, picTilesetViewer.Height);
            vs = new ViewSprite(picSprite.Handle);
            vf = new ViewFace(picFace.Handle);
            vas = new ViewAnimateSprite(picSpriteAnimation.Handle);
            vs.SetView(picSprite.Width, picSprite.Height);

            //tv.LoadTileset(new Texture("0.png"));
            tv.yOffSet = vTilesetScroll.Value;
            tv.UpdateView();

            lstTileset.DataSource = Editor.Instance.curGame.TM.myTileset;
            lstTileset.DisplayMember = "Name";

            lstSprite.DataSource = Editor.Instance.curGame.AM.MySprite;
            lstSprite.DisplayMember = "Name";

            lstFace.DataSource = Editor.Instance.curGame.AM.MyFace;

            cmts = (CurrencyManager)BindingContext[Editor.Instance.curGame.TM.myTileset];
            cms = (CurrencyManager)BindingContext[Editor.Instance.curGame.AM.MySprite];
            cmf = (CurrencyManager)BindingContext[Editor.Instance.curGame.AM.MyFace];

            RefreshTilesetDatabase();
            RefreshSpriteDatabase();
            RefreshFaceDatabase();

            tmrRefresher.Start();
        }

        public void UpdateDatabase()
        {
            cmts.Refresh();
            RefreshTilesetDatabase();
            cms.Refresh();
            RefreshSpriteDatabase();
            cmf.Refresh();
            RefreshFaceDatabase();
        }

        public void RefreshSpriteDatabase()
        {
            if (Editor.Instance.curGame.AM.MySprite.Count == 0)
                return;

            Actor _actor = new Actor();
            _actor.Sprite = lstSprite.SelectedIndex;

            vs.ChangeActor(_actor);
            vas.ChangeActor(_actor);

            SetSpriteScrollsSize();

            vs.Render();
        }

        public void RefreshFaceDatabase()
        {
            if (Editor.Instance.curGame.AM.MyFace.Count == 0)
                return;

            Actor _actor = new Actor();
            _actor.Face = lstFace.SelectedIndex;

            vf.ChangeActor(_actor);
            
            SetFaceScrollsSize();

            vf.Render();
        }

        public void RefreshTilesetDatabase()
        {
            if (Editor.Instance.curGame.TM.myTileset.Count != 0)
            {
                //tv.LoadTileset(new Texture(Editor.Instance.curGame.Path + @"\Graphic\Tileset\Tileset1.jrpts"));
                lblName.Text = "Name: " + Editor.Instance.curGame.TM.myTileset[lstTileset.SelectedIndex].Name;
                tv.LoadTileset(Editor.Instance.curGame.GM.myResource[lstTileset.SelectedIndex].myTexture);
                lblEditting.Text = "Editing Tileset: " + lstTileset.SelectedIndex;
            }
            else
            {
                lblEditting.Text = "No tileset";
            }
            


            SetTilesetScrollsSize();
            tv.Render();
        }

        private void SetTilesetScrollsSize()
        {
            if (tv.TSTexture == null)
                return;

            vTilesetScroll.Maximum = (int)tv.TSTexture.Size.Y - picTilesetViewer.Height;
            hTilesetScroll.Maximum = (int)tv.TSTexture.Size.X - picTilesetViewer.Width;
                
        }

        private void SetSpriteScrollsSize()
        {
            if (Editor.Instance.curGame.AM.MySprite.Count == 0)
                return;

            vSpriteScroll.Maximum = (int)Editor.Instance.curGame.GM.myResource[Editor.Instance.curGame.AM.MySprite[lstSprite.SelectedIndex].ID].myTexture.Size.X - picSprite.Height;
            hSpriteScroll.Maximum = (int)Editor.Instance.curGame.GM.myResource[Editor.Instance.curGame.AM.MySprite[lstSprite.SelectedIndex].ID].myTexture.Size.Y - picSprite.Width;

        }

        private void SetFaceScrollsSize()
        {
            if (Editor.Instance.curGame.AM.MyFace.Count == 0)
                return;

            vFaceScroll.Maximum = (int)Editor.Instance.curGame.GM.myResource[Editor.Instance.curGame.AM.MyFace[lstFace.SelectedIndex].ID].myTexture.Size.X - picFace.Height;
            hFaceScroll.Maximum = (int)Editor.Instance.curGame.GM.myResource[Editor.Instance.curGame.AM.MyFace[lstFace.SelectedIndex].ID].myTexture.Size.Y - picFace.Width;
            
        }

        private void vTilesetScroll_Scroll(object sender, ScrollEventArgs e)
        {
            tv.yOffSet = vTilesetScroll.Value;
            tv.UpdateView();
        }

        private void buttAddTileset_Click(object sender, EventArgs e)
        {
            NewTileset nt = new NewTileset();
            nt.ShowDialog();
        }

        private void TabGraphic_Click(object sender, EventArgs e)
        {
            tv.yOffSet = vTilesetScroll.Value;
            tv.UpdateView();
        }

        private void buttModifyTileset_Click(object sender, EventArgs e)
        {
            if (Editor.Instance.curGame.TM.myTileset.Count == 0)
                return;

            EditTileset et = new EditTileset(Editor.Instance.curGame.TM.myTileset[lstTileset.SelectedIndex]);
            et.ShowDialog();
        }

        private void hTilesetScroll_Scroll(object sender, ScrollEventArgs e)
        {
            tv.xOffSet = hTilesetScroll.Value;
            tv.UpdateView();
        }

        private void buttDelete_Click(object sender, EventArgs e)
        {
            if (Editor.Instance.curGame.TM.myTileset.Count == 0)
                return;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this tileset?", "Delete Tileset?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                Editor.Instance.curGame.TM.myTileset.RemoveAt(lstTileset.SelectedIndex);
                RefreshTilesetDatabase();

                Editor.Instance.ChangeMade = true;
                Editor.Instance.UpdateTitle();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
                return;
            }
        }

        private void GraphicDatabase_Load(object sender, EventArgs e)
        {

        }

        private void grpTilesetProperty_Enter(object sender, EventArgs e)
        {

        }

        private void lstTileset_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTilesetDatabase();
        }

        private void lstSprite_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSpriteDatabase();
        }

        private void buttAddSprite_Click(object sender, EventArgs e)
        {
            NewSprites ns = new NewSprites();
            ns.ShowDialog();
        }

        private void hSpriteScroll_Scroll(object sender, ScrollEventArgs e)
        {
            vs.UpdateView(hSpriteScroll.Value, vSpriteScroll.Value);
            vs.Render();
        }

        private void vSpriteScroll_Scroll(object sender, ScrollEventArgs e)
        {
            vs.UpdateView(hSpriteScroll.Value, vSpriteScroll.Value);
            vs.Render();
        }

        public void AnimateSprite()
        {
            vas.Render();
        }

        private void tmrRefresher_Tick(object sender, EventArgs e)
        {
            if (Editor.Instance.curGame.AM.MySprite.Count == 0)
                return;

            AnimateSprite();
        }

        private void lstFace_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFaceDatabase();
        }

        private void buttAddFace_Click(object sender, EventArgs e)
        {

        }

        private void hFaceScroll_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
