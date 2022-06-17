using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BisCarePosEdition
{
    public partial class Store_Operations : Form
    {
        public Store_Operations()
        {
            InitializeComponent();
        }
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }
        public void ApplyTheme()
        {
            this.BackColor = Color.FromArgb(Convert.ToInt32(Theme.FormColor));
            var G = GetAll(this, typeof(GroupBox));
            foreach (GroupBox gb in G)
            {
                gb.ForeColor = Color.FromArgb(Convert.ToInt32(Theme.LblForeColor));
            }
            var b = GetAll(this, typeof(Button));
            foreach (Button cb in b)
            {
                if (Theme.FlatStyle == "Flat")
                {
                    cb.FlatStyle = FlatStyle.Flat;
                }
                if (Theme.FlatStyle == "Standard")
                {
                    cb.FlatStyle = FlatStyle.Standard;
                }
                if (Theme.FlatStyle == "Pop up")
                {
                    cb.FlatStyle = FlatStyle.Popup;
                }
                if (Theme.FlatStyle == "System")
                {
                    cb.FlatStyle = FlatStyle.System;
                }
                cb.BackColor = Color.FromArgb(Convert.ToInt32(Theme.BtnBackColor));
                cb.ForeColor = Color.FromArgb(Convert.ToInt32(Theme.BtnForeColor));
                cb.FlatAppearance.MouseOverBackColor = Color.FromArgb(Convert.ToInt32(Theme.BtnMouseOver));

            }
            var lbl = GetAll(this, typeof(Label));
            foreach (Label labl in lbl)
            {
                labl.ForeColor = Color.FromArgb(Convert.ToInt32(Theme.LblForeColor));
            }
            var gv = GetAll(this, typeof(DataGridView));
            foreach (DataGridView dgv in gv)
            {
                dgv.BackgroundColor = Color.FromArgb(Convert.ToInt32(Theme.DgvBackColor));
            }
        }
        Codebehind ObjCode = new Codebehind();
        private void Store_Operations_Load(object sender, EventArgs e)
        {
            cmb_store.Items.Add("Select One");
            cmb_store.Items.Add("Open");
            cmb_store.Items.Add("Close");
            cmb_store.SelectedIndex = 0;
            ApplyTheme();
        }
        int counterid;
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (cmb_store.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select A Store Status");
                cmb_store.Focus();
                return;
            }
            else
            {
                DataSet ds = new DataSet();
                string message = "";
                //if (globalvariable.designation.ToUpper().ToString() == "ADMIN")
                //{
                    ds = ObjCode.InsertStoreOpenNCloed(globalvariable.userid.ToString(), Convert.ToDateTime(DateTime.Now), Convert.ToDateTime(globalvariable.StoreDate), cmb_store.SelectedItem.ToString(), "insert");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        if (ds.Tables[0].Rows[0]["msg"].ToString().Contains("Store Already Close"))
                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString() + ". Please Open the Store", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (ds.Tables[0].Rows[0]["msg"].ToString().Contains("Store Already Open"))
                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString() + ". Please Close the Store", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (ds.Tables[0].Rows[0]["msg"].ToString() == "UserIdCounterId")
                        {
                            if (ds.Tables[1].Rows.Count > 0)
                            {
                                // message = "      UserName           CounterId        StoreDate " + Environment.NewLine;
                                for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                                    message += ds.Tables[1].Rows[i]["username"].ToString() + "      " + ds.Tables[1].Rows[i]["counter_id"].ToString() + "     " + Convert.ToDateTime(ds.Tables[1].Rows[i]["LoginDate"].ToString()).ToShortDateString() + "  " + Environment.NewLine;
                                DialogResult dr = MessageBox.Show(message + "  " + Environment.NewLine + "Do You Wish to SignOut All Counters....", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (dr == DialogResult.Yes)
                                {
                                    counterid = Convert.ToInt32(File.ReadAllText("counter.txt"));
                                
                                    for (int i = 0; i < ds.Tables[1].Rows.Count; i++) 
                                    ObjCode.updatelogin(ds.Tables[1].Rows[i]["user_id"].ToString(), DateTime.Now, 
                                        //Convert.ToDateTime(ds.Tables[1].Rows[i]["LoginDate"].ToString())
                                      Convert.ToDateTime(globalvariable.StoreDate), counterid, "changestatus");
                                    MessageBox.Show("All The Counters Are Closed...! Now You Can Close The Store...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        else
                        {
                            if (ds.Tables[1].Rows.Count > 0)
                                globalvariable.StoreDate = ds.Tables[1].Rows[0]["Date"].ToString();
                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                //}
                //else
                //    MessageBox.Show("You Don't Have the Rights To Open/Close The Store ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
