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
    public partial class DealerSearch : Form
    {
        public DealerSearch()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
        private void DealerSearch_Load(object sender, EventArgs e)
        {
            //ApplyTheme();
        }

        private void txt_custname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int Intchk = obj.CheckInternetConnection();
                if (Intchk == 1)
                {
                    dgvCustomer.Rows.Clear();
                    DataTable dt1 = new DataTable();
                    if (chstart.Checked == true)
                    {
                        dt1 = obj.DealerSearch("0", txt_custname.Text, "1");
                    }
                    else
                    {
                        dt1 = obj.DealerSearch("0", txt_custname.Text, "2");
                    }
                    if (dt1.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt1.Rows.Count; i++)
                        {
                            dgvCustomer.Rows.Add();
                            dgvCustomer[0, i].Value = i + 1;
                            dgvCustomer[1, i].Value = dt1.Rows[i]["dealer_name"].ToString();
                            dgvCustomer[2, i].Value = dt1.Rows[i]["address"].ToString();
                            dgvCustomer[3, i].Value = dt1.Rows[i]["phno"].ToString();
                            dgvCustomer[4, i].Value = dt1.Rows[i]["email"].ToString();
                            dgvCustomer[5, i].Value = dt1.Rows[i]["tin_no"].ToString();
                            dgvCustomer[6, i].Value = dt1.Rows[i]["cst_no"].ToString();
                            dgvCustomer[7, i].Value = dt1.Rows[i]["dealer_id"].ToString();
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

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public DialogResult dr;
        public string id;

        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                id = dgvCustomer[7, e.RowIndex].Value.ToString();
                dr = DialogResult.OK;
                this.Close();
            }
        }

        private void txt_custname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                dgvCustomer.Focus();
            }
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txt_mob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                dgvCustomer.Focus();
            }
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txt_mob_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int Intchk = obj.CheckInternetConnection();
                if (Intchk == 1)
                {
                    dgvCustomer.Rows.Clear();

                    DataTable dt1 = new DataTable();

                    if (txt_mob.Text != string.Empty)
                    {
                        dt1 = obj.DealerSearch(txt_mob.Text, "0", "3");
                    }
                    else
                    {
                        MessageBox.Show("Please Enter a Mobile No.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_mob.Focus();
                    }


                    if (dt1.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt1.Rows.Count; i++)
                        {
                            dgvCustomer.Rows.Add();
                            dgvCustomer[0, i].Value = i + 1;
                            dgvCustomer[1, i].Value = dt1.Rows[i]["dealer_name"].ToString();
                            dgvCustomer[2, i].Value = dt1.Rows[i]["address"].ToString();
                            dgvCustomer[3, i].Value = dt1.Rows[i]["phno"].ToString();
                            dgvCustomer[4, i].Value = dt1.Rows[i]["email"].ToString();
                            dgvCustomer[5, i].Value = dt1.Rows[i]["tin_no"].ToString();
                            dgvCustomer[6, i].Value = dt1.Rows[i]["cst_no"].ToString();
                            dgvCustomer[7, i].Value = dt1.Rows[i]["dealer_id"].ToString();
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

        private void dgvCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    int c = dgvCustomer.CurrentCell.RowIndex;
                    id = dgvCustomer[7, c].Value.ToString();
                    dr = DialogResult.OK;
                    this.Close();
                }
                if (e.KeyData == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            chBetwn.Checked = true;
            txt_custname.Text = "";
            txt_mob.Text = "";
            dgvCustomer.Rows.Clear();
        }

        private void btnReset_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                chBetwn.Checked = true;
                txt_custname.Text = "";
                txt_mob.Text = "";
                dgvCustomer.Rows.Clear();
            }
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Btn_Close_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.Close();
            }
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
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

        private void txt_custname_DoubleClick(object sender, EventArgs e)
        {
            txt_custname.SelectAll();
        }

        private void txt_mob_DoubleClick(object sender, EventArgs e)
        {
            txt_mob.SelectAll();
        }
    }
}
