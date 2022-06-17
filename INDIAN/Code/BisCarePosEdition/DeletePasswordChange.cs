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
    public partial class DeletePasswordChange : Form
    {
        public DeletePasswordChange()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txt_confirmpassword.Text = "";
            txt_Newpassword.Text = "";
        }
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        Codebehind obj = new Codebehind();
        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaveStatus == "1")
                {
                    if (txt_Newpassword.Text == "")
                    {
                        MessageBox.Show("Please Enter New Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_Newpassword.Focus();
                    }
                    else
                    {
                        if (txt_confirmpassword.Text == "")
                        {
                            MessageBox.Show("Please Enter Confirm Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_confirmpassword.Focus();
                        }
                        else
                        {
                            if (txt_Newpassword.Text == txt_confirmpassword.Text)
                            {
                                obj.SaveDeletePass(txt_confirmpassword.Text);
                                MessageBox.Show("Password successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clear();
                            }
                            else
                            {
                                MessageBox.Show("Mismatch In Passwords.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txt_confirmpassword.Focus();
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
        private void DeletePasswordChange_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            this.ActiveControl = txt_Newpassword;
            DataTable dt1 = new DataTable();
            dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "DeletePassword");
            SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
            UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
            DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
