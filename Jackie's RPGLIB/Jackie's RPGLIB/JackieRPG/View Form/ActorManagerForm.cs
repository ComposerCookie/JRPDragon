using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Jackie_s_RPGLIB.Graphic;

namespace JackieRPG
{
    public partial class ActorManagerForm : Form
    {
        CurrencyManager cm;
        ViewAnimateSprite vas;
        ViewFace vf;
        ViewSprite vs;

        public ActorManagerForm()
        {
            InitializeComponent();

            vas = new ViewAnimateSprite(picAnimation.Handle);
            vf = new ViewFace(picFace.Handle);
            vs = new ViewSprite(picSprite.Handle);

            lstActor.DataSource = Editor.Instance.curGame.AM.MyActor;
            lstActor.DisplayMember = "Name";

            cm = (CurrencyManager)BindingContext[Editor.Instance.curGame.AM.MyActor];

            UpdateDatabase();

            tmrAnimationRefresh.Interval = 180;
            tmrAnimationRefresh.Start();

            
        }

        private void lstActor_SelectedIndexChanged(object sender, EventArgs e)
        {
            vf.ChangeActor(Editor.Instance.curGame.AM.MyActor[lstActor.SelectedIndex]);
            vs.ChangeActor(Editor.Instance.curGame.AM.MyActor[lstActor.SelectedIndex]);
            vas.ChangeActor(Editor.Instance.curGame.AM.MyActor[lstActor.SelectedIndex]);

            RefreshDatabase();
        }

        public void UpdateDatabase()
        {
            cm.Refresh();
            RefreshDatabase();
        }

        public void RefreshDatabase()
        {
            if (Editor.Instance.curGame.AM.MyActor.Count == 0)
                return;

            if (Editor.Instance.curGame.AM.MyActor.Count != 0 && lstActor.SelectedIndex < 0)
                lstActor.SelectedIndex = 0;

            txtName.Text = Editor.Instance.curGame.AM.MyActor[lstActor.SelectedIndex].Name;
            txtDescription.Text = Editor.Instance.curGame.AM.MyActor[lstActor.SelectedIndex].Description;
            txtBaseLevel.Text = Editor.Instance.curGame.AM.MyActor[lstActor.SelectedIndex].Level.ToString();

            if (Editor.Instance.curGame.AM.MyActor[lstActor.SelectedIndex].Face > -1)
                vf.Render();

            if (Editor.Instance.curGame.AM.MyActor[lstActor.SelectedIndex].Sprite > -1)
            {
                vs.Render();
                vas.Render();
            }
        }

        public void AnimatedSprite()
        {
            vas.Render();
            vf.Render();
            vs.Render();
        }

        private void picFace_Click(object sender, EventArgs e)
        {
            if (Editor.Instance.curGame.AM.MyActor.Count == 0)
                return;

            ChooseFace cf = new ChooseFace(Editor.Instance.curGame.AM.MyActor[lstActor.SelectedIndex]);
            cf.ShowDialog();

            RefreshDatabase();
        }

        private void picSprite_Click(object sender, EventArgs e)
        {
            if (Editor.Instance.curGame.AM.MyActor.Count == 0)
                return;

            ChooseSprite cs = new ChooseSprite(Editor.Instance.curGame.AM.MyActor[lstActor.SelectedIndex]);
            cs.ShowDialog();

            RefreshDatabase();
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            NewActor _na = new NewActor();
            _na.ShowDialog();
        }

        private void tmrAnimationRefresh_Tick(object sender, EventArgs e)
        {
            AnimatedSprite();
        }
    }
}
