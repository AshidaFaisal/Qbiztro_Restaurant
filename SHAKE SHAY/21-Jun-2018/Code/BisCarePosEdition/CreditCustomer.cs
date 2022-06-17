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
    public partial class CreditCustomer : Form
    {
        public CreditCustomer()
        {
            InitializeComponent();
        }
        string payableamnt1;
        public CreditCustomer(string payable )
        {
            InitializeComponent();
            payableamnt1 = payable;
        }
        Codebehind objcode = new Codebehind();
        /// <summary>
        /// flag
        /// </summary>
        int f = 0;
        public void FloatValueValidate(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void CreditCustomer_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = objcode.GetCustomer();
            cmb_custname.DataSource = ds.Tables[0];
            cmb_custname.DisplayMember = "customer_name";
            cmb_custname.ValueMember = "customer_id";
          
            DataRow dr = ds.Tables[0].NewRow();
            dr["customer_name"] = "--Select One--";
            dr["customer_id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cmb_custname.SelectedIndex = 0;

            txt_payable.Text = payableamnt1;
            f = 1;
        }

        private void rd_credit_CheckedChanged(object sender, EventArgs e)
        {
            if (f == 1)
            {
                
                DataSet ds = new DataSet();
                ds = objcode.GetCustomer();
                cmb_custname.DataSource = ds.Tables[0];
                cmb_custname.DisplayMember = "customer_name";
                cmb_custname.ValueMember = "customer_id";

                DataRow dr = ds.Tables[0].NewRow();
                dr["customer_name"] = "--Select One--";
                dr["customer_id"] = "0";
                ds.Tables[0].Rows.InsertAt(dr, 0);
                cmb_custname.SelectedIndex = 0;

                f = 1;
            }

        }
        int g = 0;
        private void rd_staff_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_staff.Checked == true)
            {
                lbl_recevable.Text = "0.00";
                Lbl_credit.Text = "0.00";
                DataSet ds1 = new DataSet();
                ds1 = objcode.GetempName();
                cmb_custname.DataSource = ds1.Tables[0];
                cmb_custname.DisplayMember = "Name";
                cmb_custname.ValueMember = "Id";
                DataRow drr1 = ds1.Tables[0].NewRow();
                drr1["Name"] = "--Select One--";
                drr1["Id"] = "0";
                ds1.Tables[0].Rows.InsertAt(drr1, 0);
                cmb_custname.SelectedIndex = 0;
                g = 1;
            }
        }

        private void txt_paidamnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_payable_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_balance_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void cmb_custname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f == 1)
            {
                if (rd_credit.Checked == true)
                {
                    lbl_recevable.Text = "0.00";
                    Lbl_credit.Text = "0.00";
                    if (cmb_custname.SelectedIndex > 0)
                    {
                        DataTable dt = new DataTable();
                        dt = objcode.EditCustomer(cmb_custname.SelectedValue.ToString());
                        if (dt.Rows.Count > 0)
                        {
                            Lbl_credit.Text = dt.Rows[0]["CreditAmount"].ToString();
                        }
                        string s = objcode.GetCustBalance(cmb_custname.SelectedValue.ToString());
                        double sa = Convert.ToDouble(s);
                        lbl_recevable.Text = sa.ToString("F2");
                    }
                }
                else
                {
                    Lbl_credit.Text = "0.00";
                    lbl_recevable.Text = "0.00";
                }
            }
        }

        private void Lbl_credit_Click(object sender, EventArgs e)
        {

        }

        private void txt_paidamnt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Str = txt_paidamnt.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    if ((txt_paidamnt.Text != "") && (txt_paidamnt.Text != ""))
                    {
                        txt_balance.Text = (Convert.ToDouble(txt_payable.Text) - Convert.ToDouble(txt_paidamnt.Text)).ToString("F2");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_paidamnt.Text = "0.00";
                }


            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        public string custid;
        public DialogResult dr;
        public string custst;
        public string paidamnt;

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (rd_credit.Checked == true)
            {
               // paidamnt = "1";
                custst = "1";
               
            }
            else
            {
                custst = "2";
               
            }
            if (((rd_credit.Checked == true) && ((Convert.ToDouble(txt_payable.Text))-(Convert.ToDouble(txt_paidamnt.Text))<=(Convert.ToDouble(Lbl_credit.Text) - Convert.ToDouble(lbl_recevable.Text)))) || (rd_staff.Checked == true))
            {
                custid = cmb_custname.SelectedValue.ToString();
                paidamnt = txt_paidamnt.Text;
                dr = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Credit limit of the customer is " + Lbl_credit.Text+ ". Please reset the credit limit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dr = DialogResult.Cancel;
            }
        }
    }
}
