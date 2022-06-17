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

namespace BisCarePosEdition
{
    public partial class OtherIncome : Form
    {
        public OtherIncome()
        {
            InitializeComponent();
            Rb_new.Checked = true;
            Rb_edit.Checked = false;
        }
        Codebehind cb = new Codebehind();
        int f = 0;
        public void loadcombo()
        {
            DataSet ds = cb.GetIncome();
            cmb_income.DataSource = ds.Tables[0];
            cmb_income.DisplayMember = "Type";
            cmb_income.ValueMember = "Id";
            DataRow dr = ds.Tables[0].NewRow();
            dr["Type"] = "--Select One--";
            dr["Id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cmb_income.SelectedIndex = 0;
            f = 1;

        }

        private void gbCategory_Enter(object sender, EventArgs e)
        {

        }

        private void Rb_edit_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_edit.Checked == true)
            {
                cmb_income.Enabled = true;
                Btn_Delete.Enabled = true;
            }
            else
            {
                cmb_income.Enabled = false;
                Btn_Delete.Enabled = false;
            }
        }

        private void Rb_new_CheckedChanged(object sender, EventArgs e)
        {
            loadcombo();
            txt_income.Text = "";
            txt_amount.Text = "0";
            dtp_date.Value = DateTime.Now;
            txt_discription.Text = "";
            Btn_Delete.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Rb_new.Checked == true)
            {
                if (txt_income.Text == "")
                {
                    MessageBox.Show("Enter income ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_income.Focus();
                }
                else if (txt_amount.Text == "0")
                {
                    MessageBox.Show("Enter amount ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_amount.Focus();
                }
                else
                {
                    String msg = cb.InsertorUpdateIncome("0", txt_income.Text, dtp_date.Value, txt_discription.Text, txt_amount.Text, "0");
                    MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadcombo();
                    txt_income.Text = "";
                    txt_amount.Text = "0";
                    dtp_date.Value = DateTime.Now;
                    txt_discription.Text = "";
                }
            }
            else
            {
                if (cmb_income.SelectedIndex > 0)
                {
                    if (txt_income.Text == "")
                    {
                        MessageBox.Show("Enter income ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_income.Focus();
                    }
                    else if (txt_amount.Text == "0")
                    {
                        MessageBox.Show("Enter amount ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_amount.Focus();
                    }
                    else
                    {
                        string msg = cb.InsertorUpdateIncome("1", txt_income.Text, dtp_date.Value, txt_discription.Text, txt_amount.Text, cmb_income.SelectedValue.ToString());
                        MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadcombo();
                        txt_income.Text = "";
                        txt_amount.Text = "0";
                        dtp_date.Value = DateTime.Now;
                        txt_discription.Text = "";
                    }
                }
                else 
                {
                    MessageBox.Show("Please select Income", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_income.Focus();
                }
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (cmb_income.SelectedIndex > 0)
            {
                string msg = cb.DeleteIncome(cmb_income.SelectedValue.ToString());
                MessageBox.Show("Income sucessfully deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadcombo();
                txt_income.Text = "";
                txt_amount.Text = "0";
                dtp_date.Value = DateTime.Now;
                txt_discription.Text = "";
            }
            else
            {
                MessageBox.Show("Please select an Income ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_income.Focus();
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void OtherIncome_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_income;
            loadcombo();
            Btn_Delete.Enabled = false;
        }

        private void cmb_income_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f == 1)
            {
               // cb.GetIncomeById(cmb_income.SelectedValue.ToString());
                SqlDataReader dr = cb.GetIncomeById(cmb_income.SelectedValue.ToString());
                if (dr.Read())
                {
                    txt_income.Text = dr[2].ToString();
                    txt_amount.Text = dr[4].ToString();
                    txt_discription.Text=dr[3].ToString();
                    dtp_date.Value =(DateTime) dr[1];

                }
            }
        }
        public void FloatValueValidate(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void Rb_new_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_income.Focus();
            }
        }

        private void txt_income_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_amount.Focus();
            }
        }

        private void txt_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_date.Focus();
            }
        }

        private void dtp_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_discription.Focus();
            }
        }

        private void txt_discription_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_discription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save.Focus();
            }
        }

        private void cmb_income_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_income.DroppedDown)
            {
                cmb_income.Focus();
            }
            //else
            //    txt_income.Focus();
        }

        private void Rb_edit_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                cmb_income.Focus();
            }
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {

            if (txt_amount.Text == "")
            {
                txt_amount.Text = "0";
            }
            string Str = txt_amount.Text.Trim();
            double Num;
            bool isNum = double.TryParse(Str, out Num);
            if (isNum)
            {
                // Functionality here	
            }
            else
            {
                MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_amount.Text = "0";
            }
        }
        int k = 0;
        private void btn_save_Paint(object sender, PaintEventArgs e)
        {
            Color borderDark, borderLight, bgdark, bgmed, bglight, textColor;
            int _roundedRadiusX = 3;
            int _roundedRadiusY = 3;
            if (k == 0)
            {
                //initialization
                //blue button
                borderDark = ColorFromHex("#1f48a1");
                borderLight = ColorFromHex("#4487e4");
                bgdark = ColorFromHex("#2961b5");
                bglight = ColorFromHex("#3e7ddb");
                textColor = Color.White;
            }
            else
            {
                //////yellow button
                borderDark = ColorFromHex("#ecc757");
                borderLight = ColorFromHex("#fcf3d7");
                bgdark = ColorFromHex("#f9e189");
                bglight = ColorFromHex("#fbf9e0");
                textColor = ColorFromHex("#1e395b");
            }
            //now let's we begin painting
            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.HighQuality;

            Rectangle r = new Rectangle(e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width, e.ClipRectangle.Height);
            Rectangle r2 = r;
            r2.Inflate(-1, -1);
            Rectangle r3 = r2;
            r3.Inflate(-1, -1);

            //clear background first
            using (SolidBrush br = new SolidBrush(Color.FromName("ButtonFace")))
            {
                g.FillRectangle(br, r);
            }

            //rectangle for gradient, half upper and lower
            RectangleF halfup = new RectangleF(r.Left, r.Top, r.Width, r.Height);
            RectangleF halfdown = new RectangleF(r.Left, r.Top + (r.Height / 2) - 1, r.Width, r.Height);

            //BEGIN PAINT BACKGROUND
            //for half upper, we paint using linear gradient
            using (GraphicsPath thePath = GetRoundedRect(r, _roundedRadiusX, _roundedRadiusY))
            {
                LinearGradientBrush lgb =
                    new LinearGradientBrush(halfup, bglight, bgdark, 90f, true);

                Blend blend = new Blend(4);
                blend.Positions = new float[] { 0, 0.18f, 0.35f, 1f };
                blend.Factors = new float[] { 0f, .4f, .9f, 1f };
                lgb.Blend = blend;
                g.FillPath(lgb, thePath);
                lgb.Dispose();

                //for half lower, we paint using radial gradient
                using (GraphicsPath p = new GraphicsPath())
                {
                    p.AddEllipse(halfdown); //make it radial
                    using (PathGradientBrush gradient = new PathGradientBrush(p))
                    {
                        gradient.WrapMode = WrapMode.Clamp;
                        gradient.CenterPoint = new PointF(Convert.ToSingle(halfdown.Left + halfdown.Width / 2), Convert.ToSingle(halfdown.Bottom));
                        gradient.CenterColor = bglight;
                        gradient.SurroundColors = new Color[] { bgdark };

                        blend = new Blend(4);
                        blend.Positions = new float[] { 0, 0.15f, 0.4f, 1f };
                        blend.Factors = new float[] { 0f, .3f, 1f, 1f };
                        gradient.Blend = blend;

                        g.FillPath(gradient, thePath);
                    }
                }
                //END PAINT BACKGROUND
                //BEGIN PAINT BORDERS
                using (GraphicsPath gborderDark = thePath)
                {
                    using (Pen p = new Pen(borderDark, 1))
                    {
                        g.DrawPath(p, gborderDark);
                    }
                }
                using (GraphicsPath gborderLight = GetRoundedRect(r2, _roundedRadiusX, _roundedRadiusY))
                {
                    using (Pen p = new Pen(borderLight, 1))
                    {
                        g.DrawPath(p, gborderLight);
                    }
                }
                using (GraphicsPath gborderMed = GetRoundedRect(r3, _roundedRadiusX, _roundedRadiusY))
                {
                    SolidBrush bordermed = new SolidBrush(Color.FromArgb(50, borderLight));
                    using (Pen p = new Pen(bordermed, 1))
                    {
                        g.DrawPath(p, gborderMed);
                    }
                }
                //END PAINT BORDERS
                //BEGIN PAINT TEXT & Image
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                if (this.ShowKeyboardCues)
                    sf.HotkeyPrefix = HotkeyPrefix.Show;
                else
                    sf.HotkeyPrefix = HotkeyPrefix.Hide;
                g.DrawString((sender as Control).Text, (sender as Control).Font, new SolidBrush(textColor), e.ClipRectangle, sf);
                g.DrawImage(((Button)sender).Image, e.ClipRectangle.Left, e.ClipRectangle.Top);
            }
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
