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
namespace BisCarePosEdition
{
    public partial class DeleteBill : Form
    {
        public DeleteBill()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        string ID;
        int k = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
            dgv_InvoiceDetails.Rows.Clear();
            dgv_test.Rows.Clear();
            int j;
            DataTable dt = new DataTable();
            dt = obj.InvoiceDatails(txt_InvoiceNo.Text);
            for (j = 0; j < dt.Rows.Count; j++)
            {
                dgv_InvoiceDetails.Rows.Add();
                dgv_InvoiceDetails[0,j].Value=j+1;
                dgv_InvoiceDetails[1,j].Value=dt.Rows[j]["kotId"].ToString();
                dgv_InvoiceDetails[2,j].Value=dt.Rows[j]["ItemCode"].ToString();
                dgv_InvoiceDetails[3,j].Value=dt.Rows[j]["ItemName"].ToString();
                dgv_InvoiceDetails[4,j].Value=dt.Rows[j]["Quntity"].ToString();
              //if(  dt.Rows[j]["Compliment"].ToString()=="1")
              //  dgv_InvoiceDetails[5, j].Value = "Yes";
              //else
              //    dgv_InvoiceDetails[5, j].Value = "No";

              //dgv_InvoiceDetails[6, j].Value = Convert.ToDouble(dt.Rows[j]["TotalAmount"].ToString()) ;
            
            }
           
            SqlDataReader dr = obj.GetInvoiceMasterDetail(txt_InvoiceNo.Text);
            if (dr.Read())
            {
                ID = dr[0].ToString();
                if(dr[4].ToString()=="1")
                {
                     lbl_BilType.Text="Dine In";
                }
                if (dr[4].ToString() == "2")
                {
                    lbl_BilType.Text = "Teke Away";
                }
                if (dr[4].ToString() == "3")
                {
                    lbl_BilType.Text = "Counter Bill";
                }
               
                lbl_Name.Text=dr[3].ToString();
                lbl_total.Text=dr[5].ToString();
                dtp_date.Value = Convert.ToDateTime(dr[2].ToString());
            dr.Close();
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SearchBill s = new SearchBill();
                s.ShowDialog();
                if (s.dr == DialogResult.OK)
                {
                    txt_InvoiceNo.Text = s.InNo;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }



        }
        string custname, custmon, custemil, status, totalamnt,invoiceNo,Invoiceid,comp,discount;
        DateTime date;
        
        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Do You Want to Delete This Record ??", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;
            if (DeleteStatus == "1")
            {
                if (dgv_InvoiceDetails.Rows.Count > 0)
                {
                    string st = obj.GetBillingSt(ID);
                    if (st == "0")
                    {
                        SqlDataReader dt = obj.GetAllInvoiceMasterDetails(ID);
                        if (dt.Read())
                        {
                            totalamnt = dt[0].ToString();
                            status = dt[1].ToString();
                            custname = dt[4].ToString();
                            custmon = dt[2].ToString();
                            custemil = dt[3].ToString();
                            date = Convert.ToDateTime(dt[5].ToString());
                            Invoiceid = dt[7].ToString();
                            invoiceNo = dt[6].ToString();
                            comp = dt[8].ToString();
                            discount = dt[9].ToString();

                        }
                        string id = obj.InsertDeletedInvoiceMaster(invoiceNo, date, custname, custmon, custemil, status, totalamnt, Invoiceid, comp, discount);
                        DataTable dt1 = obj.GetAllInvoiceDetails(ID);
                        for (int s = 0; s < dt1.Rows.Count; s++)
                        {
                            dgv_test.Rows.Add();
                            dgv_test[0, s].Value = dt1.Rows[s]["Token"].ToString();
                            dgv_test[1, s].Value = dt1.Rows[s]["WaiterId"].ToString();
                            dgv_test[2, s].Value = dt1.Rows[s]["TableId"].ToString();
                            dgv_test[3, s].Value = dt1.Rows[s]["kotId"].ToString();
                            dgv_test[4, s].Value = dt1.Rows[s]["Amount"].ToString();
                            dgv_test[5, s].Value = dt1.Rows[s]["Rate"].ToString();
                            dgv_test[6, s].Value = dt1.Rows[s]["Quntity"].ToString();
                            dgv_test[7, s].Value = dt1.Rows[s]["ItemId"].ToString();
                            dgv_test[8, s].Value = id;
                        }
                        for (int j = 0; j < dgv_test.Rows.Count; j++)
                        {
                            obj.InsertDeletedInvoiceDetails(dgv_test[8, j].Value.ToString(), dgv_test[7, j].Value.ToString(), dgv_test[6, j].Value.ToString(), dgv_test[5, j].Value.ToString(), dgv_test[4, j].Value.ToString(), dgv_test[3, j].Value.ToString(), dgv_test[2, j].Value.ToString(), dgv_test[1, j].Value.ToString(), dgv_test[0

                                , j].Value.ToString());
                        }
                        obj.DeleteBill(ID);
                        MessageBox.Show("Invoice successfully deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgv_InvoiceDetails.Rows.Clear();
                        clear();
                        txt_InvoiceNo.Text = "";
                        txt_InvoiceNo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Invoice alreday in use.So you can not delete this Invoice", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_InvoiceNo.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please select an Invoice for delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_InvoiceNo.Focus();
                }
            }
            else
            {

                MessageBox.Show("You Do Not Have The Permission To Delete Invoice", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
        private void DeleteBill_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
            DataTable dt1 = new DataTable();
            dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "DeleteBill");
            SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
            UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
            DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();
            this.ActiveControl = txt_InvoiceNo;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void btn_reset_Paint(object sender, PaintEventArgs e)
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
        public void clear()
        {
            lbl_BilType.Text = "";
            lbl_Name.Text = "";
            lbl_total.Text = "";
        }

        private void btn_reset_MouseEnter(object sender, EventArgs e)
        {
            k = 1;
            btn_reset.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_reset_Paint);
        }

        private void btn_reset_MouseLeave(object sender, EventArgs e)
        {
            k = 0;
            btn_reset.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_reset_Paint);
        }
    }
}
