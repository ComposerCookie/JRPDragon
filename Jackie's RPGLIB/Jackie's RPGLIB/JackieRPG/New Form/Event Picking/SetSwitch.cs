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
    public partial class SetSwitch : Form
    {
        List<Event> _toAdd;
        ViewEvent _forRefresh;

        public SetSwitch(List<Event> toadd, ViewEvent toRefresh)
        {
            InitializeComponent();
            _toAdd = toadd;
            _forRefresh = toRefresh;

            lstSwitch.DataSource = Editor.Instance.curGame.MySwitch;
            lstSwitch.DisplayMember = "Name";

            lstSwitch.Refresh();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Jackie_s_RPGLIB.Database.Functional.SetSwitch ss = new Jackie_s_RPGLIB.Database.Functional.SetSwitch();
            ss.Switch = lstSwitch.SelectedIndex;

            switch (cmbSwitch.SelectedIndex)
            {
                case 0:
                    ss.Value = true;
                    break;
                case 1:
                    ss.Value = false;
                    break;
                case 2:
                    ss.ChangeType = 2;
                    break;
            }

            _toAdd.Add(ss);
            _forRefresh.RefreshTreeView();
        }
    }
}
