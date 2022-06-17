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
    public partial class ReportBankTransaction : Form
    {
        public ReportBankTransaction()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
        int k = 0;
        private void ReportBankTransaction_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
                int Intchk = obj.CheckInternetConnection();
                if (Intchk == 1)
                {

                    DataSet ds = new DataSet();
                    ds = obj.LoadBankName();
                    cmb_bankname.DataSource = ds.Tables[0];
                    cmb_bankname.DisplayMember = "bank_name";
                    cmb_bankname.ValueMember = "bank_id";


                    DataRow dr1 = ds.Tables[0].NewRow();
                    dr1["bank_name"] = "--Select One--";
                    dr1["bank_id"] = "0";
                    ds.Tables[0].Rows.InsertAt(dr1, 0);
                    cmb_bankname.SelectedIndex = 0;

                    f = 1;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
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
        int f = 0;

        private void Cbox_Date_CheckedChanged(object sender, EventArgs e)
        {
            if (f == 1)
            {
                cmb_bankname.SelectedIndex = 0;
            }
            if (Cbox_Bank.Checked == true)
                cmb_bankname.Enabled = true;
            else
                cmb_bankname.Enabled = false;
        }

        private void Cbox_Type_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbox_Type.Checked == true)
            {
                Rb_Deposit.Enabled = true;
                Rb_withdrawal.Enabled = true;
            }
            else
            {
                Rb_withdrawal.Enabled = false;
                Rb_Deposit.Enabled = false;
            }
        }

        private void bttn_search_Click(object sender, EventArgs e)
        {
            try
            {
                int Intchk = obj.CheckInternetConnection();
                if (Intchk == 1)
                {
                    string type;
                    if (Rb_Deposit.Checked == true)
                        type = Rb_Deposit.Text;
                    else
                        type = Rb_withdrawal.Text;

                    if ((Cbox_Bank.Checked == true) && (Cbox_Type.Checked == false) && (Cbox_Date.Checked == false))//by bank mod 1
                    {
                        if (Convert.ToInt32(cmb_bankname.SelectedValue) == 0)
                            MessageBox.Show("Please Select Bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            FrmBankTransReportByBank obj1 = new FrmBankTransReportByBank(Convert.ToInt32(cmb_bankname.SelectedValue), type, Dtp_Start.Value, Dtp_End.Value, 1);
                            obj1.ShowDialog();
                        }
                    }

                    if ((Cbox_Bank.Checked == false) && (Cbox_Type.Checked == true) && (Cbox_Date.Checked == false))//by type mod2
                    {

                        FrmBankTransByType obj1 = new FrmBankTransByType(Convert.ToInt32(cmb_bankname.SelectedValue), type, Dtp_Start.Value, Dtp_End.Value, 2);
                        obj1.ShowDialog();

                    }

                    if ((Cbox_Bank.Checked == false) && (Cbox_Type.Checked == false) && (Cbox_Date.Checked == true))//by date mod3
                    {
                        FrmBankTransReport obj1 = new FrmBankTransReport(Convert.ToInt32(cmb_bankname.SelectedValue), type, Dtp_Start.Value, Dtp_End.Value, 3);
                        obj1.ShowDialog();

                    }

                    if ((Cbox_Bank.Checked == true) && (Cbox_Type.Checked == true) && (Cbox_Date.Checked == false))//by bank and type mod4
                    {
                        if (Convert.ToInt32(cmb_bankname.SelectedValue) == 0)
                            MessageBox.Show("Please Select Bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            FrmBankTransReportByBank obj1 = new FrmBankTransReportByBank(Convert.ToInt32(cmb_bankname.SelectedValue), type, Dtp_Start.Value, Dtp_End.Value, 4);
                            obj1.ShowDialog();
                        }
                    }

                    if ((Cbox_Bank.Checked == true) && (Cbox_Type.Checked == false) && (Cbox_Date.Checked == true))//by bank and date mod5
                    {
                        if (Convert.ToInt32(cmb_bankname.SelectedValue) == 0)
                            MessageBox.Show("Please Select Bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            FrmBankTransReportByBank obj1 = new FrmBankTransReportByBank(Convert.ToInt32(cmb_bankname.SelectedValue), type, Dtp_Start.Value, Dtp_End.Value, 5);
                            obj1.ShowDialog();
                        }
                    }

                    if ((Cbox_Bank.Checked == false) && (Cbox_Type.Checked == true) && (Cbox_Date.Checked == true))//by Type and Date mod6
                    {
                        FrmBankTransByType obj1 = new FrmBankTransByType(Convert.ToInt32(cmb_bankname.SelectedValue), type, Dtp_Start.Value, Dtp_End.Value, 6);
                        obj1.ShowDialog();

                    }

                    if ((Cbox_Bank.Checked == true) && (Cbox_Type.Checked == true) && (Cbox_Date.Checked == true))//by date, bank and type mod7
                    {
                        if (Convert.ToInt32(cmb_bankname.SelectedValue) == 0)
                            MessageBox.Show("Please Select Bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            FrmBankTransReportByBank obj1 = new FrmBankTransReportByBank(Convert.ToInt32(cmb_bankname.SelectedValue), type, Dtp_Start.Value, Dtp_End.Value, 7);
                            obj1.ShowDialog();
                        }
                    }
                    if ((Cbox_Bank.Checked == false) && (Cbox_Type.Checked == false) && (Cbox_Date.Checked == false))
                    {
                        MessageBox.Show("Please Select Any Searching Criteria", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cmb_bankname_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_bankname.DroppedDown)
            {
                cmb_bankname.Focus();


            }
        }

        private void rd_monthly_CheckedChanged(object sender, EventArgs e)
        {
            f = 1;
            //groupBox2.Enabled = false;
            Dtp_End.Value = DateTime.Now;
            Dtp_Start.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day);
            f = 0;
        }

        private void rd_weekly_CheckedChanged(object sender, EventArgs e)
        {
            f = 1;
            //groupBox2.Enabled = false;
            Dtp_Start.Value = DateTime.Now.AddDays(-6);
            Dtp_End.Value = DateTime.Now;
            f = 0;
        }

        private void Dtp_Start_ValueChanged(object sender, EventArgs e)
        {
            if (f == 0)
            {
                DateChanging();
            }          
        }
        public void DateChanging()
        {
            var MonthFirstDay = new DateTime(Convert.ToInt32(DateTime.Now.Year), Convert.ToInt32(DateTime.Now.Month), 1);
            var LastweekFistDay = DateTime.Now.AddDays(-6);
            if ((Dtp_Start.Value.ToShortDateString() == MonthFirstDay.ToShortDateString()) && (Dtp_End.Value.ToShortDateString() == DateTime.Now.ToShortDateString()))
            {
                rd_monthly.Checked = true;
            }
            else if ((Dtp_Start.Value.ToShortDateString() == LastweekFistDay.ToShortDateString()) && (Dtp_End.Value.ToShortDateString() == DateTime.Now.ToShortDateString()))
            {
                rd_weekly.Checked = true;
            }
            else
            {
                rd_custom.Checked = true;
            }
        }

        private void Dtp_End_ValueChanged(object sender, EventArgs e)
        {
            if (f == 0)
            {
                DateChanging();
            }      
        }

        private void Cbox_Bank_CheckedChanged(object sender, EventArgs e)
        {
            if (f == 1)
            {
                cmb_bankname.SelectedIndex = 0;
            }
            if (Cbox_Bank.Checked == true)
                cmb_bankname.Enabled = true;
            else
                cmb_bankname.Enabled = false;
        }
    }
}
