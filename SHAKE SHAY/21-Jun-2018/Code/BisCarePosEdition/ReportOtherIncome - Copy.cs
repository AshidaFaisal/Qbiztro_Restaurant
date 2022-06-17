using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace BisCarePosEdition
{
    public partial class ReportOtherIncome : Form
    {
        public ReportOtherIncome()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
        private void btn_viewreport_Click(object sender, EventArgs e)
        {
            if ((ch_date.Checked == true) && (Cbox_type.Checked == false))
            {
                FrmReportOtherIncome ot = new FrmReportOtherIncome(dtp_end.Value, dtp_start.Value.ToShortDateString(), cmb_newtype.Text, 1);
                ot.ShowDialog();
            }
            if ((ch_date.Checked == false) && (Cbox_type.Checked == true))
            {
                if (cmb_newtype.SelectedIndex > 0)
                {
                    FrmReportOtherIncomeType ot = new FrmReportOtherIncomeType(dtp_end.Value, dtp_start.Value.ToShortDateString(), cmb_newtype.Text, 2);
                    ot.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a Type ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_newtype.Focus();
                }
            }
            if ((ch_date.Checked == true) && (Cbox_type.Checked == true))
            {
                if (cmb_newtype.SelectedIndex > 0)
                {
                    FrmReportOtherIncome sd = new FrmReportOtherIncome(dtp_end.Value, dtp_start.Value.ToShortDateString(), cmb_newtype.Text, 3);
                    sd.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a Type ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_newtype.Focus();
                }

            }

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void ReportOtherIncome_Load(object sender, EventArgs e)
        {
            this.ActiveControl = ch_date;
            cmb_newtype.Enabled = false;
            this.ActiveControl = cmb_newtype;
            DataSet ds = obj.GetOtherIncomeType();
            cmb_newtype.DataSource = ds.Tables[0];
            cmb_newtype.DisplayMember = "Type";
            //cmb_newtype.ValueMember = "Id";

            DataRow dr4 = ds.Tables[0].NewRow();
            dr4["Type"] = "--Select One--";
            ds.Tables[0].Rows.InsertAt(dr4, 0);
            cmb_newtype.SelectedIndex = 0;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ch_date_CheckedChanged(object sender, EventArgs e)
        {
            dtp_start.Value = DateTime.Now;
            dtp_end.Value = DateTime.Now;
            if (ch_date.Checked == true)
            {
                dtp_start.Enabled = true;
                dtp_end.Enabled = true;
            }
            else
            {
                dtp_start.Enabled = false;
                dtp_end.Enabled = false;
            }
        }

        private void Cbox_type_CheckedChanged(object sender, EventArgs e)
        {
            cmb_newtype.SelectedIndex = 0;
            if (Cbox_type.Checked == true)
            {
                cmb_newtype.Enabled = true;
            }
            else
            {
                cmb_newtype.Enabled = false;
            }
        }
        int k = 0;
        private void btn_viewreport_Paint(object sender, PaintEventArgs e)
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

        private void btn_viewreport_MouseEnter(object sender, EventArgs e)
        {
            k = 1;
            btn_viewreport.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_viewreport_Paint);
        }

        private void btn_viewreport_MouseLeave(object sender, EventArgs e)
        {
            k = 0;
            btn_viewreport.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_viewreport_Paint);
        }


    }
}
