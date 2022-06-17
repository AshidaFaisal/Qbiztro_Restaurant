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
    public partial class ReportGoodsRec : Form
    {
        public ReportGoodsRec()
        {
            InitializeComponent();
        }
        //int counterId = Convert.ToInt32(File.ReadAllText("counter.txt"));
        Codebehind objcode = new Codebehind();
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        DataTable dtKOT, dtKOTTake, dtCounterBill, dtBill;
        Font font20 = new Font("Arial", 20, GraphicsUnit.Point);
        Font font15 = new Font("Arial", 15, GraphicsUnit.Point);
        Font font8 = new Font("Arial", 8, GraphicsUnit.Point);
        Font font5 = new Font("Arial", 5, GraphicsUnit.Point);
        Font font9 = new Font("Arial", 9, GraphicsUnit.Point);
        Font font10 = new Font("Arial", 10, GraphicsUnit.Point);
        Font font12 = new Font("Arial", 12, GraphicsUnit.Point);
        SolidBrush sBrush = new SolidBrush(Color.Black);
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
        private void ReportGoodsRec_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();

                chkbxCust.Checked = false;
                grpDealer.Enabled = false;

                checkitem.Checked = false;
                grpitem.Enabled = false;

                btndetailreport.Visible = false;


                if (checkitem.Checked == true)
                {
                    btnViewReport.Visible = false;
                    btndetailreport.Visible = true;
                }
                
                DataSet ds2 = new DataSet();
                ds2 = objcode.GetItem(0);
                cbox_ItemCode.DataSource = ds2.Tables[0];
                cbox_ItemCode.DisplayMember = "ItemName";
                cbox_ItemCode.ValueMember = "Id";
                DataRow dr2 = ds2.Tables[0].NewRow();
                dr2["ItemName"] = "--Select One--";
                dr2["Id"] = "0";
                ds2.Tables[0].Rows.InsertAt(dr2, 0);
                cbox_ItemCode.SelectedIndex = 0;

                DataSet ds1 = new DataSet();
                ds1 = objcode.GetDealer();
                cboxCust.DataSource = ds1.Tables[0];
                cboxCust.DisplayMember = "dealer_name";
                cboxCust.ValueMember = "Dealer_id";
                DataRow dr = ds1.Tables[0].NewRow();
                dr["dealer_name"] = "--Select One--";
                dr["Dealer_id"] = "0";
                ds1.Tables[0].Rows.InsertAt(dr, 0);
                cboxCust.SelectedIndex = 0;

            }
            catch (Exception ex)
            {

            }
                
        }
        int f = 0;
        private void rd_monthly_CheckedChanged(object sender, EventArgs e)
        {
            f = 1;
            dtpEndDate.Value = DateTime.Now;
            dtpStartDate.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day);
            f = 0;
        }

        private void rd_custom_CheckedChanged(object sender, EventArgs e)
        {
            f = 1;
            dtpStartDate.Value = DateTime.Now.AddDays(-6);
            dtpEndDate.Value = DateTime.Now;
            f = 0;
        }

        private void ch_date_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_date.Checked == true)
            {
                grpbxDate.Enabled = true;
            }
            else
            {
                grpbxDate.Enabled = false;
            }



            if (chkbxCust.Checked == true)
            {
                grpDealer.Enabled = true;




                btnViewReport.Visible = true;
                btndetailreport.Visible = false;


            }
          if (checkitem.Checked == true)
            {
                grpitem.Enabled = true;

                btnViewReport.Visible = false;
                btndetailreport.Visible = true;
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
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

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (f == 0)
            {
                DateChanging();
            } 
        }

        private void chkbxCust_CheckedChanged(object sender, EventArgs e)
        {

            if (chkbxCust.Checked == true)
            {
                grpDealer.Enabled = true;




                btnViewReport.Visible = true;
                btndetailreport.Visible = false;


            }
            if (checkitem.Checked == true)
            {
                grpitem.Enabled = true;

                btnViewReport.Visible = false;
                btndetailreport.Visible = true;
            }
            if (chkbxCust.Checked == false)
            {
                grpDealer.Enabled = false;
                cboxCust.SelectedIndex = 0;
            }
        }

        private void cboxCust_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cboxCust.DroppedDown)
            {
                cboxCust.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (checkitem.Checked == true)
                {

                    if (cbox_ItemCode.SelectedIndex > 0)
                    {
                        if (chkbxCust.Checked == false)
                        {

                            FrmGoodsReceiptMain obj = new FrmGoodsReceiptMain(Convert.ToInt32(cboxCust.SelectedValue.ToString()), Convert.ToInt32(cbox_ItemCode.SelectedValue.ToString()), 1, dtpStartDate.Value, dtpEndDate.Value);
                            obj.ShowDialog();
                        }


                        //if (checkitem.Checked == false)
                        //{

                        //    FrmGoodsReceiptMain obj = new FrmGoodsReceiptMain(Convert.ToInt32(cboxCust.SelectedValue.ToString()), Convert.ToInt32(cbox_ItemCode.SelectedValue.ToString()), 2, dtpStartDate.Value, dtpEndDate.Value);
                        //    obj.ShowDialog();
                        //}

                        if (chkbxCust.Checked == true)
                        {
                            if (cboxCust.SelectedIndex > 0)
                            {

                                FrmGoodsReceiptMain obj = new FrmGoodsReceiptMain(Convert.ToInt32(cboxCust.SelectedValue.ToString()), Convert.ToInt32(cbox_ItemCode.SelectedValue.ToString()), 2, dtpStartDate.Value, dtpEndDate.Value);
                                obj.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Please select Dealer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cboxCust.Focus();

                            }
                        }
                    }

                    else
                    {

                        MessageBox.Show("Please select Item code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               cbox_ItemCode.Focus();
                    }
                }


                //if (checkitem.Checked == true)
                //{
                //    if (cbox_ItemCode.SelectedIndex > 0)
                //    {

                //        FrmGoodsReceiptMain obj = new FrmGoodsReceiptMain(Convert.ToInt32(cboxCust.SelectedValue.ToString()), Convert.ToInt32(cbox_ItemCode.SelectedValue.ToString()), 1, dtpStartDate.Value, dtpEndDate.Value);
                //        obj.ShowDialog();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Please select Item code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        cboxCust.Focus();

                //    }
                //}
            }

            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

            //if (chkbxCust.Checked == false)
            //{

            //    //FrmGoodsReceiptMain obj = new FrmGoodsReceiptMain(Convert.ToInt32(cboxCust.SelectedValue.ToString()), 0, 2, dtpStartDate.Value, dtpEndDate.Value);
            //    //obj.ShowDialog();
            //}
            //if (chkbxCust.Checked == true)
            //{

            //    //FrmGoodsReceiptMain obj = new FrmGoodsReceiptMain(Convert.ToInt32(cboxCust.SelectedValue.ToString()), 0, 1, dtpStartDate.Value, dtpEndDate.Value);
            //    //obj.ShowDialog();
            //}
            if ((chkbxCust.Checked == false) && (checkitem.Checked == true))
            {
                //if (cbox_ItemCode.SelectedIndex < 1)
                //{
                //    MessageBox.Show("Select Item", "Message");
                //    return;
                //}

                //FrmGoodsReceiptBrief obj = new FrmGoodsReceiptBrief(Convert.ToInt32(cboxCust.SelectedValue.ToString()), 0, 2, dtpStartDate.Value, dtpEndDate.Value);
                //obj.ShowDialog();
            }
            else if ((checkitem.Checked == false) && (chkbxCust.Checked == true))
            {

                //if (cboxCust.SelectedIndex < 1)
                //{
                //    MessageBox.Show("Select Dealer", "Message");
                //    return;
                //}
                //FrmGoodsReceiptBrief obj = new FrmGoodsReceiptBrief(Convert.ToInt32(cboxCust.SelectedValue.ToString()), 0, 1, dtpStartDate.Value, dtpEndDate.Value);
                //obj.ShowDialog();
            }
            else if ((chkbxCust.Checked == true) && (checkitem.Checked == true))
            {
                //if (cboxCust.SelectedIndex < 1)
                //{
                //    MessageBox.Show("Select Dealer", "Message");
                //    return;
                //}
                //if (cbox_ItemCode.SelectedIndex < 1)
                //{
                //    MessageBox.Show("Select Item", "Message");
                //    return;
                //}

            }

            else if ((chkbxCust.Checked == false) && (checkitem.Checked == false))
            {

            }

        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {

            try
            {
                int Intchk = objcode.CheckInternetConnection();
                if (Intchk == 1)
                {
                    //if (chkbxCust.Checked == false && ch_date.Checked == false && checkitem.Checked == false)
                    //{

                    //    FrmGoodsReceiptBrief obj = new FrmGoodsReceiptBrief(Convert.ToInt32(cboxCust.SelectedValue.ToString()), 0, 4, dtpStartDate.Value, dtpEndDate.Value);
                    //    obj.ShowDialog();
                    //}
                  

                    if (chkbxCust.Checked == false)
                    {

                        FrmGoodsReceiptBrief obj = new FrmGoodsReceiptBrief(Convert.ToInt32(cboxCust.SelectedValue.ToString()), 0, 2, dtpStartDate.Value, dtpEndDate.Value);
                        obj.ShowDialog();
                    }
                    if (chkbxCust.Checked == true)
                    {
                        if (cboxCust.SelectedIndex > 0)
                        {
                            FrmGoodsReceiptBrief obj = new FrmGoodsReceiptBrief(Convert.ToInt32(cboxCust.SelectedValue.ToString()), 0, 1, dtpStartDate.Value, dtpEndDate.Value);
                            obj.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Please select Dealer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cboxCust.Focus();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

            //if ((chkbxCust.Checked == false) && (checkitem.Checked == true))
            //{
            //    if (cbox_ItemCode.SelectedIndex < 1)
            //    {
            //        MessageBox.Show("Select Item", "Message");
            //        return;
            //    }
            //    //DEALER CHECKED FALSE
            //    //FrmGoodsReceiptBrief obj = new FrmGoodsReceiptBrief(Convert.ToInt32(cboxCust.SelectedValue.ToString()), 0, 2, dtpStartDate.Value, dtpEndDate.Value);
            //    //obj.ShowDialog();
            //}
            //else if ((checkitem.Checked == false)&&(chkbxCust.Checked == true))
            //{

            //    if (cboxCust.SelectedIndex < 1)
            //    {
            //        MessageBox.Show("Select Dealer", "Message");
            //        return;
            //    }
            //    //DEALER CHECKED TRUE
            //    //FrmGoodsReceiptBrief obj = new FrmGoodsReceiptBrief(Convert.ToInt32(cboxCust.SelectedValue.ToString()), 0, 1, dtpStartDate.Value, dtpEndDate.Value);
            //    //obj.ShowDialog();
            //}
            //else if ((chkbxCust.Checked == true) && (checkitem.Checked == true))
            //{
            //    if (cboxCust.SelectedIndex < 1)
            //    {
            //        MessageBox.Show("Select Dealer", "Message");
            //        return;
            //    }
            //    if (cbox_ItemCode.SelectedIndex < 1)
            //    {
            //        MessageBox.Show("Select Item", "Message");
            //        return;
            //    }

            //}

            //else if ((chkbxCust.Checked == false) && (checkitem.Checked == false))
            //{

            //}

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (chkbxCust.Checked == true)
            {
                grpDealer.Enabled = true;




                btnViewReport.Visible = true;
                btndetailreport.Visible = false;


            }
            if (checkitem.Checked == true)
            {
                grpitem.Enabled = true;

                btnViewReport.Visible = false;
                btndetailreport.Visible = true;
            }


            if (checkitem.Checked == false)
            {
                grpitem.Enabled = false;
                cbox_ItemCode.SelectedIndex = 0;
            }
            if (checkitem.Checked == false)
            {
                btnViewReport.Visible = true;
                btndetailreport.Visible = false;
            }
        }
















        //
    }
}
