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
    public partial class DeletedInvoiceReportShort : Form
    {
        public DeletedInvoiceReportShort()
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
        private void DeletedInvoiceReportShort_Load(object sender, EventArgs e)
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
            frmDeletedInvoiceReportShort ob = new frmDeletedInvoiceReportShort(dtp_start.Value, dtp_end.Value);
            ob.ShowDialog();
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            dtCounterBill = cb.ReportofDeletedInvoice(dtp_start.Value, dtp_end.Value);
            dtComplimentary = cb.ReportofDeletedInvoiceComplimentary(dtp_start.Value, dtp_end.Value);
           if(dtComplimentary.Rows.Count>0 || dtCounterBill.Rows.Count>0)
            PrintCounterBill();
           else
               MessageBox.Show("Not Such Reports Found", "Warnig", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


            }
        Codebehind cb = new Codebehind();
        DataTable dtCounterBill,dtComplimentary;
        Font font20 = new Font("Arial", 20, GraphicsUnit.Point);
        Font font15 = new Font("Arial", 15, GraphicsUnit.Point);
        Font font8 = new Font("Arial", 8, GraphicsUnit.Point);
        Font font9 = new Font("Arial", 9, GraphicsUnit.Point);
        Font font10 = new Font("Arial", 10, GraphicsUnit.Point);
        Font font12 = new Font("Arial", 12, GraphicsUnit.Point);
        Font font17 = new Font("Arial",17,GraphicsUnit.Point);
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

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            int widtableh = e.PageBounds.Width;
            int height = e.PageBounds.Height;
            float lineHeight = font20.GetHeight(e.Graphics);
            float xbillno = 0;
            // float xcustname = 30;
            float xbilltype = 35;
            //float xprice = 200;
            //float xquantity = 290;
            float xamount = 95;
            float xdiscount = 95;
            float xnetamount = 150;
            float xdate = 225;
            float xcdate = 130;
            y = 0;
            dtprintfeatures = obj.getprinterfeatures();
            if (dtprintfeatures.Rows[0]["logo"].ToString() == "1")
            {
                if (File.Exists(Application.StartupPath + "\\logo.jpg"))
                {
                    string path = Application.StartupPath + "\\logo.jpg";
                    Image r = Image.FromFile(path);
                    Point p = new Point(92, 0);
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
                lineHeight = font10.GetHeight(e.Graphics);
                y += lineHeight;

            }
       
             if (dtprintfeatures.Rows[0]["address2"].ToString() != null)
            {
            e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address2"].ToString(), 44), font12, new SolidBrush(Color.Black), 0, y);
            lineHeight = font10.GetHeight(e.Graphics);
            y += lineHeight;
             }
         
             if (dtprintfeatures.Rows[0]["address3"].ToString() != null)
             {
                 e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address3"].ToString(), 50), font10, new SolidBrush(Color.Black), 0, y);
                 lineHeight = font10.GetHeight(e.Graphics);
                 y += lineHeight;
             }
           
            e.Graphics.DrawString("       DELETED INVOICE REPORT", font10, new SolidBrush(Color.Black), 0, y);
            lineHeight = font12.GetHeight(e.Graphics);
            y += lineHeight;
            y += 3;
            e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(300, Convert.ToInt32(y)));

            y += 3;

            //e.Graphics.DrawString(dtable.Rows[0]["waitername"].ToString() + "  Table no. " + dtable.Rows[0]["tableno"].ToString(), font10, sBrush, 0, y);
            //lineHeight = font10.GetHeight(e.Graphics);
            //y += lineHeight;

            e.Graphics.DrawString("Start Date: " + dtp_start.Value.ToShortDateString() + ",    End Date: " + dtp_end.Value.ToShortDateString(), font9, sBrush, 0, y);
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
                e.Graphics.DrawString("Bill #", font9, sBrush, xbillno, y);
                //e.Graphics.DrawString("Customer Name", font9, sBrush, xcustname, y);
                e.Graphics.DrawString("Bill Type", font9, sBrush, xbilltype, y);

                //e.Graphics.DrawString("Price", font9, sBrush, xprice, y);

                //e.Graphics.DrawString("Qty", font9, sBrush, xquantity, y);

               // e.Graphics.DrawString("Amount", font9, sBrush, xamount, y);
                e.Graphics.DrawString("Discount", font9, sBrush, xdiscount, y);
                e.Graphics.DrawString("Net Amount", font9, sBrush, xnetamount, y);

                e.Graphics.DrawString("Deleted Date", font9, sBrush, xdate, y);
                y += lineHeight;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(300, Convert.ToInt32(y)));
                y += 3;

                double total = 0, disc = 0;
                lineHeight = font8.GetHeight(e.Graphics);
                int slnum = 1;
                for (int i = 0; i < dtCounterBill.Rows.Count; i++)
                {
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["InvoiceNo"].ToString(), font8, sBrush, xbillno, y);
                    // e.Graphics.DrawString(dtCounterBill.Rows[i]["CustomerName"].ToString(), font9, sBrush, xcustname, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["Status1"].ToString(), font8, sBrush, xbilltype, y);
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["Rate"].ToString(), font8, sBrush, xprice, y);
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["Quntity"].ToString(), font8, sBrush, xquantity, y);
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["TotalAmount"].ToString(), font8, sBrush, xamount, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["discount"].ToString(), font8, sBrush, xdiscount, y);
                    e.Graphics.DrawString((Convert.ToDouble(dtCounterBill.Rows[i]["TotalAmount"].ToString()) - Convert.ToDouble(dtCounterBill.Rows[i]["discount"].ToString())).ToString("F2"), font8, sBrush, xnetamount, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["DeletedInvoiceDate"].ToString(), font9, sBrush, xdate, y);
                    total += Convert.ToDouble(dtCounterBill.Rows[i]["TotalAmount"]);
                    disc += Convert.ToDouble(dtCounterBill.Rows[i]["discount"]);
                    slnum += 1;
                    y += lineHeight;
                }
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
                //e.Graphics.DrawString("   This bill incl. all establish and service charge.", font9, sBrush, 0, y);
                //y += lineHeight;
            }
            if (dtComplimentary.Rows.Count > 0)
            {
                e.Graphics.DrawString("Complimentary Sales Report", font15, new SolidBrush(Color.Black), 0, y);
                lineHeight = font12.GetHeight(e.Graphics);
                y += lineHeight;
                lineHeight = font8.GetHeight(e.Graphics);
                y += lineHeight;

                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(200, Convert.ToInt32(y)));
                y += 3;
                e.Graphics.DrawString("Bill #", font9, sBrush, xbillno, y);
                //e.Graphics.DrawString("Customer Name", font9, sBrush, xcustname, y);
                e.Graphics.DrawString("Bill Type", font9, sBrush, xbilltype, y);

                //e.Graphics.DrawString("Price", font9, sBrush, xprice, y);

                //e.Graphics.DrawString("Qty", font9, sBrush, xquantity, y);

                e.Graphics.DrawString("Amount", font9, sBrush, xamount, y);

                e.Graphics.DrawString("Deleted  Date", font9, sBrush, xcdate, y);
                y += lineHeight;
                y += 3;

                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(200, Convert.ToInt32(y)));
                y += 3;

                double total = 0;
                lineHeight = font8.GetHeight(e.Graphics);
                int slnum = 1;
                for (int i = 0; i < dtComplimentary.Rows.Count; i++)
                {
                    e.Graphics.DrawString(dtComplimentary.Rows[i]["InvoiceNo"].ToString(), font8, sBrush, xbillno, y);
                    //e.Graphics.DrawString(dtComplimentary.Rows[i]["CustomerName"].ToString(), font9, sBrush, xcustname, y);
                    e.Graphics.DrawString(dtComplimentary.Rows[i]["Status1"].ToString(), font8, sBrush, xbilltype, y);
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["Rate"].ToString(), font8, sBrush, xprice, y);
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["Quntity"].ToString(), font8, sBrush, xquantity, y);
                    e.Graphics.DrawString(dtComplimentary.Rows[i]["TotalAmount"].ToString(), font8, sBrush, xamount, y);
                    e.Graphics.DrawString(dtComplimentary.Rows[i]["DeletedInvoiceDate"].ToString(), font9, sBrush, xcdate, y);
                    total += Convert.ToDouble(dtComplimentary.Rows[i]["TotalAmount"]);
                    //disc += Convert.ToDouble(dtCounterBill.Rows[i]["discount"]);
                    slnum += 1;
                    y += lineHeight;
                }
                tot = total;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(200, Convert.ToInt32(y)));
                y += 7;
                e.Graphics.DrawString("Total : Rs." + total.ToString("F2"), font15, sBrush, 40, y);
                lineHeight = font20.GetHeight(e.Graphics);
                y += lineHeight;
                
            }
            //e.Graphics.DrawString("              Thank you, See you soon.", font10, sBrush, 0, y);


        }

        private void dtp_start_ValueChanged(object sender, EventArgs e)
        {
            if (f == 0)
            {
                DateChanging();
            }   
        }
        public void DateChanging()
        {
            try

            {
            var MonthFirstDay = new DateTime(Convert.ToInt32(DateTime.Now.Year), Convert.ToInt32(DateTime.Now.Month), 1);
            var LastweekFistDay = DateTime.Now.AddDays(-6);
            if ((dtp_start.Value.ToShortDateString() == MonthFirstDay.ToShortDateString()) && (dtp_end.Value.ToShortDateString() == DateTime.Now.ToShortDateString()))
            {
                rd_monthly.Checked = true;
            }
            else if ((dtp_start.Value.ToShortDateString() == LastweekFistDay.ToShortDateString()) && (dtp_end.Value.ToShortDateString() == DateTime.Now.ToShortDateString()))
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
        int f = 0;
        private void rd_monthly_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            f = 1;
            dtp_end.Value = DateTime.Now;
            dtp_start.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day);
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
            dtp_start.Value = DateTime.Now.AddDays(-6);
            dtp_end.Value = DateTime.Now;
            f = 0;
            }
        catch (Exception ex)
        {
            File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
        }


        }

        private void dtp_end_ValueChanged(object sender, EventArgs e)
        {
            if (f == 0)
            {
                DateChanging();
            }   
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
