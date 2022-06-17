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
    public partial class ReceiptVoucher : Form
    {
        double sum1 = 0;
        int no = 0;
        //int g = 0;
        double sum = 0;
        int inid = 0;
        string rid;
        //double tot = 0;
        int chk = 0;
        public int CheckId = 0;

        string Balance = "0";
        public void FloatValueValidate(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;
        }
        public ReceiptVoucher()
        {
            InitializeComponent();
            chk = 0;
            CheckId = 0;
        }
        string CustmrId = string.Empty;

        Codebehind objcode = new Codebehind();
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        int f = 0, t = 0;
        string CustId = "0", InvoiceId = "0";

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
        private void ReceiptVoucher_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    DataTable dt1 = new DataTable();
                    dt1 = objcode.GetFormUserRights(File.ReadAllText("user.txt"), "ReceiptVoucher");
                    SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
                    UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
                    DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();

                    lblname.Visible = true;
                    txtother.Visible = false;
                    label4.Visible = false;
                    cmb_Customer.Visible = true;

                    if (chk == 0)
                    {
                        vouchernoload();
                    }
                    DataSet ds = new DataSet();
                    ds = objcode.GetCustomer();
                    cmb_Customer.DataSource = ds.Tables[0];
                    cmb_Customer.DisplayMember = "customer_name";
                    cmb_Customer.ValueMember = "customer_id";
                    DataRow dr1 = ds.Tables[0].NewRow();
                    dr1["customer_name"] = "--Select One--";
                    dr1["customer_id"] = "0";
                    ds.Tables[0].Rows.InsertAt(dr1, 0);
                    cmb_Customer.SelectedValue = 0;

                    DataSet ds1 = new DataSet();
                    ds1 = objcode.LoadBankName();
                    cmbBank.DataSource = ds1.Tables[0];
                    cmbBank.DisplayMember = "bank_name";
                    cmbBank.ValueMember = "bank_id";
                    //DataRow dr12 = ds1.Tables[0].NewRow();
                    //dr12["bank_name"] = "--Select One--";
                    //dr12["bank_id"] = "0";
                    //ds1.Tables[0].Rows.InsertAt(dr12, 0);
                    //cmbBank.SelectedValue = 0;
                    cmb_Paymentmode.SelectedIndex = 0;
                    // cmb_Customer.Text = "select";
                    if (chk == 1 && no == 1)
                    {
                        cmb_Customer.SelectedValue = CustmrId;
                    }
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
            string vno = objcode.GetVoucherNo();
            txt_Voucherno.Text = vno.ToString();

        }
        //public void vouchernoloadMaintanance()
        //{
        //    string vno = objcode.GetVoucherNoMaintanance();
        //    txt_Voucherno.Text = vno.ToString();

        //}

        public void vouchernoloadOldPayReceive()
        {
            string vno = objcode.GetVoucherNoOldPayReceive();
            txt_Voucherno.Text = vno.ToString();

        }
        public void clear()
        {
            try
            {
                txt_Amount.Text = "0";
                txt_Description.Text = "";
                dgv_Receipt.Rows.Clear();
                btn_save.Enabled = true;
                btn_update.Enabled = false;
                cmb_Customer.Enabled = true;
                txtother.Enabled = true;
                btn_Save1.Enabled = true;
                btndelete.Enabled = false;

                cmb_invoice.DataSource = null;
                cmb_invoice.Text = "Select";
                lbldot.Text = "";
                txt_amount1.Text = "0";
                txtCheque.Text = "";
                dtvoucher.Value = DateTime.Now;
                txtother.Text = "";
                txtdescription1.Text = "";
                cmb_Customer.SelectedValue = 0;
                // cmb_editcustomer.SelectedIndex = 0;
                cmb_Paymentmode.SelectedIndex = 0;
                cmbBank.SelectedValue = 0;
                cmb_Customer.SelectedValue = 0;
                //rb_other.Checked = false;
                rb_other.Enabled = true;
                if (Rb_Invoice.Checked == true)
                {
                    vouchernoload();
                }
                //else if (Rb_Maintanance.Checked == true)
                //{
                //    vouchernoloadMaintanance();
                //    rb_other.Enabled = false;
                //}
                else
                {
                    vouchernoloadOldPayReceive();
                    rb_other.Enabled = false;
                }

                cmb_Customer.Enabled = true;
                Balance = "0";
                rid = "0";
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
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    lbldot.Text = "";
                    cmb_invoice.Text = "";


                    if (Rb_Invoice.Checked == true)
                    {
                        if (rb_other.Checked == false && cmb_Customer.DataSource != null && rb_customer.Checked == true)
                        {
                            CustId = cmb_Customer.SelectedValue.ToString();





                            if (f == 1 && CustId != "0" && CustId != "System.Data.DataRowView")
                            {
                                f = 0;
                                DataSet ds2 = new DataSet();
                                ds2 = objcode.SelectInvoiceNo(Convert.ToInt32(CustId));
                                cmb_invoice.DataSource = ds2.Tables[0];
                                cmb_invoice.ValueMember = "InvoiceId";
                                cmb_invoice.DisplayMember = "InvoiceName";
                                DataRow dr1 = ds2.Tables[0].NewRow();
                                dr1["InvoiceName"] = "--Select One--";
                                dr1["InvoiceId"] = "0";
                                ds2.Tables[0].Rows.InsertAt(dr1, 0);
                                cmb_invoice.SelectedValue = 0;
                                cmb_invoice.SelectedIndex = 0;
                                f = 1;
                            }

                            t = 1;
                        }
                    }
                 
                    if (rb_PayableRecevabel.Checked == true)
                    {
                        if (rb_customer.Checked == true)
                        {
                            if (rb_other.Checked == false && cmb_Customer.DataSource != null)
                            {
                                CustId = cmb_Customer.SelectedValue.ToString();
                                if (f == 1 && CustId != "0" && CustId != "System.Data.DataRowView")
                                {
                                    f = 0;
                                    DataSet ds2 = new DataSet();
                                    ds2 = objcode.SelectInvoiceNoOldPayReceive(Convert.ToInt32(CustId));
                                    cmb_invoice.DataSource = ds2.Tables[0];
                                    cmb_invoice.ValueMember = "OldPayReceiveID";
                                    cmb_invoice.DisplayMember = "RefNo";
                                    DataRow dr1 = ds2.Tables[0].NewRow();
                                    dr1["RefNo"] = "--Select One--";
                                    dr1["OldPayReceiveID"] = "0";
                                    ds2.Tables[0].Rows.InsertAt(dr1, 0);
                                    cmb_invoice.SelectedValue = 0;

                                    f = 1;
                                    //cmb_invoice.SelectedText = "--Select One--";
                                }
                                t = 1;
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                int w = 0;
                if (Convert.ToInt32(cmb_Customer.SelectedValue) != 0 && cmb_invoice.SelectedIndex >= 0 && (cmb_invoice.Text != "--Select One--") && (cmb_Paymentmode.Text) != "--Select One--")
                {
                    int invoicen = Convert.ToInt32(cmb_invoice.SelectedValue);

                    for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                    {
                        int invgrid = Convert.ToInt32(dgv_Receipt.Rows[i].Cells[0].Value);
                        if (invoicen == invgrid)
                        {
                            w = 2;
                            MessageBox.Show("Selected Invoice Already Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    if (w != 2)
                    {

                        if ((txt_amount1.Text != "0") && (Convert.ToDouble(txt_amount1.Text) != 0))
                        {

                            double amt2 = Convert.ToDouble(txt_amount1.Text);
                            double ChkAmt = Convert.ToDouble(lbldot.Text);

                            if (ChkAmt >= amt2)
                            {
                                dgv_Receipt.Rows.Add(cmb_invoice.SelectedValue, cmb_invoice.Text, txtdescription1.Text, amt2);
                                //}
                                if (Balance == "0" || Balance == string.Empty)
                                {
                                    lbldot.Text = (ChkAmt - amt2).ToString();
                                }
                                else
                                {
                                    Balance = (Convert.ToDouble(Balance) - amt2).ToString();
                                    lbldot.Text = Balance;
                                }
                                //ChkAmt = ChkAmt - amt2;
                                //lbldot.Text = ChkAmt.ToString();
                                txtdescription1.Text = "";
                                txt_amount1.Text = "0";
                                if (dgv_Receipt.Rows.Count != 0)
                                {
                                    sum1 = 0;
                                    for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                    {
                                        sum1 = sum1 + Convert.ToDouble(dgv_Receipt.Rows[i].Cells[3].Value);
                                    }
                                }
                                txt_Amount.Text = sum1.ToString();
                                cmb_Customer.Enabled = false;
                                cmb_invoice.SelectedIndex = 0;
                                lbldot.Text = "0.00";
                                Balance = "0";
                            }
                            else
                            {
                                MessageBox.Show("Check the Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_Amount.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Check the Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_Amount.Focus();
                        }
                    }
                    //

                }


                else
                {
                    if (Convert.ToInt32(cmb_Customer.SelectedValue) <= 0)
                    {
                        MessageBox.Show("Please Select Customer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmb_Customer.Focus();
                    }


                    else if (Convert.ToInt32(cmb_invoice.SelectedValue) == 0)
                    {
                        MessageBox.Show("Please Select Invoice", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmb_invoice.Focus();
                    }
                    else if ((cmb_Paymentmode.Text) == "--Select One--")
                    {
                        MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmb_Paymentmode.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                // cmb_Customer.Text = "select";
                if (dgv_Receipt.Rows.Count != 0)
                {
                    int rindex = dgv_Receipt.CurrentCell.RowIndex;
                    if (dgv_Receipt.Rows[rindex].Cells[3].Value != null)
                    {
                        double amt = Convert.ToDouble(dgv_Receipt.Rows[rindex].Cells[3].Value);
                        double netamt = Convert.ToDouble(txt_Amount.Text);
                        double final = netamt - amt;
                        txt_Amount.Text = final.ToString();
                        dgv_Receipt.Rows.RemoveAt(rindex);
                        lbldot.Text = amt.ToString();
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

        private void cmb_invoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbldot.Text = "";
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    lbldot.Visible = true;
                    lbldot.Text = "";
                    label8.Visible = true;

                    if (t == 1)
                    {
                        // t = 0;
                        if (Rb_Invoice.Checked == true && cmb_invoice.DataSource != null && cmb_invoice.Text != "--Select One--" && f != 0)
                        {
                            if (cmb_invoice.Text != "" && cmb_invoice.DataSource != null)
                            {
                                InvoiceId = cmb_invoice.SelectedValue.ToString();
                                // MessageBox.Show(InvoiceId);
                                DataSet ds2 = new DataSet();
                                ds2 = objcode.Getbalanceinvoiceno(Convert.ToInt32(InvoiceId));
                                lbldot.Text = ds2.Tables[0].Rows[0][0].ToString();
                            }
                        }

                        if (rb_PayableRecevabel.Checked == true)
                        {
                            if (rb_customer.Checked == true && cmb_invoice.DataSource != null && cmb_invoice.Text != "--Select One--" && f != 0)
                            {
                                if (cmb_invoice.Text != "" && cmb_invoice.DataSource != null && cmb_invoice.Text != "System.Data.DataRowView")
                                {
                                    InvoiceId = cmb_invoice.SelectedValue.ToString();
                                    // MessageBox.Show(InvoiceId);
                                    DataSet ds2 = new DataSet();
                                    ds2 = objcode.GetbalanceOldPayReceiveNoCustomer(Convert.ToInt32(InvoiceId));
                                    lbldot.Text = ds2.Tables[0].Rows[0][0].ToString();
                                }
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
        private void cmb_Paymentmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (cmb_Paymentmode.Text == "Cheque")
                    {
                        panelbank.Enabled = true;
                        if (f == 1)
                        {
                            DataSet ds = new DataSet();
                            ds = objcode.LoadBankName();
                            cmbBank.DataSource = ds.Tables[0];
                            cmbBank.DisplayMember = "bank_name";
                            cmbBank.ValueMember = "bank_id";
                            DataRow dr12 = ds.Tables[0].NewRow();
                            dr12["bank_name"] = "--Select One--";
                            dr12["bank_id"] = "0";
                            ds.Tables[0].Rows.InsertAt(dr12, 0);
                            cmbBank.SelectedValue = 0;
                        }
                    }
                    else
                    {
                        panelbank.Enabled = false;
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
                clear();
                searchReceiptvoucher objser = new searchReceiptvoucher();
                int g = 1;
                objser.ShowDialog();
                // passing Rid From search window
                if (objser.chk != 0)
                {
                    if (objser.InvChk == 1)
                    {
                        //invoice
                        rid = objser.rid;
                        Rb_Invoice.Checked = true;
                        DataTable DtRVM = new DataTable();
                        DtRVM = objcode.GetReceiptMaster(Convert.ToInt32(rid));

                        int custid = Convert.ToInt32(DtRVM.Rows[0]["customer_id"]);
                        if (custid == 0)
                        {
                            CustmrId = "0";
                            rb_other.Checked = true;
                            txtother.Text = DtRVM.Rows[0]["OtherName"].ToString();
                            txt_Amount.Text = DtRVM.Rows[0]["Amount"].ToString();

                            txtother.Enabled = false;

                        }
                        else
                        {
                            no = 1;
                            rb_customer.Checked = true;
                            CustmrId = custid.ToString();
                            cmb_Customer.SelectedValue = custid;
                            txt_Amount.Enabled = false;
                            cmb_Customer.Enabled = false;

                        }

                        //getting details from receipt voucher detail table
                        DataTable dt = objcode.getReceiptDetails(rid);
                        textBox1.Text = rid.ToString();
                        btn_Save1.Enabled = false;
                        btn_update.Enabled = true;
                        btndelete.Enabled = true;

                        //cmb_invoice.SelectedValue = Convert.ToInt32(dt.Rows[i]["Id"]);

                        dgv_Receipt.Rows.Clear();
                        //int i;
                        int i = 0;
                        for (i = 0; i < dt.Rows.Count; i++)
                        {
                            dgv_Receipt.Rows.Add();
                            dgv_Receipt[0, i].Value = dt.Rows[i]["Id"].ToString();
                            dgv_Receipt[1, i].Value = dt.Rows[i]["InvoiceNo"].ToString();
                            dgv_Receipt[2, i].Value = dt.Rows[i]["description"].ToString();
                            dgv_Receipt[3, i].Value = dt.Rows[i]["amount"].ToString();

                        }
                        chk = 1;

                        txt_Voucherno.Text = DtRVM.Rows[0]["VoucherNo"].ToString();
                        txt_Amount.Text = DtRVM.Rows[0]["Amount"].ToString();//Amount
                        txt_Description.Text = DtRVM.Rows[0]["Description"].ToString();
                        string paymode = DtRVM.Rows[0]["Paymode"].ToString();
                        if (paymode == "1")
                        {
                            cmb_Paymentmode.Text = "Cash";
                            panelbank.Enabled = false;
                        }
                        else
                        {
                            cmb_Paymentmode.Text = "Cheque";
                            DataTable dt1 = objcode.GetCheckForReceiptVoucher(Convert.ToInt32(DtRVM.Rows[0]["VoucherNo"]));
                            if (dt1.Rows.Count > 0)
                            {
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
                        }

                        dtvoucher.Value = Convert.ToDateTime(DtRVM.Rows[0]["VoucherDate"]);
                        // dgv_Receipt.DataSource = ds.Tables[0];
                        panelnew.Visible = false;
                        panelold.Visible = true;
                        btnadd.Visible = true;
                        //btn_remove.Visible = true;



                        btn_update.Enabled = true;
                        txt_Amount.Enabled = true;
                        btn_update.Enabled = true;
                        btndelete.Enabled = true;
                        btn_save.Enabled = false;
                        //this.Hide();
                    }

                    
                    if (objser.InvChk == 3)
                    {
                        //old receivable
                        rb_PayableRecevabel.Checked = true;
                        rid = objser.rid;

                        DataTable DtRVM = new DataTable();
                        DtRVM = objcode.GetReceiptVoucherMasterOldReceive(Convert.ToInt32(rid));

                        int custid = Convert.ToInt32(DtRVM.Rows[0]["customer_id"]);
                        if (custid == 0)
                        {
                            CustmrId = "0";
                            rb_other.Checked = true;
                            txtother.Text = DtRVM.Rows[0]["OtherName"].ToString();
                            txt_Amount.Text = DtRVM.Rows[0]["Amount"].ToString();
                            txtother.Enabled = false;

                        }
                        else
                        {
                            no = 1;
                            rb_customer.Checked = true;
                            CustmrId = custid.ToString();
                            cmb_Customer.SelectedValue = custid;
                            txt_Amount.Enabled = false;
                            cmb_Customer.Enabled = false;

                        }

                        //getting details from receipt voucher detail table
                        DataTable dt = objcode.GetReceiptDetailsOldReceive(rid);
                        textBox1.Text = rid.ToString();
                        btn_Save1.Enabled = false;
                        btn_update.Enabled = true;
                        btndelete.Enabled = true;

                        //cmb_invoice.SelectedValue = Convert.ToInt32(dt.Rows[i]["Id"]);

                        dgv_Receipt.Rows.Clear();
                        //int i;
                        int i = 0;
                        for (i = 0; i < dt.Rows.Count; i++)
                        {
                            dgv_Receipt.Rows.Add();
                            dgv_Receipt[0, i].Value = dt.Rows[i]["Id"].ToString();
                            dgv_Receipt[1, i].Value = dt.Rows[i]["RefNo"].ToString();
                            dgv_Receipt[2, i].Value = dt.Rows[i]["description"].ToString();
                            dgv_Receipt[3, i].Value = dt.Rows[i]["amount"].ToString();

                        }
                        chk = 1;

                        txt_Voucherno.Text = DtRVM.Rows[0]["VoucherNo"].ToString();
                        txt_Amount.Text = DtRVM.Rows[0]["Amount"].ToString();//Amount
                        txt_Description.Text = DtRVM.Rows[0]["Description"].ToString();
                        string paymode = DtRVM.Rows[0]["Paymode"].ToString();
                        if (paymode == "1")
                        {
                            cmb_Paymentmode.Text = "Cash";
                            panelbank.Enabled = false;
                        }
                        else
                        {
                            cmb_Paymentmode.Text = "Cheque";
                            DataTable dt1 = objcode.GetCheckForReceiptVoucherOldReceive(Convert.ToInt32(DtRVM.Rows[0]["VoucherNo"]));
                            if (dt1.Rows.Count > 0)
                            {
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
                        }

                        dtvoucher.Value = Convert.ToDateTime(DtRVM.Rows[0]["VoucherDate"]);
                        // dgv_Receipt.DataSource = ds.Tables[0];
                        panelnew.Visible = false;
                        panelold.Visible = true;
                        btnadd.Visible = true;
                        //btn_remove.Visible = true;

                        btn_update.Enabled = true;
                        txt_Amount.Enabled = true;
                        btn_update.Enabled = true;
                        btndelete.Enabled = true;
                        btn_save.Enabled = false;
                        //this.Hide();
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
                        if (Rb_Invoice.Checked == true && rb_PayableRecevabel.Checked == false )
                        {
                            //nvocie

                            if (cmb_Paymentmode.Text != string.Empty && (cmb_Paymentmode.Text) != "--Select One--")
                            {

                                if (cmb_Paymentmode.Text == "Cheque")
                                {
                                    if (txtCheque.Text != string.Empty && Convert.ToInt32(cmbBank.SelectedValue) != 0)
                                    {
                                        int status;
                                        if (cbox_check.Checked == true)
                                            status = 1;
                                        else
                                            status = 0;
                                        if (rb_other.Checked == true)
                                        {
                                            //delete from receipt master tbl and detail table
                                            string mg = objcode.deletereceipt(textBox1.Text);

                                            //delete customer details 
                                            objcode.DeleteUserAccDetailsByRV(Convert.ToInt32(textBox1.Text));

                                            //delete from check details
                                            if (CheckId != 0)
                                            {
                                                objcode.DeleteCheckDetailsByRV(CheckId);
                                            }

                                            string msg = objcode.InsertReceiptVoucher(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "3", status);
                                            // insert into customer account details
                                            objcode.InsertCustAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "1", "2", msg, "Rs " + txt_Amount.Text + " is Credited by reciept voucher Refnum-" + msg);

                                            //insert into check details
                                            objcode.InsertChequeDetails(txt_Voucherno.Text, "2", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());
                                            //objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Update");
                                            MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                            btn_update.Enabled = false;
                                            btndelete.Enabled = false;
                                            btn_save.Enabled = true;
                                            vouchernoload();

                                        }
                                        else if (rb_customer.Checked == true && Rb_Invoice.Checked == true)
                                        {
                                            if (Convert.ToInt32(cmb_Customer.SelectedValue) != 0)
                                            {
                                                if (dgv_Receipt.Rows.Count > 0)
                                                {

                                                    // g = 0;
                                                    sum = 0;
                                                    no = 0;
                                                    //tot = 0;
                                                    if (dgv_Receipt.RowCount > 0)
                                                    {
                                                        for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                        {
                                                            double sumrows = Convert.ToDouble(dgv_Receipt.Rows[i].Cells[3].Value.ToString());
                                                            sum = sum + sumrows;
                                                        }
                                                    }
                                                    else
                                                        sum = Convert.ToDouble(txt_Amount.Text);
                                                    if (Convert.ToDouble(txt_Amount.Text) == sum)
                                                    {



                                                        //delete from receipt master tbl and detail table
                                                        string mg = objcode.deletereceipt(textBox1.Text);

                                                        //delete customer details 
                                                        objcode.DeleteUserAccDetailsByRV(Convert.ToInt32(textBox1.Text));

                                                        //delete from check details
                                                        if (CheckId != 0)
                                                        {
                                                            objcode.DeleteCheckDetailsByRV(CheckId);
                                                        }

                                                        string msg = objcode.InsertReceiptVoucher(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                        string rid1 = objcode.selectid();
                                                        for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                        {
                                                            string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                            string customerid = cmb_Customer.SelectedValue.ToString();
                                                            string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                            string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                            string msg1 = objcode.InsertReceiptVoucherDetails(rid1, invid, customerid, desc, amt);
                                                        }

                                                        // insert into customer account details
                                                        objcode.InsertCustAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "1", "2", msg, "Rs " + txt_Amount.Text + " is Credited by reciept voucher Refnum-" + msg);

                                                        //insert into check details
                                                        objcode.InsertChequeDetails(txt_Voucherno.Text, "2", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());
                                                       // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Update");
                                                        MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                                        btn_update.Enabled = false;
                                                        btndelete.Enabled = false;
                                                        btn_save.Enabled = true;
                                                        vouchernoload();

                                                        sum = 0;
                                                        dgv_Receipt.Rows.Clear();

                                                        clear();


                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Enter Valid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    }
                                                }
                                                else
                                                    MessageBox.Show("Please Add The Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            else
                                                MessageBox.Show("Please Select Customer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        }

                                    }
                                    else
                                    {
                                        if (txtCheque.Text == string.Empty)
                                        {
                                            MessageBox.Show("Please Enter Check no", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                                    if (rb_other.Checked == true)
                                    {
                                        //delete from receipt master tbl and detail table
                                        string mg = objcode.deletereceipt(textBox1.Text);

                                        //delete customer details 
                                        objcode.DeleteUserAccDetailsByRV(Convert.ToInt32(textBox1.Text));

                                        //delete from check details
                                        if (CheckId != 0)
                                        {
                                            objcode.DeleteCheckDetailsByRV(CheckId);
                                        }

                                        string msg = objcode.InsertReceiptVoucher(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "1", 1);
                                        // insert into customer account details
                                        objcode.InsertCustAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "1", "2", msg, "Rs " + txt_Amount.Text + " is Credited by reciept voucher Refnum-" + msg);


                                      //  objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Update");
                                        MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        btn_update.Enabled = false;
                                        btndelete.Enabled = false;
                                        btn_save.Enabled = true;
                                        vouchernoload();

                                        sum = 0;
                                        dgv_Receipt.Rows.Clear();

                                        clear();
                                    }
                                    else if (rb_customer.Checked == true && Rb_Invoice.Checked == true)
                                    {
                                        if (Convert.ToInt32(cmb_Customer.SelectedValue) != 0)
                                        {
                                            if (dgv_Receipt.Rows.Count > 0)
                                            {
                                                // g = 0;
                                                sum = 0;
                                                no = 0;
                                                //tot = 0;
                                                if (dgv_Receipt.RowCount > 0)
                                                {
                                                    for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                    {
                                                        double sumrows = Convert.ToDouble(dgv_Receipt.Rows[i].Cells[3].Value.ToString());
                                                        sum = sum + sumrows;
                                                    }
                                                }
                                                else
                                                    sum = Convert.ToDouble(txt_Amount.Text);
                                                if (Convert.ToDouble(txt_Amount.Text) == sum)
                                                {

                                                    //delete from receipt master tbl and detail table
                                                    string mg = objcode.deletereceipt(textBox1.Text);

                                                    //delete customer details 
                                                    objcode.DeleteUserAccDetailsByRV(Convert.ToInt32(textBox1.Text));

                                                    //delete from check details
                                                    if (CheckId != 0)
                                                    {
                                                        objcode.DeleteCheckDetailsByRV(CheckId);
                                                    }

                                                    string msg = objcode.InsertReceiptVoucher(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "1", 1);
                                                    // insert into customer account details
                                                    objcode.InsertCustAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "1", "2", msg, "Rs " + txt_Amount.Text + " is Credited by reciept voucher Refnum-" + msg);

                                                    string rid1 = objcode.selectid();
                                                    for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                    {
                                                        string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                        string customerid = cmb_Customer.SelectedValue.ToString();
                                                        string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                        string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                        string msg1 = objcode.InsertReceiptVoucherDetails(rid1, invid, customerid, desc, amt);
                                                    }
                                                   // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Update");
                                                    MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                                    btn_update.Enabled = false;
                                                    btndelete.Enabled = false;
                                                    btn_save.Enabled = true;
                                                    vouchernoload();
                                                    sum = 0;
                                                    dgv_Receipt.Rows.Clear();

                                                    clear();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Enter Valid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }
                                            }
                                            else
                                                MessageBox.Show("Please Add The Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                            MessageBox.Show("Please Select Customer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }


                                }
                            }
                            else
                            {

                                if (cmb_Paymentmode.Text == "--Select One--")
                                {
                                    MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cmb_Paymentmode.Focus();
                                }
                                else if (cmb_Paymentmode.Text == string.Empty)
                                {
                                    MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cmb_Paymentmode.Focus();
                                }

                            }

                        }
                      
                        //close goods receipt

                        if (Rb_Invoice.Checked == false && rb_PayableRecevabel.Checked == true)
                        {

                            //Old Receivalbe
                            if (cmb_Paymentmode.Text != string.Empty && (cmb_Paymentmode.Text) != "--Select One--")
                            {

                                if (cmb_Paymentmode.Text == "Cheque")
                                {
                                    if (txtCheque.Text != string.Empty && Convert.ToInt32(cmbBank.SelectedValue) != 0)
                                    {
                                        int status;
                                        if (cbox_check.Checked == true)
                                            status = 1;
                                        else
                                            status = 0;
                                        if (rb_other.Checked == true)
                                        {
                                            //delete from receipt master tbl and detail table
                                            string mg = objcode.DeleteReceiptOldReceive(textBox1.Text);

                                            //delete customer details 
                                            objcode.DeleteUserAccDetailsByRVOldReceivable(Convert.ToInt32(textBox1.Text));
                                            //objcode.DeleteDealerAccDetailsByRV(Convert.ToInt32(textBox1.Text));

                                            //delete from check details
                                            if (CheckId != 0)
                                            {
                                                objcode.DeleteCheckDetailsByRVOldReceivable(CheckId);
                                            }

                                            string msg = objcode.InsertReceiptVoucherOldReceivable(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                            objcode.InsertChequeDetails(txt_Voucherno.Text, "8", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());

                                            // insert into customer account details
                                            objcode.InsertCustAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "1", "8", msg, "Rs " + txt_Amount.Text + " Is Credited By Reciept Voucher Old Receivalbe Refnum-" + msg);
                                           // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Update");
                                            MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                            btn_update.Enabled = false;
                                            btndelete.Enabled = false;
                                            btn_save.Enabled = true;
                                            vouchernoloadOldPayReceive();

                                        }
                                        else if (rb_customer.Checked == true)
                                        {
                                            if (Convert.ToInt32(cmb_Customer.SelectedValue) != 0)
                                            {
                                                if (dgv_Receipt.Rows.Count > 0)
                                                {

                                                    // g = 0;
                                                    sum = 0;
                                                    no = 0;
                                                    //tot = 0;
                                                    if (dgv_Receipt.RowCount > 0)
                                                    {
                                                        for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                        {
                                                            double sumrows = Convert.ToDouble(dgv_Receipt.Rows[i].Cells[3].Value.ToString());
                                                            sum = sum + sumrows;
                                                        }
                                                    }
                                                    else
                                                        sum = Convert.ToDouble(txt_Amount.Text);
                                                    if (Convert.ToDouble(txt_Amount.Text) == sum)
                                                    {



                                                        //delete from receipt master tbl and detail table
                                                        string mg = objcode.DeleteReceiptOldReceive(textBox1.Text);

                                                        //delete customer details 
                                                        objcode.DeleteUserAccDetailsByRVOldReceivable(Convert.ToInt32(textBox1.Text));

                                                        //delete from check details
                                                        if (CheckId != 0)
                                                        {
                                                            objcode.DeleteCheckDetailsByRVOldReceivable(CheckId);
                                                        }

                                                        string msg = objcode.InsertReceiptVoucherOldReceivable(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                        objcode.InsertChequeDetails(txt_Voucherno.Text, "8", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());

                                                        // insert into customer account details
                                                        objcode.InsertCustAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "1", "8", msg, "Rs " + txt_Amount.Text + " Is Credited By Reciept Voucher Old Receivalbe Refnum-" + msg);

                                                        // insert into receipt voucher details
                                                        //string rid = objcode.selectidMain();
                                                        for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                        {
                                                            string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                            string customerid = cmb_Customer.SelectedValue.ToString();
                                                            string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                            string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                            string msg1 = objcode.InsertReceiptVoucherDetailsOldPayReceive(msg, invid, customerid, desc, amt, 0);
                                                        }
                                                       // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Update");
                                                        MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                                        btn_update.Enabled = false;
                                                        btndelete.Enabled = false;
                                                        btn_save.Enabled = true;
                                                        vouchernoloadOldPayReceive();

                                                        sum = 0;
                                                        dgv_Receipt.Rows.Clear();

                                                        clear();


                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Enter Valid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    }
                                                }
                                                else
                                                    MessageBox.Show("Please Add The Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            else
                                                MessageBox.Show("Please Select Customer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        }


                                    }
                                    else
                                    {
                                        if (txtCheque.Text == string.Empty)
                                        {
                                            MessageBox.Show("Please Enter Check no", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                                    if (rb_other.Checked == true)
                                    {
                                        //delete from receipt master tbl and detail table
                                        string mg = objcode.DeleteReceiptOldReceive(textBox1.Text);

                                        //delete customer details 
                                        objcode.DeleteUserAccDetailsByRVOldReceivable(Convert.ToInt32(textBox1.Text));

                                        //delete from check details
                                        if (CheckId != 0)
                                        {
                                            objcode.DeleteCheckDetailsByRVOldReceivable(CheckId);
                                        }

                                        string msg = objcode.InsertReceiptVoucherOldReceivable(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                        // insert into customer account details
                                        objcode.InsertCustAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "1", "8", msg, "Rs " + txt_Amount.Text + " Is Credited By Reciept Voucher Old Receivalbe Refnum-" + msg);



                                       // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Update");
                                        MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        btn_update.Enabled = false;
                                        btndelete.Enabled = false;
                                        btn_save.Enabled = true;
                                        vouchernoloadOldPayReceive();

                                        sum = 0;
                                        dgv_Receipt.Rows.Clear();

                                        clear();
                                    }
                                    else if (rb_customer.Checked == true)
                                    {
                                        if (Convert.ToInt32(cmb_Customer.SelectedValue) != 0)
                                        {
                                            if (dgv_Receipt.Rows.Count > 0)
                                            {
                                                // g = 0;
                                                sum = 0;
                                                no = 0;
                                                //tot = 0;
                                                if (dgv_Receipt.RowCount > 0)
                                                {
                                                    for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                    {
                                                        double sumrows = Convert.ToDouble(dgv_Receipt.Rows[i].Cells[3].Value.ToString());
                                                        sum = sum + sumrows;
                                                    }
                                                }
                                                else
                                                    sum = Convert.ToDouble(txt_Amount.Text);
                                                if (Convert.ToDouble(txt_Amount.Text) == sum)
                                                {

                                                    //delete from receipt master tbl and detail table
                                                    string mg = objcode.DeleteReceiptOldReceive(textBox1.Text);

                                                    //delete customer details 
                                                    objcode.DeleteUserAccDetailsByRVOldReceivable(Convert.ToInt32(textBox1.Text));

                                                    //delete from check details
                                                    if (CheckId != 0)
                                                    {
                                                        objcode.DeleteCheckDetailsByRVOldReceivable(CheckId);
                                                    }

                                                    string msg = objcode.InsertReceiptVoucherOldReceivable(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                                    // insert into customer account details
                                                    objcode.InsertCustAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "1", "8", msg, "Rs " + txt_Amount.Text + " Is Credited By Reciept Voucher Old Receivalbe Refnum-" + msg);

                                                    // insert into receipt voucher details
                                                    //string rid = objcode.selectidMain();
                                                    for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                    {
                                                        string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                        string customerid = cmb_Customer.SelectedValue.ToString();
                                                        string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                        string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                        string msg1 = objcode.InsertReceiptVoucherDetailsOldPayReceive(msg, invid, customerid, desc, amt, 0);
                                                    }
                                                    //objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Update");
                                                    MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                                    btn_update.Enabled = false;
                                                    btndelete.Enabled = false;
                                                    btn_save.Enabled = true;
                                                    vouchernoloadOldPayReceive();
                                                    sum = 0;
                                                    dgv_Receipt.Rows.Clear();

                                                    clear();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Enter Valid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }
                                            }
                                            else
                                                MessageBox.Show("Please Add The Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                            MessageBox.Show("Please Select Customer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            else
                            {

                                if (cmb_Paymentmode.Text == "--Select One--")
                                {
                                    MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cmb_Paymentmode.Focus();
                                }
                                else if (cmb_Paymentmode.Text == string.Empty)
                                {
                                    MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cmb_Paymentmode.Focus();
                                }

                            }

                        }
                        //close Old Receivable
                    }
                    else
                    {
                        MessageBox.Show("You Do Not Have The Permission To Update Receipt Voucher", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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

        private void txt_amount1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_amount1.Text == "0")
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

        private void btn_Save1_Click(object sender, EventArgs e)
        {

            try
            {
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (SaveStatus == "1")
                    {
                        if (Rb_Invoice.Checked == true && rb_PayableRecevabel.Checked == false )
                        {
                            //Invoice

                            if (rb_other.Checked == true)
                            {
                                if (txtother.Text != string.Empty && txt_Amount.Text != "0" && cmb_Paymentmode.Text != string.Empty && (cmb_Paymentmode.Text) != "--Select One--")
                                {
                                    if (cmb_Paymentmode.Text == "Cheque")
                                    {
                                        if (txtCheque.Text != string.Empty && Convert.ToInt32(cmbBank.SelectedValue) != 0)
                                        {
                                            int status;
                                            if (cbox_check.Checked == true)
                                                status = 1;
                                            else
                                                status = 0;
                                            string msg = objcode.InsertReceiptVoucher(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                            objcode.InsertChequeDetails(txt_Voucherno.Text, "2", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());

                                            // insert into customer account details
                                            objcode.InsertCustAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "1", "2", msg, "Rs " + txt_Amount.Text + " is Credited by reciept voucher Refnum-" + msg);
                                           // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Save");
                                            MessageBox.Show("Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            vouchernoload();
                                            clear();
                                        }
                                        else
                                        {
                                            if (txtCheque.Text == string.Empty)
                                            {
                                                MessageBox.Show("Please Enter Check no", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                        string msg = objcode.InsertReceiptVoucher(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                        // insert into customer account details
                                        objcode.InsertCustAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "1", "2", msg, "Rs " + txt_Amount.Text + " is Credited by reciept voucher Refnum-" + msg);
                                       // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Save");
                                        MessageBox.Show("Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                    else if (cmb_Paymentmode.Text == "--Select One--")
                                    {
                                        MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cmb_Paymentmode.Focus();
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
                            else if (rb_customer.Checked == true)
                            {
                                if (cmb_Paymentmode.Text != string.Empty && (cmb_Paymentmode.Text) != "--Select One--" && Convert.ToInt32(cmb_Customer.SelectedValue) != 0)
                                {
                                    if (dgv_Receipt.Rows.Count != 0)
                                    {
                                        sum = 0;
                                        no = 0;
                                        //tot = 0;
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
                                                    int status;
                                                    if (cbox_check.Checked == true)
                                                        status = 1;
                                                    else
                                                        status = 0;

                                                    string msg = objcode.InsertReceiptVoucher(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                    objcode.InsertChequeDetails(txt_Voucherno.Text, "2", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());

                                                    // insert into customer account details
                                                    objcode.InsertCustAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "1", "2", msg, "Rs " + txt_Amount.Text + " is Credited by reciept voucher Refnum-" + msg);

                                                    // insert into receipt voucher details
                                                    string rid = objcode.selectid();
                                                    for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                    {
                                                        string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                        string customerid = cmb_Customer.SelectedValue.ToString();
                                                        string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                        string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                        string msg1 = objcode.InsertReceiptVoucherDetails(rid, invid, customerid, desc, amt);
                                                    }


                                                    sum = 0;
                                                    dgv_Receipt.Rows.Clear();
                                                    vouchernoload();
                                                    clear();
                                                    cmb_Customer.SelectedValue = 0;
                                                    //objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Save");
                                                    MessageBox.Show("Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }
                                                else
                                                {
                                                    if (txtCheque.Text == string.Empty)
                                                    {
                                                        MessageBox.Show("Please Enter Check no", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                                string msg = objcode.InsertReceiptVoucher(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                                // insert into customer account details
                                                objcode.InsertCustAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "1", "2", msg, "Rs " + txt_Amount.Text + " is Credited by reciept voucher Refnum-" + msg);

                                                // insert into receipt voucher details
                                                string rid = objcode.selectid();
                                                for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                {
                                                    string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                    string customerid = cmb_Customer.SelectedValue.ToString();
                                                    string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                    string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                    string msg1 = objcode.InsertReceiptVoucherDetails(rid, invid, customerid, desc, amt);
                                                }


                                                sum = 0;
                                                dgv_Receipt.Rows.Clear();
                                                vouchernoload();
                                                clear();
                                                cmb_Customer.SelectedValue = 0;
                                              //  objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Save");
                                                MessageBox.Show("Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }


                                        }
                                        else
                                        {
                                            MessageBox.Show("Enter Valid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }

                                    }
                                    else
                                        MessageBox.Show("Please Add The Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    if (Convert.ToInt32(cmb_Customer.SelectedValue) == 0)
                                    {
                                        MessageBox.Show("Please Select Customer.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cmb_Customer.Focus();
                                    }
                                    else if (cmb_Paymentmode.Text == "--Select One--")
                                    {
                                        MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cmb_Paymentmode.Focus();
                                    }
                                    else if (cmb_Paymentmode.Text == string.Empty)
                                    {
                                        MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cmb_Paymentmode.Focus();
                                    }

                                }
                            }

                        }//close goods
                        //close maintanance
                        if (Rb_Invoice.Checked == false &&  rb_PayableRecevabel.Checked == true)
                        {
                            //Old Pay Receive

                            if (rb_other.Checked == true)
                            {
                                if (txtother.Text != string.Empty && txt_Amount.Text != "0" && cmb_Paymentmode.Text != string.Empty && (cmb_Paymentmode.Text) != "--Select One--")
                                {
                                    if (cmb_Paymentmode.Text == "Cheque")
                                    {
                                        if (txtCheque.Text != string.Empty && Convert.ToInt32(cmbBank.SelectedValue) != 0)
                                        {
                                            int status;
                                            if (cbox_check.Checked == true)
                                                status = 1;
                                            else
                                                status = 0;

                                            string msg = objcode.InsertReceiptVoucherOldReceivable(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                            objcode.InsertChequeDetails(txt_Voucherno.Text, "8", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());

                                            // insert into customer account details
                                            objcode.InsertCustAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "1", "8", msg, "Rs " + txt_Amount.Text + " Is Credited By Reciept Voucher Old Receivalbe Refnum-" + msg);
                                           // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Save");
                                            MessageBox.Show("Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            vouchernoloadOldPayReceive();
                                            clear();
                                        }
                                        else
                                        {
                                            if (txtCheque.Text == string.Empty)
                                            {
                                                MessageBox.Show("Please Enter Check no", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                        string msg = objcode.InsertReceiptVoucherOldReceivable(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                        // insert into customer account details
                                        objcode.InsertCustAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "1", "8", msg, "Rs " + txt_Amount.Text + " Is Credited By Reciept Voucher Old Receivalbe Refnum-" + msg);
                                       // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Save");
                                        MessageBox.Show("Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        vouchernoloadOldPayReceive();
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
                                    else if (cmb_Paymentmode.Text == "--Select One--")
                                    {
                                        MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cmb_Paymentmode.Focus();
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
                            else if (rb_customer.Checked == true)
                            {
                                if (cmb_Paymentmode.Text != string.Empty && (cmb_Paymentmode.Text) != "--Select One--" && Convert.ToInt32(cmb_Customer.SelectedValue) != 0)
                                {
                                    if (dgv_Receipt.Rows.Count != 0)
                                    {
                                        sum = 0;
                                        no = 0;
                                        //tot = 0;
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
                                                    int status;
                                                    if (cbox_check.Checked == true)
                                                        status = 1;
                                                    else
                                                        status = 0;

                                                    string msg = objcode.InsertReceiptVoucherOldReceivable(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                    objcode.InsertChequeDetails(txt_Voucherno.Text, "8", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());

                                                    // insert into customer account details
                                                    objcode.InsertCustAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "1", "8", msg, "Rs " + txt_Amount.Text + " Is Credited By Reciept Voucher Old Receivalbe Refnum-" + msg);

                                                    // insert into receipt voucher details
                                                    //string rid = objcode.selectidMain();
                                                    for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                    {
                                                        string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                        string customerid = cmb_Customer.SelectedValue.ToString();
                                                        string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                        string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                        string msg1 = objcode.InsertReceiptVoucherDetailsOldPayReceive(msg, invid, customerid, desc, amt, 0);
                                                    }


                                                    sum = 0;
                                                    dgv_Receipt.Rows.Clear();
                                                    vouchernoloadOldPayReceive();
                                                    clear();
                                                    cmb_Customer.SelectedValue = 0;
                                                   // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Save");
                                                    MessageBox.Show("Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }
                                                else
                                                {
                                                    if (txtCheque.Text == string.Empty)
                                                    {
                                                        MessageBox.Show("Please Enter Check no", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                                string msg = objcode.InsertReceiptVoucherOldReceivable(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                                // insert into customer account details
                                                objcode.InsertCustAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "1", "8", msg, "Rs " + txt_Amount.Text + " Is Credited By Reciept Voucher Old Receivalbe Refnum-" + msg);

                                                // insert into receipt voucher details
                                                //string rid = objcode.selectidMain();
                                                for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                {
                                                    string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                    string customerid = cmb_Customer.SelectedValue.ToString();
                                                    string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                    string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                    string msg1 = objcode.InsertReceiptVoucherDetailsOldPayReceive(msg, invid, customerid, desc, amt, 0);
                                                }


                                                sum = 0;
                                                dgv_Receipt.Rows.Clear();
                                                vouchernoloadOldPayReceive();
                                                clear();
                                                cmb_Customer.SelectedValue = 0;
                                              //  objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Save");
                                                MessageBox.Show("Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }


                                        }
                                        else
                                        {
                                            MessageBox.Show("Enter Valid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }

                                    }
                                    else
                                        MessageBox.Show("Please Add The Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    if (Convert.ToInt32(cmb_Customer.SelectedValue) == 0)
                                    {
                                        MessageBox.Show("Please Select Customer.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cmb_Customer.Focus();
                                    }
                                    else if (cmb_Paymentmode.Text == "--Select One--")
                                    {
                                        MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cmb_Paymentmode.Focus();
                                    }
                                    else if (cmb_Paymentmode.Text == string.Empty)
                                    {
                                        MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cmb_Paymentmode.Focus();
                                    }

                                }
                            }


                        }
                        //close old receive
                    }
                    else
                    {
                        MessageBox.Show("You Do Not Have The Permission To Save Receipt Voucher", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        if (Rb_Invoice.Checked == true)
                        {
                            string mg = objcode.deletereceipt(textBox1.Text);

                            //delete from customer account details
                            objcode.DeleteUserAccDetailsByRV(Convert.ToInt32(textBox1.Text));

                            //delete from check details
                            if (CheckId != 0)
                                objcode.DeleteCheckDetailsByRV(CheckId);
                           // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Delete");
                            MessageBox.Show(mg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_update.Enabled = false;
                            btndelete.Enabled = false;
                            btn_Save1.Enabled = true;

                            dgv_Receipt.Rows.Clear();
                            vouchernoload();
                            clear();
                        }
                        //if (Rb_Invoice.Checked == false && Rb_Maintanance.Checked == true)
                        //{
                        //    string mg = objcode.DeleteReceiptMaintanance(textBox1.Text);

                        //    if (rb_customer.Checked == true)
                        //    {
                        //        //delete from customer account details
                        //        objcode.DeleteUserAccDetailsByRVMaintanance(Convert.ToInt32(textBox1.Text));
                        //    }
                        //    else if (Rb_Dealer.Checked == true)
                        //    {
                        //        //delete from dealer acc details
                        //        objcode.DeleteDealerAccDetailsByRVMaintanance(Convert.ToInt32(textBox1.Text));
                        //    }

                        //    //delete from check details
                        //    if (CheckId != 0)
                        //        objcode.DeleteCheckDetailsByRVMaintanance(CheckId);
                        //    //objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Delete");
                        //    MessageBox.Show(mg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    btn_update.Enabled = false;
                        //    btndelete.Enabled = false;
                        //    btn_Save1.Enabled = true;

                        //    dgv_Receipt.Rows.Clear();

                        //    vouchernoloadMaintanance();
                        //    clear();

                        //}
                        if (Rb_Invoice.Checked == false  && rb_PayableRecevabel.Checked == true)
                        {
                            //delete from receipt master tbl and detail table
                            string mg = objcode.DeleteReceiptOldReceive(textBox1.Text);

                            //delete customer details 
                            objcode.DeleteUserAccDetailsByRVOldReceivable(Convert.ToInt32(textBox1.Text));

                            //delete from check details
                            if (CheckId != 0)
                            {
                                objcode.DeleteCheckDetailsByRVOldReceivable(CheckId);
                            }
                           // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Delete");
                            MessageBox.Show(mg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_update.Enabled = false;
                            btndelete.Enabled = false;
                            btn_Save1.Enabled = true;

                            dgv_Receipt.Rows.Clear();

                            vouchernoloadOldPayReceive();
                            clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You Do Not Have The Permission To Delete Receipt Voucher", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
                f = 0;
                if (Rb_Invoice.Checked == true && rb_PayableRecevabel.Checked == false )
                {
                    if (rb_customer.Checked == true)
                    {
                        clear();


                        cmb_Customer.DataSource = null;
                        cmb_invoice.DataSource = null;

                        DataSet ds = new DataSet();
                        ds = objcode.GetCustomer();
                        cmb_Customer.DataSource = ds.Tables[0];
                        cmb_Customer.DisplayMember = "customer_name";
                        cmb_Customer.ValueMember = "customer_id";
                        DataRow dr1 = ds.Tables[0].NewRow();
                        dr1["customer_name"] = "--Select One--";
                        dr1["customer_id"] = "0";
                        ds.Tables[0].Rows.InsertAt(dr1, 0);
                        cmb_Customer.SelectedValue = 0;

                        lblname.Visible = true;
                        txtother.Visible = false;
                        label4.Visible = false;
                        cmb_Customer.Visible = true;
                        txt_Amount.Enabled = false;
                        txt_Amount.Text = "0";
                        InvoiceDetails.Visible = true;
                        label8.Visible = true;
                        lbl_Dealer.Visible = false;
                        f = 1;
                    }
                    vouchernoload();
                }
              
                else
                {
                    if (rb_PayableRecevabel.Checked == true && rb_customer.Checked == true)
                    {
                        clear();
                        rb_other.Enabled = false;
                        cmb_Customer.DataSource = null;
                        cmb_invoice.DataSource = null;

                        DataSet ds = new DataSet();
                        ds = objcode.GetCustomer();
                        cmb_Customer.DataSource = ds.Tables[0];
                        cmb_Customer.DisplayMember = "customer_name";
                        cmb_Customer.ValueMember = "customer_id";
                        DataRow dr1 = ds.Tables[0].NewRow();
                        dr1["customer_name"] = "--Select One--";
                        dr1["customer_id"] = "0";
                        ds.Tables[0].Rows.InsertAt(dr1, 0);
                        cmb_Customer.SelectedValue = 0;

                        lblname.Visible = true;
                        txtother.Visible = false;
                        label4.Visible = false;
                        cmb_Customer.Visible = true;
                        txt_Amount.Enabled = false;
                        txt_Amount.Text = "0";
                        InvoiceDetails.Visible = true;
                        label8.Visible = true;
                        lbl_Dealer.Visible = false;

                        vouchernoloadOldPayReceive();
                        f = 1;
                    }

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
                if (Rb_Invoice.Checked == true)
                {
                    clear();

                    lblname.Visible = false;

                    label4.Visible = true;
                    txtother.Visible = true;
                    cmb_Customer.Visible = false;
                    txt_Amount.Enabled = true;
                    txt_Amount.Text = "0";
                    InvoiceDetails.Visible = false;
                    label8.Visible = false;
                    //vouchernoload();
                    f = 0;
                }
               
                else
                {
                    clear();

                    lblname.Visible = false;

                    label4.Visible = true;
                    txtother.Visible = true;
                    cmb_Customer.Visible = false;
                    txt_Amount.Enabled = true;
                    txt_Amount.Text = "0";
                    InvoiceDetails.Visible = false;
                    label8.Visible = false;
                    //vouchernoloadOldPayReceive();
                    f = 0;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void BTNCHANGE_Click(object sender, EventArgs e)
        {
            try
            {
                int RINX = dgv_Receipt.CurrentCell.RowIndex;
                dgv_Receipt.Rows.RemoveAt(RINX);

                // int invid =Convert.ToInt32(inid,
                int inno = Convert.ToInt32(cmb_invoice.Text);
                string des = txtdescription1.Text;
                double amt = Convert.ToDouble(txt_amount1.Text);
                dgv_Receipt.Rows.Add(inid, inno, des, amt);
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txt_amount1_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void Rb_Invoice_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Rb_Invoice.Checked == true)
                {
                    clear();
                    cmb_Customer.SelectedValue = 0;
                    vouchernoload();
                }
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
                    if (SaveStatus == "1")
                    {
                        if (Convert.ToInt32(rid) == 0)
                        {

                            //save

                            if (Rb_Invoice.Checked == true)
                            {
                                if (rb_other.Checked == true)
                                {
                                    if (txtother.Text != string.Empty && txt_Amount.Text != "0" && cmb_Paymentmode.Text != string.Empty && (cmb_Paymentmode.Text) != "--Select One--")
                                    {
                                        if (cmb_Paymentmode.Text == "Cheque")
                                        {
                                            if (txtCheque.Text != string.Empty && Convert.ToInt32(cmbBank.SelectedValue) != 0)
                                            {
                                                int status;
                                                if (cbox_check.Checked == true)
                                                    status = 1;
                                                else
                                                    status = 0;
                                                string msg = objcode.InsertReceiptVoucher(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                objcode.InsertChequeDetails(txt_Voucherno.Text, "2", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());

                                                // insert into customer account details
                                                objcode.InsertCustAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "1", "2", msg, "Rs " + txt_Amount.Text + " is Credited by reciept voucher Refnum-" + msg);
                                               // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Save");
                                                //MessageBox.Show("Successfully Inserted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                FrmPrintReceiptVoucherOther PRV = new FrmPrintReceiptVoucherOther(Convert.ToInt32(msg));
                                               PRV.ShowDialog();

                                                vouchernoload();
                                                clear();
                                            }
                                            else
                                            {
                                                if (txtCheque.Text == string.Empty)
                                                {
                                                    MessageBox.Show("Please Enter Check no", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                            string msg = objcode.InsertReceiptVoucher(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                            // insert into customer account details
                                            objcode.InsertCustAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "1", "2", msg, "Rs " + txt_Amount.Text + " is Credited by reciept voucher Refnum-" + msg);
                                            //MessageBox.Show("Insertion Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            //objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Save");
                                           FrmPrintReceiptVoucherOther PRV = new FrmPrintReceiptVoucherOther(Convert.ToInt32(msg));
                                            PRV.ShowDialog();
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
                                        else if (cmb_Paymentmode.Text == "--Select One--")
                                        {
                                            MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cmb_Paymentmode.Focus();
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
                                else if (rb_customer.Checked == true)
                                {
                                    if (cmb_Paymentmode.Text != string.Empty && (cmb_Paymentmode.Text) != "--Select One--" && Convert.ToInt32(cmb_Customer.SelectedValue) != 0)
                                    {
                                        if (dgv_Receipt.Rows.Count != 0)
                                        {
                                            sum = 0;
                                            no = 0;
                                            //tot = 0;
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
                                                        int status;
                                                        if (cbox_check.Checked == true)
                                                            status = 1;
                                                        else
                                                            status = 0;

                                                        string msg = objcode.InsertReceiptVoucher(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                        objcode.InsertChequeDetails(txt_Voucherno.Text, "2", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());

                                                        // insert into customer account details
                                                        objcode.InsertCustAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "1", "2", msg, "Rs " + txt_Amount.Text + " is Credited by reciept voucher Refnum-" + msg);

                                                        // insert into receipt voucher details
                                                        string rid1 = objcode.selectid();
                                                        for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                        {
                                                            string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                            string customerid = cmb_Customer.SelectedValue.ToString();
                                                            string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                            string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                            string msg1 = objcode.InsertReceiptVoucherDetails(rid1, invid, customerid, desc, amt);
                                                        }


                                                        sum = 0;
                                                        dgv_Receipt.Rows.Clear();
                                                        vouchernoload();
                                                        clear();
                                                        cmb_Customer.SelectedValue = 0;
                                                        //MessageBox.Show("Insertion successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                       // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Save");
                                                       FrmPrintReceiptVoucher PRV = new FrmPrintReceiptVoucher(Convert.ToInt32(msg));
                                                      PRV.ShowDialog();
                                                    }
                                                    else
                                                    {
                                                        if (txtCheque.Text == string.Empty)
                                                        {
                                                            MessageBox.Show("Please Enter Check no", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                                    string msg = objcode.InsertReceiptVoucher(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                                    // insert into customer account details
                                                    objcode.InsertCustAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "1", "2", msg, "Rs " + txt_Amount.Text + " is Credited by reciept voucher Refnum-" + msg);

                                                    // insert into receipt voucher details
                                                    string rid1 = objcode.selectid();
                                                    for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                    {
                                                        string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                        string customerid = cmb_Customer.SelectedValue.ToString();
                                                        string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                        string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                        string msg1 = objcode.InsertReceiptVoucherDetails(rid1, invid, customerid, desc, amt);
                                                    }


                                                    sum = 0;
                                                    dgv_Receipt.Rows.Clear();
                                                    vouchernoload();
                                                    clear();
                                                    cmb_Customer.SelectedValue = 0;
                                                    //MessageBox.Show("Insertion Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    //objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Save");
                                                   FrmPrintReceiptVoucher PRV = new FrmPrintReceiptVoucher(Convert.ToInt32(msg));
                                                   PRV.ShowDialog();
                                                }


                                            }
                                            else
                                            {
                                                MessageBox.Show("Enter Valid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }

                                        }
                                        else
                                            MessageBox.Show("Please Add The Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        if (Convert.ToInt32(cmb_Customer.SelectedValue) == 0)
                                        {
                                            MessageBox.Show("Please Select Customer.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cmb_Customer.Focus();
                                        }
                                        else if (cmb_Paymentmode.Text == "--Select One--")
                                        {
                                            MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cmb_Paymentmode.Focus();
                                        }
                                        else if (cmb_Paymentmode.Text == string.Empty)
                                        {
                                            MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cmb_Paymentmode.Focus();
                                        }

                                    }
                                }

                            }
  
                            if (Rb_Invoice.Checked == false && rb_PayableRecevabel.Checked == true)
                            {
                                //Old Pay Receive

                                if (rb_other.Checked == true)
                                {
                                    if (txtother.Text != string.Empty && txt_Amount.Text != "0" && cmb_Paymentmode.Text != string.Empty && (cmb_Paymentmode.Text) != "--Select One--")
                                    {
                                        if (cmb_Paymentmode.Text == "Cheque")
                                        {
                                            if (txtCheque.Text != string.Empty && Convert.ToInt32(cmbBank.SelectedValue) != 0)
                                            {
                                                int status;
                                                if (cbox_check.Checked == true)
                                                    status = 1;
                                                else
                                                    status = 0;

                                                string msg = objcode.InsertReceiptVoucherOldReceivable(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                objcode.InsertChequeDetails(txt_Voucherno.Text, "8", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());

                                                // insert into customer account details
                                                objcode.InsertCustAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "1", "8", msg, "Rs " + txt_Amount.Text + " Is Credited By Reciept Voucher Old Receivalbe Refnum-" + msg);
                                               // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Save");
                                                //MessageBox.Show("Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                FrmPrintReceiptVoucherOldReceiveOther PRV = new FrmPrintReceiptVoucherOldReceiveOther(Convert.ToInt32(msg));
                                               PRV.ShowDialog();


                                                vouchernoloadOldPayReceive();
                                                clear();
                                            }
                                            else
                                            {
                                                if (txtCheque.Text == string.Empty)
                                                {
                                                    MessageBox.Show("Please Enter Check no", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                            string msg = objcode.InsertReceiptVoucherOldReceivable(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                            // insert into customer account details
                                            objcode.InsertCustAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "1", "8", msg, "Rs " + txt_Amount.Text + " Is Credited By Reciept Voucher Old Receivalbe Refnum-" + msg);
                                           // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Save");
                                            //MessageBox.Show("Insertion Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                           FrmPrintReceiptVoucherOldReceiveOther PRV = new FrmPrintReceiptVoucherOldReceiveOther(Convert.ToInt32(msg));
                                          PRV.ShowDialog();

                                            vouchernoloadOldPayReceive();
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
                                        else if (cmb_Paymentmode.Text == "--Select One--")
                                        {
                                            MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cmb_Paymentmode.Focus();
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
                                else if (rb_customer.Checked == true)
                                {
                                    if (cmb_Paymentmode.Text != string.Empty && (cmb_Paymentmode.Text) != "--Select One--" && Convert.ToInt32(cmb_Customer.SelectedValue) != 0)
                                    {
                                        if (dgv_Receipt.Rows.Count != 0)
                                        {
                                            sum = 0;
                                            no = 0;
                                            //tot = 0;
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
                                                        int status;
                                                        if (cbox_check.Checked == true)
                                                            status = 1;
                                                        else
                                                            status = 0;

                                                        string msg = objcode.InsertReceiptVoucherOldReceivable(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                        objcode.InsertChequeDetails(txt_Voucherno.Text, "8", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());

                                                        // insert into customer account details
                                                        objcode.InsertCustAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "1", "8", msg, "Rs " + txt_Amount.Text + " Is Credited By Reciept Voucher Old Receivalbe Refnum-" + msg);

                                                        // insert into receipt voucher details
                                                        //string rid = objcode.selectidMain();
                                                        for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                        {
                                                            string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                            string customerid = cmb_Customer.SelectedValue.ToString();
                                                            string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                            string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                            string msg1 = objcode.InsertReceiptVoucherDetailsOldPayReceive(msg, invid, customerid, desc, amt, 0);
                                                        }
                                                        //objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Save");
                                                        FrmPrintReceiptVoucherOldReceive PRV = new FrmPrintReceiptVoucherOldReceive(Convert.ToInt32(msg));
                                                        PRV.ShowDialog();

                                                        sum = 0;
                                                        dgv_Receipt.Rows.Clear();
                                                        vouchernoloadOldPayReceive();
                                                        clear();
                                                        cmb_Customer.SelectedValue = 0;
                                                        //MessageBox.Show("Insertion successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    }
                                                    else
                                                    {
                                                        if (txtCheque.Text == string.Empty)
                                                        {
                                                            MessageBox.Show("Please Enter Check no", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                                    string msg = objcode.InsertReceiptVoucherOldReceivable(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                                    // insert into customer account details
                                                    objcode.InsertCustAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "1", "8", msg, "Rs " + txt_Amount.Text + " Is Credited By Reciept Voucher Old Receivalbe Refnum-" + msg);

                                                    // insert into receipt voucher details
                                                    //string rid = objcode.selectidMain();
                                                    for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                    {
                                                        string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                        string customerid = cmb_Customer.SelectedValue.ToString();
                                                        string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                        string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                        string msg1 = objcode.InsertReceiptVoucherDetailsOldPayReceive(msg, invid, customerid, desc, amt, 0);
                                                    }
                                                   // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Save");
                                                   FrmPrintReceiptVoucherOldReceive PRV = new FrmPrintReceiptVoucherOldReceive(Convert.ToInt32(msg));
                                                   PRV.ShowDialog();

                                                    sum = 0;
                                                    dgv_Receipt.Rows.Clear();
                                                    vouchernoloadOldPayReceive();
                                                    clear();
                                                    cmb_Customer.SelectedValue = 0;
                                                    //MessageBox.Show("Insertion Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }


                                            }
                                            else
                                            {
                                                MessageBox.Show("Enter Valid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }

                                        }
                                        else
                                            MessageBox.Show("Please Add The Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        if (Convert.ToInt32(cmb_Customer.SelectedValue) == 0)
                                        {
                                            MessageBox.Show("Please Select Customer.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cmb_Customer.Focus();
                                        }
                                        else if (cmb_Paymentmode.Text == "--Select One--")
                                        {
                                            MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cmb_Paymentmode.Focus();
                                        }
                                        else if (cmb_Paymentmode.Text == string.Empty)
                                        {
                                            MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cmb_Paymentmode.Focus();
                                        }

                                    }
                                }


                            }
                            //close old receive
                        }
                        else
                        {
                            //update

                            if (Rb_Invoice.Checked == true)
                            {
                                if (cmb_Paymentmode.Text != string.Empty && (cmb_Paymentmode.Text) != "--Select One--")
                                {

                                    if (cmb_Paymentmode.Text == "Cheque")
                                    {
                                        if (txtCheque.Text != string.Empty && Convert.ToInt32(cmbBank.SelectedValue) != 0)
                                        {
                                            int status;
                                            if (cbox_check.Checked == true)
                                                status = 1;
                                            else
                                                status = 0;
                                            if (rb_other.Checked == true)
                                            {
                                                //delete from receipt master tbl and detail table
                                                string mg = objcode.deletereceipt(textBox1.Text);

                                                //delete customer details 
                                                objcode.DeleteUserAccDetailsByRV(Convert.ToInt32(textBox1.Text));

                                                //delete from check details
                                                if (CheckId != 0)
                                                {
                                                    objcode.DeleteCheckDetailsByRV(CheckId);
                                                }

                                                string msg = objcode.InsertReceiptVoucher(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "3", status);
                                                // insert into customer account details
                                                objcode.InsertCustAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "1", "2", msg, "Rs " + txt_Amount.Text + " is Credited by reciept voucher Refnum-" + msg);

                                                //insert into check details
                                                objcode.InsertChequeDetails(txt_Voucherno.Text, "2", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());

                                               // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Update");
                                                //MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                FrmPrintReceiptVoucherOther PRV = new FrmPrintReceiptVoucherOther(Convert.ToInt32(msg));
                                                PRV.ShowDialog();

                                                btn_update.Enabled = false;
                                                btndelete.Enabled = false;
                                                btn_save.Enabled = true;
                                                vouchernoload();

                                            }
                                            else if (rb_customer.Checked == true && Rb_Invoice.Checked == true)
                                            {
                                                if (Convert.ToInt32(cmb_Customer.SelectedValue) != 0)
                                                {
                                                    if (dgv_Receipt.Rows.Count > 0)
                                                    {

                                                        // g = 0;
                                                        sum = 0;
                                                        no = 0;
                                                        //tot = 0;
                                                        if (dgv_Receipt.RowCount > 0)
                                                        {
                                                            for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                            {
                                                                double sumrows = Convert.ToDouble(dgv_Receipt.Rows[i].Cells[3].Value.ToString());
                                                                sum = sum + sumrows;
                                                            }
                                                        }
                                                        else
                                                            sum = Convert.ToDouble(txt_Amount.Text);
                                                        if (Convert.ToDouble(txt_Amount.Text) == sum)
                                                        {



                                                            //delete from receipt master tbl and detail table
                                                            string mg = objcode.deletereceipt(textBox1.Text);

                                                            //delete customer details 
                                                            objcode.DeleteUserAccDetailsByRV(Convert.ToInt32(textBox1.Text));

                                                            //delete from check details
                                                            if (CheckId != 0)
                                                            {
                                                                objcode.DeleteCheckDetailsByRV(CheckId);
                                                            }

                                                            string msg = objcode.InsertReceiptVoucher(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                            string rid1 = objcode.selectid();
                                                            for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                            {
                                                                string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                                string customerid = cmb_Customer.SelectedValue.ToString();
                                                                string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                                string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                                string msg1 = objcode.InsertReceiptVoucherDetails(rid1, invid, customerid, desc, amt);
                                                            }

                                                            // insert into customer account details
                                                            objcode.InsertCustAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "1", "2", msg, "Rs " + txt_Amount.Text + " is Credited by reciept voucher Refnum-" + msg);

                                                            //insert into check details
                                                            objcode.InsertChequeDetails(txt_Voucherno.Text, "2", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());
                                                           // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Update");
                                                            //MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                           FrmPrintReceiptVoucher PRV = new FrmPrintReceiptVoucher(Convert.ToInt32(msg));
                                                           PRV.ShowDialog();

                                                            btn_update.Enabled = false;
                                                            btndelete.Enabled = false;
                                                            btn_save.Enabled = true;
                                                            vouchernoload();

                                                            sum = 0;
                                                            dgv_Receipt.Rows.Clear();

                                                            clear();


                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Enter Valid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        }
                                                    }
                                                    else
                                                        MessageBox.Show("Please Add The Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }
                                                else
                                                    MessageBox.Show("Please Select Customer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            }

                                        }
                                        else
                                        {
                                            if (txtCheque.Text == string.Empty)
                                            {
                                                MessageBox.Show("Please Enter Check no", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                                        if (rb_other.Checked == true)
                                        {
                                            //delete from receipt master tbl and detail table
                                            string mg = objcode.deletereceipt(textBox1.Text);

                                            //delete customer details 
                                            objcode.DeleteUserAccDetailsByRV(Convert.ToInt32(textBox1.Text));

                                            //delete from check details
                                            if (CheckId != 0)
                                            {
                                                objcode.DeleteCheckDetailsByRV(CheckId);
                                            }

                                            string msg = objcode.InsertReceiptVoucher(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "1", 1);
                                            // insert into customer account details
                                            objcode.InsertCustAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "1", "2", msg, "Rs " + txt_Amount.Text + " is Credited by reciept voucher Refnum-" + msg);
                                            //objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Update");
                                            FrmPrintReceiptVoucherOther PRV = new FrmPrintReceiptVoucherOther(Convert.ToInt32(msg));
                                           PRV.ShowDialog();

                                            //MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            btn_update.Enabled = false;
                                            btndelete.Enabled = false;
                                            btn_save.Enabled = true;
                                            vouchernoload();

                                            sum = 0;
                                            dgv_Receipt.Rows.Clear();

                                            clear();
                                        }
                                        else if (rb_customer.Checked == true && Rb_Invoice.Checked == true)
                                        {
                                            if (Convert.ToInt32(cmb_Customer.SelectedValue) != 0)
                                            {
                                                if (dgv_Receipt.Rows.Count > 0)
                                                {
                                                    // g = 0;
                                                    sum = 0;
                                                    no = 0;
                                                    //tot = 0;
                                                    if (dgv_Receipt.RowCount > 0)
                                                    {
                                                        for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                        {
                                                            double sumrows = Convert.ToDouble(dgv_Receipt.Rows[i].Cells[3].Value.ToString());
                                                            sum = sum + sumrows;
                                                        }
                                                    }
                                                    else
                                                        sum = Convert.ToDouble(txt_Amount.Text);
                                                    if (Convert.ToDouble(txt_Amount.Text) == sum)
                                                    {

                                                        //delete from receipt master tbl and detail table
                                                        string mg = objcode.deletereceipt(textBox1.Text);

                                                        //delete customer details 
                                                        objcode.DeleteUserAccDetailsByRV(Convert.ToInt32(textBox1.Text));

                                                        //delete from check details
                                                        if (CheckId != 0)
                                                        {
                                                            objcode.DeleteCheckDetailsByRV(CheckId);
                                                        }

                                                        string msg = objcode.InsertReceiptVoucher(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "1", 1);
                                                        // insert into customer account details
                                                        objcode.InsertCustAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "1", "2", msg, "Rs " + txt_Amount.Text + " is Credited by reciept voucher Refnum-" + msg);

                                                        string rid1 = objcode.selectid();
                                                        for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                        {
                                                            string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                            string customerid = cmb_Customer.SelectedValue.ToString();
                                                            string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                            string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                            string msg1 = objcode.InsertReceiptVoucherDetails(rid1, invid, customerid, desc, amt);
                                                        }
                                                        //objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Update");
                                                        //MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                      FrmPrintReceiptVoucher PRV = new FrmPrintReceiptVoucher(Convert.ToInt32(msg));
                                                      PRV.ShowDialog();

                                                        btn_update.Enabled = false;
                                                        btndelete.Enabled = false;
                                                        btn_save.Enabled = true;
                                                        vouchernoload();
                                                        sum = 0;
                                                        dgv_Receipt.Rows.Clear();

                                                        clear();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Enter Valid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    }
                                                }
                                                else
                                                    MessageBox.Show("Please Add The Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            else
                                                MessageBox.Show("Please Select Customer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }


                                    }
                                }
                                else
                                {

                                    if (cmb_Paymentmode.Text == "--Select One--")
                                    {
                                        MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cmb_Paymentmode.Focus();
                                    }
                                    else if (cmb_Paymentmode.Text == string.Empty)
                                    {
                                        MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cmb_Paymentmode.Focus();
                                    }

                                }

                            }
          
                            if (Rb_Invoice.Checked == false &&  rb_PayableRecevabel.Checked == true)
                            {

                                //Old Receivalbe
                                if (cmb_Paymentmode.Text != string.Empty && (cmb_Paymentmode.Text) != "--Select One--")
                                {

                                    if (cmb_Paymentmode.Text == "Cheque")
                                    {
                                        if (txtCheque.Text != string.Empty && Convert.ToInt32(cmbBank.SelectedValue) != 0)
                                        {
                                            int status;
                                            if (cbox_check.Checked == true)
                                                status = 1;
                                            else
                                                status = 0;
                                            if (rb_other.Checked == true)
                                            {
                                                //delete from receipt master tbl and detail table
                                                string mg = objcode.DeleteReceiptOldReceive(textBox1.Text);

                                                //delete customer details 
                                                objcode.DeleteUserAccDetailsByRVOldReceivable(Convert.ToInt32(textBox1.Text));
                                                //objcode.DeleteDealerAccDetailsByRV(Convert.ToInt32(textBox1.Text));

                                                //delete from check details
                                                if (CheckId != 0)
                                                {
                                                    objcode.DeleteCheckDetailsByRVOldReceivable(CheckId);
                                                }

                                                string msg = objcode.InsertReceiptVoucherOldReceivable(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                objcode.InsertChequeDetails(txt_Voucherno.Text, "8", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());

                                                // insert into customer account details
                                                objcode.InsertCustAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "1", "8", msg, "Rs " + txt_Amount.Text + " Is Credited By Reciept Voucher Old Receivalbe Refnum-" + msg);
                                               // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Update");
                                                //MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                               FrmPrintReceiptVoucherOldReceiveOther PRV = new FrmPrintReceiptVoucherOldReceiveOther(Convert.ToInt32(msg));
                                               PRV.ShowDialog();

                                                btn_update.Enabled = false;
                                                btndelete.Enabled = false;
                                                btn_save.Enabled = true;
                                                vouchernoloadOldPayReceive();

                                            }
                                            else if (rb_customer.Checked == true)
                                            {
                                                if (Convert.ToInt32(cmb_Customer.SelectedValue) != 0)
                                                {
                                                    if (dgv_Receipt.Rows.Count > 0)
                                                    {

                                                        // g = 0;
                                                        sum = 0;
                                                        no = 0;
                                                        //tot = 0;
                                                        if (dgv_Receipt.RowCount > 0)
                                                        {
                                                            for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                            {
                                                                double sumrows = Convert.ToDouble(dgv_Receipt.Rows[i].Cells[3].Value.ToString());
                                                                sum = sum + sumrows;
                                                            }
                                                        }
                                                        else
                                                            sum = Convert.ToDouble(txt_Amount.Text);
                                                        if (Convert.ToDouble(txt_Amount.Text) == sum)
                                                        {



                                                            //delete from receipt master tbl and detail table
                                                            string mg = objcode.DeleteReceiptOldReceive(textBox1.Text);

                                                            //delete customer details 
                                                            objcode.DeleteUserAccDetailsByRVOldReceivable(Convert.ToInt32(textBox1.Text));

                                                            //delete from check details
                                                            if (CheckId != 0)
                                                            {
                                                                objcode.DeleteCheckDetailsByRVOldReceivable(CheckId);
                                                            }

                                                            string msg = objcode.InsertReceiptVoucherOldReceivable(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "3", status);

                                                            objcode.InsertChequeDetails(txt_Voucherno.Text, "8", txtCheque.Text, dtChequeDate.Value, cmbBank.SelectedValue.ToString(), txt_Amount.Text, status.ToString());

                                                            // insert into customer account details
                                                            objcode.InsertCustAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "1", "8", msg, "Rs " + txt_Amount.Text + " Is Credited By Reciept Voucher Old Receivalbe Refnum-" + msg);

                                                            // insert into receipt voucher details
                                                            //string rid = objcode.selectidMain();
                                                            for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                            {
                                                                string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                                string customerid = cmb_Customer.SelectedValue.ToString();
                                                                string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                                string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                                string msg1 = objcode.InsertReceiptVoucherDetailsOldPayReceive(msg, invid, customerid, desc, amt, 0);
                                                            }
                                                           // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Update");
                                                            //MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            FrmPrintReceiptVoucherOldReceive PRV = new FrmPrintReceiptVoucherOldReceive(Convert.ToInt32(msg));
                                                            PRV.ShowDialog();

                                                            btn_update.Enabled = false;
                                                            btndelete.Enabled = false;
                                                            btn_save.Enabled = true;
                                                            vouchernoloadOldPayReceive();

                                                            sum = 0;
                                                            dgv_Receipt.Rows.Clear();

                                                            clear();


                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Enter Valid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        }
                                                    }
                                                    else
                                                        MessageBox.Show("Please Add The Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }
                                                else
                                                    MessageBox.Show("Please Select Customer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            }


                                        }
                                        else
                                        {
                                            if (txtCheque.Text == string.Empty)
                                            {
                                                MessageBox.Show("Please Enter Check no", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                                        if (rb_other.Checked == true)
                                        {
                                            //delete from receipt master tbl and detail table
                                            string mg = objcode.DeleteReceiptOldReceive(textBox1.Text);

                                            //delete customer details 
                                            objcode.DeleteUserAccDetailsByRVOldReceivable(Convert.ToInt32(textBox1.Text));

                                            //delete from check details
                                            if (CheckId != 0)
                                            {
                                                objcode.DeleteCheckDetailsByRVOldReceivable(CheckId);
                                            }

                                            string msg = objcode.InsertReceiptVoucherOldReceivable(dtvoucher.Value, txt_Voucherno.Text, "", "0", txtother.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                            // insert into customer account details
                                            objcode.InsertCustAccountDetails("0", dtvoucher.Value, txt_Amount.Text, "1", "8", msg, "Rs " + txt_Amount.Text + " Is Credited By Reciept Voucher Old Receivalbe Refnum-" + msg);



                                           // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Update");
                                            //MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            FrmPrintReceiptVoucherOldReceiveOther PRV = new FrmPrintReceiptVoucherOldReceiveOther(Convert.ToInt32(msg));
                                            PRV.ShowDialog();

                                            btn_update.Enabled = false;
                                            btndelete.Enabled = false;
                                            btn_save.Enabled = true;
                                            vouchernoloadOldPayReceive();

                                            sum = 0;
                                            dgv_Receipt.Rows.Clear();

                                            clear();
                                        }
                                        else if (rb_customer.Checked == true)
                                        {
                                            if (Convert.ToInt32(cmb_Customer.SelectedValue) != 0)
                                            {
                                                if (dgv_Receipt.Rows.Count > 0)
                                                {
                                                    // g = 0;
                                                    sum = 0;
                                                    no = 0;
                                                    //tot = 0;
                                                    if (dgv_Receipt.RowCount > 0)
                                                    {
                                                        for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                        {
                                                            double sumrows = Convert.ToDouble(dgv_Receipt.Rows[i].Cells[3].Value.ToString());
                                                            sum = sum + sumrows;
                                                        }
                                                    }
                                                    else
                                                        sum = Convert.ToDouble(txt_Amount.Text);
                                                    if (Convert.ToDouble(txt_Amount.Text) == sum)
                                                    {

                                                        //delete from receipt master tbl and detail table
                                                        string mg = objcode.DeleteReceiptOldReceive(textBox1.Text);

                                                        //delete customer details 
                                                        objcode.DeleteUserAccDetailsByRVOldReceivable(Convert.ToInt32(textBox1.Text));

                                                        //delete from check details
                                                        if (CheckId != 0)
                                                        {
                                                            objcode.DeleteCheckDetailsByRVOldReceivable(CheckId);
                                                        }

                                                        string msg = objcode.InsertReceiptVoucherOldReceivable(dtvoucher.Value, txt_Voucherno.Text, "", cmb_Customer.SelectedValue.ToString(), cmb_Customer.Text, txt_Amount.Text, txt_Description.Text, "1", 1);

                                                        // insert into customer account details
                                                        objcode.InsertCustAccountDetails(cmb_Customer.SelectedValue.ToString(), dtvoucher.Value, txt_Amount.Text, "1", "8", msg, "Rs " + txt_Amount.Text + " Is Credited By Reciept Voucher Old Receivalbe Refnum-" + msg);

                                                        // insert into receipt voucher details
                                                        //string rid = objcode.selectidMain();
                                                        for (int i = 0; i < dgv_Receipt.Rows.Count; i++)
                                                        {
                                                            string invid = dgv_Receipt.Rows[i].Cells[0].Value.ToString();
                                                            string customerid = cmb_Customer.SelectedValue.ToString();
                                                            string desc = dgv_Receipt.Rows[i].Cells[2].Value.ToString();
                                                            string amt = dgv_Receipt.Rows[i].Cells[3].Value.ToString();

                                                            string msg1 = objcode.InsertReceiptVoucherDetailsOldPayReceive(msg, invid, customerid, desc, amt, 0);
                                                        }
                                                       // objcode.SaveWindow(DateTime.Now, "ReceiptVoucher", File.ReadAllText("user.txt"), "Update");
                                                        //MessageBox.Show("Updation Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        FrmPrintReceiptVoucherOldReceive PRV = new FrmPrintReceiptVoucherOldReceive(Convert.ToInt32(msg));
                                                        PRV.ShowDialog();

                                                        btn_update.Enabled = false;
                                                        btndelete.Enabled = false;
                                                        btn_save.Enabled = true;
                                                        vouchernoloadOldPayReceive();
                                                        sum = 0;
                                                        dgv_Receipt.Rows.Clear();

                                                        clear();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Enter Valid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    }
                                                }
                                                else
                                                    MessageBox.Show("Please Add The Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            else
                                                MessageBox.Show("Please Select Customer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                }
                                else
                                {

                                    if (cmb_Paymentmode.Text == "--Select One--")
                                    {
                                        MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cmb_Paymentmode.Focus();
                                    }
                                    else if (cmb_Paymentmode.Text == string.Empty)
                                    {
                                        MessageBox.Show("Please Select Payment Mode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cmb_Paymentmode.Focus();
                                    }

                                }

                            }
                            //close Old Receivable

                        }
                    }
                    else
                    {
                        MessageBox.Show("You Do Not Have The Permission To Print Receipt Voucher", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (dgv_Receipt.RowCount > 0)
                {
                    if (Rb_Invoice.Checked == true && rb_PayableRecevabel.Checked == false)
                    {
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

                        //DataSet invoicenbalance = objcode.Getbalanceinvoiceno(inid);
                        //lbldot.Text = (Convert.ToDouble(invoicenbalance.Tables[0].Rows[0][0]) + amt).ToString();
                        ////+Convert.ToDouble(amt))
                        ////lbldot.Text = (Convert.ToDouble(lbldot.Text) + Convert.ToDouble(amt)).ToString();
                        if (Convert.ToInt32(rid) == 0)
                        {
                            //save
                            DataSet invoicenbalance = objcode.Getbalanceinvoiceno(inid);
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
                            DataSet invoicenbalance = objcode.Getbalanceinvoiceno(inid);
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
                        dgv_Receipt.Rows.RemoveAt(RINX);
                    }
                   
                    if (Rb_Invoice.Checked == false  && rb_PayableRecevabel.Checked == true)
                    {
                        f = 0;
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
                        f = 1;

                        cmb_invoice.SelectedValue = inid;



                        string invno = dgv_Receipt.Rows[RINX].Cells[1].Value.ToString();
                        string des = dgv_Receipt.Rows[RINX].Cells[2].Value.ToString();
                        double amt = Convert.ToDouble(dgv_Receipt.Rows[RINX].Cells[3].Value);
                        txtdescription1.Text = des.ToString();
                        txt_amount1.Text = amt.ToString();
                        cmb_invoice.Text = invno.ToString();


                        if (rb_customer.Checked == true)
                        {
                            if (Convert.ToInt32(rid) == 0)
                            {
                                DataSet invoicenbalance = objcode.GetbalanceOldPayReceiveNoCustomer(inid);
                                //lbldot.Text = (Convert.ToDouble(invoicenbalance.Tables[0].Rows[0][0]) + amt).ToString();
                                //+Convert.ToDouble(amt))
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
                                DataSet invoicenbalance = objcode.GetbalanceOldPayReceiveNoCustomer(inid);
                                //lbldot.Text = (Convert.ToDouble(invoicenbalance.Tables[0].Rows[0][0]) + amt).ToString();
                                //+Convert.ToDouble(amt))
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
                        }

                        dgv_Receipt.Rows.RemoveAt(RINX);
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void rb_PayableRecevabel_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rb_PayableRecevabel.Checked == true)
                {
                    clear();
                    cmb_Customer.SelectedValue = 0;
                    vouchernoloadOldPayReceive();
                    rb_other.Checked = false;
                    rb_other.Enabled = false;
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

        private void cmb_invoice_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_invoice.DroppedDown)
            {
                cmb_invoice.Focus();
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
                // txt_Amount.Text = Convert.ToString(Convert.ToDouble((int)Math.Floor(Convert.ToDouble(txt_Amount.Text) + .49)));
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void bttn_newcategory_Click(object sender, EventArgs e)
        {
            try
            {
                Bank b = new Bank();
                b.ShowDialog();
                DataSet ds1 = new DataSet();
                ds1 = objcode.LoadBankName();
                cmbBank.DataSource = ds1.Tables[0];
                cmbBank.DisplayMember = "bank_name";
                cmbBank.ValueMember = "bank_id";
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_Voucherno_DoubleClick(object sender, EventArgs e)
        {
            txt_Voucherno.SelectAll();
        }

        private void txtother_DoubleClick(object sender, EventArgs e)
        {
            txtother.SelectAll();
        }

        private void txt_Amount_DoubleClick(object sender, EventArgs e)
        {
            txt_Amount.SelectAll();
        }

        private void txt_Description_DoubleClick(object sender, EventArgs e)
        {
            txt_Description.SelectAll();
        }

        private void txtdescription1_DoubleClick(object sender, EventArgs e)
        {
            txtdescription1.SelectAll();
        }

        private void txt_amount1_DoubleClick(object sender, EventArgs e)
        {
            txt_amount1.SelectAll();
        }

        private void txtCheque_DoubleClick(object sender, EventArgs e)
        {
            txtCheque.SelectAll();
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

        private void dgv_Receipt_Click(object sender, EventArgs e)
        {

        }
    }
}
