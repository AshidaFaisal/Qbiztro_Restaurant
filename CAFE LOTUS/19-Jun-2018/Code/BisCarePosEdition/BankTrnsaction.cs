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
    public partial class BankTrnsaction : Form
    {
        public BankTrnsaction()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();

        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";

        public int idedit;
        public int isupdate = 0;
        public void clear()
        {
            txt_amt.Text = "0";
            txt_description.Text = string.Empty;
            gv_transaction.Rows.Clear();
            bttn_delete.Enabled = false;
            dtp_date.Value = DateTime.Now;
            cmb_editbank.SelectedIndex = 0;
            cmb_newbank.SelectedIndex = 0;
            cmb_newtype.SelectedIndex = 0;
            cmb_edittype.SelectedIndex = 0;
            cbox_bank.Checked = false;
            cbox_date.Checked = false;
            cbox_type.Checked = false;
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

        private void BankTrnsaction_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();

                int Intchk = obj.CheckInternetConnection();
                if (Intchk == 1)
                {
                    DataTable dt1 = new DataTable();
                    dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "BankTransaction");
                    SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
                    UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
                    DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();

                    DataSet ds = new DataSet();
                    ds = obj.LoadBankName();
                    cmb_newbank.DataSource = ds.Tables[0];
                    cmb_newbank.DisplayMember = "bank_name";
                    cmb_newbank.ValueMember = "bank_id";

                    DataRow dr = ds.Tables[0].NewRow();
                    dr["bank_name"] = "--Select One--";
                    dr["bank_id"] = "0";
                    ds.Tables[0].Rows.InsertAt(dr, 0);
                    cmb_newbank.SelectedIndex = 0;

                    DataSet ds1 = new DataSet();
                    ds1 = obj.LoadBankName();
                    cmb_editbank.DataSource = ds1.Tables[0];
                    cmb_editbank.DisplayMember = "bank_name";
                    cmb_editbank.ValueMember = "bank_id";

                    DataRow dr2 = ds1.Tables[0].NewRow();
                    dr2["bank_name"] = "--Select One--";
                    dr2["bank_id"] = "0";
                    ds1.Tables[0].Rows.InsertAt(dr2, 0);
                    cmb_editbank.SelectedIndex = 0;

                    cmb_newtype.SelectedIndex = 0;
                    cmb_edittype.SelectedIndex = 0;
                    cmb_editbank.Enabled = false;
                    cmb_edittype.Enabled = false;
                    dtp_startdate.Enabled = false;
                    dtp_enddate.Enabled = false;

                    bttn_delete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cbox_bank_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_bank.Checked == true)
                cmb_editbank.Enabled = true;
            else
                cmb_editbank.Enabled = false;
        }

        private void cbox_type_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_type.Checked == true)
                cmb_edittype.Enabled = true;
            else
                cmb_edittype.Enabled = false;
        }

        private void cbox_date_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_date.Checked == true)
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

        private void bttn_search_Click(object sender, EventArgs e)
        {
            try
            {
                int Intchk = obj.CheckInternetConnection();
                if (Intchk == 1)
                {
                    gv_transaction.Rows.Clear();
                    DataTable dt = new DataTable();
                    if ((cbox_date.Checked == false) && (cbox_type.Checked == false) && (cbox_bank.Checked == false))
                    {
                        MessageBox.Show("Please choose a searching type", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        //    if(@Mode=1)--by bank
                        if ((cbox_date.Checked == false) && (cbox_type.Checked == false) && (cbox_bank.Checked == true))
                        {
                            if (cmb_editbank.SelectedIndex > 0)
                            {
                                dt.Rows.Clear();
                                dt = obj.SearchBankTrans(Convert.ToInt32(cmb_editbank.SelectedValue), dtp_startdate.Value, dtp_enddate.Value, cmb_edittype.Text, 1);
                            }
                            else
                            {
                                MessageBox.Show("Please select a Bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmb_editbank.Focus();
                            }
                        }


                        //    if(@Mode=2)--by type
                        if ((cbox_date.Checked == false) && (cbox_type.Checked == true) && (cbox_bank.Checked == false))
                        {
                            if (cmb_edittype.SelectedIndex > 0)
                            {
                                dt.Rows.Clear();
                                dt = obj.SearchBankTrans(Convert.ToInt32(cmb_editbank.SelectedValue), dtp_startdate.Value, dtp_enddate.Value, cmb_edittype.Text, 2);
                            }
                            else
                            {
                                MessageBox.Show("Please select a Transaction Type", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmb_edittype.Focus();
                            }

                        }


                        //    if(@Mode=3)--by date
                        if ((cbox_date.Checked == true) && (cbox_type.Checked == false) && (cbox_bank.Checked == false))
                        {
                            dt.Rows.Clear();
                            dt = obj.SearchBankTrans(Convert.ToInt32(cmb_editbank.SelectedValue), dtp_startdate.Value, dtp_enddate.Value, cmb_edittype.Text, 3);

                        }


                        //    if(@Mode=4)--by bank and type
                        if ((cbox_date.Checked == false) && (cbox_type.Checked == true) && (cbox_bank.Checked == true))
                        {
                            if (cmb_editbank.SelectedIndex > 0)
                            {
                                if (cmb_edittype.SelectedIndex > 0)
                                {
                                    dt.Rows.Clear();
                                    dt = obj.SearchBankTrans(Convert.ToInt32(cmb_editbank.SelectedValue), dtp_startdate.Value, dtp_enddate.Value, cmb_edittype.Text, 4);
                                }
                                else
                                {
                                    MessageBox.Show("Please select a Type", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cmb_edittype.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please select a Bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmb_editbank.Focus();
                            }

                        }


                        //    if(@Mode=5)--by bank and date
                        if ((cbox_date.Checked == true) && (cbox_type.Checked == false) && (cbox_bank.Checked == true))
                        {
                            if (cmb_editbank.SelectedIndex > 0)
                            {
                                dt.Rows.Clear();
                                dt = obj.SearchBankTrans(Convert.ToInt32(cmb_editbank.SelectedValue), dtp_startdate.Value, dtp_enddate.Value, cmb_edittype.Text, 5);
                            }
                            else
                            {
                                MessageBox.Show("Please select a Bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmb_editbank.Focus();
                            }
                        }


                        //    if(@Mode=6)--by type and date
                        if ((cbox_date.Checked == true) && (cbox_type.Checked == true) && (cbox_bank.Checked == false))
                        {
                            if (cmb_edittype.SelectedIndex > 0)
                            {
                                dt.Rows.Clear();
                                dt = obj.SearchBankTrans(Convert.ToInt32(cmb_editbank.SelectedValue), dtp_startdate.Value, dtp_enddate.Value, cmb_edittype.Text, 6);
                            }
                            else
                            {
                                MessageBox.Show("Please select a Type", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmb_edittype.Focus();
                            }
                        }


                        //    if(@Mode=7)--by date, bank and type 
                        if ((cbox_date.Checked == true) && (cbox_type.Checked == true) && (cbox_bank.Checked == true))
                        {
                            if (cmb_editbank.SelectedIndex > 0)
                            {
                                if (cmb_edittype.SelectedIndex > 0)
                                {
                                    dt.Rows.Clear();
                                    dt = obj.SearchBankTrans(Convert.ToInt32(cmb_editbank.SelectedValue), dtp_startdate.Value, dtp_enddate.Value, cmb_edittype.Text, 7);
                                }
                                else
                                {
                                    MessageBox.Show("Please select a Type", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cmb_edittype.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please select a Bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmb_editbank.Focus();
                            }
                        }
                        //if (dt.Rows.Count < 1)
                        //{
                        //    MessageBox.Show("No Search Result Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                    }

                    if (dt.Rows.Count > 0)
                    {

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            gv_transaction.Rows.Add();
                            gv_transaction[0, i].Value = dt.Rows[i]["Trans_Id"].ToString();
                            gv_transaction[1, i].Value = dt.Rows[i]["Type"].ToString();
                            gv_transaction[2, i].Value = dt.Rows[i]["date"].ToString();
                            gv_transaction[3, i].Value = dt.Rows[i]["bank_name"].ToString();
                            gv_transaction[4, i].Value = dt.Rows[i]["Description"].ToString();
                            gv_transaction[5, i].Value = dt.Rows[i]["Amount"].ToString();
                            gv_transaction[6, i].Value = dt.Rows[i]["Bank_Id"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void gv_transaction_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    idedit = Convert.ToInt32(gv_transaction[0, e.RowIndex].Value);
                    dtp_date.Value = Convert.ToDateTime(gv_transaction[2, e.RowIndex].Value);
                    cmb_newtype.Text = gv_transaction[1, e.RowIndex].Value.ToString();
                    txt_description.Text = gv_transaction[4, e.RowIndex].Value.ToString();
                    cmb_newbank.SelectedValue = Convert.ToInt32(gv_transaction[6, e.RowIndex].Value);
                    txt_amt.Text = gv_transaction[5, e.RowIndex].Value.ToString();
                    isupdate = 1;
                    bttn_delete.Enabled = true;
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
                    if (cmb_newtype.SelectedIndex > 0)
                    {

                        if (Convert.ToInt32(cmb_newbank.SelectedValue) > 0)
                        {
                            if ((txt_amt.Text != "0") && (cmb_newtype.SelectedIndex > 0))
                            {
                                if (isupdate == 0)
                                {
                                    if (SaveStatus == "1")
                                    {
                                        string msg = obj.InsertBankTrans(Convert.ToInt32(cmb_newbank.SelectedValue), cmb_newtype.Text, dtp_date.Value, txt_description.Text, txt_amt.Text);
                                        if (msg == "Bank Transaction Succesfully Saved")
                                           // obj.SaveWindow(DateTime.Now, "Bank Transaction", File.ReadAllText("user.txt"), "Save");
                                        MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }

                                    else
                                    {
                                        MessageBox.Show("You Do Not Have The Permission To Save Bank Transaction", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    if (UpdateStatus == "1")
                                    {
                                        string msg = obj.UpdateBankTrans(idedit, Convert.ToInt32(cmb_newbank.SelectedValue), cmb_newtype.Text, dtp_date.Value, txt_description.Text, txt_amt.Text);
                                        if (msg == "Bank Transaction Successfully Updated")
                                            //obj.SaveWindow(DateTime.Now, "Bank Transaction", File.ReadAllText("user.txt"), "Update");
                                        MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        isupdate = 0;
                                    }
                                    else
                                    {
                                        MessageBox.Show("You Do Not Have The Permission To Update Bank Transaction", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }

                                DataSet ds = new DataSet();
                                ds = obj.LoadBankName();
                                cmb_newbank.DataSource = ds.Tables[0];
                                cmb_newbank.DisplayMember = "bank_name";
                                cmb_newbank.ValueMember = "bank_id";
                                DataRow dr = ds.Tables[0].NewRow();
                                dr["bank_name"] = "--Select--";
                                dr["bank_id"] = "0";
                                ds.Tables[0].Rows.InsertAt(dr, 0);
                                cmb_newbank.SelectedIndex = 0;

                                DataSet ds1 = new DataSet();
                                ds1 = obj.LoadBankName();
                                cmb_editbank.DataSource = ds1.Tables[0];
                                cmb_editbank.DisplayMember = "bank_name";
                                cmb_editbank.ValueMember = "bank_id";
                                DataRow dr2 = ds1.Tables[0].NewRow();
                                dr2["bank_name"] = "--Select One--";
                                dr2["bank_id"] = "0";
                                ds1.Tables[0].Rows.InsertAt(dr2, 0);
                                cmb_editbank.SelectedIndex = 0;
                                cmb_editbank.SelectedIndex = 0;
                                clear();
                            }


                        }
                        else
                        {
                            MessageBox.Show("Please Select Any BankName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmb_newbank.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select Any Type", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmb_newtype.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void bttn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int Intchk = obj.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (DeleteStatus == "1")
                    {
                        string msg = obj.DeleteBankTrans(idedit);
                        if (msg == "Transaction Details have been Successfully Deleted")
                           // obj.SaveWindow(DateTime.Now, "Bank Transaction", File.ReadAllText("user.txt"), "Delete");
                        MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isupdate = 0;

                        DataSet ds = new DataSet();
                        ds = obj.LoadBankName();
                        cmb_newbank.DataSource = ds.Tables[0];
                        cmb_newbank.DisplayMember = "bank_name";
                        cmb_newbank.ValueMember = "bank_id";
                        DataRow dr = ds.Tables[0].NewRow();
                        dr["bank_name"] = "--Select One--";
                        dr["bank_id"] = "0";
                        ds.Tables[0].Rows.InsertAt(dr, 0);
                        cmb_newbank.SelectedIndex = 0;


                        DataSet ds1 = new DataSet();
                        ds1 = obj.LoadBankName();
                        cmb_editbank.DataSource = ds1.Tables[0];
                        cmb_editbank.DisplayMember = "bank_name";
                        cmb_editbank.ValueMember = "bank_id";
                        DataRow dr1 = ds1.Tables[0].NewRow();
                        dr1["bank_name"] = "--Select One--";
                        dr1["bank_id"] = "0";
                        ds1.Tables[0].Rows.InsertAt(dr1, 0);

                        cmb_editbank.SelectedIndex = 0;
                        bttn_delete.Enabled = false;
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("You Do Not Have The Permission To Delete Bank Transaction", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            isupdate = 0;
            this.Close();
        }

        private void bttn_reset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txt_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void cmb_newtype_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_newtype.DroppedDown)
            {
                cmb_newtype.Focus();


            }
        }

        private void cmb_newbank_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_newbank.DroppedDown)
            {
                cmb_newbank.Focus();


            }
        }

        private void cmb_editbank_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_editbank.DroppedDown)
            {
                cmb_editbank.Focus();
            }
        }

        private void cbox_type_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_edittype.DroppedDown)
            {
                cmb_edittype.Focus();
            }
        }

        private void txt_amt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_amt.Text == "")
                {
                    txt_amt.Text = "0";
                }
                string Str = txt_amt.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {

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

        private void txt_description_TextChanged(object sender, EventArgs e)
        {
            //txt_description.SelectAll();
        }

        private void txt_amt_DoubleClick(object sender, EventArgs e)
        {
            txt_amt.SelectAll();
        }

        private void bttn_newcategory_Click(object sender, EventArgs e)
        {
            try
            {
                Bank bk = new Bank(1);
                bk.ShowDialog();

                int Intchk = obj.CheckInternetConnection();
                if (Intchk == 1)
                {
                    DataSet ds = new DataSet();
                    ds = obj.LoadBankName();
                    cmb_newbank.DataSource = ds.Tables[0];
                    cmb_newbank.DisplayMember = "bank_name";
                    cmb_newbank.ValueMember = "bank_id";
                    DataRow dr = ds.Tables[0].NewRow();
                    dr["bank_name"] = "--Select One--";
                    dr["bank_id"] = "0";
                    ds.Tables[0].Rows.InsertAt(dr, 0);
                    cmb_newbank.SelectedIndex = 0;

                    DataSet ds1 = new DataSet();
                    ds1 = obj.LoadBankName();
                    cmb_editbank.DataSource = ds1.Tables[0];
                    cmb_editbank.DisplayMember = "bank_name";
                    cmb_editbank.ValueMember = "bank_id";
                    DataRow dr1 = ds1.Tables[0].NewRow();
                    dr1["bank_name"] = "--Select One--";
                    dr1["bank_id"] = "0";
                    ds1.Tables[0].Rows.InsertAt(dr1, 0);

                    cmb_editbank.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
    }
}
