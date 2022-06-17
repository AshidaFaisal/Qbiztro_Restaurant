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
using System.IO;

namespace BisCarePosEdition
{
    public partial class SearchBill : Form
    {
        public SearchBill()
        {
            InitializeComponent();
        }

        Codebehind ObjCode = new Codebehind();
        int f = 0;
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
                this.DoubleBuffered = true;
                ApplyTheme();
            this.ActiveControl = cboxTable;
            DataSet ds5 = new DataSet();
            ds5 = ObjCode.GetItem();
            cboxItem.DataSource = ds5.Tables[0];
            cboxItem.DisplayMember = "ItemName";
            cboxItem.ValueMember = "Id";
            DataRow dr5 = ds5.Tables[0].NewRow();
            dr5["ItemName"] = "--Select One--";
            dr5["Id"] = "0";
            ds5.Tables[0].Rows.InsertAt(dr5, 0);
            cboxItem.SelectedIndex = 0;

            DataSet ds = new DataSet();
            ds = ObjCode.GetWaiter();
            cboxWaiter.DataSource = ds.Tables[0];
            cboxWaiter.DisplayMember = "Name";
            cboxWaiter.ValueMember = "Id";
            DataRow dr= ds.Tables[0].NewRow();
            dr["Name"] = "--Select One--";
            dr["Id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboxWaiter.SelectedIndex = 0;

            DataSet ds1 = new DataSet();
            ds1 = ObjCode.GetTable();
            cboxTable.DataSource = ds1.Tables[0];
            cboxTable.DisplayMember = "TableName";
            cboxTable.ValueMember = "Id";
            DataRow dr1 = ds1.Tables[0].NewRow();
            dr1["TableName"] = "--Select One--";
            dr1["Id"] = "0";
            ds1.Tables[0].Rows.InsertAt(dr1, 0);
            cboxTable.SelectedIndex = 0;

            DataSet ds11 = new DataSet();
            ds11 = ObjCode.GetInvoiceCombo();
            cboxInvoice.DataSource = ds11.Tables[0];
            cboxInvoice.DisplayMember = "InvoiceNo";
            cboxInvoice.ValueMember = "Id";
            DataRow dr11 = ds11.Tables[0].NewRow();
            dr11["InvoiceNo"] = "--Select One--";
            dr11["Id"] = "0";
            ds11.Tables[0].Rows.InsertAt(dr11, 0);
            cboxInvoice.SelectedIndex = 0;

            grp_tableWaiter.Enabled = true;
            grp_Invoice.Enabled = false;
            grpItem.Enabled = false;
            grpTable.Enabled = false;
            grpWaiter.Enabled = false;
            f = 1;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }      
        }

        //string myDate = dtpStartDate.Value.ToString("yyyy-MM-dd");

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
            dgv_SearchInvoice.Rows.Clear();
            string queryStr=string.Empty;
             string start = dtpStartDate.Value.ToString("yyyy-MM-dd");
            string end=dtpEndDate.Value.ToString("yyyy-MM-dd");
            if (rd_DineIn.Checked == true)
            {
                queryStr = "SELECT max( dbo.tbInvoice.InvoiceNo)as InvoiceNo ,max( dbo.tbInvoice.TotalAmount)as TotalAmount,max( dbo.tbInvoice.InvoiceDate)as date , max(dbo.tbInvoice.Status)as Status ,max( dbo.tbInvoice.CustomerName)as CustomerName ,max(dbo.tbInvoiceDetails.kotId) as kotId,max( dbo.tbInvoiceDetails.TableId)as TableId, max(dbo.tbInvoiceDetails.WaiterId) as WaiterId ";

                queryStr = queryStr + "FROM dbo.tbInvoiceDetails INNER JOIN dbo.tbInvoice ON dbo.tbInvoiceDetails.InvoiceId = dbo.tbInvoice.Id where (dbo.tbInvoice.Status=1) and  cast((convert(varchar(10),dbo.tbInvoice.date,120)) as date) between  cast('" + start + "'as date) and cast ('" + end + "'as date)  ";
                if (chkbxItem.Checked == true)
                {
                    queryStr = queryStr + " and  dbo.tbInvoiceDetails.ItemId=" + cboxItem.SelectedValue.ToString();
                }
                if (chkInvoice.Checked == true)
                {
                    queryStr = queryStr + " and  dbo.tbInvoice.Id=" + cboxInvoice.SelectedValue.ToString();
                }
                if (chkTable.Checked == true)
                {
                    queryStr = queryStr + " and  dbo.tbInvoiceDetails.TableId=" + cboxTable.SelectedValue.ToString();
                }
                if (chkWaiter.Checked == true)
                {
                    queryStr = queryStr + " and  dbo.tbInvoiceDetails.WaiterId=" + cboxWaiter.SelectedValue.ToString();
                }
                queryStr = queryStr + " GROUP BY dbo.tbInvoiceDetails.InvoiceId";
            }

            if (rd_TakeAway.Checked == true)
            {
                queryStr = "SELECT max( dbo.tbInvoice.InvoiceNo)as InvoiceNo ,max( dbo.tbInvoice.TotalAmount)as TotalAmount,max( dbo.tbInvoice.InvoiceDate)as date , max(dbo.tbInvoice.Status)as Status ,max( dbo.tbInvoice.CustomerName)as CustomerName ,max(dbo.tbInvoiceDetails.kotId) as kotId,max( dbo.tbInvoiceDetails.TableId)as TableId, max(dbo.tbInvoiceDetails.WaiterId) as WaiterId ";

                queryStr = queryStr + "FROM dbo.tbInvoiceDetails INNER JOIN dbo.tbInvoice ON dbo.tbInvoiceDetails.InvoiceId = dbo.tbInvoice.Id where (dbo.tbInvoice.Status=2) and cast((convert(varchar(10),dbo.tbInvoice.date,120)) as date) between  cast('" + start + "'as date) and cast ('" + end + "'as date)  ";
                if (chkbxItem.Checked == true)
                {
                    queryStr = queryStr + "and dbo.tbInvoiceDetails.ItemId=" + cboxItem.SelectedValue.ToString();
                }
                if (chkInvoice.Checked == true)
                {
                    queryStr = queryStr + " and  dbo.tbInvoice.Id=" + cboxInvoice.SelectedValue.ToString();
                }
                queryStr = queryStr + " GROUP BY dbo.tbInvoiceDetails.InvoiceId";
            }
            if (rd_CounterBill.Checked == true)
            {

                queryStr = "SELECT max( dbo.tbInvoice.InvoiceNo)as InvoiceNo ,max( dbo.tbInvoice.TotalAmount)as TotalAmount,max( dbo.tbInvoice.InvoiceDate)as date , max(dbo.tbInvoice.Status)as Status ,max( dbo.tbInvoice.CustomerName)as CustomerName ,max(dbo.tbInvoiceDetails.kotId) as kotId,max( dbo.tbInvoiceDetails.TableId)as TableId, max(dbo.tbInvoiceDetails.WaiterId) as WaiterId ";

                queryStr = queryStr + "FROM dbo.tbInvoiceDetails INNER JOIN dbo.tbInvoice ON dbo.tbInvoiceDetails.InvoiceId = dbo.tbInvoice.Id where (dbo.tbInvoice.Status=3) and cast((convert(varchar(10),dbo.tbInvoice.date,120)) as date) between  cast('" + start + "'as date) and cast ('" + end + "'as date)  ";
                if (chkbxItem.Checked == true)
                {
                    queryStr = queryStr + "and dbo.tbInvoiceDetails.ItemId=" + cboxItem.SelectedValue.ToString();
                }
                if (chkInvoice.Checked == true)
                {
                    queryStr = queryStr + " and  dbo.tbInvoice.Id=" + cboxInvoice.SelectedValue.ToString();
                }
                queryStr = queryStr + " GROUP BY dbo.tbInvoiceDetails.InvoiceId";
            }
            DataTable dt = ObjCode.InvoiceSearch(queryStr);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv_SearchInvoice.Rows.Add();
                dgv_SearchInvoice[0, i].Value = i + 1;
                dgv_SearchInvoice[1, i].Value = dt.Rows[i]["InvoiceNo"].ToString();
                dgv_SearchInvoice[2, i].Value = dt.Rows[i]["CustomerName"].ToString();
                dgv_SearchInvoice[3, i].Value = dt.Rows[i]["TotalAmount"].ToString();
                dgv_SearchInvoice[4, i].Value = dt.Rows[i]["date"].ToString();
              
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void grp_custtype_Enter(object sender, EventArgs e)
        {

        }

        private void chkInvoice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInvoice.Checked == true)
            {
                grp_Invoice.Enabled = true;
            }
            else
            {
                grp_Invoice.Enabled = false;
            }
        }

        private void chkbxItem_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxItem.Checked == true)
            {
                grpItem.Enabled = true;
            }
            else
            {
                grpItem.Enabled = false;
            }
        }

        private void chkTable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTable.Checked == true)
            {
                grpTable.Enabled = true;
            }
            else
            {
                grpTable.Enabled = false;
            }
        }

        private void chkWaiter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWaiter.Checked == true)
            {
                grpWaiter.Enabled = true;
            }
            else
            {
                grpWaiter.Enabled = false;
            }
        }

        private void rd_DineIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_DineIn.Checked == true)
            {
                grp_tableWaiter.Enabled = true;
            }
        }

        private void rd_CounterBill_CheckedChanged(object sender, EventArgs e)
        {
            if(rd_CounterBill.Checked==true)
            {
                grp_tableWaiter.Enabled = false;
            }
        }

        private void rd_TakeAway_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_TakeAway.Checked == true)
            {
                grp_tableWaiter.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public DialogResult dr;
        public string InNo,na;
        Codebehind obj = new Codebehind();
        private void dgv_SearchInvoice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("    Print this bill ???", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;

                {
                    InNo = dgv_SearchInvoice[1, e.RowIndex].Value.ToString();
                    Billing pc = new Billing();

                    if (rd_CounterBill.Checked == true)
                    {
                        Billing.dtCounterBill = obj.PrintBillCounter(InNo);
                        pc.PrintCounterBill();
                    }
                    else if (rd_DineIn.Checked == true)
                    {
                        Billing.dtBill = obj.PrintBill(InNo);
                        pc.PrintBill();
                    }
                    else if (rd_TakeAway.Checked == true)
                    {
                        Billing.dtCounterBill = obj.PrintBillCounter(InNo);
                        pc.PrintCounterBill();
                    }
                    dr = DialogResult.OK;
                    //this.Close();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        int k = 0;
        private void btnSearch_Paint(object sender, PaintEventArgs e)
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

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            k = 1;
            btnSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSearch_Paint);
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            k = 0;
            btnSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSearch_Paint);
        }

        private void cboxTable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboxTable.DroppedDown)
            {
                cboxTable.Focus();

            }
        }

        private void cboxWaiter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboxTable.DroppedDown)
            {
                cboxTable.Focus();

            }
        }

        private void cboxInvoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboxInvoice.DroppedDown)
            {
                cboxInvoice.Focus();

            }
        }

        private void cboxItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboxItem.DroppedDown)
            {
                cboxItem.Focus();

            }
        }
    }
}
