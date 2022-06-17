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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        public DialogResult dgrslt = new DialogResult();
        double ans = 0;
        
        int dec = 0;
       
        private TextBox lastFocused;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_keypadeout.Text.Length <= 8)
            {
                if (dec == 0)
                {
                    ans = ans * 10 + Convert.ToDouble(((Button)sender).Text);
                    lastFocused.Text = ans.ToString();
                }
                else
                {

                    lastFocused.AppendText(((Button)sender).Text);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_keypadeout.Text.Length <= 8)
            {
                if (dec == 0)
                {
                    ans = ans * 10 + Convert.ToDouble(((Button)sender).Text);
                    lastFocused.Text = ans.ToString();
                }
                else
                {

                    lastFocused.AppendText(((Button)sender).Text);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txt_keypadeout.Text.Length <= 8)
            {

                if (dec == 0)
                {
                    ans = ans * 10 + Convert.ToDouble(((Button)sender).Text);
                    lastFocused.Text = ans.ToString();
                }
                else
                {

                    lastFocused.AppendText(((Button)sender).Text);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txt_keypadeout.Text.Length <= 8)
            {
                if (dec == 0)
                {
                    ans = ans * 10 + Convert.ToDouble(((Button)sender).Text);
                    lastFocused.Text = ans.ToString();
                }
                else
                {

                    lastFocused.AppendText(((Button)sender).Text);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txt_keypadeout.Text.Length <= 8)
            {
                if (dec == 0)
                {
                    ans = ans * 10 + Convert.ToDouble(((Button)sender).Text);
                    lastFocused.Text = ans.ToString();
                }
                else
                {

                    lastFocused.AppendText(((Button)sender).Text);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txt_keypadeout.Text.Length <= 8)
            {
                if (dec == 0)
                {
                    ans = ans * 10 + Convert.ToDouble(((Button)sender).Text);
                    lastFocused.Text = ans.ToString();
                }
                else
                {

                    lastFocused.AppendText(((Button)sender).Text);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txt_keypadeout.Text.Length <= 8)
            {
                if (dec == 0)
                {
                    ans = ans * 10 + Convert.ToDouble(((Button)sender).Text);
                    lastFocused.Text = ans.ToString();
                }
                else
                {

                    lastFocused.AppendText(((Button)sender).Text);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txt_keypadeout.Text.Length <= 8)
            {
                if (dec == 0)
                {
                    ans = ans * 10 + Convert.ToDouble(((Button)sender).Text);
                    lastFocused.Text = ans.ToString();
                }
                else
                {

                    lastFocused.AppendText(((Button)sender).Text);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txt_keypadeout.Text.Length <= 8)
            {
                if (dec == 0)
                {
                    ans = ans * 10 + Convert.ToDouble(((Button)sender).Text);
                    lastFocused.Text = ans.ToString();
                }
                else
                {

                    lastFocused.AppendText(((Button)sender).Text);
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
                if (dec == 0)
                {
                    ans = ans * 10 + Convert.ToDouble(((Button)sender).Text);
                    lastFocused.Text = ans.ToString();
                }
                else
                {

                    lastFocused.AppendText(((Button)sender).Text);
                }
         
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (txt_keypadeout.Text.Length <= 8)
            {
                if (dec == 0)
                    lastFocused.Text = lastFocused.Text + ".";

                dec = 1;
            }
        }
        int x = 0;
        double paydedamt = 0;
        string Id;
        string quantity = "0";
        double total;
        private void txt_keypadeout_TextChanged(object sender, EventArgs e)
        {
            if (txt_keypadeout.Text.EndsWith("."))
            {
                x++;
            }
            if (!txt_keypadeout.Text.EndsWith(".") || x > 1)
            {
                
                string Str = txt_keypadeout.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    paydedamt = Convert.ToDouble(txt_keypadeout.Text);
                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    total = 0;
                    txt_keypadeout.Text = "0";
                    x = 0;                  
                }

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
        private void Calculator_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
                lastFocused = txt_keypadeout;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lastFocused.Text = "0";
            ans = 0;
            dec = 0;
        }
        public double Qty;
        private void button17_Click(object sender, EventArgs e)
        {
            Qty = Convert.ToDouble(txt_keypadeout.Text);
            if (Qty == 0)
            {
                MessageBox.Show("Please enter value", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgrslt = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Qty = 0;
            dgrslt = DialogResult.Cancel;
            this.Close();
        }
    }
}
