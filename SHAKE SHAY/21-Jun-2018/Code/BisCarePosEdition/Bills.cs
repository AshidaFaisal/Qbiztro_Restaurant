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
using System.Drawing.Printing;

namespace BisCarePosEdition
{
    public partial class Bills : Form
    {
        Codebehind obj = new Codebehind();
        Font font20 = new Font("Arial", 20, GraphicsUnit.Point);
        Font font15 = new Font("Arial", 15, GraphicsUnit.Point);
        Font font8 = new Font("Arial", 8, GraphicsUnit.Point);
        Font font5 = new Font("Arial", 5, GraphicsUnit.Point);
        Font font9 = new Font("Arial", 9, GraphicsUnit.Point);
        Font font10 = new Font("Arial", 10, GraphicsUnit.Point);
        Font font12 = new Font("Arial", 12, GraphicsUnit.Point);
        SolidBrush sBrush = new SolidBrush(Color.Black);
        public Bills()
        {
            InitializeComponent();
        }

        private void Bills_Load(object sender, EventArgs e)
        {
            dgv_bills.Visible = true;
            dgv_billdetails.Visible = false;
            DataTable dt = new DataTable();
            dt = obj.getbills();
            dgv_bills.Visible = true;
            if( dt.Rows.Count > 0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)
            {
            dgv_bills.Rows.Add();
            dgv_bills[0, i].Value = i + 1; 
            dgv_bills[1, i].Value = dt.Rows[i]["InvoiceNo"].ToString();
            dgv_bills[2, i].Value = dt.Rows[i]["date"].ToString();
            dgv_bills[3, i].Value = dt.Rows[i]["TotalAmount"].ToString();
            //dgv_bills[3, i].Value = dt.Rows[i][""].ToString();


        
            }
    }
    }
        DataTable dtBill; 
        private void dgv_bills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex <= 4)
            {
                string msg = dgv_bills[1, e.RowIndex].Value.ToString();
                DataTable dt = new DataTable();
                dtBill = obj.PrintBill(msg);
                PrintBill();
            }
        }
        private void dgv_billdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_billdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_bills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && e.ColumnIndex <= 4)
            //{
            //    string msg = dgv_bills[1, e.RowIndex].Value.ToString();
            //    DataTable dt = new DataTable();
            //    dtBill = obj.PrintBill(msg);
            //    PrintBill();
            //}
        }

        private void dgv_bills_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                dgv_billdetails.Visible = true;
                string msg = dgv_bills[1, e.RowIndex].Value.ToString();
                DataTable dt = new DataTable();
                dt = obj.getbilldetails(msg);
                if (dt.Rows.Count > 0)
                {
                    dgv_billdetails.Visible = true;
                    dgv_bills.Visible = false;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgv_billdetails.Rows.Add();
                        dgv_billdetails[0, i].Value = i + 1;
                        dgv_billdetails[1, i].Value = dt.Rows[i]["ItemCode"].ToString();
                        dgv_billdetails[2, i].Value = dt.Rows[i]["ItemName"].ToString();

                    }
                }

            }

        }

        private void dgv_bills_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
              string msg = dgv_bills[1, e.RowIndex].Value.ToString();
                DataTable dt = new DataTable();
                dtBill = obj.PrintBill(msg);
                PrintBill();
            }
        
        public void PrintBill()
        {
            try
            {
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += this.Doc_PrintBill;
                //doc.PrinterSettings.PrinterName = "VENDOR THERMAL PRINTER";
                doc.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                //doc.OriginAtMargins = true;
                //PrintDocument doc1 = new PrintDocument();
                //doc1.PrintPage += this.Doc_PrintPageCounterBill;
                //doc1.PrinterSettings.PrinterName = File.ReadAllText("Printer.txt");
                //doc1.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                ////doc.OriginAtMargins = true;

                //try
                //{
                //    doc1.Print();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.ToString());
                //    // throw new ApplicationException("Printer Error");
                //}
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
        int counterId;
        private void Doc_PrintBill(object sender, PrintPageEventArgs e)
        {
            try
            {
                double tot = 0;
                if (dtBill.Rows.Count > 0)
                {
                    float x = e.MarginBounds.Left;
                    float y = 10;
                    int widtableh = e.PageBounds.Width;
                    int height = e.PageBounds.Height;
                    float lineHeight = font20.GetHeight(e.Graphics);
                    // float xSlno = 0;
                    float xitemaname = 0;
                    float xprice = 160;
                    float xquantity = 115;
                    float xamount = 200;



                    e.Graphics.DrawString(" Dinnies Family Restaurant", font15, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font15.GetHeight(e.Graphics);
                    y += lineHeight;
                    e.Graphics.DrawString("         Moonupeedika,Kaipamangalam", font10, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font10.GetHeight(e.Graphics);
                    y += lineHeight;
                    e.Graphics.DrawString("                         Thrissur", font10, new SolidBrush(Color.Black), 0, y);
                    y += lineHeight;
                    e.Graphics.DrawString("               Phone: 0480 2845 800", font10, new SolidBrush(Color.Black), 0, y);
                    y += lineHeight;
                    ////e.Graphics.DrawString("Email: thaninaadanfamilyrestaurant@gmail.com", font10, new SolidBrush(Color.Black), 0, y); 
                    ////y += lineHeight;
                    e.Graphics.DrawString("                   CASH BILL", font12, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font12.GetHeight(e.Graphics);
                    y += lineHeight;
                    y += 3;
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(260, Convert.ToInt32(y)));

                    y += 3;



                    e.Graphics.DrawString("Bill No: " + dtBill.Rows[0]["InvoiceNo"].ToString() + ",   Date : " + DateTime.Now.ToString(), font10, sBrush, 0, y);
                    lineHeight = font10.GetHeight(e.Graphics);
                    y += lineHeight;
                    if (counterId != 0)
                    {

                        DataTable dt = new DataTable();
                        dt = obj.EditCounter(counterId.ToString());
                        if (dt.Rows.Count > 0)
                        {
                            e.Graphics.DrawString("Counter : " + dt.Rows[0]["counter_name"].ToString().ToString(), font9, sBrush, 0, y);
                            //txt_countername.Text = dt.Rows[0]["counter_name"].ToString();
                            //txt_remarks.Text = dt.Rows[0]["remarks"].ToString();

                            //f = 1;
                        }

                        lineHeight = font9.GetHeight(e.Graphics);
                        y += lineHeight;
                        e.Graphics.DrawString("Cashier : " + obj.GetUsernameById(File.ReadAllText("user.txt")), font9, sBrush, 0, y);
                        lineHeight = font9.GetHeight(e.Graphics);
                        y += lineHeight;
                    }
                    //e.Graphics.DrawString("Waiter: " + dtBill.Rows[0]["Waiter"].ToString() + ",    Table No: " + dtBill.Rows[0]["TableName"].ToString(), font9, sBrush, 0, y);
                    e.Graphics.DrawString("Table No: " + dtBill.Rows[0]["TableName"].ToString(), font9, sBrush, 0, y);
                    lineHeight = font9.GetHeight(e.Graphics);
                    y += lineHeight;

                    e.Graphics.DrawString("WaiterCode: " + dtBill.Rows[0]["WaiterCode"].ToString(), font9, sBrush, 0, y);
                    lineHeight = font9.GetHeight(e.Graphics);
                    y += lineHeight;

                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(260, Convert.ToInt32(y)));
                    y += 3;
                    //  e.Graphics.DrawString("Slno", font9, sBrush, xSlno, y);
                    e.Graphics.DrawString("Itemname", font9, sBrush, xitemaname, y);

                    e.Graphics.DrawString("Price", font9, sBrush, xprice, y);

                    e.Graphics.DrawString("Qty", font9, sBrush, xquantity, y);

                    e.Graphics.DrawString("Value", font9, sBrush, xamount, y);

                    y += lineHeight;
                    y += 3;

                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(260, Convert.ToInt32(y)));
                    y += 3;

                    double total = 0;
                    lineHeight = font8.GetHeight(e.Graphics);
                    int slnum = 1;
                    for (int i = 0; i < dtBill.Rows.Count; i++)
                    {
                        // e.Graphics.DrawString(slnum.ToString(), font8, sBrush, xSlno, y);
                        e.Graphics.DrawString(dtBill.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);
                        e.Graphics.DrawString(dtBill.Rows[i]["Quntity"].ToString(), font8, sBrush, xquantity, y);
                        e.Graphics.DrawString(dtBill.Rows[i]["Rate"].ToString(), font8, sBrush, xprice, y);
                        e.Graphics.DrawString(dtBill.Rows[i]["Amount"].ToString(), font8, sBrush, xamount, y);

                        total += Convert.ToDouble(dtBill.Rows[i]["Amount"]);
                        slnum += 1;
                        y += lineHeight;
                    }
                    tot = total;
                    y += 3;
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(260, Convert.ToInt32(y)));
                    y += 3;
                    //if (ch_complimet.Checked == true)
                    //{
                    //    e.Graphics.DrawString("Total : Rs." + total.ToString("F2"), font15, sBrush, 60, y);
                    //    lineHeight = font20.GetHeight(e.Graphics);
                    //    y += lineHeight;
                    //    e.Graphics.DrawString("Complimentary Bill", font20, sBrush, 40, y);
                    //    y += lineHeight;
                    //}
                    //else
                    //{
                        if (Convert.ToDouble(dtBill.Rows[0]["discount"]) == 0)
                        {
                            e.Graphics.DrawString("Total : Rs." + total.ToString("F2"), font12, sBrush, 60, y);
                            lineHeight = font12.GetHeight(e.Graphics);
                            y += lineHeight;
                        }
                        else
                        {
                            e.Graphics.DrawString("Total : Rs." + total.ToString("F2"), font12, sBrush, 60, y);
                            lineHeight = font12.GetHeight(e.Graphics);
                            y += lineHeight;
                            e.Graphics.DrawString("   Discount : Rs." + dtBill.Rows[0]["discount"].ToString(), font10, sBrush, 60, y);
                            lineHeight = font10.GetHeight(e.Graphics);
                            y += lineHeight;
                            e.Graphics.DrawString("NetValue : Rs." + (total - Convert.ToDouble(dtBill.Rows[0]["discount"].ToString())).ToString("F2"), font12, sBrush, 60, y);
                            lineHeight = font12.GetHeight(e.Graphics);
                            y += lineHeight;
                        }
                    //}
                    //e.Graphics.DrawString("   This bill incl. all establish and service charge.", font9, sBrush, 0, y);
                    lineHeight = font9.GetHeight(e.Graphics);
                    y += lineHeight;
                    y += lineHeight;

                    //e.Graphics.DrawString(" ", font5, sBrush, 0, y);
                    //e.Graphics.DrawString(" ", font5, sBrush, 0, y);
                    e.Graphics.DrawString("              Thank you,Visit again.", font10, sBrush, 0, y);
                    lineHeight = font9.GetHeight(e.Graphics);
                    y += lineHeight;
                    y += lineHeight;

                    //e.Graphics.DrawString(" ", font5, sBrush, 0, y);
                    //e.Graphics.DrawString(" ", font5, sBrush, 0, y);
                    e.Graphics.DrawString("   www.loyalitsolutions.com", font5, sBrush, 0, y);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }
    }
}

