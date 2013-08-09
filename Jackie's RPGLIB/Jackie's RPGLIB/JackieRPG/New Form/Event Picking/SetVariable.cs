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
    public partial class SetVariable : Form
    {
        List<Event> _toAdd;
        ViewEvent _forRefresh;

        public SetVariable(List<Event> toadd, ViewEvent toRefresh)
        {
            InitializeComponent();

            _toAdd = toadd;
            _forRefresh = toRefresh;

            lstVariable.DataSource = Editor.Instance.curGame.MyVariable;
            lstVariable.DisplayMember = "Name";

            lstVariable.Refresh();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Jackie_s_RPGLIB.Database.Functional.SetVariable sv = new Jackie_s_RPGLIB.Database.Functional.SetVariable();
            sv.Variable = lstVariable.SelectedIndex;
            sv.Value = int.Parse(txtValue.Text);

            if (rdbSet.Checked == true)
                sv.ChangeType = 0;
            else if (rdbAdd.Checked == true)
                sv.ChangeType = 1;
            else if (rdbSub.Checked == true)
                sv.ChangeType = 2;
            else if (rdbMul.Checked == true)
                sv.ChangeType = 3;
            else if (rdbDiv.Checked == true)
                sv.ChangeType = 4;
            else if (rdbRem.Checked == true)
                sv.ChangeType = 5;

            _toAdd.Add(sv);
            _forRefresh.RefreshTreeView();
        }
    }
}
