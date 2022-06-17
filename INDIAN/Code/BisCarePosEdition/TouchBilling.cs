using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Printing;
using System.Threading;

namespace BisCarePosEdition
{
    public partial class TouchBilling : Form
    {
        public TouchBilling()
        {
            InitializeComponent();
        }
        Codebehind ObjCode = new Codebehind();

        private void tblyPanelFooter_Paint(object sender, PaintEventArgs e)
        {

        }
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        DataTable dtKOT, dtKOTTake, dtCounterBill, dtBill;
        Font font20 = new Font("Arial", 20, GraphicsUnit.Point);
        Font font15 = new Font("Arial", 15, GraphicsUnit.Point);
        Font font8 = new Font("Arial", 8, GraphicsUnit.Point);
        Font font9 = new Font("Arial", 9, GraphicsUnit.Point);
        Font font10 = new Font("Arial", 10, GraphicsUnit.Point);
        Font font12 = new Font("Arial", 12, GraphicsUnit.Point);
        Font fontarb = new Font("trado", 9, GraphicsUnit.Point);

        Font myfontb1 = new Font("Arial", 10, FontStyle.Bold);
        Font myfontb2 = new Font("Arial", 10, FontStyle.Italic);
        Font myfonti1 = new Font("Arial", 12, FontStyle.Italic);
        Font myfontb15 = new Font("", 15, FontStyle.Bold);
        Font myfonti15 = new Font("", 15, FontStyle.Italic);
        Font Addr1Font = new Font("Arial", 9, FontStyle.Bold);
        SolidBrush sBrush = new SolidBrush(Color.Black);

        Font myFontb = new Font("Arial", 12, FontStyle.Bold);



        Font font20b = new Font("Arial", 20, FontStyle.Bold);
        Font font20i = new Font("Arial", 20, FontStyle.Italic);

        Font AddrFont = new Font("", 15, FontStyle.Italic);
        Font fontKotNo = new Font("Arial", 10, FontStyle.Bold);
        Font font = new Font("Arial", 12, GraphicsUnit.Point);
        Font myFonti = new Font("Arial", 12, FontStyle.Italic);


        private void TouchBilling_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000; //ticks every 1 second
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();
            DataTable dt1 = new DataTable();
            dt1 = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Billing");
            SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
            UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
            DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();
            SqlDataReader drr = ObjCode.GetSettings();
            if (drr.Read())
            {
                if (drr[1].ToString() == "1")
                {
                    SqlDataReader dr1r = ObjCode.GetInvoiceNo();
                    if (dr1r.Read())
                    {
                        txtInvoiceNumber.Text = dr1r[0].ToString();
                        // txtInvoiceNumber.Enabled = false;
                    }
                    else
                    {
                        // txtInvoiceNumber.Enabled = true;
                    }
                }
            }
            lblDate.Text =DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"); //globalvariable.StoreDate; 
            lblHeading.Text = "";
            lblTable.Text = "......";
            lblTable.Tag = "0";
            lblToken.Text = "......";
            lblToken.Tag = "0";
            lblWaiter.Text = "......";
            lblWaiter.Tag = "0";
            btn_0.Tag = "0";
            btn_1.Tag = "1";
            btn_2.Tag = "2";
            btn_3.Tag = "3";
            btn_4.Tag = "4";
            btn_5.Tag = "5";
            btn_6.Tag = "6";
            btn_7.Tag = "7";
            btn_8.Tag = "8";
            btn_9.Tag = "9";
            ACStatus = 0;
        }
        private void tmr_Tick(object sender, EventArgs e)
        {
            lblDate.Text =DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"); //globalvariable.StoreDate; 
            //LblUTCTime.Text = DateTime.UtcNow.ToString("MM/dd/yyyy HH:mm:ss");
        }
        private void btnTable_Click(object sender, EventArgs e)
        {
            btnToken.ForeColor = Color.Maroon;
            btnWaiter.ForeColor = Color.Maroon;
            btnItem.ForeColor = Color.Maroon;
            //ButtonColor();
            btnTable.BackColor = Color.White;
            // btnTable.ForeColor = Color.Black;
            splitContainerDetails.Panel2.Controls.Clear();
            DataSet ds = new DataSet();
            ds = ObjCode.GetTable();
            DataTable dtTables = ds.Tables[0];
            if (dtTables.Rows.Count > 0)
            {
                TableLayoutPanel tblypanelDetailsCenter = new System.Windows.Forms.TableLayoutPanel();
                splitContainerDetails.Panel2.Controls.Add(tblypanelDetailsCenter);
                tblypanelDetailsCenter.AutoSize = true;
                tblypanelDetailsCenter.ColumnCount = 6;//1
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.Dock = System.Windows.Forms.DockStyle.Top;
                tblypanelDetailsCenter.Margin = new System.Windows.Forms.Padding(0);
                tblypanelDetailsCenter.Name = "tblypanelDetailsCenter";
                tblypanelDetailsCenter.Controls.Clear();
                tblypanelDetailsCenter.RowCount = (dtTables.Rows.Count / 6) + 1; //3;
                for (int i = 0; i < tblypanelDetailsCenter.RowCount; i++)
                {
                    tblypanelDetailsCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, Convert.ToInt32(70)));
                }
                int RowNum = 0, ColumnNum = 0;

                for (int i = 0; i < dtTables.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        RowNum = 0; ColumnNum = 0;
                    }
                    else if (i == 1)
                    {
                        RowNum = 0;
                        ColumnNum = 1;
                    }
                    else
                    {
                        if (i < 6)
                        {
                            RowNum = 0;
                            ColumnNum = i;
                        }
                        else
                        {
                            RowNum = i / 6;
                            ColumnNum = i % 6;
                        }
                    }
                    Button btnTable1 = new Button();
                    btnTable1.Name = "btnTable1" + i.ToString();
                    btnTable1.ForeColor = Color.White;
                    btnTable1.BackColor = Color.FromArgb(0, 85, 85);
                    btnTable1.Text = dtTables.Rows[i]["TableName"].ToString();
                    btnTable1.Tag = dtTables.Rows[i]["Id"].ToString();
                    btnTable1.Dock = System.Windows.Forms.DockStyle.Fill;
                    btnTable1.Click += new System.EventHandler(this.TableBtn_Click);
                    tblypanelDetailsCenter.Controls.Add(btnTable1, ColumnNum, RowNum);
                    
                }
                //var ty = "btnTable13";
                //this.Controls.Find("btnTable13", true)[0].BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("No tables are entered for display", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lblHeading.Text = "Select Table";

        }
        int ACStatus = 0;
        public string tablestatus = "0";

        private void TableColor(string TableName)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = ObjCode.GetTable();
                DataTable dtTables = ds.Tables[0];
                for (int i = 0; i < dtTables.Rows.Count; i++)
                {
                    if (TableName == ("btnTable1" + i.ToString()))
                    {
                        this.Controls.Find(TableName, true)[0].BackColor = Color.Red;
                    }
                    else
                    {
                        this.Controls.Find("btnTable1" + i.ToString(), true)[0].BackColor = Color.CadetBlue;
                    }


                }
            }
            catch { }

        }

        private void TableBtn_Click(object sender, EventArgs e)
        {
            double rate;
            tablestatus = "1";
            lblTable.Text = ((Button)sender).Text;
            lblTable.Tag = ((Button)sender).Tag;
            lblToken.Text = "........";
            lblToken.Tag = "0";
            dgvBill.Rows.Clear();
            ACStatus = ObjCode.TableACStat(((Button)sender).Tag.ToString());// To check the table is in AC or Non AC
            DataTable dt = new DataTable();
            dt = ObjCode.GetKotDetails(((Button)sender).Tag.ToString());
            for (int d = 0; d < dt.Rows.Count; d++)
            {
                dgvBill.Rows.Add();
                int code = Convert.ToInt32(dt.Rows[d]["ItemId"].ToString());
                dgvBill[0, d].Value = dt.Rows[d]["ItemName"].ToString();
                dgvBill[1, d].Value = dt.Rows[d]["Quantity"].ToString();
                dgvBill[2, d].Value = dt.Rows[d]["Amount"].ToString();
                dgvBill[3, d].Value = dt.Rows[d]["ItemId"].ToString();
                dgvBill[4, d].Value = dt.Rows[d]["Rate"].ToString();
                dgvBill[5, d].Value = dt.Rows[d]["kotId"].ToString();
               
                //SqlDataReader dr = ObjCode.GetItemDetail1(((Button)sender).Tag.ToString());
                SqlDataReader dr = ObjCode.GetItemDetail1(dt.Rows[d]["ItemId"].ToString());
                if (dr.Read())
                {
                        if (ACStatus == 1)
                        {
                           // dgvBill[2, d].Value = dr[10].ToString();
                            rate = Convert.ToDouble(dt.Rows[d]["Quantity"]) * Convert.ToDouble(dr[10]);
                            dgvBill[2, d].Value = rate.ToString();
                            dgvBill[4, d].Value = dr[10].ToString();
                           // dgvBill[4, d].Value = rate.ToString();
                           // Rate = Convert.ToDouble(dr[10]);
                        }
                        else
                        {
                            //dgvBill[2, d].Value = dr[11].ToString();
                            rate = Convert.ToDouble(dt.Rows[d]["Quantity"]) * Convert.ToDouble(dr[11]);
                            //dgvBill[4, d].Value = rate.ToString();
                            dgvBill[2, d].Value = rate.ToString();
                            dgvBill[4, d].Value = dr[11].ToString();
                            //Rate = Convert.ToDouble(dr[11]);
                        }
                }
                DataTable dt1 = new DataTable();
                dt1 = ObjCode.GetSt(code);
                if (Convert.ToInt32(dt1.Rows[0]["ChangeSellpricestatus"].ToString()) == 1)
                {
                    this.dgvBill.Rows[d].Cells["Column11"].ReadOnly = false;
                }
                else
                    this.dgvBill.Rows[d].Cells["Column11"].ReadOnly = true;
            }
            if (dt.Rows.Count == 0)
            {
                btnWaiter_Click(sender, e);
                TableColor(((Button)sender).Name);
                tablestatus = " 0";
            }
            else
            {
                SqlDataReader dr1 = ObjCode.GetWaiterbyTable(((Button)sender).Tag.ToString());
                if (dr1.Read())
                {
                    btnWaiter.Enabled = true;
                    lblWaiter.Text = dr1[0].ToString();
                    lblWaiter.Tag = dr1[1].ToString();
                    dgvBillEnterDelete();
                    tablestatus = " 0";
                    TableColor(((Button)sender).Name);
                }
                else
                {
                    dgvKotEnterDelete();
                    btnWaiter_Click(sender, e);
                    TableColor(((Button)sender).Name);
                    tablestatus = " 0";

                }

            }
        }
        private void btnToken_Click(object sender, EventArgs e)
        {  
            btnWaiter.ForeColor = Color.Maroon;
            btnItem.ForeColor = Color.Maroon;
            btnTable.ForeColor = Color.Maroon;
            ButtonColor();
            btnToken.BackColor = Color.White;
            btnToken.ForeColor = Color.Black;
            splitContainerDetails.Panel2.Controls.Clear();
            TableLayoutPanel tblypanelDetailsCenter = new System.Windows.Forms.TableLayoutPanel();
            splitContainerDetails.Panel2.Controls.Add(tblypanelDetailsCenter);
            tblypanelDetailsCenter.AutoSize = true;
            tblypanelDetailsCenter.ColumnCount = 6;
            tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tblypanelDetailsCenter.Dock = System.Windows.Forms.DockStyle.Top;
            tblypanelDetailsCenter.Margin = new System.Windows.Forms.Padding(0);
            tblypanelDetailsCenter.Name = "tblypanelDetailsCenter";
            tblypanelDetailsCenter.Controls.Clear();
            tblypanelDetailsCenter.RowCount = 3;
            for (int i = 0; i < tblypanelDetailsCenter.RowCount; i++)
            {
                tblypanelDetailsCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, Convert.ToInt32(70)));
            }
            int RowNum = 0, ColumnNum = 0;

            for (int i = 0; i < 15; i++)
            {
                if (i == 0)
                {
                    RowNum = 0; ColumnNum = 0;
                }
                else if (i == 1)
                {
                    RowNum = 0;
                    ColumnNum = 1;
                }
                else
                {
                    if (i < 6)
                    {
                        RowNum = 0;
                        ColumnNum = i;
                    }
                    else
                    {
                        RowNum = i / 6;
                        ColumnNum = i % 6;
                    }
                }
                Button btnToken1 = new Button();
                btnToken1.Name = "btnToken1" + i.ToString();
                btnToken1.Text = "Token " + (i + 1).ToString();
                btnToken1.ForeColor = Color.White;
                btnToken1.BackColor = Color.FromArgb(64, 0, 64);
                btnToken1.Dock = System.Windows.Forms.DockStyle.Fill;
                btnToken1.Click += new System.EventHandler(this.Tokenbtn_Click);
                tblypanelDetailsCenter.Controls.Add(btnToken1, ColumnNum, RowNum);
            }
            lblHeading.Text = "Select Token";
        }
        private void Tokenbtn_Click(object sender, EventArgs e)
        {
            lblToken.Text = ((Button)sender).Text;
            lblToken.Tag = ((Button)sender).Text;

            btnToken.ForeColor = Color.FromArgb(255, 128, 0);
          
            lblTable.Text = ".......";
            lblTable.Tag = "0";
            lblWaiter.Text = "......";
            lblWaiter.Tag = "0";
            dgvBill.Rows.Clear();

            DataTable dt = ObjCode.GetKotDetailsByToken(((Button)sender).Text,"0");
            if (dt.Rows.Count > 0)
            {
                for (int d = 0; d < dt.Rows.Count; d++)
                {
                    dgvBill.Rows.Add();
                    int code = Convert.ToInt32(dt.Rows[d]["ItemId"].ToString());
                    dgvBill[0, d].Value = dt.Rows[d]["ItemName"].ToString();
                    dgvBill[1, d].Value = dt.Rows[d]["Quantity"].ToString();
                    dgvBill[2, d].Value = dt.Rows[d]["Amount"].ToString();
                    dgvBill[3, d].Value = dt.Rows[d]["ItemId"].ToString();
                    dgvBill[4, d].Value = dt.Rows[d]["Rate"].ToString();
                    dgvBill[5, d].Value = dt.Rows[d]["kotId"].ToString();
                    DataTable dt1 = new DataTable();
                    dt1 = ObjCode.GetSt(code);
                    if (Convert.ToInt32(dt1.Rows[0]["ChangeSellpricestatus"].ToString()) == 1)
                    {
                        this.dgvBill.Rows[d].Cells["Column11"].ReadOnly = false;
                    }
                    else
                        this.dgvBill.Rows[d].Cells["Column11"].ReadOnly = true;
                }
                dgvBillEnterDelete();
            }
            else
            {
                dgvKotEnterDelete();
                if ((lblToken.Tag.ToString() == "1") && (dgvKOT.Rows.Count > 0))
                {
                    btnItem_Click(sender, e);
                }
                else
                {
                    btnItem_Click(sender, e);
                }
            }

        }

        private void btnWaiter_Click(object sender, EventArgs e)
        {
            btnToken.ForeColor = Color.Maroon;
            btnWaiter.BackColor = Color.White;
            btnWaiter.ForeColor = Color.Black;
            splitContainerDetails.Panel2.Controls.Clear();
            DataSet ds6 = new DataSet();
            ds6 = ObjCode.GetWaiter();
            DataTable dtWaiters = ds6.Tables[0];
            if (dtWaiters.Rows.Count > 0)
            {
                TableLayoutPanel tblypanelDetailsCenter = new System.Windows.Forms.TableLayoutPanel();
                splitContainerDetails.Panel2.Controls.Add(tblypanelDetailsCenter);
                tblypanelDetailsCenter.AutoSize = true;
                tblypanelDetailsCenter.ColumnCount = 6;
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.Dock = System.Windows.Forms.DockStyle.Top;
                tblypanelDetailsCenter.Margin = new System.Windows.Forms.Padding(0);
                tblypanelDetailsCenter.Name = "tblypanelDetailsCenter";
                tblypanelDetailsCenter.Controls.Clear();
                tblypanelDetailsCenter.RowCount = (dtWaiters.Rows.Count / 6) + 1;
                for (int i = 0; i < tblypanelDetailsCenter.RowCount; i++)
                {
                    tblypanelDetailsCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, Convert.ToInt32(70)));
                }
                int RowNum = 0, ColumnNum = 0;

                for (int i = 0; i < dtWaiters.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        RowNum = 0; ColumnNum = 0;
                    }
                    else if (i == 1)
                    {
                        RowNum = 0;
                        ColumnNum = 1;
                    }
                    else
                    {
                        if (i < 6)
                        {
                            RowNum = 0;
                            ColumnNum = i;
                        }
                        else
                        {
                            RowNum = i / 6;
                            ColumnNum = i % 6;
                        }
                    }
                    Button btnWaiter1 = new Button();
                    btnWaiter1.ForeColor = Color.White;
                    btnWaiter1.BackColor = Color.FromArgb(168, 0, 84);
                    btnWaiter1.Name = "btnWaiter1" + i.ToString();
                    btnWaiter1.Text = dtWaiters.Rows[i]["Name"].ToString(); 
                    btnWaiter1.Tag = dtWaiters.Rows[i]["Id"].ToString();
                    btnWaiter1.Dock = System.Windows.Forms.DockStyle.Fill;
                    btnWaiter1.Click += new System.EventHandler(this.WaiterBtn_Click);
                    tblypanelDetailsCenter.Controls.Add(btnWaiter1, ColumnNum, RowNum);
                }
            }
            else
            {
                MessageBox.Show("No Waiters are entered for display", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lblHeading.Text = "Select Waiter";
        }
        private void waitercolor(string Name)
        {
            try
            {

                DataSet ds6 = new DataSet();
                ds6 = ObjCode.GetWaiter();
                DataTable dtWaiters = ds6.Tables[0];
                for (int i = 0; i < dtWaiters.Rows.Count; i++)
                {
                    if (Name == ("btnWaiter1" + i.ToString()))
                    {
                        this.Controls.Find(Name, true)[0].BackColor = Color.Green;
                    }
                    else
                    {
                        this.Controls.Find("btnWaiter1" + i.ToString(), true)[0].BackColor = Color.Green;
                    }


                }
            }
            catch (Exception ex)
            {

                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        public string waiterstatus = "0";
        private void WaiterBtn_Click(object sender, EventArgs e)
         {
            waiterstatus = "1";
            btnWaiter.ForeColor = Color.FromArgb(255, 128, 0);
            lblWaiter.Text = ((Button)sender).Text;
            lblWaiter.Tag = ((Button)sender).Tag;
            if ((itemstatus == 0) && (waiterstatus == "1") && (tablestatus == "1") && (dgvKOT.Rows.Count < 0))
            {

                btnItem_Click(sender, e);

            }
            else
            {
                btnItem_Click(sender, e);

            }
        }
        private void lbl_clicked(object sender, EventArgs e)
        {
          
            ItemBtn_Click(sender, e);
        }

        public int itemstatus;
        private bool lbl1_click=false;
        private void btnItem_Click(object sender, EventArgs e)
        {
            lbl1_click = true;
            double Qty, Rate;
            string ItemName;
            itemstatus = 1;
            ButtonColor();
            btnItem.ForeColor = Color.Black;
            btnItem.BackColor = Color.White;
            splitContainerDetails.Panel2.Controls.Clear();
            DataSet ds = new DataSet();
            ds = ObjCode.GetCategory();
            DataTable dtCategory = ds.Tables[0];
            if (dtCategory.Rows.Count > 0)
            {
                TableLayoutPanel tblypanelDetailsCenter = new System.Windows.Forms.TableLayoutPanel();
                splitContainerDetails.Panel2.Controls.Add(tblypanelDetailsCenter);
                tblypanelDetailsCenter.AutoSize = true;
                tblypanelDetailsCenter.ColumnCount = 6;
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.Dock = System.Windows.Forms.DockStyle.Top;
                tblypanelDetailsCenter.Margin = new System.Windows.Forms.Padding(0);
                tblypanelDetailsCenter.Name = "tblypanelDetailsCenter";
                tblypanelDetailsCenter.Controls.Clear();
                tblypanelDetailsCenter.RowCount = (dtCategory.Rows.Count / 6) + 1;
                for (int i = 0; i < tblypanelDetailsCenter.RowCount*2; i++)
                {
                    tblypanelDetailsCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, Convert.ToInt32(70)));
                }
                int RowNum = 0, ColumnNum = 0;

                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        RowNum = 0; ColumnNum = 0;
                    }
                    else if (i == 1)
                    {
                        RowNum = 0;
                        ColumnNum = 1;
                    }
                    else
                    {
                        if (i < 6)
                        {
                            RowNum = 0;
                            ColumnNum = i;
                        }
                        else
                        {
                            RowNum = i / 6;
                            ColumnNum = i % 6;
                        }
                    }
                    Button btnCategory = new Button();
                    btnCategory.ForeColor = Color.White;
                    btnCategory.BackColor = Color.FromArgb(119, 0, 0);
                    btnCategory.Name = "btnCategory" + i.ToString();
                    Button lbl1 = new Button();    
                    lbl1.Text = dtCategory.Rows[i]["Name"].ToString();
                    lbl1.Click+= new System.EventHandler(this.lbl1_clicked);
                    lbl1.ForeColor = Color.Black;
                    lbl1.Font = new Font(lbl1.Font.FontFamily, 10, FontStyle.Bold);
                    lbl1.FlatAppearance.BorderSize = 0;


                    lbl1.Tag = dtCategory.Rows[i]["Id"].ToString();
                    if (dtCategory.Rows[i]["photo"] != "0x")
                    {
                        img = (byte[])dtCategory.Rows[i]["photo"];
                        MemoryStream ms = new MemoryStream((byte[])dtCategory.Rows[i]["photo"]);
                        if (ms.Length == 0)
                        {
                            string FilePath = Application.StartupPath + " \\Images\\" + "category image.jpg";
                            btnCategory.BackgroundImage = Image.FromFile(FilePath);
                            btnCategory.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else
                        {
                            btnCategory.BackgroundImage = Image.FromStream(ms);
                            btnCategory.BackgroundImageLayout = ImageLayout.Stretch;
                            btnCategory.Refresh();
                        }
                    }
                   
                    btnCategory.FlatAppearance.BorderSize = 0;
                    btnCategory.Tag = dtCategory.Rows[i]["Id"].ToString();
                    btnCategory.Dock = System.Windows.Forms.DockStyle.Fill;
                    btnCategory.Click += new System.EventHandler(this.CategoryBtn_Click);
                    btnCategory.FlatStyle = FlatStyle.Flat;
                    lbl1.Dock = System.Windows.Forms.DockStyle.Fill;
                    lbl1.FlatStyle = FlatStyle.Flat;
                    lbl1.BackColor = Color.White;
                    tblypanelDetailsCenter.Controls.Add(btnCategory, ColumnNum, (RowNum*2));
                    tblypanelDetailsCenter.Controls.Add(lbl1, ColumnNum, (RowNum * 2) + 1);
                    itemstatus = 0;
                }
            }
            else
            {
                MessageBox.Show("No Category Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lblHeading.Text = "Select Item Category";
        }
         private void lbl1_clicked(object sender, EventArgs e)
         {
            
             CategoryBtn_Click(sender, e);
         }

        byte[] img;
        private bool lbl_click  = false;
        DataTable dtItems;
        private void CategoryBtn_Click(object sender, EventArgs e)
        {

            lbl_click = true;
            btnWaiter.ForeColor = Color.Maroon;
            btnToken.ForeColor = Color.Maroon;
            dtItems = ObjCode.GetItembyCategory(((Button)sender).Tag.ToString());
             if (dtItems.Rows.Count > 0)
            {
                splitContainerDetails.Panel2.Controls.Clear();
                TableLayoutPanel tblypanelDetailsCenter = new System.Windows.Forms.TableLayoutPanel();
                splitContainerDetails.Panel2.Controls.Add(tblypanelDetailsCenter);
                tblypanelDetailsCenter.AutoSize = true;
                tblypanelDetailsCenter.ColumnCount = 6;
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
                tblypanelDetailsCenter.Dock = System.Windows.Forms.DockStyle.Top;
                tblypanelDetailsCenter.Margin = new System.Windows.Forms.Padding(0);
                tblypanelDetailsCenter.Name = "tblypanelDetailsCenter";
                tblypanelDetailsCenter.Controls.Clear();
                tblypanelDetailsCenter.RowCount = (dtItems.Rows.Count / 6) + 1;
                for (int i = 0; i < tblypanelDetailsCenter.RowCount*2; i++)
                {
                    if (i % 2 == 0)
                    {
                        tblypanelDetailsCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, Convert.ToInt32(70)));
                    }
                    else
                    {
                        tblypanelDetailsCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, Convert.ToInt32(35)));
                    }
                }
                int RowNum = 0, ColumnNum = 0;

                for (int i = 0; i < dtItems.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        RowNum = 0; ColumnNum = 0;
                    }
                    else if (i == 1)
                    {
                        RowNum = 0;
                        ColumnNum = 1;
                    }
                    else
                    {
                        if (i < 6)
                        {
                            RowNum = 0;
                            ColumnNum = i;
                        }
                        else
                        {
                            RowNum = i / 6;
                            ColumnNum = i % 6;
                        }
                    }
                    Button btnItems = new Button();
                    btnItems.BackColor = Color.FromArgb(0, 51, 0);
                    Button lbl = new Button();
                    lbl.Tag=((Button)sender).Tag.ToString();
                    lbl.Text = dtItems.Rows[i]["ItemName"].ToString();
                    lbl.Click += new System.EventHandler(this.lbl_clicked);
                    lbl.ForeColor = Color.White;
                    lbl.Font = new Font(lbl.Font.FontFamily, 10 ,FontStyle.Bold); 


                    lbl.Tag = dtItems.Rows[i]["Id"].ToString();
                    lbl.FlatAppearance.BorderSize = 0; 
                    btnItems.FlatAppearance.BorderSize = 0;
                    btnItem.ForeColor = Color.FromArgb(255, 128, 0);
                    btnItems.ForeColor = Color.White;
                    btnItems.Name = "btnItems" + i.ToString();
                    if (dtItems.Rows[i]["photo"] != "0x")
                    {
                        img = (byte[])dtItems.Rows[i]["photo"];
                        MemoryStream ms = new MemoryStream((byte[])dtItems.Rows[i]["photo"]);
                        if (ms.Length == 0)
                        {
                            string FilePath = Application.StartupPath + " \\Images\\" + "Default Image.jpg";
                            btnItems.BackgroundImage = Image.FromFile(FilePath);
                            btnItems.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else
                        {
                            btnItems.BackgroundImage = Image.FromStream(ms);
                            btnItems.BackgroundImageLayout = ImageLayout.Stretch;
                            btnItems.Refresh();
                        }
                    }
                    
                    btnItems.Tag = dtItems.Rows[i]["Id"].ToString();
                    btnItems.Dock = System.Windows.Forms.DockStyle.Fill;
                    btnItems.Click += new System.EventHandler(this.ItemBtn_Click);
                    btnItems.FlatStyle = FlatStyle.Flat;
                    lbl.Dock = System.Windows.Forms.DockStyle.Fill;
                    lbl.FlatStyle = FlatStyle.Flat;
                    lbl.BackColor = Color.FromArgb(0, 64, 64);
                    
                    tblypanelDetailsCenter.Controls.Add(btnItems, ColumnNum, (RowNum*2));
                    tblypanelDetailsCenter.Controls.Add(lbl, ColumnNum, (RowNum * 2)+1);
                  
                }
                lblHeading.Text = "Select Items";
            }
            else
            {
                MessageBox.Show("No Items found in this Category", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblHeading.Text = "Select Item Category";
            }
        }
     
        private void ItemBtn_Click(object sender, EventArgs e)
        {
            try
            {
                type = "plus";
                btn_plus.Enabled=false;
                str = "";
                double Qty, Rate;
                string ItemName;
                //Calculator Obj = new Calculator();
                //Obj.ShowDialog();
                //if (Obj.dgrslt == DialogResult.OK)
                //{
                    SqlDataReader dr = ObjCode.GetItemDetail1(((Button)sender).Tag.ToString());
                    if (dr.Read())
                    {
                        if (ACStatus == 1)
                        {
                            Rate = Convert.ToDouble(dr[10]);
                        }
                        else
                        {
                            Rate = Convert.ToDouble(dr[11]);
                        }
                        //if (Convert.ToDouble(dr[8]) == 2)
                        //{
                        //    Rate = Convert.ToDouble(dr[3]);
                        //}
                       
                       // Qty = Obj.Qty;
                        Qty = 1;
                        ItemName = dr[7].ToString();

                        int s = 0;
                        string itemid = "0";
                        int chk = 0;

                        for (int k = 0; k < dgvKOT.Rows.Count; k++)
                        {
                            itemid = dgvKOT[4, k].Value.ToString();
                            if (itemid == ((Button)sender).Tag.ToString())
                            {
                                Qty = Convert.ToDouble(dgvKOT[1, k].Value) + Convert.ToDouble(Qty);
                                dgvKOT[1, k].Value = Qty.ToString();
                                dgvKOT[2, k].Value = (Qty * Rate).ToString();
                                dgvKOT[6, k].Value = dr[4];
                                chk = 1;
                                dgvKotEnterDelete();
                                break;
                            }
                        }

                        if (chk == 0)
                        {
                            dgvKOT.Rows.Add();
                            int i = dgvKOT.Rows.Count - 1;
                            dgvKOT[0, i].Value = ItemName;
                            dgvKOT[1, i].Value = Qty.ToString();
                            dgvKOT[2, i].Value = (Qty * Rate).ToString();
                            dgvKOT[4, i].Value = ((Button)sender).Tag.ToString();
                            dgvKOT[5, i].Value = Rate.ToString();
                            dgvKOT[6, i].Value = dr[4];
                            txtItemTotal.Text = dgvKOT[2, i].Value.ToString();
                            dgvKotEnterDelete();

                        }


                        if ((lblTable.Tag == "0") && (kotstatus == "0"))
                        {
                            btnTable_Click(sender, e);

                        }

                    //}

                }
            }

            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }


        private void categorycolor(string Name)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = ObjCode.GetCategory(1);
                DataTable dtCategory = ds.Tables[0];
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    if (Name == ("btnCategory" + i.ToString()))
                    {

                        this.Controls.Find(Name, true)[0].BackColor = Color.Red;
                    }
                    else
                    {
                        this.Controls.Find("btnCategory" + i.ToString(), true)[0].BackColor = Color.CadetBlue;
                    }


                }
            }
            catch (Exception ex)
            {

                //File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }
        private void btnPendingKOT_Click(object sender, EventArgs e)
        {
          
            PendingOT_S Obj = new PendingOT_S();
            Obj.ShowDialog();
        }

        private void dgvKOT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 0;
            int i = e.RowIndex;
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                dgvKOT.Rows.Remove(dgvKOT.Rows[e.RowIndex]);
                dgvKotEnterDelete();

                //------------Gst Caluculation------//
                GstCalculationKot();
                GstCalculation();
                //txtItemTotal.Text = s.ToString("F2");
                double ItemTotalwithouRoundoff = 0;
                ItemTotalwithouRoundoff = (Convert.ToDouble(GstTotKot) + Convert.ToDouble(GstTot));
                txtItemTotal.Text = CalcAmtRoundOff(ItemTotalwithouRoundoff).ToString("F2");
                GstClearKot();
                GstClear();
                //-------------------------------//
            }
            str = ""; status = "";
            if (dgvKOT.Rows.Count > 0)
                BtnEnabled();
            else
                BtnDisabled();
        }

        public void dgvKotEnterDelete()
        {
            txtItemTotal.Text = "0.00";
            if (dgvKOT.Rows.Count > 0)
            {
                double s = 0;
                for (int i = 0; i < dgvKOT.Rows.Count; i++)
                {
                    s += Convert.ToDouble(dgvKOT[2, i].Value);
                }
                GstCalculationKot();
                GstCalculation();
                //txtItemTotal.Text = s.ToString("F2");
                double ItemTotalwithouRoundoff = 0;
                ItemTotalwithouRoundoff = (Convert.ToDouble(GstTotKot) + Convert.ToDouble(GstTot));
                txtItemTotal.Text = CalcAmtRoundOff(ItemTotalwithouRoundoff).ToString("F2");
                GstClearKot();
                GstClear();

            }
        }
        public void dgvBillEnterDelete()
        {
            txtItemTotal.Text = "0.00";
            if (dgvBill.Rows.Count > 0)
            {
                double s = 0;
                for (int i = 0; i < dgvBill.Rows.Count; i++)
                {
                    s += Convert.ToDouble(dgvBill[2, i].Value);
                }

                //GstCalculation();
                ////txtItemTotal.Text = s.ToString("F2");
                //txtItemTotal.Text = Convert.ToDouble(GstTot).ToString("F2");
                //GstClear();
                GstCalculationKot();
                GstCalculation();
                //txtItemTotal.Text = s.ToString("F2");

                double ItemTotalwithouRoundoff = 0;
                ItemTotalwithouRoundoff = (Convert.ToDouble(GstTotKot) + Convert.ToDouble(GstTot));

                txtItemTotal.Text = CalcAmtRoundOff(ItemTotalwithouRoundoff).ToString("F2");
                GstClearKot();
                GstClear();
            }
        }
public void Reset()
{
lblHeading.Text = "";
lblTable.Text = "......";
lblTable.Tag = "0";
lblToken.Text = "......";
lblToken.Tag = "0";
lblWaiter.Text = "......";
lblWaiter.Tag = "0";
dgvKOT.Rows.Clear();
dgvBill.Rows.Clear();
txtDiscount.Text = "0.00";
txt_PackCharge.Text = "0.00";
txtNettAmount.Text = "0.00";
txtItemTotal.Text = "0.00";
splitContainerDetails.Panel2.Controls.Clear();
ch_complimet.Checked = false;
btnWaiter.Enabled = true;
btnTable.ForeColor = Color.Maroon;
btnToken.ForeColor = Color.Maroon;
btnWaiter.ForeColor = Color.Maroon;
btnItem.ForeColor = Color.Maroon;
SqlDataReader drr = ObjCode.GetSettings();
if (drr.Read())
{
    if (drr[1].ToString() == "1")
    {
        SqlDataReader dr1r = ObjCode.GetInvoiceNo();
        if (dr1r.Read())
        {
            txtInvoiceNumber.Text = dr1r[0].ToString();
            txtInvoiceNumber.Enabled = false;
        }
        else
        {
            txtInvoiceNumber.Enabled = true;
        }
    }
}
ButtonColor();}

private void btnReset_Click(object sender, EventArgs e)
{
    Reset();
    ACStatus = 0;
    btnTable_Click(sender, e);
}

private void txtItemTotal_TextChanged(object sender, EventArgs e) 
{
//txtNettAmount.Text = (Convert.ToDouble(txtItemTotal.Text) + (Convert.ToDouble(txt_PackCharge.Text)) - Convert.ToDouble(txtDiscount.Text)).ToString("F2");

    //if (dgvKOT.Rows.Count > 0 && dgvBill.Rows.Count <= 0)
    //{
    //    GstCalculationKot();
    //    txtNettAmount.Text = (Convert.ToDouble(GstTot1Kot) + (Convert.ToDouble(txt_PackCharge.Text)) - Convert.ToDouble(txtDiscount.Text)).ToString("F2");
    //    GstClearKot();
    //}
    //else if (dgvBill.Rows.Count > 0 && dgvKOT.Rows.Count <= 0)
    //{
    //    GstCalculation();
    //    txtNettAmount.Text = (Convert.ToDouble(GstTot1) + (Convert.ToDouble(txt_PackCharge.Text)) - Convert.ToDouble(txtDiscount.Text)).ToString("F2");
    //    GstClear();
    //}
    //else
    //{
        GstCalculationKot();
        GstCalculation();
        txtNettAmount.Text = (Convert.ToDouble(GstTot1Kot) + Convert.ToDouble(GstTot1)).ToString("F2");
        //txtNettAmount.Text = (Convert.ToDouble(GstTot1Kot) + Convert.ToDouble(GstTot1) + (Convert.ToDouble(txt_PackCharge.Text)) - Convert.ToDouble(txtDiscount.Text)).ToString("F2");
        GstClear();
        GstClearKot();
    //}

}

private void txtDiscount_Click(object sender, EventArgs e)
{
    txtDiscount.SelectAll();
    str = "";
    flag = 0;
    status = "discount";
    BtnEnabled();
//Calculator Obj = new Calculator();
//Obj.ShowDialog();
//if (Obj.dgrslt == DialogResult.OK)
//{
//    double disc = Obj.Qty;
//    txtDiscount.Text = disc.ToString("F2");
//}

//else
//{
//    txtDiscount.Text = "0.00";
//}

}
public string kotstatus;
//public string dtkot;
private void btnPrintKot_Click(object sender, EventArgs e)
{
           
    kotstatus = "1";
    if (dgvKOT.Rows.Count > 0)
    {

        if (lblTable.Tag.ToString() != "0")
        {
            if (lblWaiter.Tag.ToString() != "0" && !(lblWaiter.Tag.ToString().Contains("Waiter")))
            {
                //List<string> li = new List<string>();
                //li.Add(dgvKOT[6, 0].Value.ToString());

                //for (int index = 0; index < dgvKOT.Rows.Count; index++)
                //{
                    //int chk = 0;
                    //for (int i = 0; i < li.Count; i++)
                    //{
                    //    if (li[i] == dgvKOT[6, index].Value.ToString())
                    //    {
                    //        chk = 1;
                    //    }

                    //}
                    //if (chk == 0)
                    //{
                    //li.Add(dgvKOT[6, index].Value.ToString());
                    //}
                    //}
                    //for (int i = 0; i < li.Count; i++)
                    //{
                    string msg = ObjCode.InsertKotMaster("Cash", "", "", txtItemTotal.Text, "0", lblTable.Tag.ToString(), lblWaiter.Tag.ToString(), "1", "0", DateTime.Now, dgvKOT[6, 0].Value.ToString(), "0");//li[i]

                    for (int k = 0; k < dgvKOT.Rows.Count; k++)
                    {

                        //if (li[i] == this.dgvKOT[6, k].Value.ToString())
                        //{

                        ObjCode.InsertKotDetail(msg, dgvKOT[4, k].Value.ToString(), dgvKOT[1, k].Value.ToString(), dgvKOT[5, k].Value.ToString(), dgvKOT[2, k].Value.ToString());


                        //}

                    }

                    DataTable dt = new DataTable();
                    dt = ObjCode.PrintKot(msg);
                    dtKOT = dt;
                //}
                    PrintKOT();
                    ACStatus = 0;   
                       
               // }
                Reset();
            }
            else
            {
                MessageBox.Show("Please select a waiter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            if (lblToken.Tag.ToString() != "0")
            {
                //List<string> li = new List<string>();
                //li.Add(dgvKOT[6, 0].Value.ToString());
                //for (int index = 0; index < dgvKOT.Rows.Count; index++)
                //{
                //    int chk = 0;
                //    for (int i = 0; i < li.Count; i++)
                //    {
                //        if (li[i] == dgvKOT[6, index].Value.ToString())
                //        {
                //            chk = 1;
                //        }
                //    }
                //    if (chk == 0)
                //    {
                //        li.Add(dgvKOT[6, index].Value.ToString());
                //    }
                //}
                //for (int i = 0; i < li.Count; i++)
                //{

                string msg = ObjCode.InsertKotMaster("Take away", "", "", txtItemTotal.Text, "0", "0", "0", "2", lblToken.Tag.ToString(), DateTime.Now, dgvKOT[6, 0].Value.ToString(), "1");
                    for (int k = 0; k < dgvKOT.Rows.Count; k++)
                    {
                        //if (li[i] == this.dgvKOT[6, k].Value.ToString())
                        //{
                            ObjCode.InsertKotDetail(msg, dgvKOT[4, k].Value.ToString(), dgvKOT[1, k].Value.ToString(), dgvKOT[5, k].Value.ToString(), dgvKOT[2, k].Value.ToString());
                        //}
                                
                    }
                    DataTable dt = new DataTable();
                    dt = ObjCode.PrintKotTake(msg);
                    dtKOTTake = dt;
                    PrintKOTTake();
                    ACStatus = 0;      
                         
                //}
                Reset();
            }
            else
            {   
                MessageBox.Show("Please select a Table or Token for KOT printing", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    else
    {
        MessageBox.Show("Please select Items for KOT printing", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
   // ACStatus = 0;
    btnTable_Click(sender, e);
}

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
        }

        private void btnCounterBill_Click(object sender, EventArgs e)
        {   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteKOT_Click(object sender, EventArgs e)
        {
            DeleteKot Obj = new DeleteKot();
            Obj.ShowDialog();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text == "")
            {
                txtDiscount.Text = "0.00";
            }
            double TotWithDisc = 0;
            //txtNettAmount.Text = (Convert.ToDouble(txtItemTotal.Text) + Convert.ToDouble(txt_PackCharge.Text) - Convert.ToDouble(txtDiscount.Text)).ToString("F2");
            GstCalculationKot();
            GstCalculation();
            //txtNettAmount.Text = (Convert.ToDouble(GstTot1Kot) + Convert.ToDouble(GstTot1) + Convert.ToDouble(txt_PackCharge.Text) - Convert.ToDouble(txtDiscount.Text)).ToString("F2");

            TotWithDisc = CalcTotalDiscount(Convert.ToDouble(GstTot1Kot) + Convert.ToDouble(GstTot1) + Convert.ToDouble(txt_PackCharge.Text),  Convert.ToDouble(txtDiscount.Text),Convert.ToDouble(GstTax)+Convert.ToDouble(GstTaxKot));
            txtNettAmount.Text = TotWithDisc.ToString();


            //double ItemTotalwithouRoundoff = 0;
            //ItemTotalwithouRoundoff = (Convert.ToDouble(GstTot1Kot) + Convert.ToDouble(GstTot1) + Convert.ToDouble(txt_PackCharge.Text) - Convert.ToDouble(txtDiscount.Text));

           // txtItemTotal.Text = TotWithDisc.ToString("F2");

            txtNettAmount.Text = TotWithDisc.ToString("F2");
            
            GstClearKot();
            GstClear();
        }
        public void ButtonColor()
        {
            //btnTable.BackColor = Color.Green;
            //btnTable.ForeColor = Color.White;
            //btnToken.BackColor = Color.FromArgb(0, 192, 192);
            //btnToken.ForeColor = Color.White;
            //btnWaiter.BackColor = Color.FromArgb(192, 192, 0);
            //btnWaiter.ForeColor = Color.White;
            //btnItem.BackColor = Color.FromArgb(64, 0, 64);
            //btnItem.ForeColor = Color.White;
        }
        //string []kotprinters ;
        public void PrintKOT()
        {
            PrintDocument doc = new PrintDocument();
            doc.PrinterSettings.PrinterName =File.ReadAllText("Printer.txt"); //default printer
            doc.PrintPage += this.Doc_PrintPageKOT;
            doc.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            if (File.Exists("KOTPrinter.txt"))
            {
                PrintDocument dockot = new PrintDocument();
                dockot.PrinterSettings.PrinterName = File.ReadAllText("KOTPrinter.txt");//network printer
                dockot.PrintPage += this.Doc_PrintPageKOT;
                dockot.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                try
                {
                    dockot.Print();
                }
                catch (Exception e)  
                {
                    MessageBox.Show("Printer Error");
                }
            }
            try
            {
               // doc.Print();

            }
            catch (Exception e)
            {
                MessageBox.Show("Printer Error");
            }
        }
        private void Doc_PrintPageKOT(object sender, PrintPageEventArgs e)
        
        {
            if (dtKOT.Rows.Count > 0)
            {
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;
                int widtableh = e.PageBounds.Width;
                int height = e.PageBounds.Height;
                float lineHeight = font20.GetHeight(e.Graphics);
                float xSlno = 0;
                float xitemaname = 40;
                float xquantity = 200;
                e.Graphics.DrawString("                       KOT", font12, new SolidBrush(Color.Black), 0, y);
                lineHeight = font12.GetHeight(e.Graphics);
                y += lineHeight;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                y += 3;
                e.Graphics.DrawString("KOT : " + dtKOT.Rows[0]["KotNo"].ToString() + ",   Date: " + DateTime.Now.ToString(), font10, sBrush, 0, y);
                lineHeight = font12.GetHeight(e.Graphics);
                y += lineHeight;

                e.Graphics.DrawString("Waiter: " + dtKOT.Rows[0]["Waiter"].ToString() + ",      Table : " + dtKOT.Rows[0]["TableName"].ToString(), fontKotNo, sBrush, 0, y);
                lineHeight = font10.GetHeight(e.Graphics);
                y += lineHeight;

                //e.Graphics.DrawString("Department: " + dtKOT.Rows[0]["department"].ToString(), font10, sBrush, 0, y);
                //lineHeight = font10.GetHeight(e.Graphics);
                //y += lineHeight;

                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                y += 3;
                e.Graphics.DrawString("Sno", font9, sBrush, xSlno, y);
                e.Graphics.DrawString("Item Name", font9, sBrush, xitemaname, y);
                e.Graphics.DrawString("Quantity", font9, sBrush, xquantity, y);
                y += lineHeight;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                y += 3;
                lineHeight = font8.GetHeight(e.Graphics);
                int slnum = 1;
                for (int i = 0; i < dtKOT.Rows.Count; i++)
                {
                    e.Graphics.DrawString(slnum.ToString(), font8, sBrush, xSlno, y);
                    e.Graphics.DrawString(dtKOT.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);
                    e.Graphics.DrawString(dtKOT.Rows[i]["Quantity"].ToString(), font8, sBrush, xquantity, y);
                    slnum += 1;
                    y += lineHeight;
                }
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                y += 3;
            }
        }
        public void PrintKOTTake()
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.Doc_PrintPageKOTTake; 
            doc.PrinterSettings.PrinterName = File.ReadAllText("Printer.txt");
            doc.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            if (File.Exists("KOTPrinter.txt"))
            {
                PrintDocument dockot = new PrintDocument();
                dockot.PrinterSettings.PrinterName = File.ReadAllText("KOTPrinter.txt");//network printer
                dockot.PrintPage += this.Doc_PrintPageKOTTake;
                dockot.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                try
                {
                    dockot.Print();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Printer Error");
                }
            }
            try
            {
              //  doc.Print();
            }
            catch (Exception e)
            {
                MessageBox.Show("Printer Error");
            }
        }
        private void Doc_PrintPageKOTTake(object sender, PrintPageEventArgs e)
        {
            if (dtKOTTake.Rows.Count > 0)
            {
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;
                int widtableh = e.PageBounds.Width;
                int height = e.PageBounds.Height;
                float lineHeight = font20.GetHeight(e.Graphics);
                float xSlno = 0;
                float xitemaname = 40;
                float xquantity = 200;
                e.Graphics.DrawString("                       KOT", font12, new SolidBrush(Color.Black), 0, y);
                lineHeight = font12.GetHeight(e.Graphics);
                y += lineHeight;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                y += 3;
                e.Graphics.DrawString("KOT : " + dtKOTTake.Rows[0]["KotNo"].ToString() + ",   Date: " + DateTime.Now.ToString(), font10, sBrush, 0, y);
                lineHeight = font10.GetHeight(e.Graphics);
                y += lineHeight;
                e.Graphics.DrawString("Token: " + dtKOTTake.Rows[0]["Token"].ToString(), font10, sBrush, 0, y);
                lineHeight = font10.GetHeight(e.Graphics);
                y += lineHeight;

                //e.Graphics.DrawString("Department: " + dtKOTTake.Rows[0]["department"].ToString(), font10, sBrush, 0, y);
                //lineHeight = font10.GetHeight(e.Graphics);
                //y += lineHeight;



                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                y += 3;
                e.Graphics.DrawString("Slno", font9, sBrush, xSlno, y);
                e.Graphics.DrawString("Item Name", font9, sBrush, xitemaname, y);
                e.Graphics.DrawString("Quantity", font9, sBrush, xquantity, y);
                y += lineHeight;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                y += 3;
                lineHeight = font8.GetHeight(e.Graphics);
                int slnum = 1;
                for (int i = 0; i < dtKOTTake.Rows.Count; i++)
                {
                    e.Graphics.DrawString(slnum.ToString(), font8, sBrush, xSlno, y);
                    e.Graphics.DrawString(dtKOTTake.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);
                    e.Graphics.DrawString(dtKOTTake.Rows[i]["Quantity"].ToString(), font8, sBrush, xquantity, y);
                    slnum += 1;
                    y += lineHeight;
                }
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                y += 3;
            }
        }
        public string user;
        public void PrintCounterBill()
        {
            PrintDocument doc = new PrintDocument();
            //doc.PrintPage += this.Doc_PrintPageCounterBill;
            doc.PrintPage += this.Doc_PrintPageCounterBillGST;
            //doc.PrinterSettings.PrinterName = "VENDOR THERMAL PRINTER";
            doc.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            //doc.OriginAtMargins = true;
            try
            {
                dtprintfeatures = ObjCode.getprinterfeatures();
                int pcount = Convert.ToInt32(dtprintfeatures.Rows[0]["PrintCount"]);
                for (int i = 0; i < pcount; i++)
                {

                    doc.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                // throw new ApplicationException("Printer Error");
            }
        }
        public static string CenterString(string stringToCenter, int totalLength)
        {
            Billing bc = new Billing();
            return stringToCenter.PadLeft(((totalLength - stringToCenter.Length) / 2)
                                + stringToCenter.Length)
                       .PadRight(totalLength);

        }


        DataTable dtprintfeatures; Font Fonts2;
        private void Doc_PrintPageCounterBill(object sender, PrintPageEventArgs e)
        {   
            double tot = 0;
            if (dtCounterBill.Rows.Count > 0)
            {
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;
                int widtableh = e.PageBounds.Width;
                int height = e.PageBounds.Height;
                float lineHeight = font20.GetHeight(e.Graphics);
                float xSlno = 0;
                float xitemaname = 30;
                float xitemarabic = 65;
                float xprice = 155;
                float xquantity = 200;
                float xamount = 240;
                //float xitemaname = 30;
                //float xprice = 145;
                //float xquantity = 190;
                //float xamount = 230;
               
                //y += lineHeight;
                //y += 3;
                dtprintfeatures = ObjCode.getprinterfeatures();
                if (dtprintfeatures.Rows[0]["logo"].ToString() == "1")
                {
                    if (File.Exists(Application.StartupPath + "\\logo.jpg"))
                    {
                        string path = Application.StartupPath + "\\logo.jpg";
                        Image r = Image.FromFile(path);
                        Point p = new Point(82, 30);
                        e.Graphics.DrawImage(r, p);
                        //y += lineHeight;
                        //y += 3;
                    }
                }
                dtprintfeatures = ObjCode.getprinterfeatures();
                if(dtprintfeatures.Rows[0]["address1"].ToString()!=null)
                {
                    if (dtprintfeatures.Rows[0]["AddressFont"].ToString() == "Bold")
                    {
                        Fonts2 =   new Font("", 15, FontStyle.Bold);;
                    }
                    else
                    {
                        Fonts2 =new Font("", 15, FontStyle.Italic);
                    }
                e.Graphics.DrawString(CenterString( dtprintfeatures.Rows[0]["address1"].ToString(),28), Fonts2, new SolidBrush(Color.Black), 0, y);//55
                y += lineHeight;
                }
                if(dtprintfeatures.Rows[0]["address2"].ToString()!=null)
                {
                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address2"].ToString(), 52), font12, new SolidBrush(Color.Black), 0, y);//45
                y += lineHeight;
                }
                if(dtprintfeatures.Rows[0]["address3"].ToString()!=null)
                {
                e.Graphics.DrawString(CenterString( dtprintfeatures.Rows[0]["address3"].ToString(),35), font10, new SolidBrush(Color.Black), 0, y);
                lineHeight = font10.GetHeight(e.Graphics);
                y += lineHeight;
                }
                if(dtprintfeatures.Rows[0]["address4"].ToString()!=null)
                {
                e.Graphics.DrawString(CenterString( dtprintfeatures.Rows[0]["address4"].ToString(),52), font10, new SolidBrush(Color.Black), 0, y);
                y += lineHeight;
                }
                if (dtprintfeatures.Rows[0]["address5"].ToString() != null)
                {
                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address5"].ToString(), 45), font10, new SolidBrush(Color.Black), 0, y);
                y += lineHeight;
                    }
            if (dtprintfeatures.Rows[0]["BillName"].ToString() != null)
                {
                
                e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["BillName"].ToString(),55), font12, new SolidBrush(Color.Black), 0, y);
                lineHeight = font12.GetHeight(e.Graphics);
                y += lineHeight;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));

                y += 3;
                //if (dtprintfeatures.Rows[0]["WaiterStatus"].ToString() == "1")
                //{
                //    e.Graphics.DrawString("Waiter: " + dtCounterBill.Rows[0]["Waiter"].ToString(), font9, sBrush, 0, y);
                //    lineHeight = font10.GetHeight(e.Graphics);
                //    y += lineHeight;
                //}
                }

                e.Graphics.DrawString("Bill No: " + dtCounterBill.Rows[0]["InvoiceNo"].ToString() + ",    Date: " + DateTime.Now.ToString(), font9, sBrush, 0, y);
                lineHeight = font9.GetHeight(e.Graphics);
                y += lineHeight;

                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                y += 3;
                e.Graphics.DrawString("Sno", font9, sBrush, xSlno, y);
                e.Graphics.DrawString("Item Name", font9, sBrush, xitemaname, y);

                e.Graphics.DrawString("Price", font9, sBrush, xprice, y);

                e.Graphics.DrawString("Qty", font9, sBrush, xquantity, y);

                e.Graphics.DrawString("Amount", font9, sBrush, xamount, y);

                y += lineHeight;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                y += 3;
                string currency = dtprintfeatures.Rows[0]["currency"].ToString();
                double total = 0, disc = 0, pckcharge = 0;
                lineHeight = font8.GetHeight(e.Graphics);
                int slnum = 1;
                for (int i = 0; i < dtCounterBill.Rows.Count; i++)
                {
                    e.Graphics.DrawString(slnum.ToString(), font8, sBrush, xSlno, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);
                    if (dtCounterBill.Rows[i]["ItemArabic"].ToString() != "")
                    {
                        y += lineHeight;
                        e.Graphics.DrawString(dtCounterBill.Rows[i]["ItemArabic"].ToString(), fontarb, sBrush, xitemarabic, y);
                        y -= lineHeight;
                    }
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["Rate"].ToString(), font8, sBrush, xprice, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["Quntity"].ToString(), font8, sBrush, xquantity, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["Amount"].ToString(), font8, sBrush, xamount, y);
                    total += Convert.ToDouble(dtCounterBill.Rows[i]["Amount"]);
                    disc = Convert.ToDouble(dtCounterBill.Rows[i]["discount"]);
                    pckcharge = Convert.ToDouble(dtCounterBill.Rows[i]["PckCharge"]);
                    slnum += 1;
                    y += lineHeight;
                    y += lineHeight;
                }
                tot = total;
                y += lineHeight;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                y += 7;
                if (ch_complimet.Checked == true)
                {
                    
                    e.Graphics.DrawString("Total          : "+currency+"." + total.ToString("F2"), font15, sBrush, 40, y);
                    lineHeight = font20.GetHeight(e.Graphics);
                    y += lineHeight;
                    e.Graphics.DrawString("Complimentary Bill", font20, sBrush, 40, y);
                    y += lineHeight;
                }
                else
                {
                    y += 7;
                    if (pckcharge > 0)
                    {
                        e.Graphics.DrawString("Packing Charge  : " + currency +"."+ pckcharge.ToString("F2"), font10, sBrush, 40, y);
                        lineHeight = font15.GetHeight(e.Graphics);
                        y += lineHeight;
                    }
                    e.Graphics.DrawString("Total                    : "+currency +"." + total.ToString("F2"), font10, sBrush, 40, y);
                    lineHeight = font15.GetHeight(e.Graphics);
                    y += lineHeight;
                    e.Graphics.DrawString("Discount              : " + currency + "." + disc.ToString("F2"), font10, sBrush, 40, y);
                    y += lineHeight;
                    e.Graphics.DrawString("Net Value      : " + currency + "." + (total + pckcharge - disc).ToString("F2"), font12, sBrush, 40, y);
                    y += lineHeight;
                }
                if(dtprintfeatures.Rows[0]["greeting1"].ToString()!=null)
                {
                    if (dtprintfeatures.Rows[0]["AddressFont"].ToString() == "Bold")
                    {
                        Fonts1 = myfontb1;
                    }
                    else
                    {
                        Fonts1 = myfontb2;
                    }


                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["greeting1"].ToString(), 55), Fonts1, sBrush, 0, y);
                y += lineHeight;
                }
                if (dtprintfeatures.Rows[0]["greeting2"].ToString() != null)
                {
                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["greeting2"].ToString(), 55), Fonts1, sBrush, 0, y);
                }
            }
        }
        public void PrintBill()
        {
            PrintDocument doc = new PrintDocument();
            //doc.PrintPage += this.Doc_PrintBill;
            doc.PrintPage += this.Doc_PrintBillGST;
            //doc.PrinterSettings.PrinterName = "VENDOR THERMAL PRINTER";
            doc.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            //doc.OriginAtMargins = true;
            try
            {
                dtprintfeatures = ObjCode.getprinterfeatures();
                int pcount = Convert.ToInt32(dtprintfeatures.Rows[0]["PrintCount"]);
                for (int i = 0; i < pcount; i++)
                {

                    doc.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                // throw new ApplicationException("Printer Error");
            }
        }
        public Font Ft, Fonts1;
        private void Doc_PrintBill(object sender, PrintPageEventArgs e)
        {
            double tot = 0;
            if (dtBill.Rows.Count > 0)
            {
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;
                int widtableh = e.PageBounds.Width;
                int height = e.PageBounds.Height;
                float lineHeight = font20.GetHeight(e.Graphics);
                float xSlno = 0;
                float xitemaname = 30;
                float xitemarabic = 65;
                float xprice = 155;
                float xquantity = 200;
                float xamount = 240;
                //float xitemaname = 30;
                //float xprice = 145;
                //float xquantity = 190;
                //float xamount = 230;
               // y += lineHeight;
                //y += 3;
                dtprintfeatures = ObjCode.getprinterfeatures();
                if (dtprintfeatures.Rows[0]["logo"].ToString() == "1")
                {
                    if (File.Exists(Application.StartupPath + "\\logo.jpg"))
                    {
                        string path = Application.StartupPath + "\\logo.jpg";
                        Image r = Image.FromFile(path);
                        Point p = new Point(82, 0);
                        e.Graphics.DrawImage(r, p);
                        y += lineHeight;
                        y += 1;
                    }
                }

                dtprintfeatures = ObjCode.getprinterfeatures();
                if (dtprintfeatures.Rows[0]["address1"].ToString() != null)
                {
                    if (dtprintfeatures.Rows[0]["AddressFont"].ToString() == "Bold")
                    {
                        Ft = myfontb15;
                        
                    }
                    else
                    {
                        Ft = myfonti15;
                    }
                   // y += lineHeight;
                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address1"].ToString(), 25), Ft, new SolidBrush(Color.Black), 0, y-30);
                    //lineHeight = font15.GetHeight(e.Graphics);
                   //y += lineHeight;
                }
                if (dtprintfeatures.Rows[0]["address2"].ToString() != null)
                {
                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address2"].ToString(), 52), font10, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font10.GetHeight(e.Graphics);
                    y += lineHeight;
                }
                if (dtprintfeatures.Rows[0]["address3"].ToString() != null)
                {
                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address3"].ToString(), 48), font10, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font10.GetHeight(e.Graphics);
                    y += lineHeight;
                }
                if (dtprintfeatures.Rows[0]["address4"].ToString() != null)
                {
                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address4"].ToString(), 45), font10, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font10.GetHeight(e.Graphics);
                    y += lineHeight;
                }
                if (dtprintfeatures.Rows[0]["address5"].ToString() != null)
                {
                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address5"].ToString(), 55), font10, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font10.GetHeight(e.Graphics);
                    //y += lineHeight;
                }
                if (dtprintfeatures.Rows[0]["BillName"].ToString() != null)
                {
                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["BillName"].ToString(), 46), font12, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font12.GetHeight(e.Graphics);
                    y += lineHeight;
                }
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                y += 3;

                if (dtprintfeatures.Rows[0]["BillNo"].ToString() == "1")
                {
                    e.Graphics.DrawString("Bill No: " + dtBill.Rows[0]["InvoiceNo"].ToString() + ",   Date : " + DateTime.Now.ToString(), font9, sBrush, 0, y);
                    lineHeight = font10.GetHeight(e.Graphics);
                    y += lineHeight;
                }
                if (dtprintfeatures.Rows[0]["TableStatus"].ToString() == "1")
                {
                    e.Graphics.DrawString("Table No: " + dtBill.Rows[0]["TableName"].ToString(), font9, sBrush, 0, y);
                    lineHeight = font9.GetHeight(e.Graphics);
                    y += lineHeight;
                }

                if (dtprintfeatures.Rows[0]["WaiterStatus"].ToString() == "1")
                {
                    e.Graphics.DrawString("Waiter: " + dtBill.Rows[0]["Waiter"].ToString(), font9, sBrush, 0, y);
                    lineHeight = font9.GetHeight(e.Graphics);
                    y += lineHeight;
                }

                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                y += 3;

                e.Graphics.DrawString("Sno", font9, sBrush, xSlno, y);
                e.Graphics.DrawString("Item Name", font9, sBrush, xitemaname, y);
                e.Graphics.DrawString("Price", font9, sBrush, xprice, y);
                e.Graphics.DrawString("Qty", font9, sBrush, xquantity, y);
                e.Graphics.DrawString("Amount", font9, sBrush, xamount, y);
                y += lineHeight;
                y += 3;

                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                y += 3;

                string currency = dtprintfeatures.Rows[0]["currency"].ToString();
                double total = 0, disc = 0, pckcharge=0;
                lineHeight = font8.GetHeight(e.Graphics);
                int slnum = 1;
                for (int i = 0; i < dtBill.Rows.Count; i++)
                {
                    e.Graphics.DrawString(slnum.ToString(), font8, sBrush, xSlno, y);
                    e.Graphics.DrawString(dtBill.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);
                    if (dtBill.Rows[i]["ItemArabic"].ToString() != "")
                    {
                        y += lineHeight;
                        e.Graphics.DrawString(dtBill.Rows[i]["ItemArabic"].ToString(), fontarb, sBrush, xitemarabic, y);
                        y -= lineHeight;
                    }
                    e.Graphics.DrawString(dtBill.Rows[i]["Rate"].ToString(), font8, sBrush, xprice, y);
                    e.Graphics.DrawString(dtBill.Rows[i]["Quntity"].ToString(), font8, sBrush, xquantity, y);
                    e.Graphics.DrawString(dtBill.Rows[i]["Amount"].ToString(), font8, sBrush, xamount, y);
                    total += Convert.ToDouble(dtBill.Rows[i]["Amount"]);
                    disc = Convert.ToDouble(dtBill.Rows[i]["discount"]);
                    pckcharge = Convert.ToDouble(dtBill.Rows[i]["PckCharge"]);
                    slnum += 1;
                    y += lineHeight;
                    y += lineHeight;
                }
                tot = total;
                y += lineHeight;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                y += 7;
                if (ch_complimet.Checked == true)
                {
                    e.Graphics.DrawString("Total           :" +currency+"."+ total.ToString("F2"), font15, sBrush, 40, y);
                    lineHeight = font20.GetHeight(e.Graphics);
                    y += lineHeight;
                    e.Graphics.DrawString("Complimentary Bill", font20, sBrush, 40, y);
                    y += lineHeight;
                }
                else
                {
                    y += 7;
                    if(Convert.ToDouble(dtBill.Rows[0]["PckCharge"])>0)
                    {
                        e.Graphics.DrawString("Packing Charge    : " + currency + "." + dtBill.Rows[0]["PckCharge"].ToString(), font10, sBrush, 40, y);
                    lineHeight = font15.GetHeight(e.Graphics);
                    y += lineHeight;
                    }
                    e.Graphics.DrawString("Total                     : " + currency + "." + total.ToString("F2"), font10, sBrush, 40, y);
                    lineHeight = font15.GetHeight(e.Graphics);
                    y += lineHeight;
                    e.Graphics.DrawString("Discount               : " + currency + "." + dtBill.Rows[0]["discount"].ToString(), font10, sBrush, 40, y);
                    y += lineHeight;
                    e.Graphics.DrawString("Net Value       : " + currency + "." + (total + Convert.ToDouble(dtBill.Rows[0]["PckCharge"].ToString()) - Convert.ToDouble(dtBill.Rows[0]["discount"].ToString())).ToString("F2"), font12, sBrush, 40, y);
                    y += lineHeight;
                }
                y += lineHeight;
                if (dtprintfeatures.Rows[0]["greeting1"].ToString() != null)
                {
                    if (dtprintfeatures.Rows[0]["GreetingFont"].ToString() == "Bold")
                    {
                        Fonts1 = myfontb1;
                    }
                    else
                    {
                        Fonts1 = myfonti1;
                    }

                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["greeting1"].ToString(), 60), Fonts1, sBrush, 0, y);
                    lineHeight = font9.GetHeight(e.Graphics);
                    y += lineHeight;

                }

                if (dtprintfeatures.Rows[0]["greeting2"].ToString() != null)
                {
                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["greeting2"].ToString(), 50), Fonts1, sBrush, 0, y);
                    lineHeight = font9.GetHeight(e.Graphics);
                    y += lineHeight;

                }
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
              
                e.Graphics.DrawString("   www.loyalitsolutions.com", font9, sBrush, 0, y);
                y += lineHeight;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
            }
        }
        int combliment = 0;
        string remarks;
        private void ch_complimet_CheckedChanged(object sender, EventArgs e)
        {
            //if (ch_complimet.Checked == true)
            //{
            //    combliment = 1;
            //}
            //else
            //{
            //    combliment = 0;
            //}
            try
            {
                if (ch_complimet.Checked == true)
                {
                    DialogResult dr = MessageBox.Show("If you select complimentary, Food will be free of cost \n Do you Want Continue ? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        txtDiscount.Enabled = false;
                        txtDiscount.Text = "0";
                        combliment = 1;
                        Complimentary_touchbill cc = new Complimentary_touchbill();
                        cc.ShowDialog();
                        if (cc.dr == DialogResult.OK)
                        {

                            remarks = cc.remarks;
                        }
                    }
                    else
                    {
                        combliment = 0;
                        ch_complimet.Checked = false;
                        txtDiscount.Enabled = true;
                    }
                }
                else
                {
                    combliment = 0;
                    txtDiscount.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        private void splitContainerDetails_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgvKOT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 0;
            str = ""; status = "";
            if (dgvKOT.Rows.Count > 0)
                BtnEnabled();
            else
                BtnDisabled();
        }
        private void TouchBilling_Shown(object sender, EventArgs e)
        {
            TouchBilling ob = new TouchBilling();
            //ob.Show();
            Application.OpenForms[ob.Name].Activate();
        }

        private void splitContainerDetails_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
         public int flag = 0;
        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            str = "";
            flag = 1;
            status = "";
            int i = e.RowIndex;
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete this kot ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    //ObjCode.DeleteKotitems(dgvBill[3, i].Value.ToString());
                    DataTable dt = new DataTable();
                    dt = ObjCode.removeKOT(Convert.ToInt32(Convert.ToDouble(dgvBill[3,e.RowIndex].Value.ToString())), Convert.ToInt32(Convert.ToDouble(dgvBill[5, e.RowIndex].Value.ToString())));
                    dgvBill.Rows.Remove(dgvBill.Rows[e.RowIndex]);
                    dgvBillEnterDelete();

                    //------------Gst Caluculation------//
                    GstCalculationKot();
                    GstCalculation();
                    //txtItemTotal.Text = s.ToString("F2");
                    double ItemTotalwithouRoundoff = 0;
                    ItemTotalwithouRoundoff = (Convert.ToDouble(GstTotKot) + Convert.ToDouble(GstTot));
                    txtItemTotal.Text = CalcAmtRoundOff(ItemTotalwithouRoundoff).ToString("F2");
                    GstClearKot();
                    GstClear();
                    //-------------------------------//

                }
            }
        } 
        private void txtItemTotal_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void btnCounterBill_Click_1(object sender, EventArgs e)
        {

        }
       public  int billtype = 0;
        private void checkbilltype()
        {
            if (lblTable.Tag.ToString() != "0")
            {
                int tablestatus = ObjCode.TableACStat(lblTable.Tag.ToString());
                if (tablestatus == 1)
                {
                    billtype = 1;
                }
                else
                {
                    billtype = 2;
                }
            }
            else if (lblToken.Tag.ToString() != "0")
            {
                billtype = 3;
            }
            else if (lblTable.Tag.ToString()=="0"&& lblToken.Tag.ToString()=="0"&& billcounterstatus ==1)
            {
                billtype = 4;
            }
            
        }
        
private void btnPrintBill_Click_2(object sender, EventArgs e)
{
    checkbilltype();

    CheckTaxAmoutInBill();
    //btnPrintBill.ForeColor = Color.FromArgb(255, 128, 0);
    if (txtInvoiceNumber.Text != "")
    {
        if (dgvKOT.Rows.Count > 0)
        {
            MessageBox.Show("Please print KOT for the selected items and then print bill.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            if (dgvBill.Rows.Count > 0)
            {
                //dgvBill.Visible = true;
                billingclass.setnetamount = Convert.ToDouble(txtNettAmount.Text.ToString());
                //Payment ps = new Payment();
                //ps.ShowDialog();
                //if ((billingclass.paidamt >= billingclass.payableamt) && (billingclass.cardamt + billingclass.cashamt >= billingclass.payableamt))
                //{
                int status = 2;
                //int compliment = 0;
                //if (ch_complimet.Checked == true)
                //    compliment = 1;
                if (lblTable.Tag.ToString() != "0")
                {
                    status = 1;
                }
                GstCalculation();
                string msg1 = ObjCode.InsertInvoiceMaster(txtInvoiceNumber.Text, Convert.ToDateTime(globalvariable.StoreDate), "0", "0", "0", status, txtItemTotal.Text, combliment, txtDiscount.Text, txtNettAmount.Text, "0", "0", user, txt_PackCharge.Text, billtype, Convert.ToDateTime(globalvariable.StoreDate)
                    , billingclass.paymode, billingclass.cashamt.ToString(), billingclass.cardamt.ToString(), "Touch", GstTax == "" ? "0.00" : GstTax);   // Convert.ToDateTime(globalvariable.StoreDate)   Convert.ToDateTime(lblDate.Text)         
                //string msg1 = ObjCode.InsertInvoiceMaster(txtInvoiceNumber.Text, Convert.ToDateTime(globalvariable.StoreDate), "0", "0", "0", status, GstTot, combliment, txtDiscount.Text, txtNettAmount.Text, "0", "0", user, txt_PackCharge.Text, billtype, Convert.ToDateTime(globalvariable.StoreDate)
                //   , billingclass.paymode, billingclass.cashamt.ToString(), billingclass.cardamt.ToString(), "Touch", GstTax == "" ? "0.00" : GstTax); 

                if (combliment == 1)
                {
                    ObjCode.InsertComplimentary(msg1, remarks);
                }
                if (msg1 == "0")
                {
                    MessageBox.Show("Sorry, This invoice number already exists.Please try other one", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtInvoiceNumber.Focus();
                }
                else
                {
                    for (int i = 0; i < dgvBill.Rows.Count; i++)
                    {
                        ObjCode.InsertInvoiceDetails(msg1, dgvBill[3, i].Value.ToString(), dgvBill[1, i].Value.ToString(), dgvBill[4, i].Value.ToString(), dgvBill[2, i].Value.ToString(), dgvBill[5, i].Value.ToString(), lblTable.Tag.ToString(), lblWaiter.Tag.ToString()=="......"?"":lblWaiter.Tag.ToString(),lblToken.Tag.ToString());
                    }
                    if (lblTable.Tag.ToString() != "0")
                    {
                        dtBill = ObjCode.PrintBill(msg1);
                        PrintBill();
                        ACStatus = 0;
                    }
                    if (lblToken.Tag.ToString() != "0")
                    {
                        dtCounterBill = ObjCode.PrintBillCounter(msg1);
                        PrintCounterBill();
                        ACStatus = 0;
                    }
                    Reset();
                }
                //}
                //else
                //{
                //    MessageBox.Show("Please pay The Bill Amount...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

            }
            else
            {
                MessageBox.Show("Please select items for printing the bill.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    else
    {
        MessageBox.Show("Please Change the settings for Invoice number to come automatically.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
int billcounterstatus = 0;

        private void btnCounterBill_Click_2(object sender, EventArgs e)
        {
            billcounterstatus = 1;
            checkbilltype();

            CheckTaxAmoutInBill();

            //btnCounterBill.ForeColor = Color.FromArgb(255, 128, 0);
            if (txtInvoiceNumber.Text != "")
            {
                if (dgvKOT.Rows.Count > 0)
                {
                    //GstCalculation();
                    GstCalculationKot();
                    billingclass.setnetamount = Convert.ToDouble(txtNettAmount.Text.ToString());
                    //Payment ps = new Payment();
                    //ps.ShowDialog();

                    //if ((billingclass.paidamt >= billingclass.payableamt) && (billingclass.cardamt + billingclass.cashamt >= billingclass.payableamt))
                    //{

                        if (lblTable.Tag.ToString() != "0")
                        {
                            MessageBox.Show("You selected a Table. So print KOT and then print bill or Reset and add Items again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (lblToken.Tag.ToString() != "0")
                        {
                            MessageBox.Show("You selected a Token. So print KOT and then print bill or Reset and add Items again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                           // int compliment = 0;
                            //if (ch_complimet.Checked == true)
                            //    compliment = 1;
                            string msg = ObjCode.InsertInvoiceMaster(txtInvoiceNumber.Text, Convert.ToDateTime(globalvariable.StoreDate), "0", "0", "0", 3, txtItemTotal.Text, combliment, txtDiscount.Text, txtNettAmount.Text, "0", "0", user, txt_PackCharge.Text, billtype, Convert.ToDateTime(globalvariable.StoreDate)
                                , billingclass.paymode, billingclass.cashamt.ToString(), billingclass.cardamt.ToString(), "Touch", GstTaxKot == "" ? "0.00" : GstTaxKot);//Convert.ToDateTime(globalvariable.StoreDate) Convert.ToDateTime(lblDate.Text)
                            //string msg = ObjCode.InsertInvoiceMaster(txtInvoiceNumber.Text, Convert.ToDateTime(globalvariable.StoreDate), "0", "0", "0", 3, GstTot, combliment, txtDiscount.Text, txtNettAmount.Text, "0", "0", user, txt_PackCharge.Text, billtype, Convert.ToDateTime(globalvariable.StoreDate)
                            //   , billingclass.paymode, billingclass.cashamt.ToString(), billingclass.cardamt.ToString(), "Touch", GstTax == "" ? "0.00" : GstTax);//Convert.ToDateTime(globalvariable.StoreDate) Convert.ToDateTime(lblDate.Text)
                            if (combliment == 1)
                            {
                                ObjCode.InsertComplimentary(msg, remarks);
                            }
                            if (msg == "0")
                            {
                                MessageBox.Show("Sorry,This invoice number already exists.Please try other one", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtInvoiceNumber.Focus();
                            }
                            else
                            {
                                if ((lblTable.Tag == "0") && (lblToken.Tag == "0"))
                                {
                                    for (int d = 0; d < dgvKOT.Rows.Count; d++)
                                    {
                                        dgvBill.Rows.Add();
                                        // dgvBill[0, d].Value = dt.Rows[d]["ItemName"].ToString();
                                        dgvBill[0, d].Value = dgvKOT[0, d].Value;
                                        dgvBill[1, d].Value = dgvKOT[1, d].Value;
                                        dgvBill[2, d].Value = dgvKOT[2, d].Value;
                                        dgvBill[3, d].Value = dgvKOT[3, d].Value.ToString();
                                        dgvBill[4, d].Value = dgvKOT[4, d].Value.ToString();
                                        dgvBill[5, d].Value = dgvKOT[5, d].Value;
                                        //dgvKOT[3, i].Value = ((Button)sender).Tag.ToString();


                                    }
                                }
                                for (int i = 0; i < dgvKOT.Rows.Count; i++)
                                {
                                    ObjCode.InsertInvoiceDetails(msg, dgvBill[4, i].Value.ToString(), dgvBill[1, i].Value.ToString(), dgvBill[5, i].Value.ToString(), dgvBill[2, i].Value.ToString(), "0", lblTable.Tag.ToString(), lblWaiter.Tag.ToString() == "......" ? "" : lblWaiter.Tag.ToString(), lblToken.Tag.ToString());
                                }
                                // MessageBox.Show("Print Success");
                                dtCounterBill = ObjCode.PrintBillCounter(msg);
                                PrintCounterBill();
                                Reset();
                                ACStatus = 0;
                                billcounterstatus = 0;
                            }
                        }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Please pay The Bill Amount...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
                else
                {
                    MessageBox.Show("Please add items for printing the bill.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Change the settings for Invoice number to come automatically.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tblypanelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_PackCharge_TextChanged(object sender, EventArgs e)
        {
            txtNettAmount.Text = (Convert.ToDouble(txtItemTotal.Text) + Convert.ToDouble(txt_PackCharge.Text) - Convert.ToDouble(txtDiscount.Text)).ToString("F2");
        }

        private void txt_PackCharge_Click(object sender, EventArgs e)
        {
            txt_PackCharge.SelectAll();
            str = "";
            status = "paking";
            flag = 0;
            BtnEnabled();
            //Calculator Obj = new Calculator();
            //Obj.ShowDialog();
            //if (Obj.dgrslt == DialogResult.OK)
            //{
            //    double pckcharge = Obj.Qty;
            //    txt_PackCharge.Text = pckcharge.ToString("F2");
            //}

            //else
            //{
            //    txt_PackCharge.Text = "0.00";
            //}
        }

        private void txt_PackCharge_Leave(object sender, EventArgs e)
        {
           
        }

        private void dgvBill_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            status = "";
            str = "";
            flag = 1;
        }
        public string str = "";
        public string status = "";
        public string type = "";
        double d;
        private void btn_numeric_Click(object sender, EventArgs e)
        {
            string numeric = ((Button)sender).Tag.ToString();
            if (numeric == "1")
            {
                str = str + "1";
            }
            else if (numeric == "2")
            {
                str = str + "2";
            }
            else if (numeric == "3")
            {
                str = str + "3";
            }
            else if (numeric == "4")
            {
                str = str + "4";
            }
            else if (numeric == "5")
            {
                str = str + "5";
            }
            else if (numeric == "6")
            {
                str = str + "6";
            }
            else if (numeric == "7")
            {
                str = str + "7";
            }
            else if (numeric == "8")
            {
                str = str + "8";
            }
            else if (numeric == "9")
            {
                str = str + "9";
            }
            else if (numeric == "0")
            {
                str = str + "0";

            }
            else if (numeric == ".")
            {
                if (!str.Contains("."))
                    str = str == "" ? "0." : str + ".";
            }
            //if (this.dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells[0].Selected == true)
            //{
                if (str.StartsWith("0"))
                {
                    str = "";
                    MessageBox.Show("Enter Correct Quantity ! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column5"].Selected = true;
                    return;
                }
            //}
            if (status == "discount")
            {
                btn_pt.Enabled = true;
                if (str.Contains("."))
                {
                    string[] a = str.Split(new char[] { '.' });
                    if (a[1].Length > 2)
                        str = str.Remove(str.Length - 1);
                }
                //txt_disc.Text = str;
                //grandTotal();
                txtDiscount.Text = str;
            }
            else if (status == "paking")
            {
                btn_pt.Enabled = true;
                if (str.Contains("."))
                {
                    string[] a = str.Split(new char[] { '.' });
                    if (a[1].Length > 2)
                        str = str.Remove(str.Length - 1);
                }
                txt_PackCharge.Text = str;
                //txt_cash.Text = str;
                //grandTotal();

            }
            else
            {
                if((dgvKOT.Rows.Count > 0 ) && flag==0)
                {
                    btn_pt.Enabled = true;
                    if (str.Contains("."))
                    {
                        string[] a = str.Split(new char[] { '.' });
                        if (a[1].Length > 3)
                            str = str.Remove(str.Length - 1);
                    }
                    string str1 = "";
                    //str = "";
                    string pri = "";
                    string c = dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column5"].Value.ToString();
                    string s = str;
                    if (c.Length ==3)
                        return;
                    if (str.Length > 3 && type != "minus")
                    {
                        str = str.Remove(str.Length - 1,1);
                        s = str;
                    }
                    if (str.StartsWith("0") && str != "0")
                        if(c.Length >3 )
                            if (str.Substring(0, 2) == "0.")
                                s = str;
                            else
                                s = str.Remove(0, 1);
                    else if (str.StartsWith("-0"))
                        if (str.Substring(0, 3) == "-0.")
                            s = str;
                        else
                            s = str.Remove(0, 2);
                    //if (this.dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells[0].Selected == true)
                    //if (c.Length > 3)
                    //{
                    //    s = str.Remove(0, 1);
                    //    str = "";
                    //}
                    //{
                         if (str.StartsWith("0"))
                         {
                             str = "";
                              MessageBox.Show("Enter Correct Quantity ! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             //dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column5"].Selected = true;
                             return;
                         }
                    //}
                    str1 = dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column5"].Value.ToString();
                    double d;
                    if (type == "minus")
                    {
                      
                        s = s.Substring(str.Length - 1);
                        d = Convert.ToDouble(str1) - Convert.ToDouble(s);
                        if (d == 0 ||d.ToString().Contains("-"))
                        {
                            MessageBox.Show("Quantity Cannot be Zero.Enter Correct Quantity ! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           str = "";
                            type = "";
                            return;
                           
                        }
                        else
                        {
                            dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column5"].Value = d.ToString();
                            //str = str.Remove(str.Length - 1);
                            //d = Math.Abs(d);
                            str = d.ToString();
                        }

                    }
                    else
                    {
                        //d = Convert.ToDouble(str1) + Convert.ToDouble(s);
                        //dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column5"].Value = d.ToString();
                        //dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column5"].Value = str1.Contains("-") == true ? "-" + s : s;
                        dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column5"].Value = s;
                        d = Convert.ToDouble(dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column5"].Value);
                    }
                    DataTable dt = new DataTable();
                    dt = ObjCode.GetItemDetail(dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column8"].Value.ToString());
                    pri = Convert.ToString(Convert.ToDouble(d) * Convert.ToDouble(dt.Rows[0]["SellPriceNonAc"].ToString()));    
                    //dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column6"].Value = str1.Contains("-") == true ? "-" + pri : pri;
                    dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column6"].Value = pri;
                    type = "plus";
                    //str = "";
                    dgvKotEnterDelete();
                }
                
            }
            if (dgvBill.Rows.Count > 0  && flag==1)
            {
                btn_pt.Enabled = true;
                if (str.Contains("."))
                {
                    string[] a = str.Split(new char[] { '.' });
                    if (a[1].Length > 3)
                        str = str.Remove(str.Length - 1);
                }
                string str1 = "";
                string pri = "";
                //str = "";
                string c = dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column11"].Value.ToString();
                string s = str;
                if (str.StartsWith("0") && str != "0")
                    if (c.Length > 3)
                        if (str.Substring(0, 2) == "0.")
                            s = str;
                        else
                            s = str.Remove(0, 1);
                    else if (str.StartsWith("-0"))
                        if (str.Substring(0, 3) == "-0.")
                            s = str;
                        else
                            s = str.Remove(0, 2);
                if (this.dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells[0].Selected == true)
                {
                    if (str.StartsWith("0"))
                    {
                        str = "";
                        MessageBox.Show("Enter Correct Quantity ! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column11"].Selected = true;
                        return;
                    }
                }
                //str1 = "";// dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column11"].Value.ToString();
               
                if (type == "minus")
                {

                    s = s.Substring(str.Length - 1);
                    DataTable dt1 = new DataTable();
                    dt1 = ObjCode.GetSt(Convert.ToInt32(dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["item"].Value));
                    if (Convert.ToInt32(dt1.Rows[0]["ChangeSellpricestatus"].ToString()) == 1)
                    {
                        this.dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column11"].ReadOnly = false;
                        dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column11"].Value = Convert.ToDouble(dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column11"].Value) - Convert.ToDouble(s);
                    }
                    else
                        this.dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column11"].ReadOnly = true;

                    //d = Convert.ToDouble(str) - Convert.ToDouble(s);
                    
                    //dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column11"].Value = d.ToString();
                    //str = str.Remove(str.Length - 1);
                    //d = Math.Abs(d);
                    //str = d.ToString();

                }
                else
                {
                    DataTable dt1 = new DataTable();
                    dt1 = ObjCode.GetSt(Convert.ToInt32(dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["item"].Value));
                    if (Convert.ToInt32(dt1.Rows[0]["ChangeSellpricestatus"].ToString()) == 1)
                    {
                        this.dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column11"].ReadOnly = false;
                        dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column11"].Value = s;
                    }
                    else
                        this.dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column11"].ReadOnly = true;

                    
                    d = Convert.ToDouble(dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column11"].Value);
                }
                DataTable dt = new DataTable();
                dt = ObjCode.GetItemDetail(dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["item"].Value.ToString());
                pri = Convert.ToString(Convert.ToDouble( dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column11"].Value) * Convert.ToDouble(dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column2"].Value));//Convert.ToDouble(dt.Rows[0]["SellPriceNonAc"].ToString()
                //dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column6"].Value = str1.Contains("-") == true ? "-" + pri : pri;
                dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column3"].Value = pri;
                type = "plus";
                //str = "";
                dgvBillEnterDelete();
            }
             
        }
        private void  btn_delete_Click(object sender, EventArgs e)
        {
            if (DeleteStatus == "1")
            {
                if (status == "discount")
                {
                    str = str == "" ? "" : str.Remove(str.Length - 1);
                    if (str == "0.")
                        str = "";
                    if (str == "")
                        str = "0.00";
                    // txt_disc.Text = str;
                    //txt_disc.Text = str + "%";
                    txtDiscount.Text = str;
                }
                else if (status == "paking")
                {
                    str = str == "" ? "" : str.Remove(str.Length - 1);
                    if (str == "")
                        str = "0.00";
                    txt_PackCharge.Text = str;
                    // txt_cash.Text = str;
                }
                else
                {
                    if (dgvKOT.Rows.Count > 0 && flag == 0)
                    {
                        //string str1 = "";
                        str = dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column5"].Value.ToString();
                        str = str.Remove(str.Length - 1);
                        if (str == "" || str == "-")
                        {
                            str = "";
                            dgvKOT.Rows.RemoveAt(dgvKOT.CurrentRow.Index);
                        }
                        else
                        {
                            dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column5"].Value = str;
                            DataTable dt = new DataTable();
                            dt = ObjCode.GetItemDetail(dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column8"].Value.ToString());
                            dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column6"].Value = Convert.ToString(Convert.ToDouble(str) * Convert.ToDouble(dt.Rows[0]["SellPriceNonAc"].ToString()));
                            //Write_Logdb("CHANGED", dgvBill.CurrentRow.Index);                       
                        }
                        dgvBillEnterDelete();
                    }
                }


                if (dgvBill.Rows.Count > 0 && flag == 1)
                {
                    DataTable dt1 = new DataTable();
                    dt1 = ObjCode.GetSt(Convert.ToInt32(dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["item"].Value));
                    if (Convert.ToInt32(dt1.Rows[0]["ChangeSellpricestatus"].ToString()) == 0)
                    {
                        this.dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column11"].ReadOnly =true ;
                    }
                    else
                    {
                        this.dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column11"].ReadOnly =false ;
                        str = dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column11"].Value.ToString();
                        str = str.Remove(str.Length - 1);
                        if (str == "" || str == "-")
                        {
                            str = "";
                            dgvBill.Rows.RemoveAt(dgvBill.CurrentRow.Index);
                        }
                        else
                        {
                            dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column11"].Value = str;
                            DataTable dt = new DataTable();
                            dt = ObjCode.GetItemDetail(dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["item"].Value.ToString());
                            dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column3"].Value = Convert.ToString(Convert.ToDouble(dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column2"].Value) * Convert.ToDouble(dgvBill.Rows[dgvBill.CurrentCell.RowIndex].Cells["Column11"].Value));
                            //Write_Logdb("CHANGED", dgvBill.CurrentRow.Index);                       
                        }
                        dgvBillEnterDelete();
                    }
                }

            }

            else
            {
                MessageBox.Show("You Don't Have the Rights To Delete ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnDisabled()
        {
            btn_1.Enabled = false;
            btn_2.Enabled = false;
            btn_3.Enabled = false;
            btn_4.Enabled = false;
            btn_5.Enabled = false;
            btn_6.Enabled = false;
            btn_7.Enabled = false;
            btn_8.Enabled = false;
            btn_9.Enabled = false;
            btn_0.Enabled = false;
            btn_pt.Enabled = false;
            btn_delete.Enabled = false;
            
        }
        private void BtnEnabled()
        {
            btn_1.Enabled = true;
            btn_2.Enabled = true;
            btn_3.Enabled = true;
            btn_4.Enabled = true;
            btn_5.Enabled = true;
            btn_6.Enabled = true;
            btn_7.Enabled = true;
            btn_8.Enabled = true;
            btn_9.Enabled = true;
            btn_0.Enabled = true;
            btn_pt.Enabled = true;
            btn_delete.Enabled = true;

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            type = "plus";
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            type = "minus";
            if (flag == 1)
                str = "";
        }

        private void btn_reprint_Click(object sender, EventArgs e)
        {
            Reprint rp = new Reprint();
            rp.ShowDialog();
        }

        private void dgvBill_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double total = 0;
            try
            {
                dgvBill[2, e.RowIndex].Value = (Convert.ToDouble(dgvBill[1, e.RowIndex].Value) * Convert.ToDouble(dgvBill[4, e.RowIndex].Value)).ToString("F2");
                for (int r = 0; r < dgvBill.Rows.Count; r++)
                {
                    total += (Convert.ToDouble(dgvBill[2, r].Value));
                }

                txtItemTotal.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(total), 2, MidpointRounding.AwayFromZero));
                txtItemTotal.Text = string.Format("{0:0.00}", Convert.ToDouble(txtItemTotal.Text));


            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void dgvBill_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvBill_CellEndEdit(sender, e);
        }

        private void dgvKOT_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column11"].Value == "0")
            //{
            //    MessageBox.Show("Enter Correct Quantity ! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column11"].Selected=true;
            //    return;
            //   //dgvKOT.Select(DataGridView.tbody.find("tr").eq(_rowIndex)); e.sender.element.focus(); 
            //    //dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column11"].fo
            //}
        }

        private void dgvKOT_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvKOT.Rows.Count > 0 )
            //{
            //    if (dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column5"].Value.ToString().StartsWith("0"))
            //    {
            //        MessageBox.Show("Enter Correct Quantity ! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column5"].Selected = true;
            //        return;
            //    }
            //}
        }

        private void dgvKOT_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKOT.Rows.Count > 0)
            {
                if (dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column5"].Value.ToString().StartsWith("0"))
                {
                    MessageBox.Show("Enter Correct Quantity ! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvKOT.Rows[dgvKOT.CurrentCell.RowIndex].Cells["Column5"].Selected = true;
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment ps = new Payment();
            ps.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Billing obj = new Billing();
            obj.ShowDialog();
        }

        string GstTot = "0";
        string GstTot1 = "0";
        string GstTax = "0";
        string GstTotKot = "0";
        string GstTot1Kot = "0";
        string GstTaxKot = "0";
        private void GstCalculation()
        {
            decimal Tot = 0;
            double Tot1 = 0;
            for (int s = 0; s < dgvBill.Rows.Count; s++)
            {
                Tot += (decimal.Round(Convert.ToDecimal((Convert.ToDouble(dgvBill["Column3", s].Value))), 2, MidpointRounding.AwayFromZero));
                //txt_total.Text = Tot.ToString();
                GstTot = Tot.ToString();
                //txt_total1.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));
                Tot1 += Convert.ToDouble(string.Format("{0:0.00}", Convert.ToDouble(dgvBill["Column2", s].Value) * Convert.ToDouble(dgvBill["Column11", s].Value)));
                GstTot1 = Tot1.ToString();
                //txt_total1.Text = Tot1.ToString();
            }
            //------------GST Tax Calculation 5% -------------------//
            //GstTot = Convert.ToString(Convert.ToString(decimal.Round(Convert.ToDecimal(((Convert.ToDouble(GstTot1) * 5) / 100) + Convert.ToDouble(GstTot1)), 2, MidpointRounding.AwayFromZero)));

            GstTot = GstTot1;

            //txttax.Text = Convert.ToString(Convert.ToDecimal(txt_total.Text) - Convert.ToDecimal(txt_total1.Text));
            GstTax = Convert.ToString(Convert.ToDecimal(GstTot) - Convert.ToDecimal(GstTot1));
            //------------------------------------------------------//

            ////------Round Off-------------------//
            //double AmtWithRoundOff = 0;
            //AmtWithRoundOff = CalcAmtRoundOff(Convert.ToDouble(GstTot));
            //GstTot = AmtWithRoundOff.ToString();
            ////----------------------------------//
        }


        private void GstCalculationKot()
        {
            decimal Tot = 0;
            double Tot1 = 0;
            for (int s = 0; s < dgvKOT.Rows.Count; s++)
            {
                Tot += (decimal.Round(Convert.ToDecimal((Convert.ToDouble(dgvKOT["Column6", s].Value))), 2, MidpointRounding.AwayFromZero));
                //txt_total.Text = Tot.ToString();
                GstTotKot = Tot.ToString();
                //txt_total1.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));
                Tot1 += Convert.ToDouble(string.Format("{0:0.00}", Convert.ToDouble(dgvKOT["Column5", s].Value) * Convert.ToDouble(dgvKOT["Column10", s].Value)));
                GstTot1Kot = Tot1.ToString();
                //txt_total1.Text = Tot1.ToString();
            }
            //------------GST Tax Calculation 5% -------------------//
          //  GstTotKot = Convert.ToString(Convert.ToString(decimal.Round(Convert.ToDecimal(((Convert.ToDouble(GstTot1Kot) * 5) / 100) + Convert.ToDouble(GstTot1Kot)), 2, MidpointRounding.AwayFromZero)));

            GstTotKot = GstTot1Kot;
            
            //txttax.Text = Convert.ToString(Convert.ToDecimal(txt_total.Text) - Convert.ToDecimal(txt_total1.Text));
            GstTaxKot = Convert.ToString(Convert.ToDecimal(GstTotKot) - Convert.ToDecimal(GstTot1Kot));
            //------------------------------------------------------//

            ////------Round Off-------------------//
            //double AmtWithRoundOff = 0;
            //AmtWithRoundOff = CalcAmtRoundOff(Convert.ToDouble(GstTotKot));
            //GstTotKot = AmtWithRoundOff.ToString();
            ////----------------------------------//
        }


        private double CalcAmtRoundOff(double AmtRound)
        {
            double firstValue = 0;
            double secondValue = 0;
            double secondroundoffdecimalvalue = 0;
            int conditionroundoffplus;
            int conditionroundoffminus;
            double roundoffplusvalue = 0;
            double roundoffminusvalue = 0;
            double AmountWithRoundOff = 0;

            if (AmtRound > 0)
            {
                string[] values = Convert.ToString(Convert.ToDouble(AmtRound).ToString("F2")).Split(new char[] { '.' });
                firstValue = double.Parse(values[0]);
                secondValue = double.Parse(values[1]);
                secondroundoffdecimalvalue = secondValue / 100;
            }



            if (secondroundoffdecimalvalue >= 0.5)
            {
                conditionroundoffplus = 1;
                roundoffplusvalue = (1 - secondroundoffdecimalvalue);

                // rounoff_plus.Text = Convert.ToString(roundoffplusvalue);

                AmountWithRoundOff = AmtRound + roundoffplusvalue;
            }
            else if (secondroundoffdecimalvalue < 0.5 && secondroundoffdecimalvalue > 0)
            {
                conditionroundoffminus = 1;
                roundoffminusvalue = secondroundoffdecimalvalue;
                AmountWithRoundOff = AmtRound - roundoffminusvalue;
                //Roundoff_minus.Text = Convert.ToString(roundoffminusvalue);
            }
            else
            {
                conditionroundoffminus = 0;
                roundoffplusvalue = 0;
                AmountWithRoundOff = AmtRound;
            }

            return AmountWithRoundOff;
        }

        private void GstClear()
        {
            GstTot = "0";
            GstTot1 = "0";
            GstTax = "0";
        }
        private void GstClearKot()
        {
            GstTotKot = "0";
            GstTot1Kot = "0";
            GstTaxKot = "0";
        }
        private double CalcTotalDiscount(double TotWithoutDisc, double DiscAmt, double DiscTax)
        {
            double TotWithDisc = 0;
            double TotWithDiscTax = 0;

            TotWithDisc = Math.Round((TotWithoutDisc + DiscTax), 0);
            TotWithDiscTax = TotWithDisc - DiscAmt;
            return TotWithDiscTax;
        }

        Codebehind obj = new Codebehind();
        int counterId = Convert.ToInt32(File.ReadAllText("counter.txt"));
        private void Doc_PrintPageCounterBillGST(object sender, PrintPageEventArgs e)
        {
            try
            {

                double tot = 0;
                if (dtCounterBill.Rows.Count > 0)
                {
                    float x = e.MarginBounds.Left;
                    float y = 10;
                    int widtableh = e.PageBounds.Width;
                    int height = e.PageBounds.Height;

                    float lineHeight = font20.GetHeight(e.Graphics);
                    //float xSlno = 0;
                    //float xitemaname = 0;
                    //float xitemarabic = 65;
                    //float xprice = 160;
                    //float xquantity = 115;
                    //float xamount = 200;

                    float xSlno = 0;
                    float xitemaname = 18;
                    float xitemarabic = 65;
                    float xprice = 160;
                    float xquantity = 115;
                    float xamount = 200;

                    //float xitemaname = 0;
                    //float xprice = 160;
                    //float xquantity = 115;
                    //float xamount = 200;
                    if (dtprintfeatures.Rows[0]["logo"].ToString() == "1")
                    {
                        if (File.Exists(Application.StartupPath + "\\logo.jpg"))
                        {
                            string path = Application.StartupPath + "\\logo.jpg";
                            Image r = Image.FromFile(path);
                            Point p = new Point(25, 0);
                            //Point p = new Point(82, 0);
                            e.Graphics.DrawImage(r, p);
                            y += lineHeight;
                            y += 3;
                        }
                    }

                    dtprintfeatures = obj.getprinterfeatures();
                    var result1 = dtprintfeatures.Rows[0]["address1"];

                    if (result1 != null)
                    {
                        if (dtprintfeatures.Rows[0]["AddressFont"].ToString() == "Bold")
                        {
                            //font = myFontb;
                            font = Addr1Font;
                        }
                        else
                        {
                            //font = myFonti;
                            font = Addr1Font;
                        }
                        y += lineHeight;
                        //e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address1"].ToString(), 36), font, new SolidBrush(Color.Black), 0, y);
                        e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address1"].ToString(), 25), font, new SolidBrush(Color.Black), 0, y);
                        lineHeight = font15.GetHeight(e.Graphics);
                        y += lineHeight;
                    }
                    var result2 = dtprintfeatures.Rows[0]["address2"];
                    if (result2 != null)
                    {

                        //e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address2"].ToString(), 55), font10, new SolidBrush(Color.Black), 0, y);
                        e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address2"].ToString(), 20), font9, new SolidBrush(Color.Black), 0, y);


                        lineHeight = font10.GetHeight(e.Graphics);
                        y += lineHeight;
                    }

                    var result3 = dtprintfeatures.Rows[0]["address3"];
                    if (result3 != null)
                    {
                        //e.Graphics.DrawString( CenterString(dtprintfeatures.Rows[0]["address3"].ToString(),48), font10, new SolidBrush(Color.Black), 0, y);
                        e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address3"].ToString(), 25), font10, new SolidBrush(Color.Black), 0, y);
                        lineHeight = font10.GetHeight(e.Graphics);
                        y += lineHeight;
                    }

                    var result4 = dtprintfeatures.Rows[0]["address4"];
                    if (result4 != null)
                    {
                        //e.Graphics.DrawString(             CenterString(dtprintfeatures.Rows[0]["address4"].ToString(),45), font10, new SolidBrush(Color.Black), 0, y);
                        e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address4"].ToString(), 25), font10, new SolidBrush(Color.Black), 0, y);
                        lineHeight = font10.GetHeight(e.Graphics);
                        y += lineHeight;
                    }
                    var result5 = dtprintfeatures.Rows[0]["address5"];
                    if ((result5 != null) && (result5 != ""))
                    {
                        //e.Graphics.DrawString(       CenterString(dtprintfeatures.Rows[0]["address5"].ToString(),55), font10, new SolidBrush(Color.Black), 0, y);
                        e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address5"].ToString(), 25), font10, new SolidBrush(Color.Black), 0, y);
                        lineHeight = font10.GetHeight(e.Graphics);
                        y += lineHeight;
                    }

                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["BillName"].ToString(), 46), font12, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font12.GetHeight(e.Graphics);
                    y += lineHeight;
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(260, Convert.ToInt32(y)));
                    y += 3;

                    //<--------------For waiter-------------->

                    if (dtprintfeatures.Rows[0]["BillNo"].ToString() == "1")
                    {
                        e.Graphics.DrawString("Bill No: " + dtCounterBill.Rows[0]["InvoiceNo"].ToString() + ",    Date: " + DateTime.Now.ToString(), font9, sBrush, 0, y);
                        lineHeight = font9.GetHeight(e.Graphics);
                        y += lineHeight;
                    }
                    if (counterId != 0)
                    {
                        if (dtprintfeatures.Rows[0]["Counter"].ToString() == "1")
                        {
                            DataTable dt = new DataTable();
                            dt = obj.EditCounter(counterId.ToString());
                            if (dt.Rows.Count > 0)
                            {
                                e.Graphics.DrawString("Counter : " + dt.Rows[0]["counter_name"].ToString().ToString(), font9, sBrush, 0, y);
                            }

                            lineHeight = font9.GetHeight(e.Graphics);
                            y += lineHeight;
                        }
                        if (dtprintfeatures.Rows[0]["cashierst"].ToString() == "1")
                        {
                            e.Graphics.DrawString("Cashier : " + obj.GetUsernameById(File.ReadAllText("user.txt")), font9, sBrush, 0, y);
                            lineHeight = font9.GetHeight(e.Graphics);
                            y += lineHeight;
                        }
                    }
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(260, Convert.ToInt32(y)));
                    y += 3;


                    e.Graphics.DrawString("Sl ", font9, sBrush, xSlno, y);

                    e.Graphics.DrawString("Itemname", font9, sBrush, xitemaname, y);


                    e.Graphics.DrawString("Qty", font9, sBrush, xquantity, y);

                    e.Graphics.DrawString("Price", font9, sBrush, xprice, y);


                    e.Graphics.DrawString("Value", font9, sBrush, xamount, y);

                    y += lineHeight;
                    y += 3;
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(260, Convert.ToInt32(y)));
                    y += 3;

                    double total = 0, pckcharge = 0;
                    lineHeight = font8.GetHeight(e.Graphics);
                    int slnum = 1;
                    int itemst = Convert.ToInt32(dtprintfeatures.Rows[0]["Itemcode"].ToString());
                    int slnst = Convert.ToInt32(dtprintfeatures.Rows[0]["Slno"].ToString());
                    for (int i = 0; i < dtCounterBill.Rows.Count; i++)
                    {
                        if (slnst == 1)
                        {
                            e.Graphics.DrawString(slnum.ToString(), font8, sBrush, xSlno, y);
                        }
                        if (itemst == 1)
                        {
                            e.Graphics.DrawString(dtCounterBill.Rows[i]["itemcode"].ToString(), font8, sBrush, xamount, y);
                        }
                        //e.Graphics.DrawString(dtCounterBill.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);
                        e.Graphics.DrawString(dtCounterBill.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);

                        if (dtCounterBill.Rows[i]["ItemArabic"].ToString() != "")
                        {
                            y += lineHeight;
                            e.Graphics.DrawString(dtCounterBill.Rows[i]["ItemArabic"].ToString(), fontarb, sBrush, xitemarabic, y);
                            y -= lineHeight;
                        }


                        y += lineHeight;
                        y += 3;

                        e.Graphics.DrawString(dtCounterBill.Rows[i]["Quntity"].ToString(), font8, sBrush, xquantity, y);
                        e.Graphics.DrawString(dtCounterBill.Rows[i]["Rate"].ToString(), font8, sBrush, xprice, y);
                        e.Graphics.DrawString(dtCounterBill.Rows[i]["Amount"].ToString(), font8, sBrush, xamount, y);
                        total += Convert.ToDouble(dtCounterBill.Rows[i]["Amount"]);
                        pckcharge = Convert.ToDouble(dtCounterBill.Rows[i]["PckCharge"]);
                        slnum += 1;
                        y += lineHeight;
                        y += lineHeight;
                    }
                    tot = total;
                    y += lineHeight;
                    y += 3;
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(260, Convert.ToInt32(y)));
                    y += 7;
                    if (ch_complimet.Checked == true)
                    {

                        e.Graphics.DrawString("Total : Rs." + total.ToString("F2"), font12, sBrush, 60, y);
                        lineHeight = font12.GetHeight(e.Graphics);
                        y += lineHeight;
                        e.Graphics.DrawString("Complimentary Bill", font15, sBrush, 40, y);
                        lineHeight = font15.GetHeight(e.Graphics);
                        y += lineHeight;
                    }
                    else
                    {
                        y += 7;
                        if (Convert.ToDouble(dtCounterBill.Rows[0]["PckCharge"]) > 0)
                        {
                            e.Graphics.DrawString("Packing Charge      : Rs." + pckcharge.ToString("F2"), font10, sBrush, 40, y);
                            lineHeight = font15.GetHeight(e.Graphics);
                            y += lineHeight;
                        }

                        //double totaltxamt = ((((total) * 5)) / 100);
                        //double totaltx = ((((total) * 5)) / 100) / 2;

                        //e.Graphics.DrawString("Total            : Rs." + (total+totaltxamt).ToString("F2"), font12, sBrush, 40, y);
                        //lineHeight = font12.GetHeight(e.Graphics);
                        //y += lineHeight;

                        //e.Graphics.DrawString("NetValue      : Rs." + (total - Convert.ToDouble(dtCounterBill.Rows[0]["discount"].ToString())).ToString("F2"), font12, sBrush, 40, y);
                        //e.Graphics.DrawString("NetValue      : Rs." + (total).ToString("F2"), font12, sBrush, 40, y);
                        e.Graphics.DrawString("NetValue          : Rs." + (total).ToString("F2"), font10, sBrush, 40, y);
                        lineHeight = font12.GetHeight(e.Graphics);
                        y += lineHeight;


                        //e.Graphics.DrawString("CGST 2.5%      : Rs." + (Convert.ToDouble(totaltx)).ToString("F2"), font10, sBrush, 40, y);
                        //lineHeight = font12.GetHeight(e.Graphics);
                        //y += lineHeight;

                        //e.Graphics.DrawString("SGST 2.5%      : Rs." + (Convert.ToDouble(totaltx)).ToString("F2"), font10, sBrush, 40, y);
                        //lineHeight = font12.GetHeight(e.Graphics);
                        //y += lineHeight;


                        if (Convert.ToDouble(dtCounterBill.Rows[0]["discount"].ToString()) > 0)
                        {
                            e.Graphics.DrawString("Discount      : Rs." + dtCounterBill.Rows[0]["discount"].ToString(), font12, sBrush, 40, y);
                            lineHeight = font10.GetHeight(e.Graphics);
                            y += lineHeight;
                        }
                        //e.Graphics.DrawString("NetValue : Rs." + (total - Convert.ToDouble(dtCounterBill.Rows[0]["discount"].ToString())).ToString("F2"), font15, sBrush, 40, y);
                        //lineHeight = font12.GetHeight(e.Graphics);
                        //y += lineHeight;

                        //e.Graphics.DrawString("Total        : Rs." + (total + totaltxamt).ToString("F2"), font15, sBrush, 40, y);

                        //------Round Off-------------------//
                        double AmtWithRoundOff = 0;
                        double AmtWithoutRoundOff = 0;
                        AmtWithoutRoundOff = total  - Convert.ToDouble(dtCounterBill.Rows[0]["discount"].ToString());
                        AmtWithRoundOff = CalcAmtRoundOff(Convert.ToDouble(AmtWithoutRoundOff));

                        //----------------------------------//

                        e.Graphics.DrawString("Total        : Rs." + (AmtWithRoundOff).ToString("F2"), font15, sBrush, 40, y);
                        lineHeight = font12.GetHeight(e.Graphics);
                        y += lineHeight;
                    }

                    y += lineHeight;
                    y += lineHeight;
                    y += lineHeight;
                    if (dtprintfeatures.Rows[0]["greeting1"].ToString() != null)
                    {
                        if (dtprintfeatures.Rows[0]["GreetingFont"].ToString() == "Bold")
                        {
                            Fonts1 = myfontb1;
                        }
                        else
                        {
                            Fonts1 = myfonti1;
                        }
                        e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["greeting1"].ToString(), 60), Fonts1, sBrush, 0, y);
                        lineHeight = font9.GetHeight(e.Graphics);
                        y += lineHeight;

                    }

                    if (dtprintfeatures.Rows[0]["greeting2"].ToString() != null)
                    {
                        e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["greeting2"].ToString(), 50), font10, sBrush, 0, y);
                        lineHeight = font9.GetHeight(e.Graphics);
                        y += lineHeight;

                    }

                    e.Graphics.DrawString("   www.loyalitsolutions.com", font9, sBrush, 0, y);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }


        private void Doc_PrintBillGST(object sender, PrintPageEventArgs e)
        {
            try
            {
                double tot = 0;
                if (dtBill.Rows.Count > 0)
                {
                    float x = e.MarginBounds.Left;
                    float y = 10;
                    int widtableh = e.PageBounds.Width;
                    int height = e.PageBounds.Height;
                    float lineHeight = font20.GetHeight(e.Graphics);
                    float xSlno = 0;
                    float xitemaname = 18;
                    float xitemarabic = 65;
                    float xprice = 160;
                    float xquantity = 115;
                    float xamount = 200;

                    StringFormat sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;

                    if (dtprintfeatures.Rows[0]["logo"].ToString() == "1")
                    {
                        if (File.Exists(Application.StartupPath + "\\logo.jpg"))
                        {
                            string path = Application.StartupPath + "\\logo.jpg";
                            Image r = Image.FromFile(path);
                            //Point p = new Point(82, 0);
                            Point p = new Point(25, 0);
                            e.Graphics.DrawImage(r, p);
                            y += lineHeight;
                            y += 1;
                        }
                    }
                    dtprintfeatures = obj.getprinterfeatures();
                    if (dtprintfeatures.Rows[0]["address1"].ToString() != null)
                    {
                        if (dtprintfeatures.Rows[0]["AddressFont"].ToString() == "Bold")
                        {
                            //Ft = myfontb15;
                            Ft = Addr1Font;
                        }
                        else
                        {
                            //Ft = myfonti15;
                            Ft = Addr1Font;
                        }
                        y += lineHeight;
                        //e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address1"].ToString(), 25), Ft, new SolidBrush(Color.Black), 0, y);
                        e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address1"].ToString(), 25), Ft, new SolidBrush(Color.Black), 0, y);

                        lineHeight = font15.GetHeight(e.Graphics);
                        y += lineHeight;
                    }
                    if (dtprintfeatures.Rows[0]["address2"].ToString() != null)
                    {
                        //e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address2"].ToString(),52), font10, new SolidBrush(Color.Black), 0, y);
                        e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address2"].ToString(), 20), font9, new SolidBrush(Color.Black), 0, y);
                        lineHeight = font10.GetHeight(e.Graphics);
                        y += lineHeight;
                    }
                    if (dtprintfeatures.Rows[0]["address3"].ToString() != null)
                    {
                        //e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address3"].ToString(),48), font10, new SolidBrush(Color.Black), 0, y);
                        e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address3"].ToString(), 25), font10, new SolidBrush(Color.Black), 0, y);
                        lineHeight = font10.GetHeight(e.Graphics);
                        y += lineHeight;
                    }
                    if (dtprintfeatures.Rows[0]["address4"].ToString() != null)
                    {
                        //e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address4"].ToString(),55), font10, new SolidBrush(Color.Black), 0, y);
                        e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address4"].ToString(), 25), font10, new SolidBrush(Color.Black), 0, y);
                        lineHeight = font10.GetHeight(e.Graphics);
                        y += lineHeight;
                    }
                    if (dtprintfeatures.Rows[0]["address5"].ToString() != null)
                    {
                        //e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address5"].ToString(),55), font10, new SolidBrush(Color.Black), 0, y);
                        e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address5"].ToString(), 25), font10, new SolidBrush(Color.Black), 0, y);
                        lineHeight = font10.GetHeight(e.Graphics);
                        //y += lineHeight;
                    }
                    lineHeight = font10.GetHeight(e.Graphics);
                    y += lineHeight;

                   

                    if (dtprintfeatures.Rows[0]["BillName"].ToString() != null)
                    {
                        e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["BillName"].ToString(), 46), font12, new SolidBrush(Color.Black), 0, y);
                        lineHeight = font12.GetHeight(e.Graphics);
                        y += lineHeight;
                    }
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(260, Convert.ToInt32(y)));
                    y += 3;
                    if (dtprintfeatures.Rows[0]["BillNo"].ToString() == "1")
                    {
                        e.Graphics.DrawString("Bill No: " + dtBill.Rows[0]["InvoiceNo"].ToString() + ",   Date : " + DateTime.Now.ToString(), font9, sBrush, 0, y);
                        lineHeight = font10.GetHeight(e.Graphics);
                        y += lineHeight;
                    }
                    if (counterId != 0)
                    {

                        DataTable dt = new DataTable();
                        dt = obj.EditCounter(counterId.ToString());
                        if (dtprintfeatures.Rows[0]["Counter"].ToString() == "1")
                        {
                            if (dt.Rows.Count > 0)
                            {
                                e.Graphics.DrawString("Counter : " + dt.Rows[0]["counter_name"].ToString().ToString(), font9, sBrush, 0, y);
                                //txt_countername.Text = dt.Rows[0]["counter_name"].ToString();
                                //txt_remarks.Text = dt.Rows[0]["remarks"].ToString();

                                //f = 1;
                            }
                        }

                        //lineHeight = font9.GetHeight(e.Graphics);
                        //y += lineHeight;
                        if (dtprintfeatures.Rows[0]["cashierst"].ToString() == "1")
                        {
                            e.Graphics.DrawString("Cashier : " + obj.GetUsernameById(File.ReadAllText("user.txt")), font9, sBrush, 0, y);
                            lineHeight = font9.GetHeight(e.Graphics);
                            y += lineHeight;
                        }
                    }
                    if (dtprintfeatures.Rows[0]["TableStatus"].ToString() == "1")
                    {
                        e.Graphics.DrawString("Table No: " + dtBill.Rows[0]["TableName"].ToString(), font9, sBrush, 0, y);
                        lineHeight = font9.GetHeight(e.Graphics);
                        y += lineHeight;
                    }

                    if (dtprintfeatures.Rows[0]["WaiterStatus"].ToString() == "1")
                    {
                        e.Graphics.DrawString("WaiterCode: " + dtBill.Rows[0]["WaiterCode"].ToString(), font9, sBrush, 0, y);
                        lineHeight = font9.GetHeight(e.Graphics);
                        y += lineHeight;
                    }

                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(260, Convert.ToInt32(y)));
                    y += 3;

                    e.Graphics.DrawString("Sl ", font9, sBrush, xSlno, y);

                    e.Graphics.DrawString("Itemname", font9, sBrush, xitemaname, y);

                    e.Graphics.DrawString("Price", font9, sBrush, xprice, y);

                    e.Graphics.DrawString("Qty", font9, sBrush, xquantity, y);

                    e.Graphics.DrawString("Value", font9, sBrush, xamount, y);

                    y += lineHeight;
                    y += 3;

                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(260, Convert.ToInt32(y)));
                    y += 3;

                    double total = 0, pckcharge = 0;
                    lineHeight = font8.GetHeight(e.Graphics);
                    int slnum = 1;
                    int itemst = Convert.ToInt32(dtprintfeatures.Rows[0]["Itemcode"].ToString());
                    int slnst = Convert.ToInt32(dtprintfeatures.Rows[0]["Slno"].ToString());

                    for (int i = 0; i < dtBill.Rows.Count; i++)
                    {
                        string name = dtBill.Rows[i]["ItemName"].ToString();
                        if (slnst == 1)
                        {
                            e.Graphics.DrawString(slnum.ToString(), font8, sBrush, xSlno, y);

                        }
                        if (itemst == 1)
                        {
                            e.Graphics.DrawString(dtCounterBill.Rows[i]["itemcode"].ToString(), font8, sBrush, xamount, y);

                        }
                        //e.Graphics.DrawString(dtBill.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);
                        e.Graphics.DrawString(dtBill.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);
                        if (dtBill.Rows[i]["ItemArabic"].ToString() != "")
                        {
                            y += lineHeight;
                            e.Graphics.DrawString(dtBill.Rows[i]["ItemArabic"].ToString(), fontarb, sBrush, xitemarabic, y);
                            y -= lineHeight;
                        }


                        y += lineHeight;
                        y += 3;

                        e.Graphics.DrawString(dtBill.Rows[i]["Quntity"].ToString(), font8, sBrush, xquantity, y);
                        e.Graphics.DrawString(dtBill.Rows[i]["Rate"].ToString(), font8, sBrush, xprice, y);
                        e.Graphics.DrawString(dtBill.Rows[i]["Amount"].ToString(), font8, sBrush, xamount, y);

                        total += Convert.ToDouble(dtBill.Rows[i]["Amount"]);
                        pckcharge = Convert.ToDouble(dtBill.Rows[i]["PckCharge"]);
                        slnum += 1;
                        y += lineHeight;
                        y += lineHeight;
                    }
                    tot = total;
                    y += lineHeight;
                    y += 3;
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(260, Convert.ToInt32(y)));
                    y += 3;
                    if (ch_complimet.Checked == true)
                    {
                        e.Graphics.DrawString("Total : Rs." + total.ToString("F2"), font15, sBrush, 60, y);
                        lineHeight = font20.GetHeight(e.Graphics);
                        y += lineHeight;
                        e.Graphics.DrawString("Complimentary Bill", font20, sBrush, 40, y);
                        y += lineHeight;
                    }
                    else
                    {
                        y += 7;
                        if (Convert.ToDouble(dtBill.Rows[0]["PckCharge"]) > 0)
                        {
                            e.Graphics.DrawString("Packing Charge      : Rs." + pckcharge.ToString("F2"), font10, sBrush, 40, y);
                            lineHeight = font15.GetHeight(e.Graphics);
                            y += lineHeight;
                        }


                        //double totaltxamt = ((((total) * 5)) / 100);
                        //double totaltx = ((((total) * 5)) / 100) / 2;

                        //e.Graphics.DrawString("Total            : Rs." +( total+totaltxamt).ToString("F2"), font12, sBrush, 40, y);
                        //lineHeight = font12.GetHeight(e.Graphics);
                        //y += lineHeight;

                        //e.Graphics.DrawString("NetValue      : Rs." + (total  - Convert.ToDouble(dtBill.Rows[0]["discount"].ToString())).ToString("F2"), font12, sBrush, 40, y);
                        //e.Graphics.DrawString("NetValue      : Rs." + (total ).ToString("F2"), font12, sBrush, 40, y);
                        e.Graphics.DrawString("NetValue          : Rs." + (total).ToString("F2"), font10, sBrush, 40, y);
                        lineHeight = font12.GetHeight(e.Graphics);
                        y += lineHeight;

                        //e.Graphics.DrawString("CGST 2.5%      : Rs." + (Convert.ToDouble(totaltx)).ToString("F2"), font10, sBrush, 40, y);
                        //lineHeight = font12.GetHeight(e.Graphics);
                        //y += lineHeight;

                        //e.Graphics.DrawString("SGST 2.5%      : Rs." + (Convert.ToDouble(totaltx)).ToString("F2"), font10, sBrush, 40, y);
                        //lineHeight = font12.GetHeight(e.Graphics);
                        //y += lineHeight;


                        if (Convert.ToDouble(dtBill.Rows[0]["discount"].ToString()) > 0)
                        {
                            e.Graphics.DrawString("Discount      : Rs." + dtBill.Rows[0]["discount"].ToString(), font12, sBrush, 40, y);
                            lineHeight = font10.GetHeight(e.Graphics);
                            y += lineHeight;
                        }
                        //e.Graphics.DrawString("NetValue : Rs." + (total + totaltxamt - Convert.ToDouble(dtBill.Rows[0]["discount"].ToString())).ToString("F2"), font15, sBrush, 40, y);
                        //lineHeight = font12.GetHeight(e.Graphics);

                        //------Round Off-------------------//
                        double AmtWithRoundOff = 0;
                        double AmtWithoutRoundOff = 0;
                        AmtWithoutRoundOff = total - Convert.ToDouble(dtBill.Rows[0]["discount"].ToString());
                        AmtWithRoundOff = CalcAmtRoundOff(Convert.ToDouble(AmtWithoutRoundOff));
                        
                        //----------------------------------//
                        //e.Graphics.DrawString("Total        : Rs." + (total + totaltxamt).ToString("F2"), font15, sBrush, 40, y);
                        //e.Graphics.DrawString("Total        : Rs." + (AmtWithRoundOff).ToString("F2"), font15, sBrush, 40, y);
                        e.Graphics.DrawString("Total        : Rs." + (AmtWithRoundOff).ToString("F2"), font15, sBrush, 40, y);
                        lineHeight = font12.GetHeight(e.Graphics);
                        y += lineHeight;
                    }


                    y += lineHeight;
                    y += lineHeight;
                    y += lineHeight;
                    if (dtprintfeatures.Rows[0]["greeting1"].ToString() != null)
                    {
                        if (dtprintfeatures.Rows[0]["GreetingFont"].ToString() == "Bold")
                        {
                            Fonts1 = myfontb1;
                        }
                        else
                        {
                            Fonts1 = myfonti1;
                        }

                        e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["greeting1"].ToString(), 60), Fonts1, sBrush, 0, y);
                        lineHeight = font9.GetHeight(e.Graphics);
                        y += lineHeight;

                    }

                    if (dtprintfeatures.Rows[0]["greeting2"].ToString() != null)
                    {
                        e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["greeting2"].ToString(), 50), Fonts1, sBrush, 0, y);
                        lineHeight = font9.GetHeight(e.Graphics);
                        y += lineHeight;

                    }
                    e.Graphics.DrawString("   www.loyalitsolutions.com", font9, sBrush, 0, y);

                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void CheckTaxAmoutInBill()
        {
            decimal ItemTot = 0;
            decimal BillTot = 0;
            string BillTotWithTax="0";
            string BillTotWithTaxWithROff="0";
            for (int s = 0; s < dgvKOT.Rows.Count; s++)
            {
                ItemTot += (decimal.Round(Convert.ToDecimal((Convert.ToDouble(dgvKOT["Column6", s].Value))), 2, MidpointRounding.AwayFromZero));
             
            }
            for (int s = 0; s < dgvBill.Rows.Count; s++)
            {
                ItemTot += (decimal.Round(Convert.ToDecimal((Convert.ToDouble(dgvBill["Column3", s].Value))), 2, MidpointRounding.AwayFromZero));
 
            }

            BillTot = Convert.ToDecimal(txtItemTotal.Text == "" ? "0" : txtItemTotal.Text);

            if (BillTot == ItemTot)
            {
                //------------GST Tax Calculation 5% -------------------//
               // BillTotWithTax = Convert.ToString(Convert.ToString(decimal.Round(Convert.ToDecimal(((Convert.ToDouble(BillTot) * 5) / 100) + Convert.ToDouble(BillTot)), 2, MidpointRounding.AwayFromZero)));

                BillTotWithTax = BillTot.ToString();

                BillTotWithTaxWithROff = CalcAmtRoundOff(Convert.ToDouble(BillTotWithTax)).ToString();

                txtItemTotal.Text = BillTotWithTaxWithROff;
            }

        }

    }
}





