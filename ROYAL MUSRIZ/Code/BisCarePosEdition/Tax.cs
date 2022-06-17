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
   


    public partial class Tax : Form
    {
        public Tax()
        {
            InitializeComponent();
            Rb_new.Checked = true;
            Rb_edit.Checked = false;
        }
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        Codebehind obj = new Codebehind();
        public void FloatValueValidate(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
            if (Rb_new.Checked == true)
            {
                if (SaveStatus == "1")
                {
                    if (txt_name.Text == "")
                    {
                        MessageBox.Show("Please enter tax name ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_name.Focus();
                    }
                    else
                    {
                        string msg = cb.InsertorUpdateTax(txt_name.Text, txt_persant.Text, "0", "0");
                        if (msg == "This tax percent already exists")
                        MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            if(msg=="This tax already exits")
                                 MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        else
                            MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadcombo();
                        txt_name.Text = "";
                        txt_persant.Text = "";
                        txt_name.Focus();

                    }
                }
                else
                {

                    MessageBox.Show("You Do Not Have The Permission To Save Tax", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                if (UpdateStatus == "1")
                {
                    if (cmb_tax.SelectedIndex > 0)
                    {
                        if (txt_name.Text == "")
                        {
                            MessageBox.Show("Please enter tax name ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_name.Focus();
                        }
                        else
                        {



                            string msg = cb.InsertorUpdateTax(txt_name.Text.ToString(), txt_persant.Text.ToString(), "1", cmb_tax.SelectedValue.ToString());
                            if (msg == "This tax percent already exists")
                                MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                                MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadcombo();
                            txt_name.Text = "";
                            txt_persant.Text = "";
                            txt_name.Focus();
                            Rb_edit.Checked = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select tax ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmb_tax.Focus();
                    }

                }
                else
                {

                    MessageBox.Show("You Do Not Have The Permission To Update Tax", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }
        Codebehind cb = new Codebehind();
        int f = 0;
        public void loadcombo()
        {
           // DataSet ds = new DataSet();
           DataSet ds = cb.GetTax();
            cmb_tax.DataSource = ds.Tables[0];
            cmb_tax.DisplayMember = "Name";
            cmb_tax.ValueMember = "Id";
            DataRow dr = ds.Tables[0].NewRow();
            dr["Name"] = "--Select One--";
            dr["Id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cmb_tax.SelectedIndex = 0;
            f = 1;

        }

        private void gbCategory_Enter(object sender, EventArgs e)
        {

        }

      /*  private void btn_save_Click(object sender, EventArgs e)
        {

        }*/

        private void Rb_edit_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tax_Load(object sender, EventArgs e)
        {
            loadcombo();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rb_edit_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Rb_edit.Checked == true)
            {
                cmb_tax.Enabled = true;
              //  Btn_Delete.Enabled = true;
                cmb_tax.Focus();
            }
            else
            {
                cmb_tax.Enabled = false;
                Btn_Delete.Enabled = false;
                txt_name.Focus();
            }
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
        private void Tax_Load_1(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
             DataTable dt1 = new DataTable();
            dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "Tax");
            SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
            UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
            DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();

            this.ActiveControl = txt_name;
            loadcombo();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void Rb_new_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            loadcombo();
            txt_name.Text = "";
            txt_persant.Text="";
            txt_name.Focus();
                }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
            if (DeleteStatus == "1")
            {
                if (cmb_tax.SelectedIndex > 0)
                {
                    string msg = cb.DeleteTax(cmb_tax.SelectedValue.ToString());
                    if (msg == "1")
                    {

                        MessageBox.Show("Tax sucessfully deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_name.Focus();
                    }
                    else
                        MessageBox.Show("Tax already in use.So you can not delete this Tax", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Please select tax");
                }
                loadcombo();
                txt_name.Text = "";
                txt_persant.Text = "0";
                cmb_tax.Focus();
            }
            else
            {

                MessageBox.Show("You Do Not Have The Permission To Delete Tax", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        //public void FloatValueValidate(KeyPressEventArgs e)
        //{
        //    if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}
        private void cmb_tax_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            if (f == 1)
            {
                if (Convert.ToDouble(cmb_tax.SelectedValue) > 0)
                {
                    SqlDataReader dr = cb.GetTaxbyId(cmb_tax.SelectedValue.ToString());
                    if (dr.Read())
                    {
                        Btn_Delete.Enabled = true;
                        txt_name.Text = dr[1].ToString();
                        txt_persant.Text = dr[2].ToString();
                    }
                    else
                    {
                        Btn_Delete.Enabled = false;
                    }
                }
                else
                {
                    txt_name.Text = "";
                    txt_persant.Text = "0";
                }
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_persant_KeyPress(object sender, KeyPressEventArgs e)
        {
          FloatValueValidate(e);
        }

        private void cmb_tax_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_tax.DroppedDown)
            {
                cmb_tax.Focus();
            }
        }

        private void Rb_new_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Rb_new_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txt_name.Focus();
            }
        }

        private void Rb_edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_tax.Focus();
            }
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_persant.Focus();
            }
        }

        private void txt_persant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save.Focus();
            }
        }

        private void txt_persant_TextChanged(object sender, EventArgs e)
        {
            try
            {
            if (txt_persant.Text == string.Empty)
            {
                txt_persant.Text = "0";
            }
            if (txt_persant.Text.StartsWith("0") == true)
            {
                txt_persant.Text = Convert.ToDouble(txt_persant.Text).ToString();
            }
            string Str = txt_persant.Text.Trim();
            double Num;
            bool isNum = double.TryParse(Str, out Num);
            if (isNum)
            {
                // Functionality here
                txt_persant.Select(txt_persant.Text.Length, 0);
            }
            else
            {
                MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_persant.Text = "0";
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
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
    }
}
