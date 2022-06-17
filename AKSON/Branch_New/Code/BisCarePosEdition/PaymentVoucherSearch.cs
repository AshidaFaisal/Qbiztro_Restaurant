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
    public partial class PaymentVoucherSearch : Form
    {
        public PaymentVoucherSearch()
        {
            InitializeComponent();
        }
        Codebehind objcode = new Codebehind();
        public string rid;
        public int ChkSer = 0;
        public int CHkGR = 0;
        int t = 0;
        private void PaymentVoucherSearch_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            int Intchk = objcode.CheckInternetConnection();
            if (Intchk == 1)
            {


                ChkSer = 0;
            }
        }

        private void chk_customer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (chk_customer.Checked == true)
                    {
                        lblcustomer.Enabled = true;
                        cmb_editcustomer.Enabled = true;
                        DataSet ds = new DataSet();
                        ds = objcode.GetDealer();
                        cmb_editcustomer.DataSource = ds.Tables[0];
                        cmb_editcustomer.DisplayMember = "dealer_name";
                        cmb_editcustomer.ValueMember = "dealer_id";
                        DataRow dr1 = ds.Tables[0].NewRow();
                        dr1["dealer_name"] = "--Select One--";
                        dr1["dealer_id"] = "0";
                        ds.Tables[0].Rows.InsertAt(dr1, 0);
                        cmb_editcustomer.SelectedIndex = 0;
                    }
                    else
                    {
                        lblcustomer.Enabled = false; ;
                        cmb_editcustomer.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void chkvoucherNo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkvoucherNo.Checked == true)
                {
                    lblvoucherno.Enabled = true;
                    txt_editvoucherno.Enabled = true;

                }
                else
                {
                    lblvoucherno.Enabled = false; ;
                    txt_editvoucherno.Enabled = false;
                    txt_editvoucherno.Text = "";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDate.Checked == true)
            {
                dtfrom.Enabled = true;
                dtto.Enabled = true;
            }
            else
            {
                dtfrom.Enabled = false;
                dtto.Enabled = false;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    DataTable ds = new DataTable();
                    dgvEdit.Rows.Clear();

                    if (Rb_GoodsReceipt.Checked == true)
                    {
                        if (chk_customer.Checked == true && chkvoucherNo.Checked == false && chkDate.Checked == false)
                        {
                            if (cmb_editcustomer.SelectedIndex > 0)
                            {
                                ds.Rows.Clear();
                                ds = objcode.getreceiptdetailsforeditpayment(cmb_editcustomer.SelectedValue.ToString(), "", DateTime.Now, DateTime.Now, "0");// string    
                                t = 1;
                            }
                            else
                            {
                                MessageBox.Show("Please select a Dealer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmb_editcustomer.Focus();
                            }
                        }
                        if (chk_customer.Checked == true && chkvoucherNo.Checked == true && chkDate.Checked == false)
                        {
                            if (txt_editvoucherno.Text != string.Empty)
                            {
                                if (cmb_editcustomer.SelectedIndex > 0)
                                {
                                    ds.Rows.Clear();
                                    ds = objcode.getreceiptdetailsforeditpayment(cmb_editcustomer.SelectedValue.ToString(), txt_editvoucherno.Text, DateTime.Now, DateTime.Now, "1");// string                 
                                    t = 1;
                                }
                                else
                                {
                                    MessageBox.Show("Please select a Dealer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cmb_editcustomer.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter an Invoice No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_editvoucherno.Focus();
                            }
                        }
                        if (chk_customer.Checked == false && chkvoucherNo.Checked == true && chkDate.Checked == false)
                        {
                            if (txt_editvoucherno.Text != string.Empty)
                            {
                                ds.Rows.Clear();
                                ds = objcode.getreceiptdetailsforeditpayment("", txt_editvoucherno.Text, DateTime.Now, DateTime.Now, "2");// string 
                                t = 1;
                            }
                            else
                            {
                                MessageBox.Show("Please enter an Invoice No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_editvoucherno.Focus();
                            }
                        }
                        if (chk_customer.Checked == true && chkvoucherNo.Checked == false && chkDate.Checked == true)
                        {
                            if (cmb_editcustomer.SelectedIndex > 0)
                            {
                                ds.Rows.Clear();
                                ds = objcode.getreceiptdetailsforeditpayment(cmb_editcustomer.SelectedValue.ToString(), txt_editvoucherno.Text, dtfrom.Value, dtto.Value, "3");// string 
                                t = 1;
                            }
                            else
                            {
                                MessageBox.Show("Please select a Dealer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmb_editcustomer.Focus();
                            }
                        }
                        if (chk_customer.Checked == true && chkvoucherNo.Checked == true && chkDate.Checked == true)
                        {
                            if (txt_editvoucherno.Text != string.Empty)
                            {
                                if (cmb_editcustomer.SelectedIndex > 0)
                                {
                                    ds.Rows.Clear();
                                    ds = objcode.getreceiptdetailsforeditpayment(cmb_editcustomer.SelectedValue.ToString(), txt_editvoucherno.Text, dtfrom.Value, dtto.Value, "4");// string                 
                                    t = 1;
                                }
                                else
                                {
                                    MessageBox.Show("Please select a Dealer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cmb_editcustomer.Focus();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Please enter an Invoice No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_editvoucherno.Focus();
                            }
                        }
                        if (chk_customer.Checked == false && chkvoucherNo.Checked == true && chkDate.Checked == true)
                        {
                            if (txt_editvoucherno.Text != string.Empty)
                            {
                                ds.Rows.Clear();
                                ds = objcode.getreceiptdetailsforeditpayment("", txt_editvoucherno.Text, dtfrom.Value, dtto.Value, "5");// string 
                                t = 1;
                            }
                            else
                            {
                                MessageBox.Show("Please enter an Invoice No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_editvoucherno.Focus();
                            }

                        }

                        if (chk_customer.Checked == false && chkvoucherNo.Checked == false && chkDate.Checked == true)
                        {
                            ds.Rows.Clear();
                            ds = objcode.getreceiptdetailsforeditpayment("", txt_editvoucherno.Text, dtfrom.Value, dtto.Value, "6");// string                 
                            t = 1;
                        }
                        if (chk_customer.Checked == false && chkvoucherNo.Checked == false && chkDate.Checked == false)
                        {
                            t = 0;
                            MessageBox.Show("Please Select Any Serching Criteria", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        if (ds.Rows.Count > 0 && t == 1)
                        {
                           
                            t = 0;
                            dgvEdit.Rows.Clear();
                            for (int i = 0; i < ds.Rows.Count; i++)
                            {
                                dgvEdit.Rows.Add();
                                dgvEdit[0, i].Value = ds.Rows[i]["VoucherDate"].ToString();
                                dgvEdit[1, i].Value = ds.Rows[i]["VoucherNo"].ToString();
                                dgvEdit[2, i].Value = ds.Rows[i]["OtherName"].ToString();
                                dgvEdit[3, i].Value = ds.Rows[i]["Amount"].ToString();
                                dgvEdit[4, i].Value = ds.Rows[i]["description"].ToString();
                                dgvEdit[5, i].Value = ds.Rows[i]["Paymode"].ToString();
                                dgvEdit[6, i].Value = ds.Rows[i]["Id"].ToString();
                                dgvEdit[7, i].Value = ds.Rows[i]["DealerID"].ToString();
                            }
                            CHkGR = 1;

                        }

                        txt_editvoucherno.Text = "";
                    }


                    //Old Payable

                    if (Rb_OldPayable.Checked == true)
                    {
                        if (chk_customer.Checked == true && chkvoucherNo.Checked == false && chkDate.Checked == false)
                        {
                            if (cmb_editcustomer.SelectedIndex >= 0)
                            {
                                ds.Rows.Clear();
                                ds = objcode.GetReceiptDetailsForEditPaymentOldPay(cmb_editcustomer.SelectedValue.ToString(), "", DateTime.Now, DateTime.Now, "0");// string    
                                t = 1;
                            }
                        }
                        if (chk_customer.Checked == true && chkvoucherNo.Checked == true && chkDate.Checked == false)
                        {
                            if (cmb_editcustomer.SelectedIndex >= 0)
                            {
                                ds.Rows.Clear();
                                ds = objcode.GetReceiptDetailsForEditPaymentOldPay(cmb_editcustomer.SelectedValue.ToString(), txt_editvoucherno.Text, DateTime.Now, DateTime.Now, "1");// string                 
                                t = 1;
                            }
                        }
                        if (chk_customer.Checked == false && chkvoucherNo.Checked == true && chkDate.Checked == false)
                        {
                            ds.Rows.Clear();
                            ds = objcode.GetReceiptDetailsForEditPaymentOldPay("", txt_editvoucherno.Text, DateTime.Now, DateTime.Now, "2");// string 
                            t = 1;
                        }
                        if (chk_customer.Checked == true && chkvoucherNo.Checked == false && chkDate.Checked == true)
                        {
                            if (cmb_editcustomer.SelectedIndex >= 0)
                            {
                                ds.Rows.Clear();
                                ds = objcode.GetReceiptDetailsForEditPaymentOldPay(cmb_editcustomer.SelectedValue.ToString(), txt_editvoucherno.Text, dtfrom.Value, dtto.Value, "3");// string 
                                t = 1;
                            }
                        }
                        if (chk_customer.Checked == true && chkvoucherNo.Checked == true && chkDate.Checked == true)
                        {
                            if (cmb_editcustomer.SelectedIndex >= 0)
                            {
                                ds.Rows.Clear();
                                ds = objcode.GetReceiptDetailsForEditPaymentOldPay(cmb_editcustomer.SelectedValue.ToString(), txt_editvoucherno.Text, dtfrom.Value, dtto.Value, "4");// string                 
                                t = 1;
                            }
                        }
                        if (chk_customer.Checked == false && chkvoucherNo.Checked == true && chkDate.Checked == true)
                        {
                            ds.Rows.Clear();
                            ds = objcode.GetReceiptDetailsForEditPaymentOldPay("", txt_editvoucherno.Text, dtfrom.Value, dtto.Value, "5");// string 
                            t = 1;

                        }

                        if (chk_customer.Checked == false && chkvoucherNo.Checked == false && chkDate.Checked == true)
                        {
                            ds.Rows.Clear();
                            ds = objcode.GetReceiptDetailsForEditPaymentOldPay("", txt_editvoucherno.Text, dtfrom.Value, dtto.Value, "6");// string                 
                            t = 1;
                        }

                        if (chk_customer.Checked == false && chkvoucherNo.Checked == false && chkDate.Checked == false)
                        {
                            t = 0;
                            MessageBox.Show("Please Select Any Serching Criteria", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        if (ds.Rows.Count <= 0 && t == 1)
                        {
                            MessageBox.Show("No Search Results Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            t = 0;
                        }
                        else
                        {
                            t = 0;
                            dgvEdit.Rows.Clear();
                            for (int i = 0; i < ds.Rows.Count; i++)
                            {
                                dgvEdit.Rows.Add();
                                dgvEdit[0, i].Value = ds.Rows[i]["VoucherDate"].ToString();
                                dgvEdit[1, i].Value = ds.Rows[i]["VoucherNo"].ToString();
                                dgvEdit[2, i].Value = ds.Rows[i]["OtherName"].ToString();
                                dgvEdit[3, i].Value = ds.Rows[i]["Amount"].ToString();
                                dgvEdit[4, i].Value = ds.Rows[i]["description"].ToString();
                                dgvEdit[5, i].Value = ds.Rows[i]["Paymode"].ToString();
                                dgvEdit[6, i].Value = ds.Rows[i]["Id"].ToString();
                                dgvEdit[7, i].Value = ds.Rows[i]["DealerID"].ToString();
                            }
                            CHkGR = 2;
                        }

                        txt_editvoucherno.Text = "";
                    }

                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void dgvEdit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvEdit.Rows.Count != 0)
                {

                    if (e.RowIndex >= 0)
                    {
                        int rindex = dgvEdit.CurrentCell.RowIndex;
                        rid = dgvEdit.Rows[rindex].Cells[6].Value.ToString();
                        ChkSer = 1;

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
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

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_editcustomer_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_editcustomer.DroppedDown)
            {
                cmb_editcustomer.Focus();
            }
        }

        private void txt_editvoucherno_DoubleClick(object sender, EventArgs e)
        {
            if (!cmb_editcustomer.DroppedDown)
            {
                cmb_editcustomer.Focus();
            }
        }
    }
}
