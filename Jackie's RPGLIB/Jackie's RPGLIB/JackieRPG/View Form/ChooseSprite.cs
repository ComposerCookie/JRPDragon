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
    public partial class ChooseSprite : Form
    {
        CurrencyManager cm;
        ViewSprite vs;
        Actor _actor;

        public ChooseSprite(Actor actor)
        {
            InitializeComponent();

            _actor = actor;
            vs = new ViewSprite(picSprite.Handle);

            lstSprite.DataSource = Editor.Instance.curGame.AM.MySprite;
            lstSprite.DisplayMember = "Name";

            cm = (CurrencyManager)BindingContext[Editor.Instance.curGame.AM.MySprite];
            RefreshDatabase();
        }

        public void RefreshDatabase()
        {
            if (Editor.Instance.curGame.AM.MySprite.Count == 0)
                return;

            Actor _actor = new Actor();
            _actor.Sprite = lstSprite.SelectedIndex;

            vs.ChangeActor(_actor);

            vs.Render();
        }

        private void lstSprite_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _actor.Sprite = lstSprite.SelectedIndex;
            Close();
        }
    }
}
