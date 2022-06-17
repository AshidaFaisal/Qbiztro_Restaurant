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
    public partial class Designation : Form
    {
        public Designation()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
        int f = 0;
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        public void clear()
        {
            txt_designation.Text = string.Empty;
            txt_remarks.Text = string.Empty;

            button1.Enabled = false;
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
        private void Designation_Load(object sender, EventArgs e)
        {
            try
            {
            ApplyTheme();
            DataTable dt1 = new DataTable();
            dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "Designation");
            SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
            UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
            DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();
            this.ActiveControl = txt_designation; ;
            button1.Enabled = false;

            Rb_new.Checked = true;
            DataSet ds = new DataSet();
            ds = obj.GetDesignation();
            Cmb_designame.DataSource = ds.Tables[0];
            Cmb_designame.DisplayMember = "designation_name";
            Cmb_designame.ValueMember = "designation_id";

            DataRow dr = ds.Tables[0].NewRow();
            dr["designation_name"] = "--Select One--";
            dr["designation_id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            Cmb_designame.SelectedIndex = 0;
            f = 1;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


            }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
            if (Rb_new.Checked == true)
            {
                if (SaveStatus == "1")
                {
                    if (txt_designation.Text == string.Empty)
                    {
                        MessageBox.Show("Please Enter Designation", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_designation.Focus();
                    }
                    else
                    {
                        string msg = obj.InsertDesignation(txt_designation.Text, txt_remarks.Text, "", 1);
                        if (msg == "Designation Successfully Saved")
                        {
                            MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           // obj.SaveWindow(DateTime.Now, "Designation", File.ReadAllText("user.txt"), "Save");
                        }
                        else
                        MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Rb_new.Checked = true;
                        txt_designation.Focus();
                    }
                }

                else
                {
                    MessageBox.Show("You Do Not Have The Permission To Save Designation", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                if ((Rb_edit.Checked == true) && (Cmb_designame.SelectedIndex > 0))
                {
                    if (UpdateStatus == "1")
                    {
                        if (txt_designation.Text == string.Empty)
                        {
                            MessageBox.Show("Please Enter Designation", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_designation.Focus();
                        }
                        else
                        {
                            string msg = obj.InsertDesignation(txt_designation.Text, txt_remarks.Text, Cmb_designame.SelectedValue.ToString(), 2);
                            //obj.SaveWindow(DateTime.Now, "Designation", File.ReadAllText("user.txt"), "Update");
                            MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Rb_new.Checked = true;
                            txt_designation.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You Do Not Have The Permission To Update Designation", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Designation", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cmb_designame.Focus();
                    //}
                }
            }
            DataSet ds = new DataSet();
            ds = obj.GetDesignation();
            Cmb_designame.DataSource = ds.Tables[0];
            Cmb_designame.DisplayMember = "designation_name";
            Cmb_designame.ValueMember = "designation_id";

            DataRow dr = ds.Tables[0].NewRow();
            dr["designation_name"] = "--Select One--";
            dr["designation_id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            Cmb_designame.SelectedIndex = 0;
            clear();
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
            if (DeleteStatus == "1")
            {
                string st = obj.DeleteDesignation(Cmb_designame.SelectedValue.ToString());
                if (st == "1")
                {
                    MessageBox.Show("Deletion Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataSet ds = new DataSet();
                    ds = obj.GetDesignation();
                    Cmb_designame.DataSource = ds.Tables[0];
                    Cmb_designame.DisplayMember = "designation_name";
                    Cmb_designame.ValueMember = "designation_id";
                    DataRow dr = ds.Tables[0].NewRow();
                    dr["designation_name"] = "--Select One--";
                    dr["designation_id"] = "0";
                    ds.Tables[0].Rows.InsertAt(dr, 0);
                    Cmb_designame.SelectedIndex = 0;
                }
                if (st == "0")
                {
                    MessageBox.Show("Sorry,Designatio already in use.So you canot delete this designation", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                clear();
                Rb_new.Checked = true;
            }
            else
            {

                MessageBox.Show("You Do Not Have The Permission To Delete Designation", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                Cmb_designame.Enabled = false;
                clear();
                txt_designation.Focus();
            }
            if (f==1)
            Cmb_designame.SelectedIndex = 0;
        }

        private void Rb_edit_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            if (Rb_edit.Checked == true)
            {
                Cmb_designame.Enabled = true;
                clear();
                DataSet ds = new DataSet();
                ds = obj.GetDesignation();
                Cmb_designame.DataSource = ds.Tables[0];
                Cmb_designame.DisplayMember = "designation_name";
                Cmb_designame.ValueMember = "designation_id";

                DataRow dr = ds.Tables[0].NewRow();
                dr["designation_name"] = "--Select One--";
                dr["designation_id"] = "0";
                ds.Tables[0].Rows.InsertAt(dr, 0);
                Cmb_designame.SelectedIndex = 0;
                Cmb_designame.Focus();
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cmb_designame_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            if (f == 1)
            {
                clear();

                DataTable dt = obj.selectdesignation(Cmb_designame.SelectedValue.ToString());
                if (dt.Rows.Count > 0)
                {
                    txt_designation.Text = dt.Rows[0]["designation_name"].ToString();
                    txt_remarks.Text = dt.Rows[0]["remarks"].ToString();

                    button1.Enabled = true;
                }
            
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void Cmb_designame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_designation.Focus();
            }
        }

        private void txt_designation_KeyDown(object sender, KeyEventArgs e)
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
                btn_Save.Focus();
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

        private void btn_Save_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_Save_MouseEnter(object sender, EventArgs e)
        {
            k = 1;
            btn_Save.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Save_Paint);
        }

        private void btn_Save_MouseLeave(object sender, EventArgs e)
        {
            k = 0;
            btn_Save.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Save_Paint);
        }

        private void Cmb_designame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Cmb_designame.DroppedDown)
            {
                Cmb_designame.Focus();

            }
        }
    }
}
