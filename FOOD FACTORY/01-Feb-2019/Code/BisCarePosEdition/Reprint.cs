using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Printing;
using System.Threading;


namespace BisCarePosEdition
{
    public partial class Reprint : Form
    {
        public Reprint()
        {
            InitializeComponent();
        }
        Codebehind ObjCode = new Codebehind();
        Font font20 = new Font("Arial", 20, GraphicsUnit.Point);
        Font font15 = new Font("Arial", 15, GraphicsUnit.Point);
        Font font8 = new Font("Arial", 8, GraphicsUnit.Point);
        Font font9 = new Font("Arial", 9, GraphicsUnit.Point);
        Font font10 = new Font("Arial", 10, GraphicsUnit.Point);
        Font font12 = new Font("Arial", 12, GraphicsUnit.Point);
        Font fontarb = new Font("trado", 9, GraphicsUnit.Point);

        Font myfontb1 = new Font("Arial", 10, FontStyle.Bold);
        Font myfontb2 = new Font("Arial", 10, FontStyle.Italic);
        Font myfonti1 = new Font("Arial", 12, FontStyle.Italic);
        Font myfontb15 = new Font("", 15, FontStyle.Bold);
        Font myfonti15 = new Font("", 15, FontStyle.Italic);
        SolidBrush sBrush = new SolidBrush(Color.Black);
        private void Reprint_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ObjCode.GetInvoicesTouch();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv_reprint.Rows.Add();
                dgv_reprint[0,i].Value= dt.Rows[i]["InvoiceNo"].ToString();
                dgv_reprint[1, i].Value =Convert.ToDateTime(dt.Rows[i]["date"].ToString()).ToShortDateString(); 
                dgv_reprint[2, i].Value = dt.Rows[i]["TotalAmount"].ToString();
                dgv_reprint[3, i].Value = dt.Rows[i]["username"].ToString(); 
            }
        }
        public DataTable dtprintfeatures,dtBill;
        private void dgv_reprint_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                //DataTable dtBill = new DataTable();
                dtBill = ObjCode.PrintBillTouch(dgv_reprint.Rows[dgv_reprint.CurrentCell.RowIndex].Cells["Invoice"].Value.ToString());
                PrintBill();
            }

        }
        
        public void PrintBill()
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.Doc_PrintBill;
            doc.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            try
            {
                dtprintfeatures = ObjCode.getprinterfeatures();
                int pcount = Convert.ToInt32(dtprintfeatures.Rows[0]["PrintCount"]);
                for (int i = 0; i < pcount; i++)
                {

                    doc.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static string CenterString(string stringToCenter, int totalLength)
        {
            Billing bc = new Billing();
            return stringToCenter.PadLeft(((totalLength - stringToCenter.Length) / 2)
                                + stringToCenter.Length)
                       .PadRight(totalLength);

        }
        public Font Ft, Fonts1;
        private void Doc_PrintBill(object sender, PrintPageEventArgs e)
        {
            double tot = 0;
            if (dtBill.Rows.Count > 0)
            {
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;
                int widtableh = e.PageBounds.Width;
                int height = e.PageBounds.Height;
                float lineHeight = font20.GetHeight(e.Graphics);
                float xSlno = 0;
                float xitemaname = 30;
                float xitemarabic = 65;
                float xprice = 155;
                float xquantity = 200;
                float xamount = 240;
                //float xitemaname = 30;
                //float xprice = 145;
                //float xquantity = 190;
                //float xamount = 230;
                // y += lineHeight;
                //y += 3;
                dtprintfeatures = ObjCode.getprinterfeatures();
                if (dtprintfeatures.Rows[0]["logo"].ToString() == "1")
                {
                    if (File.Exists(Application.StartupPath + "\\logo.jpg"))
                    {
                        string path = Application.StartupPath + "\\logo.jpg";
                        Image r = Image.FromFile(path);
                        Point p = new Point(82, 0);
                        e.Graphics.DrawImage(r, p);
                        y += lineHeight;
                        y += 1;
                    }
                }

                dtprintfeatures = ObjCode.getprinterfeatures();
                if (dtprintfeatures.Rows[0]["address1"].ToString() != null)
                {
                    if (dtprintfeatures.Rows[0]["AddressFont"].ToString() == "Bold")
                    {
                        Ft = myfontb15;

                    }
                    else
                    {
                        Ft = myfonti15;
                    }
                    // y += lineHeight;
                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address1"].ToString(), 25), Ft, new SolidBrush(Color.Black), 0, y - 30);
                    //lineHeight = font15.GetHeight(e.Graphics);
                    //y += lineHeight;
                }
                if (dtprintfeatures.Rows[0]["address2"].ToString() != null)
                {
                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address2"].ToString(), 52), font10, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font10.GetHeight(e.Graphics);
                    y += lineHeight;
                }
                if (dtprintfeatures.Rows[0]["address3"].ToString() != null)
                {
                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address3"].ToString(), 48), font10, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font10.GetHeight(e.Graphics);
                    y += lineHeight;
                }
                if (dtprintfeatures.Rows[0]["address4"].ToString() != null)
                {
                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address4"].ToString(), 45), font10, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font10.GetHeight(e.Graphics);
                    y += lineHeight;
                }
                if (dtprintfeatures.Rows[0]["address5"].ToString() != null)
                {
                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address5"].ToString(), 55), font10, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font10.GetHeight(e.Graphics);
                    //y += lineHeight;
                }
                if (dtprintfeatures.Rows[0]["BillName"].ToString() != null)
                {
                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["BillName"].ToString(), 46), font12, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font12.GetHeight(e.Graphics);
                    y += lineHeight;
                }
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                y += 3;

                if (dtprintfeatures.Rows[0]["BillNo"].ToString() == "1")
                {
                    e.Graphics.DrawString("Bill No: " + dtBill.Rows[0]["InvoiceNo"].ToString() + ",   Date : " + DateTime.Now.ToString(), font9, sBrush, 0, y);
                    lineHeight = font10.GetHeight(e.Graphics);
                    y += lineHeight;
                }
                if (!(dtBill.Rows[0]["billtype"].ToString() == "3" || dtBill.Rows[0]["billtype"].ToString() == "4"))
                {
                    if (dtprintfeatures.Rows[0]["TableStatus"].ToString() == "1")
                    {
                        e.Graphics.DrawString("Table No: " + dtBill.Rows[0]["TableName"].ToString(), font9, sBrush, 0, y);
                        lineHeight = font9.GetHeight(e.Graphics);
                        y += lineHeight;
                    }

                    if (dtprintfeatures.Rows[0]["WaiterStatus"].ToString() == "1")
                    {
                        e.Graphics.DrawString("Waiter: " + dtBill.Rows[0]["Waiter"].ToString(), font9, sBrush, 0, y);
                        lineHeight = font9.GetHeight(e.Graphics);
                        y += lineHeight;
                    }
                }
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                y += 3;

                e.Graphics.DrawString("Sno", font9, sBrush, xSlno, y);
                e.Graphics.DrawString("Item Name", font9, sBrush, xitemaname, y);
                e.Graphics.DrawString("Price", font9, sBrush, xprice, y);
                e.Graphics.DrawString("Qty", font9, sBrush, xquantity, y);
                e.Graphics.DrawString("Amount", font9, sBrush, xamount, y);
                y += lineHeight;
                y += 3;

                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                y += 3;

                string currency = dtprintfeatures.Rows[0]["currency"].ToString();
                double total = 0, disc = 0, pckcharge = 0;
                lineHeight = font8.GetHeight(e.Graphics);
                int slnum = 1;
                for (int i = 0; i < dtBill.Rows.Count; i++)
                {
                    e.Graphics.DrawString(slnum.ToString(), font8, sBrush, xSlno, y);
                    e.Graphics.DrawString(dtBill.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);
                    //if (dtBill.Rows[i]["ItemArabic"].ToString() != "")
                    //{
                    //    y += lineHeight;
                    //    e.Graphics.DrawString(dtBill.Rows[i]["ItemArabic"].ToString(), fontarb, sBrush, xitemarabic, y);
                    //    y -= lineHeight;
                    //}
                    e.Graphics.DrawString(dtBill.Rows[i]["Rate"].ToString(), font8, sBrush, xprice, y);
                    e.Graphics.DrawString(dtBill.Rows[i]["Quntity"].ToString(), font8, sBrush, xquantity, y);
                    e.Graphics.DrawString(dtBill.Rows[i]["Amount"].ToString(), font8, sBrush, xamount, y);
                    total += Convert.ToDouble(dtBill.Rows[i]["Amount"]);
                    disc = Convert.ToDouble(dtBill.Rows[i]["discount"]);
                    pckcharge = Convert.ToDouble(dtBill.Rows[i]["PckCharge"]);
                    slnum += 1;
                    y += lineHeight;
                    y += lineHeight;
                }
                tot = total;
                y += lineHeight;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                y += 7;
                if (dtBill.Rows[0]["Compliment"].ToString() == "1")
                {
                    e.Graphics.DrawString("Total           :" + currency + "." + total.ToString("F2"), font15, sBrush, 40, y);
                    lineHeight = font20.GetHeight(e.Graphics);
                    y += lineHeight;
                    e.Graphics.DrawString("Complimentary Bill", font20, sBrush, 40, y);
                    y += lineHeight;
                }
                else
                {
                    y += 7;
                    if (Convert.ToDouble(dtBill.Rows[0]["PckCharge"]) > 0)
                    {
                        e.Graphics.DrawString("Packing Charge    : " + currency + "." + dtBill.Rows[0]["PckCharge"].ToString(), font10, sBrush, 40, y);
                        lineHeight = font15.GetHeight(e.Graphics);
                        y += lineHeight;
                    }
                    e.Graphics.DrawString("Total                     : " + currency + "." + total.ToString("F2"), font10, sBrush, 40, y);
                    lineHeight = font15.GetHeight(e.Graphics);
                    y += lineHeight;
                    e.Graphics.DrawString("Discount               : " + currency + "." + dtBill.Rows[0]["discount"].ToString(), font10, sBrush, 40, y);
                    y += lineHeight;
                    e.Graphics.DrawString("Net Value       : " + currency + "." + (total + Convert.ToDouble(dtBill.Rows[0]["PckCharge"].ToString()) - Convert.ToDouble(dtBill.Rows[0]["discount"].ToString())).ToString("F2"), font12, sBrush, 40, y);
                    y += lineHeight;
                }
                y += lineHeight;
                if (dtprintfeatures.Rows[0]["greeting1"].ToString() != null)
                {
                    if (dtprintfeatures.Rows[0]["GreetingFont"].ToString() == "Bold")
                    {
                        Fonts1 = myfontb1;
                    }
                    else
                    {
                        Fonts1 = myfonti1;
                    }

                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["greeting1"].ToString(), 60), Fonts1, sBrush, 0, y);
                    lineHeight = font9.GetHeight(e.Graphics);
                    y += lineHeight;

                }

                if (dtprintfeatures.Rows[0]["greeting2"].ToString() != null)
                {
                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["greeting2"].ToString(), 50), Fonts1, sBrush, 0, y);
                    lineHeight = font9.GetHeight(e.Graphics);
                    y += lineHeight;

                }
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));

                e.Graphics.DrawString("   www.loyalitsolutions.com", font9, sBrush, 0, y);
                y += lineHeight;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
            }
        }

        private void dgv_reprint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

       
    }
}
