using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;

namespace BisCarePosEdition
{
    public partial class Brand : Form
    {
        public Brand()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }
        int f = 0;
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
        private void Brand_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
                this.ActiveControl = txt_brandname;
                DataSet ds = new DataSet();
                ds = obj.GetBrand();
                cmb_bname.DataSource = ds.Tables[0];
                cmb_bname.DisplayMember = "Name";
                cmb_bname.ValueMember = "Id";
                DataRow dr = ds.Tables[0].NewRow();
                dr["Name"] = "--Select One--";
                dr["Id"] = "0";
                ds.Tables[0].Rows.InsertAt(dr, 0);
                cmb_bname.SelectedIndex = 0;

                Rb_new.Checked = true;
                cmb_bname.Enabled = false;
                f = 1;

                txt_brandname.Focus();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        public void clear()
        {
            txt_brandname.Text = "";
            txt_remarks.Text = "";


        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
            if (Rb_new.Checked == true)
            {
                if (txt_brandname.Text != string.Empty)
                {
                    string msg = obj.InsertBrand(txt_brandname.Text, txt_remarks.Text);
                    if (msg == "This brandname already exists")
                    MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    clear();

                    DataSet ds = new DataSet();
                    ds = obj.GetBrand();
                    cmb_bname.DataSource = ds.Tables[0];
                    cmb_bname.DisplayMember = "Name";
                    cmb_bname.ValueMember = "Id";
                    DataRow dr = ds.Tables[0].NewRow();
                    dr["Name"] = "--Select One--";
                    dr["Id"] = "0";
                    ds.Tables[0].Rows.InsertAt(dr, 0);
                    cmb_bname.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("please enter brand", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_brandname.Focus();
                }
            }
           if(Rb_edit.Checked==true)
            {
                if (cmb_bname.SelectedIndex > 0)
                {
                    string msg = obj.UpdateBrand(txt_brandname.Text, txt_remarks.Text,cmb_bname.SelectedValue.ToString());
                    MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();

                    DataSet ds = new DataSet();
                    ds = obj.GetBrand();
                    cmb_bname.DataSource = ds.Tables[0];
                    cmb_bname.DisplayMember = "Name";
                    cmb_bname.ValueMember = "Id";
                    DataRow dr = ds.Tables[0].NewRow();
                    dr["Name"] = "--Select One--";
                    dr["Id"] = "0";
                    ds.Tables[0].Rows.InsertAt(dr, 0);
                    cmb_bname.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("please select a brand", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_bname.Focus();
                }
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            string msg = obj.DeleteBrand(cmb_bname.SelectedValue.ToString());
            if (cmb_bname.SelectedIndex > 0)
            {
                if (msg == "1")
                {
                    MessageBox.Show("Brand successfully deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    DataSet ds = new DataSet();
                    ds = obj.GetBrand();
                    cmb_bname.DataSource = ds.Tables[0];
                    cmb_bname.DisplayMember = "Name";
                    cmb_bname.ValueMember = "Id";
                    DataRow dr = ds.Tables[0].NewRow();
                    dr["Name"] = "--Select One--";
                    dr["Id"] = "0";
                    ds.Tables[0].Rows.InsertAt(dr, 0);
                    cmb_bname.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Sory,This Brand already in use.So you canot delete it", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a brand", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void Rb_new_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_new.Checked == true)
            {
                cmb_bname.Enabled = false;
                btn_del.Enabled = false;
                txt_brandname.Text = "";
                txt_remarks.Text = "";
                cmb_bname.SelectedIndex = 0;
            }
            else
            {
                cmb_bname.Enabled = true;
                btn_del.Enabled = true;
            }
        }

        private void Rb_edit_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_edit.Checked == true)
            {
                cmb_bname.Enabled = true;
                btn_del.Enabled = true;
                txt_brandname.Text = "";
                txt_remarks.Text = "";
                cmb_bname.SelectedIndex = 0;
            }
            else
            {
                cmb_bname.Enabled = false;
                btn_del.Enabled = false;
            }
        }

        private void cmb_bname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            if (f == 1)
            {
                clear();
                SqlDataReader dr = obj.GetBrandDetail(cmb_bname.SelectedValue.ToString());
                if (dr.Read())
                {
                    txt_brandname.Text = dr[1].ToString();
                    txt_remarks.Text = dr[2].ToString();

                    dr.Close();
                }
            }
            }
 catch (Exception ex)
 {
     File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
 }


        }

        private void cmb_bname_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_bname.DroppedDown)
            {
                cmb_bname.Focus();

            }
        }
        int k = 0;
        private void btn_Save_Paint(object sender, PaintEventArgs e)
        {

        }


        public static GraphicsPath GetRoundedRect(RectangleF r, float radiusX, float radiusY)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.StartFigure();
            r = new RectangleF(r.Left, r.Top, r.Width, r.Height);
            if (radiusX <= 0.0F || radiusY <= 0.0F)
            {
                gp.AddRectangle(r);
            }
            else
            {
                try
                {
                    //arcs work with diameters (radius * 2)
                    PointF d = new PointF(Math.Min(radiusX * 2, r.Width), Math.Min(radiusY * 2, r.Height));
                    gp.AddArc(r.X, r.Y, d.X, d.Y, 180, 90);
                    gp.AddArc(r.Right - d.X, r.Y, d.X - 1, d.Y, 270, 90);
                    gp.AddArc(r.Right - d.X, (r.Bottom) - d.Y - 1, d.X - 1, d.Y, 0, 90);
                    gp.AddArc(r.X, (r.Bottom) - d.Y - 1, d.X - 1, d.Y, 90, 90);
                }
                catch (Exception w)
                {

                }
            }
            gp.CloseFigure();
            return gp;
        }
        public static Color ColorFromHex(string hex)
        {
            if (hex.StartsWith("#"))
                hex = hex.Substring(1);

            if (hex.Length != 6) throw new Exception("Color not valid");

            return Color.FromArgb(
                int.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber),
                int.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber),
                int.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber));
        }

        private void btn_Save_MouseLeave(object sender, EventArgs e)
        {
            k = 0;
            btn_Save.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Save_Paint);
        }

        private void btn_Save_MouseEnter(object sender, EventArgs e)
        {
            k = 1;
            btn_Save.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Save_Paint);
        }

        private void txt_brandname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_bname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_bname.DroppedDown)
            {
                cmb_bname.Focus();

            }
        }
    }
}
