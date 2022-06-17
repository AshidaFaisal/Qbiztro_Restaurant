using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace BisCarePosEdition 
{
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();
        }
        int chk;
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        public Bank(int i)
        {
            InitializeComponent();
            chk = i;
        }
        Codebehind objcode = new Codebehind();
        public void clear()
        {
            txt_address.Text = string.Empty;
            txt_name.Text = string.Empty;
            txt_branch.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_phno.Text = string.Empty;
            txt_accno.Text = string.Empty;
            txt_opening.Text = "0";
        }
        int f = 0;
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
        MyClass cls = new MyClass();
        private void Bank_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();


                cls.Numerictxt(txt_accno);
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    DataTable dt1 = new DataTable();
                    dt1 = objcode.GetFormUserRights(File.ReadAllText("user.txt"), "Bank");
                    SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
                    UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
                    DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();
                    rb_new.Checked = true;
                    DataSet ds = new DataSet();
                    ds = objcode.GetBank();
                    cmb_bankname.DataSource = ds.Tables[0];
                    cmb_bankname.DisplayMember = "bank_name";
                    cmb_bankname.ValueMember = "bank_id";
                    button1.Enabled = false;
                    btn_save.Enabled = true;
                    DataRow dr = ds.Tables[0].NewRow();
                    dr["bank_name"] = "--Select One--";
                    dr["bank_id"] = "0";
                    ds.Tables[0].Rows.InsertAt(dr, 0);
                    cmb_bankname.SelectedIndex = 0;
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
                    if (rb_new.Checked == true)
                    {

                        if (SaveStatus == "1")
                        {
                            if (txt_name.Text == string.Empty)
                            {
                                MessageBox.Show("Please enter bank name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_name.Focus();
                            }
                            else
                            {
                                if (txt_branch.Text == string.Empty)
                                {
                                    MessageBox.Show("Please enter branch", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txt_branch.Focus();
                                }
                                else
                                {

                                    if (txt_phno.Text == string.Empty)
                                    {
                                        MessageBox.Show("Please enter phone number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txt_phno.Focus();
                                    }
                                    else
                                    {
                                        if (txt_accno.Text == string.Empty)
                                        {
                                            MessageBox.Show("Please enter  A/C No.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            txt_accno.Focus();
                                            return;
                                        }
                                        

                                        string msg = objcode.InsertBank(txt_name.Text, txt_branch.Text, txt_address.Text, txt_email.Text, txt_phno.Text, txt_opening.Text, txt_accno.Text);
                                        if (msg == "Bank successfully saved")
                                            objcode.SaveWindow(DateTime.Now, "Bank", File.ReadAllText("user.txt"), "Save");
                                        MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        DataSet ds = new DataSet();
                                        ds = objcode.GetBank();
                                        cmb_bankname.DataSource = ds.Tables[0];
                                        cmb_bankname.DisplayMember = "bank_name";
                                        cmb_bankname.ValueMember = "bank_id";

                                        DataRow dr = ds.Tables[0].NewRow();
                                        dr["bank_name"] = "--Select One--";
                                        dr["bank_id"] = "0";
                                        ds.Tables[0].Rows.InsertAt(dr, 0);
                                        cmb_bankname.SelectedIndex = 0;
                                        clear();
                                        if (chk == 1)
                                            this.Close();
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("You do not have the permission to save bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if ((rb_edit.Checked == true) && (cmb_bankname.SelectedIndex > 0))
                        {
                            if (UpdateStatus == "1")
                            {
                                if (txt_name.Text == string.Empty)
                                {
                                    MessageBox.Show("Please enter bank name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txt_name.Focus();
                                }
                                else
                                {
                                    if (txt_branch.Text == string.Empty)
                                    {
                                        MessageBox.Show("Please enter branch", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txt_branch.Focus();
                                    }
                                    else
                                    {

                                        if (txt_phno.Text == string.Empty)
                                        {
                                            MessageBox.Show("Please enter phone number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            txt_phno.Focus();
                                        }
                                        else
                                        {
                                            if (txt_accno.Text == string.Empty)
                                            {
                                                MessageBox.Show("Please enter  A/C No.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                txt_phno.Focus();
                                                return;
                                            }

                                            string msg = objcode.UpdateBank(cmb_bankname.SelectedValue.ToString(), txt_name.Text, txt_branch.Text, txt_address.Text, txt_email.Text, txt_phno.Text, txt_opening.Text, txt_accno.Text);
                                            if (msg == "Bank Successfully Updated")
                                                objcode.SaveWindow(DateTime.Now, "Bank", File.ReadAllText("user.txt"), "Update");
                                            MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            DataSet ds = new DataSet();
                                            ds = objcode   .GetBank();
                                            cmb_bankname.DataSource = ds.Tables[0];
                                            cmb_bankname.DisplayMember = "bank_name";
                                            cmb_bankname.ValueMember = "bank_id";

                                            DataRow dr = ds.Tables[0].NewRow();
                                            dr["bank_name"] = "--Select--";
                                            dr["bank_id"] = "0";
                                            ds.Tables[0].Rows.InsertAt(dr, 0);
                                            cmb_bankname.SelectedIndex = 0;
                                            clear();
                                            if (chk == 1)
                                                this.Close();
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("You do not have the permission to update bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select a bank name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmb_bankname.Focus();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void rb_new_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_new.Checked == true)
            {
                cmb_bankname.Enabled = false;
                button1.Enabled = false;
                btn_save.Enabled = true;
                clear();
            }
        }

        private void rb_edit_CheckedChanged(object sender, EventArgs e)
        {
            cmb_bankname.SelectedIndex = 0;
            if (rb_edit.Checked == true)
            {
                cmb_bankname.Enabled = true;
                btn_save.Enabled = true;
                button1.Enabled = true;
                DataSet ds = new DataSet();
                ds = objcode.GetBank();
                cmb_bankname.DataSource = ds.Tables[0];
                cmb_bankname.DisplayMember = "bank_name";
                cmb_bankname.ValueMember = "bank_id";

                DataRow dr = ds.Tables[0].NewRow();
                dr["bank_name"] = "--Select--";
                dr["bank_id"] = "0";
                ds.Tables[0].Rows.InsertAt(dr, 0);
                cmb_bankname.SelectedIndex = 0;
            }
        }

        private void cmb_bankname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (f == 1)
                    {
                        clear();
                        DataTable dt = new DataTable();
                        dt = objcode.EditBank(cmb_bankname.SelectedValue.ToString());
                        if (dt.Rows.Count > 0)
                        {
                            txt_name.Text = dt.Rows[0]["bank_name"].ToString();
                            txt_branch.Text = dt.Rows[0]["branch"].ToString();
                            txt_address.Text = dt.Rows[0]["address"].ToString();
                            txt_email.Text = dt.Rows[0]["email"].ToString();
                            txt_phno.Text = dt.Rows[0]["phoneno"].ToString();
                            txt_opening.Text = dt.Rows[0]["openingBal"].ToString();
                            txt_accno.Text = dt.Rows[0]["Accno"].ToString();
                            btn_save.Enabled = true;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void FloatValueValidatePhoneNum(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void txt_phno_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
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
                        if (cmb_bankname.SelectedIndex > 0)
                        {
                            try
                            {
                                DialogResult dr1;
                                dr1 = MessageBox.Show("Do you want to delete this bank?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if (dr1 == DialogResult.Yes)
                                {
                                    int st = objcode.DeleteBank(cmb_bankname.SelectedValue.ToString());
                                    if (st == 0)
                                    {
                                        MessageBox.Show("Sorry, The bank is already in use. So you cannot delete this bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                    else
                                    {

                                        objcode.SaveWindow(DateTime.Now, "Bank", File.ReadAllText("user.txt"), "Deleted");
                                        MessageBox.Show("Bank deleted succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                    clear();
                                    DataSet ds = new DataSet();
                                    ds = objcode.GetBank();
                                    cmb_bankname.DataSource = ds.Tables[0];
                                    cmb_bankname.DisplayMember = "bank_name";
                                    cmb_bankname.ValueMember = "bank_id";

                                    DataRow dr = ds.Tables[0].NewRow();
                                    dr["bank_name"] = "--Select--";
                                    dr["bank_id"] = "0";
                                    ds.Tables[0].Rows.InsertAt(dr, 0);
                                    cmb_bankname.SelectedIndex = 0;
                                    clear();
                                }
                            }
                            catch
                            {

                                MessageBox.Show("Sorry, The bank is already in use. So you cannot delete this bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmb_bankname.Focus();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select a bank.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmb_bankname.Focus();
                        }
                        //MessageBox.Show("No Item Selected.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("You do not have the permission to delete bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }


        private void txt_opening_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_opening.Text == string.Empty)
                {
                    txt_opening.Text = "0";
                }
                string Str = txt_opening.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {

                }
                else
                {
                    MessageBox.Show("Invalid number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_opening.Text = "0";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_opening_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void cmb_bankname_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_bankname.DroppedDown)
            {
                cmb_bankname.Focus();
            }
        }

        private void txt_name_DoubleClick(object sender, EventArgs e)
        {
            txt_name.SelectAll();
        }

        private void txt_branch_DoubleClick(object sender, EventArgs e)
        {
            txt_branch.SelectAll();
        }

        private void txt_email_DoubleClick(object sender, EventArgs e)
        {
            txt_email.SelectAll();
        }

        private void txt_address_DoubleClick(object sender, EventArgs e)
        {
            txt_address.SelectAll();
        }

        private void txt_phno_DoubleClick(object sender, EventArgs e)
        {
            txt_phno.SelectAll();
        }

        private void txt_opening_DoubleClick(object sender, EventArgs e)
        {
            txt_opening.SelectAll();
        }

        private void txt_phno_Validating(object sender, CancelEventArgs e)
        {

            //if (txt_phno.Text.Length == 12)
            //{
            //    String strcell = String.Empty;
            //    for (int i = 0; i < 12; i++)
            //    {
            //        if (Char.IsDigit(txt_phno.Text[i]))
            //        {

            //        }
            //        else
            //        {
            //            MessageBox.Show("Invalid cellNo");
            //            txt_phno.Text = "";
            //            break;
            //        }

            //    }

            //    //MessageBox.Show("you cell Number is valid:" + phone); 
            //}
            //else
            //{
            //    MessageBox.Show("CellNo Should Contain exactly 10 Digits");
            //} 


        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txt_email.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txt_email.Text))
                {
                    MessageBox.Show("Not in a frormat of gmail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_email.SelectAll();
                    txt_email.Text = "";
                    e.Cancel = true;
                }
            }
        }

        private void txt_accno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_phno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

