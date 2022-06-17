using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BisCarePosEdition
{
    public partial class DeletePassword : Form
    {
        public DeletePassword()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
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
        private void DeletePassword_Load(object sender, EventArgs e)
        {
            ApplyTheme();
        }
        public DialogResult Dr=DialogResult.Cancel;
        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            string pass = obj.GetDeletePass();
            if (pass != "0")
            {
                if (Txt_Passwd.Text == pass)
                {
                    Dr = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    if (Txt_Passwd.Text == "")
                    {
                        MessageBox.Show("Please Enter Delete Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Txt_Passwd.Focus();
                        Dr = DialogResult.Cancel;
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Txt_Passwd.Text = "";
                        Txt_Passwd.Focus();
                        Dr = DialogResult.Cancel;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please set Password to delete KOT.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
