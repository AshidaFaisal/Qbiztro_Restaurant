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
    public partial class DayClosing : Form
    {
        public DayClosing()
        {
            InitializeComponent();
        }
        Codebehind obj=new Codebehind();
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
        public void FloatValueValidate(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;
        }
        public void sum()
        {
            txt_total.Text = Convert.ToDouble(Convert.ToDouble(txt_fiftyPstotal.Text) + Convert.ToDouble(txt_oneTotal.Text) + Convert.ToDouble(txt_twototal.Text) + Convert.ToDouble(txt_fivetotal.Text) + Convert.ToDouble(txt_tentotal.Text) + Convert.ToDouble(txt_twentytotal.Text) + Convert.ToDouble(txt_fiftytotal.Text) + Convert.ToDouble(txt_hundradtotal.Text) + Convert.ToDouble(txt_fivehundradtotal.Text) + Convert.ToDouble(txt_totalThousand.Text)).ToString("F2");
        }
        private void DayClosing_Load(object sender, EventArgs e)
        {
            //ApplyTheme();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

       

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_fiftyps_Click(object sender, EventArgs e)
        {

        }

        private void lbl_One_Click(object sender, EventArgs e)
        {

        }

        private void lbl_five_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ten_Click(object sender, EventArgs e)
        {

        }

        private void txt_fiftyPs_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_thosand_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_fivehundrad_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_hundrad_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_fifty_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_ten_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_five_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_one_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_fiftyPs_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_fiftyPs.Text == "")
                {
                    txt_fiftyPs.Text = "0";
                }
                string Str = txt_fiftyPs.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    if ((txt_fiftyPs.Text != "") && (txt_fiftyPs.Text != "0"))
                    {
                        txt_fiftyPstotal.Text = (Convert.ToDouble(txt_fiftyPs.Text) * 0.50).ToString("F2");
                        sum();
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_one_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_one.Text == "")
                {
                    txt_one.Text = "0";
                }
                string Str = txt_one.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    txt_oneTotal.Text = (Convert.ToDouble(txt_one.Text) * 1).ToString("F2");
                    sum();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_five_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_five.Text == "")
                {
                    txt_five.Text = "0";
                }
                string Str = txt_five.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    txt_fivetotal.Text = (Convert.ToDouble(txt_five.Text) * 5).ToString("F2");
                    sum();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_ten.Text == "")
                {
                    txt_ten.Text = "0";
                }
                string Str = txt_ten.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    txt_tentotal.Text = (Convert.ToDouble(txt_ten.Text) * 10).ToString("F2");
                    sum();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_fifty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_fifty.Text == "")
                {
                    txt_fifty.Text = "0";
                }
                string Str = txt_fifty.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    txt_fiftytotal.Text = (Convert.ToDouble(txt_fifty.Text) * 50).ToString("F2");
                    sum();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_hundrad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_hundrad.Text == "")
                {
                    txt_hundrad.Text = "0";
                }
                string Str = txt_hundrad.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    txt_hundradtotal.Text = (Convert.ToDouble(txt_hundrad.Text) * 100).ToString("F2");
                    sum();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_fivehundrad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_fivehundrad.Text == "")
                {
                    txt_fivehundrad.Text = "0";
                }
                string Str = txt_fivehundrad.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    txt_fivehundradtotal.Text = (Convert.ToDouble(txt_fivehundrad.Text) * 500).ToString("F2");
                    sum();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_thosand_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_thosand.Text == "")
                {
                    txt_thosand.Text = "0";
                }
                string Str = txt_thosand.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    txt_totalThousand.Text = (Convert.ToDouble(txt_thosand.Text) * 1000).ToString("F2");
                    sum();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_fiftyPstotal_TextChanged(object sender, EventArgs e)
        {   
          
       
        }

        private void txt_two_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_two.Text == "")
                {
                    txt_two.Text = "0";
                }
                string Str = txt_two.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    txt_twototal.Text = (Convert.ToDouble(txt_two.Text) * 2).ToString("F2");
                    sum();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_twenty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_twenty.Text == "")
                {
                    txt_twenty.Text = "0";
                }
                string Str = txt_twenty.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    txt_twentytotal.Text = (Convert.ToDouble(txt_twenty.Text) * 20).ToString("F2");
                    sum();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_totalThousand_TextChanged(object sender, EventArgs e)
        {

        }
        public void reset()
        {
            txt_fiftyPs.Text = "0";
            txt_fiftyPstotal.Text = "0.00";
            txt_one.Text = "0";
            txt_oneTotal.Text = "0.00";
            txt_two.Text = "0";
            txt_twototal.Text = "0.00";
            txt_five.Text = "0";
            txt_fivetotal.Text = "0.00";
            txt_ten.Text = "0";
            txt_tentotal.Text = "0.00";
            txt_twenty.Text = "0";
            txt_twentytotal.Text = "0.00";
            txt_fifty.Text = "0";
            txt_fiftytotal.Text = "0.00";
            txt_hundrad.Text = "0";
            txt_hundradtotal.Text = "0.00";
            txt_fivehundrad.Text = "0";
            txt_fivehundradtotal.Text = "0.00";
            txt_thosand.Text = "0";
            txt_totalThousand.Text = "0.00";
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            obj.InsertDayClosing(lbl_fiftyps.Text, txt_fiftyPs.Text, txt_fiftyPstotal.Text);
            obj.InsertDayClosing(lbl_One.Text, txt_one.Text, txt_oneTotal.Text);
            obj.InsertDayClosing(lbl_two.Text, txt_two.Text, txt_twototal.Text);
            obj.InsertDayClosing(lbl_five.Text, txt_five.Text, txt_fivetotal.Text);
            obj.InsertDayClosing(lbl_ten.Text, txt_ten.Text, txt_tentotal.Text);
            obj.InsertDayClosing(lbl_twenty.Text, txt_twenty.Text, txt_twentytotal.Text);
            obj.InsertDayClosing(lbl_fifty.Text, txt_fifty.Text, txt_fiftytotal.Text);
            obj.InsertDayClosing(lbl_hundrad.Text, txt_hundrad.Text, txt_hundradtotal.Text);
            obj.InsertDayClosing(fivehundrad.Text, txt_fivehundrad.Text, txt_fivehundradtotal.Text);
            obj.InsertDayClosing(lbl_thousand.Text, txt_thosand.Text, txt_totalThousand.Text);
            MessageBox.Show("Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
            

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_viewreport_Click(object sender, EventArgs e)
        {
            ViewDayClosing v = new ViewDayClosing();
            v.ShowDialog();
        }
    }
}
