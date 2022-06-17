using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;

namespace BisCarePosEdition  
{
    public partial class SwipingMachine : Form
    {
        public SwipingMachine()
        {
            InitializeComponent();
        }

        Codebehind objcode = new Codebehind();
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void clear()
        {
            //cmb_bank.se = 0;
            //cmb_bank.SelectedIndex = 0;
            //txt_address.Text = string.Empty;
            txt_name.Text = string.Empty;
            txt_branch.Text = string.Empty;
            txt_Remarks.Text = string.Empty;
            txt_accno.Text = string.Empty;
            savemode = true;
            //txt_opening.Text = "0";
            
            DataSet ds1 = new DataSet();
            ds1 = objcode.GetBank();
            cmb_bank.DataSource = ds1.Tables[0];
            cmb_bank.DisplayMember = "bank_name";
            cmb_bank.ValueMember = "bank_id";
            //button1.Enabled = false;
            //btn_save.Enabled = true;

            DataRow dr1 = ds1.Tables[0].NewRow();
            dr1["bank_name"] = "--Select One--";
            dr1["bank_id"] = "0";
            ds1.Tables[0].Rows.InsertAt(dr1, 0);
            cmb_bank.SelectedIndex = 0;
           
        }
        bool savemode = true;
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

        private void SwipingMachine_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1 = objcode.GetFormUserRights(File.ReadAllText("user.txt"), "SwipingMachine");
            SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
            UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
            DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();

            ApplyTheme();

            rb_new.Checked = true;
            DataSet ds = new DataSet();
            ds = objcode.GetSwipeMachine();
            cmb_name.DataSource = ds.Tables[0];
            cmb_name.DisplayMember = "SwipeName";
            cmb_name.ValueMember = "SwipeId";
            button1.Enabled = false;
            btn_save.Enabled = true;

            DataRow dr = ds.Tables[0].NewRow();
            dr["SwipeName"] = "--Select One--";
            dr["Swipeid"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cmb_name.SelectedIndex = 0;
            //f = 1;
        }

        private void rb_new_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_new.Checked == true)
            {
                cmb_name.Enabled = false;
                button1.Enabled = false;
                btn_save.Enabled = true;
                clear();
                //cmb_name.SelectedIndex = 0;
            }
        }

        private void rb_edit_CheckedChanged(object sender, EventArgs e)
        {
            //cmb_name.SelectedIndex = 0;
            if (rb_edit.Checked == true)
            {
                cmb_name.Enabled = true;
                btn_save.Enabled = true;
                button1.Enabled = true;


                DataSet ds = new DataSet();
                ds = objcode.GetSwipeMachine();
                cmb_name.DataSource = ds.Tables[0];
                cmb_name.DisplayMember = "SwipeName";
                cmb_name.ValueMember = "SwipeId";
                button1.Enabled = false;
                btn_save.Enabled = true;

                DataRow dr = ds.Tables[0].NewRow();
                dr["SwipeName"] = "--Select One--";
                dr["Swipeid"] = "0";
                ds.Tables[0].Rows.InsertAt(dr, 0);
                cmb_name.SelectedIndex = 0;
                
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
                            if (savemode == true)
                            {
                                if (txt_name.Text == string.Empty)
                                {
                                    MessageBox.Show("Please enter name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txt_name.Focus();
                                    return;
                                }
                                if (cmb_bank.SelectedIndex <= 0)
                                {
                                    MessageBox.Show("Please enter bank name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cmb_bank.Focus();
                                }
                                else
                                {
                                    string msg = objcode.Save_Swiping_Machine("0", txt_name.Text, cmb_bank.SelectedValue.ToString(), txt_Remarks.Text, 0);
                                    if (msg == "Swipping machine successfully saved")
                                        objcode.SaveWindow(DateTime.Now, "Designation", File.ReadAllText("user.txt"), "Save");
                                    MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }

                            else
                            {
                                MessageBox.Show("You do not have the permission to save Swipping machine", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("You do not have the permission to save", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    else
                    {
                        if (rb_edit.Checked == true) 
                        {
                            if (UpdateStatus == "1")
                            {
                                if (savemode == true)
                                {
                                    if (txt_name.Text == string.Empty)
                                    {
                                        MessageBox.Show("Please select swiping machine", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txt_name.Focus();
                                        return;
                                    }
                                    if (cmb_bank.SelectedIndex <= 0)
                                    {
                                        MessageBox.Show("Please enter bank name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cmb_bank.Focus();
                                        return;
                                    }
                                    else
                                    {
                                        string msg = objcode.Save_Swiping_Machine(cmb_name.SelectedValue.ToString(), txt_name.Text, cmb_bank.SelectedValue.ToString(), txt_Remarks.Text, 1);

                                        objcode.SaveWindow(DateTime.Now, "Designation", File.ReadAllText("user.txt"), "Update");
                                        MessageBox.Show("Swipping machine successfully updated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        //else
                                        //{
                                        //    MessageBox.Show("This swipping machine name already exists.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        //     txt_name.Focus();
                                        //}
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("You do not have the permission to update swipping machine", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("You do not have the permission to update", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select swiping machine", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_name.Focus();
                            //}
                        }
                    }
                    DataSet ds = new DataSet();
                    ds = objcode.GetSwipeMachine();
                cmb_name.DataSource = ds.Tables[0];
                cmb_name.DisplayMember = "SwipeName";
                cmb_name.ValueMember = "SwipeId";
                button1.Enabled = false;
                btn_save.Enabled = true;

                DataRow dr = ds.Tables[0].NewRow();
                dr["SwipeName"] = "--Select One--";
                dr["Swipeid"] = "0";
                ds.Tables[0].Rows.InsertAt(dr, 0);
                cmb_name.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

       // MyClass cls = new MyClass()
            

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_name.SelectedIndex > 0)
            {
                try
                {
                    if (DeleteStatus == "1")
                    {
                        DialogResult dr1;
                        dr1 = MessageBox.Show("Do you want to delete swiping machine?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        
                        if (dr1 == DialogResult.Yes)
                        {
                            int st = objcode.Delete_SwipeMachine(cmb_name.SelectedValue.ToString());
                            if (st == 0)
                            {
                                MessageBox.Show("Sorry, Already in use. So you cannot delete this entry", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {

                                objcode.SaveWindow(DateTime.Now, "Bank", File.ReadAllText("user.txt"), "Deleted");
                                MessageBox.Show("Swiping machine deleted Succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            clear();
                            DataSet ds = new DataSet();
                            ds = objcode.GetSwipeMachine();
                            cmb_name.DataSource = ds.Tables[0];
                            cmb_name.DisplayMember = "SwipeName";
                            cmb_name.ValueMember = "SwipeId";

                            DataRow dr = ds.Tables[0].NewRow();
                            dr["SwipeName"] = "--Select--";
                            dr["SwipeId"] = "0";
                            ds.Tables[0].Rows.InsertAt(dr, 0);
                            cmb_name.SelectedIndex = 0;
                            clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You do not have permission to delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                    }
                }
                catch
                {

                    MessageBox.Show("Sorry, The bank is already in use. So you cannot delete this bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_name.Focus();

                }
            }
            else
            {
                MessageBox.Show("Please select a bank.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_name.Focus();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int f = 0;
        private void cmb_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_name.Enabled = true;
                //int Intchk = obj.CheckInternetConnection();
                //if (Intchk == 1)
                //{
                //    if (f == 1)
                //    {
                        clear();
                        DataTable dt = new DataTable();
                        dt = objcode.Edit_SwipeMaster(cmb_name.SelectedValue.ToString());
                        if (dt.Rows.Count > 0)
                        {
                            txt_name.Text = dt.Rows[0]["SwipeName"].ToString();
                            txt_branch.Text = dt.Rows[0]["branch"].ToString();

                            cmb_bank.SelectedValue = dt.Rows[0]["bankId"].ToString();
                            txt_accno.Text = dt.Rows[0]["AccNo"].ToString();
                            txt_Remarks.Text = dt.Rows[0]["Remarks"].ToString();

                            //txt_email.Text = dt.Rows[0]["email"].ToString();
                            //txt_phno.Text = dt.Rows[0]["phoneno"].ToString();
                            //txt_opening.Text = dt.Rows[0]["openingBal"].ToString();
                            btn_save.Enabled = true;
                            button1.Enabled = true;

                        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cmb_bank_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_accno.Text = "";
            txt_branch.Text = "";
            if (cmb_bank.SelectedIndex < 1)
                return;
            DataTable dt = new DataTable();
            dt = objcode.EditBank(cmb_bank.SelectedValue.ToString());
          
            if (dt.Rows.Count > 0)
            {
                txt_accno.Text = dt.Rows[0]["Accno"].ToString();
                txt_branch.Text = dt.Rows[0]["branch"].ToString();

            }

           

        }

        private void bttn_reset_Click(object sender, EventArgs e)
        {
            rb_new.Checked = true;
            cmb_name.SelectedIndex = 0;
            txt_name.Text = string.Empty;
            cmb_bank.SelectedIndex = 0;
            txt_Remarks.Text = string.Empty;
            txt_accno.Text = string.Empty;
            txt_branch.Text = string.Empty;
        }

        private void btn_Newbank_Click(object sender, EventArgs e)
        {
            Bank bk = new Bank();
            bk.ShowDialog();
            DataSet ds = new DataSet();
            ds = objcode.GetBank();
                cmb_bank.DataSource = ds.Tables[0];
                cmb_bank.DisplayMember = "bank_name";
                cmb_bank.ValueMember = "bank_id";
                button1.Enabled = false;
                btn_save.Enabled = true;
                DataRow dr = ds.Tables[0].NewRow();
                dr["bank_name"] = "--Select One--";
                dr["bank_id"] = "0";
                ds.Tables[0].Rows.InsertAt(dr, 0);
                cmb_bank.SelectedIndex = 0;
            
        }
    }
}
