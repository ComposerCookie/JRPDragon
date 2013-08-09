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
    public partial class ViewVariable : Form
    {
        CurrencyManager cm;

        public ViewVariable()
        {
            InitializeComponent();

            lstVariable.DataSource = Editor.Instance.curGame.MyVariable;
            lstVariable.DisplayMember = "Name";

            cm = (CurrencyManager)BindingContext[Editor.Instance.curGame.MyVariable];

            RefreshDatabase();
        }

        public void RefreshDatabase()
        {
            if (Editor.Instance.curGame.MyVariable.Count == 0)
                return;

            cm.Refresh();
        }

        private void buttAdd_Click(object sender, EventArgs e)
        {
            NewVariable nv = new NewVariable();
            nv.ShowDialog();
        }

        private void lstVariable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
