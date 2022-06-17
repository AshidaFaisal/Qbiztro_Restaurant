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
    public partial class ReportInvoiceSummary : Form
    {
        Codebehind obj = new Codebehind();
        public ReportInvoiceSummary()
        {
            InitializeComponent();
        }

        private void ReportInvoiceSummary_Load(object sender, EventArgs e)
        {
            try
            {

                this.ActiveControl = ch_date;
                this.ActiveControl = cmb_newtype;

                DataSet ds = obj.GetOtherExpenceType();
                cmb_newtype.DataSource = ds.Tables[0];
                cmb_newtype.DisplayMember = "Name";
                cmb_newtype.ValueMember = "Id";

                DataRow dr4 = ds.Tables[0].NewRow();
                dr4["Name"] = "--Select One--";
                dr4["Id"] = "0";
                ds.Tables[0].Rows.InsertAt(dr4, 0);
                cmb_newtype.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void ch_date_CheckedChanged(object sender, EventArgs e)
        {
            dtp_start.Value = DateTime.Now;
            dtp_end.Value = DateTime.Now;
            if (ch_date.Checked == true)
            {
                groupBox4.Enabled = true;
                dtp_start.Enabled = true;
                dtp_end.Enabled = true;
                dtp_start.Focus();
            }
            else
            {
                groupBox4.Enabled = false;
                dtp_start.Enabled = false;
                dtp_end.Enabled = false;
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

        private void dtp_start_ValueChanged(object sender, EventArgs e)
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

        private void Cbox_type_CheckedChanged(object sender, EventArgs e)
        {
            cmb_newtype.SelectedIndex = 0;
            if (Cbox_type.Checked == true)
            {
                cmb_newtype.Enabled = true;
                cmb_newtype.Focus();
            }
            else
            {
                cmb_newtype.Enabled = false;
            }
        }
        int mode = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if ((ch_date.Checked == true) && (Cbox_type.Checked == false))
            {
                mode = 1;
            }
            if ((ch_date.Checked == false) && (Cbox_type.Checked == true))
            {
                if (cmb_newtype.SelectedIndex > 0)
                {
                    mode = 2;
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
                    mode = 3;
                }
                else
                {
                    MessageBox.Show("Please select a Type ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_newtype.Focus();
                }
            }
            if (mode > 0)
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
                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address2"].ToString(), 35), font10, new SolidBrush(Color.Black), 0, y);
                    y += lineHeight;
                }
                //e.Graphics.DrawString("                  Perinjanam-680686", font10, new SolidBrush(Color.Black), 0, y);
                //y += lineHeight;
                //e.Graphics.DrawString("       Email: thaninaadanfamilyrestaurant@gmail.com", font10, new SolidBrush(Color.Black), 0, y);
                //y += lineHeight;
                e.Graphics.DrawString("   INVOICE REPORT", font10, new SolidBrush(Color.Black), 0, y);
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
                e.Graphics.DrawString("Date", font9, sBrush, xdate, y);
                e.Graphics.DrawString("TAX", font9, sBrush, xbilltype, y);
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
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["Date"].ToString(), font8, sBrush, xdate, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["Tax"].ToString(), font9, sBrush, xbilltype, y);
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

        private void btn_viewreport_Click(object sender, EventArgs e)
        {
            try
            {
                if ((ch_date.Checked == true))
                {
                    FormInvoiceSummary ot = new FormInvoiceSummary(dtp_end.Value, dtp_start.Value.ToShortDateString());
                    ot.ShowDialog();


                }



                //if ((ch_date.Checked == true) && (Cbox_type.Checked == false))
                //{
                //    FrmReportOtherExpence ot = new FrmReportOtherExpence(dtp_end.Value, dtp_start.Value.ToShortDateString(), cmb_newtype.Text, 1);
                //    ot.ShowDialog();
                //}
                //if ((ch_date.Checked == false) && (Cbox_type.Checked == true))
                //{
                //    if (cmb_newtype.SelectedIndex > 0)
                //    {
                //        FrmOtherExpenceReport ot = new FrmOtherExpenceReport(dtp_end.Value, dtp_start.Value.ToShortDateString(), cmb_newtype.Text, 2);
                //        ot.ShowDialog();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Please select a Type ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        cmb_newtype.Focus();
                //    }
                //}
                //if ((ch_date.Checked == true) && (Cbox_type.Checked == true))
                //{
                //    if (cmb_newtype.SelectedIndex > 0)
                //    {
                //        FrmReportOtherExpence sd = new FrmReportOtherExpence(dtp_end.Value, dtp_start.Value.ToShortDateString(), cmb_newtype.Text, 3);
                //        sd.ShowDialog();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Please select a Type ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        cmb_newtype.Focus();
                //    }
                //}
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



    }
}
