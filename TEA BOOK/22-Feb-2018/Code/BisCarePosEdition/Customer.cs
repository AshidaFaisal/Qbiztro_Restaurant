using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace BisCarePosEdition
{
    public partial class Customer : Form
    {
        int chk = 0;
        public Customer()
        {
            InitializeComponent();
        }
        public Customer(int i)
        {
            InitializeComponent();
            chk = i;
        }
        Codebehind objcode = new Codebehind();
        int f = 0;
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        public void clear()
        {
            int Intchk = objcode.CheckInternetConnection();
            if (Intchk == 1)
            {
                DataSet ds = new DataSet();
                ds = objcode.GetCustomer();
                cmb_custname.DataSource = ds.Tables[0];
                cmb_custname.DisplayMember = "customer_name";
                cmb_custname.ValueMember = "customer_id";

                txt_openingbal.Text = "0";

                DataRow dr = ds.Tables[0].NewRow();
                dr["customer_name"] = "--Select One--";
                dr["customer_id"] = "0";
                ds.Tables[0].Rows.InsertAt(dr, 0);
                cmb_custname.SelectedIndex = 0;


                txt_customername.Text = string.Empty;
                txt_address.Text = string.Empty;
                txt_cstno.Text = string.Empty;
                txt_email.Text = string.Empty;
                txt_openingbal.Text = "0";
                txt_phno.Text = string.Empty;
                txt_tinno.Text = string.Empty;
                txt_CreditPeriod.Text = "0";

                string drr = objcode.GetCustSt();
                if (drr == "1")
                {
                    SqlDataReader dr3 = objcode.GetCustCodeAuto();
                    if (dr3.Read())
                    {
                        txt_custCode.Text = dr3[0].ToString();
                        txt_custCode.Enabled = false;
                    }

                }
                else
                {
                    txt_custCode.Enabled = true;
                    txt_custCode.Text = string.Empty;
                }
                button1.Enabled = false;
            }
        }
        public void FloatValueValidate(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;
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

        private void Customer_Load(object sender, EventArgs e)
        {
            try
            {

                ApplyTheme();

                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    string drr = objcode.GetCustSt();
                    if (drr == "1")
                    {
                        SqlDataReader dr3 = objcode.GetCustCodeAuto();
                        if (dr3.Read())
                        {
                            txt_custCode.Text = dr3[0].ToString();
                            txt_custCode.Enabled = false;
                        }

                    }
                    else
                    {
                        txt_custCode.Enabled = true;
                        txt_custCode.Text = string.Empty;
                    }
                    DataTable dt1 = new DataTable();
                    dt1 = objcode.GetFormUserRights(File.ReadAllText("user.txt"), "Customer");
                    SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
                    UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
                    DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();

                    button1.Enabled = false;
                    cmb_custname.Enabled = false;
                    Rb_new.Checked = true;
                    DataSet ds = new DataSet();
                    ds = objcode.GetCustomer();
                    cmb_custname.DataSource = ds.Tables[0];
                    cmb_custname.DisplayMember = "customer_name";
                    cmb_custname.ValueMember = "customer_id";

                    txt_openingbal.Text = "0";

                    DataRow dr = ds.Tables[0].NewRow();
                    dr["customer_name"] = "--Select One--";
                    dr["customer_id"] = "0";
                    ds.Tables[0].Rows.InsertAt(dr, 0);
                    cmb_custname.SelectedIndex = 0;

                    //cmb_custname.Enabled = false;
                    //txt_customername.Focus();

                    f = 1;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (Rb_new.Checked == true)
                    {

                        if (SaveStatus == "1")
                        {
                            if (txt_customername.Text == string.Empty)
                            {
                                MessageBox.Show("Please Enter Customername", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_customername.Focus();
                            }
                            else
                            {

                                if (txt_custCode.Text == string.Empty)
                                {
                                    MessageBox.Show("Please Enter Customer Code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txt_custCode.Focus();
                                }
                                else
                                {

                                    //if (txt_openingbal.Text == string.Empty)
                                    //{
                                    //    MessageBox.Show("Please Enter Opening Balance", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //    txt_openingbal.Focus();
                                    //}

                                    //else
                                    //{
                                    if (txt_customername.Text != string.Empty && txt_openingbal.Text != string.Empty)
                                    {
                                        string msg = objcode.InsertCustomer(txt_customername.Text, txt_address.Text, txt_phno.Text, txt_email.Text, txt_tinno.Text, txt_cstno.Text, Convert.ToString(txt_openingbal.Text), "", "1", txt_CreditPeriod.Text, txt_custCode.Text, txtCreditAmount.Text);

                                        if (msg == "0")
                                        {
                                            MessageBox.Show("Customer Code Already Exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            //objcode.SaveWindow(DateTime.Now, "Customer", File.ReadAllText("user.txt"), "Save");
                                            MessageBox.Show("Customer Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            if (chk == 1)
                                                this.Close();
                                            clear();

                                            string drr = objcode.GetCustSt();
                                            if (drr == "1")
                                            {
                                                SqlDataReader dr3 = objcode.GetCustCodeAuto();
                                                if (dr3.Read())
                                                {
                                                    txt_custCode.Text = dr3[0].ToString();
                                                    txt_custCode.Enabled = false;
                                                }

                                            }
                                            else
                                            {
                                                txt_custCode.Enabled = true;
                                                txt_custCode.Text = string.Empty;
                                            }
                                        }
                                    }

                                    //}
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("You Do Not Have The Permission To Save Customer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {

                        if (UpdateStatus == "1")
                        {
                            if (txt_customername.Text == string.Empty)
                            {
                                MessageBox.Show("Please Enter Customername", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_customername.Focus();
                            }
                            //     else
                            //{



                            //else if (txt_openingbal.Text == string.Empty)
                            //{
                            //    MessageBox.Show("Please Enter Opening Balance", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //    txt_openingbal.Focus();
                            //}
                            else if ((Rb_edit.Checked == true) && (cmb_custname.SelectedIndex > 0) && (txt_custCode.Text != string.Empty))
                            {
                                string msg = objcode.InsertCustomer(txt_customername.Text, txt_address.Text, txt_phno.Text, txt_email.Text, txt_tinno.Text, txt_cstno.Text, "0", cmb_custname.SelectedValue.ToString(), "2", txt_CreditPeriod.Text, txt_custCode.Text, txtCreditAmount.Text);
                                if (msg == "1")
                                {
                                    //objcode.SaveWindow(DateTime.Now, "Customer", File.ReadAllText("user.txt"), "Update");
                                    MessageBox.Show("Customer Sucessfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clear();
                                    if (chk == 1)
                                        this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("This Customer Code Already Exists.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txt_custCode.Focus();
                                }

                            }
                            else
                            {
                                if ((cmb_custname.SelectedIndex <= 0))
                                {
                                    MessageBox.Show("Please Select Customer Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cmb_custname.Focus();
                                }
                                else
                                {
                                    if (txt_custCode.Text == string.Empty)
                                    {
                                        MessageBox.Show("Please Enter Customer Code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txt_custCode.Focus();
                                    }
                                }

                            }
                        }

                        else
                        {
                            MessageBox.Show("You Do Not Have The Permission To Update Customer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

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
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {

                    if (DeleteStatus == "1")
                    {
                        if (cmb_custname.SelectedIndex > 0)
                        {
                            try
                            {
                                int Stat = objcode.DeleteCustomer(cmb_custname.SelectedValue.ToString());
                                if (Stat == 0)
                                {
                                    // objcode.SaveWindow(DateTime.Now, "Coustemer", File.ReadAllText("user.txt"), "Delete");
                                    MessageBox.Show("Deletion Successfull.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                    clear();
                                    //string drr = objcode.GetCustSt();
                                    //if (drr == "1")
                                    //{
                                    //    SqlDataReader dr3 = objcode.GetCustCodeAuto();
                                    //    if (dr3.Read())
                                    //    {
                                    //        txt_custCode.Text = dr3[0].ToString();
                                    //        txt_custCode.Enabled = false;
                                    //    }

                                    //}
                                    //else
                                    //{
                                    //    txt_custCode.Enabled = true;
                                    //    txt_custCode.Text = string.Empty;
                                    //}
                                    txt_custCode.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("This customer is already in use. So you cannot delete this customer.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            catch (Exception ex)
                            {
                                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Select A Customer.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmb_custname.Focus();
                        }
                    }

                    else
                    {
                        MessageBox.Show("You Do Not Have The Permission To Delete Customer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_CreditPeriod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_CreditPeriod.Text == "")
                {
                    txt_CreditPeriod.Text = "0";
                }
                string Str = txt_CreditPeriod.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {

                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_CreditPeriod.Text = "0";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_CreditPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void cmb_custname_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.F1)
                {
                    CustomerSearch Obj = new CustomerSearch();
                    Obj.ShowDialog();
                    if (Obj.dr == DialogResult.OK)
                    {
                        cmb_custname.SelectedValue = Obj.id;
                        txt_customername.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cmb_custname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_custname.DroppedDown)
                cmb_custname.Focus();

        }

        private void txtCreditAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txtCreditAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtCreditAmount.Text == String.Empty)
            {
                txtCreditAmount.Text = "0";
            }
            string Str = txtCreditAmount.Text.Trim();
            double Num;
            bool isNum = double.TryParse(Str, out Num);
            if (!isNum)
            {
                MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCreditAmount.Text = "0";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear();
            Rb_new.Checked = true;
            button1.Enabled = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rb_new_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_new.Checked == true)
            {
                cmb_custname.Enabled = false;
                txt_customername.Focus();
            }
        }

        private void Rb_edit_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_edit.Checked == true)
            {
                cmb_custname.Enabled = true;
                cmb_custname.Focus();
            }
        }

        private void cmb_custname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (f == 1)
                    {
                        txt_customername.Text = string.Empty;
                        txt_address.Text = string.Empty;
                        txt_cstno.Text = string.Empty;
                        txt_email.Text = string.Empty;
                        txt_openingbal.Text = "0";
                        txt_phno.Text = string.Empty;
                        txt_tinno.Text = string.Empty;
                        txt_CreditPeriod.Text = "0";
                        txtCreditAmount.Text = "0";
                        txt_custCode.Text = "";
                        if (cmb_custname.SelectedIndex != 0)
                        {
                            DataTable dt = new DataTable();
                            dt = objcode.EditCustomer(cmb_custname.SelectedValue.ToString());
                            txt_customername.Text = dt.Rows[0]["customer_name"].ToString();
                            txt_address.Text = dt.Rows[0]["address"].ToString();
                            txt_cstno.Text = dt.Rows[0]["cst_no"].ToString();
                            txt_email.Text = dt.Rows[0]["email"].ToString();
                            txt_openingbal.Text = dt.Rows[0]["opening_balance"].ToString();
                            txt_phno.Text = dt.Rows[0]["phone"].ToString();
                            txt_tinno.Text = dt.Rows[0]["tin_no"].ToString();
                            txt_CreditPeriod.Text = dt.Rows[0]["CreditPeriod"].ToString();
                            txt_custCode.Text = dt.Rows[0]["CustomerCode"].ToString();
                            txtCreditAmount.Text = dt.Rows[0]["CreditAmount"].ToString();

                            button1.Enabled = true;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_phno_TextChanged(object sender, EventArgs e)
        {

        }

        //private void txt_phno_MouseLeave(object sender, EventArgs e)
        //{

        //    if (txt_phno.CausesValidation)
        //    {
        //        MessageBox.Show("please enter 10 digit phone number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }
        //}

        private void txt_phno_KeyDown(object sender, KeyEventArgs e)
        {
            //if (txt_phno.Text == ToString())
            //{

            //    if (txt_phno.CausesValidation)
            //    {
            //        MessageBox.Show("please enter 10 digit phone number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    }
            //}
        }

        private void txt_phno_Validating(object sender, CancelEventArgs e)
        {
        //    ErrorProvider e1 = new ErrorProvider();
        //    Regex regex = new Regex("^[0-9]*$");
        //    if (regex.IsMatch(txt_phno.Text))
        //    {

        //        e1.SetError(txt_phno, String.Empty);
        //    }
        //    else
        //    {
        //        e1.SetError(txt_phno,
        //              "Only numbers may be entered here");
        //    }

        }
        public void FloatValueValidatePhoneNum(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar ==8)

                //MessageBox.Show(" enter your 10 digit phone number","message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_phno_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidatePhoneNum(e);

        }

        


    }
    }

