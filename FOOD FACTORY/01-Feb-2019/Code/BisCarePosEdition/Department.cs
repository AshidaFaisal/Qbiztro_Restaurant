using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
namespace BisCarePosEdition
{
    public partial class Department : Form
    {
        Codebehind obj = new Codebehind();

        public Department()
        {
            InitializeComponent();
            Rb_new.Checked = true;
            Rb_edit.Checked = false;
            txt_department.Focus();

        }
        int f = 0;
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
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

        private void Department_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
                DataTable dt1 = new DataTable();
                dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "department");
                SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
                UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
                DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();
                this.ActiveControl = txt_department;
                loadcombo();
                txt_department.Focus();
                f = 1;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }









        public void loadcombo()
        {

            DataSet ds = new DataSet();
            ds = obj.getdepartrment();
            cmb_department.DataSource = ds.Tables[0];
            cmb_department.DisplayMember = "department";
            cmb_department.ValueMember = "Id";
            DataRow dr = ds.Tables[0].NewRow();
            dr["department"] = "--Select One--";
            dr["Id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cmb_department.SelectedIndex = 0;
            f = 1;

        }
        
        private void btn_save_Click(object sender, EventArgs e)
         
        { 
            try
            {
                if (Rb_new.Checked == true)
                {
                    if (SaveStatus == "1")
                    {
                        if (txt_department.Text != "")
                        {

                            string msg = obj.InsertorUpdatedepartment(txt_department.Text, txt_remarks.Text, "0", "0");
                            Rb_new.Enabled = true;
                            cmb_department.Enabled = false;
                            txt_department.Focus();
                                 if (msg != null)
                            if (msg == "This department name already exists")
                                MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                                MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadcombo();
                            cmb_department.Enabled = false;
                            txt_department.Focus();
                            //  txt_name.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("Please enter department", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //cmb_category.Focus();
                            txt_department.Focus();
                        }
                    }
                    else
                    {

                        MessageBox.Show("You Do Not Have The Permission To Save department", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    if (Rb_edit.Checked == true)
                    {
                      
                        if (UpdateStatus == "1")
                        {
                            if (cmb_department.SelectedIndex > 0)
                            {
                                if (txt_department.Text != "")
                                { 
                                    string msg = obj.InsertorUpdatedepartment(txt_department.Text, txt_remarks.Text, "1", txt_department.Tag.ToString());
                                   txt_department.Text = "";
                                   Rb_new.Enabled = true;
                                   
                                    cmb_department.Focus();

                                    if (msg != null)
                                    {
                                        MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        loadcombo();
                                    }
                                    if (Rb_new.Checked == true)
                                    {


                                        txt_department.Text = "";
                                        cmb_department.Text = "--select--";
                                        cmb_department.Focus();
                                    }
                                }
                                else if (cmb_department.Text == "select")
                                {
                                    MessageBox.Show("Please enter category", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cmb_department.Focus();
                                }

                                else
                                {
                                    MessageBox.Show("You Do Not Have The Permission To Update Category", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                                }
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

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeleteStatus == "1")
                {
                    if (cmb_department.SelectedIndex > 0)
                    {
                        string msg = obj.deletedepartment(cmb_department.SelectedValue.ToString());

                        MessageBox.Show("department sucessfully deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_department.Text = "";
                        txt_department.Focus();
                        Rb_new.Enabled = true;
                        txt_remarks.Text = "";
                        loadcombo();

                    }
                    else

                        MessageBox.Show("Sorry,department already in use.So you can not delete this department", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_department.Text = "";
                    cmb_department.Text = "select";
                    txt_department.Focus();
                   
                }

                else
                {
                    MessageBox.Show("Please select a department", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




                    cmb_department.Focus();
                    txt_department.Text = "";
                    txt_department.Focus();
                    txt_remarks.Text = "";


            
                if(DeleteStatus=="0")
               
                {

                    MessageBox.Show("You Do Not Have The Permission To Delete department", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        
            
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }


        private void Rb_edit_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_edit.Checked == true)
            {
                cmb_department.Enabled = true;
                //Btn_Delete.Enabled = true;
                //cmb_department.Focus();
                txt_department.Text = "";
                txt_remarks.Text = "";
                loadcombo();
                cmb_department.Focus();

            }
            else
            {


                txt_department.Focus();
            }
        }

        private void cmb_department_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                if (f == 1)
                { SqlDataReader ds = obj.getdepartmentbyid(cmb_department.SelectedValue.ToString());
                    if (ds.Read())
                   
                    {
                        txt_department.Tag = ds[0].ToString();
                        txt_department.Text = ds[1].ToString();
                        txt_remarks.Text = ds[2].ToString();
                        ds.Close();
                        txt_department.Focus();
                    }
                    else
                    {
                        txt_department.Text = "";
                        cmb_department.Text = "select";
                        txt_remarks.Text = "";
                    }
                }
            }           
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }     
        }

        private void Rb_new_CheckedChanged(object sender, EventArgs e)
        {
            loadcombo();
            txt_department.Text = "";
            txt_remarks.Text = "";
            txt_department.Focus();
            cmb_department.Enabled = false;
            
        }

        private void Rb_new_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_department.Focus();
            }
        }

        private void Rb_edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_department.Focus();
            }

        }

        private void txt_department_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_remarks.Focus();
            }
        }

        private void txt_remarks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save.Focus();
            }
        }

        private void btn_save_KeyDown(object sender, KeyEventArgs e)
        {
             
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Delete.Focus();
            }
        }

        private void Btn_Delete_KeyDown(object sender, KeyEventArgs e)
        {
            btn_cancel.Focus();
        }

        private void btn_save_Leave(object sender, EventArgs e)
        {
            //DataSet s = new DataSet();
            //s = obj.getdepartrment();
            //cmb_department.DataSource = s.Tables[0];
            //cmb_department.DisplayMember = "department";
            //cmb_department.ValueMember = "Id";
        }
    }
}


