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
    public partial class PaymentVoucher : Form
    {
        public PaymentVoucher()
        {
            InitializeComponent();
            chk = 0;
            btn_Save1.Enabled = true;
            btn_update.Enabled = false;
            btndelete.Enabled = false;
            rb_customer.Checked = true;
            btn_remove.Enabled = true; ;
            BTNCHANGE.Enabled = false;
            CheckId = 0;
        }
        double sum1 = 0;

        //int no = 0;
        //int g = 0;
        double sum = 0;
        int inid = 0;
        string rid, refno;
        double tot = 0;
        int chk = 0;
        public int CheckId = 0;

        string Balance = "0";
        Codebehind objcode = new Codebehind();
        string dealid = "0", InvoiceId = "0";
        int f = 0, t = 0;
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
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
        private void PaymentVoucher_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    DataTable dt1 = new DataTable();
                    dt1 = objcode.GetFormUserRights(File.ReadAllText("user.txt"), "PaymentVoucher");
                    SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
                    UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
                    DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();

                    btnadd.Enabled = true;
                    if (chk == 0 && Rb_GoodsReceipt.Checked == true)
                    {
                        vouchernoload();
                    }
                    Balance = "0";
                    DataSet ds = new DataSet();
                    ds = objcode.GetDealer();
                    cmb_Customer.DataSource = ds.Tables[0];
                    cmb_Customer.DisplayMember = "dealer_name";
                    cmb_Customer.ValueMember = "dealer_id";
                    DataRow dr1 = ds.Tables[0].NewRow();
                    dr1["dealer_name"] = "--Select One--";
                    dr1["dealer_id"] = "0";
                    ds.Tables[0].Rows.InsertAt(dr1, 0);
                    cmb_Customer.SelectedIndex = 0;
                    cmb_Paymentmode.SelectedIndex = 0;

                    DataSet ds1 = new DataSet();
                    ds1 = objcode.LoadBankName();
                    cmbBank.DataSource = ds1.Tables[0];
                    cmbBank.DisplayMember = "bank_name";
                    cmbBank.ValueMember = "bank_id";
                    DataRow dr12 = ds1.Tables[0].NewRow();
                    dr12["bank_name"] = "--Select One--";
                    dr12["bank_id"] = "0";
                    ds1.Tables[0].Rows.InsertAt(dr12, 0);
                    cmbBank.SelectedIndex = 0;

                    f = 1;
                    t = 0;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        public void vouchernoload()
        {
            try
            {
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {

                    string vnopay = objcode.GetVoucherNopayment();
                    txt_Voucherno.Text = vnopay.ToString();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        public void VoucherNoLoadOldPay()
        {
            try
            {

                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    string vnopay = objcode.GetVoucherNopaymentOld();
                    txt_Voucherno.Text = vnopay.ToString();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cmb_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                lbldot.Text = ".";
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (Rb_GoodsReceipt.Checked == true)
                    {
                        if (rb_other.Checked == false)
                        {
                            if (f == 1)
                            {
                                f = 0;
                                if (cmb_Customer.SelectedValue != null)
                                {
                                    dealid = cmb_Customer.SelectedValue.ToString();
                                    DataSet ds2 = new DataSet();
                                    ds2 = objcode.SelectInvoiceNopayment(dealid);
                                    cmb_invoice.DataSource = ds2.Tables[0];
                                    cmb_invoice.DisplayMember = "InvoiceId";
                                    cmb_invoice.ValueMember = "InvoiceId";

                                    cmb_invoice.Text = "--Select--";

                                    f = 1;
                                }
                            }
                            t = 1;
                        }
                    }
                    if (Rb_OldPayable.Checked == true)
                    {
                        if (rb_other.Checked == false)
                        {
                            if (f == 1)
                            {
                                f = 0;
                                if (cmb_Customer.SelectedValue != null)
                                {
                                    dealid = cmb_Customer.SelectedValue.ToString();
                                    DataSet ds2 = new DataSet();
                                    ds2 = objcode.SelectInvoiceNopaymentOldPay(dealid);
                                    cmb_invoice.DataSource = ds2.Tables[0];
                                    cmb_invoice.DisplayMember = "RefNo";
                                    cmb_invoice.ValueMember = "OldPayReceiveID";

                                    cmb_invoice.Text = "--Select--";

                                    f = 1;
                                }
                            }
                            t = 1;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (Rb_GoodsReceipt.Checked == true)
                    {
                        //goods receipt
                        int t = 0;
                        if ((cmb_Customer.SelectedIndex > 0) && (cmb_Paymentmode.Text != "--Select One--") && (cmb_invoice.SelectedValue != null) && (cmb_invoice.Text != "--Select--"))
                        {
                            int invoicen = Convert.ToInt32(cmb_invoice.Text);

                            for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                            {
                                int invgrid = Convert.ToInt32(dgv_Receipt.Rows[i].Cells[1].Value);
                                if (invoicen == invgrid)
                                {
                                    t = 2;
                                    MessageBox.Show("Selected Goods Receipt Already Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            if (t != 2)
                            {
                                if (txt_amount1.Text != "0")
                                {
                                    double dotamt = Convert.ToDouble(lbldot.Text);
                                    double amt1 = Convert.ToDouble(txt_amount1.Text);

                                    if (dotamt >= amt1)
                                    {
                                        double amt2 = Convert.ToDouble(txt_amount1.Text);

                                        dgv_Receipt.Rows.Add(cmb_invoice.SelectedValue, cmb_invoice.Text, txtdescription1.Text, amt2);
                                        txtdescription1.Text = "";
                                        txt_amount1.Text = "0";
                                        if (Balance == "0" || Balance == string.Empty)
                                        {
                                            lbldot.Text = (dotamt - amt1).ToString();
                                        }
                                        else
                                        {
                                            Balance = (Convert.ToDouble(Balance) - amt1).ToString();
                                            lbldot.Text = Balance;
                                        }
                                        cmb_Customer.Enabled = false;
                                        if (dgv_Receipt.Rows.Count != 0)
                                        {
                                            sum1 = 0;
                                            for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                            {
                                                sum1 = sum1 + Convert.ToDouble(dgv_Receipt.Rows[i].Cells[3].Value);
                                            }
                                        }
                                        txt_Amount.Text = sum1.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Check The Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Check The Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }
                        }
                        else
                        {
                            if (cmb_Customer.SelectedIndex <= 0)
                            {
                                MessageBox.Show("Please Select Dealer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmb_Customer.Focus();

                            }
                            else if (cmb_Paymentmode.Text == "--Select One--")
                            {
                                MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmb_Paymentmode.Focus();

                            }
                            else if ((cmb_invoice.SelectedValue == null))
                            {
                                MessageBox.Show("Please Select Invoice", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmb_invoice.Focus();

                            }
                            else if (cmb_invoice.Text == "--Select One--")
                            {
                                MessageBox.Show("Please Select Invoice", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmb_invoice.Focus();

                            }

                        }


                    }
                    if (Rb_OldPayable.Checked == true)
                    {
                        //goods receipt
                        int t = 0;
                        if ((cmb_Customer.SelectedIndex > 0) && (cmb_Paymentmode.Text != "--Select One--") && (cmb_invoice.SelectedValue != null) && (cmb_invoice.Text != "--Select--"))
                        {
                            string invoicen = cmb_invoice.Text;
                            
                            for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                            {
                                string invgrid = dgv_Receipt.Rows[i].Cells[1].Value.ToString();
                                if (invoicen == invgrid)
                                {
                                    t = 2;
                                    MessageBox.Show("Selected Goods Receipt Already Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            if (t != 2)
                            {
                                if (txt_amount1.Text != "0")
                                {
                                    double dotamt = Convert.ToDouble(lbldot.Text);
                                    double amt1 = Convert.ToDouble(txt_amount1.Text);

                                    if (dotamt >= amt1)
                                    {
                                        double amt2 = Convert.ToDouble(txt_amount1.Text);

                                        dgv_Receipt.Rows.Add(cmb_invoice.SelectedValue, cmb_invoice.Text, txtdescription1.Text, amt2);
                                        txtdescription1.Text = "";
                                        txt_amount1.Text = "0";
                                        if (Balance == "0" || Balance == string.Empty)
                                        {
                                            lbldot.Text = (dotamt - amt1).ToString();
                                        }
                                        else
                                        {
                                            Balance = (Convert.ToDouble(Balance) - amt1).ToString();
                                            lbldot.Text = Balance;
                                        }
                                        cmb_Customer.Enabled = false;
                                        if (dgv_Receipt.Rows.Count != 0)
                                        {
                                            sum1 = 0;
                                            for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                            {
                                                sum1 = sum1 + Convert.ToDouble(dgv_Receipt.Rows[i].Cells[3].Value);
                                            }
                                        }
                                        txt_Amount.Text = sum1.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Check The Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Check The Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }
                        }
                        else
                        {
                            if (cmb_Customer.SelectedIndex <= 0)
                            {
                                MessageBox.Show("Please Select Dealer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmb_Customer.Focus();

                            }
                            else if (cmb_Paymentmode.Text == "--Select One--")
                            {
                                MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmb_Paymentmode.Focus();

                            }
                            else if ((cmb_invoice.SelectedValue == null))
                            {
                                MessageBox.Show("Please Select Invoice", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmb_invoice.Focus();

                            }
                            else if (cmb_invoice.Text == "--Select--")
                            {
                                MessageBox.Show("Please Select Invoice", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmb_invoice.Focus();

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

        private void cmb_invoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbldot.Text = "";
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (Rb_GoodsReceipt.Checked == true)
                    {
                        if (t == 1 && f == 1)
                        {
                            if (Convert.ToInt32(cmb_invoice.SelectedValue) != 0)
                            {
                                InvoiceId = cmb_invoice.SelectedValue.ToString();
                                // MessageBox.Show(InvoiceId);
                                DataSet ds2 = new DataSet();
                                ds2 = objcode.Getbalanceinvoicenopayment(InvoiceId);
                                lbldot.Text = ds2.Tables[0].Rows[0][0].ToString();
                                if (lbldot.Visible == false)
                                    lbldot.Visible = true;
                            }
                        }
                    }


                    if (Rb_OldPayable.Checked == true)
                    {
                        if (t == 1 && f == 1)
                        {
                            if (Convert.ToInt32(cmb_invoice.SelectedValue) != 0)
                            {
                                InvoiceId = cmb_invoice.SelectedValue.ToString();
                                // MessageBox.Show(InvoiceId);
                                DataSet ds2 = new DataSet();
                                ds2 = objcode.GetbalanceInvoiceNoPaymentOldPay(InvoiceId);
                                lbldot.Text = ds2.Tables[0].Rows[0][0].ToString();
                                if (lbldot.Visible == false)
                                    lbldot.Visible = true;
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (UpdateStatus == "1")
                    {
                        if (Rb_GoodsReceipt.Checked == true)
                        {
                            //other cusstomer
                            if (cmb_Paymentmode.Text != "--Select One--")
                            {
                                if (rb_other.Checked == true)
                                {



                                    if (cmb_Paymentmode.Text == "Cheque")
                                    {
                                        if (txtCheque.Text != string.Empty && Convert.ToInt32(cmbBank.SelectedValue) != 0)
                                        {
                                            // delete payment master, details
                                            string mg = objcode.deletepayment(textBox1.Text);


                                            //delete dealer details 
                                            objcode.DeleteDealerAccDetailsByPV(Convert.ToInt32(textBox1.Text));

                                            //delete from check details
                                            if (CheckId != 0)
                                            {
                                                objcode.DeleteCheckDetailsByPV(CheckId);
                                            }

                                            int status;
                                            if (cbox_check.Checked == true)
                                                status = 1;
                                            else
                                                status = 0;
                                            string msg = objcode.InsertpaymentVoucher(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                            //insert check details
                                            objcode.InsertChequeDetails(txt_Voucherno.Text, "5", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());

                                            //insert dealer account details
                                            objcode.InsertDealerAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "2", "5", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Refnum-" + msg);
                                           // objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Update");
                                            MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            vouchernoload();
                                            clear();
                                        }
                                        else
                                        {
                                            if (txtCheque.Text == string.Empty)
                                            {
                                                MessageBox.Show("Please Enter Check No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                txtCheque.Focus();
                                            }
                                            else if (Convert.ToInt32(cmbBank.SelectedValue) == 0)
                                            {
                                                MessageBox.Show("Please Select Bank.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                txtCheque.Focus();
                                            }

                                        }
                                    }
                                    else
                                    {
                                        // delete payment master, details
                                        string mg = objcode.deletepayment(textBox1.Text);


                                        //delete dealer details 
                                        objcode.DeleteDealerAccDetailsByPV(Convert.ToInt32(textBox1.Text));

                                        //delete from check details
                                        if (CheckId != 0)
                                        {
                                            objcode.DeleteCheckDetailsByPV(CheckId);
                                        }
                                        string msg = objcode.InsertpaymentVoucher(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                        //insert dealer account details
                                        objcode.InsertDealerAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "2", "5", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Refnum-" + msg);
                                        //objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Update");
                                        MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        vouchernoload();
                                        clear();

                                    }

                                }

                                    //normal customer
                                else
                                {
                                    if (dgv_Receipt.Rows.Count != 0)
                                    {
                                        // g = 0;
                                        sum = 0;
                                        //no = 0;
                                        tot = 0;
                                        for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                        {
                                            double sumrows = Convert.ToDouble(dgv_Receipt.Rows[i].Cells[3].Value.ToString());
                                            sum = sum + sumrows;
                                        }


                                        if (Convert.ToDouble(txt_Amount.Text) == sum)
                                        {
                                            if (cmb_Paymentmode.Text == "Cheque")
                                            {
                                                if (txtCheque.Text != string.Empty && Convert.ToInt32(cmbBank.SelectedValue) != 0)
                                                {
                                                    // delete payment master, details
                                                    string mg = objcode.deletepayment(textBox1.Text);


                                                    //delete dealer details 
                                                    objcode.DeleteDealerAccDetailsByPV(Convert.ToInt32(textBox1.Text));

                                                    //delete from check details
                                                    if (CheckId != 0)
                                                    {
                                                        objcode.DeleteCheckDetailsByPV(CheckId);
                                                    }

                                                    int status;
                                                    if (cbox_check.Checked == true)
                                                        status = 1;
                                                    else
                                                        status = 0;

                                                    string msg = objcode.InsertpaymentVoucher(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                    //insert check details
                                                    objcode.InsertChequeDetails(txt_Voucherno.Text, "5", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());
                                                    //insert dealer account details
                                                    objcode.InsertDealerAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "2", "5", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Refnum-" + msg);


                                                    string rid1 = objcode.selectidpayment();
                                                    for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                    {
                                                        string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                        string customerid = cmb_Customer.SelectedValue.ToString();
                                                        string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                        string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                        string msg1 = objcode.InsertpaymentVoucherDetails(rid1, invid, customerid, desc, amt);
                                                    }


                                                    sum = 0;
                                                    dgv_Receipt.Rows.Clear();

                                                    clear();

                                                    btn_update.Enabled = false;
                                                    btndelete.Enabled = false;
                                                    vouchernoload();
                                                    btn_Save1.Enabled = true;
                                                    btn_remove.Enabled = true;

                                                    MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }

                                                else
                                                {
                                                    if (txtCheque.Text == string.Empty)
                                                    {
                                                        MessageBox.Show("Please Enter Check No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        txtCheque.Focus();
                                                    }
                                                    else if (Convert.ToInt32(cmbBank.SelectedValue) == 0)
                                                    {
                                                        MessageBox.Show("Please Select Bank.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        txtCheque.Focus();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                // delete payment master, details
                                                string mg = objcode.deletepayment(textBox1.Text);


                                                //delete dealer details 
                                                objcode.DeleteDealerAccDetailsByPV(Convert.ToInt32(textBox1.Text));

                                                //delete from check details
                                                if (CheckId != 0)
                                                {
                                                    objcode.DeleteCheckDetailsByPV(CheckId);
                                                }

                                                string msg = objcode.InsertpaymentVoucher(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                                //insert dealer account details
                                                objcode.InsertDealerAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "2", "5", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Refnum-" + msg);

                                                //insertion into payment details
                                                string rid1 = objcode.selectidpayment();
                                                for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                {
                                                    string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                    string customerid = cmb_Customer.SelectedValue.ToString();
                                                    string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                    string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                    string msg1 = objcode.InsertpaymentVoucherDetails(rid1, invid, customerid, desc, amt);
                                                }
                                              //  objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Update");
                                                MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                sum = 0;
                                                dgv_Receipt.Rows.Clear();

                                                clear();
                                                btn_update.Enabled = false;
                                                btndelete.Enabled = false;
                                                vouchernoload();
                                                btn_Save1.Enabled = true;
                                                btn_remove.Enabled = true;

                                            }


                                        }
                                        else
                                        {
                                            MessageBox.Show("Enter Valid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Please Add The Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            else
                            {
                                if (cmb_Paymentmode.Text == "--Select One--")
                                {
                                    MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }


                        //Old Payable

                        if (Rb_GoodsReceipt.Checked == false && Rb_OldPayable.Checked == true)
                        {
                            //other cusstomer
                            if (cmb_Paymentmode.Text != "--Select One--")
                            {
                                if (rb_other.Checked == true)
                                {



                                    if (cmb_Paymentmode.Text == "Cheque")
                                    {
                                        if (txtCheque.Text != string.Empty && Convert.ToInt32(cmbBank.SelectedValue) != 0)
                                        {
                                            // delete payment master, details
                                            string mg = objcode.DeletePaymentOldPay(textBox1.Text);


                                            //delete dealer details 
                                            objcode.DeleteDealerAccDetailsByPVOldPay(Convert.ToInt32(textBox1.Text));

                                            //delete from check details
                                            if (CheckId != 0)
                                            {
                                                objcode.DeleteCheckDetailsByPVOldPay(CheckId);
                                            }

                                            int status;
                                            if (cbox_check.Checked == true)
                                                status = 1;
                                            else
                                                status = 0;
                                            string msg = objcode.InsertpaymentVoucherOldPayable(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                            //insert check details
                                            objcode.InsertChequeDetails(txt_Voucherno.Text, "9", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());

                                            //insert dealer account details
                                            objcode.InsertDealerAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "2", "9", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Old Payable Refnum-" + msg);
                                           // objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Update");
                                            MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            vouchernoload();
                                            clear();
                                        }
                                        else
                                        {
                                            if (txtCheque.Text == string.Empty)
                                            {
                                                MessageBox.Show("Please Enter Check No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                txtCheque.Focus();
                                            }
                                            else if (Convert.ToInt32(cmbBank.SelectedValue) == 0)
                                            {
                                                MessageBox.Show("Please Select Bank.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                txtCheque.Focus();
                                            }

                                        }
                                    }
                                    else
                                    {
                                        // delete payment master, details
                                        string mg = objcode.DeletePaymentOldPay(textBox1.Text);


                                        //delete dealer details 
                                        objcode.DeleteDealerAccDetailsByPVOldPay(Convert.ToInt32(textBox1.Text));

                                        //delete from check details
                                        if (CheckId != 0)
                                        {
                                            objcode.DeleteCheckDetailsByPVOldPay(CheckId);
                                        }
                                        string msg = objcode.InsertpaymentVoucherOldPayable(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                        //insert dealer account details
                                        objcode.InsertDealerAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "2", "9", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Old Payable Refnum-" + msg);
                                        //objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Update");
                                        MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        vouchernoload();
                                        clear();

                                    }

                                }

                                    //normal customer
                                else
                                {
                                    if (dgv_Receipt.Rows.Count != 0)
                                    {
                                        // g = 0;
                                        sum = 0;
                                        //no = 0;
                                        tot = 0;
                                        for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                        {
                                            double sumrows = Convert.ToDouble(dgv_Receipt.Rows[i].Cells[3].Value.ToString());
                                            sum = sum + sumrows;
                                        }


                                        if (Convert.ToDouble(txt_Amount.Text) == sum)
                                        {
                                            if (cmb_Paymentmode.Text == "Cheque")
                                            {
                                                if (txtCheque.Text != string.Empty && Convert.ToInt32(cmbBank.SelectedValue) != 0)
                                                {
                                                    // delete payment master, details
                                                    string mg = objcode.DeletePaymentOldPay(textBox1.Text);


                                                    //delete dealer details 
                                                    objcode.DeleteDealerAccDetailsByPVOldPay(Convert.ToInt32(textBox1.Text));

                                                    //delete from check details
                                                    if (CheckId != 0)
                                                    {
                                                        objcode.DeleteCheckDetailsByPVOldPay(CheckId);
                                                    }

                                                    int status;
                                                    if (cbox_check.Checked == true)
                                                        status = 1;
                                                    else
                                                        status = 0;

                                                    string msg = objcode.InsertpaymentVoucherOldPayable(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                    //insert check details
                                                    objcode.InsertChequeDetails(txt_Voucherno.Text, "9", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());
                                                    //insert dealer account details
                                                    objcode.InsertDealerAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "2", "9", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Old Payable  Refnum-" + msg);


                                                    string rid1 = objcode.selectidpayment();
                                                    for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                    {
                                                        string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                        string customerid = cmb_Customer.SelectedValue.ToString();
                                                        string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                        string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                        string msg1 = objcode.InsertpaymentVoucherDetailsOldPayment(msg, invid, customerid, desc, amt);
                                                    }


                                                    sum = 0;
                                                    dgv_Receipt.Rows.Clear();

                                                    clear();

                                                    btn_update.Enabled = false;
                                                    btndelete.Enabled = false;
                                                    vouchernoload();
                                                    btn_Save1.Enabled = true;
                                                    btn_remove.Enabled = true;
                                                    //objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Update");
                                                    MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }

                                                else
                                                {
                                                    if (txtCheque.Text == string.Empty)
                                                    {
                                                        MessageBox.Show("Please Enter Check No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        txtCheque.Focus();
                                                    }
                                                    else if (Convert.ToInt32(cmbBank.SelectedValue) == 0)
                                                    {
                                                        MessageBox.Show("Please Select Bank.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        txtCheque.Focus();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                // delete payment master, details
                                                string mg = objcode.DeletePaymentOldPay(textBox1.Text);


                                                //delete dealer details 
                                                objcode.DeleteDealerAccDetailsByPVOldPay(Convert.ToInt32(textBox1.Text));

                                                //delete from check details
                                                if (CheckId != 0)
                                                {
                                                    objcode.DeleteCheckDetailsByPVOldPay(CheckId);
                                                }

                                                string msg = objcode.InsertpaymentVoucherOldPayable(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                                //insert dealer account details
                                                objcode.InsertDealerAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "2", "5", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Old Payable Refnum-" + msg);

                                                //insertion into payment details
                                                string rid1 = objcode.selectidpayment();
                                                for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                {
                                                    string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                    string customerid = cmb_Customer.SelectedValue.ToString();
                                                    string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                    string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                    string msg1 = objcode.InsertpaymentVoucherDetailsOldPayment(msg, invid, customerid, desc, amt);
                                                }
                                               // objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Update");
                                                MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                sum = 0;
                                                dgv_Receipt.Rows.Clear();

                                                clear();
                                                btn_update.Enabled = false;
                                                btndelete.Enabled = false;
                                                vouchernoload();
                                                btn_Save1.Enabled = true;
                                                btn_remove.Enabled = true;

                                            }


                                        }
                                        else
                                        {
                                            MessageBox.Show("Enter Valid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Please Add The Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            else
                            {
                                if (cmb_Paymentmode.Text == "--Select One--")
                                {
                                    MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("You Do Not Have The Permission To Update Payment Voucher", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        public void clear()
        {
            try
            {
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (Rb_GoodsReceipt.Checked == true)
                    {
                        vouchernoload();
                        rb_other.Enabled = false;
                    }
                    if (Rb_OldPayable.Checked == true)
                    {
                        VoucherNoLoadOldPay();
                        rb_other.Enabled = false;
                    }
                    txt_Amount.Text = "0";
                    txt_Description.Text = "";
                    InvoiceDetails.Visible = true;
                    panelbank.Enabled = false;
                    btn_Save1.Enabled = true;
                    btn_update.Enabled = false;
                    btndelete.Enabled = false;
                    lbldot.Visible = false;
                    btn_remove.Enabled = true;
                    txt_amount1.Text = "0";
                    txt_Amount.Text = "0";
                    txtdescription1.Text = "";
                    txt_Description.Text = "";
                    cmb_Customer.Enabled = true;
                    txtother.Enabled = true;
                    dtvoucher.Value = DateTime.Now;
                    txtother.Text = "";
                    txtCheque.Text = "";
                    Balance = "0";
                    rid = "0";
                    rb_other.Enabled = true;
                    //  cmb_Customer.SelectedIndex = 0;
                    //rb_customer.Checked = true;

                    cmb_Customer.Text = "--Select One--";
                    //cmb_invoice.Items.Clear();
                    cmb_invoice.DataSource = null;
                    cmb_invoice.Text = "--Select One--";
                    //vouchernoload();
                    //cmb_invoice.SelectedIndex = 0;
                    if (dgv_Receipt.Rows.Count != 0)
                    {
                        dgv_Receipt.Rows.Clear();
                    }
                    if (rb_other.Checked == true)
                    {
                        lblname.Visible = true;
                        txtother.Visible = true;
                        label4.Visible = false;
                        cmb_Customer.Visible = false;
                        txt_Amount.Enabled = true;
                        txt_Amount.Text = "0";
                        InvoiceDetails.Visible = false;
                        label8.Visible = false;
                    }
                    dtvoucher.Value = DateTime.Now;
                    dtChequeDate.Value = DateTime.Now;

                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void rb_customer_CheckedChanged(object sender, EventArgs e)
        {
              try
            {
                if (rb_customer.Checked == true)
                {
                    clear();
                    if (Rb_OldPayable.Checked == true)
                        rb_other.Enabled = false;

                    lblname.Visible = false;
                    txtother.Visible = false;
                    label4.Visible = true;
                    cmb_Customer.Visible = true;
                    txt_Amount.Enabled = false;
                    txt_Amount.Text = "0";
                    InvoiceDetails.Visible = true;
                    label8.Visible = true;

                }
            }
              catch (Exception ex)
              {
                  File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
              }
        }

        private void rb_other_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rb_other.Checked == true)
                {
                    clear();
                    lblname.Visible = true;
                    txtother.Visible = true;
                    label4.Visible = false;
                    cmb_Customer.Visible = false;
                    txt_Amount.Enabled = true;
                    txt_Amount.Text = "0";
                    InvoiceDetails.Visible = false;
                    label8.Visible = false;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btn_cancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNCHANGE_Click(object sender, EventArgs e)
        {
            try
            {
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (dgv_Receipt.Rows.Count != 0)
                    {
                        if (cmb_invoice.SelectedValue != null)
                        {
                            if (txt_amount1.Text != "0")
                            {
                                double dotamt = Convert.ToDouble(lbldot.Text);
                                double amt1 = Convert.ToDouble(txt_amount1.Text);

                                if (dotamt >= amt1)
                                {
                                    int RINX = dgv_Receipt.CurrentCell.RowIndex;
                                    dgv_Receipt.Rows.RemoveAt(RINX);

                                    // int invid =Convert.ToInt32(inid,
                                    int inno = Convert.ToInt32(cmb_invoice.Text);
                                    string des = txtdescription1.Text;
                                    double amt = Convert.ToDouble(txt_amount1.Text);
                                    dgv_Receipt.Rows.Add(inid, inno, des, amt);
                                    if (dgv_Receipt.Rows.Count != 0)
                                    {
                                        sum1 = 0;
                                        for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                        {
                                            sum1 = sum1 + Convert.ToDouble(dgv_Receipt.Rows[i].Cells[3].Value);
                                        }
                                        txt_Amount.Text = sum1.ToString();
                                    }
                                }
                                //double amt = Convert.ToDouble(dgv_Receipt.Rows[RINX].Cells[3].Value);
                                //txtdescription1.Text = des.ToString();
                                //txt_amount1.Text = amt.ToString();
                                //cmb_invoice.Text = invno.ToString();
                            }
                        }

                    }
                    BTNCHANGE.Enabled = false;
                    cmb_invoice.Text = "--Select One--";
                    cmb_Customer.Text = "--Select One--";
                    txt_amount1.Text = "0";
                    txtdescription1.Text = "";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cmb_Paymentmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Paymentmode.Text == "Cheque" && f == 1)
            {
                panelbank.Enabled = true;
            }
            else
            {
                panelbank.Enabled = false;
            }
        }

        private void txt_amount1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;

            FloatValueValidate(e);
        }

        private void btn_Save1_Click(object sender, EventArgs e)
        {
            try
            {
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {

                    if (SaveStatus == "1")
                    {
                        if (Rb_GoodsReceipt.Checked == true)
                        {
                            if (txt_Amount.Text != "0" && cmb_Paymentmode.Text != "--Select One--")
                            {
                                if (rb_other.Checked == true)
                                {
                                    if (txtother.Text != string.Empty && txt_Amount.Text != "0" && cmb_Paymentmode.Text != string.Empty)
                                    {

                                        if (cmb_Paymentmode.Text == "Cheque")
                                        {
                                            if (txtCheque.Text != string.Empty && cmbBank.SelectedIndex > 0)
                                            {
                                                int status;
                                                if (cbox_check.Checked == true)
                                                    status = 1;
                                                else
                                                    status = 0;
                                                string msg = objcode.InsertpaymentVoucher(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                objcode.InsertChequeDetails(txt_Voucherno.Text, "5", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());

                                                //insert dealer account details
                                                objcode.InsertDealerAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "2", "5", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Refnum-" + msg);
                                                //  if (msg == "Password Successfully Updated")
                                                //objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Save");
                                                //  objcode.SaveWindow(DateTime.Now, "Payment Voucher", File.ReadAllText("user.txt"), "Save");
                                                MessageBox.Show("Voucher Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                vouchernoload();
                                                clear();
                                            }
                                            else
                                            {
                                                if (txtCheque.Text == string.Empty)
                                                {
                                                    MessageBox.Show("Please Enter Check No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    txtCheque.Focus();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please Select Bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    cmbBank.Focus();
                                                }
                                            }
                                        }
                                        else
                                        {
                                            string msg = objcode.InsertpaymentVoucher(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                            //insert dealer account details
                                            objcode.InsertDealerAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "2", "5", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Refnum-" + msg);
                                            // objcode.SaveWindow(DateTime.Now, "Payment Voucher", File.ReadAllText("user.txt"), "Save");
                                            //objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Save");
                                            MessageBox.Show("Voucher Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            vouchernoload();
                                            clear();

                                        }
                                    }
                                    else
                                    {
                                        if (txtother.Text == string.Empty)
                                        {
                                            MessageBox.Show("Please Enter Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            txtother.Focus();
                                        }
                                        else if (cmb_Paymentmode.Text == string.Empty)
                                        {
                                            MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cmb_Paymentmode.Focus();
                                        }
                                        else if (txt_Amount.Text == "0")
                                        {
                                            MessageBox.Show("Please Enter Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            txt_Amount.Focus();
                                        }
                                    }

                                }
                                else
                                {
                                    if (dgv_Receipt.Rows.Count != 0)
                                    {

                                        sum = 0;
                                        //no = 0;
                                        tot = 0;
                                        for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                        {
                                            double sumrows = Convert.ToDouble(dgv_Receipt.Rows[i].Cells[3].Value.ToString());
                                            sum = sum + sumrows;
                                        }
                                        if (Convert.ToDouble(txt_Amount.Text) == sum)
                                        {
                                            if (cmb_Paymentmode.Text == "Cheque")
                                            {
                                                if (txtCheque.Text != string.Empty && cmbBank.SelectedIndex > 0)
                                                {
                                                    int status;
                                                    if (cbox_check.Checked == true)
                                                        status = 1;
                                                    else
                                                        status = 0;

                                                    string msg = objcode.InsertpaymentVoucher(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                    //insert check details
                                                    objcode.InsertChequeDetails(txt_Voucherno.Text, "5", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());
                                                    //insert dealer account details
                                                    objcode.InsertDealerAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "2", "5", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Refnum-" + msg);

                                                    //insert into payment details
                                                    string rid = objcode.selectidpayment();
                                                    for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                    {
                                                        string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                        string customerid = cmb_Customer.SelectedValue.ToString();
                                                        string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                        string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                        string msg1 = objcode.InsertpaymentVoucherDetails(rid, invid, customerid, desc, amt);
                                                    }

                                                    //objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Save");
                                                    //  objcode.SaveWindow(DateTime.Now, "Payment Voucher", File.ReadAllText("user.txt"), "Save");
                                                    MessageBox.Show("Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    sum = 0;
                                                    dgv_Receipt.Rows.Clear();
                                                    vouchernoload();
                                                    clear();
                                                    cmb_Customer.Text = "--Select One--";

                                                    lbldot.Text = 0.ToString();

                                                }
                                                else
                                                {
                                                    if (txtCheque.Text == string.Empty)
                                                    {
                                                        MessageBox.Show("Please Enter Check No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        txtCheque.Focus();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please Select Bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        cmbBank.Focus();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string msg = objcode.InsertpaymentVoucher(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                                //insert dealer account details
                                                objcode.InsertDealerAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "2", "5", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Refnum-" + msg);

                                                //insert payment voucher details
                                                string rid = objcode.selectidpayment();
                                                for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                {
                                                    string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                    string customerid = cmb_Customer.SelectedValue.ToString();
                                                    string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                    string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                    string msg1 = objcode.InsertpaymentVoucherDetails(rid, invid, customerid, desc, amt);
                                                }

                                               // objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Save");
                                                MessageBox.Show("Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                sum = 0;
                                                dgv_Receipt.Rows.Clear();
                                                vouchernoload();
                                                clear();
                                                cmb_Customer.SelectedValue = 0;

                                                lbldot.Text = 0.ToString();
                                            }


                                        }
                                        else
                                        {
                                            MessageBox.Show("Enter Valid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    ///////////////////////////////////////////////
                                }
                            }
                            else
                            {
                                if (txt_Amount.Text == "0")
                                {
                                    MessageBox.Show("Please Add The Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else if (cmb_Paymentmode.Text == "--Select One--")
                                {
                                    MessageBox.Show("Please Select PaymentMode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        if (Rb_GoodsReceipt.Checked == false && Rb_OldPayable.Checked == true)
                        {
                            if (txt_Amount.Text != "0" && cmb_Paymentmode.Text != "--Select One--")
                            {
                                if (rb_other.Checked == true)
                                {
                                    if (txtother.Text != string.Empty && txt_Amount.Text != "0" && cmb_Paymentmode.Text != string.Empty)
                                    {

                                        if (cmb_Paymentmode.Text == "Cheque")
                                        {
                                            if (txtCheque.Text != string.Empty && cmbBank.SelectedIndex > 0)
                                            {
                                                int status;
                                                if (cbox_check.Checked == true)
                                                    status = 1;
                                                else
                                                    status = 0;
                                                string msg = objcode.InsertpaymentVoucherOldPayable(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                objcode.InsertChequeDetails(txt_Voucherno.Text, "9", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());

                                                //insert dealer account details
                                                objcode.InsertDealerAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "2", "9", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Old Payable Refnum-" + msg);
                                               // objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Save");
                                                MessageBox.Show("Insertion Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                VoucherNoLoadOldPay();
                                                clear();
                                            }
                                            else
                                            {
                                                if (txtCheque.Text == string.Empty)
                                                {
                                                    MessageBox.Show("Please Enter Check No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    txtCheque.Focus();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please Select Bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    cmbBank.Focus();
                                                }
                                            }
                                        }
                                        else
                                        {
                                            string msg = objcode.InsertpaymentVoucherOldPayable(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                            //insert dealer account details
                                            objcode.InsertDealerAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "2", "9", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Old Payable Refnum-" + msg);
                                           // objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Save");
                                            MessageBox.Show("Insertion Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            VoucherNoLoadOldPay();
                                            clear();

                                        }
                                    }
                                    else
                                    {
                                        if (txtother.Text == string.Empty)
                                        {
                                            MessageBox.Show("Please Enter Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            txtother.Focus();
                                        }
                                        else if (cmb_Paymentmode.Text == string.Empty)
                                        {
                                            MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cmb_Paymentmode.Focus();
                                        }
                                        else if (txt_Amount.Text == "0")
                                        {
                                            MessageBox.Show("Please Enter Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            txt_Amount.Focus();
                                        }
                                    }

                                }
                                else
                                {
                                    if (dgv_Receipt.Rows.Count != 0)
                                    {

                                        sum = 0;
                                        //no = 0;
                                        tot = 0;
                                        for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                        {
                                            double sumrows = Convert.ToDouble(dgv_Receipt.Rows[i].Cells[3].Value.ToString());
                                            sum = sum + sumrows;
                                        }
                                        if (Convert.ToDouble(txt_Amount.Text) == sum)
                                        {
                                            if (cmb_Paymentmode.Text == "Cheque")
                                            {
                                                if (txtCheque.Text != string.Empty && cmbBank.SelectedIndex > 0)
                                                {
                                                    int status;
                                                    if (cbox_check.Checked == true)
                                                        status = 1;
                                                    else
                                                        status = 0;

                                                    string msg = objcode.InsertpaymentVoucherOldPayable(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                    //insert check details
                                                    objcode.InsertChequeDetails(txt_Voucherno.Text, "9", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());
                                                    //insert dealer account details
                                                    objcode.InsertDealerAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "2", "9", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Old Payable Refnum-" + msg);

                                                    //insert into payment details
                                                    //string rid = objcode.selectidpayment();
                                                    for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                    {
                                                        string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                        string customerid = cmb_Customer.SelectedValue.ToString();
                                                        string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                        string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                        string msg1 = objcode.InsertpaymentVoucherDetailsOldPayment(msg, invid, customerid, desc, amt);
                                                    }

                                                   // objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Save");

                                                    MessageBox.Show("Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    sum = 0;
                                                    dgv_Receipt.Rows.Clear();
                                                    VoucherNoLoadOldPay();
                                                    clear();
                                                    cmb_Customer.Text = "--Select One--";

                                                    lbldot.Text = 0.ToString();

                                                }
                                                else
                                                {
                                                    if (txtCheque.Text == string.Empty)
                                                    {
                                                        MessageBox.Show("Please Enter Check No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        txtCheque.Focus();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please Select Bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        cmbBank.Focus();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string msg = objcode.InsertpaymentVoucherOldPayable(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                                //insert dealer account details
                                                objcode.InsertDealerAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "2", "9", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Old Payable Refnum-" + msg);

                                                //insert payment voucher details
                                                //string rid = objcode.selectidpayment();
                                                for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                {
                                                    string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                    string customerid = cmb_Customer.SelectedValue.ToString();
                                                    string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                    string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                    string msg1 = objcode.InsertpaymentVoucherDetailsOldPayment(msg, invid, customerid, desc, amt);
                                                }
                                               // objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Save");

                                                MessageBox.Show("Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                sum = 0;
                                                dgv_Receipt.Rows.Clear();
                                                VoucherNoLoadOldPay();
                                                clear();
                                                cmb_Customer.SelectedValue = 0;

                                                lbldot.Text = 0.ToString();
                                            }


                                        }
                                        else
                                        {
                                            MessageBox.Show("Enter Valid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    ///////////////////////////////////////////////
                                }
                            }
                            else
                            {
                                if (txt_Amount.Text == "0")
                                {
                                    MessageBox.Show("Please Add The Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else if (cmb_Paymentmode.Text == "--Select One--")
                                {
                                    MessageBox.Show("Please Select PaymentMode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("You Do Not Have The Permission To Save Payment Voucher", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (DeleteStatus == "1")
                    {
                        if (Rb_GoodsReceipt.Checked == true)
                        {
                            // delete payment master, details
                            string mg = objcode.deletepayment(textBox1.Text);

                            //delete dealer details
                            objcode.DeleteDealerAccDetailsByPV(Convert.ToInt32(textBox1.Text));

                            //delete from check details
                            if (CheckId != 0)
                            {
                                objcode.DeleteCheckDetailsByPV(CheckId);
                            }
                            //objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Delete");
                            MessageBox.Show(mg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_update.Enabled = false;
                            btndelete.Enabled = false;
                            clear();
                            dgv_Receipt.Rows.Clear();
                            cmb_invoice.Text = "--Select One--";
                            cmb_Customer.Text = "--Select One--";
                            txt_amount1.Text = "0";
                            txtdescription1.Text = "";
                            vouchernoload();
                            btn_Save1.Enabled = true;
                            btn_remove.Enabled = true;
                        }

                        //old pay
                        if (Rb_GoodsReceipt.Checked == false && Rb_OldPayable.Checked == true)
                        {
                            // delete payment master, details
                            string mg = objcode.DeletePaymentOldPay(textBox1.Text);

                            //delete dealer details
                            objcode.DeleteDealerAccDetailsByPVOldPay(Convert.ToInt32(textBox1.Text));

                            //delete from check details
                            if (CheckId != 0)
                            {
                                objcode.DeleteCheckDetailsByPVOldPay(CheckId);
                            }
                            //objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Delete");
                            MessageBox.Show(mg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_update.Enabled = false;
                            btndelete.Enabled = false;
                            clear();
                            dgv_Receipt.Rows.Clear();
                            cmb_invoice.Text = "--Select One--";
                            cmb_Customer.Text = "--Select One--";
                            txt_amount1.Text = "0";
                            txtdescription1.Text = "";
                            vouchernoload();
                            btn_Save1.Enabled = true;
                            btn_remove.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You Do Not Have The Permission To Delete Payment Voucher", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    PaymentVoucherSearch ps = new PaymentVoucherSearch();
                    ps.ShowDialog();
                    if (ps.ChkSer != 0)
                    {
                        if (ps.CHkGR == 1)
                        {
                            //Goods Receipt
                            Rb_GoodsReceipt.Checked = true;


                            rid = ps.rid;

                            btn_remove.Enabled = false;
                            //rb_customer.Checked = true;

                            DataTable DtPvm = objcode.GetPaymentVoucherMaster(Convert.ToInt32(rid));
                            DataTable dt = objcode.getReceiptDetailspayment(rid);


                            int custid = Convert.ToInt32(DtPvm.Rows[0]["DealerID"]);
                            string custname = DtPvm.Rows[0]["OtherName"].ToString();
                            string amt = DtPvm.Rows[0]["Amount"].ToString();
                            string paymode = DtPvm.Rows[0]["Paymode"].ToString();
                            string vno1 = DtPvm.Rows[0]["VoucherNo"].ToString();

                            if (custid == 0)
                            {
                                dealid = "0";
                                rb_other.Checked = true;
                                txtother.Text = custname;
                                txt_Amount.Text = amt;


                                txtother.Enabled = false;

                            }
                            else
                            {
                                rb_customer.Checked = true;
                                ///no = 1;
                                dealid = custid.ToString();
                                txt_Amount.Enabled = false;
                                cmb_Customer.SelectedValue = custid;
                            }

                            textBox1.Text = rid.ToString();



                            dgv_Receipt.Rows.Clear();
                            int i = 0;
                            for (i = 0; i < dt.Rows.Count; i++)
                            {
                                dgv_Receipt.Rows.Add();
                                dgv_Receipt[0, i].Value = dt.Rows[i]["Id"].ToString();
                                dgv_Receipt[1, i].Value = dt.Rows[i]["Id"].ToString();
                                dgv_Receipt[2, i].Value = dt.Rows[i]["description"].ToString();
                                dgv_Receipt[3, i].Value = dt.Rows[i]["amount"].ToString();
                              //  dgv_Receipt[4, i].Value = 0;

                            }

                            chk = 1;

                            txt_Voucherno.Text = DtPvm.Rows[0]["VoucherNo"].ToString();
                            txt_Amount.Text = DtPvm.Rows[0]["Amount"].ToString();
                            txt_Description.Text = DtPvm.Rows[0]["description"].ToString();

                            if (paymode == "Cash")
                                cmb_Paymentmode.Text = "Cash";
                            else
                            {
                                cmb_Paymentmode.Text = "Cheque";


                                DataTable dt1 = objcode.GetCheckForPaymentVoucher(Convert.ToInt32(vno1));
                                CheckId = Convert.ToInt32(dt1.Rows[0]["Id"]);
                                txtCheque.Text = dt1.Rows[0]["ChequeNo"].ToString();
                                cmbBank.SelectedValue = Convert.ToInt32(dt1.Rows[0]["Bank"]);
                                dtChequeDate.Value = Convert.ToDateTime(dt1.Rows[0]["ChequeDate"]);
                                if (Convert.ToInt32(dt1.Rows[0]["Status"]) == 1)
                                    cbox_check.Checked = true;
                                else
                                    cbox_check.Checked = false;


                                panelbank.Enabled = true;
                            }

                            dtvoucher.Value = Convert.ToDateTime(DtPvm.Rows[0]["VoucherDate"]);
                            // dgv_Receipt.DataSource = ds.Tables[0];
                            panelnew.Visible = false;
                            panelold.Visible = true;
                            btnadd.Visible = true;
                            //btn_remove.Visible = true;
                            btn_Save1.Enabled = false;
                            btn_update.Enabled = true;
                            btndelete.Enabled = true;

                            // g = 1;
                        }
                        //close Goods Receipt

                        if (ps.CHkGR == 2)
                        {
                            //Old Payment
                            Rb_OldPayable.Checked = true;
                            rid = ps.rid;

                            btn_remove.Enabled = false;
                            rb_customer.Checked = true;

                            DataTable DtPvm = objcode.GetPaymentVoucherMasterOldPay(Convert.ToInt32(rid));
                            DataTable dt = objcode.GetReceiptDetailsPaymentOldPay(rid);
                            textBox1.Text = rid.ToString();

                            dgv_Receipt.Rows.Clear();
                            int i = 0;
                            for (i = 0; i < dt.Rows.Count; i++)
                            {
                                dgv_Receipt.Rows.Add();
                                dgv_Receipt[0, i].Value = dt.Rows[i]["Id"].ToString();
                                dgv_Receipt[1, i].Value = dt.Rows[i]["RefNo"].ToString();
                                dgv_Receipt[2, i].Value = dt.Rows[i]["description"].ToString();
                                dgv_Receipt[3, i].Value = dt.Rows[i]["amount"].ToString();
                                //dgv_Receipt[4, i].Value = 0;
                            }

                            chk = 1;

                            txt_Voucherno.Text = DtPvm.Rows[0]["VoucherNo"].ToString();
                            txt_Amount.Text = DtPvm.Rows[0]["Amount"].ToString();

                            string paymode = DtPvm.Rows[0]["Paymode"].ToString();
                            string vno1 = DtPvm.Rows[0]["VoucherNo"].ToString();
                            int custid = Convert.ToInt32(DtPvm.Rows[0]["DealerID"]);
                            string custname = DtPvm.Rows[0]["OtherName"].ToString();
                            string amt = DtPvm.Rows[0]["Amount"].ToString();

                            if (custid == 0)
                            {
                                dealid = "0";
                                rb_other.Checked = true;
                                txtother.Text = custname;
                                txt_Amount.Text = amt;

                                txtother.Enabled = false;

                            }
                            else
                            {
                                //no = 1;
                                dealid = custid.ToString();
                                txt_Amount.Enabled = false;
                                cmb_Customer.SelectedValue = custid;
                            }

                            txt_Description.Text = DtPvm.Rows[0]["description"].ToString();

                            if (paymode == "Cash")
                                cmb_Paymentmode.Text = "Cash";
                            else
                            {
                                cmb_Paymentmode.Text = "Cheque";


                                DataTable dt1 = objcode.GetCheckForPaymentVoucherOldPay(Convert.ToInt32(vno1));
                                CheckId = Convert.ToInt32(dt1.Rows[0]["Id"]);
                                txtCheque.Text = dt1.Rows[0]["ChequeNo"].ToString();
                                cmbBank.SelectedValue = Convert.ToInt32(dt1.Rows[0]["Bank"]);
                                dtChequeDate.Value = Convert.ToDateTime(dt1.Rows[0]["ChequeDate"]);
                                if (Convert.ToInt32(dt1.Rows[0]["Status"]) == 1)
                                    cbox_check.Checked = true;
                                else
                                    cbox_check.Checked = false;


                                panelbank.Enabled = true;
                            }

                            dtvoucher.Value = Convert.ToDateTime(DtPvm.Rows[0]["VoucherDate"]);
                            // dgv_Receipt.DataSource = ds.Tables[0];
                            panelnew.Visible = false;
                            panelold.Visible = true;
                            btnadd.Visible = true;
                            //btn_remove.Visible = true;
                            btn_Save1.Enabled = false;
                            btn_update.Enabled = true;
                            btndelete.Enabled = true;

                            // g = 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            PaymentVoucher_Load(this, e);
            clear();
        }

        private void txt_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                cmb_Customer.Text = "--Select One--";
                if (dgv_Receipt.RowCount > 0)
                {
                    int rindex = dgv_Receipt.CurrentCell.RowIndex;
                    if (dgv_Receipt.Rows[rindex].Cells[3].Value != null)
                    {
                        double amt = Convert.ToDouble(dgv_Receipt.Rows[rindex].Cells[3].Value);
                        double netamt = Convert.ToDouble(txt_Amount.Text);
                        double final = netamt - amt;
                        txt_Amount.Text = final.ToString();
                        dgv_Receipt.Rows.RemoveAt(rindex);
                    }
                }
                else
                    MessageBox.Show("Please Add The Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    //Goods Receipt
                    if (SaveStatus == "1")
                    {
                        if (Rb_GoodsReceipt.Checked == true)
                        {
                            if (Convert.ToInt32(rid) == 0)
                            {
                                //save
                                if (txt_Amount.Text != "" && cmb_Paymentmode.Text != "--Select One--")
                                {
                                    if (rb_other.Checked == true)
                                    {
                                        if (txtother.Text != string.Empty && txt_Amount.Text != string.Empty && cmb_Paymentmode.Text != string.Empty)
                                        {

                                            if (cmb_Paymentmode.Text == "Cheque")
                                            {
                                                if (txtCheque.Text != string.Empty && cmbBank.SelectedIndex > 0)
                                                {
                                                    int status;
                                                    if (cbox_check.Checked == true)
                                                        status = 1;
                                                    else
                                                        status = 0;
                                                    string msg = objcode.InsertpaymentVoucher(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                    objcode.InsertChequeDetails(txt_Voucherno.Text, "3", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());

                                                    //insert dealer account details
                                                    objcode.InsertDealerAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "2", "5", msg, "Rs " + txt_Amount.Text + " is Debited by payment voucher Refnum-" + msg);
                                                   // objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Save");
                                                    //MessageBox.Show("Insertion Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    FrmPrintPaymentVoucherOther PPV = new FrmPrintPaymentVoucherOther(Convert.ToInt32(msg));
                                                    PPV.ShowDialog();

                                                    vouchernoload();
                                                    clear();
                                                }
                                                else
                                                {
                                                    if (txtCheque.Text == string.Empty)
                                                    {
                                                        MessageBox.Show("Please Enter Check No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        txtCheque.Focus();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please Select Bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        cmbBank.Focus();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string msg = objcode.InsertpaymentVoucher(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                                //insert dealer account details
                                                objcode.InsertDealerAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "2", "5", msg, "Rs " + txt_Amount.Text + " is Debited by payment voucher Refnum-" + msg);
                                                //objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Save");
                                                //MessageBox.Show("Insertion Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                FrmPrintPaymentVoucherOther PPV = new FrmPrintPaymentVoucherOther(Convert.ToInt32(msg));
                                                PPV.ShowDialog();

                                                vouchernoload();
                                                clear();

                                            }
                                        }
                                        else
                                        {
                                            if (txtother.Text == string.Empty)
                                            {
                                                MessageBox.Show("Please Enter Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                txtother.Focus();
                                            }
                                            else if (cmb_Paymentmode.Text == string.Empty)
                                            {
                                                MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                cmb_Paymentmode.Focus();
                                            }
                                            else if (txt_Amount.Text == "0")
                                            {
                                                MessageBox.Show("Please Enter Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                txt_Amount.Focus();
                                            }
                                        }

                                    }
                                    else
                                    {
                                        if (dgv_Receipt.Rows.Count != 0)
                                        {

                                            sum = 0;
                                            //no = 0;
                                            tot = 0;
                                            for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                            {
                                                double sumrows = Convert.ToDouble(dgv_Receipt.Rows[i].Cells[3].Value.ToString());
                                                sum = sum + sumrows;
                                            }
                                            if (Convert.ToDouble(txt_Amount.Text) == sum)
                                            {
                                                if (cmb_Paymentmode.Text == "Cheque")
                                                {
                                                    if (txtCheque.Text != string.Empty && cmbBank.SelectedIndex > 0)
                                                    {
                                                        int status;
                                                        if (cbox_check.Checked == true)
                                                            status = 1;
                                                        else
                                                            status = 0;

                                                        string msg = objcode.InsertpaymentVoucher(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                        //insert check details
                                                        objcode.InsertChequeDetails(txt_Voucherno.Text, "3", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());
                                                        //insert dealer account details
                                                        objcode.InsertDealerAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "2", "5", msg, "Rs " + txt_Amount.Text + " is Debited by payment voucher Refnum-" + msg);

                                                        //insert into payment details
                                                        string rid1 = objcode.selectidpayment();
                                                        for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                        {
                                                            string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                            string customerid = cmb_Customer.SelectedValue.ToString();
                                                            string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                            string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                            string msg1 = objcode.InsertpaymentVoucherDetails(rid1, invid, customerid, desc, amt);
                                                        }
                                                       // objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Save");
                                                        //MessageBox.Show("Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        FrmPrintPaymentVoucher PPV = new FrmPrintPaymentVoucher(Convert.ToInt32(msg));
                                                        PPV.ShowDialog();

                                                        sum = 0;
                                                        dgv_Receipt.Rows.Clear();
                                                        vouchernoload();
                                                        clear();
                                                        cmb_Customer.Text = "--Select One--";

                                                        lbldot.Text = 0.ToString();

                                                    }
                                                    else
                                                    {
                                                        if (txtCheque.Text == string.Empty)
                                                        {
                                                            MessageBox.Show("Please Enter Check No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            txtCheque.Focus();
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Please Select Bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            cmbBank.Focus();
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    string msg = objcode.InsertpaymentVoucher(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                                    //insert dealer account details
                                                    objcode.InsertDealerAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "2", "5", msg, "Rs " + txt_Amount.Text + " is Debited by payment voucher Refnum-" + msg);

                                                    //insert payment voucher details
                                                    string rid1 = objcode.selectidpayment();
                                                    for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                    {
                                                        string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                        string customerid = cmb_Customer.SelectedValue.ToString();
                                                        string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                        string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                        string msg1 = objcode.InsertpaymentVoucherDetails(rid1, invid, customerid, desc, amt);
                                                    }

                                                   // objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Save");
                                                    //MessageBox.Show("Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    FrmPrintPaymentVoucher PPV = new FrmPrintPaymentVoucher(Convert.ToInt32(msg));
                                                    PPV.ShowDialog();

                                                    sum = 0;
                                                    dgv_Receipt.Rows.Clear();
                                                    vouchernoload();
                                                    clear();
                                                    cmb_Customer.SelectedValue = 0;

                                                    lbldot.Text = 0.ToString();
                                                }


                                            }
                                            else
                                            {
                                                MessageBox.Show("Enter Valid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                        }
                                        ///////////////////////////////////////////////
                                    }
                                }
                                else
                                {
                                    if (txt_Amount.Text == "0")
                                    {
                                        MessageBox.Show("Please Add The Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else if (cmb_Paymentmode.Text == "--Select One--")
                                    {
                                        MessageBox.Show("Please Select PaymentMode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            else
                            {
                                //update
                                //other cusstomer
                                if (cmb_Paymentmode.Text != "--Select One--")
                                {
                                    if (rb_other.Checked == true)
                                    {



                                        if (cmb_Paymentmode.Text == "Cheque")
                                        {
                                            if (txtCheque.Text != string.Empty && Convert.ToInt32(cmbBank.SelectedValue) != 0)
                                            {
                                                // delete payment master, details
                                                string mg = objcode.deletepayment(textBox1.Text);


                                                //delete dealer details 
                                                objcode.DeleteDealerAccDetailsByPV(Convert.ToInt32(textBox1.Text));

                                                //delete from check details
                                                if (CheckId != 0)
                                                {
                                                    objcode.DeleteCheckDetailsByPV(CheckId);
                                                }

                                                int status;
                                                if (cbox_check.Checked == true)
                                                    status = 1;
                                                else
                                                    status = 0;
                                                string msg = objcode.InsertpaymentVoucher(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                //insert check details
                                                objcode.InsertChequeDetails(txt_Voucherno.Text, "3", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());

                                                //insert dealer account details
                                                objcode.InsertDealerAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "2", "5", msg, "Rs " + txt_Amount.Text + " is Debited by payment voucher Refnum-" + msg);
                                               // objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Save");
                                                //MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                FrmPrintPaymentVoucherOther PPV = new FrmPrintPaymentVoucherOther(Convert.ToInt32(msg));
                                                PPV.ShowDialog();

                                                vouchernoload();
                                                clear();
                                            }
                                            else
                                            {
                                                if (txtCheque.Text == string.Empty)
                                                {
                                                    MessageBox.Show("Please Enter Check No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    txtCheque.Focus();
                                                }
                                                else if (Convert.ToInt32(cmbBank.SelectedValue) == 0)
                                                {
                                                    MessageBox.Show("Please Select Bank.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    txtCheque.Focus();
                                                }

                                            }
                                        }
                                        else
                                        {
                                            // delete payment master, details
                                            string mg = objcode.deletepayment(textBox1.Text);


                                            //delete dealer details 
                                            objcode.DeleteDealerAccDetailsByPV(Convert.ToInt32(textBox1.Text));

                                            //delete from check details
                                            if (CheckId != 0)
                                            {
                                                objcode.DeleteCheckDetailsByPV(CheckId);
                                            }
                                            string msg = objcode.InsertpaymentVoucher(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                            //insert dealer account details
                                            objcode.InsertDealerAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "2", "5", msg, "Rs " + txt_Amount.Text + " is Debited by payment voucher Refnum-" + msg);
                                           // objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Save");
                                            //MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            FrmPrintPaymentVoucherOther PPV = new FrmPrintPaymentVoucherOther(Convert.ToInt32(msg));
                                            PPV.ShowDialog();

                                            vouchernoload();
                                            clear();

                                        }

                                    }

                                        //normal customer
                                    else
                                    {
                                        if (dgv_Receipt.Rows.Count != 0)
                                        {
                                            // g = 0;
                                            sum = 0;
                                            //no = 0;
                                            tot = 0;
                                            for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                            {
                                                double sumrows = Convert.ToDouble(dgv_Receipt.Rows[i].Cells[3].Value.ToString());
                                                sum = sum + sumrows;
                                            }


                                            if (Convert.ToDouble(txt_Amount.Text) == sum)
                                            {
                                                if (cmb_Paymentmode.Text == "Cheque")
                                                {
                                                    if (txtCheque.Text != string.Empty && Convert.ToInt32(cmbBank.SelectedValue) != 0)
                                                    {
                                                        // delete payment master, details
                                                        string mg = objcode.deletepayment(textBox1.Text);


                                                        //delete dealer details 
                                                        objcode.DeleteDealerAccDetailsByPV(Convert.ToInt32(textBox1.Text));

                                                        //delete from check details
                                                        if (CheckId != 0)
                                                        {
                                                            objcode.DeleteCheckDetailsByPV(CheckId);
                                                        }

                                                        int status;
                                                        if (cbox_check.Checked == true)
                                                            status = 1;
                                                        else
                                                            status = 0;

                                                        string msg = objcode.InsertpaymentVoucher(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                        //insert check details
                                                        objcode.InsertChequeDetails(txt_Voucherno.Text, "3", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());
                                                        //insert dealer account details
                                                        objcode.InsertDealerAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "2", "5", msg, "Rs " + txt_Amount.Text + " is Debited by SaleReturn Refnum-" + msg);


                                                        string rid1 = objcode.selectidpayment();
                                                        for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                        {
                                                            string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                            string customerid = cmb_Customer.SelectedValue.ToString();
                                                            string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                            string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                            string msg1 = objcode.InsertpaymentVoucherDetails(rid1, invid, customerid, desc, amt);
                                                        }


                                                        sum = 0;
                                                        dgv_Receipt.Rows.Clear();

                                                        clear();

                                                        btn_update.Enabled = false;
                                                        btndelete.Enabled = false;
                                                        vouchernoload();
                                                        btn_Save1.Enabled = true;
                                                        btn_remove.Enabled = true;
                                                       // objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Save");
                                                        //MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        FrmPrintPaymentVoucher PPV = new FrmPrintPaymentVoucher(Convert.ToInt32(msg));
                                                        PPV.ShowDialog();

                                                    }

                                                    else
                                                    {
                                                        if (txtCheque.Text == string.Empty)
                                                        {
                                                            MessageBox.Show("Please Enter Check No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            txtCheque.Focus();
                                                        }
                                                        else if (Convert.ToInt32(cmbBank.SelectedValue) == 0)
                                                        {
                                                            MessageBox.Show("Please Select Bank.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            txtCheque.Focus();
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    // delete payment master, details
                                                    string mg = objcode.deletepayment(textBox1.Text);


                                                    //delete dealer details 
                                                    objcode.DeleteDealerAccDetailsByPV(Convert.ToInt32(textBox1.Text));

                                                    //delete from check details
                                                    if (CheckId != 0)
                                                    {
                                                        objcode.DeleteCheckDetailsByPV(CheckId);
                                                    }

                                                    string msg = objcode.InsertpaymentVoucher(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                                    //insert dealer account details
                                                    objcode.InsertDealerAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "2", "5", msg, "Rs " + txt_Amount.Text + " is Debited by payment voucher Refnum-" + msg);

                                                    //insertion into payment details
                                                    string rid1 = objcode.selectidpayment();
                                                    for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                    {
                                                        string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                        string customerid = cmb_Customer.SelectedValue.ToString();
                                                        string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                        string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                        string msg1 = objcode.InsertpaymentVoucherDetails(rid1, invid, customerid, desc, amt);
                                                    }
                                                   // objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Save");
                                                    //MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    FrmPrintPaymentVoucher PPV = new FrmPrintPaymentVoucher(Convert.ToInt32(msg));
                                                    PPV.ShowDialog();

                                                    sum = 0;
                                                    dgv_Receipt.Rows.Clear();

                                                    clear();
                                                    btn_update.Enabled = false;
                                                    btndelete.Enabled = false;
                                                    vouchernoload();
                                                    btn_Save1.Enabled = true;
                                                    btn_remove.Enabled = true;

                                                }


                                            }
                                            else
                                            {
                                                MessageBox.Show("Enter Valid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("Please Add The Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                }
                                else
                                {
                                    if (cmb_Paymentmode.Text == "--Select One--")
                                    {
                                        MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }



                        }

                        //Old Payable

                        if (Rb_GoodsReceipt.Checked == false && Rb_OldPayable.Checked == true)
                        {
                            if (Convert.ToInt32(rid) == 0)
                            {
                                if (txt_Amount.Text != "" && cmb_Paymentmode.Text != "--Select One--")
                                {
                                    if (rb_other.Checked == true)
                                    {
                                        if (txtother.Text != string.Empty && txt_Amount.Text != string.Empty && cmb_Paymentmode.Text != string.Empty)
                                        {

                                            if (cmb_Paymentmode.Text == "Cheque")
                                            {
                                                if (txtCheque.Text != string.Empty && cmbBank.SelectedIndex > 0)
                                                {
                                                    int status;
                                                    if (cbox_check.Checked == true)
                                                        status = 1;
                                                    else
                                                        status = 0;
                                                    string msg = objcode.InsertpaymentVoucherOldPayable(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                    objcode.InsertChequeDetails(txt_Voucherno.Text, "9", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());

                                                    //insert dealer account details
                                                    objcode.InsertDealerAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "2", "9", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Old Payable Refnum-" + msg);
                                                  //  objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Save");
                                                    //MessageBox.Show("Insertion Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    FrmPrintPaymentVoucherOldPayOther PPV = new FrmPrintPaymentVoucherOldPayOther(Convert.ToInt32(msg));
                                                    PPV.ShowDialog();

                                                    VoucherNoLoadOldPay();
                                                    clear();
                                                }
                                                else
                                                {
                                                    if (txtCheque.Text == string.Empty)
                                                    {
                                                        MessageBox.Show("Please Enter Check No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        txtCheque.Focus();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please Select Bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        cmbBank.Focus();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string msg = objcode.InsertpaymentVoucherOldPayable(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                                //insert dealer account details
                                                objcode.InsertDealerAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "2", "9", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Old Payable Refnum-" + msg);
                                                //objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Save");
                                                //MessageBox.Show("Insertion Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                FrmPrintPaymentVoucherOldPayOther PPV = new FrmPrintPaymentVoucherOldPayOther(Convert.ToInt32(msg));
                                                PPV.ShowDialog();

                                                VoucherNoLoadOldPay();
                                                clear();

                                            }
                                        }
                                        else
                                        {
                                            if (txtother.Text == string.Empty)
                                            {
                                                MessageBox.Show("Please Enter Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                txtother.Focus();
                                            }
                                            else if (cmb_Paymentmode.Text == string.Empty)
                                            {
                                                MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                cmb_Paymentmode.Focus();
                                            }
                                            else if (txt_Amount.Text == "0")
                                            {
                                                MessageBox.Show("Please Enter Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                txt_Amount.Focus();
                                            }
                                        }

                                    }
                                    else
                                    {
                                        if (dgv_Receipt.Rows.Count != 0)
                                        {

                                            sum = 0;
                                            //no = 0;
                                            tot = 0;
                                            for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                            {
                                                double sumrows = Convert.ToDouble(dgv_Receipt.Rows[i].Cells[3].Value.ToString());
                                                sum = sum + sumrows;
                                            }
                                            if (Convert.ToDouble(txt_Amount.Text) == sum)
                                            {
                                                if (cmb_Paymentmode.Text == "Cheque")
                                                {
                                                    if (txtCheque.Text != string.Empty && cmbBank.SelectedIndex > 0)
                                                    {
                                                        int status;
                                                        if (cbox_check.Checked == true)
                                                            status = 1;
                                                        else
                                                            status = 0;

                                                        string msg = objcode.InsertpaymentVoucherOldPayable(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                        //insert check details
                                                        objcode.InsertChequeDetails(txt_Voucherno.Text, "9", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());
                                                        //insert dealer account details
                                                        objcode.InsertDealerAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "2", "9", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Old Payable Refnum-" + msg);

                                                        //insert into payment details
                                                        //string rid = objcode.selectidpayment();
                                                        for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                        {
                                                            string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                            string customerid = cmb_Customer.SelectedValue.ToString();
                                                            string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                            string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                            string msg1 = objcode.InsertpaymentVoucherDetailsOldPayment(msg, invid, customerid, desc, amt);
                                                        }
                                                        //objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Save");
                                                        FrmPrintPaymentVoucherOldPay PPV = new FrmPrintPaymentVoucherOldPay(Convert.ToInt32(msg));
                                                        PPV.ShowDialog();

                                                        //MessageBox.Show("Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        sum = 0;
                                                        dgv_Receipt.Rows.Clear();
                                                        VoucherNoLoadOldPay();
                                                        clear();
                                                        cmb_Customer.Text = "--Select One--";

                                                        lbldot.Text = 0.ToString();

                                                    }
                                                    else
                                                    {
                                                        if (txtCheque.Text == string.Empty)
                                                        {
                                                            MessageBox.Show("Please Enter Check No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            txtCheque.Focus();
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Please Select Bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            cmbBank.Focus();
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    string msg = objcode.InsertpaymentVoucherOldPayable(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                                    //insert dealer account details
                                                    objcode.InsertDealerAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "2", "9", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Old Payable Refnum-" + msg);

                                                    //insert payment voucher details
                                                    //string rid = objcode.selectidpayment();
                                                    for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                    {
                                                        string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                        string customerid = cmb_Customer.SelectedValue.ToString();
                                                        string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                        string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                        string msg1 = objcode.InsertpaymentVoucherDetailsOldPayment(msg, invid, customerid, desc, amt);
                                                    }

                                                    FrmPrintPaymentVoucherOldPay PPV = new FrmPrintPaymentVoucherOldPay(Convert.ToInt32(msg));
                                                    PPV.ShowDialog();
                                                   // objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Save");
                                                    //MessageBox.Show("Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                    sum = 0;
                                                    dgv_Receipt.Rows.Clear();
                                                    VoucherNoLoadOldPay();
                                                    clear();
                                                    cmb_Customer.SelectedValue = 0;

                                                    lbldot.Text = 0.ToString();
                                                }


                                            }
                                            else
                                            {
                                                MessageBox.Show("Enter Valid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                        }
                                        ///////////////////////////////////////////////
                                    }
                                }
                                else
                                {
                                    if (txt_Amount.Text == "0")
                                    {
                                        MessageBox.Show("Please Add The Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else if (cmb_Paymentmode.Text == "--Select One--")
                                    {
                                        MessageBox.Show("Please Select PaymentMode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                /////////////////////
                            }
                            else
                            {
                                //Update

                                //other cusstomer
                                if (cmb_Paymentmode.Text != "--Select One--")
                                {
                                    if (rb_other.Checked == true)
                                    {



                                        if (cmb_Paymentmode.Text == "Cheque")
                                        {
                                            if (txtCheque.Text != string.Empty && Convert.ToInt32(cmbBank.SelectedValue) != 0)
                                            {
                                                // delete payment master, details
                                                string mg = objcode.DeletePaymentOldPay(textBox1.Text);


                                                //delete dealer details 
                                                objcode.DeleteDealerAccDetailsByPVOldPay(Convert.ToInt32(textBox1.Text));

                                                //delete from check details
                                                if (CheckId != 0)
                                                {
                                                    objcode.DeleteCheckDetailsByPVOldPay(CheckId);
                                                }

                                                int status;
                                                if (cbox_check.Checked == true)
                                                    status = 1;
                                                else
                                                    status = 0;
                                                string msg = objcode.InsertpaymentVoucherOldPayable(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                //insert check details
                                                objcode.InsertChequeDetails(txt_Voucherno.Text, "9", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());

                                                //insert dealer account details
                                                objcode.InsertDealerAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "2", "9", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Old Payable Refnum-" + msg);
                                               //objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Update");
                                                //MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                FrmPrintPaymentVoucherOldPayOther PPV = new FrmPrintPaymentVoucherOldPayOther(Convert.ToInt32(msg));
                                                PPV.ShowDialog();

                                                vouchernoload();
                                                clear();
                                            }
                                            else
                                            {
                                                if (txtCheque.Text == string.Empty)
                                                {
                                                    MessageBox.Show("Please Enter Check No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    txtCheque.Focus();
                                                }
                                                else if (Convert.ToInt32(cmbBank.SelectedValue) == 0)
                                                {
                                                    MessageBox.Show("Please Select Bank.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    txtCheque.Focus();
                                                }

                                            }
                                        }
                                        else
                                        {
                                            // delete payment master, details
                                            string mg = objcode.DeletePaymentOldPay(textBox1.Text);


                                            //delete dealer details 
                                            objcode.DeleteDealerAccDetailsByPVOldPay(Convert.ToInt32(textBox1.Text));

                                            //delete from check details
                                            if (CheckId != 0)
                                            {
                                                objcode.DeleteCheckDetailsByPVOldPay(CheckId);
                                            }
                                            string msg = objcode.InsertpaymentVoucherOldPayable(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                            //insert dealer account details
                                            objcode.InsertDealerAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "2", "9", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Old Payable Refnum-" + msg);
                                            //objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Update");
                                            //MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            FrmPrintPaymentVoucherOldPayOther PPV = new FrmPrintPaymentVoucherOldPayOther(Convert.ToInt32(msg));
                                            PPV.ShowDialog();

                                            vouchernoload();
                                            clear();

                                        }

                                    }

                                        //normal customer
                                    else
                                    {
                                        if (dgv_Receipt.Rows.Count != 0)
                                        {
                                            // g = 0;
                                            sum = 0;
                                            //no = 0;
                                            tot = 0;
                                            for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                            {
                                                double sumrows = Convert.ToDouble(dgv_Receipt.Rows[i].Cells[3].Value.ToString());
                                                sum = sum + sumrows;
                                            }


                                            if (Convert.ToDouble(txt_Amount.Text) == sum)
                                            {
                                                if (cmb_Paymentmode.Text == "Cheque")
                                                {
                                                    if (txtCheque.Text != string.Empty && Convert.ToInt32(cmbBank.SelectedValue) != 0)
                                                    {
                                                        // delete payment master, details
                                                        string mg = objcode.DeletePaymentOldPay(textBox1.Text);


                                                        //delete dealer details 
                                                        objcode.DeleteDealerAccDetailsByPVOldPay(Convert.ToInt32(textBox1.Text));

                                                        //delete from check details
                                                        if (CheckId != 0)
                                                        {
                                                            objcode.DeleteCheckDetailsByPVOldPay(CheckId);
                                                        }

                                                        int status;
                                                        if (cbox_check.Checked == true)
                                                            status = 1;
                                                        else
                                                            status = 0;

                                                        string msg = objcode.InsertpaymentVoucherOldPayable(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                        //insert check details
                                                        objcode.InsertChequeDetails(txt_Voucherno.Text, "9", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());
                                                        //insert dealer account details
                                                        objcode.InsertDealerAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "2", "9", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Old Payable  Refnum-" + msg);


                                                        string rid1 = objcode.selectidpayment();
                                                        for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                        {
                                                            string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                            string customerid = cmb_Customer.SelectedValue.ToString();
                                                            string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                            string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                            string msg1 = objcode.InsertpaymentVoucherDetailsOldPayment(msg, invid, customerid, desc, amt);
                                                        }
                                                     //   objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Update");
                                                        FrmPrintPaymentVoucherOldPay PPV = new FrmPrintPaymentVoucherOldPay(Convert.ToInt32(msg));
                                                        PPV.ShowDialog();

                                                        sum = 0;
                                                        dgv_Receipt.Rows.Clear();

                                                        clear();

                                                        btn_update.Enabled = false;
                                                        btndelete.Enabled = false;
                                                        vouchernoload();
                                                        btn_Save1.Enabled = true;
                                                        btn_remove.Enabled = true;

                                                        //MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    }

                                                    else
                                                    {
                                                        if (txtCheque.Text == string.Empty)
                                                        {
                                                            MessageBox.Show("Please Enter Check No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            txtCheque.Focus();
                                                        }
                                                        else if (Convert.ToInt32(cmbBank.SelectedValue) == 0)
                                                        {
                                                            MessageBox.Show("Please Select Bank.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            txtCheque.Focus();
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    // delete payment master, details
                                                    string mg = objcode.DeletePaymentOldPay(textBox1.Text);


                                                    //delete dealer details 
                                                    objcode.DeleteDealerAccDetailsByPVOldPay(Convert.ToInt32(textBox1.Text));

                                                    //delete from check details
                                                    if (CheckId != 0)
                                                    {
                                                        objcode.DeleteCheckDetailsByPVOldPay(CheckId);
                                                    }

                                                    string msg = objcode.InsertpaymentVoucherOldPayable(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                                    //insert dealer account details
                                                    objcode.InsertDealerAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "2", "5", msg, "Rs " + txt_Amount.Text + " is Debited by Payment Voucher Old Payable Refnum-" + msg);

                                                    //insertion into payment details
                                                    string rid1 = objcode.selectidpayment();
                                                    for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                    {
                                                        string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                        string customerid = cmb_Customer.SelectedValue.ToString();
                                                        string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                        string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                        string msg1 = objcode.InsertpaymentVoucherDetailsOldPayment(msg, invid, customerid, desc, amt);
                                                    }
                                                   // objcode.SaveWindow(DateTime.Now, "PaymentVoucher", File.ReadAllText("user.txt"), "Update");
                                                    //MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    FrmPrintPaymentVoucherOldPay PPV = new FrmPrintPaymentVoucherOldPay(Convert.ToInt32(msg));
                                                    PPV.ShowDialog();

                                                    sum = 0;
                                                    dgv_Receipt.Rows.Clear();

                                                    clear();
                                                    btn_update.Enabled = false;
                                                    btndelete.Enabled = false;
                                                    vouchernoload();
                                                    btn_Save1.Enabled = true;
                                                    btn_remove.Enabled = true;

                                                }


                                            }
                                            else
                                            {
                                                MessageBox.Show("Enter Valid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("Please Add The Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                }
                                else
                                {
                                    if (cmb_Paymentmode.Text == "--Select One--")
                                    {
                                        MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("You Do Not Have The Permission To Print Payment Voucher", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void Rb_OldPayable_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Rb_OldPayable.Checked == true)
                {
                    clear(); int Intchk = objcode.CheckInternetConnection();
                    if (Intchk == 1)
                    {
                        cmb_Customer.SelectedValue = 0;
                        VoucherNoLoadOldPay();
                        rb_other.Checked = false;
                        rb_other.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void Rb_GoodsReceipt_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Rb_GoodsReceipt.Checked == true)
                {
                    clear(); int Intchk = objcode.CheckInternetConnection();
                    if (Intchk == 1)
                    {
                        cmb_Customer.SelectedValue = 0;
                        vouchernoload();
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void dgv_Receipt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (Rb_GoodsReceipt.Checked == true)
                    {
                        f = 0;
                        if (dgv_Receipt.RowCount > 0)
                        {
                            BTNCHANGE.Enabled = true;
                            int RINX = dgv_Receipt.CurrentCell.RowIndex;
                            inid = Convert.ToInt32(dgv_Receipt.Rows[RINX].Cells[0].Value);
                            DataTable dt = new DataTable();
                            dt.Columns.Add("InvoiceId", typeof(int));
                            dt.Columns.Add("InvoiceName", typeof(string));
                            DataRow dr = dt.NewRow();
                            dr["InvoiceId"] = inid;
                            dr["InvoiceName"] = dgv_Receipt.Rows[RINX].Cells[1].Value.ToString();
                            dt.Rows.Add(dr);
                            cmb_invoice.DataSource = dt.DefaultView;
                            cmb_invoice.ValueMember = "InvoiceId";
                            cmb_invoice.DisplayMember = "InvoiceName";


                            cmb_invoice.SelectedValue = inid;

                            int invno = Convert.ToInt32(dgv_Receipt.Rows[RINX].Cells[1].Value.ToString());
                            string des = dgv_Receipt.Rows[RINX].Cells[2].Value.ToString();
                            double amt = Convert.ToDouble(dgv_Receipt.Rows[RINX].Cells[3].Value);
                            txtdescription1.Text = des.ToString();
                            txt_amount1.Text = amt.ToString();
                            cmb_invoice.Text = invno.ToString();
                            dgv_Receipt.Rows.RemoveAt(RINX);
                            //dgv_Receipt[4, RINX].Value = 1;
                            //Balance = lbldot.Text;
                            if (Convert.ToInt32(rid) == 0)
                            {
                                //save
                                DataSet invoicenbalance = objcode.Getbalanceinvoicenopayment(inid.ToString());
                                if (Balance == "0" || Balance == string.Empty)
                                {
                                    Balance = (Convert.ToDouble(invoicenbalance.Tables[0].Rows[0][0])).ToString();
                                    lbldot.Text = Balance.ToString();
                                }
                                else
                                {
                                    Balance = (Convert.ToDouble(Balance) + amt).ToString();
                                    lbldot.Text = (Convert.ToDouble(Balance)).ToString();
                                }
                            }
                            else
                            {
                                //update
                                DataSet invoicenbalance = objcode.Getbalanceinvoicenopayment(inid.ToString());
                                if (Balance == "0" || Balance == string.Empty)
                                {
                                    Balance = (Convert.ToDouble(invoicenbalance.Tables[0].Rows[0][0]) + amt).ToString();
                                    lbldot.Text = Balance.ToString();
                                }
                                else
                                {
                                    Balance = (Convert.ToDouble(Balance) + amt).ToString();
                                    lbldot.Text = (Convert.ToDouble(Balance)).ToString();
                                }
                            }

                            lbldot.Visible = true;
                            f = 1;
                        }
                    }
                    if (Rb_OldPayable.Checked == true)
                    {
                        f = 0;
                        if (dgv_Receipt.RowCount > 0)
                        {
                            BTNCHANGE.Enabled = true;
                            int RINX = dgv_Receipt.CurrentCell.RowIndex;
                            inid = Convert.ToInt32(dgv_Receipt.Rows[RINX].Cells[0].Value);
                            DataTable dt = new DataTable();
                            dt.Columns.Add("InvoiceId", typeof(int));
                            dt.Columns.Add("InvoiceName", typeof(string));
                            DataRow dr = dt.NewRow();
                            dr["InvoiceId"] = inid;
                            dr["InvoiceName"] = dgv_Receipt.Rows[RINX].Cells[1].Value.ToString();
                            dt.Rows.Add(dr);
                            cmb_invoice.DataSource = dt.DefaultView;
                            cmb_invoice.ValueMember = "InvoiceId";
                            cmb_invoice.DisplayMember = "InvoiceName";


                            cmb_invoice.SelectedValue = inid;

                            string invno = dgv_Receipt.Rows[RINX].Cells[1].Value.ToString();
                            string des = dgv_Receipt.Rows[RINX].Cells[2].Value.ToString();
                            double amt = Convert.ToDouble(dgv_Receipt.Rows[RINX].Cells[3].Value);
                            txtdescription1.Text = des.ToString();
                            txt_amount1.Text = amt.ToString();
                            cmb_invoice.Text = invno.ToString();
                            dgv_Receipt.Rows.RemoveAt(RINX);

                            //Balance = lbldot.Text;
                            if (Convert.ToInt32(rid) == 0)
                            {
                                //save
                                DataSet invoicenbalance = objcode.GetbalanceInvoiceNoPaymentOldPay(inid.ToString());
                                if (Balance == "0" || Balance == string.Empty)
                                {
                                    Balance = (Convert.ToDouble(invoicenbalance.Tables[0].Rows[0][0])).ToString();
                                    lbldot.Text = Balance.ToString();
                                }
                                else
                                {
                                    Balance = (Convert.ToDouble(Balance) + amt).ToString();
                                    lbldot.Text = (Convert.ToDouble(Balance)).ToString();
                                }
                            }
                            else
                            {
                                //update
                                DataSet invoicenbalance = objcode.GetbalanceInvoiceNoPaymentOldPay(inid.ToString());
                                if (Balance == "0" || Balance == string.Empty)
                                {
                                    Balance = (Convert.ToDouble(invoicenbalance.Tables[0].Rows[0][0]) + amt).ToString();
                                    lbldot.Text = Balance.ToString();
                                }
                                else
                                {
                                    Balance = (Convert.ToDouble(Balance) + amt).ToString();
                                    lbldot.Text = (Convert.ToDouble(Balance)).ToString();
                                }
                            }
                            lbldot.Visible = true;
                            f = 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cmb_Customer_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_Customer.DroppedDown)
            {
                cmb_Customer.Focus();


            }

        }

        private void cmb_Paymentmode_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_Paymentmode.DroppedDown)
            {
                cmb_Paymentmode.Focus();


            }
        }

        private void cmbBank_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmbBank.DroppedDown)
            {
                cmbBank.Focus();


            }
        }

        private void txt_Amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_Amount.Text == "")
                {
                    txt_Amount.Text = "0";
                }
                string Str = txt_Amount.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {

                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Amount.Text = "0";
                }
                //txt_Amount.Text = Convert.ToString(Convert.ToDouble((int)Math.Floor(Convert.ToDouble(txt_Amount.Text) + .49)));
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_amount1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_amount1.Text == "")
                {
                    txt_amount1.Text = "0";
                }
                string Str = txt_amount1.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {

                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_amount1.Text = "0";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnNewCust_Click(object sender, EventArgs e)
        {
            try
            {
                Bank bk = new Bank();
                bk.ShowDialog();
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    DataSet ds = new DataSet();
                    ds = objcode.LoadBankName();
                    cmbBank.DataSource = ds.Tables[0];
                    cmbBank.DisplayMember = "bank_name";
                    cmbBank.ValueMember = "bank_id";
                    DataRow dr1 = ds.Tables[0].NewRow();
                    dr1["bank_name"] = "--Select One--";
                    dr1["bank_id"] = "0";
                    ds.Tables[0].Rows.InsertAt(dr1, 0);
                    cmbBank.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txtother_DoubleClick(object sender, EventArgs e)
        {
            txtother.SelectAll();
        }

        private void txt_Amount_DoubleClick(object sender, EventArgs e)
        {
            txt_Amount.SelectAll();
        }

        private void txtdescription1_DoubleClick(object sender, EventArgs e)
        {
            txtdescription1.SelectAll();
        }

        private void txtCheque_DoubleClick(object sender, EventArgs e)
        {
            txtCheque.SelectAll();
        }

        private void txt_Description_DoubleClick(object sender, EventArgs e)
        {
            txt_Description.SelectAll();
        }

        private void txt_amount1_DoubleClick(object sender, EventArgs e)
        {
            txt_amount1.SelectAll();
        }

        private void cmb_Customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_Customer.DroppedDown)
            {
                cmb_Customer.Focus();
            }
        }

        private void cmb_Paymentmode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_Paymentmode.DroppedDown)
            {
                cmb_Paymentmode.Focus();
            }
        }

        private void cmbBank_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbBank.DroppedDown)
            {
                cmbBank.Focus();
            }
        }

        private void cmb_invoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_invoice.DroppedDown)
            {
                cmb_invoice.Focus();
            }
        }
    }
}
