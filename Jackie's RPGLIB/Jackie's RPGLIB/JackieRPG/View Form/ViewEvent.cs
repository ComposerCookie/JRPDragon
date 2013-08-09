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

//AshtonsBoutique

namespace JackieRPG
{
    public partial class ViewEvent : Form
    {
        List<Event> _list;

        public ViewEvent(List<Event> list)
        {
            InitializeComponent();
            _list = list;
            RefreshTreeView();
        }

        public ViewEvent()
        {
            InitializeComponent();
            _list = new List<Event>();
            RefreshTreeView();
        }

        public void AddEventToNode(TreeNode t, Event e)
        {
            TreeNode addIf = new TreeNode();
            TreeNode addElse = new TreeNode();

            string[] _operation = new string[6]{"Set", "Add", "Sub", "Mul", "Div", "Rem"};
            string[] _bool = new string[3] { "True", "False", "Revert" };

            switch (e.Type)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    Warp w = e as Warp;
                    TreeNode warp = new TreeNode("Warp: (" + w.WarpMap + ", " + w.WarpX + ", " + w.WarpY + ")");
                    t.Nodes.Add(warp);
                    warp.Tag = w;
                    break;
                case 3:
                    ConditionerLoc cl = e as ConditionerLoc;
                    TreeNode conditionerloc = new TreeNode("Conditioner (Loc): (" + cl.ReqMap + ", " + cl.ReqX + ", " + cl.ReqY + ")");
                    conditionerloc.Tag = cl;

                    TreeNode clIf = new TreeNode("If: ");
                    clIf.Name = "If";
                    clIf.Tag = cl.If;
                    foreach (Event me in cl.If)
                        AddEventToNode(clIf, me);
                    addIf = new TreeNode("Add");
                    addIf.Name = "AddIf";
                    addIf.Tag = cl;
                    clIf.Nodes.Add(addIf);
                    TreeNode clElse = new TreeNode("Else: ");
                    clElse.Name = "Else";
                    clElse.Tag = cl.Else;
                    foreach (Event me in cl.Else)
                        AddEventToNode(clElse, me);
                    addElse = new TreeNode("Add");
                    addElse.Name = "AddElse";
                    addElse.Tag = cl;
                    clElse.Nodes.Add(addElse);
                    
                    conditionerloc.Nodes.Add(clIf);
                    conditionerloc.Nodes.Add(clElse);

                    t.Nodes.Add(conditionerloc);
                    break;

                case 4:
                    ConditionerVariable cv = e as ConditionerVariable;
                    TreeNode conditionervariable = new TreeNode("Conditioner (Variable): " + cv.ReqVariable + "-" + Editor.Instance.curGame.MyVariable[cv.ReqVariable].Name + ": " + cv.ReqValue);
                    conditionervariable.Tag = cv;

                    TreeNode cvIf = new TreeNode("If: ");
                    cvIf.Name = "If";
                    cvIf.Tag = cv.If;

                    foreach (Event me in cv.If)
                        AddEventToNode(cvIf, me);
                    addIf = new TreeNode("Add:");
                    addIf.Name = "AddIf";
                    addIf.Tag = cv;
                    cvIf.Nodes.Add(addIf);
                    TreeNode cvElse = new TreeNode("Else: ");
                    cvElse.Name = "Else";
                    cvElse.Tag = cv.Else;
                    foreach (Event me in cv.Else)
                        AddEventToNode(cvElse, me);
                    addElse = new TreeNode("Add");
                    addElse.Name = "AddElse";
                    addElse.Tag = cv;
                    cvElse.Nodes.Add(addElse);
                    
                    conditionervariable.Nodes.Add(cvIf);
                    conditionervariable.Nodes.Add(cvElse);

                    t.Nodes.Add(conditionervariable);
                    break;

                case 5:
                    ConditionerSwitch cs = e as ConditionerSwitch;
                    TreeNode conditionerswitch = new TreeNode("Conditioner (Switch): " + cs.ReqSwitch + "-" + Editor.Instance.curGame.MySwitch[cs.ReqSwitch].Name + ": " + cs.ReqValue.ToString());
                    conditionerswitch.Tag = cs;

                    TreeNode csIf = new TreeNode("If: ");
                    csIf.Name = "If";
                    csIf.Tag = cs.If;

                    foreach (Event me in cs.If)
                        AddEventToNode(csIf, me);
                    addIf = new TreeNode("Add:");
                    addIf.Name = "AddIf";
                    addIf.Tag = cs;
                    csIf.Nodes.Add(addIf);
                    TreeNode csElse = new TreeNode("Else: ");
                    csElse.Name = "Else";
                    csElse.Tag = cs.Else;
                    foreach (Event me in cs.Else)
                        AddEventToNode(csElse, me);
                    addElse = new TreeNode("Add");
                    addElse.Name = "AddElse";
                    addElse.Tag = cs;
                    csElse.Nodes.Add(addElse);
                    
                    conditionerswitch.Nodes.Add(csIf);
                    conditionerswitch.Nodes.Add(csElse);

                    t.Nodes.Add(conditionerswitch);
                    break;

                case 6:
                    Jackie_s_RPGLIB.Database.Functional.SetSwitch ss = e as Jackie_s_RPGLIB.Database.Functional.SetSwitch;
                    
                    TreeNode setswitch = new TreeNode("Set Switch: " + ss.Switch + "-" + Editor.Instance.curGame.MySwitch[ss.Switch].Name + ": " + ss.Value + ", " + _bool[ss.ChangeType]);
                    t.Nodes.Add(setswitch);
                    setswitch.Tag = ss;

                    break;
                case 7:
                    Jackie_s_RPGLIB.Database.Functional.SetVariable sv = e as Jackie_s_RPGLIB.Database.Functional.SetVariable;

                    TreeNode setvariable = new TreeNode("Set Variable: " + sv.Variable + "-" + Editor.Instance.curGame.MyVariable[sv.Variable].Name + ": " + sv.Value + ", " + _operation[sv.ChangeType]);
                    t.Nodes.Add(setvariable);
                    setvariable.Tag = sv;

                    break;
            }

        }

        public void AddEventToNode(Event e)
        {
            string[] _operation = new string[6] { "Set", "Add", "Sub", "Mul", "Div", "Rem" };
            string[] _bool = new string[3] { "True", "False", "Revert" };

            switch (e.Type)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    Warp w = e as Warp;
                    TreeNode warp = new TreeNode("Warp: (" + w.WarpMap + ", " + w.WarpX + ", " + w.WarpY + ")");
                    trvEvent.Nodes.Add(warp);
                    warp.Tag = w;
                    break;
                case 3:
                    ConditionerLoc cl = e as ConditionerLoc;
                    TreeNode conditionerloc = new TreeNode("Conditioner (Loc): (" + cl.ReqMap + ", " + cl.ReqX + ", " + cl.ReqY + ")");
                    conditionerloc.Tag = cl;

                    TreeNode clIf = new TreeNode("If: ");
                    clIf.Name = "If";
                    clIf.Tag = cl.If;
                    foreach (Event me in cl.If)
                        AddEventToNode(clIf, me);
                    TreeNode addIf = new TreeNode("Add");
                    addIf.Name = "AddIf";
                    addIf.Tag = cl;
                    clIf.Nodes.Add(addIf);
                    TreeNode clElse = new TreeNode("Else: ");
                    clElse.Name = "Else";
                    clElse.Tag = cl.Else;
                    foreach (Event me in cl.Else)
                        AddEventToNode(clElse, me);
                    TreeNode addElse = new TreeNode("Add");
                    addElse.Name = "AddElse";
                    addElse.Tag = cl;
                    clElse.Nodes.Add(addElse);

                    conditionerloc.Nodes.Add(clIf);
                    conditionerloc.Nodes.Add(clElse);

                    trvEvent.Nodes.Add(conditionerloc);
                    break;

                case 4:
                    ConditionerVariable cv = e as ConditionerVariable;
                    TreeNode conditionervariable = new TreeNode("Conditioner (Variable): " + cv.ReqVariable + "-" + Editor.Instance.curGame.MyVariable[cv.ReqVariable].Name + ": " + cv.ReqValue);
                    conditionervariable.Tag = cv;

                    TreeNode cvIf = new TreeNode("If: ");
                    cvIf.Name = "If";
                    cvIf.Tag = cv.If;

                    foreach (Event me in cv.If)
                        AddEventToNode(cvIf, me);
                    addIf = new TreeNode("Add:");
                    addIf.Name = "AddIf";
                    addIf.Tag = cv;
                    cvIf.Nodes.Add(addIf);
                    TreeNode cvElse = new TreeNode("Else: ");
                    cvElse.Name = "Else";
                    cvElse.Tag = cv.Else;
                    foreach (Event me in cv.Else)
                        AddEventToNode(cvElse, me);
                    addElse = new TreeNode("Add");
                    addElse.Name = "AddElse";
                    addElse.Tag = cv;
                    cvElse.Nodes.Add(addElse);

                    conditionervariable.Nodes.Add(cvIf);
                    conditionervariable.Nodes.Add(cvElse);

                    trvEvent.Nodes.Add(conditionervariable);
                    break;

                case 5:
                    ConditionerSwitch cs = e as ConditionerSwitch;
                    TreeNode conditionerswitch = new TreeNode("Conditioner (Switch): " + cs.ReqSwitch + "-" + Editor.Instance.curGame.MySwitch[cs.ReqSwitch].Name + ": " + cs.ReqValue.ToString());
                    conditionerswitch.Tag = cs;

                    TreeNode csIf = new TreeNode("If: ");
                    csIf.Name = "If";
                    csIf.Tag = cs.If;

                    foreach (Event me in cs.If)
                        AddEventToNode(csIf, me);
                    addIf = new TreeNode("Add:");
                    addIf.Name = "AddIf";
                    addIf.Tag = cs;
                    csIf.Nodes.Add(addIf);
                    TreeNode csElse = new TreeNode("Else: ");
                    csElse.Name = "Else";
                    csElse.Tag = cs.Else;
                    foreach (Event me in cs.Else)
                        AddEventToNode(csElse, me);
                    addElse = new TreeNode("Add");
                    addElse.Name = "AddElse";
                    addElse.Tag = cs;
                    csElse.Nodes.Add(addElse);

                    conditionerswitch.Nodes.Add(csIf);
                    conditionerswitch.Nodes.Add(csElse);

                    trvEvent.Nodes.Add(conditionerswitch);
                    break;

                case 6:
                    Jackie_s_RPGLIB.Database.Functional.SetSwitch ss = e as Jackie_s_RPGLIB.Database.Functional.SetSwitch;

                    TreeNode setswitch = new TreeNode("Set Switch: " + ss.Switch + "-" + Editor.Instance.curGame.MySwitch[ss.Switch].Name + ": " + ss.Value + ", " + _bool[ss.ChangeType]);
                    trvEvent.Nodes.Add(setswitch);
                    setswitch.Tag = ss;

                    break;
                case 7:
                    Jackie_s_RPGLIB.Database.Functional.SetVariable sv = e as Jackie_s_RPGLIB.Database.Functional.SetVariable;

                    TreeNode setvariable = new TreeNode("Set Variable: " + sv.Variable + "-" + Editor.Instance.curGame.MyVariable[sv.Variable].Name + ": " + sv.Value + ", " + _operation[sv.ChangeType]);
                    trvEvent.Nodes.Add(setvariable);
                    setvariable.Tag = sv;

                    break;
            }
        }

        public void RefreshTreeView()
        {
            trvEvent.Nodes.Clear();

            foreach (Event e in _list)
            {
                AddEventToNode(e);
            }


            TreeNode addNew = new TreeNode("Add");
            addNew.Name = "Add";
            trvEvent.Nodes.Add(addNew);

            trvEvent.ExpandAll();

        }

        private void trvEvent_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void trvEvent_DoubleClick(object sender, EventArgs e)
        {

            

        }

        private void trvEvent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            trvEvent.SelectedNode = trvEvent.GetNodeAt(e.X, e.Y);

            if (e.Button == MouseButtons.Right)
                return;

            if (trvEvent.SelectedNode.Name.Equals("Add"))
            {
                NewEvent ne = new NewEvent(_list, this);
                ne.ShowDialog();
            }

            else
            {
                Event ev = (Event)trvEvent.SelectedNode.Tag;

                if (ev == null)
                    return;
                switch (ev.Type)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        ConditionerLoc cl = ev as ConditionerLoc;
                        if (trvEvent.SelectedNode.Name.Equals("If"))
                        {
                            //NewEvent ne = new NewEvent(cl.If);
                            //ne.ShowDialog();
                        }
                        else if (trvEvent.SelectedNode.Name.Equals("AddIf"))
                        {
                            NewEvent ne = new NewEvent(cl.If, this);
                            ne.ShowDialog();
                        }
                        else if (trvEvent.SelectedNode.Name.Equals("AddElse"))
                        {
                            NewEvent ne = new NewEvent(cl.Else, this);
                            ne.ShowDialog();
                        }
                        break;
                    case 4:
                        ConditionerVariable cv = ev as ConditionerVariable;
                        if (trvEvent.SelectedNode.Name.Equals("If"))
                        {
                            //NewEvent ne = new NewEvent(cl.If);
                            //ne.ShowDialog();
                        }
                        else if (trvEvent.SelectedNode.Name.Equals("AddIf"))
                        {
                            NewEvent ne = new NewEvent(cv.If, this);
                            ne.ShowDialog();
                        }
                        else if (trvEvent.SelectedNode.Name.Equals("AddElse"))
                        {
                            NewEvent ne = new NewEvent(cv.Else, this);
                            ne.ShowDialog();
                        }
                        break;
                    case 5:
                        ConditionerSwitch cs = ev as ConditionerSwitch;
                        if (trvEvent.SelectedNode.Name.Equals("If"))
                        {
                            //NewEvent ne = new NewEvent(cl.If);
                            //ne.ShowDialog();
                        }
                        else if (trvEvent.SelectedNode.Name.Equals("AddIf"))
                        {
                            NewEvent ne = new NewEvent(cs.If, this);
                            ne.ShowDialog();
                        }
                        else if (trvEvent.SelectedNode.Name.Equals("AddElse"))
                        {
                            NewEvent ne = new NewEvent(cs.Else, this);
                            ne.ShowDialog();
                        }
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                }
            }

            TreeNode tn = new TreeNode();

        }

        private void trvEvent_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Event eve = new Event();
                List<Event> lsteve = new List<Event>();

                trvEvent.SelectedNode = trvEvent.GetNodeAt(e.X, e.Y);

                if (trvEvent.SelectedNode.Tag is Event)
                {
                    eve = (Event)trvEvent.SelectedNode.Tag;
                    eventContextMenuStrip1.Show(Cursor.Position);
                }
                else if (trvEvent.SelectedNode.Tag is List<Event>)
                {
                    lsteve = (List<Event>)trvEvent.SelectedNode.Tag;
                }
                    
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Event eve = (Event)trvEvent.SelectedNode.Tag;

            if (eve == null)
                return;

            if (trvEvent.SelectedNode.Parent == null)
            {
                _list.Remove(eve);
                RefreshTreeView();
            }
            else
            {
                List<Event> list = (List<Event>)trvEvent.SelectedNode.Parent.Tag;
                if (list == null)
                    return;

                list.Remove(eve);
                RefreshTreeView();
            }
        }
    }
}
