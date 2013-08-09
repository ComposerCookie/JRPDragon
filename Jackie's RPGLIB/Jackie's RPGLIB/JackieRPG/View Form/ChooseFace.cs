using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Jackie_s_RPGLIB.Database.Character;

namespace JackieRPG
{
    public partial class ChooseFace : Form
    {
        CurrencyManager cm;
        ViewFace vf;
        Actor _actor;

        public ChooseFace(Actor actor)
        {
            InitializeComponent();

            _actor = actor;
            vf = new ViewFace(picFace.Handle);

            lstFace.DataSource = Editor.Instance.curGame.AM.MyFace;
            lstFace.DisplayMember = "Name";

            cm = (CurrencyManager)BindingContext[Editor.Instance.curGame.AM.MyFace];
            RefreshDatabase();
        }

        public void RefreshDatabase()
        {
            if (Editor.Instance.curGame.AM.MyFace.Count == 0)
                return;

            Actor _actor = new Actor();
            _actor.Sprite = lstFace.SelectedIndex;

            vf.ChangeActor(_actor);

            vf.Render();
        }

        private void lstSprite_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _actor.Face = lstFace.SelectedIndex;
            Close();
        }
    }
}
