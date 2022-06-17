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
    public partial class IncomeExpenseType : Form
    {
        public IncomeExpenseType()
        {
            InitializeComponent();
        }
         
        public IncomeExpenseType(int status)
        {
            InitializeComponent();
            if (status == 2)
                rbtnExpense.Checked = true;
            else
                rbtnIncome.Checked = true;
        }
        Codebehind ObjCode = new Codebehind();
        //CodeLoading ObjCode1 = new CodeLoading();
        //CodeBehindLocal objcodeLoc = new CodeBehindLocal();
        int DBConn = 0;
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

        private void IncomeExpenseType_Load(object sender, EventArgs e)
        {
            try
            {
               // DBConn = ObjCode.CheckDBConnection();
                ApplyTheme();
                bttn_delete.Enabled = false;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }          
        }

        private void bttn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rb_new_CheckedChanged(object sender, EventArgs e)
        {
            clearradio();
            if (Rb_new.Checked == true)
            {
                cboxTypeName.Enabled = false;
                bttn_delete.Enabled = false;
            }
            else
            {
                cboxTypeName.Enabled = true;
            }

        }
        public void clearradio()
        {
            txtDescription.Text = "";
            txtName.Text = "";
            if (f == 1)
            {
                cboxTypeName.SelectedIndex = 0;
            }
        }
        public void Clear()
        {
            txtDescription.Text = "";
            txtName.Text = "";
            Rb_new.Checked = true;
            rbtnIncome.Checked = true;
            bttn_delete.Enabled = false;
        }
        private void bttn_save_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                string Typ = "1";
                if (rbtnExpense.Checked == true)
                    Typ = "2";
                if (Rb_new.Checked == true)//Insert New
                {
                    //if (DBConn == 1)
                    //{

                        string msgpen = ObjCode.InsertIncomeExpenseType(Typ, txtName.Text, txtDescription.Text);
                   // }
                    //string msg = objcodeLoc.InsertIncomeExpenseType(Typ, txtName.Text, txtDescription.Text);
                        if (msgpen == "Exists")
                    {
                        MessageBox.Show("This type name already exists.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtName.Focus();
                    }
                        else
                        {
                            MessageBox.Show("Type name successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtDescription.Text = "";
                            txtName.Text = "";
                        }
                }
                else//Updation
                {
                    if (cboxTypeName.SelectedIndex > 0)
                    {
                        //if (DBConn == 1)
                        //{

                            string msgpen = ObjCode.UpdateIncomeExpenseType(cboxTypeName.SelectedValue.ToString(), Typ, txtName.Text, txtDescription.Text);
                        //}
                        //string msg = objcodeLoc.UpdateIncomeExpenseType(cboxTypeName.SelectedValue.ToString(), Typ, txtName.Text, txtDescription.Text);
                            if (msgpen == "Exists")
                            {
                                MessageBox.Show("This type name already exists.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtName.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Type successfully updated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtDescription.Text = "";
                                txtName.Text = "";
                                //Clear();
                            }
                    }
                    else
                    {
                        MessageBox.Show("Please select a type.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboxTypeName.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter type name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }
        int f = 0;
        private void Rb_edit_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_edit.Checked == true)
            {
                clearradio();
                rbtnIncome.Checked = true;
                string Typ = "1";

                DataTable dt = ObjCode.SelectIncomeExpenseType(Typ);
                cboxTypeName.DataSource = dt;
                cboxTypeName.DisplayMember = "Name";
                cboxTypeName.ValueMember = "Id";
                DataRow dr = dt.NewRow();
                dr["Name"] = "--Select One--";
                dr["Id"] = "0";
                dt.Rows.InsertAt(dr, 0);
                cboxTypeName.SelectedIndex = 0;
                f = 1;
                bttn_delete.Enabled = true;
               // dt.Rows.Clear();
            }
          //  dt.Rows.Clear();

        }

        private void cboxTypeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDescription.Text = "";
            txtName.Text = "";
            if (cboxTypeName.SelectedIndex > 0)
            {
                DataTable dt = ObjCode.GetIncomeExpenseTypeDetails(cboxTypeName.SelectedValue.ToString());
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["Type"].ToString() == "1")
                    {
                        rbtnIncome.Checked = true;
                    }
                    else
                    {
                        rbtnExpense.Checked = true;
                    }
                    txtName.Text = dt.Rows[0]["Name"].ToString();
                    txtDescription.Text = dt.Rows[0]["Description"].ToString();
                }
            }
            else
            {
                txtDescription.Text = "";
                txtName.Text = "";
            }
        }

        private void rbtnIncome_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtnIncome.Checked == true)
            {
                if (Rb_edit.Checked == true)
                {
                    string Typ = "1";

                    DataTable dt = ObjCode.SelectIncomeExpenseType(Typ);
                    cboxTypeName.DataSource = dt;
                    cboxTypeName.DisplayMember = "Name";
                    cboxTypeName.ValueMember = "Id";
                    DataRow dr = dt.NewRow();
                    dr["Name"] = "--Select One--";
                    dr["Id"] = "0";
                    dt.Rows.InsertAt(dr, 0);
                    cboxTypeName.SelectedIndex = 0;
                    f = 1;
                    //  dt.Rows.Clear();
                }
            }
        }

        private void rbtnExpense_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnExpense.Checked == true)
            {
                if (Rb_edit.Checked == true)
                {
                    txtDescription.Text = "";
                    txtName.Text = "";

                    string Typ = "2";

                    DataTable dt = ObjCode.SelectIncomeExpenseType(Typ);
                    cboxTypeName.DataSource = dt;
                    cboxTypeName.DisplayMember = "Name";
                    cboxTypeName.ValueMember = "Id";
                    DataRow dr = dt.NewRow();
                    dr["Name"] = "--Select One--";
                    dr["Id"] = "0";
                    dt.Rows.InsertAt(dr, 0);
                    cboxTypeName.SelectedIndex = 0;
                    f = 1;
                    // dt.Rows.Clear();
                }
            }
        }

        private void bttn_delete_Click(object sender, EventArgs e)
        {
            if (cboxTypeName.SelectedIndex > 0)
            {
                //if (DBConn == 1)
                //{

                    string stpen = ObjCode.DeleteIncomeExpense(cboxTypeName.Text);
                //}
                //string st = objcodeLoc.DeleteIncomeExpense(cboxTypeName.Text);
                if (rbtnIncome.Checked == true)
                {
                    //if (st == "0")
                    //{
                    //    MessageBox.Show("Income Type already in use.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    cboxTypeName.Focus();
                    //}
                    ////else
                    //{
                        MessageBox.Show("Income Type successfully deleted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearradio();
                        string Typ = "1";

                        DataTable dt = ObjCode.SelectIncomeExpenseType(Typ);
                        cboxTypeName.DataSource = dt;
                        cboxTypeName.DisplayMember = "Name";
                        cboxTypeName.ValueMember = "Id";
                        DataRow dr = dt.NewRow();
                        dr["Name"] = "--Select One--";
                        dr["Id"] = "0";
                        dt.Rows.InsertAt(dr, 0);
                        cboxTypeName.SelectedIndex = 0;
                        f = 1;
                    //}
                }

                if (rbtnExpense.Checked == true)
                {
                    //if (st == "0")
                    //{
                    //    MessageBox.Show("Expense Type already in use.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    cboxTypeName.Focus();
                    //}
                    //else
                    //{
                        MessageBox.Show("Expense Type successfully deleted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearradio();
                        string Typ = "2";

                        DataTable dt = ObjCode.SelectIncomeExpenseType(Typ);
                        cboxTypeName.DataSource = dt;
                        cboxTypeName.DisplayMember = "Name";
                        cboxTypeName.ValueMember = "Id";
                        DataRow dr = dt.NewRow();
                        dr["Name"] = "--Select One--";
                        dr["Id"] = "0";
                        dt.Rows.InsertAt(dr, 0);
                        cboxTypeName.SelectedIndex = 0;
                        f = 1;
                   // }
                }
            }
            else
            {
                MessageBox.Show("Please select a Type.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboxTypeName.Focus();
            }

        }
    }
}
