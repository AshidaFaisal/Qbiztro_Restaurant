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
    public partial class InvoiceReport : Form
    {
        public InvoiceReport()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
        private void btn_viewreport_Click(object sender, EventArgs e)
        {
            //if (rd_staff.Checked == true)
            //{
            //    if (cmb_staff.SelectedIndex < 0)
            //    {
            //        MessageBox.Show("Please select a staff...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //        cmb_staff.Focus();
            //    }
            //}
            FormInvoiceReport fs = new FormInvoiceReport(dtp_start.Value, dtp_end.Value);
            fs.ShowDialog();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dtCounterBill = cb.ReportIvoice(dtp_start.Value, dtp_end.Value);
                PrintCounterBill();
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


        public DataTable dtprintfeatures;
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
                float xdate = 0;
                float xbilltype = 70;
                //float xquantity = 145;
                float xamount = 150;
                // float xquantity = 290;
                //  float xamount = 330;
                y = 0;
                dtprintfeatures = obj.getprinterfeatures();
                if (dtprintfeatures.Rows[0]["logo"].ToString() == "1")
                {
                    if (File.Exists(Application.StartupPath + "\\logo.jpg"))
                    {
                        string path = Application.StartupPath + "\\logo.jpg";
                        Image r = Image.FromFile(path);
                        Point p = new Point(60, 0);
                        e.Graphics.DrawImage(r, p);
                        y += lineHeight;
                        y += 3;
                    }
                }
                y += lineHeight;
                y += 3;
                y += 3;

                dtprintfeatures = obj.getprinterfeatures();
                if (dtprintfeatures.Rows[0]["address1"].ToString() != null)
                {
                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address1"].ToString(), 20), font15, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font15.GetHeight(e.Graphics);
                    y += lineHeight;
                }
                if (dtprintfeatures.Rows[0]["address2"].ToString() != null)
                {
                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address2"].ToString(), 45), font10, new SolidBrush(Color.Black), 0, y);
                    y += lineHeight;
                }
                //e.Graphics.DrawString("                  Perinjanam-680686", font10, new SolidBrush(Color.Black), 0, y);
                //y += lineHeight;
                //e.Graphics.DrawString("       Email: thaninaadanfamilyrestaurant@gmail.com", font10, new SolidBrush(Color.Black), 0, y);
                //y += lineHeight;
                e.Graphics.DrawString("                INVOICE REPORT", font10, new SolidBrush(Color.Black), 0, y);
                lineHeight = font12.GetHeight(e.Graphics);
                y += lineHeight;

                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(250, Convert.ToInt32(y)));

                // y += 3;

                //e.Graphics.DrawString(dtable.Rows[0]["waitername"].ToString() + "  Table no. " + dtable.Rows[0]["tableno"].ToString(), font10, sBrush, 0, y);
                //lineHeight = font10.GetHeight(e.Graphics);
                //y += lineHeight;

                e.Graphics.DrawString(" End Date: " + dtp_end.Value, font9, sBrush, 0, y); //+ ",    End Date: " + dtp_end.Value, font9, sBrush, 0, y);
                lineHeight = font9.GetHeight(e.Graphics);
                y += lineHeight;

                e.Graphics.DrawString("Start Date: " + dtp_start.Value, font9, sBrush, 0, y);
                lineHeight = font9.GetHeight(e.Graphics);
                y += lineHeight;

                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(250, Convert.ToInt32(y)));
                y += 3;
                e.Graphics.DrawString("InvoiceNumber", font9, sBrush, xdate, y);
               // e.Graphics.DrawString("TAX", font9, sBrush, xbilltype, y);
                //e.Graphics.DrawString("Itemname", font9, sBrush, xitemaname, y);

                //e.Graphics.DrawString("Price", font9, sBrush, xprice, y);

                //e.Graphics.DrawString("Qty", font9, sBrush, xquantity, y);

                e.Graphics.DrawString("Amount", font9, sBrush, xamount, y);

                //e.Graphics.DrawString("Deleted Kot Date", font9, sBrush, xdate, y);
                y += lineHeight;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(250, Convert.ToInt32(y)));
                y += 3;

                double total = 0;
                lineHeight = font8.GetHeight(e.Graphics);
                int slnum = 1;
                for (int i = 0; i < dtCounterBill.Rows.Count; i++)
                {
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["InvoiceNo"].ToString(), font8, sBrush, xdate, y);
                  //  e.Graphics.DrawString(dtCounterBill.Rows[i]["Tax"].ToString(), font9, sBrush, xbilltype, y);
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["Rate"].ToString(), font8, sBrush, xprice, y);
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["Quntity"].ToString(), font8, sBrush, xquantity, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["TotalAmount"].ToString(), font8, sBrush, xamount, y);
                    //  e.Graphics.DrawString(dtCounterBill.Rows[i]["DeletedInvoiceDate"].ToString(), font9, sBrush, xdate, y);
                    total += Convert.ToDouble(dtCounterBill.Rows[i]["TotalAmount"]);
                    slnum += 1;
                    y += lineHeight;
                }
                tot = total;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(250, Convert.ToInt32(y)));
                y += 7;
                e.Graphics.DrawString("Total : Rs." + total.ToString("F2"), font15, sBrush, 40, y);
                lineHeight = font20.GetHeight(e.Graphics);
                y += lineHeight;
                //e.Graphics.DrawString("   This bill incl. all establish and service charge.", font9, sBrush, 0, y);
                //y += lineHeight;
                // e.Graphics.DrawString("              Thank you, See you soon.", font10, sBrush, 0, y);
            }

        }



    }
}
