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
    public partial class StockEntry : Form
    {
        public StockEntry()
        {
            InitializeComponent();
            lb_quantity.Text = "";
        }
        Codebehind obj = new Codebehind();
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        int f = 0,purchasetype=0;
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
       string  Productstatus = "0";
        private void StockEntry_Load(object sender, EventArgs e)
        {
          try
          {
              ApplyTheme();
            DataTable dt1 = new DataTable();
            dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "StockEntry");
            SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
            UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
            DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();
            this.ActiveControl = cmb_itemcode;
            DataSet dsd = new DataSet();
            dsd = obj.GetDealer();
            cboxCustomer.DataSource = dsd.Tables[0];
            cboxCustomer.DisplayMember = "dealer_name";
            cboxCustomer.ValueMember = "dealer_id";
            DataRow dr1 = dsd.Tables[0].NewRow();
            dr1["dealer_name"] = "--Select One--";
            dr1["dealer_id"] = "0";
            dsd.Tables[0].Rows.InsertAt(dr1, 0);
            cboxCustomer.SelectedIndex = 0;
           
            DataSet ds = new DataSet();
            ds = obj.GetItemCodeForStock("0");
            cmb_itemname.DataSource = ds.Tables[0];
            cmb_itemname.DisplayMember = "ItemName";
            cmb_itemname.ValueMember = "Id";

            cmb_itemcode.DataSource = ds.Tables[0];
            cmb_itemcode.DisplayMember = "ItemCode";
            cmb_itemcode.ValueMember = "Id";

            DataRow dr = ds.Tables[0].NewRow();
            dr["ItemName"] = "--Select One--";
            dr["ItemCode"] = "--Select One--";
            dr["Id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cmb_itemname.SelectedIndex = 0;


            DataSet ds3 = new DataSet();
            ds3 = obj.GetPurchaser();
            cboxPurchaser.DataSource = ds3.Tables[0];
            cboxPurchaser.DisplayMember = "username";
            cboxPurchaser.ValueMember = "user_id";
            DataRow dr3 = ds3.Tables[0].NewRow();
            dr3["username"] = "--Select One--";
            dr3["user_id"] = "0";
            ds3.Tables[0].Rows.InsertAt(dr3, 0);
            cboxPurchaser.SelectedIndex = 0;

            btn_add.Enabled = true;
            btn_save.Enabled = true;
            btn_update.Enabled = false;
            button1.Enabled = false;


            cmb_itemcode.Focus();
            f = 1;
            cboxPurchaser.Text = Login.username;
          }
          catch (Exception ex)
          {
              File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
          }
        }
        public void ClearAll()
        {
            cmb_itemcode.SelectedIndex = 0;
            txt_qty.Text = "0";
            txt_totalamount.Text = "0";
            txt_total.Text = "0";
            txt_description.Text = "0";
            gv_stock.Rows.Clear();
        }
        private void cmb_itemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (f == 1)
                {
                    SqlDataReader dr = obj.GetCostPrice(cmb_itemname.SelectedValue.ToString());
                    if (dr.Read())
                    {
                        txt_unitprice.Text = dr[0].ToString();
                        dr.Close();
                    }
                    else
                    {
                        txt_unitprice.Text = "0";
                    }
                    if (cmb_itemname.SelectedValue.ToString() != "0")
                    {
                        lb_quantity.Text = obj.GetUnitbyId(cmb_itemname.SelectedValue.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
            txt_totalamount.Text = "0";
            if (txt_qty.Text == "")
            {
                txt_qty.Text = "0";
            }
            //if (txt_qty.Text.StartsWith("0") == true && txt_qty.Text.EndsWith(".") != true)
            //{
            //    txt_qty.Text = Convert.ToDouble(txt_qty.Text).ToString();
            //}
            string Str = txt_qty.Text.Trim();
            double Num;
            bool isNum = double.TryParse(Str, out Num);
            if (isNum && txt_qty.Text.StartsWith(".") == false)
            {
                if (txt_qty.Text != "0" && txt_unitprice.Text != "0")
                {

                   // txt_qty.Text = (decimal.Round(Convert.ToDecimal(txt_qty.Text), 2, MidpointRounding.AwayFromZero)).ToString("F2");
                    txt_totalamount.Text = (Convert.ToDouble(txt_qty.Text) * (Convert.ToDouble(txt_unitprice.Text))).ToString("F2");
                }
                txt_qty.Select(txt_qty.Text.Length, 0);
            }
            else
            {
                MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_qty.Text = "0";
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_unitprice_TextChanged(object sender, EventArgs e)
        {
            try
            {
            txt_totalamount.Text = "0";
            if (txt_unitprice.Text == "")
            {
                txt_unitprice.Text = "0";
            }
            //if (txt_unitprice.Text.StartsWith("0") == true && txt_unitprice.Text.EndsWith(".") != true)
            //{
            //    txt_unitprice.Text = Convert.ToDouble(txt_unitprice.Text).ToString();
            //}

            string Str = txt_unitprice.Text.Trim();
            double Num;
            bool isNum = double.TryParse(Str, out Num);
            if (isNum)
            {

                if (txt_qty.Text != "0" && txt_unitprice.Text != "0")
                {

                    //txt_qty.Text = (decimal.Round(Convert.ToDecimal(txt_qty.Text), 2, MidpointRounding.AwayFromZero)).ToString("F2");
                    txt_totalamount.Text = (Convert.ToDouble(txt_qty.Text) * (Convert.ToDouble(txt_unitprice.Text))).ToString("F2");

                }
                txt_unitprice.Select(txt_unitprice.Text.Length, 0);
            }
            else
            {
                MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_unitprice.Text = "0";
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_totalamount_TextChanged(object sender, EventArgs e)
        {
            try
            {
            if (txt_totalamount.Text == "")
            {
                txt_totalamount.Text = "0";
            }
            string Str = txt_totalamount.Text.Trim();
            double Num;
            bool isNum = double.TryParse(Str, out Num);
            if (isNum)
            {

            }
            else
            {
                MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_totalamount.Text = "0";
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_totala_TextChanged(object sender, EventArgs e)
        {
            try
            {
            if (txt_totala.Text == "")
            {
                txt_totala.Text = "0.00";
            }
            string Str = txt_totala.Text.Trim();
            double Num;
            bool isNum = double.TryParse(Str, out Num);
            if (isNum)
            {
                txtPayable.Text = Convert.ToDouble(Convert.ToDouble(txt_totala.Text) - (Convert.ToDouble(txtDiscount.Text))).ToString("F2");
                txtBalance.Text = Convert.ToDouble(Convert.ToDouble(txtPayable.Text) - (Convert.ToDouble(txtPayingAmt.Text))).ToString("F2");
            }
            else
            {
                MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_totala.Text = "0.00";
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cmb_itemcode_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_itemcode.DroppedDown)
            {
                cmb_itemcode.Focus();

            }
        }

        private void cmb_itemname_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_itemname.DroppedDown)
            {
                cmb_itemname.Focus();

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
            if (cmb_itemname.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select Item Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_itemname.Focus();
            }
            else
            {
                if (cmb_itemcode.SelectedIndex <= 0)
                {
                    MessageBox.Show("Please select itemcode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_itemcode.Focus();
                }
                else
                {
                    if (txt_unitprice.Text == "0")
                    {
                        MessageBox.Show("Please enter unitprice", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_unitprice.Focus();
                    }
                    else
                    {
                        if (txt_qty.Text == "0")
                        {
                            MessageBox.Show("Please enter quantity", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_qty.Focus();
                        }
                        else
                        {                        
                            int rowindex;
                            if (editing == 1)
                            {
                                editing = 0;
                                rowindex = edit_row;
                                gv_stock[11, rowindex].Value = stockid;

                            }
                            else
                            {
                                gv_stock.Rows.Add();
                                rowindex = gv_stock.Rows.Count - 1;
                                
                            }

                            //int si;
                            //si = gv_stock.Rows.Count + 1;
                            //gv_stock.Rows.Insert(0, rowindex + 1);
                            
                           
                            gv_stock[0, rowindex].Value = rowindex + 1;
                            if (rd_countersale.Checked == true)
                                gv_stock[2, rowindex].Value = "Counter Sale";
                            else
                                gv_stock[2, rowindex].Value = "Ingredient";
                            gv_stock[3, rowindex].Value = cmb_itemname.Text;
                            gv_stock[4, rowindex].Value = Convert.ToDouble(txt_unitprice.Text).ToString("F2");
                            gv_stock[5, rowindex].Value = Convert.ToDouble(txt_qty.Text).ToString("F2");
                            gv_stock[6, rowindex].Value = Convert.ToDouble(txt_totalamount.Text).ToString("F2");
                            gv_stock[7, rowindex].Value = dtp_stockdate.Text;
                            gv_stock[8, rowindex].Value = txt_description.Text;
                            gv_stock[9, rowindex].Value = cmb_itemname.SelectedValue.ToString();
                            gv_stock[1, rowindex].Value = cmb_itemcode.SelectedValue.ToString();
                            gv_stock[11, rowindex].Value = txtsid.Text;
                            gv_stock.FirstDisplayedScrollingRowIndex = (gv_stock.Rows.Count) - 1;
                            
                            //= gv_stock.CurrentRow.Cells[11].Value.ToString();

                            clear();
                            cmb_itemname.Focus();

                        }
                    }
                }
            }
            txt_totala.Text = "0.00";
            for (int r = 0; r < gv_stock.Rows.Count; r++)
            {
                txt_totala.Text = (Convert.ToDouble(txt_totala.Text) + (Convert.ToDouble(gv_stock[6, r].Value))).ToString("F2");
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
          
        }
        public string check()
        {
            string st = "0";
            if ((Convert.ToDouble(txtDiscount.Text)) > (Convert.ToDouble(txtPayable.Text)))
            {
                MessageBox.Show("Please check the Discount Amount.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiscount.Focus();
                st = "1";
            }
            else
            {
                st = "0";
            }
            return st;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
               
            if (SaveStatus == "1")
            {
                if (gv_stock.Rows.Count > 0)
                {
                    if (rbtnNormal.Checked == true && Convert.ToDouble(cboxCustomer.SelectedValue) > 0 || Rb_OldStock.Checked==true)
                    {
                        if (txtDealerRefNo.Text != "" || Rb_OldStock.Checked == true)
                        {
                            if (Convert.ToDouble(cboxPurchaser.SelectedValue) > 0)
                            {
                                string stat = check();
                                if (stat == "0")
                                {
                                    string Sid = obj.InsertStockEntryMaster(Convert.ToString(cboxCustomer.SelectedValue), txt_totala.Text, txtPayingAmt.Text, txtDiscount.Text, txtRemarks.Text, Convert.ToDateTime(dtp_stockdate.Value), txtTinNo.Text, txtDealerRefNo.Text, cboxPurchaser.SelectedValue.ToString(), purchasetype.ToString(), "1", "0", txtPayable.Text);
                                    for (int i = 0; i < gv_stock.Rows.Count; i++)
                                    {
                                        int type = 0;
                                        if (gv_stock[2, i].Value.ToString() == "Counter Sale")
                                        {
                                            type = 2;
                                        }
                                        else if (gv_stock[2, i].Value.ToString() == "Ingredient")
                                            type = 0;
                                        obj.InsertStockEntry(type, gv_stock[9, i].Value.ToString(), gv_stock[5, i].Value.ToString(), gv_stock[4, i].Value.ToString(), gv_stock[6, i].Value.ToString(), Sid, gv_stock[8, i].Value.ToString(), "1", "0");

                                    }
                                }
                                MessageBox.Show("Goods Receipt sucessfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                reset();
                               cmb_itemname.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Please select purchaser", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cboxPurchaser.Focus();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please enter dealer reference number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDealerRefNo.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select dealer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cboxCustomer.Focus();
                    }

                }
                else
                {

                    MessageBox.Show("Please add Items for Goods Receipt", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_itemname.Focus();
                }
            }
            else
            {

                MessageBox.Show("You Do Not Have The Permission To Save Goods Receipt", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void gv_stock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 10 && e.RowIndex >= 0)
                {
                    int i = e.RowIndex;
                    txt_totala.Text = Convert.ToString(Convert.ToDouble(txt_totala.Text) - (Convert.ToDouble(gv_stock[6, i].Value)));
                    gv_stock.Rows.Remove(gv_stock.Rows[e.RowIndex]);
                    for (int j = 0; j < gv_stock.Rows.Count; j++)
                    {
                        gv_stock[0, j].Value = j + 1;
                    }
                    if (gv_stock.CurrentRow.Cells[11].Value == txtsid.Text)
                    {
                        clear();
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }
        String stockid = "0";
        private void btn_search_Click(object sender, EventArgs e)
        {
            try{
            StockEntrySearch s = new StockEntrySearch();
            s.ShowDialog();
            string id = s.id;
            stockid = id;
                if (s.dr == DialogResult.OK)
            {
                //// DealerId,Total,PaidedAmount,Discount,Remarks,Date,TinNo ,DealerRef,PurchaserId,PurchaseType 
                DataTable dtm = new DataTable();
                dtm = obj.GetStockMasterDetails(id);
                if (dtm.Rows.Count > 0)
                {
                    cboxCustomer.SelectedValue = Convert.ToDouble(dtm.Rows[0]["DealerId"]);
                    txtTinNo.Text = dtm.Rows[0]["TinNo"].ToString();
                    txtDealerRefNo.Text = dtm.Rows[0]["DealerRef"].ToString();
                    txtRemarks.Text = dtm.Rows[0]["Remarks"].ToString();
                    txtPayingAmt.Text = Convert.ToDouble(dtm.Rows[0]["PaidedAmount"]).ToString("F2");
                    txtDiscount.Text = dtm.Rows[0]["Discount"].ToString();
                    dtp_stockdate.Value = Convert.ToDateTime(dtm.Rows[0]["Date"]);
                    txt_totala.Text = Convert.ToDouble(dtm.Rows[0]["Total"]).ToString("F2");
                    cboxPurchaser.SelectedValue = Convert.ToDouble(dtm.Rows[0]["PurchaserId"]);
                    if (Convert.ToDouble(dtm.Rows[0]["PurchaseType"]) == 1)
                        Rb_OldStock.Checked = true;
                    else if (Convert.ToDouble(dtm.Rows[0]["PurchaseType"]) == 0)
                        rbtnNormal.Checked = true;
                }

                gv_stock.Rows.Clear();
                DataTable dt = new DataTable();
                dt = obj.GetStockDetails(id);
                int i;
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    gv_stock.Rows.Add();
                    gv_stock[0, i].Value = i + 1;
                    gv_stock[1, i].Value = dt.Rows[i]["ItemCode"].ToString();
                    if(Convert.ToInt32(dt.Rows[i]["Type"].ToString())==0)
                        gv_stock[2, i].Value = "Ingredient";
                    else if (Convert.ToInt32(dt.Rows[i]["Type"].ToString()) == 2)
                        gv_stock[2, i].Value = "Counter Sale";
                    gv_stock[3, i].Value = dt.Rows[i]["ItemName"].ToString();
                    gv_stock[4, i].Value = Convert.ToDouble(dt.Rows[i]["CostPrice"]).ToString("F2");
                    gv_stock[5, i].Value = Convert.ToDouble(dt.Rows[i]["Quantity"]).ToString("F2");
                    gv_stock[6, i].Value = Convert.ToDouble(dt.Rows[i]["TotalAmount"]).ToString("F2");
                    // string start =  dtpStartDate.Value.ToString("yyyy-MM-dd");
                  //  gv_stock[7, i].Value = (Convert.ToDateTime(dt.Rows[i]["Date"])).ToShortDateString();
                    gv_stock[8, i].Value = dt.Rows[i]["Description"].ToString();
                    gv_stock[9, i].Value = dt.Rows[i]["Id"].ToString();
                    gv_stock[11, i].Value = dt.Rows[i]["sid"].ToString();
                   // txt_totala.Text = gv_stock[6, i].Value.ToString();

                }
                for (int r = 0; r < gv_stock.Rows.Count; r++)
                {

                    txt_total.Text = Convert.ToDouble(Convert.ToDouble(txt_total.Text) + (Convert.ToDouble(gv_stock[6, r].Value))).ToString("F2");
                }
               // btn_add.Enabled = false;
                btn_save.Enabled = false;
                btn_update.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                btn_add.Enabled = true;
                btn_save.Enabled = true;
                btn_update.Enabled = false;
                button1.Enabled = false;
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        int NumStat = 0;
        private void gv_stock_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try{
            NumStat = 0;
            int i = e.RowIndex;
            decimal newInteger;
            if ((!decimal.TryParse(gv_stock[4, i].FormattedValue.ToString(), out newInteger) || newInteger < 0) || (!decimal.TryParse(gv_stock[5, i].FormattedValue.ToString(), out newInteger) || newInteger < 0))
                NumStat = 1;
            if (NumStat == 1)
            {
                MessageBox.Show("Please Enter Number Value To Corresponding Fields.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double total = 0;
                gv_stock[6, i].Value = Convert.ToString((Convert.ToDouble(gv_stock[4, i].Value)) * (Convert.ToDouble(gv_stock[5, i].Value)));
                for (int t = 0; t < gv_stock.Rows.Count; t++)
                {
                    total += (Convert.ToDouble(gv_stock[6, t].Value));
                    //int s = e.RowIndex;
                    //txt_totala.Text = Convert.ToString(Convert.ToDouble(gv_stock[5, t].Value));
                }
                txt_totala.Text = Convert.ToString(total);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (UpdateStatus == "1")
                {
                    if (gv_stock.Rows.Count >= 1)
                    {
                        if (rbtnNormal.Checked == true && Convert.ToDouble(cboxCustomer.SelectedValue) > 0 || Rb_OldStock.Checked == true)
                        {
                            if (txtDealerRefNo.Text != "" || Rb_OldStock.Checked == true)
                            {
                                if (Convert.ToDouble(cboxPurchaser.SelectedValue) > 0)
                                {
                                    string stat = check();
                                    if (stat == "0")
                                    {
                                        obj.InsertStockEntryMaster(Convert.ToString(cboxCustomer.SelectedValue), txt_totala.Text, txtPayingAmt.Text, txtDiscount.Text, txtRemarks.Text, Convert.ToDateTime(dtp_stockdate.Value), txtTinNo.Text, txtDealerRefNo.Text, cboxPurchaser.SelectedValue.ToString(), purchasetype.ToString(), "0", stockid, txtPayable.Text);
                                        decimal newInteger;
                                        NumStat = 0;
                                        ///delete stock details and add items
                                        // obj.DeleteStockEntry(stockid);
                                        ////// add updated details  
                                        for (int i = 0; i < gv_stock.Rows.Count; i++)
                                        {
                                            if ((!decimal.TryParse(gv_stock[4, i].FormattedValue.ToString(), out newInteger) || newInteger < 0) || (!decimal.TryParse(gv_stock[5, i].FormattedValue.ToString(), out newInteger) || newInteger < 0))
                                                NumStat = 1;
                                        }
                                        if (NumStat == 1)
                                        {
                                            MessageBox.Show("Please Enter Number Value To Corresponding Fields.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            for (int i = 0; i < gv_stock.Rows.Count; i++)
                                            {
                                                int type = 0;
                                                if (gv_stock[2, i].Value.ToString() == "Counter Sale")
                                                {
                                                    type = 2;
                                                }
                                                else if (gv_stock[2, i].Value.ToString() == "Ingredient")
                                                    type = 0;
                                                //obj.InsertStockEntry(type, gv_stock[9, i].Value.ToString(), gv_stock[5, i].Value.ToString(), gv_stock[4, i].Value.ToString(), gv_stock[6, i].Value.ToString(), stockid, gv_stock[8, i].Value.ToString(), "1", gv_stock[11, i].Value.ToString());
                                                obj.InsertStockEntry(type, gv_stock[9, i].Value.ToString(), gv_stock[5, i].Value.ToString(), gv_stock[4, i].Value.ToString(), gv_stock[6, i].Value.ToString(), stockid, gv_stock[8, i].Value.ToString(), "1", txtsid.Text);
                                                    
                                                
                                            }
                                            MessageBox.Show("Goods Receipt successfully updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            reset();
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please select purchaser", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cboxPurchaser.Focus();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Please enter dealer reference number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtDealerRefNo.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select dealer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cboxCustomer.Focus();
                        }

                    }
                    else
                    {

                        MessageBox.Show("Please add Items for Goods Receipt", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmb_itemname.Focus();
                    }

                }
                else
                {

                    MessageBox.Show("You Do Not Have The Permission To Update Goods Receipt", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Do You Want to Delete This Record ??", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;
            if (DeleteStatus == "1")
            {
                if (gv_stock.Rows.Count >= 1)
                {

                    string msg = obj.DeleteStockMaster(stockid);
                    if (msg == "0")
                    {
                        MessageBox.Show("Successfully deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Goods Receipt already in use. So you cannot delete this GR.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("No search result", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                MessageBox.Show("You Do Not Have The Permission To Delete Goods Receipt", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        int k = 0;
        private void btn_search_Paint(object sender, PaintEventArgs e)
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

        private void btn_search_MouseEnter(object sender, EventArgs e)
        {
            k = 1;
            btn_search.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_search_Paint);
        }

        private void btn_search_MouseLeave(object sender, EventArgs e)
        {
            k = 0;
            btn_search.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_search_Paint);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {


        }

        private void txt_unitprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_totalamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_totala_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();


        }
        public void clear()
        {
            txt_description.Text = "";
            txt_qty.Text = "0";
            txt_total.Text = "0.00";
            txt_unitprice.Text = "0.00";
            txtsid.Text = "0";
            txt_totalamount.Text = "0.00";
            cmb_itemcode.SelectedIndex = 0;
            lb_quantity.Text = "";
        }
        public void reset()
        {
            txtsid.Text = "0";
            txt_description.Text = "";
            txt_qty.Text = "0";
            txt_total.Text = "0.00";
            txt_unitprice.Text = "0.00";
            stockid = "0";
            txt_totalamount.Text = "0.00";
            cmb_itemcode.SelectedIndex = 0;
            txt_totala.Text = "0.00";
            gv_stock.Rows.Clear();
            dtp_stockdate.Value = DateTime.Now;
            btn_add.Enabled = true;
            btn_save.Enabled = true;
            btn_update.Enabled = false;
            button1.Enabled = false;          
            cboxCustomer.SelectedIndex = 0;
            txtDealerRefNo.Text = "";
            txtDiscount.Text = "0.00";
            txtPayingAmt.Text = "0.00";
            txtRemarks.Text = "";
            cboxPurchaser.SelectedIndex = 0;

        }
        private void BTN_RESET_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void bttn_newcategory_Click(object sender, EventArgs e)
        {
            try
            {
            Item it = new Item();
            it.ShowDialog();

            DataSet ds = new DataSet();
            ds = obj.GetItemCodeForStock(Productstatus);
            cmb_itemname.DataSource = ds.Tables[0];
            cmb_itemname.DisplayMember = "ItemName";
            cmb_itemname.ValueMember = "Id";

            cmb_itemcode.DataSource = ds.Tables[0];
            cmb_itemcode.DisplayMember = "ItemCode";
            cmb_itemcode.ValueMember = "Id";

            DataRow dr = ds.Tables[0].NewRow();
            dr["ItemName"] = "--Select One--";
            dr["ItemCode"] = "--Select One--";
            dr["Id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cmb_itemname.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cmb_itemcode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_itemcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cmb_itemname.Focus();
            }
        }

        private void cmb_itemname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_unitprice.Focus();
            }
        }

        private void txt_unitprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_qty.Focus();
            }
        }

        private void txt_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_description.Focus();
            }
        }

        private void txt_totalamount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_description.Focus();
            }
        }

        private void txt_description_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_add.Focus();
            }
        }

        private void btn_add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                gv_stock.Focus();
            }
        }

        private void gv_stock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_save.Focus();
            }
        }

        private void cmb_itemname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_itemname.DroppedDown)
            {
                cmb_itemname.Focus();

            }
        }

        private void rd_Ingradiant_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rd_countersale_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void cboxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f == 1)
            {
               // clear();
                DataTable dt = obj.selectdealer(cboxCustomer.SelectedValue.ToString());
                if (dt.Rows.Count > 0)
                {
                    txtTinNo.Text = dt.Rows[0]["tin_no"].ToString();

                }
                else
                {
                    txtTinNo.Text = "";
                }
            }
        }

        private void Rb_OldStock_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_OldStock.Checked == true)
            {
                purchasetype = 1;
                Gr_Dealer.Enabled = false;
                grp_dealerIn.Enabled = false;
            }
        }

        private void rbtnNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_OldStock.Checked == false)
            
                purchasetype=0;
                Gr_Dealer.Enabled = true;
                grp_dealerIn.Enabled = true;
            
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void txtPayingAmt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPayingAmt.Text == "")
                {
                    txtPayingAmt.Text = "0";
                }
                string Str = txtPayingAmt.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    txtPayable.Text = Convert.ToDouble(Convert.ToDouble(txt_totala.Text) - (Convert.ToDouble(txtDiscount.Text))).ToString("F2");
                    txtBalance.Text = Convert.ToDouble(Convert.ToDouble(txtPayable.Text) - (Convert.ToDouble(txtPayingAmt.Text))).ToString("F2");
                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPayingAmt.Text = "0";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDiscount.Text == "")
                {
                    txtDiscount.Text = "0";
                }
                string Str = txtDiscount.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    txtPayable.Text= Convert.ToDouble(Convert.ToDouble(txt_totala.Text) - (Convert.ToDouble(txtDiscount.Text))).ToString("F2");
                    txtBalance.Text = Convert.ToDouble(Convert.ToDouble(txtPayable.Text) - (Convert.ToDouble(txtPayingAmt.Text))).ToString("F2");
                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDiscount.Text = "0";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPayable_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPayable.Text == "")
                {
                    txtPayable.Text = "0.00";
                }
                string Str = txtPayable.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {

                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPayable.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnNewCust_Click(object sender, EventArgs e)
        {
            Dealer dl = new Dealer();
            dl.ShowDialog();

            DataSet dsd = new DataSet();
            dsd = obj.GetDealer();
            cboxCustomer.DataSource = dsd.Tables[0];
            cboxCustomer.DisplayMember = "dealer_name";
            cboxCustomer.ValueMember = "dealer_id";
            DataRow dr1 = dsd.Tables[0].NewRow();
            dr1["dealer_name"] = "--Select One--";
            dr1["dealer_id"] = "0";
            dsd.Tables[0].Rows.InsertAt(dr1, 0);
            cboxCustomer.SelectedIndex = 0;
        }

        private void rd_countersale_CheckedChanged_1(object sender, EventArgs e)
        {
            Productstatus = "2";
            f = 0;
            DataSet ds = new DataSet();
            ds = obj.GetItemCodeForStock(Productstatus);
            cmb_itemname.DataSource = ds.Tables[0];
            cmb_itemname.DisplayMember = "ItemName";
            cmb_itemname.ValueMember = "Id";

            cmb_itemcode.DataSource = ds.Tables[0];
            cmb_itemcode.DisplayMember = "ItemCode";
            cmb_itemcode.ValueMember = "Id";

            DataRow dr = ds.Tables[0].NewRow();
            dr["ItemName"] = "--Select One--";
            dr["ItemCode"] = "--Select One--";
            dr["Id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cmb_itemname.SelectedIndex = 0;
            f = 1;
            clear();
        }

        private void rd_Ingradiant_CheckedChanged_1(object sender, EventArgs e)
        {
            Productstatus = "0";
            f = 0;
            DataSet ds = new DataSet();
            ds = obj.GetItemCodeForStock(Productstatus);
            cmb_itemname.DataSource = ds.Tables[0];
            cmb_itemname.DisplayMember = "ItemName";
            cmb_itemname.ValueMember = "Id";

            cmb_itemcode.DataSource = ds.Tables[0];
            cmb_itemcode.DisplayMember = "ItemCode";
            cmb_itemcode.ValueMember = "Id";

            DataRow dr = ds.Tables[0].NewRow();
            dr["ItemName"] = "--Select One--";
            dr["ItemCode"] = "--Select One--";
            dr["Id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cmb_itemname.SelectedIndex = 0;
            f = 1;
            clear();
        }

        private void gv_stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static int edit_row,editing;
        private void gv_stock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gv_stock.RowCount>0)
            {
                edit_row = gv_stock.CurrentRow.Index;
                editing = 1;

                cmb_itemname.SelectedValue = gv_stock.CurrentRow.Cells[9].Value;
                cmb_itemcode.SelectedValue = gv_stock.CurrentRow.Cells[9].Value;
                cmb_itemname.Text = gv_stock.CurrentRow.Cells[3].Value.ToString();
                cmb_itemcode.Text = gv_stock.CurrentRow.Cells[1].Value.ToString();
                txt_unitprice.Text = gv_stock.CurrentRow.Cells[4].Value.ToString();
                txt_qty.Text = gv_stock.CurrentRow.Cells[5].Value.ToString();
                txt_totalamount.Text = gv_stock.CurrentRow.Cells[6].Value.ToString();
                txt_description.Text = gv_stock.CurrentRow.Cells[8].Value.ToString();
                txtsid.Text = gv_stock.CurrentRow.Cells[11].Value.ToString();

            }

        }

        private void txtsid_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbll_total_Click(object sender, EventArgs e)
        {

        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void text1_Click(object sender, EventArgs e)
        {

        }

        private void txtRemarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboxPurchaser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_quantity_Click(object sender, EventArgs e)
        {

        }

        private void lbl_description_Click(object sender, EventArgs e)
        {

        }

        private void txt_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_itemname_Click(object sender, EventArgs e)
        {

        }

        private void lbl_unitprice_Click(object sender, EventArgs e)
        {

        }

        private void lbl_quantity_Click(object sender, EventArgs e)
        {

        }

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }

        private void lbl_itemcode_Click(object sender, EventArgs e)
        {

        }

        private void dtp_stockdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void grp_dealerIn_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtDealerRefNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Gr_Dealer_Enter(object sender, EventArgs e)
        {

        }

        private void txtTinNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        } 
        
       
    }
}
   
