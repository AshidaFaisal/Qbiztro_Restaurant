using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BisCarePosEdition
{
    public partial class OldPayableReceivable : Form
    {
        public OldPayableReceivable()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
        int status;
        int searchstatus;
        int editid;
        int mode;

        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        public void clear()
        {
            Gv_Search.Rows.Clear();
            txt_amt.Text = "0";
            txt_Balance.Text = "0.00";
            txt_PaidAmt.Text = "0";
            txt_refno.Text = string.Empty;
            mode = 1;
            bttn_delete.Enabled = false;
            dtp_RefDate.Value = DateTime.Now;
            cmb_Name.SelectedIndex = 0;
            cmb_searchname.SelectedIndex = 0;
        }
        public void FloatValueValidate(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (m.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }
            base.WndProc(ref m);
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

        private void OldPayableReceivable_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
                int Intchk = obj.CheckInternetConnection();
                if (Intchk == 1)
                {
                    DataTable dt1 = new DataTable();
                    dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "OldPayablReceivable");
                    SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
                    UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
                    DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();

                    mode = 1;

                    DataSet ds = obj.GetDealer();
                    cmb_Name.DataSource = ds.Tables[0];
                    cmb_Name.DisplayMember = "dealer_name";
                    cmb_Name.ValueMember = "dealer_id";
                    DataRow dr1 = ds.Tables[0].NewRow();
                    dr1["dealer_name"] = "--Select One--";
                    dr1["dealer_id"] = "0";
                    ds.Tables[0].Rows.InsertAt(dr1, 0);
                    cmb_Name.SelectedIndex = 0;

                    status = 1;

                    lbl_name.Text = "Dealer Name :";
                    lbl_refno.Text = "GR No :";
                    lbl_date.Text = "GR Date :";

                    DataSet ds2 = obj.GetDealer();
                    cmb_searchname.DataSource = ds2.Tables[0];
                    cmb_searchname.DisplayMember = "dealer_name";
                    cmb_searchname.ValueMember = "dealer_id";
                    DataRow dr2 = ds2.Tables[0].NewRow();
                    dr2["dealer_name"] = "--Select One--";
                    dr2["dealer_id"] = "0";
                    ds2.Tables[0].Rows.InsertAt(dr2, 0);
                    cmb_searchname.SelectedIndex = 0;

                    searchstatus = 1;
                    bttn_delete.Enabled = false;
                    lbl_searchname.Text = "Dealer Name :";

                    txt_amt.Text = "0";
                    txt_Balance.Text = "0";
                    txt_PaidAmt.Text = "0";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void rb_payable_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int Intchk = obj.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (rb_payable.Checked == true)
                    {
                        DataSet ds = obj.GetDealer();
                        cmb_Name.DataSource = ds.Tables[0];
                        cmb_Name.DisplayMember = "dealer_name";
                        cmb_Name.ValueMember = "dealer_id";
                        DataRow dr1 = ds.Tables[0].NewRow();
                        dr1["dealer_name"] = "--Select One--";
                        dr1["dealer_id"] = "0";
                        ds.Tables[0].Rows.InsertAt(dr1, 0);
                        cmb_Name.SelectedIndex = 0;

                        cmb_Name.ValueMember = "dealer_id";
                        status = 1;

                        lbl_name.Text = "Dealer Name :";
                        lbl_refno.Text = "GR No :";
                        lbl_date.Text = "GR Date :";
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void rb_receivable_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int Intchk = obj.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (rb_receivable.Checked == true)
                    {
                        DataSet ds = obj.GetCustomer();
                        cmb_Name.DataSource = ds.Tables[0];
                        cmb_Name.DisplayMember = "customer_name";
                        cmb_Name.ValueMember = "customer_id";
                        DataRow dr1 = ds.Tables[0].NewRow();
                        dr1["customer_name"] = "--Select One--";
                        dr1["customer_id"] = "0";
                        ds.Tables[0].Rows.InsertAt(dr1, 0);
                        cmb_Name.SelectedIndex = 0;
                        status = 0;

                        lbl_name.Text = "Customer Name :";
                        lbl_date.Text = "Invoice Date :";
                        lbl_refno.Text = "Invoice no :";

                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void rb_searchpay_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int Intchk = obj.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (rb_searchpay.Checked == true)
                    {
                        DataSet ds2 = obj.GetDealer();
                        cmb_searchname.DataSource = ds2.Tables[0];
                        cmb_searchname.DisplayMember = "dealer_name";
                        cmb_searchname.ValueMember = "dealer_id";
                        DataRow dr1 = ds2.Tables[0].NewRow();
                        dr1["dealer_name"] = "--Select One--";
                        dr1["dealer_id"] = "0";
                        ds2.Tables[0].Rows.InsertAt(dr1, 0);
                        cmb_searchname.SelectedIndex = 0;

                        searchstatus = 1;

                        lbl_searchname.Text = "Dealer Name :";
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void rb_searchreceive_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int Intchk = obj.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (rb_searchreceive.Checked == true)
                    {
                        DataSet ds1 = obj.GetCustomer();
                        cmb_searchname.DataSource = ds1.Tables[0];
                        cmb_searchname.DisplayMember = "customer_name";
                        cmb_searchname.ValueMember = "customer_id";
                        DataRow dr1 = ds1.Tables[0].NewRow();
                        dr1["customer_name"] = "--Select One--";
                        dr1["customer_id"] = "0";
                        ds1.Tables[0].Rows.InsertAt(dr1, 0);
                        cmb_searchname.SelectedIndex = 0;
                        searchstatus = 0;

                        lbl_searchname.Text = "Customer Name :";
                    }

                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cbox_sbyname_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_sbyname.Checked == true)
                cmb_searchname.Enabled = true;

            else
            {
                cmb_searchname.Enabled = false;
                cmb_searchname.SelectedIndex = 0;
            }
        }

        private void cbox_sbydate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_sbydate.Checked == true)
            {
                dtp_startdate.Enabled = true;
                dtp_enddate.Enabled = true;
            }
            else
            {
                dtp_startdate.Enabled = false;
                dtp_enddate.Enabled = false;

            }
        }
        int t = 0;
        private void bttn_search_Click(object sender, EventArgs e)
        {
            try
            {
                t = 0;
                int Intchk = obj.CheckInternetConnection();
                if (Intchk == 1)
                {
                    Gv_Search.Rows.Clear();
                    DataTable dt = new DataTable();


                    //if(@Mode=1)--date & status--
                    if ((cbox_sbydate.Checked == true) && (cbox_sbyname.Checked == false))
                    {
                        dt.Rows.Clear();
                        dt = obj.SearchOldPayReceive(searchstatus, Convert.ToInt32(cmb_searchname.SelectedValue), "", dtp_startdate.Value, dtp_enddate.Value, 1);
                        t = 1;
                    }


                    //if(@Mode=2)--Deale or Cust id & status --
                    if ((cbox_sbydate.Checked == false) && (cbox_sbyname.Checked == true))
                    {
                        if (cmb_searchname.SelectedIndex > 0)
                        {
                            dt.Rows.Clear();
                            dt = obj.SearchOldPayReceive(searchstatus, Convert.ToInt32(cmb_searchname.SelectedValue), "", dtp_startdate.Value, dtp_enddate.Value, 2);
                            t = 1;
                        }
                        else
                        {
                            MessageBox.Show("Please select a name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmb_searchname.Focus();
                        }
                    }

                   
                    if ((cbox_sbyname.Checked == true) && (cbox_sbydate.Checked == true))
                    {
                        if (cmb_searchname.SelectedIndex > 0)
                        {
                            dt.Rows.Clear();
                            dt = obj.SearchOldPayReceive(searchstatus, Convert.ToInt32(cmb_searchname.SelectedValue), "", dtp_startdate.Value, dtp_enddate.Value, 3);
                            t = 1;
                        }

                        else
                        {
                            MessageBox.Show("Please select a name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmb_searchname.Focus();
                        }
                    }

                    //if(@Mode=4)--by status only--
                    if ((searchstatus != 2) && ((cbox_sbyname.Checked == false) && (cbox_sbydate.Checked == false)))
                    {
                        dt.Rows.Clear();
                        dt = obj.SearchOldPayReceive(searchstatus, Convert.ToInt32(cmb_searchname.SelectedValue), "", dtp_startdate.Value, dtp_enddate.Value, 4);
                        t = 1;
                    }
                    if ((dt.Rows.Count < 1) && (t == 1))
                    {
                        MessageBox.Show("No Search Result Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            Gv_Search.Rows.Add();
                            Gv_Search[0, i].Value = dt.Rows[i]["Id"].ToString();
                            Gv_Search[1, i].Value = dt.Rows[i]["Status"].ToString();
                            Gv_Search[2, i].Value = dt.Rows[i]["Expr1"].ToString();

                            if (dt.Rows[i]["Status"].ToString() == "1")
                                Gv_Search[3, i].Value = dt.Rows[i]["dealer_name"].ToString();
                            else
                                Gv_Search[3, i].Value = dt.Rows[i]["customer_name"].ToString();

                            Gv_Search[4, i].Value = dt.Rows[i]["RefNo"].ToString();
                            Gv_Search[5, i].Value = dt.Rows[i]["InsDate"].ToString();
                            Gv_Search[6, i].Value = dt.Rows[i]["Amount"].ToString();
                            Gv_Search[7, i].Value = dt.Rows[i]["PaidAmount"].ToString();
                            Gv_Search[8, i].Value = dt.Rows[i]["Balance"].ToString();


                        }
                    }


                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        int st = 1;

        private void Gv_Search_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Gv_Search.RowCount > 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        editid = Convert.ToInt32(Gv_Search[0, e.RowIndex].Value);
                        if (Convert.ToInt32(Gv_Search[1, e.RowIndex].Value) == 1)
                        {
                            rb_payable.Checked = true;
                            status = 1;
                            //string s = obj.CheckOldPayableInPaymentVoucher(editid);
                            //if (s == "0")
                            //{
                            //    st = 0;
                            //}
                            //else
                            //{
                            //    st = 1;
                            //}
                        }
                        else
                        {
                            rb_receivable.Checked = true;
                            status = 0;
                            //string s = obj.CheckOldPayableInReceiptVoucher(editid);
                            //if (s == "0")
                            //{
                            //    st = 0;
                            //}
                            //else
                            //{
                            //    st = 1;
                            //}
                        }
                        if (st == 1)
                        {
                            cmb_Name.SelectedValue = Convert.ToInt32(Gv_Search[2, e.RowIndex].Value);
                            txt_refno.Text = Gv_Search[4, e.RowIndex].Value.ToString();
                            dtp_RefDate.Value = Convert.ToDateTime(Gv_Search[5, e.RowIndex].Value);
                            txt_amt.Text = Gv_Search[6, e.RowIndex].Value.ToString();
                            txt_PaidAmt.Text = Gv_Search[7, e.RowIndex].Value.ToString();
                            txt_Balance.Text = Gv_Search[8, e.RowIndex].Value.ToString();
                            mode = 2;
                            bttn_delete.Enabled = true;
                        }
                        else
                        {
                            if (rb_payable.Checked == true)
                            {
                                MessageBox.Show("Already made Payment Voucher against this.So you can not edit this entry", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            if (rb_receivable.Checked == true)
                            {
                                MessageBox.Show("Already made Receipt Voucher against this.So you can not edit this entry", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void bttn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int Intchk = obj.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (cmb_Name.SelectedIndex > 0)
                    {
                        if (rb_payable.Checked == true && txt_refno.Text == "")
                        {
                            MessageBox.Show("Please Enter Reference No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_refno.Focus();
                        }
                        else if (rb_receivable.Checked == true && txt_refno.Text == "")
                        {
                            MessageBox.Show("Please Enter Reference No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_refno.Focus();
                        }
                        else
                        {
                            if (txt_amt.Text != "0")
                            {
                               
                                if (Convert.ToDouble(txt_amt.Text) >= Convert.ToDouble(txt_PaidAmt.Text))
                                {
                                    if (mode == 1)
                                    {
                                        if (SaveStatus == "1")
                                        {
                                            string msg = obj.InsertupdateOldPayReceive(0, status, Convert.ToInt32(cmb_Name.SelectedValue), txt_refno.Text, dtp_RefDate.Value, txt_amt.Text, txt_PaidAmt.Text, txt_Balance.Text, mode);                                           
                                           
                                            MessageBox.Show("Details successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            MessageBox.Show("You Do Not Have The Permission To Save OldPayableReceivable", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    if (mode == 2)
                                    {
                                        if (UpdateStatus == "1")
                                        {
                                            string msg = obj.InsertupdateOldPayReceive(editid, status, Convert.ToInt32(cmb_Name.SelectedValue), txt_refno.Text, dtp_RefDate.Value, txt_amt.Text, txt_PaidAmt.Text, txt_Balance.Text, mode);
                                          
                                        
                                               // obj.SaveWindow(DateTime.Now, "OldPayableReceivable", File.ReadAllText("user.txt"), "Update");
                                            MessageBox.Show(" Details are succesfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            mode = 1;
                                        }
                                        else
                                        {
                                            MessageBox.Show("You Do Not Have The Permission To Update OldPayableReceivable", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    clear();
                                }
                                else
                                {
                                    MessageBox.Show("Please Check Paid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txt_PaidAmt.Focus();
                                }
                               
                            }
                            else
                            {
                                MessageBox.Show("Please Enter Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_amt.Focus();
                            }

                        }
                    
                    }
                    else
                    {
                        MessageBox.Show("Please Select Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmb_Name.Focus();
                    }

                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_PaidAmt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double amt = 0;
                double paid = 0;
                double bal = 0;
                if (txt_PaidAmt.Text == string.Empty)
                    txt_PaidAmt.Text = "0";


                string Str = txt_PaidAmt.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    if ((txt_PaidAmt.Text != "") && (txt_amt.Text != ""))
                    {
                        amt = Convert.ToDouble(txt_amt.Text);
                        //txt_PaidAmt.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(txt_PaidAmt.Text), 2, MidpointRounding.AwayFromZero));
                        paid = Convert.ToDouble(txt_PaidAmt.Text);
                        bal = amt - paid;
                        txt_Balance.Text = bal.ToString("F2");
                    }
                    else
                        txt_Balance.Text = "0";
                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_PaidAmt.Text = "0";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void bttn_reset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void bttn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int Intchk = obj.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (mode == 2)
                    {
                        if (DeleteStatus == "1")
                        {
                            string st = obj.DeleteOldPayReceive(editid);
                            if (st == "0")
                            {
                                MessageBox.Show("Deleted Sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                mode = 1;
                                clear();
                            }
                            else
                            {
                                MessageBox.Show("Detaile alreday in use.So you can not delete it", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("You Do Not Have The Permission To Delete OldPayableReceivable", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void bttn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_PaidAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_amt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double amt = 0;
                double paid = 0;
                double bal = 0;
                if (txt_PaidAmt.Text == string.Empty)
                    txt_PaidAmt.Text = "0";
                if (txt_amt.Text == string.Empty)
                    txt_amt.Text = "0";

                string Str = txt_amt.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    if ((txt_PaidAmt.Text != "") && (txt_amt.Text != ""))
                    {
                        amt = Convert.ToDouble(txt_amt.Text);                      
                        paid = Convert.ToDouble(txt_PaidAmt.Text);
                        bal = amt - paid;
                        txt_Balance.Text = bal.ToString("F2");
                    }
                    else
                        txt_Balance.Text = "0.00";
                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_amt.Text = "0";
                }

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cmb_Name_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_Name.DroppedDown)
            {
                cmb_Name.Focus();
            }
        }

        private void cmb_searchname_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_searchname.DroppedDown)
            {
                cmb_searchname.Focus();
            }
        }

        private void Btn_NewCust_Click(object sender, EventArgs e)
        {
            try
            {
                int Intchk = obj.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (rb_payable.Checked == true)
                    {
                        Dealer d = new Dealer(1);
                        d.ShowDialog();
                        DataSet ds = obj.GetDealer();
                        cmb_Name.DataSource = ds.Tables[0];
                        cmb_Name.DisplayMember = "dealer_name";
                        cmb_Name.ValueMember = "dealer_id";
                        DataRow dr1 = ds.Tables[0].NewRow();
                        dr1["dealer_name"] = "--Select One--";
                        dr1["dealer_id"] = "0";
                        ds.Tables[0].Rows.InsertAt(dr1, 0);
                        cmb_Name.SelectedIndex = 0;
                    }
                    if (rb_receivable.Checked == true)
                    {
                        Customer c = new Customer(1);
                        c.ShowDialog();
                        DataSet ds = obj.GetCustomer();
                        cmb_Name.DataSource = ds.Tables[0];
                        cmb_Name.DisplayMember = "customer_name";
                        cmb_Name.ValueMember = "customer_id";

                        DataRow dr1 = ds.Tables[0].NewRow();
                        dr1["customer_name"] = "--Select One--";
                        dr1["customer_id"] = "0";
                        ds.Tables[0].Rows.InsertAt(dr1, 0);
                        cmb_Name.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_refno_DoubleClick(object sender, EventArgs e)
        {
            txt_refno.SelectAll();
        }

        private void txt_amt_DoubleClick(object sender, EventArgs e)
        {
            txt_amt.SelectAll();
        }

        private void txt_PaidAmt_DoubleClick(object sender, EventArgs e)
        {
            txt_PaidAmt.SelectAll();
        }

        private void txt_Balance_DoubleClick(object sender, EventArgs e)
        {
            txt_Balance.SelectAll();
        }

        private void cmb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_Name.DroppedDown)
            {
                cmb_Name.Focus();
            }
        }
    }
}
