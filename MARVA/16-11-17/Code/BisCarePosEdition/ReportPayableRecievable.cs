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
    public partial class ReportPayableRecievable : Form
    {
        public ReportPayableRecievable()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                //int Intchk = ObjCode.CheckInternetConnection();
                //if (Intchk == 1)
                //{
                if (rbtnPayable.Checked == true)
                {
                    if ((chkbxCustomer.Checked == false) && (chkbxDate.Checked == false))
                    {
                        FrmReportPayable Obj = new FrmReportPayable(dtpStartDate.Value, dtpEndDate.Value, Convert.ToInt32(cboxCust.SelectedValue), 1, 2);
                        Obj.ShowDialog();
                    }
                    if ((chkbxCustomer.Checked == true) && (chkbxDate.Checked == false))
                    {
                        if (cboxCust.SelectedValue != null)
                        {
                            FrmReportPayable Obj = new FrmReportPayable(dtpStartDate.Value, dtpEndDate.Value, Convert.ToInt32(cboxCust.SelectedValue), 2, 2);
                            Obj.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Please Select A Customer.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cboxCust.Focus();
                        }
                    }
                    if ((chkbxCustomer.Checked == true) && (chkbxDate.Checked == true))
                    {
                        if (cboxCust.SelectedValue != null)
                        {
                            FrmReportPayable Obj = new FrmReportPayable(dtpStartDate.Value, dtpEndDate.Value, Convert.ToInt32(cboxCust.SelectedValue), 3, 2);
                            Obj.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Please Select A Customer.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cboxCust.Focus();
                        }
                    }
                    if ((chkbxCustomer.Checked == false) && (chkbxDate.Checked == true))
                    {
                        FrmReportPayable Obj = new FrmReportPayable(dtpStartDate.Value, dtpEndDate.Value, Convert.ToInt32(cboxCust.SelectedValue), 4, 2);
                        Obj.ShowDialog();
                    }
                }
                else
                {
                    if ((chkbxCustomer.Checked == false) && (chkbxDate.Checked == false))
                    {
                        FrmPrintPayableRecievable Obj = new FrmPrintPayableRecievable(dtpStartDate.Value, dtpEndDate.Value, Convert.ToInt32(cboxCust.SelectedValue), 1, 1);
                        Obj.ShowDialog();
                    }
                    if ((chkbxCustomer.Checked == true) && (chkbxDate.Checked == false))
                    {
                        if (cboxCust.SelectedValue != null)
                        {
                            FrmPrintPayableRecievable Obj = new FrmPrintPayableRecievable(dtpStartDate.Value, dtpEndDate.Value, Convert.ToInt32(cboxCust.SelectedValue), 2, 1);
                            Obj.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Please Select A Customer.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cboxCust.Focus();
                        }
                    }
                    if ((chkbxCustomer.Checked == true) && (chkbxDate.Checked == true))
                    {
                        if (cboxCust.SelectedValue != null)
                        {
                            FrmPrintPayableRecievable Obj = new FrmPrintPayableRecievable(dtpStartDate.Value, dtpEndDate.Value, Convert.ToInt32(cboxCust.SelectedValue), 3, 1);
                            Obj.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Please Select A Customer.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cboxCust.Focus();
                        }
                    }
                    if ((chkbxCustomer.Checked == false) && (chkbxDate.Checked == true))
                    {
                        FrmPrintPayableRecievable Obj = new FrmPrintPayableRecievable(dtpStartDate.Value, dtpEndDate.Value, Convert.ToInt32(cboxCust.SelectedValue), 4, 1);
                        Obj.ShowDialog();
                    }
                }
                //}
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cboxCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////if (f == 1)
            ////{
            ////    cboxCust.SelectedIndex = 0;
            ////}
            //if (chkbxCustomer.Checked == true)
            //{
            //    cboxCust.Enabled = true;
            //}
            //else
            //{
            //    cboxCust.Enabled = false;
            //}
        }
        Codebehind ObjCode = new Codebehind();
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

        private void ReportPayableRecievable_Load(object sender, EventArgs e)
        {
            try
            {
                //    ApplyTheme();
                //int Intchk = ObjCode.CheckInternetConnection();
                //if (Intchk == 1)
                //{
                rbtnPayable.Checked = false;
                rbtnPayable.Checked = true;
                //cboxCust.Visible = true;
                //cboxCust.Enabled = false;
                //DataSet ds2 = new DataSet();
                //ds2 = ObjCode.GetDealer();
                //cboxCust.DataSource = ds2.Tables[0];
                //cboxCust.DisplayMember = "dealer_name";
                //cboxCust.ValueMember = "dealer_id";


                //DataRow dr = ds2.Tables[0].NewRow();
                //dr["dealer_name"] = "--Select One--";
                //dr["dealer_id"] = "0";
                //ds2.Tables[0].Rows.InsertAt(dr, 0);
                //cboxCust.SelectedIndex = 0;


                //DataSet ds1 = new DataSet();
                //ds1 = ObjCode.GetCustomer();
                //cboxCust.DataSource = ds1.Tables[0];
                //cboxCust.DisplayMember = "customer_name";
                //cboxCust.ValueMember = "customer_id";

                //DataRow dr1 = ds1.Tables[0].NewRow();
                //dr1["customer_name"] = "--Select One--";
                //dr1["customer_id"] = "0";
                //ds1.Tables[0].Rows.InsertAt(dr1, 0);
                //cboxCust.SelectedIndex = 0;
                //}
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void rbtnRecievable_CheckedChanged(object sender, EventArgs e)
        {
            chkbxCustomer.Checked = false;
            try
            {
                int Intchk = ObjCode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    if (rbtnRecievable.Checked == true)
                    {
                        DataSet ds1 = new DataSet();
                        ds1 = ObjCode.GetCustomer();
                        cboxCust.DataSource = ds1.Tables[0];
                        cboxCust.DisplayMember = "customer_name";
                        cboxCust.ValueMember = "customer_id";
                        DataRow dr1 = ds1.Tables[0].NewRow();
                        dr1["customer_name"] = "--Select One--";
                        dr1["customer_id"] = "0";
                        ds1.Tables[0].Rows.InsertAt(dr1, 0);
                        cboxCust.SelectedIndex = 0;

                        chkbxCustomer.Text = "Include Customer";
                        chkbxDate.Text = "Include Date with Customer";

                        Lbl_Customer.Visible = true;
                        cboxCust.Visible = true;
                        cboxCust.Enabled = false;
                        Lbl_Dealer.Visible = false;

                    }
                    else
                    {
                        //DataSet ds2 = new DataSet();
                        //ds2 = ObjCode.GetDealer();
                        //cboxCust.DataSource = ds2.Tables[0];
                        //cboxCust.DisplayMember = "dealer_name";
                        //cboxCust.ValueMember = "dealer_id";
                        //DataRow dr = ds2.Tables[0].NewRow();
                        //dr["dealer_name"] = "--Select One--";
                        //dr["dealer_id"] = "0";
                        //ds2.Tables[0].Rows.InsertAt(dr, 0);
                        //cboxCust.SelectedIndex = 0;

                        //chkbxCustomer.Text = "Include Dealer";
                        //chkbxDate.Text = "Include Date with Dealer";

                        //Lbl_Customer.Visible = false;
                        //Lbl_Dealer.Visible = true;
                        //cboxCust.Visible = true;
                        //cboxCust.Enabled = false;

                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cboxCust_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cboxCust.DroppedDown)
            {
                cboxCust.Focus();


            }
        }

        private void rd_monthly_CheckedChanged(object sender, EventArgs e)
        {
            f = 1;
            dtpEndDate.Value = DateTime.Now;
            dtpStartDate.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day);
            f = 0;
        }

        private void rd_weekly_CheckedChanged(object sender, EventArgs e)
        {
            f = 1;
            dtpStartDate.Value = DateTime.Now.AddDays(-6);
            dtpEndDate.Value = DateTime.Now;
            f = 0;
        }
        public void DateChanging()
        {
            var MonthFirstDay = new DateTime(Convert.ToInt32(DateTime.Now.Year), Convert.ToInt32(DateTime.Now.Month), 1);
            var LastweekFistDay = DateTime.Now.AddDays(-6);
            if ((dtpStartDate.Value.ToShortDateString() == MonthFirstDay.ToShortDateString()) && (dtpEndDate.Value.ToShortDateString() == DateTime.Now.ToShortDateString()))
            {
                rd_monthly.Checked = true;
            }
            else if ((dtpStartDate.Value.ToShortDateString() == LastweekFistDay.ToShortDateString()) && (dtpEndDate.Value.ToShortDateString() == DateTime.Now.ToShortDateString()))
            {
                rd_weekly.Checked = true;
            }
            else
            {
                rd_custom.Checked = true;
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (f == 0)
            {
                DateChanging();
            }    
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (f == 0)
            {
                DateChanging();
            }    
        }

        private void chkbxCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (f == 1)
            {
                cboxCust.SelectedIndex = 0;
            }
            if (chkbxCustomer.Checked == true)
            {
                cboxCust.Enabled = true;
            }
            else
            {
                cboxCust.Enabled = false;
            }
        }

        private void chkbxDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxDate.Checked == true)
            {
                grp_date.Enabled = true;
            }
            else
            {
                grp_date.Enabled = false ;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            chkbxCustomer.Checked = false;
            try
            {
                //int Intchk = ObjCode.CheckInternetConnection();
                //if (Intchk == 1)
                //{
                if (rbtnRecievable.Checked == true)
                {
                    DataSet ds1 = new DataSet();
                    ds1 = ObjCode.GetCustomer();
                    cboxCust.DataSource = ds1.Tables[0];
                    cboxCust.DisplayMember = "customer_name";
                    cboxCust.ValueMember = "customer_id";
                    DataRow dr1 = ds1.Tables[0].NewRow();
                    dr1["customer_name"] = "--Select One--";
                    dr1["customer_id"] = "0";
                    ds1.Tables[0].Rows.InsertAt(dr1, 0);
                    cboxCust.SelectedIndex = 0;

                    chkbxCustomer.Text = "Include Customer";
                    chkbxDate.Text = "Include Date with Customer";

                    Lbl_Customer.Visible = true;
                    cboxCust.Visible = true;
                    cboxCust.Enabled = false;
                    Lbl_Dealer.Visible = false;

                }
                else
                {
                    DataSet ds2 = new DataSet();
                    ds2 = ObjCode.GetDealer();
                    cboxCust.DataSource = ds2.Tables[0];
                    cboxCust.DisplayMember = "dealer_name";
                    cboxCust.ValueMember = "dealer_id";
                    DataRow dr = ds2.Tables[0].NewRow();
                    dr["dealer_name"] = "--Select One--";
                    dr["dealer_id"] = "0";
                    ds2.Tables[0].Rows.InsertAt(dr, 0);
                    cboxCust.SelectedIndex = 0;

                    chkbxCustomer.Text = "Include Dealer";
                    chkbxDate.Text = "Include Date with Dealer";

                    Lbl_Customer.Visible = false;
                    Lbl_Dealer.Visible = true;
                    cboxCust.Visible = true;
                    cboxCust.Enabled = false;

                }
            }
            catch (Exception ex)
            {
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnPayable_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPayable.Checked == true)
            {
                DataSet ds2 = new DataSet();
                ds2 = ObjCode.GetDealer();
                cboxCust.DataSource = ds2.Tables[0];
                cboxCust.DisplayMember = "dealer_name";
                cboxCust.ValueMember = "dealer_id";
                DataRow dr = ds2.Tables[0].NewRow();
                dr["dealer_name"] = "--Select One--";
                dr["dealer_id"] = "0";
                ds2.Tables[0].Rows.InsertAt(dr, 0);
                cboxCust.SelectedIndex = 0;

                chkbxCustomer.Text = "Include Dealer";
                chkbxDate.Text = "Include Date with Dealer";

                Lbl_Customer.Visible = false;
                Lbl_Dealer.Visible = true;
                cboxCust.Visible = true;
                cboxCust.Enabled = false;
            }

        }
    }
}
