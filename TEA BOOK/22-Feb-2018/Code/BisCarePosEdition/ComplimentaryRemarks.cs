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
    public partial class ComplimentaryRemarks : Form
    {
        public ComplimentaryRemarks()
        {
            InitializeComponent();
        }
        Codebehind objcode = new Codebehind();
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
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string remarks;
        public DialogResult dr;
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (rd_staff.Checked == true)
            {
                if (cmb_staff.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Select A Staff...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_staff.Focus();
                    return;
                }
                else
                {
                    DataTable dts = objcode.GETSTAFFNAME(Convert.ToInt32(cmb_staff.SelectedValue.ToString()));
                    remarks = dts.Rows[0]["Name"].ToString();
                }
            }
            else
            {
                remarks = txt_remarks.Text;
            } 
            dr = DialogResult.OK;
            this.Close();
        }

        private void ComplimentaryRemarks_Load(object sender, EventArgs e)
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
            if (rd_staff.Checked == true)
            {
                cmb_staff.Enabled = true;
                cmb_staff.SelectedIndex = 0;
            }
            else
            {
                cmb_staff.Enabled = false;
                cmb_staff.SelectedIndex = 0;
            }

        }

        private void rd_Others_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_Others.Checked == true)
            {
                txt_remarks.Enabled = true;
                cmb_staff.Enabled = false;
                cmb_staff.SelectedIndex = 0;
            }
            else
            {
                txt_remarks.Enabled = false;
            }  
        }

        private void cmb_staff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
