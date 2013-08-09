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
    public partial class NewConditioner : Form
    {
        List<Event> _toAdd;
        ViewEvent _forRefresh;

        public NewConditioner(List<Event> toadd, ViewEvent forRefresh)
        {
            InitializeComponent();
            _toAdd = toadd;
            _forRefresh = forRefresh;

            lstSwitch.DataSource = Editor.Instance.curGame.MySwitch;
            lstVariable.DataSource = Editor.Instance.curGame.MyVariable;
            lstSwitch.DisplayMember = "Name";
            lstVariable.DisplayMember = "Name";
        }

        public void HideAll()
        {
            lblReqMap.Visible = false;
            lblReqX.Visible = false;
            lblReqY.Visible = false;
            txtReqMap.Visible = false;
            txtReqX.Visible = false;
            txtReqY.Visible = false;

            lblRequiredVariable.Visible = false;
            lblReqVarValue.Visible = false;
            lstVariable.Visible = false;
            txtReqVarValue.Visible = false;

            lblReqSwitch.Visible = false;
            lblReqSwiValue.Visible = false;
            lstSwitch.Visible = false;
            cmbSwitchValue.Visible = false;
        }

        private void chkConditionerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (chkConditionerType.SelectedIndex)
            {
                case 0:
                    HideAll();
                    lblReqMap.Visible = true;
                    lblReqX.Visible = true;
                    lblReqY.Visible = true;
                    txtReqMap.Visible = true;
                    txtReqX.Visible = true;
                    txtReqY.Visible = true;
                    break;

                case 1:
                    HideAll();
                    lblRequiredVariable.Visible = true;
                    lblReqVarValue.Visible = true;
                    lstVariable.Visible = true;
                    txtReqVarValue.Visible = true;
                    break;

                case 2:
                    HideAll();
                    lblReqSwitch.Visible = true;
                    lblReqSwiValue.Visible = true;
                    lstSwitch.Visible = true;
                    cmbSwitchValue.Visible = true;
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            switch (chkConditionerType.SelectedIndex)
            {
                case 0:
                    ConditionerLoc cl = new ConditionerLoc();
                    cl.ReqMap = int.Parse(txtReqMap.Text);
                    cl.ReqX = int.Parse(txtReqX.Text);
                    cl.ReqY = int.Parse(txtReqY.Text);

                    _toAdd.Add(cl);
                    _forRefresh.RefreshTreeView();
                    break;
                case 1:
                    ConditionerVariable cv = new ConditionerVariable();
                    cv.ReqVariable = lstVariable.SelectedIndex;
                    cv.ReqValue = int.Parse(txtReqVarValue.Text);

                    _toAdd.Add(cv);
                    _forRefresh.RefreshTreeView();
                    break;

                case 2:
                    ConditionerSwitch cs = new ConditionerSwitch();
                    cs.ReqSwitch = lstSwitch.SelectedIndex;
                    cs.ReqValue = (cmbSwitchValue.SelectedIndex == 0) ? true : false;

                    _toAdd.Add(cs);
                    _forRefresh.RefreshTreeView();
                    break;
            }

            Close();
        }

    }
}
