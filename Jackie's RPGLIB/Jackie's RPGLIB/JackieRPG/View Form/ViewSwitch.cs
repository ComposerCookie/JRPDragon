using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JackieRPG
{
    public partial class ViewSwitch : Form
    {
        CurrencyManager cm;

        public ViewSwitch()
        {
            InitializeComponent();

            lstSwitch.DataSource = Editor.Instance.curGame.MySwitch;
            lstSwitch.DisplayMember = "Name";

            cm = (CurrencyManager)BindingContext[Editor.Instance.curGame.MySwitch];

            RefreshDatabase();
        }

        public void RefreshDatabase()
        {
            if (Editor.Instance.curGame.MySwitch.Count == 0)
                return;

            cm.Refresh();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            NewSwitch ns = new NewSwitch();
            ns.ShowDialog();
        }
    }
}
