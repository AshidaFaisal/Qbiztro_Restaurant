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
using System.Drawing.Printing;
using System.IO;

namespace BisCarePosEdition
{
    public partial class DilySalesReport : Form
    {
        public DilySalesReport()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
        private void btn_viewreport_Click(object sender, EventArgs e)
        {
            try
            {
            if (rd_all.Checked == true)
            {
                FrmDailySalesReport ob = new FrmDailySalesReport(1, 0);
                ob.ShowDialog();
            }
            else
            {
                if (rd_counterBill.Checked == true)
                {
                    FrmDailySalesReport ob = new FrmDailySalesReport(4, 0);
                    ob.ShowDialog();
                }
                else
                {
                    if (rd_Dinein.Checked == true)
                    {
                        FrmDailySalesReport ob = new FrmDailySalesReport(2, 0);
                        ob.ShowDialog();
                    }
                    else
                    {
                        if (rd_takeaway.Checked == true)
                        {
                            FrmDailySalesReport ob = new FrmDailySalesReport(3, 0);
                            ob.ShowDialog();
                        }
                    }
                }
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
        private void DilySalesReport_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
                
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        int k = 0;
        private void btn_viewreport_Paint(object sender, PaintEventArgs e)
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

        private void rd_all_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rd_Dinein_CheckedChanged(object sender, EventArgs e)
        {

        }
        int mode=0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            if (rd_all.Checked == true)
            {
                mode = 1;
                //FrmDailySalesReport ob = new FrmDailySalesReport(1, 0);
                //ob.ShowDialog();
            }
            else
            {
                if (rd_counterBill.Checked == true)
                {
                    mode = 4;
                    //FrmDailySalesReport ob = new FrmDailySalesReport(4, 0);
                    //ob.ShowDialog();
                }
                else
                {
                    if (rd_Dinein.Checked == true)
                    {
                        mode = 2;
                        //FrmDailySalesReport ob = new FrmDailySalesReport(2, 0);
                        //ob.ShowDialog();
                    }
                    else
                    {
                        if (rd_takeaway.Checked == true)
                        {
                            mode = 3;
                            //FrmDailySalesReport ob = new FrmDailySalesReport(3, 0);
                            //ob.ShowDialog();
                        }
                    }
                }
            }
            if (mode > 0)
            {
                dtCounterBill = cb.ReportofsalesDaily(mode, 0);
                PrintCounterBill();

            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }
        
        Codebehind cb = new Codebehind();
        DataTable dtCounterBill;
        Font font20 = new Font("Arial", 20, GraphicsUnit.Point);
        Font font15 = new Font("Arial", 15, GraphicsUnit.Point);
        Font font8 = new Font("Arial", 8, GraphicsUnit.Point);
        Font font9 = new Font("Arial", 9, GraphicsUnit.Point);
        Font font10 = new Font("Arial", 10, GraphicsUnit.Point);
        Font font12 = new Font("Arial", 12, GraphicsUnit.Point);
        SolidBrush sBrush = new SolidBrush(Color.Black);
        public void PrintCounterBill()
        {try
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.Doc_PrintPageCounterBill;
            //doc.PrinterSettings.PrinterName = "VENDOR THERMAL PRINTER";
            doc.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            //doc.OriginAtMargins = true;
            try
            {
                doc.Print();
            }
            catch (Exception e)
            {
                MessageBox.Show("Printer Error");
                // throw new ApplicationException("Printer Error");
            }
        }
        catch (Exception ex)
        {
            File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
        }


        }
        public static string CenterString(string stringToCenter, int totalLength)
        {
            Billing bc = new Billing();
            return stringToCenter.PadLeft(((totalLength - stringToCenter.Length) / 2)
                                + stringToCenter.Length)
                       .PadRight(totalLength);

        }
        private void Doc_PrintPageCounterBill(object sender, PrintPageEventArgs e)
        {
            double tot = 0;
            if (dtCounterBill.Rows.Count > 0)
            {
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;
                int widtableh = e.PageBounds.Width;
                int height = e.PageBounds.Height;
                float lineHeight = font20.GetHeight(e.Graphics);
               
                //float xbilltype = 30;
                float xitemaname = 0;
                float xcat = 210;
                float xprice = 260;
                float xquantity = 330;
                float xamount = 390;
                //  float xdate = 390;
                e.Graphics.DrawString("    THANINAADAN", font20, new SolidBrush(Color.Black), 0, y);
                y += lineHeight;
                e.Graphics.DrawString("  Family Restaurant", font20, new SolidBrush(Color.Black), 0, y);
                y += lineHeight;
                e.Graphics.DrawString("             Opp Petrol Pump, Kottamkulam", font10, new SolidBrush(Color.Black), 0, y);
                lineHeight = font10.GetHeight(e.Graphics);
                y += lineHeight;
                //e.Graphics.DrawString("                  Perinjanam-680686", font10, new SolidBrush(Color.Black), 0, y);
                //y += lineHeight;
                //e.Graphics.DrawString("       Email: thaninaadanfamilyrestaurant@gmail.com", font10, new SolidBrush(Color.Black), 0, y);
                //y += lineHeight;
                e.Graphics.DrawString("                   DAILY SALES  REPORT", font12, new SolidBrush(Color.Black), 0, y);
                lineHeight = font12.GetHeight(e.Graphics);
                y += lineHeight;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(390, Convert.ToInt32(y)));

                y += 3;

                //e.Graphics.DrawString(dtable.Rows[0]["waitername"].ToString() + "  Table no. " + dtable.Rows[0]["tableno"].ToString(), font10, sBrush, 0, y);
                //lineHeight = font10.GetHeight(e.Graphics);
                //y += lineHeight;

                //e.Graphics.DrawString("Start Date: " + dtp_start.Value + ",    End Date: " + dtp_end.Value, font9, sBrush, 0, y);
                //lineHeight = font9.GetHeight(e.Graphics);
                //y += lineHeight;

                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(390, Convert.ToInt32(y)));
                y += 3;
                //e.Graphics.DrawString("KotNo", font9, sBrush, xSlno, y);
                //e.Graphics.DrawString("Bill Type", font9, sBrush, xbilltype, y);
                e.Graphics.DrawString("Item Name", font9, sBrush, xitemaname, y);
                e.Graphics.DrawString("Category Name", font9, sBrush, xcat, y);
                e.Graphics.DrawString("Price", font9, sBrush, xprice, y);
                e.Graphics.DrawString("Quantity", font9, sBrush, xquantity, y);
                e.Graphics.DrawString("Amount", font9, sBrush, xamount, y);

                //e.Graphics.DrawString("Deleted Kot Date", font9, sBrush, xdate, y);
                y += lineHeight;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(390, Convert.ToInt32(y)));
                y += 3;

                double total = 0;
                lineHeight = font8.GetHeight(e.Graphics);
                int slnum = 1;
                for (int i = 0; i < dtCounterBill.Rows.Count; i++)
                {
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["KOTNo"].ToString(), font8, sBrush, xSlno, y);
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["Status1"].ToString(), font9, sBrush, xbilltype, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["catname"].ToString(), font9, sBrush, xcat, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["rate"].ToString(), font8, sBrush, xprice, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["quantity"].ToString(), font8, sBrush, xquantity, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["amount"].ToString(), font8, sBrush, xamount, y);
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["DeletedInvoiceDate"].ToString(), font9, sBrush, xdate, y);
                    total += Convert.ToDouble(dtCounterBill.Rows[i]["amount"]);
                    slnum += 1;
                    y += lineHeight;
                }
                tot = total;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(390, Convert.ToInt32(y)));
                y += 7;
                e.Graphics.DrawString("Total : Rs." + total.ToString("F2"), font15, sBrush, 40, y);
                lineHeight = font20.GetHeight(e.Graphics);
                y += lineHeight;
                //e.Graphics.DrawString("   This bill incl. all establish and service charge.", font9, sBrush, 0, y);
                //y += lineHeight;
                e.Graphics.DrawString("              Thank you, See you soon.", font10, sBrush, 0, y);
            }

        }


    }
}
