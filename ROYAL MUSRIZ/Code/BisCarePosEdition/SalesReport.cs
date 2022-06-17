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
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
            cmb_Cat.Enabled = false;
            cmb_item.Enabled = false;
            cmb_Waiter.Enabled = false;
            rd_custom.Checked = true;
        }
        DataTable dtprintfeatures;
        Codebehind obj = new Codebehind();
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
        private void SalesReport_Load(object sender, EventArgs e)
        {
            try
            {
                ch_BillType.Checked = true;
                ApplyTheme();
                DataSet ds4 = new DataSet();
                ds4 = obj.GetCategory(1);
                cmb_Cat.DataSource = ds4.Tables[0];
                cmb_Cat.DisplayMember = "Name";
                cmb_Cat.ValueMember = "Id";
                DataRow dr4 = ds4.Tables[0].NewRow();
                dr4["Name"] = "--Select One--";
                dr4["Id"] = "0";
                ds4.Tables[0].Rows.InsertAt(dr4, 0);
                cmb_Cat.SelectedIndex = 0;


                DataSet ds5 = new DataSet();
                ds5 = obj.GetItemCode();
                cmb_item.DataSource = ds5.Tables[0];
                cmb_item.DisplayMember = "ItemName";
                cmb_item.ValueMember = "Id";
                DataRow dr5 = ds5.Tables[0].NewRow();
                dr5["ItemName"] = "--Select One--";
                dr5["Id"] = "0";
                ds5.Tables[0].Rows.InsertAt(dr5, 0);
                cmb_item.SelectedIndex = 0;


                DataSet ds15 = new DataSet();
                ds15 = obj.GetUsername();
                cmb_user.DataSource = ds15.Tables[0];
                cmb_user.DisplayMember = "username";
                cmb_user.ValueMember = "user_id";
                DataRow dr15 = ds15.Tables[0].NewRow();
                dr15["username"] = "--Select One--";
                dr15["user_id"] = "0";
                ds15.Tables[0].Rows.InsertAt(dr15, 0);
                cmb_user.SelectedIndex = 0;

                DataSet ds = new DataSet();
                ds = obj.GetWaiter();
                cmb_Waiter.DataSource = ds.Tables[0];
                cmb_Waiter.DisplayMember = "Name";
                cmb_Waiter.ValueMember = "Id";
                DataRow dr = ds.Tables[0].NewRow();
                dr["Name"] = "--Select One--";
                dr["Id"] = "0";
                ds.Tables[0].Rows.InsertAt(dr, 0);
                cmb_Waiter.SelectedIndex = 0;

                ch_BillType.Checked = true;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
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
        private void btn_viewreport_Click(object sender, EventArgs e)
        {
            try
            {
                saletypee = saletype();

                int BillMode = 0;
                if (ch_BillType.Checked == true)
                {
                    if (rd_Dinein.Checked == true)
                        BillMode = 1;
                    if (rd_takeaway.Checked == true)
                        BillMode = 2;
                    if (rd_counterBill.Checked == true)
                        BillMode = 3;
                    if (rbtnAC.Checked == true)
                        BillMode = 4;
                    if (rbtnNonAC.Checked == true)
                        BillMode = 5;
                }




                {
                    if ((ch_Cat.Checked == true) && (ch_item.Checked == false) && (ch_Waiter.Checked == false))
                    {
                        if (Convert.ToDouble(cmb_Cat.SelectedValue) > 0)
                            mode = 4;
                        else
                        {
                            MessageBox.Show("Please Choose category ");
                            cmb_Cat.Focus();
                            return;
                        }

                    }
                    else
                    {
                        if ((ch_Cat.Checked == false) && (ch_item.Checked == true) && (ch_Waiter.Checked == false))
                        {
                            if (Convert.ToDouble(cmb_item.SelectedValue) > 0)
                                mode = 3;
                            else
                            {
                                MessageBox.Show("Please Choose item ");
                                cmb_item.Focus();
                                return;
                            }
                        }
                        else
                        {
                            if ((ch_Cat.Checked == false) && (ch_item.Checked == false) && (ch_Waiter.Checked == true))
                            {
                                if (Convert.ToDouble(cmb_Waiter.SelectedValue) > 0)
                                    mode = 2;
                                else
                                {
                                    MessageBox.Show("Please Choose waiter ");
                                    cmb_Waiter.Focus();
                                    return;
                                }
                            }
                            else
                            {
                                if ((ch_Cat.Checked == true) && (ch_item.Checked == true) && (ch_Waiter.Checked == false))
                                {
                                    if (Convert.ToDouble(cmb_Cat.SelectedValue) > 0)
                                    {
                                        if (Convert.ToDouble(cmb_item.SelectedValue) > 0)
                                        {
                                            mode = 5;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please Choose item ");
                                            cmb_item.Focus();
                                            return;
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Please Choose category ");
                                        cmb_Cat.Focus();
                                        return;
                                    }
                                }
                                else
                                {
                                    if ((ch_Cat.Checked == true) && (ch_item.Checked == false) && (ch_Waiter.Checked == true))
                                    {
                                        if (Convert.ToDouble(cmb_Cat.SelectedValue) > 0)
                                        {
                                            if (Convert.ToDouble(cmb_Waiter.SelectedValue) > 0)
                                            {
                                                mode = 6;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please Choose waiter ");
                                                cmb_Waiter.Focus();
                                                return;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please Choose category ");
                                            cmb_Cat.Focus();
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        if ((ch_Cat.Checked == false) && (ch_item.Checked == true) && (ch_Waiter.Checked == true))
                                        {
                                            if (Convert.ToDouble(cmb_Waiter.SelectedValue) > 0)
                                            {
                                                if (Convert.ToDouble(cmb_item.SelectedValue) > 0)
                                                {
                                                    mode = 7;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please Choose item ");
                                                    cmb_item.Focus();
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please Choose waiter ");
                                                cmb_Waiter.Focus();
                                                return;
                                            }

                                        }
                                        else
                                        {
                                            if ((ch_Cat.Checked == true) && (ch_item.Checked == true) && (ch_Waiter.Checked == true))
                                            {
                                                if (Convert.ToDouble(cmb_Waiter.SelectedValue) > 0)
                                                {
                                                    if (Convert.ToDouble(cmb_item.SelectedValue) > 0)
                                                    {
                                                        if (Convert.ToDouble(cmb_Cat.SelectedValue) > 0)
                                                        {
                                                            //FrmSaleReport obj = new FrmSaleReport(Convert.ToInt32(cmb_item.SelectedValue.ToString()), Convert.ToInt32(cmb_Cat.SelectedValue.ToString()), 8, Convert.ToInt32(cmb_Waiter.SelectedValue.ToString()), dtp_start.Value.ToShortDateString(), dtp_end.Value);
                                                            //obj.ShowDialog();
                                                            mode = 8;
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Please Choose category ");
                                                            cmb_Cat.Focus();
                                                            return;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please Choose item ");
                                                        cmb_item.Focus();
                                                        return;
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please Choose waiter ");
                                                    cmb_Waiter.Focus();
                                                    return;
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (chk_user.Checked == true)//check Choose Cashier
                {
                    if (Convert.ToDouble(cmb_user.SelectedValue) > 0)
                    {
                        cashiername = cmb_user.Text;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Cashier ");
                        cmb_user.Focus();
                        return;
                    }
                }
                cashierid = 0;
                cashiername = "";
                Int32.TryParse(cmb_user.SelectedValue.ToString(), out cashierid);
                if (cashierid > 0)
                    cashiername = cmb_user.Text;




                FrmSaleReport obj = new FrmSaleReport(Convert.ToInt32(cmb_item.SelectedValue.ToString()), Convert.ToInt32(cmb_Cat.SelectedValue.ToString()), BillMode, Convert.ToInt32(cmb_Waiter.SelectedValue.ToString()), dtp_start.Value.ToShortDateString(), dtp_end.Value, saletypee, cashierid, cashiername);
                obj.ShowDialog();
                cmb_Waiter.SelectedIndex = 0;
                cmb_item.SelectedIndex = 0;
                cmb_Cat.SelectedIndex = 0;
                //radioalltype.Checked = true;

                cmb_user.SelectedIndex = 0;//cashier combobox index


            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }


        public int cashierid;
        public string cashiername;
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ch_Waiter_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Waiter.Checked == true)
            {
                cmb_Waiter.Enabled = true;
                cmb_Waiter.Focus();
            }
            else
            {
                cmb_Waiter.Enabled = false;
                cmb_Waiter.SelectedIndex = 0;
            }
        }

        private void ch_Cat_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Cat.Checked == true)
            {
                cmb_Cat.Enabled = true;
                cmb_Cat.Focus();
            }
            else
            {
                cmb_Cat.Enabled = false;
                cmb_Cat.SelectedIndex = 0;
            }
        }

        private void ch_item_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_item.Checked == true)
            {
                cmb_item.Enabled = true;
                cmb_item.Focus();
            }
            else
            {
                cmb_item.Enabled = false;
                cmb_item.SelectedIndex = 0;
            }
        }

        private void dtp_start_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_end.Focus();
            }
        }

        private void dtp_end_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Waiter.Focus();
            }
        }

        private void cmb_Waiter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Cat.Focus();
            }
        }

        private void cmb_Cat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_item.Focus();
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
        int mode = 0;
        /*Button print*/
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int BillMode1 = 0;
                if (ch_BillType.Checked == true)
                {
                    if (rd_Dinein.Checked == true)
                        BillMode1 = 1;
                    if (rd_takeaway.Checked == true)
                        BillMode1 = 2;
                    if (rd_counterBill.Checked == true)
                        BillMode1 = 3;
                    if (rbtnAC.Checked == true)
                        BillMode1 = 4;
                    if (rbtnNonAC.Checked == true)
                        BillMode1 = 5;
                }
                saletypee = saletype();

                Int32.TryParse(cmb_user.SelectedValue.ToString(), out cashierid);
                if (cashierid > 0)
                    cashiername = cmb_user.Text;

                if ((ch_Cat.Checked == false) && (ch_item.Checked == false) && (ch_Waiter.Checked == false))
                {
                    mode = 1;
                }
                else
                {
                    if ((ch_Cat.Checked == true) && (ch_item.Checked == false) && (ch_Waiter.Checked == false))
                    {
                        if (Convert.ToDouble(cmb_Cat.SelectedValue) > 0)
                            mode = 4;
                        else
                        {
                            MessageBox.Show("Please Choose category ");
                            cmb_Cat.Focus();
                        }

                    }
                    else
                    {
                        if ((ch_Cat.Checked == false) && (ch_item.Checked == true) && (ch_Waiter.Checked == false))
                        {
                            if (Convert.ToDouble(cmb_item.SelectedValue) > 0)
                                mode = 3;
                            else
                            {
                                MessageBox.Show("Please Choose item ");
                                cmb_item.Focus();
                            }
                        }
                        else
                        {
                            if ((ch_Cat.Checked == false) && (ch_item.Checked == false) && (ch_Waiter.Checked == true))
                            {
                                if (Convert.ToDouble(cmb_Waiter.SelectedValue) > 0)
                                    mode = 2;
                                else
                                {
                                    MessageBox.Show("Please Choose waiter ");
                                    cmb_Waiter.Focus();
                                }
                            }
                            else
                            {
                                if ((ch_Cat.Checked == true) && (ch_item.Checked == true) && (ch_Waiter.Checked == false))
                                {
                                    if (Convert.ToDouble(cmb_Cat.SelectedValue) > 0)
                                    {
                                        if (Convert.ToDouble(cmb_item.SelectedValue) > 0)
                                        {
                                            mode = 5;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please Choose item ");
                                            cmb_item.Focus();
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Please Choose category ");
                                        cmb_Cat.Focus();
                                    }
                                }
                                else
                                {
                                    if ((ch_Cat.Checked == true) && (ch_item.Checked == false) && (ch_Waiter.Checked == true))
                                    {
                                        if (Convert.ToDouble(cmb_Cat.SelectedValue) > 0)
                                        {
                                            if (Convert.ToDouble(cmb_Waiter.SelectedValue) > 0)
                                            {
                                                mode = 6;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please Choose waiter ");
                                                cmb_Waiter.Focus();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please Choose category ");
                                            cmb_Cat.Focus();
                                        }
                                    }
                                    else
                                    {
                                        if ((ch_Cat.Checked == false) && (ch_item.Checked == true) && (ch_Waiter.Checked == true))
                                        {
                                            if (Convert.ToDouble(cmb_Waiter.SelectedValue) > 0)
                                            {
                                                if (Convert.ToDouble(cmb_item.SelectedValue) > 0)
                                                {
                                                    mode = 7;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please Choose item ");
                                                    cmb_item.Focus();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please Choose waiter ");
                                                cmb_Waiter.Focus();
                                            }

                                        }
                                        else
                                        {
                                            if ((ch_Cat.Checked == true) && (ch_item.Checked == true) && (ch_Waiter.Checked == true))
                                            {
                                                if (Convert.ToDouble(cmb_Waiter.SelectedValue) > 0)
                                                {
                                                    if (Convert.ToDouble(cmb_item.SelectedValue) > 0)
                                                    {
                                                        if (Convert.ToDouble(cmb_Cat.SelectedValue) > 0)
                                                        {
                                                            //FrmSaleReport obj = new FrmSaleReport(Convert.ToInt32(cmb_item.SelectedValue.ToString()), Convert.ToInt32(cmb_Cat.SelectedValue.ToString()), 8, Convert.ToInt32(cmb_Waiter.SelectedValue.ToString()), dtp_start.Value.ToShortDateString(), dtp_end.Value);
                                                            //obj.ShowDialog();
                                                            mode = 8;
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Please Choose category ");
                                                            cmb_Cat.Focus();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please Choose item ");
                                                        cmb_item.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please Choose waiter ");
                                                    cmb_Waiter.Focus();
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                //choose cashier check
                if (chk_user.Checked == true)
                {
                    if (Convert.ToDouble(cmb_user.SelectedValue) > 0)
                    {
                        cashiername = cmb_user.Text;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Cashier ");
                        cmb_user.Focus();
                        return;
                    }
                }


                if (mode > 0)
                {
                    dtCounterBill = cb.ReportofSales(dtp_start.Value, dtp_end.Value, Convert.ToInt32(cmb_Cat.SelectedValue), BillMode1, Convert.ToInt32(cmb_item.SelectedValue), Convert.ToInt32(cmb_Waiter.SelectedValue), saletypee, Convert.ToInt32(cmb_user.SelectedValue));
                    dtComplimentary = cb.ReportofSalesComplimentary(dtp_start.Value, dtp_end.Value, Convert.ToInt32(cmb_Cat.SelectedValue), mode, Convert.ToInt32(cmb_item.SelectedValue), Convert.ToInt32(cmb_Waiter.SelectedValue), saletypee, Convert.ToInt32(cmb_user.SelectedValue));
                    if (dtCounterBill.Rows.Count > 0 || dtComplimentary.Rows.Count > 0)
                    {
                        PrintCounterBill();
                        //radioalltype.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("Not Such Reports Found", "Warnig", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        Codebehind cb = new Codebehind();
        DataTable dtCounterBill, dtComplimentary;

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
            //float xSlno = 0;
            //float xbilltype = 30;
            float xitemaname = 0;

            float xprice = 150;
            float xquantity = 200;
            float xamount = 240;

            y = 0;
            dtprintfeatures = obj.getprinterfeatures();
            if (dtprintfeatures.Rows[0]["logo"].ToString() == "1")
            {
                if (File.Exists(Application.StartupPath + "\\logo.jpg"))
                {
                    string path = Application.StartupPath + "\\logo.jpg";
                    Image r = Image.FromFile(path);
                    Point p = new Point(82, 0);
                    e.Graphics.DrawImage(r, p);
                    y += lineHeight;
                    y += 3;
                }
                y += lineHeight;
                y += 3;
                y += 3;
            }
           
            if (dtprintfeatures.Rows[0]["address1"].ToString() != null)
            {
                e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address1"].ToString(), 30), font15, new SolidBrush(Color.Black),0, y);
                lineHeight = font12.GetHeight(e.Graphics);
                y += lineHeight;
  
            }
            if (dtprintfeatures.Rows[0]["address2"].ToString() != null)
            {
                e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address2"].ToString(),42 ), font12, new SolidBrush(Color.Black), 0, y);
                lineHeight = font12.GetHeight(e.Graphics);
                y += lineHeight;
            }
            if (dtprintfeatures.Rows[0]["address3"].ToString() != null)
            {
                e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address3"].ToString(), 39), font12, new SolidBrush(Color.Black), 0, y);
                lineHeight = font12.GetHeight(e.Graphics);
                y += lineHeight; 
            }
           
            e.Graphics.DrawString("            SALES  REPORT", font12, new SolidBrush(Color.Black), 0, y);
            lineHeight = font12.GetHeight(e.Graphics);
            y += lineHeight;
            y += 3;
            e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(300, Convert.ToInt32(y)));

            y += 3;

          
            if (cashierid > 0) //if cashier exist    
            {
                e.Graphics.DrawString("Start Date: " + dtp_start.Value.ToShortDateString() + "      " + getsaletype() + "Cashier : " + cashiername, font9, sBrush, 0, y);
                lineHeight = font9.GetHeight(e.Graphics);
                y += lineHeight;
            }

            else
            {
                e.Graphics.DrawString("Start Date: " + dtp_start.Value.ToShortDateString() + "      " + getsaletype() + " ", font9, sBrush, 0, y);
                lineHeight = font9.GetHeight(e.Graphics);
                y += lineHeight;
            }

            e.Graphics.DrawString("End Date:   " + dtp_end.Value.ToShortDateString(), font9, sBrush, 0, y);
            lineHeight = font9.GetHeight(e.Graphics);
            y += lineHeight;
            y += 3;
            if (dtCounterBill.Rows.Count > 0)
            {
                e.Graphics.DrawString("Non Complimentary Sales Report", font12, new SolidBrush(Color.Black), 10, y);
                lineHeight = font12.GetHeight(e.Graphics);
                y += lineHeight;
                lineHeight = font8.GetHeight(e.Graphics);
                y += lineHeight;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(300, Convert.ToInt32(y)));
                y += 3;
                //e.Graphics.DrawString("KotNo", font9, sBrush, xSlno, y);
                //e.Graphics.DrawString("Bill Type", font9, sBrush, xbilltype, y);
                e.Graphics.DrawString("Itemname", font9, sBrush, xitemaname, y);
                e.Graphics.DrawString("Price", font9, sBrush, xprice, y);
                e.Graphics.DrawString("Qty", font9, sBrush, xquantity, y);
                e.Graphics.DrawString("Amount", font9, sBrush, xamount, y);



                //e.Graphics.DrawString("Deleted Kot Date", font9, sBrush, xdate, y);
                y += lineHeight;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(300, Convert.ToInt32(y)));
                y += 3;

                double total = 0, disc = 0, TaxAmt = 0,TotWithTax=0 ;
                lineHeight = font8.GetHeight(e.Graphics);
                int slnum = 1;
                for (int i = 0; i < dtCounterBill.Rows.Count; i++)
                {
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["KOTNo"].ToString(), font8, sBrush, xSlno, y);
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["Status1"].ToString(), font9, sBrush, xbilltype, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["rate"].ToString(), font8, sBrush, xprice, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["quantity"].ToString(), font8, sBrush, xquantity, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["amount"].ToString(), font8, sBrush, xamount, y);
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["DeletedInvoiceDate"].ToString(), font9, sBrush, xdate, y);
                    total += Convert.ToDouble(dtCounterBill.Rows[i]["amount"]);
                    disc += Convert.ToDouble(dtCounterBill.Rows[i]["Column1"]);
                    TaxAmt += Convert.ToDouble(dtCounterBill.Rows[i]["Tax_Amt"]);
                    slnum += 1;
                    y += lineHeight;
                }

                //---Toatal With Tax----//
                TotWithTax = total + TaxAmt;
                //----------------------//


                tot = total;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(300, Convert.ToInt32(y)));
                y += 7;


                e.Graphics.DrawString("Taxable       : Rs." + total.ToString("F2"), font15, sBrush, 40, y);
                lineHeight = font20.GetHeight(e.Graphics);
                y += lineHeight;

                e.Graphics.DrawString("Tax              : Rs." + TaxAmt.ToString("F2"), font15, sBrush, 40, y);
                lineHeight = font20.GetHeight(e.Graphics);
                y += lineHeight;

                e.Graphics.DrawString("Total            : Rs." + TotWithTax.ToString("F2"), font15, sBrush, 40, y);
                lineHeight = font20.GetHeight(e.Graphics);
                y += lineHeight;
                //e.Graphics.DrawString("Discount      : Rs." + disc.ToString("F2"), font15, sBrush, 40, y);
                //lineHeight = font20.GetHeight(e.Graphics);
                //y += lineHeight;
                //double net = total - disc;
                //e.Graphics.DrawString("Net Amount : Rs." + net.ToString("F2"), font15, sBrush, 40, y);
                //lineHeight = font20.GetHeight(e.Graphics);
                //y += lineHeight;
            }
            //y += lineHeight;
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
                e.Graphics.DrawString("Itemname", font9, sBrush, xitemaname, y);

                e.Graphics.DrawString("Price", font9, sBrush, xprice, y);
                e.Graphics.DrawString("Qty", font9, sBrush, xquantity, y);
                e.Graphics.DrawString("Amount", font9, sBrush, xamount, y);

                //e.Graphics.DrawString("Deleted Kot Date", font9, sBrush, xdate, y);
                y += lineHeight;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(300, Convert.ToInt32(y)));
                y += 3;

                double totalc = 0;
                lineHeight = font8.GetHeight(e.Graphics);
                int slnum1 = 1;
                for (int i = 0; i < dtComplimentary.Rows.Count; i++)
                {
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["KOTNo"].ToString(), font8, sBrush, xSlno, y);
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["Status1"].ToString(), font9, sBrush, xbilltype, y);
                    e.Graphics.DrawString(dtComplimentary.Rows[i]["ItemName"].ToString(), font8, sBrush,xitemaname, y);
                    e.Graphics.DrawString(dtComplimentary.Rows[i]["rate"].ToString(), font8, sBrush, xprice, y);
                    e.Graphics.DrawString(dtComplimentary.Rows[i]["quantity"].ToString(), font8, sBrush, xquantity, y);
                    e.Graphics.DrawString(dtComplimentary.Rows[i]["amount"].ToString(), font8, sBrush, xamount, y);
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["DeletedInvoiceDate"].ToString(), font9, sBrush, xdate, y);
                    totalc += Convert.ToDouble(dtComplimentary.Rows[i]["amount"]);
                    slnum1 += 1;
                    y += lineHeight;
                }
                tot = totalc;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(300, Convert.ToInt32(y)));
                y += 7;
              /////ANY STRING TOM DRAW///
                e.Graphics.DrawString("Total : Rs." + totalc.ToString("F2"), font15, sBrush, 40, y);
                lineHeight = font20.GetHeight(e.Graphics);
                y += lineHeight;
            }
           // e.Graphics.DrawString("              Thank you, See you soon.", font10, sBrush, 0, y);


        }

        private void dtp_end_ValueChanged(object sender, EventArgs e)
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
                // double days = (dtp_end.Value).Days;
                //rd_monthly.Checked = true;
                dtp_end.Value = DateTime.Now;
                dtp_start.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day);
                f = 0;
                // dtp_start.Value = DateTime(dtp_start.Year, dtp_start.Month, 1);
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

        private void dtp_start_ValueChanged(object sender, EventArgs e)
        {
            if (f == 0)
            {
                DateChanging();
            }
        }

        private void cmb_Cat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_Cat.DroppedDown)
            {
                cmb_Cat.Focus();

            }
        }

        private void cmb_item_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_item.DroppedDown)
            {
                cmb_item.Focus();

            }
        }

        private void cmb_Waiter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_Waiter.DroppedDown)
            {
                cmb_Waiter.Focus();

            }
        }

        private void radioalltype_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radiocash_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radiocredit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_user_CheckedChanged(object sender, EventArgs e)
        {
            cmb_user.SelectedIndex = 0;
            if (chk_user.Checked == true)
            {
                groupBox5.Enabled = true;

            }
            else
            {
                groupBox5.Enabled = false;

            }
        }

        private void rd_counterBill_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnNonAC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rd_takeaway_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_Waiter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_user_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grp_Waiter_Enter(object sender, EventArgs e)
        {

        }

      

       
    }
}
