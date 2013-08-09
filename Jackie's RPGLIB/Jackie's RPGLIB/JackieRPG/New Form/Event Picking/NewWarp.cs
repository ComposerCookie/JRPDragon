using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Jackie_s_RPGLIB.Database.Functional;
using Jackie_s_RPGLIB.Database.Functional.Map;

namespace JackieRPG
{
    public partial class NewWarp : Form
    {
        List<Event> _toAdd;
        ViewEvent _forRefresh;

        public NewWarp(List<Event> toadd, ViewEvent forRefresh)
        {
            InitializeComponent();
            _toAdd = toadd;
            _forRefresh = forRefresh;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Warp w = new Warp();
            w.WarpMap = int.Parse(txtWarpMap.Text);
            w.WarpX = int.Parse(txtWarpX.Text);
            w.WarpY = int.Parse(txtWarpY.Text);
            _toAdd.Add(w);

            _forRefresh.RefreshTreeView();
            
            Close();
        }
    }
}
