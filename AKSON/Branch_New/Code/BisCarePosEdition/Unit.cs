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
    public partial class Unit : Form
    {
        public Unit()
        {
            InitializeComponent();
        }
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        Codebehind obj = new Codebehind();
        int f = 0;
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
        private void Unit_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
            DataTable dt1 = new DataTable();
            dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "Unit");
            SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
            UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
            DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();

            this.ActiveControl = txt_unit;
            DataSet ds = new DataSet();
            ds = obj.GetUnit();
            cmb_unitid.DataSource = ds.Tables[0];
            cmb_unitid.DisplayMember = "Unit";
            cmb_unitid.ValueMember = "Id";
            DataRow dr = ds.Tables[0].NewRow();
            dr["Unit"] = "--Select One--";
            dr["Id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cmb_unitid.SelectedIndex = 0;


            cmb_unitid.Enabled = false;
            Btn_Delete.Enabled = false;
            txt_unit.Focus();
            f = 1;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
            if (Rb_new.Checked == true)
            {
                if (SaveStatus == "1")
                {
                    if (txt_unit.Text != "")
                    {
                        string msg = obj.InsertorUpdateUnit(txt_unit.Text, "1", cmb_unitid.SelectedValue.ToString());
                        if (msg == "Unit already exists")
                        MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_unit.Text = "";
                        DataSet ds = new DataSet();
                        ds = obj.GetUnit();
                        cmb_unitid.DataSource = ds.Tables[0];
                        cmb_unitid.DisplayMember = "Unit";
                        cmb_unitid.ValueMember = "Id";
                        DataRow dr = ds.Tables[0].NewRow();
                        dr["Unit"] = "--Select One--";
                        dr["Id"] = "0";
                        ds.Tables[0].Rows.InsertAt(dr, 0);
                        cmb_unitid.SelectedIndex = 0;
                        txt_unit.Focus();
                    }
                    else
                    {
                        MessageBox.Show("please enter unit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_unit.Focus();
                    }
                }
                else
                {

                    MessageBox.Show("You Do Not Have The Permission To Save Unit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                if (UpdateStatus == "1")
                {
                    if (cmb_unitid.SelectedIndex > 0)
                    {
                        string msg = obj.InsertorUpdateUnit(txt_unit.Text, "2", cmb_unitid.SelectedValue.ToString());
                        if (msg == "Unit already exists")
                            MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txt_unit.Text = "";

                        DataSet ds = new DataSet();
                        ds = obj.GetUnit();
                        cmb_unitid.DataSource = ds.Tables[0];
                        cmb_unitid.DisplayMember = "Unit";
                        cmb_unitid.ValueMember = "Id";
                        DataRow dr = ds.Tables[0].NewRow();
                        dr["Unit"] = "--Select One--";
                        dr["Id"] = "0";
                        ds.Tables[0].Rows.InsertAt(dr, 0);
                        cmb_unitid.SelectedIndex = 0;


                    }
                    else
                    {
                        MessageBox.Show("please select a unit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmb_unitid.Focus();
                    }
                }
                else
                {

                    MessageBox.Show("You Do Not Have The Permission To Update Unit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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
                cmb_unitid.Enabled = false;
                Btn_Delete.Enabled = false;
                txt_unit.Text = "";
                txt_unit.Focus();
            }
            else
            {
                cmb_unitid.Enabled = true;
                Btn_Delete.Enabled = true;
                cmb_unitid.Focus();
            }
            cmb_unitid.SelectedIndex = 0;
        }

        private void Rb_edit_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_edit.Checked == true)
            {
                cmb_unitid.Enabled = true;
                Btn_Delete.Enabled = true;
                cmb_unitid.Focus();
            }
            else
            {
                cmb_unitid.Enabled = false;
                Btn_Delete.Enabled = false;
                txt_unit.Focus();
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
            if (DeleteStatus == "1")
            {
                if (cmb_unitid.SelectedIndex > 0)
                {
                    string msg = obj.DeleteUnit(cmb_unitid.SelectedValue.ToString());
                    if (msg == "1")
                    {
                        MessageBox.Show("Unit successfully deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sory,This unit already in use.So you canot delete it", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("please select a unit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_unitid.Focus();
                }
                txt_unit.Text = "";
                DataSet ds = new DataSet();
                ds = obj.GetUnit();
                cmb_unitid.DataSource = ds.Tables[0];
                cmb_unitid.DisplayMember = "Unit";
                cmb_unitid.ValueMember = "Id";
                DataRow dr = ds.Tables[0].NewRow();
                dr["Unit"] = "--Select One--";
                dr["Id"] = "0";
                ds.Tables[0].Rows.InsertAt(dr, 0);
                cmb_unitid.SelectedIndex = 0;

            }
            else
            {

                MessageBox.Show("You Do Not Have The Permission To Delete Unit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_unitid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            if (f == 1)
            {
                txt_unit.Text = "";
                SqlDataReader dr = obj.GetUnitDetail(cmb_unitid.SelectedValue.ToString());
                if (dr.Read())
                {
                    txt_unit.Text = dr[1].ToString();
                    dr.Close();
                }
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cmb_unitid_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_unitid.DroppedDown)
            {
                cmb_unitid.Focus();

            }
        }
        int k = 0;
        private void btn_save_Paint(object sender, PaintEventArgs e)
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

        private void btn_save_MouseEnter(object sender, EventArgs e)
        {
            k = 1;
            btn_save.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_save_Paint);
        }

        private void btn_save_MouseLeave(object sender, EventArgs e)
        {
            k = 0;
            btn_save.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_save_Paint);
        }

        private void cmb_unitid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_unit.Focus();
            }
        }

        private void txt_unit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_save.Focus();
            }
        }
    }
}
