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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        public int chk = 0;
        public Settings(int c)
        {
            InitializeComponent();
            chk = c;
        }
        Codebehind obj = new Codebehind();
        string InvoiceStatus;
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        public DialogResult dr1;
     
        private void bttn_save_Click(object sender, EventArgs e)
        {
            try
            {
            if (SaveStatus == "1")
            {
                if (rd_autoInv.Checked == true)
                {
                    InvoiceStatus = "1";


                }
                if (rd_manualInv.Checked == true)
                {
                    InvoiceStatus = "2";
                }
                if ((txt_inPr.Text == "") && (rd_autoInv.Checked == true))
                {
                    MessageBox.Show("Please Enter Invoice Prefix", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_inPr.Focus();
                }
                else
                {
                    obj.InsertSettings(Invoicestatus, txt_inPr.Text, txt_Inst.Text, EmpStat, txt_empprefix.Text, txt_empstarting.Text);
                    MessageBox.Show("Sucessfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr1 = DialogResult.OK;
                    if (chk == 1)
                        this.Close();
                    SqlDataReader dr = obj.GetSettings();
                    if (dr.Read())
                    {
                        if (dr[0].ToString() == "1")
                        {
                            rd_autoInv.Checked = true;
                        }
                        else
                        {
                            rd_manualInv.Checked = true;
                        }
                        txt_inPr.Text = dr[3].ToString();
                        txt_Inst.Text = dr[2].ToString();

                        grp_Inv.Enabled = false;

                        txt_Inst.Enabled = false;
                        txt_inPr.Enabled = false;
                        bttn_save.Enabled = false;
                        dr.Close();
                    }
                }
            }
            else
            {

                MessageBox.Show("You Do Not Have The Permission To Save Settings", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        public void FloatValueValidate(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            try
            { 
            DataTable dt1 = new DataTable();
            dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "Setting");
            SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
            UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
            DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();
            SqlDataReader dr = obj.GetSettings();
            if (dr.Read())
            {
                if (dr[0].ToString() == "1")
                {
                    rd_autoInv.Checked = true;
                }
                else
                {
                    rd_manualInv.Checked = true;
                }
                txt_inPr.Text = dr[3].ToString();
                txt_Inst.Text = dr[2].ToString();

                grp_Inv.Enabled = false;

                txt_Inst.Enabled = false;
                txt_inPr.Enabled = false;
                bttn_save.Enabled = false;
               dr.Close(); 
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        private void rd_manualInv_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_manualInv.Checked == true)
            {
                txt_Inst.Enabled = false;
                txt_inPr.Enabled = false;
                bttn_save.Focus();
            }
            
        }

        private void rd_autoInv_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_autoInv.Checked == true)
            {
                txt_Inst.Enabled = true;
                txt_inPr.Enabled = true;
                txt_Inst.Focus();
            }
        }

        private void txt_Inst_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_Inst_TextChanged(object sender, EventArgs e)
        {
            try
            {
            if (txt_Inst.Text == "")
            {
                txt_Inst.Text = "0";
            }
            string Str = txt_Inst.Text.Trim();
            double Num;
            bool isNum = double.TryParse(Str, out Num);
            if (isNum)
            {
                
            }
            else
            {
                MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Inst.Text = "0";
            }
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
        int k=0;
        private void bttn_save_Paint(object sender, PaintEventArgs e)
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

        private void txt_inPr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_save.Focus();
            }
        }

        private void txt_Inst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_save.Focus();
            }
        }

        private void rd_manualInv_Enter(object sender, EventArgs e)
        {
           
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        }
    }

