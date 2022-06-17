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
    public partial class EmployeSearch : Form
    {
        public EmployeSearch()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
      
      

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

        private void EmployeSearch_Load(object sender, EventArgs e)
        {
            try
            {

                ApplyTheme();

               
                    DataSet ds6 = new DataSet();
                    ds6 = obj.GetEmpMob();
                    cbox_mob.DataSource = ds6.Tables[0];
                    cbox_mob.DisplayMember = "Mobile";

                    DataRow dr6 = ds6.Tables[0].NewRow();
                    dr6["Mobile"] = "--Select One--";

                    ds6.Tables[0].Rows.InsertAt(dr6, 0);
                    cbox_mob.SelectedIndex = 0;

                    DataSet ds4 = new DataSet();
                    ds4 = obj.GetDesignation();
                    cbox_designation.DataSource = ds4.Tables[0];
                    cbox_designation.DisplayMember = "designation_name";
                    cbox_designation.ValueMember = "designation_id";
                    DataRow dr4 = ds4.Tables[0].NewRow();
                    dr4["designation_name"] = "--Select One--";
                    dr4["designation_id"] = "0";
                    ds4.Tables[0].Rows.InsertAt(dr4, 0);
                    cbox_designation.SelectedIndex = 0;

                    DataSet ds5 = new DataSet();
                    ds5 = obj.GetCountry();
                    cbox_Nationality.DataSource = ds5.Tables[0];
                    cbox_Nationality.DisplayMember = "Country";
                    cbox_Nationality.ValueMember = "Id";
                    DataRow drr5 = ds5.Tables[0].NewRow();
                    drr5["Country"] = "--Select One--";
                    drr5["Id"] = "0";
                    ds5.Tables[0].Rows.InsertAt(drr5, 0);
                    cbox_Nationality.SelectedIndex = 0;

                    ch_mobile.Checked = false;
                    ch_Emp.Checked = false;
                    ch_Nationality.Checked = false;
                    ch_designation.Checked = false;
                    cbox_designation.Enabled = false;
                    cbox_mob.Enabled = false;
                    cbox_Nationality.Enabled = false;
                    txt_emp.Enabled = false;
                
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        private int chk()
        {
            int stat = 0;
            if (ch_Emp.Checked == true)
            {
                if (txt_emp.Text == string.Empty)
                {
                    stat = 1;
                    MessageBox.Show("Please Enter Employee.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_emp.Focus();
                    return stat;
                }
            }

            if (ch_designation.Checked == true)
            {
                if (cbox_designation.SelectedIndex < 1)
                {
                    stat = 1;
                    MessageBox.Show("Please Select Designation.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbox_designation.Focus();
                    return stat;
                }
            }
            if (ch_Nationality.Checked == true)
            {
                if (cbox_Nationality.SelectedIndex < 1)
                {
                    stat = 1;
                    MessageBox.Show("Please Select Country.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbox_Nationality.Focus();
                    return stat;
                }
            }
            if (ch_mobile.Checked == true)
            {
                if (cbox_mob.SelectedIndex < 1)
                {
                    stat = 1;
                    MessageBox.Show("Please Select Mobile Number.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbox_mob.Focus();
                    return stat;
                }
            }

            return stat;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
              
                    gv_EmpSearch.Rows.Clear();
                    int Stat = chk();
                    if (Stat == 0)
                    {
                        DataTable dt = new DataTable();
                        if ((ch_Emp.Checked == true) && (ch_designation.Checked == false) && (ch_Nationality.Checked == false) && (ch_mobile.Checked == false))
                        {
                            dt = obj.GetEmpSearch(txt_emp.Text, cbox_designation.SelectedValue.ToString(), cbox_Nationality.SelectedValue.ToString(), cbox_mob.Text, "1");
                        }
                        if ((ch_Emp.Checked == false) && (ch_designation.Checked == true) && (ch_Nationality.Checked == false) && (ch_mobile.Checked == false))
                        {
                            dt = obj.GetEmpSearch(txt_emp.Text, cbox_designation.SelectedValue.ToString(), cbox_Nationality.SelectedValue.ToString(), cbox_mob.Text, "2");
                        }
                        if ((ch_Emp.Checked == false) && (ch_designation.Checked == false) && (ch_Nationality.Checked == true) && (ch_mobile.Checked == false))
                        {
                            dt = obj.GetEmpSearch(txt_emp.Text, cbox_designation.SelectedValue.ToString(), cbox_Nationality.SelectedValue.ToString(), cbox_mob.Text, "3");
                        }
                        if ((ch_Emp.Checked == false) && (ch_designation.Checked == false) && (ch_Nationality.Checked == false) && (ch_mobile.Checked == true))
                        {
                            dt = obj.GetEmpSearch(txt_emp.Text, cbox_designation.SelectedValue.ToString(), cbox_Nationality.SelectedValue.ToString(), cbox_mob.Text, "4");
                        }
                        if ((ch_Emp.Checked == true) && (ch_designation.Checked == true) && (ch_Nationality.Checked == false) && (ch_mobile.Checked == false))
                        {
                            dt = obj.GetEmpSearch(txt_emp.Text, cbox_designation.SelectedValue.ToString(), cbox_Nationality.SelectedValue.ToString(), cbox_mob.Text, "5");
                        }
                        if ((ch_Emp.Checked == true) && (ch_designation.Checked == false) && (ch_Nationality.Checked == true) && (ch_mobile.Checked == false))
                        {
                            dt = obj.GetEmpSearch(txt_emp.Text, cbox_designation.SelectedValue.ToString(), cbox_Nationality.SelectedValue.ToString(), cbox_mob.Text, "6");
                        }
                        if ((ch_Emp.Checked == true) && (ch_designation.Checked == false) && (ch_Nationality.Checked == false) && (ch_mobile.Checked == true))
                        {
                            dt = obj.GetEmpSearch(txt_emp.Text, cbox_designation.SelectedValue.ToString(), cbox_Nationality.SelectedValue.ToString(), cbox_mob.Text, "7");
                        }
                        if ((ch_Emp.Checked == false) && (ch_designation.Checked == true) && (ch_Nationality.Checked == true) && (ch_mobile.Checked == false))
                        {
                            dt = obj.GetEmpSearch(txt_emp.Text, cbox_designation.SelectedValue.ToString(), cbox_Nationality.SelectedValue.ToString(), cbox_mob.Text, "8");
                        }
                        if ((ch_Emp.Checked == false) && (ch_designation.Checked == true) && (ch_Nationality.Checked == false) && (ch_mobile.Checked == true))
                        {
                            dt = obj.GetEmpSearch(txt_emp.Text, cbox_designation.SelectedValue.ToString(), cbox_Nationality.SelectedValue.ToString(), cbox_mob.Text, "9");
                        }
                        if ((ch_Emp.Checked == false) && (ch_designation.Checked == false) && (ch_Nationality.Checked == true) && (ch_mobile.Checked == true))
                        {
                            dt = obj.GetEmpSearch(txt_emp.Text, cbox_designation.SelectedValue.ToString(), cbox_Nationality.SelectedValue.ToString(), cbox_mob.Text, "10");
                        }
                        if ((ch_Emp.Checked == true) && (ch_designation.Checked == true) && (ch_Nationality.Checked == true) && (ch_mobile.Checked == false))
                        {
                            dt = obj.GetEmpSearch(txt_emp.Text, cbox_designation.SelectedValue.ToString(), cbox_Nationality.SelectedValue.ToString(), cbox_mob.Text, "11");
                        }
                        if ((ch_Emp.Checked == true) && (ch_designation.Checked == true) && (ch_Nationality.Checked == false) && (ch_mobile.Checked == true))
                        {
                            dt = obj.GetEmpSearch(txt_emp.Text, cbox_designation.SelectedValue.ToString(), cbox_Nationality.SelectedValue.ToString(), cbox_mob.Text, "12");
                        }
                        if ((ch_Emp.Checked == false) && (ch_designation.Checked == true) && (ch_Nationality.Checked == true) && (ch_mobile.Checked == true))
                        {
                            dt = obj.GetEmpSearch(txt_emp.Text, cbox_designation.SelectedValue.ToString(), cbox_Nationality.SelectedValue.ToString(), cbox_mob.Text, "13");
                        }
                        if ((ch_Emp.Checked == true) && (ch_designation.Checked == true) && (ch_Nationality.Checked == true) && (ch_mobile.Checked == true))
                        {
                            dt = obj.GetEmpSearch(txt_emp.Text, cbox_designation.SelectedValue.ToString(), cbox_Nationality.SelectedValue.ToString(), cbox_mob.Text, "2");
                        }
                        if ((ch_Emp.Checked == false) && (ch_designation.Checked == false) && (ch_Nationality.Checked == false) && (ch_mobile.Checked == false))
                        {
                            dt = obj.GetEmpSearch(txt_emp.Text, cbox_designation.SelectedValue.ToString(), cbox_Nationality.SelectedValue.ToString(), cbox_mob.Text, "15");
                        }
                        int i = 0;
                        gv_EmpSearch.Rows.Clear();
                        if (dt.Rows.Count > 0)
                        {
                            for (i = 0; i < dt.Rows.Count; i++)
                            {
                                gv_EmpSearch.Rows.Add();
                                gv_EmpSearch[0, i].Value = dt.Rows[i]["Id"].ToString();
                                gv_EmpSearch[1, i].Value = (i + 1).ToString();
                                gv_EmpSearch[2, i].Value = dt.Rows[i]["EmpCode"].ToString();
                                gv_EmpSearch[3, i].Value = dt.Rows[i]["Name"].ToString();
                                gv_EmpSearch[4, i].Value = dt.Rows[i]["DateOfBirth"].ToString();
                                gv_EmpSearch[5, i].Value = dt.Rows[i]["designation_name"].ToString();
                                gv_EmpSearch[6, i].Value = dt.Rows[i]["DateOfJoining"].ToString();
                                gv_EmpSearch[7, i].Value = dt.Rows[i]["WorkingHrs"].ToString();
                                gv_EmpSearch[8, i].Value = dt.Rows[i]["Mobile"].ToString();
                                gv_EmpSearch[9, i].Value = dt.Rows[i]["Country"].ToString();
                                gv_EmpSearch[10, i].Value = dt.Rows[i]["Gender"].ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No Search Result Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void gv_EmpSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ch_Emp_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Emp.Checked == true)
            {
                txt_emp.Enabled = true;
            }
            if (ch_Emp.Checked == false)
            {
                txt_emp.Enabled = false;
            }

        }

        private void ch_designation_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_designation.Checked == true)
            {
                cbox_designation.Enabled = true;
            }
            if (ch_designation.Checked == false)
            {
                cbox_designation.Enabled = false;
            }
        }

        private void ch_Nationality_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Nationality.Checked == true)
            {
                cbox_Nationality.Enabled = true;
            }
            if (ch_Nationality.Checked == false)
            {
                cbox_Nationality.Enabled = false;
            }
        }

        private void ch_mobile_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_mobile.Checked == true)
            {
                cbox_mob.Enabled = true;
            }
            if (ch_mobile.Checked == false)
            {
                cbox_mob.Enabled = false;
            }
        }
        public string id;
        public DialogResult drr;
        private void gv_EmpSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = gv_EmpSearch[0, e.RowIndex].Value.ToString();
                drr = DialogResult.OK;
                this.Close();

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbox_designation_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cbox_designation.DroppedDown)
            {
                cbox_designation.Focus();
            }
        }

        private void cbox_Nationality_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cbox_Nationality.DroppedDown)
            {
                cbox_Nationality.Focus();
            }
        }

        private void cbox_mob_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cbox_mob.DroppedDown)
            {
                cbox_mob.Focus();
            }
        }

        private void txt_emp_DoubleClick(object sender, EventArgs e)
        {
            txt_emp.SelectAll();
        }
        public void FloatValueValidatePhoneNum(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else
                e.Handled = true;
        }


        private void cbox_mob_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidatePhoneNum(e);
        }

        private void cbox_designation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
