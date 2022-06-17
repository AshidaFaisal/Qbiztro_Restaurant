using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace BisCarePosEdition
{
    public partial class Formdynamic : Form
    {
        Codebehind objcode = new Codebehind();
        public Formdynamic()
        {
            InitializeComponent();
        }

        private void Formdynamic_Load(object sender, EventArgs e)
        {
            Theme ObjTheme = new Theme();
            ObjTheme.setTheme();
            ApplyTheme();
            SplitContainer splitContainerDetails = new SplitContainer();
            splitContainerDetails.Panel2.Controls.Clear();
            string user=File.ReadAllText("lastlogin.txt");
            if (user== "admin")
            {


                TableLayoutPanel tblypanelDetailsCenter = new System.Windows.Forms.TableLayoutPanel();
                splitContainerDetails.Panel2.Controls.Add(tblypanelDetailsCenter);
                tblypanelDetailsCenter.AutoSize = true;
                tblypanelDetailsCenter.ColumnCount = 6;
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.Dock = System.Windows.Forms.DockStyle.Top;
                tblypanelDetailsCenter.Margin = new System.Windows.Forms.Padding(0);
                tblypanelDetailsCenter.Name = "tblypanelDetailsCenter";
                tblypanelDetailsCenter.Controls.Clear();
                DataSet dtmasters = new DataSet();
                dtmasters = objcode.getparents();
                tblypanelDetailsCenter.RowCount = (dtmasters.Tables[0].Rows.Count / 6) + 1;
                for (int i = 0; i < tblypanelDetailsCenter.RowCount; i++)
                {
                    tblypanelDetailsCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, Convert.ToInt32(70)));
                }
                int RowNum = 0, ColumnNum = 0;

                for (int i = 0; i < dtmasters.Tables[0].Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        RowNum = 0; ColumnNum = 0;
                    }
                    else if (i == 1)
                    {
                        RowNum = 0;
                        ColumnNum = 1;
                    }
                    else
                    {
                        if (i < 6)
                        {
                            RowNum = 0;
                            ColumnNum = i;
                        }
                        else
                        {
                            RowNum = i / 6;
                            ColumnNum = i % 6;
                        }
                    }
                    Button btnmasters = new Button();
                    btnmasters.Name = "btnparent1" + i.ToString();
                    btnmasters.ForeColor = Color.White;
                    btnmasters.BackColor = Color.FromArgb(0, 85, 85);
                    btnmasters.Text = dtmasters.Tables[0].Rows[0]["ParentName"].ToString();
                    btnmasters.Tag = dtmasters.Tables[0].Rows[0]["ParentId"].ToString();
                   
                    btnmasters.Dock = System.Windows.Forms.DockStyle.Fill;
                   // btnTable1.Click += new System.EventHandler(this.TableBtn_Click);
                    tblypanelDetailsCenter.Controls.Add(btnmasters, ColumnNum, RowNum);
                    
                }
              
            }
            else
            {
                MessageBox.Show("No tables are entered for display", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           }
  
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        DataTable dtKOT, dtKOTTake, dtCounterBill, dtBill;
        int LogoutStat = 0;

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

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
