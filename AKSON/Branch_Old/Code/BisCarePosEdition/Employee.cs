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
using System.Drawing.Text;
using System.Drawing.Drawing2D;

namespace BisCarePosEdition
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        Codebehind obj = new Codebehind();
        
        DataTable dtDocs = new DataTable();

       

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

        private void Employee_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
                tab_Doccuments.BackColor = Color.FromArgb(Convert.ToInt32(Theme.FormColor));
                tab_emp.BackColor = Color.FromArgb(Convert.ToInt32(Theme.FormColor));
                tab_sl.BackColor = Color.FromArgb(Convert.ToInt32(Theme.FormColor));
                
                    DataTable dt1 = new DataTable();
                    dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "Employee");
                    SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
                    UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
                    DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();
                    DataSet ds3 = new DataSet();
                    ds3 = obj.GetDesignation();
                    cmb_designation.DataSource = ds3.Tables[0];
                    cmb_designation.DisplayMember = "designation_name";
                    cmb_designation.ValueMember = "designation_id";
                    DataRow dre = ds3.Tables[0].NewRow();
                    dre["designation_name"] = "--Select One--";
                    dre["designation_id"] = "0";
                    ds3.Tables[0].Rows.InsertAt(dre, 0);
                    cmb_designation.SelectedIndex = 0;

                    DataSet ds2 = new DataSet();
                    ds2 = obj.GetCountry();
                    cmb_country.DataSource = ds2.Tables[0];
                    cmb_country.DisplayMember = "Country";
                    cmb_country.ValueMember = "Id";
                    DataRow drr2 = ds2.Tables[0].NewRow();
                    drr2["Country"] = "--Select One--";
                    drr2["Id"] = "0";
                    ds2.Tables[0].Rows.InsertAt(drr2, 0);
                    cmb_country.SelectedIndex = 0;

                    string empstat = obj.GetEmpstatus();
                    if (empstat == "1")
                    {
                        SqlDataReader dss = obj.Getempcode();
                        dss.Read();
                        txt_empcode.Text = dss[0].ToString();
                        txt_empcode.Enabled = false;
                    }
                    else
                    {
                        txt_empcode.Text = "";
                        txt_empcode.Enabled = true;
                    }


                    gv_holidys.Rows.Clear();
                    DataTable dt = new DataTable();
                    dt = obj.getworkindays();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        gv_holidys.Rows.Add();
                        gv_holidys[0, i].Value = i + 1;
                        DataGridViewComboBoxCell ComboColumn = (DataGridViewComboBoxCell)(gv_holidys.Rows[i].Cells[4]);
                        DataSet ds = new DataSet();
                        ds = obj.Getempholidaystat();
                        ComboColumn.DataSource = ds.Tables[0];
                        ComboColumn.DisplayMember = "HolidayStat";
                        ComboColumn.ValueMember = "Id";
                        gv_holidys[2, i].Value = dt.Rows[i]["Id"].ToString();
                        gv_holidys[1, i].Value = dt.Rows[i]["Day"].ToString();
                        //gv_holidys[4, i].Value = dt.Rows[i]["HolidayStat"].ToString();
                        bool tr = Convert.ToBoolean(gv_holidys[3, i].Value);
                    }
                    DataSet ds1 = new DataSet();
                    ds1 = obj.GetempName();
                    cmb_emp.DataSource = ds1.Tables[0];
                    cmb_emp.DisplayMember = "Name";
                    cmb_emp.ValueMember = "Id";
                    DataRow drr1 = ds1.Tables[0].NewRow();
                    drr1["Name"] = "--Select One--";
                    drr1["Id"] = "0";
                    ds1.Tables[0].Rows.InsertAt(drr1, 0);
                    cmb_emp.SelectedIndex = 0;
                    rd_new.Checked = true;
                    //cmb_emp.Enabled = false;
                    //cmb_emp.SelectedIndex = 0;
                    btn_update.Enabled = false;
                    // bn_update.Enabled = false;
                    //btn_updte1.Enabled = false;
                    btn_save.Enabled = true;
                    // btn_save1.Enabled = true;
                    bn_save.Enabled = true;
                    gv_holidys.Visible = true;
                    gv_holidaystat.Visible = false;
                    btn_chnge.Visible = false;
                    btn_delete.Enabled = false;


                    txt_basicsalary.Text = "0";
                    txt_hra.Text = "0";
                    txt_other.Text = "0";
                    txt_transportation.Text = "0";
                    txt_Reminder.Text = "0";

                    dtDocs.Columns.Add("Document", typeof(string));
                    dtDocs.Columns.Add("Attachment", typeof(byte[]));
                    dtDocs.Columns.Add("Reminder", typeof(int));
                    dtDocs.Columns.Add("ExpiryDate", typeof(DateTime));
                    dtDocs.Columns.Add("ReminderBefore", typeof(int));

                    string FilePath = AppDomain.CurrentDomain.BaseDirectory + "Default Image.jpg";

                    fop.FileName = FilePath;
                    pb_photo.ImageLocation = fop.FileName;
                    btnclear();
                    clear();
                   
                
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        public void btnclear()
        {
            btn_update.Enabled = false;
            btn_save.Enabled = true;
            btn_delete.Enabled = false;
            btn_chnge.Visible = false;
            gv_holidys.Visible = true;
            gv_holidaystat.Visible = false;
        }
        
        public void clear()
        {


            DataSet ds1 = new DataSet();
            ds1 = obj.GetempName();
            cmb_emp.DataSource = ds1.Tables[0];
            cmb_emp.DisplayMember = "Name";
            cmb_emp.ValueMember = "Id";
            DataRow drr1 = ds1.Tables[0].NewRow();
            drr1["Name"] = "--Select One--";
            drr1["Id"] = "0";
            ds1.Tables[0].Rows.InsertAt(drr1, 0);
            cmb_emp.SelectedIndex = 0;


                txt_basicsalary.Text = "0";
                //txt_designation.Text = "";
                cmb_designation.SelectedIndex = 0;
                txt_DoccumentName.Text = "";
                // txt_empcode.Text = "";
                txt_empid.Text = "";
                txt_hra.Text = "0";
                txt_mobile.Text = "";
                txt_name.Text = "";
                cmb_country.SelectedIndex = 0;
                txt_other.Text = "0";
                txt_phone.Text = "";
                txt_previousexp.Text = "";
                txt_qualificatn.Text = "";
                txt_Reminder.Text = "0";
                txt_total.Text = "0";
                txt_transportation.Text = "0";
                txt_workinghrs.Text = "";
                txt_Reminder.Text = "0";
                pb_photo.Image = null;
                gv_Attachment.Rows.Clear();
                gv_holidaystat.Rows.Clear();
                gv_holidys.Rows.Clear();
                DataTable dt = new DataTable();
                dt = obj.getworkindays();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    gv_holidys.Rows.Add();
                    gv_holidys[0, i].Value = i + 1;
                    DataGridViewComboBoxCell ComboColumn = (DataGridViewComboBoxCell)(gv_holidys.Rows[i].Cells[4]);
                    DataSet ds = new DataSet();
                    ds = obj.Getempholidaystat();
                    ComboColumn.DataSource = ds.Tables[0];
                    ComboColumn.DisplayMember = "HolidayStat";
                    ComboColumn.ValueMember = "Id";
                    gv_holidys[2, i].Value = dt.Rows[i]["Id"].ToString();
                    gv_holidys[1, i].Value = dt.Rows[i]["Day"].ToString();
                    // gv_holidys[4, i].Value = dt.Rows[i]["HolidayStat"].ToString();
                    bool tr = Convert.ToBoolean(gv_holidys[3, i].Value);
                }

                string empstat = obj.GetEmpstatus();
                if (empstat == "1")
                {
                    SqlDataReader dss = obj.Getempcode();
                    dss.Read();
                    txt_empcode.Text = dss[0].ToString();
                    txt_empcode.Enabled = false;
                }
                else
                {
                    txt_empcode.Text = "";
                    txt_empcode.Enabled = true;
                }

               

              

            
        }
        private void tab_emp_Click(object sender, EventArgs e)
        {

        }

        private void tab_sl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fop.ShowDialog() == DialogResult.OK)
            {
                pb_photo.ImageLocation = fop.FileName;
                pb_photo.SizeMode = PictureBoxSizeMode.Zoom;
                pb_photo.Refresh();
            }
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gv_holidys_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string id;
        string gender;
        byte[] img;
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                
                    string chk = "0";
                    if (SaveStatus == "1")
                    {
                        string empstat = obj.GetEmpstatus();
                        if (empstat == "1")
                        {
                            chk = "1";
                        }
                        else
                        {
                            chk = obj.CheckEmpCode(txt_empcode.Text);
                        }
                        if (chk == "0")
                        {
                            MessageBox.Show("This Emp code already exists. Please try different one.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_empcode.Focus();
                        }
                        else
                        {

                            //if (txt_empid.Text != "")
                            //{
                                if (txt_empcode.Text != "")
                                {
                                    if (txt_name.Text != "")
                                    {
                                        if (cmb_country.SelectedIndex > 0)
                                        {
                                            if (cmb_designation.SelectedIndex > 0)
                                            {
                                                if (txt_mobile.Text != "")
                                                {
                                                    if (txt_workinghrs.Text != "0")
                                                    {

                                                        if (txt_basicsalary.Text != "0")
                                                        {
                                                            if (rd_male.Checked == true)
                                                            {
                                                                gender = "1";
                                                            }
                                                            if (rd_Female.Checked == true)
                                                            {
                                                                gender = "2";
                                                            }

                                                            //if (pb_photo.Image == null)
                                                            //{
                                                            //    MessageBox.Show("Please Add A Photo.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            //    tabControl1.SelectedTab = tab_emp;
                                                            //}
                                                            //else
                                                            //{

                                                            if (fop.FileName != "NoFile")
                                                            {
                                                                FileStream FS = new FileStream(fop.FileName, FileMode.Open, FileAccess.Read);
                                                                img = new byte[FS.Length];
                                                                FS.Read(img, 0, Convert.ToInt32(FS.Length));
                                                            }


                                                            id = obj.insertemp(txt_empid.Text.ToString() == "" ? "" : txt_empid.Text.ToString(),
                                                                txt_empcode.Text, txt_name.Text, "", dtp_dateofbirth.Value, cmb_country.SelectedValue.ToString(), gender, txt_qualificatn.Text, cmb_designation.SelectedValue.ToString(), dtp_joining.Value,
                                                                txt_workinghrs.Text, txt_mobile.Text, txt_phone.Text.ToString() == "" ? "" : txt_phone.Text.ToString(),
                                                                txt_previousexp.Text.ToString() == "" ? "" : txt_previousexp.Text.ToString(), img, "1" );
                                                            if (id == "0")
                                                            {
                                                                MessageBox.Show("Employee Code Already Exists.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                txt_empcode.Focus();
                                                            }
                                                            else
                                                            {
                                                                for (int s = 0; s < gv_holidys.Rows.Count; s++)
                                                                {
                                                                    if ((Convert.ToBoolean(gv_holidys[3, s].Value) == true) && (gv_holidys[4, s].Value != null))
                                                                    {
                                                                        obj.insertempholidy(id, gv_holidys[2, s].Value.ToString(), gv_holidys[4, s].Value.ToString());
                                                                    }
                                                                }
                                                                if (dtDocs.Rows.Count > 0)
                                                                {
                                                                    for (int i = 0; i < dtDocs.Rows.Count; i++)
                                                                    {
                                                                        byte[] Atchmt = (byte[])dtDocs.Rows[i]["Attachment"];
                                                                        obj.InsertEmpDoccument(id, dtDocs.Rows[i]["Document"].ToString(), Atchmt, dtDocs.Rows[i]["Reminder"].ToString(), Convert.ToDateTime(dtDocs.Rows[i]["ExpiryDate"]), dtDocs.Rows[i]["ReminderBefore"].ToString());
                                                                    }
                                                                }
                                                                obj.InsertempSal(id, txt_basicsalary.Text, txt_hra.Text, txt_transportation.Text, txt_other.Text, txt_total.Text);
                                                                //obj.SaveWindow(DateTime.Now, "Employee", File.ReadAllText("user.txt"), "Save");
                                                                MessageBox.Show("Employee Details Successfully Saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                clear();
                                                            
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Please Enter Basic Salary.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            tabControl1.SelectedTab = tab_sl;
                                                            txt_basicsalary.Focus();
                                                        }
                                                    }

                                                    else
                                                    {
                                                        MessageBox.Show("Please Enter Working Hours.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        tabControl1.SelectedTab = tab_emp;
                                                        txt_workinghrs.Focus();

                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please Enter Mobile No.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    txt_mobile.Focus();

                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please Select A Designation.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                cmb_designation.Focus();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please Select A Country.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cmb_country.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please Enter Employee Name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txt_name.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please Enter Employee Code.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txt_empcode.Focus();
                                }
                            //}
                            //else
                            //{
                            //    MessageBox.Show("Please Enter Employee ID.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //    txt_empid.Focus();
                            //}
                                empflag = 1;
                            DataSet ds1 = new DataSet();
                            ds1 = obj.GetempName();
                            cmb_emp.DataSource = ds1.Tables[0];
                            cmb_emp.DisplayMember = "Name";
                            cmb_emp.ValueMember = "Id";
                            DataRow drr1 = ds1.Tables[0].NewRow();
                            drr1["Name"] = "--Select One--";
                            drr1["Id"] = "0";
                            ds1.Tables[0].Rows.InsertAt(drr1, 0);
                            cmb_emp.SelectedIndex = 0;
                            empflag = 0;

                            //
                        }
                    }
                    else
                    {
                        MessageBox.Show("You Do Not Have The Permission To Save Employee", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        int empflag = 0;
        public void FloatValueValidate(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;
        }

        public void FloatValueValidatePhoneNum(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidatePhoneNum(e);
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidatePhoneNum(e);
        }

        private void txt_workinghrs_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void rd_new_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
          
            //        if (rd_new.Checked == true)
            //        {
            //            cmb_emp.Enabled = false;
            //            btn_update.Enabled = false;
            //            //bn_update.Enabled = false;
            //            // btn_updte1.Enabled = false;
            //            btn_save.Enabled = true;
            //            //btn_save1.Enabled = true;
            //            bn_save.Enabled = true;
            //            gv_holidys.Visible = true;
            //            gv_holidaystat.Visible = false;
            //            btn_chnge.Visible = false;
            //            btn_delete.Enabled = false;
            //            clear();
            //            gv_holidys.Rows.Clear();
            //            DataTable dt = new DataTable();
            //            dt = obj.getworkindays();
            //            for (int i = 0; i < dt.Rows.Count; i++)
            //            {
            //                gv_holidys.Rows.Add();
            //                gv_holidys[0, i].Value = i + 1;
            //                DataGridViewComboBoxCell ComboColumn = (DataGridViewComboBoxCell)(gv_holidys.Rows[i].Cells[4]);
            //                DataSet ds = new DataSet();
            //                ds = obj.Getempholidaystat();
            //                ComboColumn.DataSource = ds.Tables[0];
            //                ComboColumn.DisplayMember = "HolidayStat";
            //                ComboColumn.ValueMember = "Id";
            //                gv_holidys[2, i].Value = dt.Rows[i]["Id"].ToString();
            //                gv_holidys[1, i].Value = dt.Rows[i]["Day"].ToString();
            //                // gv_holidys[4, i].Value = dt.Rows[i]["HolidayStat"].ToString();
            //                bool tr = Convert.ToBoolean(gv_holidys[3, i].Value);
            //            }
            //            string empstat = obj.GetEmpstatus();
            //            if (empstat == "1")
            //            {
            //                SqlDataReader dss = obj.Getempcode();
            //                dss.Read();
            //                txt_empcode.Text = dss[0].ToString();
            //                txt_empcode.Enabled = false;
            //            }
            //            else
            //            {
            //                txt_empcode.Text = "";
            //                txt_empcode.Enabled = true;
            //            }
            //        }
            //        if (rd_new.Checked == false)
            //        {
            //            cmb_emp.Enabled = true;
            //            btn_update.Enabled = true;
            //            //bn_update.Enabled = true;
            //            //btn_updte1.Enabled = true;
            //            btn_save.Enabled = false;
            //            // btn_save1.Enabled = false;
            //            bn_save.Enabled = true;
            //            gv_holidys.Visible = false;
            //            gv_holidaystat.Visible = true;
            //            btn_chnge.Visible = true;
            //            btn_delete.Enabled = true;
            //        }

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void rd_dit_CheckedChanged(object sender, EventArgs e)
        {
            //if (rd_dit.Checked == true)
            //{
            //    cmb_emp.Enabled = true;
            //    cmb_emp.SelectedIndex = 0;
            //    gv_holidys.Visible = false;
            //    gv_holidaystat.Visible = true;
            //    btn_chnge.Visible = true;
            //    btn_delete.Enabled = true;
            //    clear();

            //}
            //if (rd_dit.Checked == false)
            //{
            //    cmb_emp.Enabled = false;
            //    gv_holidys.Visible = true;
            //    gv_holidaystat.Visible = false;
            //    btn_chnge.Visible = false;
            //    btn_delete.Enabled = false;

            //}
        }

        private void rd_no_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tab_Doccuments_Click(object sender, EventArgs e)
        {

        }

        private void bn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string reminder;

        private void bn_save_Click(object sender, EventArgs e)
        {
            try
            {
           
                    if (txt_DoccumentName.Text != "")
                    {

                        if (rd_yes.Checked == true)
                        {
                            reminder = "1";
                        }
                        else
                        {
                            reminder = "2";
                            txt_Reminder.Text = "0";
                        }
                        if (pb_attacment.Image == null)
                        {
                            MessageBox.Show("Please Select An Attachment.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (fop1.FileName != "NoFile")
                            {
                                FileStream FS = new FileStream(fop1.FileName, FileMode.Open, FileAccess.Read);
                                img = new byte[FS.Length];
                                FS.Read(img, 0, Convert.ToInt32(FS.Length));
                            }

                            DataRow drDocrow = dtDocs.NewRow();
                            drDocrow["Document"] = txt_DoccumentName.Text;
                            drDocrow["Attachment"] = img;
                            drDocrow["Reminder"] = reminder;
                            drDocrow["ExpiryDate"] = dtp_expryDate.Value;
                            drDocrow["ReminderBefore"] = txt_Reminder.Text;
                            dtDocs.Rows.InsertAt(drDocrow, gv_Attachment.Rows.Count);
                            //for (int j = 0; j < dtDocs.Rows.Count; j++)
                            //{
                            gv_Attachment.Rows.Add();
                            int j = gv_Attachment.Rows.Count - 1;
                            gv_Attachment[0, j].Value = j + 1;
                            gv_Attachment[1, j].Value = dtDocs.Rows[j]["Document"].ToString();
                            gv_Attachment[2, j].Value = dtDocs.Rows[j]["ExpiryDate"].ToString();
                            gv_Attachment[3, j].Value = dtDocs.Rows[j]["ReminderBefore"].ToString();

                            //}
                            //ds5.Rows.InsertAt(drr1, 0);
                            //obj.InsertEmpDoccument(id, txt_DoccumentName.Text, img, reminder, dtp_expryDate.Value, txt_Reminder.Text);
                            //MessageBox.Show("Employe Doccument Successfully Inserted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //DataTable dt1 = new DataTable();
                            //dt1 = obj.GetempDoccument(cmb_emp.SelectedValue.ToString());
                            //gv_Attachment.Rows.Clear();
                            //for (int j = 0; j < dt1.Rows.Count; j++)
                            //{
                            //    gv_Attachment.Rows.Add();
                            //    gv_Attachment[1, j].Value = dt1.Rows[j]["Doccument"].ToString();
                            //    gv_Attachment[2, j].Value = dt1.Rows[j]["ExpiryDate"].ToString();
                            //    gv_Attachment[3, j].Value = dt1.Rows[j]["ReminderBefore"].ToString();
                            //    gv_Attachment[4, j].Value = dt1.Rows[j]["Id"].ToString();

                            //}
                            //for (int j = 0; j < gv_Attachment.Rows.Count; j++)
                            //{
                            //    gv_Attachment[0, j].Value = j + 1;
                            //    gv_Attachment[1, j].Value = txt_DoccumentName.Text;
                            //    gv_Attachment[2, j].Value = dtp_expryDate.Text;
                            //    gv_Attachment[3, j].Value = txt_Reminder.Text;

                            //}
                            txt_DoccumentName.Text = "";
                            txt_Reminder.Text = "";
                            rd_yes.Checked = true;
                            dtp_expryDate.Value = DateTime.Now;
                            pb_attacment.Image = null; 

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter A Doccument Name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_DoccumentName.Focus();
                    }
                
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }


        private void bn_browse_Click(object sender, EventArgs e)
        {
            if (fop1.ShowDialog() == DialogResult.OK)
            {
                pb_attacment.ImageLocation = fop1.FileName;
                pb_attacment.SizeMode = PictureBoxSizeMode.Zoom;
                pb_attacment.Refresh();
            }
        }

        private void rd_yes_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_yes.Checked == true)
            {
                txt_Reminder.Enabled = true;
            }
            if (rd_no.Checked == true)
            {
                txt_Reminder.Enabled = false;
            }
        }

        private void txt_Reminder_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_Reminder.Text == "")
                    txt_Reminder.Text = "0";
                string Str = txt_Reminder.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {

                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Reminder.Text = "0";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void btn_close1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save1_Click(object sender, EventArgs e)
        {
            //if (txt_basicsalary.Text != "0")
            //{
            //    obj.InsertempSal(id, txt_basicsalary.Text, txt_hra.Text, txt_transportation.Text, txt_other.Text, txt_total.Text);
            //    MessageBox.Show("Employee Salary Details successfully Inserted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Please Enter Basic Salary.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txt_basicsalary.Focus();
            //}

        }

        private void txt_hra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_hra.Text == "")
                {
                    txt_hra.Text = "0";
                }
                string Str = txt_hra.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    txt_total.Text = Convert.ToString((Convert.ToDouble(txt_basicsalary.Text)) + (Convert.ToDouble(txt_hra.Text)) + (Convert.ToDouble(txt_other.Text)) + (Convert.ToDouble(txt_transportation.Text)));
                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_hra.Text = "0";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void txt_basicsalary_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_basicsalary.Text == "")
                {
                    txt_basicsalary.Text = "0";
                }
                string Str = txt_basicsalary.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    txt_total.Text = Convert.ToString((Convert.ToDouble(txt_basicsalary.Text)) + (Convert.ToDouble(txt_hra.Text)) + (Convert.ToDouble(txt_other.Text)) + (Convert.ToDouble(txt_transportation.Text)));
                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_basicsalary.Text = "0";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void txt_transportation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_transportation.Text == "")
                {
                    txt_transportation.Text = "0";
                }

                string Str = txt_transportation.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    txt_total.Text = Convert.ToString((Convert.ToDouble(txt_basicsalary.Text)) + (Convert.ToDouble(txt_hra.Text)) + (Convert.ToDouble(txt_other.Text)) + (Convert.ToDouble(txt_transportation.Text)));
                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_transportation.Text = "0";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void txt_other_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_other.Text == "")
                {
                    txt_other.Text = "0";
                }
                string Str = txt_other.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    txt_total.Text = Convert.ToString((Convert.ToDouble(txt_basicsalary.Text)) + (Convert.ToDouble(txt_hra.Text)) + (Convert.ToDouble(txt_other.Text)) + (Convert.ToDouble(txt_transportation.Text)));

                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_other.Text = "0";
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
              
                    if (UpdateStatus == "1")
                    {
                        //if (txt_empid.Text != "")
                        //{
                            if (txt_empcode.Text != "")
                            {
                                if (cmb_emp.SelectedIndex > 0)
                                {
                                    if (txt_name.Text != "")
                                    {
                                        if (cmb_country.SelectedIndex > 0)
                                        {
                                            if (cmb_designation.SelectedIndex > 0)
                                            {
                                                if (txt_mobile.Text != "")
                                                {
                                                    if (txt_workinghrs.Text != "0")
                                                    {
                                                        if (txt_basicsalary.Text != "0")
                                                        {
                                                            if (rd_male.Checked == true)
                                                            {
                                                                gender = "1";
                                                            }
                                                            if (rd_Female.Checked == true)
                                                            {
                                                                gender = "2";
                                                            }
                                                            //if (pb_photo.Image == null)
                                                            //{
                                                            //    MessageBox.Show("Please Select An Image.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                            //}
                                                            //else
                                                            //{

                                                            if (fop.FileName != "NoFile")
                                                            {
                                                                FileStream FS = new FileStream(fop.FileName, FileMode.Open, FileAccess.Read);
                                                                img = new byte[FS.Length];
                                                                FS.Read(img, 0, Convert.ToInt32(FS.Length));
                                                            }


                                                          string s1=  obj.updateemp(cmb_emp.SelectedValue.ToString(), txt_empid.Text, txt_empcode.Text, txt_name.Text, dtp_dateofbirth.Value, cmb_country.SelectedValue.ToString(), gender, txt_qualificatn.Text, cmb_designation.SelectedValue.ToString(), dtp_joining.Value,
                                                                 txt_workinghrs.Text, txt_mobile.Text, txt_phone.Text, txt_previousexp.Text, img);

                                                          if (s1 == "0")
                                                          {
                                                              MessageBox.Show("Employee Code Already Exists.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                              txt_empcode.Focus();
                                                          }
                                                          else
                                                          {


                                                              obj.UpdateEmpSal(cmb_emp.SelectedValue.ToString(), txt_basicsalary.Text, txt_hra.Text, txt_transportation.Text, txt_other.Text, txt_total.Text);
                                                              if (gv_holidaystat.Visible == true)
                                                              {
                                                                  if (gv_holidaystat.Rows.Count > 0)
                                                                  {
                                                                      for (int s = 0; s < gv_holidaystat.Rows.Count; s++)
                                                                      {
                                                                          obj.insertempholidy(cmb_emp.SelectedValue.ToString(), gv_holidaystat[3, s].Value.ToString(), gv_holidaystat[4, s].Value.ToString());
                                                                      }
                                                                  }
                                                              }
                                                              else
                                                              {
                                                                  for (int sq = 0; sq < gv_holidys.Rows.Count; sq++)
                                                                  {
                                                                      if ((Convert.ToBoolean(gv_holidys[3, sq].Value) == true) && (gv_holidys[4, sq].Value != null))
                                                                      {
                                                                          obj.insertempholidy(cmb_emp.SelectedValue.ToString(), gv_holidys[2, sq].Value.ToString(), gv_holidys[4, sq].Value.ToString());
                                                                      }
                                                                  }
                                                              }
                                                              if (dtDocs.Rows.Count > 0)
                                                              {
                                                                  for (int i = 0; i < dtDocs.Rows.Count; i++)
                                                                  {
                                                                      byte[] Atchmt = (byte[])dtDocs.Rows[i]["Attachment"];
                                                                      obj.InsertEmpDoccument(cmb_emp.SelectedValue.ToString(), dtDocs.Rows[i]["Document"].ToString(), Atchmt, dtDocs.Rows[i]["Reminder"].ToString(), Convert.ToDateTime(dtDocs.Rows[i]["ExpiryDate"]), dtDocs.Rows[i]["ReminderBefore"].ToString());
                                                                  }
                                                              }
                                                             // obj.SaveWindow(DateTime.Now, "Employee", File.ReadAllText("user.txt"), "Update");
                                                              MessageBox.Show("Employee Details Successfuly Updated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                              clear();
                                                             // rd_new.Checked = true;
                                                              //}
                                                          }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Please Enter Basic Salary.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            txt_basicsalary.Focus();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please Enter Working Hours.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        txt_workinghrs.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please Enter Mobile No.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    txt_mobile.Focus();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please Enter Designation.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                cmb_designation.Focus();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please Select A Country.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cmb_country.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please Enter Employee Name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txt_name.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please Select An Employee.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                ///////////////
                            }
                            else
                            {
                                MessageBox.Show("Please Enter Employee Code.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_empcode.Focus();
                            }
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Please Enter Employee ID.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    txt_empid.Focus();
                        //}
                    }
                    else
                    {
                        MessageBox.Show("You Do Not Have The Permission To Update Employee", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        private void cmb_emp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (empflag == 0)
                {

                    SqlDataReader dr = obj.GetempDetails(cmb_emp.SelectedValue.ToString());
                    if (dr.Read())
                    {
                        txt_empid.Text = dr[1].ToString();
                        txt_empcode.Text = dr[2].ToString();
                        txt_name.Text = dr[3].ToString();
                        dtp_dateofbirth.Value= Convert.ToDateTime(dr[5].ToString());
                        cmb_country.SelectedValue = Convert.ToInt32(dr[6].ToString());
                        if (dr[7].ToString() == "1")
                        {
                            rd_male.Checked = true;
                        }
                        else
                        {
                            rd_Female.Checked = true;
                        }
                        txt_qualificatn.Text = dr[8].ToString();
                        cmb_designation.SelectedValue = dr[9].ToString();
                        dtp_joining.Text = dr[10].ToString();
                        txt_workinghrs.Text = dr[11].ToString();
                        txt_mobile.Text = dr[12].ToString();
                        txt_phone.Text = dr[13].ToString();
                        txt_previousexp.Text = dr[14].ToString();
                       
                        if (dr[15].ToString() != "")
                        {
                            img = (byte[])dr[15];
                            MemoryStream ms = new MemoryStream((byte[])dr[15]);
                            pb_photo.Image = Image.FromStream(ms);
                            pb_photo.SizeMode = PictureBoxSizeMode.Zoom;
                            pb_photo.Refresh();
                        }
                    }

                    DataTable dt1 = new DataTable();
                    dt1 = obj.GetempDoccument(cmb_emp.SelectedValue.ToString());
                    dtDocs.Rows.Clear();
                    gv_Attachment.Rows.Clear();
                    for (int j = 0; j < dt1.Rows.Count; j++)
                    {
                        DataRow drDocrow = dtDocs.NewRow();
                        drDocrow["Document"] = dt1.Rows[j]["Doccument"].ToString();
                        drDocrow["Attachment"] = (byte[])dt1.Rows[j]["Attachment"];
                        drDocrow["Reminder"] = dt1.Rows[j]["Reminder"].ToString();
                        drDocrow["ExpiryDate"] = dt1.Rows[j]["ExpiryDate"].ToString();
                        drDocrow["ReminderBefore"] = dt1.Rows[j]["ReminderBefore"].ToString();
                        dtDocs.Rows.InsertAt(drDocrow, j);
                        gv_Attachment.Rows.Add();
                        gv_Attachment[0, j].Value = j + 1;
                        gv_Attachment[1, j].Value = dt1.Rows[j]["Doccument"].ToString();
                        gv_Attachment[2, j].Value = dt1.Rows[j]["ExpiryDate"].ToString();
                        gv_Attachment[3, j].Value = dt1.Rows[j]["ReminderBefore"].ToString();
                        // gv_Attachment[4,j].Value=dt1.Rows[j]["Id"].ToString();

                    }
                    //SqlDataReader drr = obj.GetempDoccument(cmb_emp.SelectedValue.ToString());
                    //if (drr.Read())
                    //{
                    //    txt_DoccumentName.Text = drr[2].ToString();
                    //    if (drr[3].ToString() != "")
                    //    {
                    //        img = (byte[])drr[3];
                    //        MemoryStream ms = new MemoryStream((byte[])drr[3]);
                    //        pb_attacment.Image = Image.FromStream(ms);
                    //        pb_attacment.SizeMode = PictureBoxSizeMode.Zoom;
                    //        pb_attacment.Refresh();
                    //    }
                    //    dtp_expryDate.Text = drr[5].ToString();
                    //    if (drr[4].ToString() == "1")
                    //    {
                    //        rd_yes.Checked = true;
                    //    }
                    //    else
                    //    {
                    //        rd_no.Checked = true;
                    //        txt_Reminder.Enabled = false;
                    //    }


                    //        txt_Reminder.Text = drr[6].ToString();
                    //    }
                    SqlDataReader drs = obj.GetempSal(cmb_emp.SelectedValue.ToString());
                    if (drs.Read())
                    {
                        txt_basicsalary.Text = drs[2].ToString();
                        txt_hra.Text = drs[3].ToString();
                        txt_transportation.Text = drs[4].ToString();
                        txt_other.Text = drs[5].ToString();
                        txt_total.Text = drs[6].ToString();

                    }
                    DataTable dt = new DataTable();
                    dt = obj.getempHolidayStatusgv(cmb_emp.SelectedValue.ToString());
                    gv_holidaystat.Rows.Clear();
                    if (dt.Rows.Count > 0)
                    {
                        gv_holidaystat.Visible = true;
                        gv_holidys.Visible = false;
                        btn_chnge.Visible = true;
                        for (int d = 0; d < dt.Rows.Count; d++)
                        {
                            gv_holidaystat.Rows.Add();
                            gv_holidaystat[0, d].Value = dt.Rows[d]["Day"].ToString();
                            gv_holidaystat[1, d].Value = dt.Rows[d]["HolidayStat"].ToString();
                            gv_holidaystat[2, d].Value = dt.Rows[d]["Id"].ToString();
                            gv_holidaystat[3, d].Value = dt.Rows[d]["Dayid"].ToString();
                            gv_holidaystat[4, d].Value = dt.Rows[d]["HoldstId"].ToString();
                        }
                    }
                    else
                    {
                        gv_holidys.Visible = true;
                        gv_holidaystat.Visible = false;
                        btn_chnge.Visible = false;
                        ;
                    }
                    // }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void bn_update_Click(object sender, EventArgs e)
        {
            try
            {
        
                    if (cmb_emp.SelectedIndex > 0)
                    {
                        if (txt_DoccumentName.Text != "")
                        {

                            if (rd_yes.Checked == true)
                            {
                                reminder = "1";
                            }
                            else
                            {
                                reminder = "2";
                                txt_Reminder.Text = "0";
                            }
                            if (pb_attacment.Image == null)
                            {
                                MessageBox.Show("Please Select An Image.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                if (fop1.FileName != "NoFile")
                                {
                                    FileStream FS = new FileStream(fop1.FileName, FileMode.Open, FileAccess.Read);
                                    img = new byte[FS.Length];
                                    FS.Read(img, 0, Convert.ToInt32(FS.Length));
                                }
                                obj.UpdateEmpDoccument(cmb_emp.SelectedValue.ToString(), txt_DoccumentName.Text, img, reminder, dtp_expryDate.Value, txt_Reminder.Text);
                                MessageBox.Show("Employe Doccument Successfully Updated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter A Doccument Name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_DoccumentName.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select A Employee.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmb_emp.Focus();
                    }

                
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }


        private void btn_updte_Click(object sender, EventArgs e)
        {
            //    if (cmb_emp.SelectedIndex > 0)
            //    {
            //        if (txt_basicsalary.Text != "0")
            //        {
            //            obj.UpdateEmpSal(cmb_emp.SelectedValue.ToString(), txt_basicsalary.Text, txt_hra.Text, txt_transportation.Text, txt_other.Text, txt_total.Text);
            //            MessageBox.Show("Employee Salary Details successfully Updted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Please Enter Basic Salary.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            txt_basicsalary.Focus();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please Select An Employe.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        cmb_emp.Focus();
            //    }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btn_chnge_Click(object sender, EventArgs e)
        {
            if (cmb_emp.SelectedIndex > 0)
            {
                gv_holidys.Visible = true;
                gv_holidaystat.Visible = false;
            }
            else
            {
                MessageBox.Show("Plese Select An Employee.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
            
                    if (DeleteStatus == "1")
                    {
                        if (cmb_emp.SelectedIndex > 0)
                        {
                            obj.DEleteEmp(cmb_emp.SelectedValue.ToString());
                            //obj.SaveWindow(DateTime.Now, "Employee", File.ReadAllText("user.txt"), "Delete");
                            MessageBox.Show("Employee Details Successfully Deleted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();
                            rd_new.Checked = true;

                            DataSet ds1 = new DataSet();
                            ds1 = obj.GetempName();
                            cmb_emp.DataSource = ds1.Tables[0];
                            cmb_emp.DisplayMember = "Name";
                            cmb_emp.ValueMember = "Id";
                            DataRow drr1 = ds1.Tables[0].NewRow();
                            drr1["Name"] = "--Select One--";
                            drr1["Id"] = "0";
                            ds1.Tables[0].Rows.InsertAt(drr1, 0);
                        }
                        else
                        {
                            MessageBox.Show("Please Select An Employe.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmb_emp.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("You Do Not Have The Permission To Delete Employee", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void gv_Attachment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                if (i >= 0)
                {
                    gv_Attachment.Rows.Remove(gv_Attachment.Rows[e.RowIndex]);
                    txt_DoccumentName.Text = dtDocs.Rows[e.RowIndex]["Document"].ToString();
                    dtp_expryDate.Value = Convert.ToDateTime(dtDocs.Rows[e.RowIndex]["ExpiryDate"]);
                    string ReminderReq = dtDocs.Rows[e.RowIndex]["Reminder"].ToString();
                    if (ReminderReq == "1")
                        rd_yes.Checked = true;
                    else
                        rd_no.Checked = true;
                    txt_Reminder.Text = dtDocs.Rows[e.RowIndex]["ReminderBefore"].ToString();
                    MemoryStream ms = new MemoryStream((byte[])dtDocs.Rows[e.RowIndex]["Attachment"]);
                    pb_attacment.Image = Image.FromStream(ms);
                    pb_attacment.SizeMode = PictureBoxSizeMode.Zoom;
                    pb_attacment.Refresh();
                    dtDocs.Rows.RemoveAt(e.RowIndex);

                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_basicsalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_hra_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_transportation_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_other_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_Reminder_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_workinghrs_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_workinghrs.Text == string.Empty)
                {
                    txt_workinghrs.Text = "0";
                }


                string Str = txt_workinghrs.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    if (Convert.ToDouble(txt_workinghrs.Text) > 24)
                    {
                        MessageBox.Show("You Cannot Enter Values Greater Than 24.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_workinghrs.Text = "0";
                        txt_workinghrs.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_workinghrs.Text = "0";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void dtp_dateofbirth_ValueChanged(object sender, EventArgs e)
        {

        }
        DialogResult drl;
        private void bn_search_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeSearch emp = new EmployeSearch();
                emp.ShowDialog();
                string emplid = emp.id;
                if (emp.drr == DialogResult.OK)
                {                  
                    cmb_emp.SelectedValue = emplid;
                    btn_save.Enabled = false;
                    btn_update.Enabled = true;
                    btn_delete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clear();
            btnclear();

        }



        private void cmb_emp_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_emp.DroppedDown)
            {
                cmb_emp.Focus();
            }
        }

        private void cmb_country_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_country.DroppedDown)
            {
                cmb_country.Focus();
            }
        }

        private void cmb_designation_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_designation.DroppedDown)
            {
                cmb_designation.Focus();
            }
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Str = txt_total.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {

                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_total.Text = "0";
                }
                //txt_total.Text = Convert.ToString(Convert.ToDouble((int)Math.Floor(Convert.ToDouble(txt_total.Text) + .49)));
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
                Designation d = new Designation();
                d.ShowDialog();
               
                    DataSet ds3 = new DataSet();
                    ds3 = obj.GetDesignation();
                    cmb_designation.DataSource = ds3.Tables[0];
                    cmb_designation.DisplayMember = "designation_name";
                    cmb_designation.ValueMember = "designation_id";
                    DataRow dre = ds3.Tables[0].NewRow();
                    dre["designation_name"] = "--Select One--";
                    dre["designation_id"] = "0";
                    ds3.Tables[0].Rows.InsertAt(dre, 0);
                    cmb_designation.SelectedIndex = 0;
                
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_empid_DoubleClick(object sender, EventArgs e)
        {
            txt_empid.SelectAll();
        }

        private void txt_empcode_DoubleClick(object sender, EventArgs e)
        {
            txt_empcode.SelectAll();
        }

        private void txt_name_DoubleClick(object sender, EventArgs e)
        {
            txt_name.SelectAll();
        }

        private void txt_qualificatn_DoubleClick(object sender, EventArgs e)
        {
            txt_qualificatn.SelectAll();
        }

        private void txt_mobile_DoubleClick(object sender, EventArgs e)
        {
            txt_mobile.SelectAll();
        }

        private void txt_phone_DoubleClick(object sender, EventArgs e)
        {
            txt_phone.SelectAll();
        }

        private void txt_previousexp_DoubleClick(object sender, EventArgs e)
        {
            txt_previousexp.SelectAll();
        }

        private void txt_workinghrs_DoubleClick(object sender, EventArgs e)
        {
            txt_workinghrs.SelectAll();
        }

        private void txt_DoccumentName_DoubleClick(object sender, EventArgs e)
        {
            txt_DoccumentName.SelectAll();
        }

        private void txt_Reminder_DoubleClick(object sender, EventArgs e)
        {
            txt_Reminder.SelectAll();
        }

        private void txt_basicsalary_DoubleClick(object sender, EventArgs e)
        {
            txt_basicsalary.SelectAll();
        }

        private void txt_hra_DoubleClick(object sender, EventArgs e)
        {
            txt_hra.SelectAll();
        }

        private void txt_transportation_DoubleClick(object sender, EventArgs e)
        {
            txt_transportation.SelectAll();
        }

        private void txt_other_DoubleClick(object sender, EventArgs e)
        {
            txt_other.SelectAll();
        }

        private void txt_total_DoubleClick(object sender, EventArgs e)
        {
            txt_total.SelectAll();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Country c = new Country();
                c.ShowDialog();

                DataSet ds2 = new DataSet();
                ds2 = obj.GetCountry();
                cmb_country.DataSource = ds2.Tables[0];
                cmb_country.DisplayMember = "Country";
                cmb_country.ValueMember = "Id";
                DataRow drr2 = ds2.Tables[0].NewRow();
                drr2["Country"] = "--Select One--";
                drr2["Id"] = "0";
                ds2.Tables[0].Rows.InsertAt(drr2, 0);
                cmb_country.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_workinghrs_MouseClick(object sender, MouseEventArgs e)
        {
            txt_workinghrs.SelectAll();
        }
    }
}
        
