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
    public partial class PendingOT_S : Form
    {
        DataTable PKOTdin, PKOTtake;
        internal static DataTable dtCounterBill, dtBill;
        Font font20 = new Font("Arial", 20, GraphicsUnit.Point);
        Font font15 = new Font("Arial", 15, GraphicsUnit.Point);
        Font font8 = new Font("Arial", 8, GraphicsUnit.Point);
        Font font5 = new Font("Arial", 5, GraphicsUnit.Point);
        Font font9 = new Font("Arial", 9, GraphicsUnit.Point);
        Font font10 = new Font("Arial", 10, GraphicsUnit.Point);
        Font font12 = new Font("Arial", 12, GraphicsUnit.Point);
        SolidBrush sBrush = new SolidBrush(Color.Black);
        int counterId = Convert.ToInt32(File.ReadAllText("counter.txt"));
        public PendingOT_S()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
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
        private void PendingOT_S_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
                rd_DineIn.Checked = true;
                dgv_PendingKOTS.Visible = true;
                dgv_PendingKOTTakeAway.Visible = false;
                DataTable dt = new DataTable();
                dt = obj.GetPendingKOTDineIn();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgv_PendingKOTS.Rows.Add();
                        dgv_PendingKOTS[0, i].Value = i + 1;
                        dgv_PendingKOTS[1, i].Value = dt.Rows[i]["kotId"].ToString();
                        dgv_PendingKOTS[4 + 1, i].Value = dt.Rows[i]["ItemCode"].ToString();
                        dgv_PendingKOTS[5 + 1, i].Value = dt.Rows[i]["ItemName"].ToString();
                        dgv_PendingKOTS[7 + 1, i].Value = dt.Rows[i]["Quantity"].ToString();
                        dgv_PendingKOTS[8 + 1, i].Value = dt.Rows[i]["Rate"].ToString();
                        dgv_PendingKOTS[9 + 1, i].Value = Convert.ToDouble(dgv_PendingKOTS[9, i].Value) * Convert.ToDouble(dgv_PendingKOTS[8, i].Value);
                        dgv_PendingKOTS[6 + 1, i].Value = dt.Rows[i]["Unit"].ToString();
                        // dgv_PendingKOTS[10, i].Value = dt.Rows[i]["CustomerStatus"].ToString();
                        dgv_PendingKOTS[2 + 1, i].Value = dt.Rows[i]["TableName"].ToString();
                        dgv_PendingKOTS[3 + 1, i].Value = dt.Rows[i]["Waiter"].ToString();
                        dgv_PendingKOTS[10 + 1, i].Value = dt.Rows[i]["CustomerStatus"].ToString();
                        dgv_PendingKOTS[2, i].Value = dt.Rows[i]["Date"].ToString();


                    }


                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void rd_DineIn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_PendingKOTS.Rows.Clear();
                if (rd_DineIn.Checked == true)
                {
                    dgv_PendingKOTS.Visible = true;
                    dgv_PendingKOTTakeAway.Visible = false;


                    DataTable dt = new DataTable();
                    dt = obj.GetPendingKOTDineIn();

                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dgv_PendingKOTS.Rows.Add();
                            dgv_PendingKOTS[0, i].Value = i + 1;
                            dgv_PendingKOTS[1, i].Value = dt.Rows[i]["kotId"].ToString();
                            dgv_PendingKOTS[4 + 1, i].Value = dt.Rows[i]["ItemCode"].ToString();
                            dgv_PendingKOTS[5 + 1, i].Value = dt.Rows[i]["ItemName"].ToString();
                            dgv_PendingKOTS[7 + 1, i].Value = dt.Rows[i]["Quantity"].ToString();
                            dgv_PendingKOTS[8 + 1, i].Value = dt.Rows[i]["Rate"].ToString();
                            dgv_PendingKOTS[9 + 1, i].Value = Convert.ToDouble(dgv_PendingKOTS[7, i].Value) * Convert.ToDouble(dgv_PendingKOTS[8, i].Value);
                            dgv_PendingKOTS[6 + 1, i].Value = dt.Rows[i]["Unit"].ToString();
                            // dgv_PendingKOTS[10, i].Value = dt.Rows[i]["CustomerStatus"].ToString();
                            dgv_PendingKOTS[2 + 1, i].Value = dt.Rows[i]["TableName"].ToString();
                            dgv_PendingKOTS[3 + 1, i].Value = dt.Rows[i]["Waiter"].ToString();
                            dgv_PendingKOTS[10 + 1, i].Value = dt.Rows[i]["CustomerStatus"].ToString();
                            dgv_PendingKOTS[2, i].Value = dt.Rows[i]["Date"].ToString();

                        }


                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void rd_TakeAway_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_PendingKOTTakeAway.Rows.Clear();
                if (rd_TakeAway.Checked == true)
                {
                    dgv_PendingKOTS.Visible = false;
                    dgv_PendingKOTTakeAway.Visible = true;


                    DataTable dt = new DataTable();
                    dt = obj.GetPendingKOTTakeAway();
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dgv_PendingKOTTakeAway.Rows.Add();
                            dgv_PendingKOTTakeAway[0, i].Value = i + 1;
                            dgv_PendingKOTTakeAway[1, i].Value = dt.Rows[i]["kotId"].ToString();
                            dgv_PendingKOTTakeAway[3 + 1, i].Value = dt.Rows[i]["ItemCode"].ToString();
                            dgv_PendingKOTTakeAway[4 + 1, i].Value = dt.Rows[i]["ItemName"].ToString();
                            dgv_PendingKOTTakeAway[6 + 1, i].Value = dt.Rows[i]["Quantity"].ToString();
                            dgv_PendingKOTTakeAway[7 + 1, i].Value = dt.Rows[i]["Rate"].ToString();
                            dgv_PendingKOTTakeAway[8 + 1, i].Value = Convert.ToDouble((Convert.ToDouble(dgv_PendingKOTTakeAway[7, i].Value) * Convert.ToDouble(dgv_PendingKOTTakeAway[6, i].Value)).ToString("F2"));
                            dgv_PendingKOTTakeAway[5 + 1, i].Value = dt.Rows[i]["Unit"].ToString();
                            dgv_PendingKOTTakeAway[2 + 1, i].Value = dt.Rows[i]["Token"].ToString();
                            dgv_PendingKOTTakeAway[2, i].Value = dt.Rows[i]["Date"].ToString();
                            dgv_PendingKOTTakeAway[9 + 1, i].Value = dt.Rows[i]["Customermob"].ToString();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        //public void printKOTdin()
        //{
        //    try
        //    {
        //        //PrintDocument doc = new PrintDocument();
        //        //doc.PrintPage += this.Doc_PrintPageKOT;
        //        ////doc.PrinterSettings.PrinterName = "VENDOR THERMAL PRINTER";
        //        //doc.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
        //        PrintDocument doc1 = new PrintDocument();
        //        doc1.PrintPage += this.;
        //        doc1.PrinterSettings.PrinterName = File.ReadAllText("Printer.txt");
        //        doc1.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
        //        //doc.OriginAtMargins = true;

        //        try
        //        {
        //            doc1.Print();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.ToString());
        //            // throw new ApplicationException("Printer Error");
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
        //    }

        //}





        private void btn_kot_Click(object sender, EventArgs e)
        {
            //        try
            //        {
            //            if (rd_TakeAway.Checked == true)
            //            {
            //                DataTable dt = new DataTable();
            //                dt = obj.GetPendingKOTDineIn();
            //                //frm_pendingkotprint fp = new frm_pendingkotprint();
            //                //fp.Show();

            //                PKOTdin = dt;
            //                printKOTdin();


            //            }
            //            else if (rd_TakeAway.Checked == true)
            //            {

            //                DataTable dt = new DataTable();
            //                dt = obj.GetPendingKOTTakeAway();
            //                //frm_pendingkot2 fpt = new frm_pendingkot2();
            //                PKOTtake = dt;
            //                //fpt.Show();

            //            }

            //        }

            //        catch (Exception e)
            //        {


            //        }
            //    }
            //}
        }

        private void dgv_PendingKOTTakeAway_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        DataTable dtKOT, dtKOTTake;
        string msg = "0";
        private void dgv_PendingKOTS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (rd_DineIn.Checked == true)
                {
                    if (e.RowIndex >= 0 && e.ColumnIndex == 12)
                    {
                        msg = dgv_PendingKOTS[1, e.RowIndex].Value.ToString();
                        DataTable dt = new DataTable();
                        dt = obj.PrintKot(msg);
                        dtKOT = dt;
                        PrintKOT();
                    }
                }
                else if (rd_TakeAway.Checked == true)
                {
                    dgv_PendingKOTS.Visible = false;
                    dgv_PendingKOTTakeAway.Visible = true;
                    if (e.RowIndex >= 0 && e.ColumnIndex == 12)
                    {
                        msg = dgv_PendingKOTS[1, e.RowIndex].Value.ToString();
                        dgv_PendingKOTS.Visible = false;
                        DataTable dt = new DataTable();
                        dt = obj.PrintKotTake(msg);
                        dtKOTTake = dt;
                        PrintKOTTake();
                    }

                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }
        public void PrintKOT()
        {
            try
            {
                //PrintDocument doc = new PrintDocument();
                //doc.PrintPage += this.Doc_PrintPageKOT;
                ////doc.PrinterSettings.PrinterName = "VENDOR THERMAL PRINTER";
                //doc.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                PrintDocument doc1 = new PrintDocument();
                doc1.PrintPage += this.Doc_PrintPageKOT;
                doc1.PrinterSettings.PrinterName = File.ReadAllText("Printer.txt");
                doc1.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                //doc.OriginAtMargins = true;

                try
                {


                    doc1.Print();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    // throw new ApplicationException("Printer Error");
                }
                //try
                //{
                //    doc.Print();
                //}
                //catch (Exception e)
                //{
                //    MessageBox.Show("Printer Error");
                //}
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }
        private void Doc_PrintPageKOT(object sender, PrintPageEventArgs e)
        {
            try
            {
                if (dtKOT.Rows.Count > 0)
                {
                    float x = e.MarginBounds.Left;
                    float y = 10;
                    int widtableh = e.PageBounds.Width;
                    int height = e.PageBounds.Height;
                    float lineHeight = font20.GetHeight(e.Graphics);
                    float xSlno = 0;
                    float xitemaname = 40;
                    float xquantity = 200;
                    //e.Graphics.DrawString("  Dinnies Family Restaurant", font15, new SolidBrush(Color.Black), 0, y);
                    //lineHeight = font15.GetHeight(e.Graphics);
                    //y += lineHeight;
                    ////e.Graphics.DrawString("Email: thaninaadanfamilyrestaurant@gmail.com", font10, new SolidBrush(Color.Black), 0, y); 
                    ////y += lineHeight;
                    //e.Graphics.DrawString("                    Family Restaurant", font10, new SolidBrush(Color.Black), 0, y);
                    //y += lineHeight;
                    e.Graphics.DrawString("                    DUPLICATE KOT", font12, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font12.GetHeight(e.Graphics);
                    y += lineHeight;

                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));

                    y += 3;
                    //if (counterId != 0)
                    //{


                    //    DataTable dt = new DataTable();
                    //    dt = obj.EditCounter(counterId.ToString());
                    //    if (dt.Rows.Count > 0)
                    //    {
                    //        e.Graphics.DrawString("Counter : " + dt.Rows[0]["counter_name"].ToString().ToString(), font9, sBrush, 0, y);
                    //        //txt_countername.Text = dt.Rows[0]["counter_name"].ToString();
                    //        //txt_remarks.Text = dt.Rows[0]["remarks"].ToString();
                    //        //lineHeight = font9.GetHeight(e.Graphics);
                    //        //y += lineHeight;
                    //        //f = 1;
                    //    }
                    //    //e.Graphics.DrawString("Counter : " + obj.GetUsernameById(File.ReadAllText("user.txt")), font9, sBrush, 0, y);
                    //    lineHeight = font9.GetHeight(e.Graphics);
                    //    y += lineHeight;
                    //}

                    e.Graphics.DrawString("KOTNO: " + dtKOT.Rows[0]["kotno"].ToString(), font10, sBrush, 0, y);
                    lineHeight = font12.GetHeight(e.Graphics);
                    y += lineHeight;


                    e.Graphics.DrawString("Date: " + DateTime.Now.ToString(), font10, sBrush, 0, y);
                    lineHeight = font10.GetHeight(e.Graphics);
                    y += lineHeight;

                    // e.Graphics.DrawString("Waiter: " + dtKOT.Rows[0]["Waiter"].ToString(), font10, sBrush, 0, y);
                    lineHeight = font12.GetHeight(e.Graphics);
                    y += lineHeight;

                    //e.Graphics.DrawString("Department: " + dtKOT.Rows[0]["department"].ToString(), font10, sBrush, 0, y);
                    //lineHeight = font10.GetHeight(e.Graphics);
                    //y += lineHeight;

                    //lineHeight = font10.GetHeight(e.Graphics);

                    //y += lineHeight;



                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                    y += 3;
                    e.Graphics.DrawString("SNO", font9, sBrush, xSlno, y);
                    e.Graphics.DrawString("ITEM", font9, sBrush, xitemaname, y);
                    e.Graphics.DrawString("QTY", font9, sBrush, xquantity, y);

                    y += lineHeight;
                    y += 3;
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                    y += 3;
                    lineHeight = font8.GetHeight(e.Graphics);
                    int slnum = 1;
                    for (int i = 0; i < dtKOT.Rows.Count; i++)
                    {
                        e.Graphics.DrawString(slnum.ToString(), font8, sBrush, xSlno, y);
                        e.Graphics.DrawString(dtKOT.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);
                        e.Graphics.DrawString(dtKOT.Rows[i]["Quantity"].ToString(), font8, sBrush, xquantity, y);
                        slnum += 1;

                        y += lineHeight;
                    }
                    y += 3;
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                    y += 3;

                    //+ ",      Table no: " + dtKOT.Rows[0]["TableName"].ToString(), font10, sBrush, 0, y)
                    e.Graphics.DrawString("Waiter: " + dtKOT.Rows[0]["Waiter"].ToString() + "                                    T : " + dtKOT.Rows[0]["TableName"].ToString(), font10, sBrush, 0, y);

                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }
        public void PrintKOTTake()
        {
            try
            {
                //PrintDocument doc = new PrintDocument();
                //doc.PrintPage += this.Doc_PrintPageKOTTake;
                ////doc.PrinterSettings.PrinterName = "VENDOR THERMAL PRINTER";
                //doc.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                PrintDocument doc1 = new PrintDocument();
                doc1.PrintPage += this.Doc_PrintPageKOTTake;
                doc1.PrinterSettings.PrinterName = File.ReadAllText("Printer.txt");
                doc1.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                //doc.OriginAtMargins = true;

                try
                {
                    doc1.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    // throw new ApplicationException("Printer Error");
                }
                //try
                //{
                //    doc.Print();
                //}
                //catch (Exception e)
                //{
                //    MessageBox.Show("Printer Error");
                //}
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }
        private void Doc_PrintPageKOTTake(object sender, PrintPageEventArgs e)
        {
            try
            {
                if (dtKOTTake.Rows.Count > 0)
                {
                    float x = e.MarginBounds.Left;
                    float y = 10;
                    int widtableh = e.PageBounds.Width;
                    int height = e.PageBounds.Height;
                    float lineHeight = font20.GetHeight(e.Graphics);
                    float xSlno = 0;
                    float xitemaname = 40;
                    float xquantity = 200;
                    e.Graphics.DrawString("  Dinnies Family Restaurant", font15, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font15.GetHeight(e.Graphics);
                    y += lineHeight;
                    //e.Graphics.DrawString("                    Family Restaurant", font10, new SolidBrush(Color.Black), 0, y);
                    //y += lineHeight;
                    e.Graphics.DrawString("                    DUPLICATE KOT", font12, new SolidBrush(Color.Black), 0, y);

                    lineHeight = font12.GetHeight(e.Graphics);
                    y += lineHeight;
                    y += 3;
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));

                    y += 3;
                    if (counterId == 0)
                    {

                    }
                    else
                    {

                        DataTable dt = new DataTable();
                        dt = obj.EditCounter(counterId.ToString());
                        if (dt.Rows.Count > 0)
                        {
                            e.Graphics.DrawString("Counter : " + dt.Rows[0]["counter_name"].ToString().ToString(), font9, sBrush, 0, y);
                            //lineHeight = font9.GetHeight(e.Graphics);
                            //y += lineHeight;

                            //txt_countername.Text = dt.Rows[0]["counter_name"].ToString();
                            //txt_remarks.Text = dt.Rows[0]["remarks"].ToString();File.ReadAllText("user.txt")

                            //f = 1;
                        }
                        //e.Graphics.DrawString("Counter : " + obj.GetUsernameById(File.ReadAllText("user.txt")), font9, sBrush, 0, y);

                        lineHeight = font9.GetHeight(e.Graphics);
                        y += lineHeight;
                    }

                    e.Graphics.DrawString("KOT no: " + dtKOTTake.Rows[0]["kotId"].ToString() + ",   Date: " + DateTime.Now.ToString(), font10, sBrush, 0, y);
                    lineHeight = font10.GetHeight(e.Graphics);
                    y += lineHeight;

                    e.Graphics.DrawString("Token: " + dtKOTTake.Rows[0]["Token"].ToString(), font10, sBrush, 0, y);
                    lineHeight = font10.GetHeight(e.Graphics);
                    y += lineHeight;

                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                    y += 3;
                    e.Graphics.DrawString("Slno", font9, sBrush, xSlno, y);
                    e.Graphics.DrawString("Itemname", font9, sBrush, xitemaname, y);
                    e.Graphics.DrawString("      Quantity", font9, sBrush, xquantity, y);
                    y += lineHeight;
                    y += 3;
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                    y += 3;
                    lineHeight = font8.GetHeight(e.Graphics);
                    int slnum = 1;
                    for (int i = 0; i < dtKOTTake.Rows.Count; i++)
                    {
                        e.Graphics.DrawString(slnum.ToString(), font8, sBrush, xSlno, y);
                        e.Graphics.DrawString(dtKOTTake.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);
                        e.Graphics.DrawString(dtKOTTake.Rows[i]["Quantity"].ToString(), font8, sBrush, xquantity, y);
                        slnum += 1;
                        y += lineHeight;
                    }
                    y += 3;
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                    y += 3;
                }
            }

            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void dgv_PendingKOTTakeAway_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (rd_TakeAway.Checked == true)
            //    {
            //        dgv_PendingKOTS.Visible = false;
            //        dgv_PendingKOTTakeAway.Visible = true;
            //        if (e.RowIndex >= 0 && e.ColumnIndex == 12)
            //        {
            //            msg = dgv_PendingKOTS[1, e.RowIndex].Value.ToString();
            //            dgv_PendingKOTS.Visible = false;
            //            DataTable dt = new DataTable();
            //            dt = obj.PrintKotTake(msg);
            //            dtKOTTake = dt;
            //            PrintKOTTake();
            //        }

            //    }
            //}
            //catch (Exception ex)
            //{
            //    File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            //}

        }




        private void dgv_PendingKOTTakeAway_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (rd_TakeAway.Checked == true)
                {
                    dgv_PendingKOTS.Visible = false;
                    dgv_PendingKOTTakeAway.Visible = true;
                    if (e.RowIndex >= 0 && e.ColumnIndex == 12)
                    {
                        msg = dgv_PendingKOTS[1, e.RowIndex].Value.ToString();
                        dgv_PendingKOTS.Visible = false;
                        DataTable dt = new DataTable();
                        dt = obj.PrintKotTake(msg);
                        dtKOTTake = dt;
                        PrintKOTTake();
                    }

                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }


    }
}
     


