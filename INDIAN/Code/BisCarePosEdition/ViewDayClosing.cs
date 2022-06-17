using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BisCarePosEdition
{
    public partial class ViewDayClosing : Form
    {
        public ViewDayClosing()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
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
        private void ViewDayClosing_Load(object sender, EventArgs e)
        {
            //ApplyTheme();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0;
            DataTable dt = obj.GetDayClosing(dtp_date.Value);
            if (dt.Rows.Count > 0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                {
                dgv_dayclosing.Rows.Add();
                dgv_dayclosing[0, i].Value = dt.Rows[i]["Denomination"].ToString();
                dgv_dayclosing[1, i].Value = dt.Rows[i]["Number"].ToString();
                dgv_dayclosing[2, i].Value = dt.Rows[i]["TotalAmount"].ToString();
                dgv_dayclosing[3, i].Value = dt.Rows[i]["Date"].ToString();
                total = total + Convert.ToDouble(dt.Rows[i]["TotalAmount"].ToString());
                }
                txt_total.Text = total.ToString("F2");
            }
        }
    }
}
