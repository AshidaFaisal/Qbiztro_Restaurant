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
    public partial class Complimentary_Invoice_Report : Form
    {
        public Complimentary_Invoice_Report()
        {
            InitializeComponent();
        }
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }
        Codebehind objcode = new Codebehind();
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
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_viewreport_Click(object sender, EventArgs e)
        {
            if(rd_staff.Checked==true)
            {
                if(cmb_staff.SelectedIndex < 0)
                {
                       MessageBox.Show("Please select a staff...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                    cmb_staff.Focus();
                }
            }
              Form_Complimentary_Invoice_Report fs =new Form_Complimentary_Invoice_Report(dtp_start.Value,dtp_end.Value);
            fs.ShowDialog();
        }

        private void Complimentary_Invoice_Report_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            DataSet ds1 = new DataSet();
            ds1 = objcode.GetempName();
            cmb_staff.DataSource = ds1.Tables[0];
            cmb_staff.DisplayMember = "Name";
            cmb_staff.ValueMember = "Id";
            DataRow drr1 = ds1.Tables[0].NewRow();
            drr1["Name"] = "--Select One--";
            drr1["Id"] = "0";
            ds1.Tables[0].Rows.InsertAt(drr1, 0);
            cmb_staff.SelectedIndex = 0;
        }

        private void rd_staff_CheckedChanged(object sender, EventArgs e)
        {
           if(rd_staff.Checked==true)
           {
               cmb_staff.Enabled=true;
           }
           else
               cmb_staff.Enabled=false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
