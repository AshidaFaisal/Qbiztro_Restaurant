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
    public partial class Paymode : Form
    {
        public Paymode()
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
        private void Paymode_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            DataSet ds11 = new DataSet();
            ds11 = obj.GetInvoiceComboPaymode();
            cboxInvoice.DataSource = ds11.Tables[0];
            cboxInvoice.DisplayMember = "InvoiceNo";
            cboxInvoice.ValueMember = "Id";
            DataRow dr11 = ds11.Tables[0].NewRow();
            dr11["InvoiceNo"] = "--Select One--";
            dr11["Id"] = "0";
            ds11.Tables[0].Rows.InsertAt(dr11, 0);
            cboxInvoice.SelectedIndex = 0;

            DataSet ds1 = new DataSet();
            ds1 = obj.LoadBankName();
            cmbBank.DataSource = ds1.Tables[0];
            cmbBank.DisplayMember = "bank_name";
            cmbBank.ValueMember = "bank_id";
            DataRow dr12 = ds1.Tables[0].NewRow();
            dr12["bank_name"] = "--Select One--";
            dr12["bank_id"] = "0";
            ds1.Tables[0].Rows.InsertAt(dr12, 0);
            cmbBank.SelectedIndex = 0;

            grp_card.Enabled = false;
            grp_cheque.Enabled = false;
            cmb_paymode.SelectedIndex = 0;
        }

        private void btn_cancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string check()
        {
            string st = "0";
            if (cmb_paymode.Text == "Cheque")
            {
                if (txtCheque.Text == string.Empty)
                {
                    MessageBox.Show("Plese enter cheque no", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCheque.Focus();
                    st = "1";
                }
                else
                {
                    if (cmbBank.SelectedIndex <= 0)
                    {
                        MessageBox.Show("Plese select a Bank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbBank.Focus();
                        st = "1";
                    }

                }
            }
            if (cmb_paymode.Text == "Card")
            {
                if (txt_card.Text == string.Empty)
                {
                    MessageBox.Show("Plese enter card no", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_card.Focus();
                    st = "1";
                }
            }
            else
            {
               // st = "0";
            }
            return st;
        }
        public void clear()
        {
            cmb_paymode.SelectedIndex = 0;
            cboxInvoice.SelectedIndex = 0;
            dtChequeDate.Value = DateTime.Now;
            txt_card.Text = string.Empty;
            txtCheque.Text = string.Empty;
            cmbBank.SelectedIndex = 0;

        }
        private void btn_Save1_Click(object sender, EventArgs e)
        {
            string paymode="0";
            string realized = "0";
            string checkst = check();
            if (checkst == "0")
            {
                if (cboxInvoice.SelectedIndex > 0)
                {
                    if (cmb_paymode.Text == "Cash")
                    {
                        paymode = "1";
                        obj.InsertPaymode(paymode, cboxInvoice.SelectedValue.ToString(), txtCheque.Text, "0", dtChequeDate.Value, realized, txt_card.Text);
                    }
                    if (cmb_paymode.Text == "Card")
                    {
                        paymode = "2";
                        obj.InsertPaymode(paymode, cboxInvoice.SelectedValue.ToString(), txtCheque.Text, "0", dtChequeDate.Value, realized, txt_card.Text);
                    }
                    if (cmb_paymode.Text == "Cheque")
                    {
                        paymode = "3";
                        if (cbox_check.Checked == true)
                        {
                            realized = "1";
                        }
                        else
                        {
                            realized = "2";
                        }
                        obj.InsertPaymode(paymode, cboxInvoice.SelectedValue.ToString(), txtCheque.Text, cmbBank.SelectedValue.ToString(), dtChequeDate.Value, realized, txt_card.Text);
                    }
                    MessageBox.Show("Paymode successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    MessageBox.Show("Please select Invoice No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboxInvoice.Focus();
                }
                  
            }

            DataSet ds11 = new DataSet();
            ds11 = obj.GetInvoiceComboPaymode();
            cboxInvoice.DataSource = ds11.Tables[0];
            cboxInvoice.DisplayMember = "InvoiceNo";
            cboxInvoice.ValueMember = "Id";
            DataRow dr11 = ds11.Tables[0].NewRow();
            dr11["InvoiceNo"] = "--Select One--";
            dr11["Id"] = "0";
            ds11.Tables[0].Rows.InsertAt(dr11, 0);
            cboxInvoice.SelectedIndex = 0;
        }

        private void cmb_paymode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_paymode.Text == "Card")
            {
                grp_card.Enabled = true;
                grp_cheque.Enabled = false;
            }
            if (cmb_paymode.Text == "Cheque")
            {
                grp_cheque.Enabled = true;
                grp_card.Enabled = false;
            }
            if (cmb_paymode.Text == "Cash")
            {
                grp_card.Enabled = false;
                grp_cheque.Enabled = false;
            }
        }
    }
}
