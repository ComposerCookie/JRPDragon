using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Jackie_s_RPGLIB.Database.Functional;

namespace JackieRPG
{
    public partial class NewEvent : Form
    {
        List<Event> _toAdd;
        ViewEvent _forRefresh;

        public NewEvent(List<Event> toadd, ViewEvent forRefresh)
        {
            InitializeComponent();

            _toAdd = toadd;
            _forRefresh = forRefresh;
        }

        private void buttWarp_Click(object sender, EventArgs e)
        {
            NewWarp nw = new NewWarp(_toAdd, _forRefresh);
            nw.ShowDialog();
        }

        private void buttConditioner_Click(object sender, EventArgs e)
        {
            NewConditioner nc = new NewConditioner(_toAdd, _forRefresh);
            nc.ShowDialog();
        }

        private void buttSwitch_Click(object sender, EventArgs e)
        {
            if (Editor.Instance.curGame.MySwitch.Count == 0)
            {
                MessageBox.Show("You need to have atleast 1 switch before you can use this");
                return;
            }

            SetSwitch ss = new SetSwitch(_toAdd, _forRefresh);
            ss.ShowDialog();
        }

        private void buttVariable_Click(object sender, EventArgs e)
        {
            if (Editor.Instance.curGame.MyVariable.Count == 0)
            {
                MessageBox.Show("You need to have atleast 1 variable before you can use this");
                return;
            }

            SetVariable sv = new SetVariable(_toAdd, _forRefresh);
            sv.ShowDialog();
        }

        
    }
}
