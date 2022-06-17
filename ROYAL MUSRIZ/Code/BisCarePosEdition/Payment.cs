using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BisCarePosEdition
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            TouchBilling tc = new TouchBilling();
            //txt_payable.Text = billingclass.netamount.ToString();
        }
        Codebehind obj = new Codebehind();
        public int CashMode, CreditMode = 0;
        private void Payment_Load(object sender, EventArgs e)
        {
            DataSet dt = new DataSet();
            dt = obj.GetSwipeMachine();
            for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
            {
                dgvswipemasters.Rows.Add();
                dgvswipemasters[0, i].Value = dt.Tables[0].Rows[i]["SwipeName"].ToString();
            }
            if (dgvswipemasters.Rows.Count > 0)
            {
                dgvswipemasters.CurrentCell.Selected = false;
            }
            fill();
            //billingclass.setpayableamt = Convert.ToDouble(txt_payable.Text.ToString());
            lbl_swiping.Text = "";
            btn_cash_Click(sender, e);
        }
        private void fill()
        {
            DataTable dts = new DataTable();
            dts = obj.TOUCHGETDETAILS("", 1);
            dataGridView1.Rows.Clear();
            if (dts.Rows.Count > 0)
            {
                for (int i = 0; i < dts.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1[0, i].Value = i + 1;
                    dataGridView1[1, i].Value = dts.Rows[i]["InvoiceNo"].ToString();
                    dataGridView1[2, i].Value = dts.Rows[i]["totalnet"].ToString();

                }
            }
            
        }
            
        private void btn_NewUnit_Click(object sender, EventArgs e)
        {
            SwipingMachine sw = new SwipingMachine();
            sw.ShowDialog();
            DataSet ds = new DataSet();
            ds = obj.GetSwipeMachine();
            if(dgvswipemasters.Rows.Count>0)
            dgvswipemasters.CurrentCell.Selected = false;
            dgvswipemasters.Rows.Clear();
            
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dgvswipemasters.Rows.Add();
                dgvswipemasters[0, i].Value = ds.Tables[0].Rows[i]["SwipeName"].ToString();
            }   
        }
  
        private void btn_cash_Click(object sender, EventArgs e)
        {
            CashMode = 1;
            CreditMode = 0;
            btn_credit.BackColor = Color.DarkRed;
            btn_cash.BackColor = Color.Red;
            txt_amount.Focus();
            status = "";
            str = "";
            txt_amount.Text = "";
            txt_amount.Focus();

        }
        int chk = 0;
        private void btn_credit_Click(object sender, EventArgs e)
        {
            str = "";
            CreditMode = 1;
            btn_cash.BackColor = Color.DarkRed;
            btn_credit.BackColor = Color.Red;
            CashMode = 0;
            dgvswipemasters.Focus();
            if (dgvswipemasters.Rows.Count > 0 && dgvswipemasters.GetCellCount(DataGridViewElementStates.Selected) < 0)
            {
                MessageBox.Show("Please select Your Swiping Machine....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lbl_swiping.Text = Convert.ToString(dgvswipemasters.Rows[dgvswipemasters.CurrentCell.RowIndex].Cells["SwipeName"].Value);
            }
            else if (dgvswipemasters.Rows.Count < 0)
            {
                MessageBox.Show("No Swiping Machines Exists! Please Add....!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dgvswipemasters.GetCellCount(DataGridViewElementStates.Selected) == 0)
            {
                MessageBox.Show("Please select Your Swiping Machine....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txt_amount.Text = ""; 
            stcheck();
        }
        private int stcheck()
        {
            if (txt_card.Text.ToString() == "")
            {
                chk = 0;
            }
            else
            {
                chk = 1;
            }
            return chk;
        }
        public string str = "";
        private void btn_numeric_Click(object sender, EventArgs e)
         {
            //txt_amount.Focus();
            string numeric = ((Button)sender).Text.ToString();
            //if (txt_amount.Focused == false)
            //{
            //    str = "";   
            //}
            if (dgvswipemasters.SelectedCells.Count== 0 && CashMode==0&& CreditMode==1)
            {
                MessageBox.Show("Please select Your Swiping Machine....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_amount.Text = "";
                txt_amount.Focus();
            }
            if (txt_payable.Text == ""&& status !="invoice")
            {
                MessageBox.Show("Please Select Your Invoice For Your Cash Receipt....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
             if (numeric == "1")
            {
                str = str + "1";
            }
            else if (numeric == "2")
            {
                str = str + "2";
            }
            else if (numeric == "3")
            {
                str = str + "3";
            }
            else if (numeric == "4")
            {
                str = str + "4";
            }
            else if (numeric == "5")
            {
                str = str + "5";
            }
            else if (numeric == "6")
            {
                str = str + "6";
            }
            else if (numeric == "7")
            {
                str = str + "7";
            }
            else if (numeric == "8")
            {
                str = str + "8";
            }
            else if (numeric == "9")
            {
                str = str + "9";
            }
            else if (numeric == "0")
            {
                str = str + "0";
            }
            else if (numeric == ".")
            {
                if (!str.Contains("."))
                    str = str == "" ? "0." : str + ".";
            }
            if (status == "invoice")
            {
                txtInvoiceNumber.Text = str;
            }
            else
            {
                if (CashMode != 1 && CreditMode != 1)
                {
                    str = "";
                    MessageBox.Show("Please select CASH or CARD for your Payment ....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btn_cash.Focus();
                }
                else
                {
                    txt_amount.Text = str;
                    //txt_paid.Text =(Convert.ToDouble(txt_paid.Text + txt_amount.Text.ToString())).ToString();
                    txt_paid.Text = (Convert.ToDouble(txt_cash.Text.ToString() == "" ? "0" : txt_cash.Text.ToString()) + Convert.ToDouble(txt_card.Text.ToString() == "" ? "0" : txt_card.Text.ToString())).ToString();
                }
            }
            }
            //str = "";

        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (status == "invoice")
            {
                str = str == "" ? "" : str.Remove(str.Length - 1);
                txtInvoiceNumber.Text = str;
            }
            else
            {
                str = str == "" ? "" : str.Remove(str.Length - 1);
                txt_amount.Text = str;
                txt_paid.Text = str;
            }
           

        }
        private void Amountchange()
        {
            txt_change.Text = (Convert.ToDouble(txt_paid.Text.ToString() == "" ? "0" : txt_paid.Text.ToString()) - Convert.ToDouble(txt_payable.Text.ToString() == "" ? "0" : txt_payable.Text.ToString())).ToString("F2");
           // stcheck();
           // if (chk == 0 && CashMode == 1)
           //     txt_change.Text = (Convert.ToDouble(txt_amount.Text.ToString() == "" ? "0" : txt_amount.Text.ToString()) - Convert.ToDouble(txt_payable.Text.ToString() == "" ? "0" : txt_payable.Text.ToString())).ToString("F2");
           // else
           //     txt_change.Text = (Convert.ToDouble(txt_paid.Text.ToString() == "" ? "0" : txt_paid.Text.ToString()) - Convert.ToDouble(txt_payable.Text.ToString() == "" ? "0" : txt_payable.Text.ToString())).ToString("F2");
           ///// //txt_change.Text = ((Convert.ToDouble(txt_card.Text.ToString() == "" ? "0" : txt_card.Text.ToString()) + Convert.ToDouble(txt_cash.Text.ToString() == "" ? "0": txt_cash.Text.ToString()))   - Convert.ToDouble(txt_payable.Text.ToString() == "" ? "0" : txt_payable.Text.ToString())).ToString("F2");
        }
        private void checkamount()
        {
            if (CashMode == 1)
            {
                txt_cash.Text = (Convert.ToDouble(txt_amount.Text.ToString() == "" ? "0" : txt_amount.Text.ToString())).ToString();
            }
            else if (CreditMode == 1 && lbl_swiping.Text != "")
            {
                txt_card.Text = (Convert.ToDouble(txt_amount.Text.ToString() == "" ? "0" : txt_amount.Text.ToString()).ToString());    
            }
        }
        int amtst = 0;
        private void txt_amount_TextChanged(object sender, EventArgs e)
        {
            if (CashMode == 1 || CreditMode == 1 && dgvswipemasters.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                checkamount();
                Amountchange();
                
            }
            else
            {
                txt_amount.Text = ""; 
            }
        }
        private void checkpaymode()
        {
            if (Convert.ToDouble(txt_cash.Text.ToString() == "" ? "0" : txt_cash.Text.ToString()) > 0 && CashMode == 1)
            {
                billingclass.setpaymode = 1;
            }
            else if (Convert.ToDouble(txt_card.Text.ToString() == "" ? "0" : txt_card.Text.ToString()) > 0 && CreditMode == 1 && CashMode == 0)
            {
                billingclass.setpaymode = 2;
            }
            else if ((Convert.ToDouble(txt_cash.Text.ToString() == "" ? "0" : txt_cash.Text.ToString()) > 0 && CashMode == 1) && (Convert.ToDouble(txt_card.Text.ToString() == "" ? "0" : txt_card.Text.ToString()) > 0 && CreditMode == 1))
            {
                billingclass.setpaymode = 3;
            }
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            //billingclass.setcashamt = Convert.ToDouble(txt_cash.Text.ToString() == "" ? "0" : txt_cash.Text.ToString());
            //billingclass.setcardamt = Convert.ToString(txt_card.Text) == "" ? 0 : Convert.ToDouble(txt_card.Text);
            //billingclass.setpaidamt = Convert.ToDouble(txt_paid.Text.ToString() == "" ? "0" : txt_paid.Text.ToString());
            //billingclass.setpayableamt = Convert.ToDouble(txt_payable.Text == "" ? "0" : txt_payable.Text);
            //checkpaymode();

            if (((txt_cash.Text.ToString() == "") || txt_card.Text.ToString() == "")&& (txt_paid.Text.ToString() ==""))
            {
                st = "1";
                MessageBox.Show(" Please Recieve Your Cash Receipt Amount ....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            checkInvoiceAmount();
            if (st == "1")
                return;
            else
            {
                DataTable dti = new DataTable();
                dti = obj.UPDATETOUCHPAYMENTS(lbl_invoice.Text.ToString(), Convert.ToDouble(txt_cash.Text == "" ? "0" : txt_cash.Text), Convert.ToDouble(txt_card.Text == "" ? "0" : txt_card.Text));
                MessageBox.Show("Cash Receipt Received ....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fill();
                Clear();
                //if (st == "0")
                //    this.Close();
            }
        }
        private void Clear()
        {
            txtInvoiceNumber.Text = "";
            txt_card.Text = "0.00";
            txt_cash.Text = "0.00";
            txt_payable.Text = "0.00";
            txt_paid.Text = "0.00";
            txt_amount.Text="0.00";
            txt_change.Text = "0.00";

        }
        public string st = "0";
        private string checkInvoiceAmount()
        {
            if ((Convert.ToDouble(txt_paid.Text.ToString() == "" ? "0" : txt_paid.Text.ToString())) < (Convert.ToDouble(txt_payable.Text.ToString() == "" ? "0" : txt_payable.Text.ToString())))
            {
                MessageBox.Show("You Didn't Paid the correct Amount ....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                
                st = "1";
               

                //txt_amount.Text = "";
                //str = "";
                
                //txt_paid.Text = "";
            }
            else
                st = "0";
            return st;
        }
        private void dgvswipemasters_SelectionChanged(object sender, EventArgs e)
        {
            lbl_swiping.Text = Convert.ToString(dgvswipemasters.Rows[dgvswipemasters.CurrentCell.RowIndex].Cells["SwipeName"].Value);
            checkamount();
        }
        private void txt_cash_TextChanged(object sender, EventArgs e)
        {
            txt_paid.Text = (Convert.ToDouble(txt_cash.Text.ToString() == "" ? "0" : txt_cash.Text.ToString()) + Convert.ToDouble(txt_card.Text.ToString() == "" ? "0" : txt_card.Text.ToString())).ToString("F2");
        }
        private void txt_card_TextChanged(object sender, EventArgs e)
        {
            if (st != "1")
                txt_paid.Text = (Convert.ToDouble(txt_card.Text.ToString() == "" ? "0" : txt_card.Text.ToString())+Convert.ToDouble(txt_cash.Text.ToString() == "" ? "0" : txt_cash.Text.ToString())).ToString("F2");
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            str = "";
            if(dgvswipemasters.Rows.Count>0)
            dgvswipemasters.CurrentCell.Selected = false;
            CashMode = 0;
            CreditMode = 0;
            txt_cash.Text = "";
            txt_card.Text = "";
            txt_amount.Text = "";
            txt_change.Text = "";
            txt_paid.Text = "";
            str = "";
            lbl_swiping.Text = "";
            txt_payable.Text = "";
            txtInvoiceNumber.Text = "";
        }
        private void Payment_FormClosed(object sender, FormClosedEventArgs e)
        {    
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            //billingclass.setcashamt = 0;
            //billingclass.setcardamt = 0;
            //billingclass.paidamt = 0;
            this.Close();
        }
        private void dgvswipemasters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CreditMode == 1)
                str = "";
            else
            {
                MessageBox.Show("Please Select Card For Your Cash Receipt ....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void dgvswipemasters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CreditMode == 1)
                str = "";
            else
            {
                MessageBox.Show("Please Select Card For Your Cash Receipt ....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void btnload_Click(object sender, EventArgs e)
        {
            if (txtInvoiceNumber.Text == "")
            {
                MessageBox.Show("Please Enter The Invoice Number ....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable dts = new DataTable();
                dts = obj.TOUCHGETDETAILS(txtInvoiceNumber.Text.ToString(), 2);
                if (dts.Rows.Count > 0)
                {
                    btn_cash_Click(sender, e);
                    txt_payable.Text = dts.Rows[0]["totalnet"].ToString();
                    lbl_invoice.Text = txtInvoiceNumber.Text;
                    dataGridView1.ClearSelection();   
                }
                else
                    MessageBox.Show("Bill No, Doesn't Exists ....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                status = "";
                txtInvoiceNumber.Text = "";
                btn_cash_Click(sender, e);

            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dts = new DataTable();
            if (dataGridView1.Rows.Count > 0)
            {
                txt_change.Text = "0.00";
                txt_paid.Text = "0.00";
                txt_card.Text = "0.00";
                txt_cash.Text = "0.00";
                dts = obj.TOUCHGETDETAILS(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Column1"].Value.ToString(), 2);
                if (dts.Rows.Count > 0)
                {
                    btn_cash_Click(sender, e);
                    txt_payable.Text = dts.Rows[0]["totalnet"].ToString();
                    txtInvoiceNumber.Text = dts.Rows[0]["InvoiceNo"].ToString();
                    lbl_invoice.Text = dts.Rows[0]["InvoiceNo"].ToString();
                } 
            }
            btn_cash_Click(sender, e);
        }
        string status = "";
        private void txtInvoiceNumber_Click(object sender, EventArgs e)
        {
            str = "";
            status = "invoice";
            btn_cash.BackColor = Color.DarkRed;
        }

        private void txt_amount_Click(object sender, EventArgs e)
        {
            status = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dts = new DataTable();
            if (dataGridView1.Rows.Count > 0)
            {
                txt_change.Text = "0.00";
                txt_paid.Text = "0.00";
                txt_card.Text = "0.00";
                txt_cash.Text = "0.00";
                dts = obj.TOUCHGETDETAILS(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Column1"].Value.ToString(), 2);
                if (dts.Rows.Count > 0)
                {
                    btn_cash_Click(sender, e);
                    txt_payable.Text = dts.Rows[0]["totalnet"].ToString();
                    txtInvoiceNumber.Text = dts.Rows[0]["InvoiceNo"].ToString();
                }
                btn_cash_Click(sender, e);
            }
        }


        private void RefreshReceiptPage()
        {
            DataSet dt = new DataSet();
            dt = obj.GetSwipeMachine();
            for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
            {
                dgvswipemasters.Rows.Add();
                dgvswipemasters[0, i].Value = dt.Tables[0].Rows[i]["SwipeName"].ToString();
            }
            if (dgvswipemasters.Rows.Count > 0)
            {
                dgvswipemasters.CurrentCell.Selected = false;
            }
            fill();
            //billingclass.setpayableamt = Convert.ToDouble(txt_payable.Text.ToString());
            lbl_swiping.Text = "";
            btn_cash.PerformClick();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Clear();
            RefreshReceiptPage();
        }
       
    }
}
