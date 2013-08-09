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
    public partial class NewSwitch : Form
    {
        public NewSwitch()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Switch s = new Switch();
            s.Name = txtName.Text;
            Editor.Instance.curGame.MySwitch.Add(s);

            Editor.Instance.viewSwitch.RefreshDatabase();
        }
    }
}
