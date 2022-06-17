using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace BisCarePosEdition
{
    public partial class Billing_Features : Form
    {
        Codebehind obj = new Codebehind();
        string invoicest = "0", logost = "0", waiterst = "0", tablest = "0", counterst = "0", cashierst = "0", datest = "0";
        string adfontstatus = "0",gtfontstatus="0",slnostatus="0",itemstatus="0",qtystatus="0",pricest="0",amtst="0",itemcodest="0";
        public Billing_Features()
        {
            InitializeComponent();
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

        private void Billing_Features_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            DataTable dt1 = new DataTable();
            dt1 = obj.getprinterfeatures();
            if (dt1.Rows[0]["id"].ToString() != null)
            {
                checkBoxinvoice.Checked = true;
                checkBoxdate.Checked = true;
                checkBoxlogo.Checked = true;
                checkBoxtable.Checked = true;
                checkBoxwaiter.Checked = true;
                checkBoxcashier.Checked = false;
                checkBoxcounter.Checked = false;
                checkBoxBold.Checked = true;
                checkBoxitalic.Checked = false;
                checkBoxbid.Checked = true;
                checkBoxit.Checked = false;
                checkBoxqty.Checked = true;
                checkBoxslno.Checked = true;
                checkBoxp.Checked = true;
                checkBoxitem.Checked = true;
                checkBoxcode.Checked = false;
                checkBoxamnt.Checked = true;
                if (dt1.Rows[0]["address1"].ToString() != null)
                {
                    txt_ad1.Text = dt1.Rows[0]["address1"].ToString();
                }
                if (dt1.Rows[0]["address2"].ToString() != null)
                {
                    txt_ad2.Text = dt1.Rows[0]["address2"].ToString();
                }
                if (dt1.Rows[0]["address3"].ToString() != null)
                {
                    txt_ad3.Text = dt1.Rows[0]["address3"].ToString();
                }
                if (dt1.Rows[0]["address4"].ToString() != null)
                {
                    txt_ad4.Text = dt1.Rows[0]["address4"].ToString();
                }
                if (dt1.Rows[0]["address5"].ToString() != null)
                {
                    txt_ad5.Text = dt1.Rows[0]["address5"].ToString();
                }
                if (dt1.Rows[0]["greeting1"].ToString() != null)
                {
                    txt_g1.Text = dt1.Rows[0]["greeting1"].ToString();
                }
                if (dt1.Rows[0]["greeting2"].ToString() != null)
                {
                    txt_g2.Text = dt1.Rows[0]["greeting2"].ToString();

                }
                if (dt1.Rows[0]["PrintCount"].ToString() != null)
                {
                    txt_count.Text = dt1.Rows[0]["PrintCount"].ToString();
                }
                if (dt1.Rows[0]["BillName"].ToString() != null)
                {
                    txt_billname.Text = dt1.Rows[0]["BillName"].ToString();
                }
                if (dt1.Rows[0]["currency"].ToString() != null)
                {
                    txt_currency.Text = dt1.Rows[0]["currency"].ToString();
                }
              
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
        string savesatus;
        private void btn_Login_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = obj.getprinterfeatures();
            if (dt.Rows[0]["Id"].ToString() == null)
            {
                savesatus = " 0";
            }
            else
            {
                savesatus = "1";
            }
               
            try
            {
                if (checkBoxinvoice.Checked == true)
                {
                    invoicest = "1";
                }
                if (checkBoxlogo.Checked == true)
                {
                    logost = "1";
                }
                if (checkBoxtable.Checked == true)
                {
                    tablest = "1";
                }
                if (checkBoxwaiter.Checked == true)
                {
                    waiterst = "1";
                }
                if (checkBoxcashier.Checked == true)
                {
                    cashierst = "1";
                }
                if (checkBoxcounter.Checked == true)
                {
                    counterst = "1";
                }
                if (checkBoxdate.Checked == true)
                {
                    datest = "1";
                }
                if (checkBoxBold.Checked == true)
                {     adfontstatus ="Bold";
                }
                if (checkBoxitalic.Checked == true)
                {
                    adfontstatus = "Italics" ;
                }
                if (checkBoxbid.Checked == true)
                {    
                    gtfontstatus = "Bold";
                }
                if (checkBoxit.Checked == true)
                {
                    gtfontstatus = "Italics";
                }
                if (checkBoxqty.Checked == true)
                {
                    qtystatus = "1";
                }
                if (checkBoxslno.Checked == true)
                {
                    slnostatus = "1";
                }
                if (checkBoxp.Checked == true)
                {
                    pricest = "1";
                }
                if (checkBoxitem.Checked == true)
                {
                    itemstatus = "1";
                }
                if (checkBoxcode.Checked == true)
                {
                    itemcodest = "1";
                }
                if (checkBoxamnt.Checked == true)
                {
                    amtst = "1";
                }
                if (savesatus == "0")
                {
                    
                    string msg = obj.insertorupdatebilling(invoicest, waiterst, tablest, txt_billname.Text, txt_count.Text, counterst, txt_ad1.Text, txt_ad2.Text, txt_ad3.Text,
                    txt_ad4.Text, txt_ad5.Text, txt_g1.Text, txt_g2.Text, slnostatus, itemstatus, qtystatus, pricest, amtst, itemcodest, adfontstatus,
                    gtfontstatus, datest, cashierst,logost,txt_currency.Text);
                    MessageBox.Show("Printing features successfully Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(adfontstatus=="Bold")
                    {
                        txt_ad1.Font = new Font(txt_ad1.Font, FontStyle.Bold);
                    }
                    else
                    {
                        txt_ad1.Font = new Font(txt_ad1.Font,FontStyle.Italic);
                    }
                    if (gtfontstatus == "Bold")
                    {
                        txt_g1.Font = new Font(txt_g1.Font, FontStyle.Bold);
                    }
                    else
                    {
                        txt_g1.Font = new Font(txt_g1.Font, FontStyle.Italic);
                    }
                        string msg = obj.updatebillingfeatures(invoicest, waiterst, tablest, txt_billname.Text, txt_count.Text, counterst, txt_ad1.Text, txt_ad2.Text, txt_ad3.Text,
                        txt_ad4.Text, txt_ad5.Text, txt_g1.Text, txt_g2.Text, slnostatus, itemstatus, qtystatus, pricest, amtst, itemcodest, adfontstatus,
                        gtfontstatus, datest, cashierst,logost,txt_currency.Text);
                        MessageBox.Show("Printing features successfully updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

            }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            checkBoxinvoice.Checked = true;
            checkBoxdate.Checked = true;
            checkBoxlogo.Checked = true;
            checkBoxtable.Checked = true;
            checkBoxwaiter.Checked = true;
            checkBoxcashier.Checked = false;
            checkBoxcounter.Checked = false;
            checkBoxBold.Checked = true;
            checkBoxitalic.Checked = false;
            checkBoxbid.Checked = true;
            checkBoxit.Checked = false;
            checkBoxqty.Checked = true;
            checkBoxslno.Checked = true;
            checkBoxp.Checked = true;
            checkBoxitem.Checked = true;
            checkBoxcode.Checked = false;
            checkBoxamnt.Checked = true;
            txt_ad1.Text = "";
            txt_ad2.Text = "";
            txt_ad3.Text = "";
            txt_ad4.Text = "";
            txt_ad5.Text = "";
            txt_billname.Text = "";
            txt_count.Text = "";
            txt_g2.Text = "";
            txt_g2.Text = "";
        }

        private void checkBoxBold_Click(object sender, EventArgs e)
        {
             checkBoxBold.Focus();
        }

        private void checkBoxbid_CheckedChanged(object sender, EventArgs e)
        {
           checkBoxit.Checked = !checkBoxbid.Checked ;
        }

        private void checkBoxitalic_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxBold.Checked = !checkBoxitalic.Checked;   
        }

        private void checkBoxit_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxbid.Checked = !checkBoxit.Checked;
        }

        private void checkBoxBold_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxitalic.Checked = !checkBoxBold.Checked;
        }
            }

        }

    


