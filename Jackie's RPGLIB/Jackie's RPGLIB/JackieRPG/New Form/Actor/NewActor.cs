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
    public partial class NewActor : Form
    {
        Actor _actor;
        ViewFace vf;
        ViewSprite vs;

        public NewActor()
        {
            InitializeComponent();
            _actor = new Actor();
            _actor.Face = -1;
            _actor.Sprite = -1;

            vf = new ViewFace(picFace.Handle);
            vs = new ViewSprite(picSprite.Handle);
            vf.ChangeActor(_actor);
            vs.ChangeActor(_actor);

            tmrRender.Start();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _actor.Name = txtName.Text;
            //_actor.Gender
            _actor.Description = txtDescription.Text;
            _actor.Level = int.Parse(txtBaseLevel.Text);
            //_actor.

            Editor.Instance.curGame.AM.MyActor.Add(_actor);
            Editor.Instance.actorManagerForm.UpdateDatabase();

            Editor.Instance.ChangeMade = true;
            Editor.Instance.UpdateTitle();

            this.Close();
        }

        private void picFace_Click(object sender, EventArgs e)
        {
            ChooseFace cf = new ChooseFace(_actor);
            cf.ShowDialog();
        }

        private void picSprite_Click(object sender, EventArgs e)
        {
            ChooseSprite cs = new ChooseSprite(_actor);
            cs.ShowDialog();
        }

        private void tmrRender_Tick(object sender, EventArgs e)
        {
            if (_actor.Face > -1)
                vf.Render();

            if (_actor.Sprite > -1)
                vs.Render();
        }
    }
}
