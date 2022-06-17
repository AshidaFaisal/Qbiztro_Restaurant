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
    public partial class searchReceiptvoucher : Form
    {
        public string rid;
        public int chk = 0;
        public int InvChk = 4;

        public searchReceiptvoucher()
        {
            InitializeComponent();
        }
        Codebehind objcode = new Codebehind();
        private void searchReceiptvoucher_Load(object sender, EventArgs e)
        {

           // ApplyTheme();

            chk = 0;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (Rb_Invoice.Checked == true && Rb_OldReceivable.Checked == false)
                    {
                        // Invoice
                        DataTable dt = new DataTable();
                        dt.Rows.Clear();
                        dgvEdit.Rows.Clear();

                        if (chk_customer.Checked == true && chkvoucherNo.Checked == false && chkDate.Checked == false)
                        {
                            if (cmb_editcustomer.SelectedIndex >= 0)
                            {
                                dt.Rows.Clear();
                                dt = objcode.getreceiptdetailsforedit(cmb_editcustomer.SelectedValue.ToString(), "", DateTime.Now, DateTime.Now, "0");// string                        
                            }
                        }
                        if (chk_customer.Checked == true && chkvoucherNo.Checked == true && chkDate.Checked == false)
                        {
                            if (cmb_editcustomer.SelectedIndex >= 0)
                            {
                                dt.Rows.Clear();
                                dt = objcode.getreceiptdetailsforedit(cmb_editcustomer.SelectedValue.ToString(), txt_editvoucherno.Text, DateTime.Now, DateTime.Now, "1");// string 
                            }

                        }
                        if (chk_customer.Checked == false && chkvoucherNo.Checked == true && chkDate.Checked == false)
                        {
                            dt.Rows.Clear();
                            dt = objcode.getreceiptdetailsforedit("", txt_editvoucherno.Text, DateTime.Now, DateTime.Now, "2");// string 

                        }
                        if (chk_customer.Checked == true && chkvoucherNo.Checked == false && chkDate.Checked == true)
                        {
                            if (cmb_editcustomer.SelectedIndex >= 0)
                            {
                                dt.Rows.Clear();
                                dt = objcode.getreceiptdetailsforedit(cmb_editcustomer.SelectedValue.ToString(), txt_editvoucherno.Text, dtfrom.Value, dtto.Value, "3");// string                 
                            }

                        }
                        if (chk_customer.Checked == true && chkvoucherNo.Checked == true && chkDate.Checked == true)
                        {
                            if (cmb_editcustomer.SelectedIndex >= 0)
                            {
                                dt.Rows.Clear();
                                dt = objcode.getreceiptdetailsforedit(cmb_editcustomer.SelectedValue.ToString(), txt_editvoucherno.Text, dtfrom.Value, dtto.Value, "4");// string 
                            }


                        }
                        if (chk_customer.Checked == false && chkvoucherNo.Checked == true && chkDate.Checked == true)
                        {
                            dt.Rows.Clear();
                            dt = objcode.getreceiptdetailsforedit("", txt_editvoucherno.Text, dtfrom.Value, dtto.Value, "5");// string                             
                        }

                        if (chk_customer.Checked == false && chkvoucherNo.Checked == false && chkDate.Checked == true)
                        {
                            dt.Rows.Clear();
                            dt = objcode.getreceiptdetailsforedit("", txt_editvoucherno.Text, dtfrom.Value, dtto.Value, "6");// string                 
                        }

                        if (dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                dgvEdit.Rows.Add();
                                dgvEdit[0, i].Value = dt.Rows[i]["VoucherDate"].ToString();
                                dgvEdit[1, i].Value = dt.Rows[i]["VoucherNo"].ToString();
                                dgvEdit[2, i].Value = dt.Rows[i]["OtherName"].ToString();
                                dgvEdit[3, i].Value = dt.Rows[i]["Amount"].ToString();
                                dgvEdit[4, i].Value = dt.Rows[i]["description"].ToString();
                                dgvEdit[5, i].Value = dt.Rows[i]["Paymode"].ToString();
                                dgvEdit[6, i].Value = dt.Rows[i]["Id"].ToString();
                                dgvEdit[7, i].Value = dt.Rows[i]["customer_id"].ToString();

                            }
                            InvChk = 1;

                        }
                        else
                            MessageBox.Show("No Search Results Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txt_editvoucherno.Text = "";

                    }
                  
                    if (Rb_Invoice.Checked == false && Rb_OldReceivable.Checked == true)
                    {
                        DataTable dt = new DataTable();
                        dt.Rows.Clear();
                        dgvEdit.Rows.Clear();

                        if (chk_customer.Checked == true && chkvoucherNo.Checked == false && chkDate.Checked == false)
                        {
                            if (cmb_editcustomer.SelectedIndex >= 0)
                            {
                                dt.Rows.Clear();
                                dt = objcode.GetReceiptOldReceiveDetailsForEdit(cmb_editcustomer.SelectedValue.ToString(), "", DateTime.Now, DateTime.Now, "0");// string                        
                            }
                        }
                        if (chk_customer.Checked == true && chkvoucherNo.Checked == true && chkDate.Checked == false)
                        {
                            if (cmb_editcustomer.SelectedIndex >= 0)
                            {
                                dt.Rows.Clear();
                                dt = objcode.GetReceiptOldReceiveDetailsForEdit(cmb_editcustomer.SelectedValue.ToString(), txt_editvoucherno.Text, DateTime.Now, DateTime.Now, "1");// string 
                            }

                        }
                        if (chk_customer.Checked == false && chkvoucherNo.Checked == true && chkDate.Checked == false)
                        {
                            dt.Rows.Clear();
                            dt = objcode.GetReceiptOldReceiveDetailsForEdit("", txt_editvoucherno.Text, DateTime.Now, DateTime.Now, "2");// string 

                        }
                        if (chk_customer.Checked == true && chkvoucherNo.Checked == false && chkDate.Checked == true)
                        {
                            if (cmb_editcustomer.SelectedIndex >= 0)
                            {
                                dt.Rows.Clear();
                                dt = objcode.GetReceiptOldReceiveDetailsForEdit(cmb_editcustomer.SelectedValue.ToString(), txt_editvoucherno.Text, dtfrom.Value, dtto.Value, "3");// string                 
                            }

                        }
                        if (chk_customer.Checked == true && chkvoucherNo.Checked == true && chkDate.Checked == true)
                        {
                            if (cmb_editcustomer.SelectedIndex >= 0)
                            {
                                dt.Rows.Clear();
                                dt = objcode.GetReceiptOldReceiveDetailsForEdit(cmb_editcustomer.SelectedValue.ToString(), txt_editvoucherno.Text, dtfrom.Value, dtto.Value, "4");// string 
                            }


                        }
                        if (chk_customer.Checked == false && chkvoucherNo.Checked == true && chkDate.Checked == true)
                        {
                            dt.Rows.Clear();
                            dt = objcode.GetReceiptOldReceiveDetailsForEdit("", txt_editvoucherno.Text, dtfrom.Value, dtto.Value, "5");// string                             
                        }

                        if (chk_customer.Checked == false && chkvoucherNo.Checked == false && chkDate.Checked == true)
                        {
                            dt.Rows.Clear();
                            dt = objcode.GetReceiptOldReceiveDetailsForEdit("", txt_editvoucherno.Text, dtfrom.Value, dtto.Value, "6");// string                 
                        }

                        if (dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                dgvEdit.Rows.Add();
                                dgvEdit[0, i].Value = dt.Rows[i]["VoucherDate"].ToString();
                                dgvEdit[1, i].Value = dt.Rows[i]["VoucherNo"].ToString();
                                dgvEdit[2, i].Value = dt.Rows[i]["OtherName"].ToString();
                                dgvEdit[3, i].Value = dt.Rows[i]["Amount"].ToString();
                                dgvEdit[4, i].Value = dt.Rows[i]["description"].ToString();
                                dgvEdit[5, i].Value = dt.Rows[i]["Paymode"].ToString();
                                dgvEdit[6, i].Value = dt.Rows[i]["Id"].ToString();
                                dgvEdit[7, i].Value = dt.Rows[i]["customer_id"].ToString();

                            }
                            InvChk = 3;

                        }
                        else
                            MessageBox.Show("No Search Results Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txt_editvoucherno.Text = "";

                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void dgvEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
                        ds = objcode.GetCustomer();
                        cmb_editcustomer.DataSource = ds.Tables[0];
                        cmb_editcustomer.DisplayMember = "customer_name";
                        cmb_editcustomer.ValueMember = "customer_id";
                        DataRow dr1 = ds.Tables[0].NewRow();
                        dr1["customer_name"] = "-- Select One --";
                        dr1["customer_id"] = "0";
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

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cbox_Dealer_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (Cbox_Dealer.Checked == true)
                {
                    Cmb_Dealer.Enabled = true;

                    DataSet ds = new DataSet();
                    ds = objcode.GetDealer();
                    Cmb_Dealer.DataSource = ds.Tables[0];
                    Cmb_Dealer.DisplayMember = "dealer_name";
                    Cmb_Dealer.ValueMember = "dealer_id";
                    //DataRow dr = ds.Tables[0].NewRow();
                    //dr["dealer_name"] = "--Select One--";
                    //dr["dealer_id"] = "0";
                    //ds.Tables[0].Rows.InsertAt(dr, 0);
                    Cmb_Dealer.SelectedValue = 0;
                }
                else
                    Cmb_Dealer.Enabled = false;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void txt_editvoucherno_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void cmb_editcustomer_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cmb_editcustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_editcustomer.DroppedDown)
                cmb_editcustomer.Focus();
        }

        private void txt_editvoucherno_DoubleClick(object sender, EventArgs e)
        {
            txt_editvoucherno.SelectAll();
        }

        private void dgvEdit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvEdit.RowCount > 0)
                {
                    int rindex = dgvEdit.CurrentCell.RowIndex;
                    rid = dgvEdit.Rows[rindex].Cells[6].Value.ToString();
                    string vno = dgvEdit.Rows[rindex].Cells[1].Value.ToString();
                    string amt = dgvEdit.Rows[rindex].Cells[3].Value.ToString();
                    string desc = dgvEdit.Rows[rindex].Cells[4].Value.ToString();
                    string paymode = dgvEdit.Rows[rindex].Cells[5].Value.ToString();
                    int custid = Convert.ToInt32(dgvEdit.Rows[rindex].Cells[7].Value.ToString());
                    string custname = dgvEdit.Rows[rindex].Cells[2].Value.ToString();
                    chk = 1;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }


    }
}
