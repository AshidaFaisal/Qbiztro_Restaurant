using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace BisCarePosEdition
{
    public partial class UserAccountType : Form
    {
        public UserAccountType()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
        int f = 0;
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        public void clear()
        {
            txt_remarks.Text = string.Empty;
            txt_usertype.Text = string.Empty;

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
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
        private void UserAccountType_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
            DataTable dt1 = new DataTable();
            dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "UserAccountType");
            SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
            UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
            DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();

            this.ActiveControl = txt_usertype;
            cmb_usertype.Enabled = false;
            DataSet ds = obj.Getusertype();
            cmb_usertype.DataSource = ds.Tables[0];
            cmb_usertype.DisplayMember = "UserAcc_type";
            cmb_usertype.ValueMember = "UserAcc_id";
            DataRow dr = ds.Tables[0].NewRow();
            dr["UserAcc_type"] = "--Select One--";
            dr["UserAcc_id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cmb_usertype.SelectedIndex = 0;
            f = 1;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void bttn_save_Click(object sender, EventArgs e)
        {
            try
            {
            if (rb_new.Checked == true)
            {

                if (SaveStatus == "1")
                {
                    if (txt_usertype.Text != "")
                    {
                        string msg = obj.insertuseracctype(txt_usertype.Text, txt_remarks.Text, "", 1);
                        if (msg == "Account Type Already Exists")
                        {
                            MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //obj.SaveWindow(DateTime.Now, "UserAccountType", File.ReadAllText("user.txt"), "Save");
                        }
                        else
                        MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rb_new.Checked = true;
                        txt_usertype.Focus();
                    }
                    else if (txt_usertype.Text == "")
                    {
                        MessageBox.Show("Please Enter User Account Type", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_usertype.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("You Do Not Have The Permission To Save User Account Type", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (rb_edit.Checked == true)
                {
                    if (UpdateStatus == "1")
                    {
                        if (cmb_usertype.SelectedIndex > 0)
                        {
                            string msg = obj.insertuseracctype(txt_usertype.Text, txt_remarks.Text, cmb_usertype.SelectedValue.ToString(), 2);
                            //obj.SaveWindow(DateTime.Now, "UserAccountType", File.ReadAllText("user.txt"), "Update");
                            MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                        }
                        else
                        {
                            MessageBox.Show("Please Select Account Type", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cmb_usertype.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You Do Not Have The Permission To Update User Account Type", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            DataSet ds = obj.Getusertype();
            cmb_usertype.DataSource = ds.Tables[0];
            cmb_usertype.DisplayMember = "UserAcc_type";
            cmb_usertype.ValueMember = "UserAcc_id";
            DataRow dr = ds.Tables[0].NewRow();
            dr["UserAcc_type"] = "--Select One--";
            dr["UserAcc_id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cmb_usertype.SelectedIndex = 0;
            clear();
            rb_new.Checked = true;
            txt_usertype.Focus();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void bttn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rb_new_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            if (rb_new.Checked == true)
            {
                cmb_usertype.Enabled = false;
                clear();
                txt_usertype.Focus();
            }
            cmb_usertype.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void rb_edit_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            if (rb_edit.Checked == true)
            {
                cmb_usertype.Enabled = false;
                DataSet ds = obj.Getusertype();
                cmb_usertype.DataSource = ds.Tables[0];
                cmb_usertype.DisplayMember = "UserAcc_type";
                cmb_usertype.ValueMember = "UserAcc_id";
                cmb_usertype.Enabled = true;
                DataRow dr = ds.Tables[0].NewRow();
                dr["UserAcc_type"] = "--Select One--";
                dr["UserAcc_id"] = "0";
                ds.Tables[0].Rows.InsertAt(dr, 0);
                cmb_usertype.SelectedIndex = 0;
                clear();
                cmb_usertype.Focus();
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cmb_usertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            if (f == 1)
            {
                if (Convert.ToDouble(cmb_usertype.SelectedValue) > 0)
                {
                    DataTable dt = obj.Selectusertype(cmb_usertype.SelectedValue.ToString());
                    if (dt.Rows.Count > 0)
                    {
                        txt_usertype.Text = dt.Rows[0]["UserAcc_type"].ToString();
                        txt_remarks.Text = dt.Rows[0]["Remarks"].ToString();
                    }
                }
                else
                {
                    txt_remarks.Text = "";
                    txt_usertype.Text = "";
                }
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cmb_usertype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_usertype.Focus();
            }
        }

        private void txt_usertype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_remarks.Focus();
            }
        }

        private void txt_remarks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bttn_save.Focus();
            }
        }
        int k = 0;
        private void bttn_save_Paint(object sender, PaintEventArgs e)
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

        private void bttn_save_MouseEnter(object sender, EventArgs e)
        {
            k = 1;
            bttn_save.Paint += new System.Windows.Forms.PaintEventHandler(this.bttn_save_Paint);
        }

        private void bttn_save_MouseLeave(object sender, EventArgs e)
        {
            k = 0;
            bttn_save.Paint += new System.Windows.Forms.PaintEventHandler(this.bttn_save_Paint);
        }
    }
}
