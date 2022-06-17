using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace BisCarePosEdition
{
    public partial class SalesReportByDate : Form
    {
        public SalesReportByDate()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
        DataTable dtprintfeatures;
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
        private void SalesReportByDate_Load(object sender, EventArgs e)
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

        private void btn_viewreport_Click(object sender, EventArgs e)
        {
            try
            {
                saletypee = saletype();
                if (rd_all.Checked == true)
                {
                    FrmDailySalesReportByDate ob = new FrmDailySalesReportByDate(1, 0, dtp_start1.Value, dtp_end.Value,saletypee);
                    ob.ShowDialog();
                }
                else if (rd_counterBill.Checked == true)
                {
                    FrmDailySalesReportByDate ob = new FrmDailySalesReportByDate(4, 0, dtp_start1.Value, dtp_end.Value,saletypee);
                    ob.ShowDialog();
                }
                else if (rd_Dinein.Checked == true)
                {
                    FrmDailySalesReportByDate ob = new FrmDailySalesReportByDate(2, 0, dtp_start1.Value, dtp_end.Value,saletypee);
                    ob.ShowDialog();
                }
                else if (rd_takeaway.Checked == true)
                {
                    FrmDailySalesReportByDate ob = new FrmDailySalesReportByDate(3, 0, dtp_start1.Value, dtp_end.Value,saletypee);
                    ob.ShowDialog();
                }
                else if (rbtnAC.Checked == true) //AC Sales
                {
                    FrmDailySalesReportByDate ob = new FrmDailySalesReportByDate(5, 0, dtp_start1.Value, dtp_end.Value,saletypee);
                    ob.ShowDialog();
                }
                else if (rbtnNonAC.Checked == true)// Non AC Sales
                {
                    FrmDailySalesReportByDate ob = new FrmDailySalesReportByDate(6, 0, dtp_start1.Value, dtp_end.Value,saletypee);
                    ob.ShowDialog();
                }
                //radioalltype.Checked = true;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        public string getsaletype()
        {
            string k = "";
            if (saletypee == 2)
            {
                k = "( CASH SALES )";
            }
            else if (saletypee == 3)
            {
                k = "( CREDIT SALES )";
            }

            return k;
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
        int mode = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                saletypee = saletype();
                if (rd_all.Checked == true)
                {
                    mode = 1;
                    //FrmDailySalesReportByDate ob = new FrmDailySalesReportByDate(1, 0, dtp_start.Value, dtp_end.Value);
                    //ob.ShowDialog();
                }
                else
                {
                    if (rd_counterBill.Checked == true)
                    {
                        mode = 4;
                        //FrmDailySalesReportByDate ob = new FrmDailySalesReportByDate(4, 0, dtp_start.Value, dtp_end.Value);
                        //ob.ShowDialog();
                    }
                    else
                    {
                        if (rd_Dinein.Checked == true)
                        {
                            mode = 2;
                            //FrmDailySalesReportByDate ob = new FrmDailySalesReportByDate(2, 0, dtp_start.Value, dtp_end.Value);
                            //ob.ShowDialog();
                        }
                        else
                        {
                            if (rd_takeaway.Checked == true)
                            {
                                mode = 3;
                                //FrmDailySalesReportByDate ob = new FrmDailySalesReportByDate(3, 0, dtp_start.Value, dtp_end.Value);
                                //ob.ShowDialog();
                            }
                        }
                    }
                }
                dtCounterBill = cb.ReportSalesByDate(mode, 0, dtp_start1.Value, dtp_end.Value, saletypee);
                dtComplimentary = cb.ReportSalesByDateComplimentary(mode, 0, dtp_start1.Value, dtp_end.Value, saletypee);
                dtdiscount = cb.SpGetInvoiceMasterAmounts(mode, 0, dtp_start1.Value, dtp_end.Value);
                if (dtCounterBill.Rows.Count > 0 || dtComplimentary.Rows.Count > 0)
                    PrintCounterBill();
                else
                {
                    MessageBox.Show("Not Such Reports Found", "Warnig", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //radioalltype.Checked = true;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        Codebehind cb = new Codebehind();
        DataTable dtCounterBill,dtComplimentary,dtdiscount;
        Font font20 = new Font("Arial", 20, GraphicsUnit.Point);
        Font font15 = new Font("Arial", 15, GraphicsUnit.Point);
        Font font8 = new Font("Arial", 8, GraphicsUnit.Point);
        Font font9 = new Font("Arial", 9, GraphicsUnit.Point);
        Font font10 = new Font("Arial", 10, GraphicsUnit.Point);
        Font font12 = new Font("Arial", 12, GraphicsUnit.Point);
        SolidBrush sBrush = new SolidBrush(Color.Black);

        public int saletype()
        {
            int rb = 0;

            if (radiocash.Checked == true)
            {
                rb = 2;
            }
            else if (radiocredit.Checked == true)
            {
                rb = 3;
            }
            else if (radioalltype.Checked == true)
            {
                rb = 1;
            }
            return rb;
        }

        internal static int saletypee;

        public void PrintCounterBill()
        {
            try
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
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            int widtableh = e.PageBounds.Width;
            int height = e.PageBounds.Height;
            float lineHeight = font20.GetHeight(e.Graphics);

            //float xbilltype = 30;
            float xitemaname = 0;
           // float xcat = 90;
            float xprice = 160;
            float xquantity = 200;
            float xamount = 260;
            //  float xdate = 390;
            y = 0;
            dtprintfeatures = obj.getprinterfeatures();
            if (dtprintfeatures.Rows[0]["logo"].ToString() == "1")
            {
                if (File.Exists(Application.StartupPath + "\\logo.jpg"))
                {
                    string path = Application.StartupPath + "\\logo.jpg";
                    Image r = Image.FromFile(path);
                    Point p = new Point(88, 0);
                    e.Graphics.DrawImage(r, p);
                    y += lineHeight;
                    y += 3;
                }
            }
            y += lineHeight;
            y += 3;
            y += 3;
            if (dtprintfeatures.Rows[0]["address1"].ToString() != null)
            {
                e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address1"].ToString(), 25), font15, new SolidBrush(Color.Black), 0, y);
                lineHeight = font15.GetHeight(e.Graphics);
                y += lineHeight;
            }
            if (dtprintfeatures.Rows[0]["address2"].ToString() != null)
            {
                e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address2"].ToString(), 44), font10, new SolidBrush(Color.Black), 0, y);
                lineHeight = font10.GetHeight(e.Graphics);
                y += lineHeight;
            }
            if (dtprintfeatures.Rows[0]["address3"].ToString() != null)
            {
                e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address3"].ToString(),40), font10, new SolidBrush(Color.Black), 0, y);
                lineHeight = font10.GetHeight(e.Graphics);
                y += lineHeight;
            }
                //e.Graphics.DrawString("                  Thrissur", font10, new SolidBrush(Color.Black), 0, y);
                //y += lineHeight;
                //e.Graphics.DrawString("       Phone: 0480 2845 800", font10, new SolidBrush(Color.Black), 0, y);
                //y += lineHeight;
                e.Graphics.DrawString("         SALES  REPORT BY DATE", font10, new SolidBrush(Color.Black), 0, y);
                lineHeight = font12.GetHeight(e.Graphics);
                y += lineHeight;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(300, Convert.ToInt32(y)));

                y += 3;

                //e.Graphics.DrawString(dtable.Rows[0]["waitername"].ToString() + "  Table no. " + dtable.Rows[0]["tableno"].ToString(), font10, sBrush, 0, y);
                //lineHeight = font10.GetHeight(e.Graphics);
                //y += lineHeight;

                e.Graphics.DrawString("Start Date: " + dtp_start1.Value.ToShortDateString() + "      " + getsaletype() + "", font9, sBrush, 0, y);
                lineHeight = font9.GetHeight(e.Graphics);
                y += lineHeight;
                e.Graphics.DrawString("End Date: " + dtp_end.Value.ToShortDateString(), font9, sBrush, 0, y);
                lineHeight = font9.GetHeight(e.Graphics);
                y += lineHeight;
                if (dtCounterBill.Rows.Count > 0)
                {
                    e.Graphics.DrawString("Non Complimentary Sales Report", font12, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font12.GetHeight(e.Graphics);
                    y += lineHeight;
                    lineHeight = font8.GetHeight(e.Graphics);
                    y += lineHeight;
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(300, Convert.ToInt32(y)));
                y += 3;
                //e.Graphics.DrawString("KotNo", font9, sBrush, xSlno, y);
                //e.Graphics.DrawString("Bill Type", font9, sBrush, xbilltype, y);
                e.Graphics.DrawString("Item Name", font9, sBrush, xitemaname, y);
              //  e.Graphics.DrawString("Category Name", font9, sBrush, xcat, y);
                e.Graphics.DrawString("Price", font9, sBrush, xprice, y);
                e.Graphics.DrawString("Quantity", font9, sBrush, xquantity, y);
                e.Graphics.DrawString("Amount", font9, sBrush, xamount, y);

                //e.Graphics.DrawString("Deleted Kot Date", font9, sBrush, xdate, y);
                y += lineHeight;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(300, Convert.ToInt32(y)));
                y += 3;

                double total = 0, disc = 0;
                lineHeight = font8.GetHeight(e.Graphics);
                int slnum = 1;
                for (int i = 0; i < dtCounterBill.Rows.Count; i++)
                {
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["KOTNo"].ToString(), font8, sBrush, xSlno, y);
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["Status1"].ToString(), font9, sBrush, xbilltype, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["catname"].ToString(), font9, sBrush, xcat, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["rate"].ToString(), font8, sBrush, xprice, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["quantity"].ToString(), font8, sBrush, xquantity, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["amount"].ToString(), font8, sBrush, xamount, y);
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["DeletedInvoiceDate"].ToString(), font9, sBrush, xdate, y);
                    total += Convert.ToDouble(dtCounterBill.Rows[i]["amount"]);
                    slnum += 1;
                    y += lineHeight;
                }
                disc = Convert.ToDouble(dtdiscount.Rows[0]["discount"]);
                tot = total;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(300, Convert.ToInt32(y)));
                y += 7;
                e.Graphics.DrawString("Total            : Rs." + total.ToString("F2"), font15, sBrush, 40, y);
                lineHeight = font20.GetHeight(e.Graphics);
                y += lineHeight;
                e.Graphics.DrawString("Discount      : Rs." + disc.ToString("F2"), font15, sBrush, 40, y);
                lineHeight = font20.GetHeight(e.Graphics);
                y += lineHeight;
                double net = total - disc;
                e.Graphics.DrawString("Net Amount : Rs." + net.ToString("F2"), font15, sBrush, 40, y);
                lineHeight = font20.GetHeight(e.Graphics);
                y += lineHeight;
                y += 3;
                //e.Graphics.DrawString("   This bill incl. all establish and service charge.", font9, sBrush, 0, y);
                //y += lineHeight;

            }
                if (dtComplimentary.Rows.Count > 0)
                {
                    e.Graphics.DrawString("Complimentary Sales Report", font12, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font12.GetHeight(e.Graphics);
                    y += lineHeight;
                    lineHeight = font8.GetHeight(e.Graphics);
                    y += lineHeight;
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(300, Convert.ToInt32(y)));
                    y += 3;
                    //e.Graphics.DrawString("KotNo", font9, sBrush, xSlno, y);
                    //e.Graphics.DrawString("Bill Type", font9, sBrush, xbilltype, y);
                    e.Graphics.DrawString("Item Name", font9, sBrush, xitemaname, y);
                   // e.Graphics.DrawString("Category Name", font9, sBrush, xcat, y);
                    e.Graphics.DrawString("Price", font9, sBrush, xprice, y);
                    e.Graphics.DrawString("Quantity", font9, sBrush, xquantity, y);
                    e.Graphics.DrawString("Amount", font9, sBrush, xamount, y);

                    //e.Graphics.DrawString("Deleted Kot Date", font9, sBrush, xdate, y);
                    y += lineHeight;
                    y += 3;
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(300, Convert.ToInt32(y)));
                    y += 3;

                    double total = 0;
                    lineHeight = font8.GetHeight(e.Graphics);
                    int slnum = 1;
                    for (int i = 0; i < dtComplimentary.Rows.Count; i++)
                    {

                        //e.Graphics.DrawString(dtCounterBill.Rows[i]["KOTNo"].ToString(), font8, sBrush, xSlno, y);
                        //e.Graphics.DrawString(dtCounterBill.Rows[i]["Status1"].ToString(), font9, sBrush, xbilltype, y);
                        e.Graphics.DrawString(dtComplimentary.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);
                      //  e.Graphics.DrawString(dtComplimentary.Rows[i]["catname"].ToString(), font9, sBrush, xcat, y);
                        e.Graphics.DrawString(dtComplimentary.Rows[i]["rate"].ToString(), font8, sBrush, xprice, y);
                        e.Graphics.DrawString(dtComplimentary.Rows[i]["quantity"].ToString(), font8, sBrush, xquantity, y);
                        e.Graphics.DrawString(dtComplimentary.Rows[i]["amount"].ToString(), font8, sBrush, xamount, y);
                        //e.Graphics.DrawString(dtCounterBill.Rows[i]["DeletedInvoiceDate"].ToString(), font9, sBrush, xdate, y);
                        total += Convert.ToDouble(dtComplimentary.Rows[i]["amount"]);
                       // disc += Convert.ToDouble(dtComplimentary.Rows[i]["discount"]);
                        slnum += 1;
                        y += lineHeight;
                    }
                    tot = total;
                    y += 3;
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(300, Convert.ToInt32(y)));
                    y += 7;

                    e.Graphics.DrawString("Total : Rs." + total.ToString("F2"), font15, sBrush, 40, y);
                    lineHeight = font20.GetHeight(e.Graphics);
                    y += lineHeight;
                    

                }
              //e.Graphics.DrawString("              Thank you, See you soon.", font10, sBrush, 0, y);
        }
        int f = 0;
        private void dtp_start1_ValueChanged(object sender, EventArgs e)
        {
            if (f == 0)
            {
                DateChanging();
            } 
        }

        private void dtp_end_ValueChanged(object sender, EventArgs e)
        {
            if (f == 0)
            {
                DateChanging();
            } 
        }

        private void rd_monthly_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            f = 1;
            dtp_end.Value = DateTime.Now;
            dtp_start1.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day);
            f = 0;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void rd_weekly_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            f = 1;
            dtp_start1.Value = DateTime.Now.AddDays(-6);
            dtp_end.Value = DateTime.Now;
            f = 0;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        public void DateChanging()
        {
            try
            {
            var MonthFirstDay = new DateTime(Convert.ToInt32(DateTime.Now.Year), Convert.ToInt32(DateTime.Now.Month), 1);
            var LastweekFistDay = DateTime.Now.AddDays(-6);
            if ((dtp_start1.Value.ToShortDateString() == MonthFirstDay.ToShortDateString()) && (dtp_end.Value.ToShortDateString() == DateTime.Now.ToShortDateString()))
            {
                rd_monthly.Checked = true;
            }
            else if ((dtp_start1.Value.ToShortDateString() == LastweekFistDay.ToShortDateString()) && (dtp_end.Value.ToShortDateString() == DateTime.Now.ToShortDateString()))
            {
                rd_weekly.Checked = true;
            }
            else
            {
                rd_custom.Checked = true;
            }
       
             }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
    }
}
