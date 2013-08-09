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
    public partial class NewVariable : Form
    {
        public NewVariable()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Variable v = new Variable();
            v.Name = txtName.Text;

            Editor.Instance.curGame.MyVariable.Add(v);
            Editor.Instance.viewVariable.RefreshDatabase();
        }
    }
}
