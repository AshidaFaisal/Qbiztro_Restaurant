using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Data.SqlClient;

namespace BisCarePosEdition
{
    public partial class Dealer : Form
    {
        public Dealer()
        {
            InitializeComponent();
        }
        int chk;
        public Dealer(int i)
        {
            InitializeComponent();
            chk = i;
        }
        Codebehind obj = new Codebehind();
        int f = 0;

        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        public void clear()
        {
            txt_address.Text = string.Empty;
            txt_cstno.Text = string.Empty;
            txt_dealername.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_fax.Text = string.Empty;
            txt_openingbalance.Text = string.Empty;
            txt_phno.Text = string.Empty;
            txt_tinno.Text = string.Empty;
            txt_openingbalance.Text = "0";
            txt_CreditPeriod.Text = "0";
            string drr = obj.GetDealSt();
            if (drr == "1")
            {
                SqlDataReader dr3 = obj.GetDealCodeAuto();
                if (dr3.Read())
                {
                    txt_DealerCode.Text = dr3[0].ToString();
                    txt_DealerCode.Enabled = false;
                }

            }
            else
            {
                txt_DealerCode.Enabled = true;
                txt_DealerCode.Text = string.Empty;
            }
            button3.Enabled = false;

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

       // int f = 0;
        private void Dealer_Load(object sender, EventArgs e)
        {
            try{
                ApplyTheme();
            int Intchk = obj.CheckInternetConnection();
            if (Intchk == 1)
            {
                string drr = obj.GetDealSt();
                if (drr == "1")
                {
                    SqlDataReader dr3 = obj.GetDealCodeAuto();
                    if (dr3.Read())
                    {
                        txt_DealerCode.Text = dr3[0].ToString();
                        txt_DealerCode.Enabled = false;
                    }

                }
                else
                {
                    txt_DealerCode.Enabled = true;
                    txt_DealerCode.Text = string.Empty;
                }
                DataTable dt1 = new DataTable();
                dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "Dealer");
                SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
                UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
                DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();
                button3.Enabled = false;
                DataSet ds = new DataSet();
                ds = obj.GetDealer();
                cmb_dealername.DataSource = ds.Tables[0];
                cmb_dealername.DisplayMember = "dealer_name";
                cmb_dealername.ValueMember = "dealer_id";
                DataRow dr = ds.Tables[0].NewRow();
                dr["dealer_name"] = "--Select One--";
                dr["dealer_id"] = "0";
                ds.Tables[0].Rows.InsertAt(dr, 0);
                cmb_dealername.SelectedIndex = 0;
                Rb_new.Checked = true;
                txt_openingbalance.Text = "0";
                cmb_dealername.Enabled = false;
                f = 1;

            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }


        private void Rb_new_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_new.Checked == true)
            {
                cmb_dealername.Enabled = false;
                if (f == 1)
                {
                    cmb_dealername.SelectedIndex = 0;
                }

                clear();
                string drr = obj.GetDealSt();
                if (drr == "1")
                {
                    SqlDataReader dr3 = obj.GetDealCodeAuto();
                    if (dr3.Read())
                    {
                        txt_DealerCode.Text = dr3[0].ToString();
                        txt_DealerCode.Enabled = false;
                    }

                }
                else
                {
                    txt_DealerCode.Enabled = true;
                    txt_DealerCode.Text = string.Empty;
                }

            }
        }

        private void Rb_edit_CheckedChanged(object sender, EventArgs e)
        {
            try{
            //int Intchk = obj.CheckInternetConnection();
            //if (Intchk == 1)
            //{
                if (Rb_edit.Checked == true)
                {
                    cmb_dealername.Enabled = true;
                    clear();

                    DataSet ds = new DataSet();
                    ds = obj.GetDealer();
                    cmb_dealername.DataSource = ds.Tables[0];
                    cmb_dealername.DisplayMember = "dealer_name";
                    cmb_dealername.ValueMember = "dealer_id";
                    DataRow dr = ds.Tables[0].NewRow();
                    dr["dealer_name"] = "--Select One--";
                    dr["dealer_id"] = "0";
                    ds.Tables[0].Rows.InsertAt(dr, 0);
                    cmb_dealername.SelectedIndex = 0;
                    //Rb_new.Checked = true;
                    txt_openingbalance.Text = "0";
                    txt_DealerCode.Text = "";
                }
           // }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try{
            int Intchk = obj.CheckInternetConnection();
            if (Intchk == 1)
            {
                if (Rb_new.Checked == true)
                {
                    if (SaveStatus == "1")
                    {
                        if (txt_dealername.Text == string.Empty)
                        {
                            MessageBox.Show("Please Enter Dealer Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_dealername.Focus();
                        }
                           
                        else
                        {
                            if (txt_DealerCode.Text == string.Empty)
                            {
                                MessageBox.Show("Please Enter Dealer Code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_DealerCode.Focus();
                            }
                            else
                            {
                                string msg = obj.InsertDealer(txt_dealername.Text, txt_address.Text, txt_phno.Text, txt_email.Text, txt_fax.Text, txt_tinno.Text, txt_cstno.Text, txt_openingbalance.Text, "", "1", txt_DealerCode.Text, txt_CreditPeriod.Text);
                                if (msg == "0")
                                {
                                    MessageBox.Show("Dealer Name Already Exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    //obj.SaveWindow(DateTime.Now, "Dealer", File.ReadAllText("user.txt"), "Save");
                                    MessageBox.Show("Dealer Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (chk == 1)
                                    {
                                        this.Close();
                                    }
                                    string drr = obj.GetDealSt();
                                    if (drr == "1")
                                    {
                                        SqlDataReader dr3 = obj.GetDealCodeAuto();
                                        if (dr3.Read())
                                        {
                                            txt_DealerCode.Text = dr3[0].ToString();
                                            txt_DealerCode.Enabled = false;
                                        }

                                    }
                                    else
                                    {
                                        txt_DealerCode.Enabled = true;
                                        txt_DealerCode.Text = string.Empty;
                                    }

                                    DataSet ds = new DataSet();
                                    ds = obj.GetDealer();
                                    cmb_dealername.DataSource = ds.Tables[0];
                                    cmb_dealername.DisplayMember = "dealer_name";
                                    cmb_dealername.ValueMember = "dealer_id";

                                    DataRow dr = ds.Tables[0].NewRow();
                                    dr["dealer_name"] = "--Select One--";
                                    dr["dealer_id"] = "0";
                                    ds.Tables[0].Rows.InsertAt(dr, 0);
                                    cmb_dealername.SelectedIndex = 0;
                                    clear();
                                }
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("You Do Not Have The Permission To Save", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else
                {
                    if ((Rb_edit.Checked == true) && (cmb_dealername.SelectedIndex > 0))
                    {
                        if (UpdateStatus == "1")
                        {
                            if (txt_dealername.Text == string.Empty)
                            {
                                MessageBox.Show("Please Enter Dealer Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_dealername.Focus();
                            }
                            else
                            {
                                if (txt_DealerCode.Text == string.Empty)
                                {
                                    MessageBox.Show("Please Enter Dealer Code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txt_DealerCode.Focus();
                                }
                                else
                                {
                                    string msg = obj.InsertDealer(txt_dealername.Text, txt_address.Text, txt_phno.Text, txt_email.Text, txt_fax.Text, txt_tinno.Text, txt_cstno.Text, txt_openingbalance.Text, cmb_dealername.SelectedValue.ToString(), "2", txt_DealerCode.Text, txt_CreditPeriod.Text);
                                    if (msg == "1")
                                    {
                                        //obj.SaveWindow(DateTime.Now, "Dealer", File.ReadAllText("user.txt"), "Update");
                                        MessageBox.Show("Dealer Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        if (chk == 1)
                                        {
                                            this.Close();
                                        }

                                        DataSet ds = new DataSet();
                                        ds = obj.GetDealer();
                                        cmb_dealername.DataSource = ds.Tables[0];
                                        cmb_dealername.DisplayMember = "dealer_name";
                                        cmb_dealername.ValueMember = "dealer_id";

                                        DataRow dr = ds.Tables[0].NewRow();
                                        dr["dealer_name"] = "--Select One--";
                                        dr["dealer_id"] = "0";
                                        ds.Tables[0].Rows.InsertAt(dr, 0);
                                        cmb_dealername.SelectedIndex = 0;
                                        clear();
                                    }

                                    else
                                    {
                                        MessageBox.Show("Dealer Name Already Exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("You Do Not Have The Permission To Update Dealer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please Select A Dealer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmb_dealername.Focus();
                    }
                }
                //cmb_dealername.Text = "....select...";
                //Rb_new.Checked = true;

            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_dealername_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
            int Intchk = obj.CheckInternetConnection();
            if (Intchk == 1)
            {
                if (f == 1)
                {
                    clear();
                    DataTable dt = obj.selectdealer(cmb_dealername.SelectedValue.ToString());
                    if (dt.Rows.Count > 0)
                    {
                        txt_dealername.Text = dt.Rows[0]["dealer_name"].ToString();
                        txt_DealerCode.Text = dt.Rows[0]["DealerCode"].ToString();
                        txt_address.Text = dt.Rows[0]["address"].ToString();
                        txt_cstno.Text = dt.Rows[0]["cst_no"].ToString();
                        txt_email.Text = dt.Rows[0]["email"].ToString();
                        txt_fax.Text = dt.Rows[0]["fax"].ToString();
                        txt_openingbalance.Text = dt.Rows[0]["opening_balance"].ToString();
                        txt_phno.Text = dt.Rows[0]["phno"].ToString();
                        txt_tinno.Text = dt.Rows[0]["tin_no"].ToString();
                        txt_CreditPeriod.Text = dt.Rows[0]["CreditPeriod"].ToString();
                        button3.Enabled = true;
                    }
                }
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_phno_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }
        public void FloatValueValidatePhoneNum(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_openingbalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        private void txt_dealername_Enter(object sender, EventArgs e)
        {

            if (rd_arabic.Checked == true)
            {
                keybd_event(0x12, 0, 0, 0);//alt
                keybd_event(0xA0, 0, 0, 0);//shift
                keybd_event(0x12, 0, 2, 0);//alt
                keybd_event(0xA0, 0, 2, 0);//shift

            }
        }

        private void txt_address_Enter(object sender, EventArgs e)
        {

            if (rd_arabic.Checked == true)
            {
                keybd_event(0x12, 0, 0, 0);//alt
                keybd_event(0xA0, 0, 0, 0);//shift
                keybd_event(0x12, 0, 2, 0);//alt
                keybd_event(0xA0, 0, 2, 0);//shift

            }
        }

        private void txt_dealername_Leave(object sender, EventArgs e)
        {
            if (rd_arabic.Checked == true)
            {
                keybd_event(0x12, 0, 0, 0);//alt
                keybd_event(0xA0, 0, 0, 0);//shift
                keybd_event(0x12, 0, 2, 0);//alt
                keybd_event(0xA0, 0, 2, 0);//shift
            }
        }

        private void txt_address_Leave(object sender, EventArgs e)
        {
            if (rd_arabic.Checked == true)
            {
                keybd_event(0x12, 0, 0, 0);//alt
                keybd_event(0xA0, 0, 0, 0);//shift
                keybd_event(0x12, 0, 2, 0);//alt
                keybd_event(0xA0, 0, 2, 0);//shift
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try{
            int Intchk = obj.CheckInternetConnection();
            if (Intchk == 1)
            {
                if (DeleteStatus == "1")
                {

                    if (cmb_dealername.SelectedIndex > 0)
                    {
                        try
                        {
                            int Stat=obj.DeleteDealer(cmb_dealername.SelectedValue.ToString());
                            if (Stat == 0)
                            {
                               // obj.SaveWindow(DateTime.Now, "Dealer", File.ReadAllText("user.txt"), "Delete");
                                MessageBox.Show("Deletion Successfull.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DataSet ds = new DataSet();
                                ds = obj.GetDealer();
                                cmb_dealername.DataSource = ds.Tables[0];
                                cmb_dealername.DisplayMember = "dealer_name";
                                cmb_dealername.ValueMember = "dealer_id";
                                //cmb_dealername.Text = "....select...";
                                Rb_new.Checked = true;
                                txt_openingbalance.Text = "0";
                                DataRow dr = ds.Tables[0].NewRow();
                                dr["dealer_name"] = "--Select One--";
                                dr["dealer_id"] = "0";
                                ds.Tables[0].Rows.InsertAt(dr, 0);
                                cmb_dealername.SelectedIndex = 0;
                                clear();
                                string drr = obj.GetDealSt();
                                if (drr == "1")
                                {
                                    SqlDataReader dr3 = obj.GetDealCodeAuto();
                                    if (dr3.Read())
                                    {
                                        txt_DealerCode.Text = dr3[0].ToString();
                                        txt_DealerCode.Enabled = false;
                                    }

                                }
                                else
                                {
                                    txt_DealerCode.Enabled = true;
                                    txt_DealerCode.Text = string.Empty;
                                }
                               // txt_DealerCode.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("This dealer is already in use. So you cannot delete this dealer.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch
                        {

                           // MessageBox.Show("You Cannot Delete This Dealer.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select Dealer Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmb_dealername.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("You Do Not Have The Permission To Delete Dealer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }


        private void txt_openingbalance_TextChanged(object sender, EventArgs e)
        {
            if (txt_openingbalance.Text == string.Empty)
            {
                txt_openingbalance.Text = "0";
            }
        }

        private void cmb_dealername_KeyDown(object sender, KeyEventArgs e)
        {
            try{

            if (e.KeyData == Keys.F1)
            {
                DealerSearch Obj = new DealerSearch();
                Obj.ShowDialog();
                if (Obj.dr == DialogResult.OK)
                {
                    cmb_dealername.SelectedValue = Obj.id;
                    txt_dealername.Focus();
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

        private void txt_fax_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidatePhoneNum(e);
        }

        private void cmb_dealername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_dealername.DroppedDown)
                cmb_dealername.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear();
            Rb_new.Checked = true;

        }

    }
}

