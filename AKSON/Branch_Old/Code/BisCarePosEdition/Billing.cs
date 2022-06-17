using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Drawing.Printing;


namespace BisCarePosEdition
{
    public partial class Billing : Form
    {
        int combliment = 0;
        public string index,value1,dgvcellst="0",qty;
        public string wId,names,kotst="0";
        public Billing()
        { 

            InitializeComponent();
            ch_preview.Checked = false;
        }
        int counterId = Convert.ToInt32(File.ReadAllText("counter.txt"));
        Codebehind obj = new Codebehind();
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0",tokenst="0";
        DataTable dtKOT, dtKOTTake,dtprintfeatures;
        internal static DataTable dtCounterBill, dtBill;
        Font font20 = new Font("Arial", 20, GraphicsUnit.Point);
        Font font15 = new Font("Arial", 15, GraphicsUnit.Point);
        Font font8 = new Font("Arial", 8, GraphicsUnit.Point);
        Font font5 = new Font("Arial", 5, GraphicsUnit.Point);
        Font font9 = new Font("Arial", 9, GraphicsUnit.Point);
        Font font10 = new Font("Arial", 10, GraphicsUnit.Point);
        Font font12 = new Font("Arial", 12, GraphicsUnit.Point);
        Font font = new Font("Arial", 12, GraphicsUnit.Point);
        Font fontarb = new Font("trado", 9, GraphicsUnit.Point);
        Font myFontb = new Font("Arial", 12, FontStyle.Bold);
        Font myFonti = new Font("Arial", 12, FontStyle.Italic);

        Font myfontb1 = new Font("Arial", 10, FontStyle.Bold);
        Font myfonti1 = new Font("Arial", 10, FontStyle.Italic);
        Font myfontb15 = new Font("", 15, FontStyle.Bold);
        Font myfonti15 = new Font("",15,FontStyle.Italic);
        Font AddrFont = new Font("", 15, FontStyle.Italic);
        Font fontKotNo = new Font("Arial", 10, FontStyle.Bold);
        Font Addr1Font = new Font("Arial", 9, FontStyle.Bold);
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
        private void ch_dinein_CheckedChanged(object sender, EventArgs e)
        {
        }
        public void FloatValueValidate(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false; 
            else
                e.Handled = true;
        }
        string msg;
        int status1;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        
       {
            try
            {
                if (keyData == Keys.F10)
                {
                    btn_printBill_Click(null, null);
                   
                }
                else if (keyData == Keys.Escape)
                {
                    this.Close();
                }
                else 
                    
                    if (keyData == Keys.F12)
                {
                    Bills bi = new Bills();
                    bi.ShowDialog();
                }
                else if (keyData == Keys.F9)
                {
                    btn_kot_Click(null, null);
                    
                }
                else if (keyData == Keys.F3)
                {
                    PendingOT_S ps = new PendingOT_S();
                    ps.ShowDialog();
                }
                else if (keyData == Keys.F5)
                {
                    string custst = "1";
                if (custst == "1")
                {
                    List<string> li = new List<string>();

                    li.Add(dgv_ItemDteails[12, 0].Value.ToString());
                    for (int index = 0; index < dgv_ItemDteails.Rows.Count; index++)
                    {
                        int chk = 0;
                        for (int i = 0; i < li.Count; i++)
                        {
                            if (li[i] == dgv_ItemDteails[12, index].Value.ToString())
                            {
                                chk = 1;
                            }
                        }
                        if (chk == 0)
                        {
                            li.Add(dgv_ItemDteails[12, index].Value.ToString());
                        }
                    }
                    for (i = 0; i < li.Count; i++)
                    {
                      string  mg = obj.InsertKotMaster(txtCustName.Text, txtMobile.Text, txtEmail.Text, txt_total.Text, "0", cbox_table.SelectedValue.ToString(), cbox_waiter.SelectedValue.ToString(), custst, "0", dtpDate.Value, li[i],tokenst);

                        for (int k = 0; k < dgv_ItemDteails.Rows.Count; k++)
                        {
                            if (li[i] == this.dgv_ItemDteails[12, k].Value.ToString())
                            {
                                obj.InsertKotDetail(mg, dgv_ItemDteails[9, k].Value.ToString(), dgv_ItemDteails[3, k].Value.ToString(), dgv_ItemDteails[4, k].Value.ToString(), dgv_ItemDteails[5, k].Value.ToString());

                            }
                        }
                        DataTable dt = new DataTable();
                        dt = obj.PrintKot(mg);
                        dtKOTTake = dt;
                        PrintKOTTake();
                        clear();
                    }
                }
                    dgv_ItemDteails.Rows.Clear();
                }
                if (keyData == Keys.F2)
                {
                    Payment pt=new Payment();
                    pt.ShowDialog();
                }
                 else
                {
                    return base.ProcessCmdKey(ref msg, keyData);
                }
                 }    
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
            return true;
        }
        int f = 0;
       
        private void Billing_Load(object sender, EventArgs e)
        {

            try
            {
                ApplyTheme();
                btn_creditbill.Enabled = false;
                DataTable dt1 = new DataTable();
                dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "Billing");
                SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
                UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
                DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();
                this.ActiveControl = cbox_table;
                //this.ActiveControl = cbox_table.Focus();
                txtInvoiceNumber.Enabled = true;
                SqlDataReader drr = obj.GetSettings();
                if (drr.Read())
                {
                    if (drr[1].ToString() == "1")
                    {
                        SqlDataReader dr1r = obj.GetInvoiceNo();
                        if (dr1r.Read())
                        {
                            txtInvoiceNumber.Text = dr1r[0].ToString();
                            txtInvoiceNumber.Enabled = false;

                            dr1r.Close();
                        }
                        else
                        {
                            txtInvoiceNumber.Enabled = true;
                        }
                    }
                    drr.Close();
                }
                cbox_table.Focus();
                DataSet ds = new DataSet();
                ds = obj.GetTable();
                cbox_table.DataSource = ds.Tables[0];
                cbox_table.DisplayMember = "TableName";
                cbox_table.ValueMember = "Id";
                DataRow dr = ds.Tables[0].NewRow();
                dr["TableName"] = "--Select One--";
                dr["Id"] = "0";
                ds.Tables[0].Rows.InsertAt(dr, 0);
                cbox_table.SelectedIndex = 0;
                //cbox_waiter.SelectedIndex = 0;
                // load_department();


                //customer
                DataSet ds2 = new DataSet();
                ds2 = obj.GetCustomer();
                cmbcustomer.DataSource = ds2.Tables[0];
                cmbcustomer.DisplayMember = "customer_name";
                cmbcustomer.ValueMember = "customer_id";
                DataRow dr2 = ds2.Tables[0].NewRow();
                dr2["customer_name"] = "--Select One--";
                dr2["customer_id"] = "0";
                ds2.Tables[0].Rows.InsertAt(dr2, 0);
                cmbcustomer.SelectedIndex = 0;

                //**********************************

                DataSet ds1 = new DataSet();
                ds1 = obj.GetItemCode();
                cbox_ItemName.DataSource = ds1.Tables[0];
                cbox_ItemName.DisplayMember = "ItemName";
                cbox_ItemName.ValueMember = "Id";

                cbox_ItemCode.DataSource = ds1.Tables[0];
                cbox_ItemCode.DisplayMember = "ItemCode";
                cbox_ItemCode.ValueMember = "Id";

                DataRow dr1 = ds1.Tables[0].NewRow();
                dr1["ItemName"] = "--Select One--";
                dr1["ItemCode"] = "--Select One--";
                dr1["Id"] = "0";
                ds1.Tables[0].Rows.InsertAt(dr1, 0);
                cbox_ItemCode.SelectedIndex = 0;

                //grp_token.Enabled = false;
                //grp_table.Enabled = true;
                cbox_waiter.Enabled = true;
                f = 1;
                dgv_KotDetails.Rows.Clear();
                if (cbox_waiter.Items.Count > 0)
                    cbox_waiter.SelectedIndex = 0;
                else
                    cbox_waiter.Items.Add("Waiter1");
                  cbox_waiter.SelectedIndex = 0;
                DataSet ds6 = new DataSet();
                ds6 = obj.GetWaiter();
                cbox_waiter.DataSource = ds6.Tables[0];
                cbox_waiter.DisplayMember = "Name";
                cbox_waiter.ValueMember = "Id";
               

                //default waiter
                //if (cbox_waiter.Items.Count > 0)
                //    cbox_waiter.SelectedIndex = 0;
                //else
                //    cbox_waiter.Text = "Waiter1";


              

                //*************************


                DataRow dr6 = ds6.Tables[0].NewRow();
                dr6["Name"] = "--Select One--";
                dr6["Id"] = "0";
                ds6.Tables[0].Rows.InsertAt(dr6, 0);
               // dr6["Name"] = "--Select One--";
                //cbox_waiter.SelectedIndex = 1;
                cbox_waiter.SelectedIndex = 0;
                cbox_waiter.Enabled = true;
                cbox_Token.Enabled = false;
                g = 1;
                if (obj.GetACoountType(File.ReadAllText("user.txt")) == "1")
                {
                    ch_complimet.Enabled = true;
                    txt_discount.Enabled = true;
                }
                else
                {
                    ch_complimet.Enabled = true;
                    txt_discount.Enabled = true;
                }
                radiocash.Checked = true;
                radiocredit.Checked = false;
                //cbox_waiter.Focus();
                //cbox_ItemCode.Focus();
                rd_dinein.Checked = true;
                //rd_counterBill.Checked = true;  
                c = 0;

                if (cbox_waiter.Items.Count > 0)
                    cbox_waiter.SelectedIndex = 1;
                else
                    cbox_waiter.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
            rd_counterBill.Checked = false;
            //rd_counterBill.Checked = true;
            cbox_ItemCode.Focus();
            //cbox_waiter.Focus();
        }
        int g = 0;
        int ACStatus;//To check the table is in AC or Non AC
        private void cbox_table_SelectedIndexChanged(object sender, EventArgs e)
         {
             try
             {
                 if (c != 1)
                 {
                     cbox_waiter.Enabled = true;
                     h = 0;
                     //cbox_waiter.SelectedValue = 0;
                     ItemDetailClear();
                     dgv_KotDetails.Rows.Clear();
                     if (f == 1)
                     {
                         ACStatus = obj.TableACStat(cbox_table.SelectedValue.ToString());// To check the table is in AC or Non AC
                         DataTable dt = new DataTable();
                         dt = obj.GetKotDetails(cbox_table.SelectedValue.ToString());

                         for (int d = 0; d < dt.Rows.Count; d++)
                         {
                             dgv_KotDetails.Rows.Add();
                             dgv_KotDetails[0, d].Value = d + 1;
                             int code =Convert.ToInt32(dt.Rows[d]["ItemId"].ToString());
                             dgv_KotDetails[1, d].Value = dt.Rows[d]["ItemCode"].ToString();
                             dgv_KotDetails[2, d].Value = dt.Rows[d]["ItemName"].ToString();
                             dgv_KotDetails[3, d].Value = dt.Rows[d]["Quantity"].ToString();
                             dgv_KotDetails[4, d].Value = dt.Rows[d]["Rate"].ToString();
                             dgv_KotDetails[5, d].Value = dt.Rows[d]["Amount"].ToString();
                             dgv_KotDetails[6, d].Value = dt.Rows[d]["TableName"].ToString();
                             dgv_KotDetails[7, d].Value = dt.Rows[d]["Waiter"].ToString();
                             dgv_KotDetails[8, d].Value = dt.Rows[d]["ItemId"].ToString();
                             dgv_KotDetails[9, d].Value = dt.Rows[d]["Id"].ToString();
                             // dgv_KotDetails[15, d].Value = dt.Rows[d]["department"].ToString();
                             // dgv_KotDetails[17, d].Value = dt.Rows[d]["kotno"].ToString();
                             if (dt.Rows[d]["CustomerStatus"].ToString() == "1")
                             {
                                 rd_dinein.Checked = true;
                             }
                             if (dt.Rows[d]["CustomerStatus"].ToString() == "2")
                             {
                                 rd_takeaway.Checked = true;
                             }
                             DataTable dt1=new DataTable();
                             dt1=obj.GetSt(code);
                             if (Convert.ToInt32(dt1.Rows[0]["ChangeSellpricestatus"].ToString()) == 1)
                             {
                                 this.dgv_KotDetails.Rows[d].Cells["dataGridViewTextBoxColumn5"].ReadOnly = false;
                             }
                             else
                                 this.dgv_KotDetails.Rows[d].Cells["dataGridViewTextBoxColumn5"].ReadOnly = true;
                             dgv_KotDetails[10, d].Value = dt.Rows[d]["TableId"].ToString();
                             dgv_KotDetails[11, d].Value = dt.Rows[d]["WaiterId"].ToString();

                             cbox_waiter.SelectedValue = dgv_KotDetails[11, d].Value;
                             cbox_waiter.Enabled = false;
                             dgv_KotDetails[12, d].Value = dt.Rows[d]["Token"].ToString();
                             dgv_KotDetails[14, d].Value = dt.Rows[d]["DetaileID"].ToString();
                         }
                         double total = 0;
                         for (int r = 0; r < dgv_KotDetails.Rows.Count; r++)
                         {
                             total += (Convert.ToDouble(dgv_KotDetails[5, r].Value));
                         }


                         txt_total.Text = Convert.ToString((decimal.Round(Convert.ToDecimal(total), 2, MidpointRounding.AwayFromZero)));
                         txt_total1.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));
                         //txt_total1.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));
                         //------------GST Tax Calculation 5% -------------------//
                         txt_total.Text = Convert.ToString(Convert.ToString(decimal.Round(Convert.ToDecimal(((Convert.ToDouble(txt_total1.Text) * 5) / 100) + Convert.ToDouble(txt_total1.Text)), 2, MidpointRounding.AwayFromZero)));
                         txttax.Text = Convert.ToString(Convert.ToDecimal(txt_total.Text) - Convert.ToDecimal(txt_total1.Text));
                         //------------------------------------------------------//
                         //------Round Off-------------------//
                         double AmtWithRoundOff = 0;
                         AmtWithRoundOff = CalcAmtRoundOff(Convert.ToDouble(txt_total.Text));
                         txt_total.Text = AmtWithRoundOff.ToString();
                         //----------------------------------//


                         SqlDataReader dr1 = obj.GetWaiterbyTable(cbox_table.SelectedValue.ToString());
                         if (dr1.Read() && dr1.HasRows && dr1[1].ToString() != "0")
                         {
                             cbox_waiter.SelectedValue = dr1[1].ToString();
                             cbox_waiter.Enabled = false;
                             h = 1;
                             dr1.Close();
                         }
                         else
                         {
                             cbox_waiter.Enabled = true;
                             cbox_waiter.SelectedIndex = 0;
                         }

                     }
                 }
                 SetDefaultWaiter();
             }
             catch (Exception ex)
             {
                 File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
             }
        
        }

        private void txt_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_Quantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_Quantity.Text == "" || txt_Quantity.Text == ".")
                {
                    txt_Quantity.Text = "0";
                }
                if (txt_Quantity.Text.EndsWith("0") == true)
                {
                    txt_Quantity.Text = Convert.ToDouble(txt_Quantity.Text).ToString();
                }
                string Str = txt_Quantity.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                int c = txt_Quantity.Text.Count(x => x == '.');
                if (c > 1)
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Quantity.Text = "0";
                }
                else
                {
                    if (txt_Quantity.Text.EndsWith(".") == false)
                    {
                        if (isNum)
                        {
                            if (txt_Quantity.Text != "" && txt_Rate.Text != "")
                            {
                                txt_Quantity.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(txt_Quantity.Text), 2, MidpointRounding.AwayFromZero));
                                txt_totalAmount.Text = Convert.ToString(decimal.Round(Convert.ToDecimal((Convert.ToDouble(txt_Quantity.Text)) * (Convert.ToDouble(txt_Rate.Text))), 2, MidpointRounding.AwayFromZero));

                                txt_total.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));
                                txt_Quantity.Select(txt_Quantity.Text.Length, 0);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_Quantity.Text = "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        int i;
        public string check()
        {

            string status = "1";
            try
            {
                if ((cbox_table.SelectedIndex <= 0) && (rd_dinein.Checked == true))
                {
                    status = "0";
                    MessageBox.Show("Please select a table", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbox_table.Focus();

                }
                else
                {
                    if ((cbox_Token.Text == string.Empty) && (rd_takeaway.Checked == true))
                    {
                        status = "0";
                        MessageBox.Show("Please select a token", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbox_Token.Focus();
                    }    
                    else
                    {if ((cbox_waiter.SelectedIndex <= 0) && (rd_dinein.Checked == true))
                        {
                            status = "0";
                            MessageBox.Show("Please select a waiter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cbox_waiter.Focus();  
                        }
                        else
                        {
                            if (cbox_ItemCode.SelectedIndex <= 0)
                            {
                                status = "0";
                                MessageBox.Show("Please select item code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cbox_ItemCode.Focus();
                            }
                            else
                            {
                                if (cbox_ItemName.SelectedIndex <= 0)
                                {
                                    status = "0";
                                    MessageBox.Show("Please select item name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cbox_ItemName.Focus();
                                }
                                else
                                {
                                    if (txt_Quantity.Text == "0")
                                    {
                                        status = "0";
                                        MessageBox.Show("Please enter quantity", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txt_Quantity.Focus();
                                    }
                                    else
                                    {
                                        if (txt_Rate.Text == "0")
                                        {
                                            status = "0";
                                            MessageBox.Show("Please enter Rate", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txt_Rate.Focus();
                                        }
                                        else
                                        {
                                            status = "1";
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
            return status;
        }
        public void ItemDetailClear()
        {
            cbox_ItemName.SelectedValue = "0";
            txt_Quantity.Text = "0";
            txt_Rate.Text = "0";
            txt_totalAmount.Text = "0.00";
            dgv_ItemDteails.Rows.Clear();
        }
        
        int h = 0;
        string addst = "0";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            addst = "0";
            string st = check();
            try
            {
                if (st == "1")
                {
                    for (int i = 0; i < dgv_ItemDteails.Rows.Count; i++)
                    {
                        if (cbox_ItemName.SelectedValue.ToString() == dgv_ItemDteails[9, i].Value.ToString())
                        {
                            dgv_ItemDteails[3, i].Value = Convert.ToDouble(dgv_ItemDteails[3, i].Value) + Convert.ToDouble(txt_Quantity.Text);
                            dgv_ItemDteails[5, i].Value = Convert.ToString(Convert.ToDouble(dgv_ItemDteails[4, i].Value) * (Convert.ToDouble(dgv_ItemDteails[3, i].Value)));
                            addst = "1";
                        }
                    }
                    if (rd_counterBill.Checked == true)
                    {
                        if (addst == "0")
                        {
                            dgv_ItemDteails.Rows.Add();
                            i = dgv_ItemDteails.Rows.Count - 1;
                            dgv_ItemDteails[0, i].Value = i + 1;
                            dgv_ItemDteails[1, i].Value = cbox_ItemCode.Text;
                            dgv_ItemDteails[2, i].Value = cbox_ItemName.Text;
                            dgv_ItemDteails[3, i].Value = Convert.ToDouble(txt_Quantity.Text).ToString("F2");
                            dgv_ItemDteails[4, i].Value = Convert.ToDouble(txt_Rate.Text).ToString("F2");
                            dgv_ItemDteails[5, i].Value = Convert.ToDouble(txt_totalAmount.Text).ToString("F2");
                            dgv_ItemDteails[6, i].Value = cbox_table.Text;
                            dgv_ItemDteails[7, i].Value = cbox_waiter.Text;
                            dgv_ItemDteails[9, i].Value = cbox_ItemName.SelectedValue.ToString();
                            dgv_ItemDteails[10, i].Value = "0";
                            dgv_ItemDteails[11, i].Value = "0";
                            dgv_ItemDteails[12, i].Value = "0";
                            dgv_ItemDteails[13, i].Value = txtdepartment.Text; 
                        }
                    }
                    else
                    {
                        if (rd_takeaway.Checked == true)
                        {
                            if (addst == "0")
                            {
                                dgv_ItemDteails.Rows.Add();
                                i = dgv_ItemDteails.Rows.Count - 1;
                                dgv_ItemDteails[0, i].Value = i + 1;
                                dgv_ItemDteails[1, i].Value = cbox_ItemCode.Text;
                                dgv_ItemDteails[2, i].Value = cbox_ItemName.Text;
                                dgv_ItemDteails[3, i].Value = Convert.ToDouble(txt_Quantity.Text).ToString("F2");
                                dgv_ItemDteails[4, i].Value = Convert.ToDouble(txt_Rate.Text).ToString("F2");
                                dgv_ItemDteails[5, i].Value = Convert.ToDouble(txt_totalAmount.Text).ToString("F2");
                                // dgv_ItemDteails[6, i].Value = cbox_table.Text;
                                //dgv_ItemDteails[7, i].Value = cbox_waiter.Text;
                                dgv_ItemDteails[9, i].Value = cbox_ItemName.SelectedValue.ToString();
                                dgv_ItemDteails[10, i].Value = "0";
                                dgv_ItemDteails[11, i].Value = "0";
                                dgv_ItemDteails[12, i].Value = cbox_Token.Text;
                                dgv_ItemDteails[13, i].Value = txtdepartment.Text;
                            }
                        }
                        else
                        {
                            if (addst == "0")
                            {
                                dgv_ItemDteails.Rows.Add();
                                i = dgv_ItemDteails.Rows.Count - 1;
                                dgv_ItemDteails[0, i].Value = i + 1;
                                dgv_ItemDteails[1, i].Value = cbox_ItemCode.Text;
                                dgv_ItemDteails[2, i].Value = cbox_ItemName.Text;
                                dgv_ItemDteails[3, i].Value = Convert.ToDouble(txt_Quantity.Text).ToString("F2");
                                dgv_ItemDteails[4, i].Value = Convert.ToDouble(txt_Rate.Text).ToString("F2");
                                dgv_ItemDteails[5, i].Value = Convert.ToDouble(txt_totalAmount.Text).ToString("F2");
                                dgv_ItemDteails[6, i].Value = cbox_table.Text;
                                dgv_ItemDteails[7, i].Value = cbox_waiter.Text.ToString();
                                dgv_ItemDteails[9, i].Value = cbox_ItemName.SelectedValue.ToString();
                                dgv_ItemDteails[10, i].Value = cbox_waiter.SelectedValue.ToString();
                                dgv_ItemDteails[11, i].Value = cbox_table.SelectedValue.ToString();
                                dgv_ItemDteails[12, i].Value = "0";
                                dgv_ItemDteails[13, i].Value = txtdepartment.Text;

                            }
                        }
                    }
                    dgv_ItemDteails.FirstDisplayedScrollingRowIndex = (dgv_ItemDteails.Rows.Count) - 1;
                    txt_total.Text = "0";
                   

                    if (dgv_KotDetails.Rows.Count <= 0)
                    {

                        //decimal Tot = 0;
                        //double Tot1 = 0;

                        //for (int s = 0; s < dgv_ItemDteails.Rows.Count; s++)
                        //{
                        //    Tot += (decimal.Round(Convert.ToDecimal((Convert.ToDouble(dgv_ItemDteails[5, s].Value))), 2, MidpointRounding.AwayFromZero));
                        //    txt_total.Text = Tot.ToString();
                        //    //txt_total1.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));
                        //    Tot1 += Convert.ToDouble(string.Format("{0:0.00}", Convert.ToDouble(dgv_ItemDteails["Column10", s].Value) * Convert.ToDouble(dgv_ItemDteails["Column4", s].Value)));
                        //    txt_total1.Text = Tot1.ToString();
                        //}
                        ////------------GST Tax Calculation 5% -------------------//
                        //txt_total.Text = Convert.ToString(Convert.ToString(decimal.Round(Convert.ToDecimal(((Convert.ToDouble(txt_total1.Text) * 5) / 100) + Convert.ToDouble(txt_total1.Text)), 2, MidpointRounding.AwayFromZero)));
                        //txttax.Text = Convert.ToString(Convert.ToDecimal(txt_total.Text) - Convert.ToDecimal(txt_total1.Text));
                        ////------------------------------------------------------//
                       


                        FindGstWhenNoKotGrid();

                    }
                    else
                    {


                        FindGstWhenValueInKotGrid();

                        //string GStTotAmtWithoutRoundOff = "0";
                        //GstCalculation();
                        //GstCalculationKot();
                        //GStTotAmtWithoutRoundOff = (Convert.ToDouble(GstTot) + Convert.ToDouble(GstTotKot)).ToString();
                        //GStTotAmt = CalcAmtRoundOff(Convert.ToDouble(GStTotAmtWithoutRoundOff)).ToString();

                        //txt_total1.Text = (Convert.ToDouble(GstTot1) + Convert.ToDouble(GstTot1Kot)).ToString();
                        //txt_total.Text = GStTotAmt;
                        //txttax.Text = (Convert.ToDouble(GstTax)+Convert.ToDouble(GstTaxKot)).ToString();
                        ////------------------------------------------------------//

                       
                        //GStTotAmtWithoutRoundOff = "0";
                        //GstClear();
                        //GstClearKot();
                    }



                    //------Round Off-------------------//
                    double AmtWithRoundOff = 0;
                    AmtWithRoundOff = CalcAmtRoundOff(Convert.ToDouble(txt_total.Text));
                    txt_total.Text = AmtWithRoundOff.ToString();
                    //----------------------------------//

                    
                    cbox_waiter.Enabled = false;
                    cbox_ItemCode.SelectedIndex = 0;
                    txt_Quantity.Text = "";
                    txt_Rate.Text = "";
                    lbUnit.Text = "";
                    txt_ProductStock.Text = "";
                    cbox_ItemCode.Focus();
                    //cbox_waiter.Focus();
                    h = 1;
                    ////default waiter
                    //if (cbox_waiter.Items.Count > 0)
                    //    cbox_waiter.SelectedIndex = 1;
                    //else
                    //    cbox_waiter.Text = "Waiter1";

                    ////*************************
                    cbox_ItemCode.Focus();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        private void dgv_ItemDteails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 8)
                {
                    dgv_ItemDteails.Rows.RemoveAt(e.RowIndex);

                    double total = 0;
                    //dgv_ItemDteails[5, i].Value = Convert.ToString(Convert.ToDouble(dgv_ItemDteails[4, i].Value) * (Convert.ToDouble(dgv_ItemDteails[3, i].Value)));
                    //for (int r = 0; r < dgv_ItemDteails.Rows.Count; r++)
                    //{
                    //    total += (Convert.ToDouble(dgv_ItemDteails[5, r].Value));
                    //}
                    //decimal Tot = 0;
                    //double Tot1 = 0;
                    //if (dgv_ItemDteails.Rows.Count > 0)
                    //{
                    //    for (int s = 0; s < dgv_ItemDteails.Rows.Count; s++)
                    //    {
                    //        Tot += (decimal.Round(Convert.ToDecimal((Convert.ToDouble(dgv_ItemDteails[5, s].Value))), 2, MidpointRounding.AwayFromZero));
                    //        txt_total.Text = Tot.ToString();
                    //        //txt_total1.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));
                    //        Tot1 += Convert.ToDouble(string.Format("{0:0.00}", Convert.ToDouble(dgv_ItemDteails["Column10", s].Value) * Convert.ToDouble(dgv_ItemDteails["Column4", s].Value)));
                    //        txt_total1.Text = Tot1.ToString();
                    //    }


                    //    //------------GST Tax Calculation 5% -------------------//
                    //    txt_total.Text = Convert.ToString(Convert.ToString(decimal.Round(Convert.ToDecimal(((Convert.ToDouble(txt_total1.Text) * 5) / 100) + Convert.ToDouble(txt_total1.Text)), 2, MidpointRounding.AwayFromZero)));
                    //    txttax.Text = Convert.ToString(Convert.ToDecimal(txt_total.Text) - Convert.ToDecimal(txt_total1.Text));
                    //    //------------------------------------------------------//
                   
                    //}

                    if (dgv_KotDetails.Rows.Count <= 0)
                    {
                        FindGstWhenNoKotGrid();
                    }
                    else
                    {
                        FindGstWhenValueInKotGrid();
                    }

                    if (dgv_ItemDteails.Rows.Count == 0 && dgv_KotDetails.Rows.Count==0)
                    {
                        txt_total.Text = "0.00";
                        txttax.Text = "0.00";
                        txt_total1.Text = "0.00";
                    }


                    //------Round Off-------------------//
                    double AmtWithRoundOff = 0;
                    AmtWithRoundOff = CalcAmtRoundOff(Convert.ToDouble(txt_total.Text));
                    txt_total.Text = AmtWithRoundOff.ToString();
                    //----------------------------------//


                    //  Convert.ToString(decimal.Round(Convert.ToDecimal(txt_Quantity.Text), 2, MidpointRounding.AwayFromZero));
                    //txt_total.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(total), 2, MidpointRounding.AwayFromZero));
                    //txt_total.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        private void checkradiostatus()
        {
            if (rd_dinein.Checked == true)
            {
                custst = "1";
                tokenst = "0";
            }
            if (rd_takeaway.Checked == true)
            {
                custst = "2";
                tokenst = "1";
            }
            if (rd_counterBill.Checked == true)
                custst = "3";

            if (rb_homedelivery.Checked == true)
            {
                custst = "4";
                tokenst = "2";
            }
        }
        private void cbox_ItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (f == 1)
                {
                    SqlDataReader dr = obj.GetItemSellPrice(cbox_ItemName.SelectedValue.ToString());
                    checkradiostatus();

                    if (dr.Read())
                    {
                        if (ACStatus == 1 && rb_homedelivery.Checked == false)//In AC
                        {
                            txt_Rate.Text = dr[0].ToString();//AC Rate
                        }
                        else if (ACStatus == 0 && rb_homedelivery.Checked == false && rd_takeaway.Checked ==false )
                        {
                            txt_Rate.Text = dr[2].ToString();//Non AC Rate
                        }
                        else if(custst == "2"&& rb_homedelivery.Checked == false)//take away
                        {
                            txt_Rate.Text = dr[0].ToString();
                        }
                        else if (custst == "4")//home delivery 
                        {
                            txt_Rate.Text = dr[0].ToString(); 
                        }

                        lbUnit.Text = dr[1].ToString();
                        dr.Close();
                    }
                    SqlDataReader dr1 = obj.GetProductStock(cbox_ItemName.SelectedValue.ToString());
                    if (dr1.Read())
                    {
                        txt_ProductStock.Text = dr1[0].ToString();
                        dr1.Close();
                    }
                    SqlDataReader dar = obj.GETdept(cbox_ItemName.SelectedValue.ToString());
                    if (dar.Read())
                    {
                        txtdepartment.Text = dar[0].ToString();
                        dar.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        private void txt_Rate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_Rate.Text == "")
                {
                    txt_Rate.Text = "0";
                }
                string Str = txt_Rate.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    if (txt_Quantity.Text != "" && txt_Rate.Text != "")
                    {
                        txt_Rate.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(txt_Rate.Text), 2, MidpointRounding.AwayFromZero));
                        txt_totalAmount.Text = Convert.ToString(Convert.ToDouble(decimal.Round(Convert.ToDecimal(Convert.ToDouble(txt_Quantity.Text) * (Convert.ToDouble(txt_Rate.Text))), 2, MidpointRounding.AwayFromZero)));
                        txt_total.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Rate.Text = "0";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        private void txt_totalAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Str = txt_totalAmount.Text.Trim();
                double Num;

                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {

                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_totalAmount.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
        string custst;
        int c = 0;
        private void btn_kot_Click(object sender, EventArgs e)
        
         {
            c = 1;
          string msg = "0";
            try
            {
                if (rd_dinein.Checked == true)
                {
                    custst = "1";
                    tokenst = "0";
                }
                if (rd_takeaway.Checked == true)
                {
                    custst = "2";
                    tokenst = "1";
                }
                if (rd_counterBill.Checked == true)
                    custst = "3";
                
                if(rb_homedelivery.Checked==true)
                {
                    custst="4";
                    tokenst ="2";
                }
                        
             if (dgv_ItemDteails.Rows.Count > 0)
                {
                    if (custst == "2")
                    {
                        msg = obj.InsertKotMaster(txtCustName.Text, txtMobile.Text, txtEmail.Text, txt_total.Text, "0", "0", "0", custst, cbox_Token.Text, dtpDate.Value, txtdepartment.Text,tokenst);
                       
                        for (i = 0; i < dgv_ItemDteails.Rows.Count; i++)
                        {
                            obj.InsertKotDetail(msg, dgv_ItemDteails[9, i].Value.ToString(),this.dgv_ItemDteails[3, i].Value.ToString(), dgv_ItemDteails[4, i].Value.ToString(), dgv_ItemDteails[5, i].Value.ToString());
                           }
                    }
                    if (custst == "4")
                    {
                        msg = obj.InsertKotMaster(txtCustName.Text, txtMobile.Text, txtEmail.Text, txt_total.Text, "0", "0", "0", custst, cbox_Token.Text, dtpDate.Value,txtdepartment.Text, tokenst);
                        for (int i = 0; i < dgv_ItemDteails.Rows.Count; i++)
                        {
                            obj.InsertKotDetail(msg, dgv_ItemDteails[9, i].Value.ToString(), dgv_ItemDteails[3, i].Value.ToString(), dgv_ItemDteails[4, i].Value.ToString(), dgv_ItemDteails[5, i].Value.ToString());
                        }

                    }
                    if (custst == "1")
                    {
                        List<string> li = new List<string>();
                        li.Add(dgv_ItemDteails[13, 0].Value.ToString());
                        for (int index = 0; index < dgv_ItemDteails.Rows.Count; index++)
                        {
                            int chk = 0;
                            for (int i = 0; i < li.Count; i++)
                            {
                                if (li[i] == dgv_ItemDteails[13, index].Value.ToString())
                                {
                                    chk = 1;
                                }

                            }
                            if (chk == 0)
                            {
                                li.Add(dgv_ItemDteails[13, index].Value.ToString());
                            }
                        }    
                        for ( i = 0; i < li.Count; i++)
                            {
                                msg = obj.InsertKotMaster(txtCustName.Text, txtMobile.Text, txtEmail.Text, txt_total.Text, "0", cbox_table.SelectedValue.ToString(), cbox_waiter.SelectedValue.ToString(), custst, "0", dtpDate.Value,li[i],tokenst);

                                for (int k = 0; k < dgv_ItemDteails.Rows.Count; k++)
                                {     
                                   if (li[i] == this.dgv_ItemDteails[13, k].Value.ToString())
                                    {
                                        obj.InsertKotDetail(msg, dgv_ItemDteails[9, k].Value.ToString(), dgv_ItemDteails[3, k].Value.ToString(), dgv_ItemDteails[4, k].Value.ToString(), dgv_ItemDteails[5, k].Value.ToString());

                                    }

                                }
                                DataTable dt = new DataTable();
                                dt = obj.PrintKot(msg);
                                dtKOT = dt;
                                PrintKOT();
                               
                                
                            }
                        clear();
                        }
                    if (custst == "1")
                    {
                        // DataTable dt = new DataTable();
                        //dt = obj.PrintKot(msg);
                        //dtKOT = dt;
                        // PrintKOT();
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt = obj.PrintKotTake(msg);
                        dtKOTTake = dt;
                        PrintKOTTake();
                      
                    }
                    clear();
                                txt_total1.Text = "0.00";
                                txt_discount.Text = "0";
                                dgv_KotDetails.Rows.Clear();
                                cbox_table.Focus();
                                rd_counterBill.Checked = false; //cbox_ItemCode.Focus();
                                if (rd_dinein.Checked == true)
                                {
                                    DataTable dt = new DataTable();
                                    dt = obj.GetKotDetails(cbox_table.SelectedValue.ToString());
                                    for (int d = 0; d < dt.Rows.Count; d++)
                                    {
                                        dgv_KotDetails.Rows.Add();
                                        dgv_KotDetails[0, d].Value = d + 1;
                                        dgv_KotDetails[1, d].Value = dt.Rows[d]["ItemCode"].ToString();
                                        dgv_KotDetails[2, d].Value = dt.Rows[d]["ItemName"].ToString();
                                        dgv_KotDetails[3, d].Value = Convert.ToDouble(dt.Rows[d]["Quantity"]).ToString("F2");
                                        dgv_KotDetails[4, d].Value = Convert.ToDouble(dt.Rows[d]["Rate"]).ToString("F2");
                                        dgv_KotDetails[5, d].Value = Convert.ToDouble(dt.Rows[d]["Amount"]).ToString("F2");
                                        dgv_KotDetails[6, d].Value = dt.Rows[d]["TableName"].ToString();
                                        dgv_KotDetails[7, d].Value = dt.Rows[d]["Waiter"];
                                        dgv_KotDetails[8, d].Value = dt.Rows[d]["ItemId"].ToString();
                                       
                                    }
                                }
                                if (rb_homedelivery.Checked == true)
                                {
                                    DataTable dt = new DataTable();
                                    dt = obj.GetKotDetailsByToken(cbox_Token.Text, tokenst);
                                    if (dt.Rows.Count > 0)
                                    {
                                        for (int d = 0; d < dt.Rows.Count; d++)
                                        {
                                            dgv_KotDetails.Rows.Add();
                                            dgv_KotDetails[0, d].Value = d + 1;
                                            dgv_KotDetails[1, d].Value = dt.Rows[d]["ItemCode"].ToString();
                                            dgv_KotDetails[2, d].Value = dt.Rows[d]["ItemName"].ToString();
                                            dgv_KotDetails[3, d].Value = Convert.ToDouble(dt.Rows[d]["Quantity"]).ToString("F2");
                                            dgv_KotDetails[4, d].Value = Convert.ToDouble(dt.Rows[d]["Rate"]).ToString("F2");
                                            dgv_KotDetails[5, d].Value = Convert.ToDouble(dt.Rows[d]["Amount"]).ToString("F2");
                                            //dgv_KotDetails[6, d].Value = dt.Rows[d]["TableName"].ToString();
                                            // dgv_KotDetails[7, d].Value = dt.Rows[d]["Waiter"].ToString();
                                            dgv_KotDetails[8, d].Value = dt.Rows[d]["ItemId"].ToString();
                                            dgv_KotDetails[9, d].Value = dt.Rows[d]["Id"].ToString();

                                        }
                                    }
                                }
                                if (rd_takeaway.Checked == true)
                                {
                                    DataTable dt = new DataTable();
                                    dt = obj.GetKotDetailsByToken(cbox_Token.Text,tokenst);
                                    if (dt.Rows.Count > 0)
                                    {
                                        for (int d = 0; d < dt.Rows.Count; d++)
                                        {
                                            dgv_KotDetails.Rows.Add();
                                            dgv_KotDetails[0, d].Value = d + 1;
                                            dgv_KotDetails[1, d].Value = dt.Rows[d]["ItemCode"].ToString();
                                            dgv_KotDetails[2, d].Value = dt.Rows[d]["ItemName"].ToString();
                                            dgv_KotDetails[3, d].Value = Convert.ToDouble(dt.Rows[d]["Quantity"]).ToString("F2");
                                            dgv_KotDetails[4, d].Value = Convert.ToDouble(dt.Rows[d]["Rate"]).ToString("F2");
                                            dgv_KotDetails[5, d].Value = Convert.ToDouble(dt.Rows[d]["Amount"]).ToString("F2");
                                            dgv_KotDetails[7, d].Value = dt.Rows[d]["Waiter"].ToString();
                                            dgv_KotDetails[8, d].Value = dt.Rows[d]["ItemId"].ToString();
                                            dgv_KotDetails[9, d].Value = dt.Rows[d]["Id"].ToString();
                                            dgv_KotDetails[1, d].Value = txtdepartment.Text;
                                     
                                           
                                        }
                                    }
                                    double total = 0;
                                    for (int r = 0; r < dgv_KotDetails.Rows.Count; r++)
                                    {
                                        total += (Convert.ToDouble(dgv_KotDetails[5, r].Value));
                                    }
                                    // Convert.ToString(Convert.ToString(decimal.Round(Convert.ToDecimal((Convert.ToDouble(txt_total.Text) + Convert.ToDouble(dgv_ItemDteails[5, s].Value))), 2, MidpointRounding.AwayFromZero)));
                                    txt_total.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(total), 2, MidpointRounding.AwayFromZero));
                                    txt_total.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));

                                    cbox_table.SelectedIndex = 0;
                                    cbox_waiter.SelectedIndex = 0;
                                }
                }      
             else
             {   
                    MessageBox.Show("Please select items for KOT", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    c = 0;
                    cbox_ItemName.Focus();
                    return;          
                                }
                                dgv_ItemDteails.Rows.Clear();
                                cbox_table.SelectedIndex = 0;
                                cbox_waiter.SelectedIndex = 0;
                                //default waiter
                                if (cbox_waiter.Items.Count > 0)
                                    cbox_waiter.SelectedIndex = 1;
                                else
                                    cbox_waiter.Text = "Waiter1";

                                //*************************

                               // clear();
                                rd_counterBill.Checked = false;
                                rd_dinein.Checked = true;
                                c = 0;

                            } 
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        private void cbox_ItemCode_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cbox_ItemCode_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cbox_ItemCode.DroppedDown)
            {
                cbox_ItemCode.Focus();  
            }
        }
        private void cbox_table_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cbox_table.DroppedDown)
            {
                cbox_table.Focus();
            }
        }
        private void cbox_waiter_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cbox_waiter.DroppedDown)
            {
                cbox_waiter.Focus();
            }
        }
        private void cbox_ItemName_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cbox_ItemName.DroppedDown)
            {
                cbox_ItemName.Focus();
            }
        }
        public void PrintKOT()
        {
    try
    {
        //PrintDocument doc = new PrintDocument();
        //doc.PrintPage += this.Doc_PrintPageKOT;
        ////doc.PrinterSettings.PrinterName = "VENDOR THERMAL PRINTER";
        //doc.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
        PrintDocument doc1 = new PrintDocument();
        doc1.PrintPage += this.Doc_PrintPageKOT;
        doc1.PrinterSettings.PrinterName = File.ReadAllText("Printer.txt");
        doc1.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
        //doc.OriginAtMargins = true;     
        try
        {
                    
            doc1.Print();
                
                
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
            // throw new ApplicationException("Printer Error");
        }
               
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }
        private void Doc_PrintPageKOT(object sender, PrintPageEventArgs e)
        {
    try
    {
        if (dtKOT.Rows.Count > 0)
        {
            float x = e.MarginBounds.Left;
            float y = 10;
            int widtableh = e.PageBounds.Width;
            int height = e.PageBounds.Height;
            float lineHeight = font20.GetHeight(e.Graphics);
            float xSlno = 0;
            float xitemaname = 40;
            float xquantity = 200;
            e.Graphics.DrawString("                      KOT", font12, new SolidBrush(Color.Black), 0, y);
            lineHeight = font12.GetHeight(e.Graphics);
            y += lineHeight;

            e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
            y += 3;
            if (counterId != 0)
            {
                         

                DataTable dt = new DataTable();
                dt = obj.EditCounter(counterId.ToString());
                if (dt.Rows.Count > 0)
                {
                    e.Graphics.DrawString("Counter : " + dt.Rows[0]["counter_name"].ToString().ToString(), font9, sBrush, 0, y);
                            
                }
                //e.Graphics.DrawString("Counter : " + obj.GetUsernameById(File.ReadAllText("user.txt")), font9, sBrush, 0, y);
                lineHeight = font9.GetHeight(e.Graphics);
                y += lineHeight;
            }

            e.Graphics.DrawString("KOT: " + dtKOT.Rows[0]["kotno"].ToString() + "                            Table : " + dtKOT.Rows[0]["TableName"].ToString(), fontKotNo, sBrush, 0, y);
            lineHeight = font12.GetHeight(e.Graphics);
            y += lineHeight;

            e.Graphics.DrawString("Date: " + DateTime.Now.ToString(), font10, sBrush, 0, y);
            lineHeight = font10.GetHeight(e.Graphics);
            y += lineHeight; 

            e.Graphics.DrawString("Department: " + dtKOT.Rows[0]["department"].ToString(), font10, sBrush, 0, y);
            lineHeight = font10.GetHeight(e.Graphics);
            y += lineHeight;

            lineHeight = font10.GetHeight(e.Graphics);
            y += lineHeight;    

            e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
            y += 3;
            e.Graphics.DrawString("SNO", font9, sBrush, xSlno, y);
            e.Graphics.DrawString("ITEM", font9, sBrush, xitemaname, y);
            e.Graphics.DrawString("QTY", font9, sBrush, xquantity, y);

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
            
            lineHeight = font10.GetHeight(e.Graphics);
            //+ ",      Table no: " + dtKOT.Rows[0]["TableName"].ToString(), font10, sBrush, 0, y)
           // e.Graphics.DrawString("Waiter: " + dtKOT.Rows[0]["Waiter"].ToString() + "                                T : " + dtKOT.Rows[0]["TableName"].ToString(), font10, sBrush, 0, y);
        }
    }
    catch (Exception ex)
    {
        File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
    }
}
        public void PrintKOTTake()
        {
            try
            {
                //PrintDocument doc = new PrintDocument();
                //doc.PrintPage += this.Doc_PrintPageKOTTake;
                ////doc.PrinterSettings.PrinterName = "VENDOR THERMAL PRINTER";
                //doc.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                PrintDocument doc1 = new PrintDocument();
                doc1.PrintPage += this.Doc_PrintPageKOTTake;
                doc1.PrinterSettings.PrinterName = File.ReadAllText("Printer.txt");
                doc1.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                //doc.OriginAtMargins = true;

                try
                {
                    doc1.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    // throw new ApplicationException("Printer Error");
                }
                //try
                //{
                //    doc.Print();
                //}
                //catch (Exception e)
                //{
                //    MessageBox.Show("Printer Error");
                //}
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }
        private void Doc_PrintPageKOTTake(object sender, PrintPageEventArgs e)
        
    {
            try
            {
                if (dtKOTTake.Rows.Count > 0)
                {
                    float x = e.MarginBounds.Left;
                    float y = 10;
                    int widtableh = e.PageBounds.Width;
                    int height = e.PageBounds.Height;
                    float lineHeight = font20.GetHeight(e.Graphics);
                    float xSlno = 0;
                    float xitemaname = 40;
                    float xquantity = 200;
                    //e.Graphics.DrawString("  Dinnies Family Restaurant", font15, new SolidBrush(Color.Black), 0, y);
                    //lineHeight = font15.GetHeight(e.Graphics);
                    //y += lineHeight;
                    //e.Graphics.DrawString("                    Family Restaurant", font10, new SolidBrush(Color.Black), 0, y);
                    //y += lineHeight;
                    e.Graphics.DrawString("                      PARCEL", font12, new SolidBrush(Color.Black), 0, y);

                    lineHeight = font12.GetHeight(e.Graphics);
                    y += lineHeight;
                    y += 3;
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));

                    y += 3;
                    if (counterId == 0)
                    {

                    }
                    else
                    {

                        DataTable dt = new DataTable();
                        dt = obj.EditCounter(counterId.ToString());
                        if (dt.Rows.Count > 0)
                        {
                            e.Graphics.DrawString("Counter : " + dt.Rows[0]["counter_name"].ToString().ToString(), font9, sBrush, 0, y);
                            //lineHeight = font9.GetHeight(e.Graphics);
                            //y += lineHeight;

                            //txt_countername.Text = dt.Rows[0]["counter_name"].ToString();
                            //txt_remarks.Text = dt.Rows[0]["remarks"].ToString();File.ReadAllText("user.txt")

                            //f = 1;
                        }
                        //e.Graphics.DrawString("Counter : " + obj.GetUsernameById(File.ReadAllText("user.txt")), font9, sBrush, 0, y);

                        lineHeight = font9.GetHeight(e.Graphics);
                        y += lineHeight;
                    }

                    e.Graphics.DrawString("KOT no: " + dtKOTTake.Rows[0]["kotno"].ToString() + ",   Date: " + DateTime.Now.ToString(), font10, sBrush, 0, y);
                    lineHeight = font10.GetHeight(e.Graphics);
                    y += lineHeight;

                    //e.Graphics.DrawString("Token: " + dtKOTTake.Rows[0]["Token"].ToString(), font10, sBrush, 0, y);
                    //lineHeight = font10.GetHeight(e.Graphics);
                    //y += lineHeight;

                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(290, Convert.ToInt32(y)));
                    y += 3;
                    e.Graphics.DrawString("Slno", font9, sBrush, xSlno, y);
                    e.Graphics.DrawString("Itemname", font9, sBrush, xitemaname, y);
                    e.Graphics.DrawString("      Quantity", font9, sBrush, xquantity, y);
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

                    
                    e.Graphics.DrawString("Department: " + dtKOTTake.Rows[0]["department"].ToString() , font10, sBrush, 0, y);
                    lineHeight = font10.GetHeight(e.Graphics);
                    y += lineHeight;


                }
            }

            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }
        string msg1;
        int status;

        DataTable dtable = new DataTable();
        public static int CustStatus;

        public int checkcreditperson()
        {
            int k = 0;
            if (cmbcustomer.SelectedValue != null)
                if (cmbcustomer.SelectedValue.ToString() != "")
                    if (cmbcustomer.SelectedIndex != 0)
                        k = 1;
            return k;


        }

        int CustId = 0; int billtype = 0;
        string CustName = "CASH";
        string customerst;
        private void checkbilltype()
        {
            if (rd_dinein.Checked == true)
            {
                int tablestatus = obj.TableACStat(cbox_table.SelectedValue.ToString());
                if (tablestatus == 1)
                {
                    billtype = 1;
                }
                else
                {
                    billtype = 2;
                }
            }
            else if (rd_takeaway.Checked == true)
            {
                billtype = 3;
            }
            else if (rd_counterBill.Checked == true)
            {
                billtype = 4;
            }
            else if (rb_homedelivery.Checked == true)
            {
                billtype = 5;
            }
        }
        int strs = 0;
        private int price()
        {
            for (int i = 0; i <dgv_KotDetails.Rows.Count; i++)
            {
                if (string.IsNullOrEmpty(dgv_KotDetails.Rows[0].Cells[4].Value as string))
                {
                    MessageBox.Show("Please Enter Price", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    strs = 1;
                }
            }
            return strs;
                
        }
        public string user;
        private void btn_printBill_Click(object sender, EventArgs e)
        {
            try
            {
                price();
                if (strs == 0)
                {
                    checkbilltype();
                    CheckTaxAmoutInBill();
                    //DataTable dti = new DataTable();
                    //dti = obj.UPDATETOUCHPAYMENTS(txtInvoiceNumber.Text.ToString(), Convert.ToDouble(txt_total1.Text == "" ? "0" : txt_total1.Text), 0);
                    Billing_Features bif = new Billing_Features();
                    //custmer ******************************************************
                    if (radiocash.Checked == true)
                    {
                        CustId = 0;
                        CustName = txtCustName.Text;
                    }
                    else if (radiocredit.Checked == true)
                    {
                        if (checkcreditperson() > 0)
                        {
                            if (cmbcustomer.SelectedValue != null)
                            {
                                CustId = Convert.ToInt32(cmbcustomer.SelectedValue.ToString());
                                CustName = cmbcustomer.Text;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Select Customer", "Message");
                            cmbcustomer.Focus();
                            return;
                        }
                    }
                    //**************************************************************
                    if (txtInvoiceNumber.Text != "")
                    {
                        //********************************  COUNTER BILL   ******************************************  // 
                        if (rd_counterBill.Checked == true)
                        {
                            cbox_ItemCode.Focus();
                            if (dgv_ItemDteails.Rows.Count > 0)
                            {
                                if (creditst == "0")
                                {
                                    customerst = "0";
                                    customerid = "0";
                                    paidamnt = txt_total1.Text;
                                }
                                else
                                {
                                    customerst = customerstatus;
                                }

                                if (radiocredit.Checked == true)
                                    paidamnt = "0";

                                string msg = obj.InsertInvoiceMaster(txtInvoiceNumber.Text, Convert.ToDateTime(globalvariable.StoreDate), CustName, txtMobile.Text,
                                    txtEmail.Text, 3, txt_total.Text, combliment, txt_discount.Text, paidamnt, customerst,
                                    Convert.ToString(CustId), user, txt_packing.Text, billtype, Convert.ToDateTime(globalvariable.StoreDate),
                                    0  ,txt_total1.Text,"0.00", "Billing",txttax.Text==""?"0.00":txttax.Text);
                                //Convert.ToDateTime(globalvariable.StoreDate)//dtpDate.Value
                                if (combliment == 1)
                                {
                                    obj.InsertComplimentary(msg, remarks);
                                }
                                if (msg == "0")
                                {
                                    MessageBox.Show("Sorry,This invoice number already exists.Please try other one", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtInvoiceNumber.Focus();
                                }
                                else
                                {
                                    for (int i = 0; i < dgv_ItemDteails.Rows.Count; i++)
                                    {
                                        obj.InsertInvoiceDetails(msg, dgv_ItemDteails[9, i].Value.ToString(), dgv_ItemDteails[3, i].Value.ToString(), dgv_ItemDteails[4, i].Value.ToString(), dgv_ItemDteails[5, i].Value.ToString(), "0", "0", "0", "0");
                                    }

                                    if (ch_preview.Checked == true)
                                    {
                                        FrmPrintBillCounter fp = new FrmPrintBillCounter(msg, counterId);
                                        fp.Show();
                                    }
                                    else
                                    {
                                        dtCounterBill = obj.PrintBillCounter(msg);
                                        PrintCounterBill();
                                        clear();
                                    }
                                    clear();
                                    // MessageBox.Show("Invoice successfully created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // cbox_ItemName.Focus();
                                    rd_dinein.Checked = true;
                                    cbox_table.Focus();
                                    SqlDataReader drr = obj.GetSettings();
                                    if (drr.Read())
                                    {
                                        if (drr[1].ToString() == "1")
                                        {

                                            SqlDataReader dr1r = obj.GetInvoiceNo();
                                            if (dr1r.Read())
                                            {
                                                txtInvoiceNumber.Text = dr1r[0].ToString();
                                                txtInvoiceNumber.Enabled = false;
                                                dr1r.Close();
                                            }
                                            else
                                            {
                                                txtInvoiceNumber.Enabled = true;
                                            }
                                        }
                                        drr.Close();
                                    }
                                    else
                                    {
                                        txtInvoiceNumber.Text = "";

                                    }

                                    //********************** CUST DETAILS ************************************
                                    if (radiocredit.Checked == true)
                                        obj.InsertCustAccountDetails(Convert.ToString(CustId), dtpDate.Value, txt_total1.Text, "2", "1", txtInvoiceNumber.Text, "Rs " + txt_total1.Text + " is Debited -" + txtInvoiceNumber.Text);
                                    //obj.InsertCustAccountDetails(CustId, dtpDate.Value, txtPayingAmt.Text, "1", "1", txtInvoiceNumber.Text, "Rs " + txtPayingAmt.Text + " is Credited -" + txtInvoiceNumber.Text);
                                    //(string CustId, DateTime Date, string Amount, string Status, string RecieptType, string RecieptNo, string msg)
                                    //************************************************************************************************************
                                    radiocash.Checked = true;
                                    txt_total.Text = "0.00";
                                    dgv_KotDetails.Rows.Clear();
                                    cbox_table.SelectedIndex = 0;
                                    cbox_waiter.SelectedIndex = 0;
                                    dgv_ItemDteails.Rows.Clear();
                                    f = 1;

                                    //default waiter
                                    if (cbox_waiter.Items.Count > 0)
                                        cbox_waiter.SelectedIndex = 1;
                                    else
                                        cbox_waiter.Text = "Waiter1";

                                    //*************************


                                }
                            }
                            else
                            {
                                MessageBox.Show("Please add item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        //*********************************************************************************************************************************************//


                        else
                        {

                            if (dgv_KotDetails.Rows.Count > 0)
                            {
                                if (dgv_ItemDteails.Rows.Count > 0)
                                {
                                    MessageBox.Show("Please print KOT for the selected items and then print bill.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    btn_kot.Focus();
                                }
                                else
                                {
                                    if (rd_dinein.Checked == true)
                                    {
                                        status = 1;
                                    }
                                    if (rd_takeaway.Checked == true)
                                    {
                                        status = 2;
                                    }
                                    string customerst;
                                    if (creditst == "0")
                                    {
                                        customerst = "0";
                                        customerid = "0";
                                        paidamnt = txt_total1.Text;
                                    }
                                    else
                                    {
                                        customerst = customerstatus;
                                    }

                                    if (radiocredit.Checked == true)
                                        paidamnt = "0";
                                    msg1 = obj.InsertInvoiceMaster(txtInvoiceNumber.Text, Convert.ToDateTime(globalvariable.StoreDate), CustName, txtMobile.Text, txtEmail.Text, status, txt_total.Text,
                                        combliment, txt_discount.Text, paidamnt, customerst, Convert.ToString(CustId), user, txt_packing.Text, billtype, Convert.ToDateTime(globalvariable.StoreDate),
                                       0, txt_total1.Text, "0.00", "Billing", txttax.Text == "" ? "0.00" : txttax.Text);
                                    if (combliment == 1)//Convert.ToDateTime(globalvariable.StoreDate)//dtpDate.Value
                                    {
                                        obj.InsertComplimentary(msg1, remarks);
                                    }
                                    if (msg1 == "0")
                                    {
                                        MessageBox.Show("Sorry,This invoice number already exists.Please try other one", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtInvoiceNumber.Focus();
                                    }
                                    else
                                    {
                                        for (int i = 0; i < dgv_KotDetails.Rows.Count; i++)
                                        {
                                            obj.InsertInvoiceDetails(msg1, dgv_KotDetails[8, i].Value.ToString(), dgv_KotDetails[3, i].Value.ToString(), dgv_KotDetails[4, i].Value.ToString(), dgv_KotDetails[5, i].Value.ToString(), dgv_KotDetails[9, i].Value.ToString(), dgv_KotDetails[10, i].Value.ToString(), dgv_KotDetails[11, i].Value.ToString(), dgv_KotDetails[12, i].Value.ToString());
                                        }
                                        // obj.UpdateIngradientQty(msg1);
                                        if (ch_preview.Checked == true)
                                        {
                                            if (rd_dinein.Checked == true)
                                            {
                                                FrmPrintBill billObj = new FrmPrintBill(msg1, counterId);
                                                billObj.Show();
                                            }
                                            if (rd_takeaway.Checked == true)
                                            {
                                                FrmPrintBillCounter billObj = new FrmPrintBillCounter(msg1, counterId);
                                                billObj.Show();
                                            }

                                            //FrmPrintBillCounter fp = new FrmPrintBillCounter(msg1);
                                            //fp.Show();
                                        }
                                        else
                                        {
                                            if (rd_dinein.Checked == true)
                                            {
                                                dtBill = obj.PrintBill(msg1);
                                                PrintBill();
                                                clear();
                                                dgv_KotDetails.Rows.Clear();
                                                cbox_table.Focus();
                                                rd_dinein.Checked = true;
                                                cbox_table.SelectedIndex = 0;
                                                cbox_waiter.SelectedIndex = 0;
                                                txt_total1.Text = "0.00";
                                                txt_discount.Text = "0";
                                                txt_total.Text = "0.00";
                                                return;
                                                //dgv_KotDetails.Rows.Clear();

                                                dgv_ItemDteails.Rows.Clear();
                                                //rd_dinein.Checked = true;
                                                cbox_table.Focus();
                                            }
                                            if (rd_takeaway.Checked == true)
                                            {
                                                dtCounterBill = obj.PrintBillCounter(msg1);
                                                PrintCounterBill();
                                                clear();
                                                return;
                                                rd_dinein.Checked = true;
                                                cbox_table.Focus();
                                            }
                                            if (rb_homedelivery.Checked == true)
                                            {
                                                dtCounterBill = obj.PrintBillCounter(msg1);
                                                printhomedelivery();
                                            }
                                        }
                                        //MessageBox.Show("Invoice successfully created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        SqlDataReader drr = obj.GetSettings();
                                        if (drr.Read())
                                        {
                                            if (drr[1].ToString() == "1")
                                            {
                                                SqlDataReader dr1r = obj.GetInvoiceNo();
                                                if (dr1r.Read())
                                                {
                                                    txtInvoiceNumber.Text = dr1r[0].ToString();
                                                    txtInvoiceNumber.Enabled = false;
                                                    dr1r.Close();
                                                }
                                                else
                                                {
                                                    txtInvoiceNumber.Enabled = true;
                                                }
                                            }
                                            drr.Close();
                                        }
                                        else
                                        {
                                            txtInvoiceNumber.Text = "";
                                        }

                                        //********************** CUST DETAILS ************************************
                                        if (radiocredit.Checked == true)
                                            obj.InsertCustAccountDetails(Convert.ToString(CustId), dtpDate.Value, txt_total1.Text, "2", "1", txtInvoiceNumber.Text, "Rs " + txt_total1.Text + " is Debited -" + txtInvoiceNumber.Text);
                                        //obj.InsertCustAccountDetails(CustId, dtpDate.Value, txtPayingAmt.Text, "1", "1", txtInvoiceNumber.Text, "Rs " + txtPayingAmt.Text + " is Credited -" + txtInvoiceNumber.Text);

                                        //************************************************************************************************************

                                        radiocash.Checked = true;
                                        txt_total1.Text = "0.00";
                                        txt_discount.Text = "0";
                                        txt_total.Text = "0.00";
                                        //cbox_Token.SelectedIndex = 0;
                                        dgv_KotDetails.Rows.Clear();
                                        cbox_table.SelectedIndex = 0;
                                        cbox_waiter.SelectedIndex = 0;
                                        dgv_ItemDteails.Rows.Clear();


                                    }
                                }


                            }
                            else
                            {
                                MessageBox.Show("Please print KOT then print bill.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cbox_ItemCode.Focus();
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter invoice no", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtInvoiceNumber.Focus();
                        return;
                    }
                    rd_dinein.Checked = true;
                    cbox_table.Focus();
                    ch_complimet.Checked = false;
                    //rd_counterBill.Checked = false;

                    rd_dinein.Checked = true;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
            //rd_counterBill.Checked = false;
            //rd_counterBill.Checked = true;
            rd_dinein.Checked = true;
        }
        
        public void PrintCounterBill()
        {
            try
            {
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += this.Doc_PrintPageCounterBill;
                //doc.PrinterSettings.PrinterName = "Canon MG2200 series Printer";
                doc.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                try
                {
                    dtprintfeatures = obj.getprinterfeatures();
                    int pcount = Convert.ToInt32(dtprintfeatures.Rows[0]["PrintCount"]);
                    for (int i = 0; i <pcount; i++)
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
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }
        public void printhomedelivery()
        {
            try
            {
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += this.Doc_PrintPageCounterBill;
                //doc.PrinterSettings.PrinterName = "Canon MG2200 series Printer";
                doc.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                try
                {
                    dtprintfeatures = obj.getprinterfeatures();
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
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }
        public static string CenterString(string stringToCenter, int totalLength)
        {
            Billing bc = new Billing();
            return stringToCenter.PadLeft(((totalLength - stringToCenter.Length) / 2)
                                + stringToCenter.Length)
                       .PadRight(totalLength);

        }
       

        
        private void Doc_PrintPageCounterBill(object sender, PrintPageEventArgs e)
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
                     if ((result5 != null)&&(result5!=""))
                     {
                         //e.Graphics.DrawString(       CenterString(dtprintfeatures.Rows[0]["address5"].ToString(),55), font10, new SolidBrush(Color.Black), 0, y);
                         e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address5"].ToString(), 25), font10, new SolidBrush(Color.Black), 0, y);
                         lineHeight = font10.GetHeight(e.Graphics);
                         y += lineHeight;
                     }
                     
                    e.Graphics.DrawString(     CenterString(dtprintfeatures.Rows[0]["BillName"].ToString(),46), font12, new SolidBrush(Color.Black), 0, y);
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

                    double total = 0, pckcharge=0;
                    lineHeight = font8.GetHeight(e.Graphics);
                    int slnum = 1;
                    int itemst=Convert.ToInt32(  dtprintfeatures.Rows[0]["Itemcode"].ToString());
                    int slnst=Convert.ToInt32(  dtprintfeatures.Rows[0]["Slno"].ToString());
                    for (int i = 0; i < dtCounterBill.Rows.Count; i++)
                    {
                        if(slnst==1)
                        {
                        e.Graphics.DrawString(slnum.ToString(), font8, sBrush, xSlno, y);
                          }
                        if (itemst == 1)
                        {
                            e.Graphics.DrawString(dtCounterBill.Rows[i]["itemcode"].ToString(), font8, sBrush, xamount, y);
                        }
                        //e.Graphics.DrawString(dtCounterBill.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);
                        e.Graphics.DrawString(dtCounterBill.Rows[i]["ItemName"].ToString().Length > 15 ? dtCounterBill.Rows[i]["ItemName"].ToString().Remove(15) : dtCounterBill.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);

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

                        double totaltxamt = ((((total) * 5)) / 100);
                        double totaltx = ((((total) * 5)) / 100) / 2;

                            //e.Graphics.DrawString("Total            : Rs." + (total+totaltxamt).ToString("F2"), font12, sBrush, 40, y);
                            //lineHeight = font12.GetHeight(e.Graphics);
                            //y += lineHeight;

                        //e.Graphics.DrawString("NetValue      : Rs." + (total - Convert.ToDouble(dtCounterBill.Rows[0]["discount"].ToString())).ToString("F2"), font12, sBrush, 40, y);
                        //e.Graphics.DrawString("NetValue      : Rs." + (total).ToString("F2"), font12, sBrush, 40, y);
                        e.Graphics.DrawString("NetValue          : Rs." + (total).ToString("F2"), font10, sBrush, 40, y);
                        lineHeight = font12.GetHeight(e.Graphics);
                        y += lineHeight;
                            

                            e.Graphics.DrawString("CGST 2.5%      : Rs." + (Convert.ToDouble(totaltx)).ToString("F2"), font10, sBrush, 40, y);
                            lineHeight = font12.GetHeight(e.Graphics);
                            y += lineHeight;

                            e.Graphics.DrawString("SGST 2.5%      : Rs." + (Convert.ToDouble(totaltx)).ToString("F2"), font10, sBrush, 40, y);
                            lineHeight = font12.GetHeight(e.Graphics);
                            y += lineHeight;


                            if (Convert.ToDouble(dtCounterBill.Rows[0]["discount"].ToString()) >0)
                        {
                            e.Graphics.DrawString("Discount      : Rs." + dtCounterBill.Rows[0]["discount"].ToString(), font12, sBrush, 40, y);
                            lineHeight = font10.GetHeight(e.Graphics);
                            y += lineHeight;
                        }
                            //e.Graphics.DrawString("NetValue : Rs." + (total - Convert.ToDouble(dtCounterBill.Rows[0]["discount"].ToString())).ToString("F2"), font15, sBrush, 40, y);
                            //lineHeight = font12.GetHeight(e.Graphics);
                            //y += lineHeight;


                            //------Round Off-------------------//
                            double AmtWithRoundOff = 0;
                            double AmtWithoutRoundOff = 0;
                            AmtWithoutRoundOff = total + totaltxamt - Convert.ToDouble(dtCounterBill.Rows[0]["discount"].ToString());
                            AmtWithRoundOff = CalcAmtRoundOff(Convert.ToDouble(AmtWithoutRoundOff));

                            //----------------------------------//

                            //e.Graphics.DrawString("Total        : Rs." + (total + totaltxamt).ToString("F2"), font15, sBrush, 40, y);
                            e.Graphics.DrawString("Total        : Rs." + (AmtWithRoundOff).ToString("F2"), font15, sBrush, 40, y);
                            lineHeight = font12.GetHeight(e.Graphics);
                            y += lineHeight;
                        }
                    
                    y += lineHeight;
                    y += lineHeight;
                    y += lineHeight;
                    if(dtprintfeatures.Rows[0]["greeting1"].ToString() != null)
                    {
                        if (dtprintfeatures.Rows[0]["GreetingFont"].ToString() == "Bold")
                        {
                            Fonts1 = myfontb1;
                        }
                        else
                        {
                            Fonts1 = myfonti1;
                        }
                    e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["greeting1"].ToString(),60), Fonts1, sBrush, 0, y);
                    lineHeight = font9.GetHeight(e.Graphics);
                    y += lineHeight;
                   
                    }
                   
                    if (dtprintfeatures.Rows[0]["greeting2"].ToString() != null)
                    {
                        e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["greeting2"].ToString(),50), font10, sBrush, 0, y);
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

        public void PrintBill()
        {
            try
            {
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += this.Doc_PrintBill;
                //doc.PrinterSettings.PrinterName = "VENDOR THERMAL PRINTER";
                doc.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

                try
                {
                    dtprintfeatures = obj.getprinterfeatures();
                    int pcount = Convert.ToInt32(dtprintfeatures.Rows[0]["PrintCount"]);
                    for (int i = 0; i < pcount; i++)
                    {


                        doc.Print();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Printer Error");
                    // throw new ApplicationException("Printer Error");
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }
        public Font Ft, Fonts1;
        private void Doc_PrintBill(object sender, PrintPageEventArgs e)
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
                    float xitemaname =18; 
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
                            e.Graphics.DrawImage( r, p);
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
                    if(dtprintfeatures.Rows[0]["address2"].ToString()!=null)
                    {
                        //e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address2"].ToString(),52), font10, new SolidBrush(Color.Black), 0, y);
                        e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address2"].ToString(), 20), font9, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font10.GetHeight(e.Graphics);
                    y += lineHeight;
                      }
                    if (dtprintfeatures.Rows[0]["address3"].ToString()!=null)
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
                   if(dtprintfeatures.Rows[0]["address5"].ToString()!=null)
                   {
                       //e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address5"].ToString(),55), font10, new SolidBrush(Color.Black), 0, y);
                       e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["address5"].ToString(), 25), font10, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font10.GetHeight(e.Graphics);
                    //y += lineHeight;
                   }
                   lineHeight = font10.GetHeight(e.Graphics);
                   y += lineHeight;

                   if(dtprintfeatures.Rows[0]["BillName"].ToString()!=null)
                   {
                       e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["BillName"].ToString(),46), font12, new SolidBrush(Color.Black), 0, y);
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

                    double total = 0, pckcharge=0;
                    lineHeight = font8.GetHeight(e.Graphics);
                    int slnum = 1;
                    int itemst = Convert.ToInt32(dtprintfeatures.Rows[0]["Itemcode"].ToString());
                    int slnst = Convert.ToInt32(dtprintfeatures.Rows[0]["Slno"].ToString());
                      
                    for (int i = 0; i < dtBill.Rows.Count; i++)
                    {
                         string name  = dtBill.Rows[i]["ItemName"].ToString();
                        if (slnst == 1)
                        {
                            e.Graphics.DrawString(slnum.ToString(), font8, sBrush, xSlno, y);
                           
                        }
                        if (itemst == 1)
                        {
                            e.Graphics.DrawString(dtCounterBill.Rows[i]["itemcode"].ToString(), font8, sBrush, xamount, y);
                           
                        }
                        //e.Graphics.DrawString(dtBill.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);
                        e.Graphics.DrawString(dtBill.Rows[i]["ItemName"].ToString().Length > 15 ? dtBill.Rows[i]["ItemName"].ToString().Remove(15) : dtBill.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);
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
                            if(Convert.ToDouble(dtBill.Rows[0]["PckCharge"])>0)
                                 {
                        e.Graphics.DrawString("Packing Charge      : Rs." + pckcharge.ToString("F2"), font10, sBrush, 40, y);
                        lineHeight = font15.GetHeight(e.Graphics);
                        y += lineHeight;
                                }


                            double totaltxamt = ((((total) * 5)) / 100);
                            double totaltx = ((((total) * 5)) / 100) / 2;

                            //e.Graphics.DrawString("Total            : Rs." +( total+totaltxamt).ToString("F2"), font12, sBrush, 40, y);
                            //lineHeight = font12.GetHeight(e.Graphics);
                            //y += lineHeight;

                            //e.Graphics.DrawString("NetValue      : Rs." + (total  - Convert.ToDouble(dtBill.Rows[0]["discount"].ToString())).ToString("F2"), font12, sBrush, 40, y);
                            //e.Graphics.DrawString("NetValue      : Rs." + (total ).ToString("F2"), font12, sBrush, 40, y);

                            e.Graphics.DrawString("NetValue          : Rs." + (total).ToString("F2"), font10, sBrush, 40, y);
                            lineHeight = font12.GetHeight(e.Graphics);
                            y += lineHeight;

                            e.Graphics.DrawString("CGST 2.5%      : Rs." + (Convert.ToDouble(totaltx)).ToString("F2"), font10, sBrush, 40, y);
                            lineHeight = font12.GetHeight(e.Graphics);
                            y += lineHeight;

                            e.Graphics.DrawString("SGST 2.5%      : Rs." + (Convert.ToDouble(totaltx)).ToString("F2"), font10, sBrush, 40, y);
                            lineHeight = font12.GetHeight(e.Graphics);
                            y += lineHeight;


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
                            AmtWithoutRoundOff = total + totaltxamt - Convert.ToDouble(dtBill.Rows[0]["discount"].ToString());
                            AmtWithRoundOff = CalcAmtRoundOff(Convert.ToDouble(AmtWithoutRoundOff));

                            //----------------------------------//


                            //e.Graphics.DrawString("Total        : Rs." + (total + totaltxamt).ToString("F2"), font15, sBrush, 40, y);
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
                         
                        e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["greeting1"].ToString(),60), Fonts1, sBrush, 0, y);
                        lineHeight = font9.GetHeight(e.Graphics);
                        y += lineHeight;
                     
                    }
                   
                    if (dtprintfeatures.Rows[0]["greeting2"].ToString() != null)
                    {
                        e.Graphics.DrawString(CenterString(dtprintfeatures.Rows[0]["greeting2"].ToString(),50), Fonts1, sBrush, 0, y);
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
        public void clear()
        {

            try
            {
                f = 0;
                DataSet ds = new DataSet();
                ds = obj.GetTable();
                cbox_table.DataSource = ds.Tables[0];
                cbox_table.DisplayMember = "TableName";
                cbox_table.ValueMember = "Id";

                DataRow dr = ds.Tables[0].NewRow();
                dr["TableName"] = "--Select One--";
                dr["Id"] = "0";
                ds.Tables[0].Rows.InsertAt(dr, 0);
                cbox_table.SelectedIndex = 0;



                DataSet ds1 = new DataSet();
                ds1 = obj.GetItemCode();
                cbox_ItemName.DataSource = ds1.Tables[0];
                cbox_ItemName.DisplayMember = "ItemName";
                cbox_ItemName.ValueMember = "Id";
                cbox_ItemCode.DataSource = ds1.Tables[0];
                cbox_ItemCode.DisplayMember = "ItemCode";
                cbox_ItemCode.ValueMember = "Id";

                DataRow dr1 = ds1.Tables[0].NewRow();
                dr1["ItemName"] = "--Select One--";
                dr1["ItemCode"] = "--Select One--";
                dr1["Id"] = "0";
                ds1.Tables[0].Rows.InsertAt(dr1, 0);
                cbox_ItemCode.SelectedIndex = 0;
                dgv_ItemDteails.Rows.Clear();
                dgv_KotDetails.Rows.Clear();
                cbox_table.Focus();

                cbox_ItemName.SelectedIndex = 0;
                cbox_table.SelectedIndex = 0;
                cbox_waiter.SelectedIndex = 0;
                txt_Quantity.Text = "0";
                txt_Rate.Text = "0";
                txt_total.Text = "0";
                txt_discount.Text = "0.00";
                txtDiscountPercent.Text = "0";
                txt_totalAmount.Text = "0.00";
                txtCustName.Text = "";
                txtEmail.Text = "";
                txt_packing.Text = "0.00";
                dgv_KotDetails.Rows.Clear();
                txtdepartment.Text = "";
                SqlDataReader drr = obj.GetSettings();
                if (drr.Read())
                {
                    if (drr[1].ToString() == "1")
                    {

                        SqlDataReader dr1r = obj.GetInvoiceNo();
                        if (dr1r.Read())
                        {
                            txtInvoiceNumber.Text = dr1r[0].ToString();
                            txtInvoiceNumber.Enabled = false;
                            dr1r.Close();
                        }
                        else
                        {
                            txtInvoiceNumber.Enabled = true;
                        }
                    }
                    drr.Close();
                }
                else
                {
                    txtInvoiceNumber.Text = "";
                }
                txtMobile.Text = "";

               // dgv_KotDetails.Rows.Clear();
                //if (cbox_waiter.Items.Count > 0)
                //    cbox_waiter.SelectedIndex = 0;
                //else
                //    cbox_waiter.Items.Add("Waiter1");
                //cbox_waiter.SelectedIndex = 0;
                DataSet ds6 = new DataSet();
                ds6 = obj.GetWaiter();
                cbox_waiter.DataSource = ds6.Tables[0];
                cbox_waiter.DisplayMember = "Name";
                cbox_waiter.ValueMember = "Id";
                cbox_waiter.SelectedIndex = 0;

                DataRow dr6 = ds6.Tables[0].NewRow();
                dr6["Name"] = "--Select One--";
                dr6["Id"] = "0";
                ds6.Tables[0].Rows.InsertAt(dr6, 0);

                cbox_Token.SelectedIndex = -1;

                groupBox7.Enabled = true;
                grp_token.Enabled = true;
                btnAdd.Enabled = true;
                btn_creditbill.Enabled = false;
                txtCustName.Text = string.Empty;
                txtMobile.Text = string.Empty;
                txtEmail.Text = string.Empty;
                
                txt_totalAmount.Text = "0.00";
                txt_total1.Text = string.Empty;
                // btn_printBill.Enabled = true;
                ch_complimet.Checked = false;

                radiocash.Checked = true;
                radiocredit.Checked = false;

                txttax.Text = "0";
                //default waiter
                //if (cbox_waiter.Items.Count > 0)
                //    cbox_waiter.SelectedIndex = 1;
                //else
                //    cbox_waiter.Text = "Waiter1";

                //*************************


                

                f = 1;
                radiocash.Checked = false;
                radiocash.Checked = true;
                if (rd_counterBill.Checked == true)
                {
                    rd_counterBill.Checked = false;
                    rd_counterBill.Checked = true;
                }
                else if (rd_dinein.Checked == true)
                {
                    rd_dinein.Checked = false;
                    rd_dinein.Checked = true;
                }
                else if (rd_takeaway.Checked == true)
                {
                    rd_takeaway.Checked = false;
                    rd_takeaway.Checked = true;
                }

                rd_dinein.Checked = true;
                cbox_waiter.SelectedIndex = 0;

                if (cbox_waiter.Items.Count > 0)
                    cbox_waiter.SelectedIndex = 1;
                else
                    cbox_waiter.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();


        }
        int NumStat = 0;
        private void dgv_ItemDteails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                NumStat = 0;
                int i = e.RowIndex;
                decimal newInteger;
                qty = this.dgv_ItemDteails[3, i].Value.ToString();          
                dgvcellst = "1";             
                if ((!decimal.TryParse(dgv_ItemDteails[3, i].FormattedValue.ToString(), out newInteger) || newInteger < 0) || (!decimal.TryParse(dgv_ItemDteails[4, i].FormattedValue.ToString(), out newInteger) || newInteger < 0))
                  //  qty = dgv_ItemDteails[3, i].FormattedValue.ToString();         
                    NumStat = 1;
                if (NumStat == 1)
                {
                    MessageBox.Show("Please Enter Number Value To Corresponding Fields.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    //double total = 0;
                    //dgv_ItemDteails[5, i].Value = Convert.ToString(Convert.ToDouble(dgv_ItemDteails[4, i].Value) * (Convert.ToDouble(dgv_ItemDteails[3, i].Value)));
                    //for (int r = 0; r < dgv_ItemDteails.Rows.Count; r++)
                    //{
                    //    total += (Convert.ToDouble(dgv_ItemDteails[5, r].Value));
                    //}
                    ////  Convert.ToString(decimal.Round(Convert.ToDecimal(txt_Quantity.Text), 2, MidpointRounding.AwayFromZero));
                    //txt_total.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(total), 2, MidpointRounding.AwayFromZero));
                    //txt_total.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));


                    decimal Tot = 0;
                    double Tot1 = 0;
                    //for (int s = 0; s < dgv_ItemDteails.Rows.Count; s++)
                    //{
                    //    Tot += (decimal.Round(Convert.ToDecimal((Convert.ToDouble(dgv_ItemDteails[5, s].Value))), 2, MidpointRounding.AwayFromZero));
                    //    txt_total.Text = Tot.ToString();
                    //    //txt_total1.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));
                    //    Tot1 += Convert.ToDouble(string.Format("{0:0.00}", Convert.ToDouble(dgv_ItemDteails["Column10", s].Value) * Convert.ToDouble(dgv_ItemDteails["Column4", s].Value)));
                    //    txt_total1.Text = Tot1.ToString();
                    //}

                    ////------------GST Tax Calculation 5% -------------------//
                    //txt_total.Text = Convert.ToString(Convert.ToString(decimal.Round(Convert.ToDecimal(((Convert.ToDouble(txt_total1.Text) * 5) / 100) + Convert.ToDouble(txt_total1.Text)), 2, MidpointRounding.AwayFromZero)));
                    //txttax.Text = Convert.ToString(Convert.ToDecimal(txt_total.Text) - Convert.ToDecimal(txt_total1.Text));
                    ////------------------------------------------------------//
                   

                    if (dgv_KotDetails.Rows.Count <= 0)
                    {
                        FindGstWhenNoKotGrid();
                    }
                    else
                    {
                        FindGstWhenValueInKotGrid();
                    }

                    //------Round Off-------------------//
                    double AmtWithRoundOff = 0;
                    AmtWithRoundOff = CalcAmtRoundOff(Convert.ToDouble(txt_total.Text));
                    txt_total.Text = AmtWithRoundOff.ToString();
                    //----------------------------------//

                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void dgv_KotDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            double total = 0;
            try
            {
                dgv_KotDetails[5, e.RowIndex].Value = (Convert.ToDouble(dgv_KotDetails[3, e.RowIndex].Value) * Convert.ToDouble(dgv_KotDetails[4, e.RowIndex].Value)).ToString("F2");
                for (int r = 0; r < dgv_KotDetails.Rows.Count; r++)
                {
                    total += (Convert.ToDouble(dgv_KotDetails[5, r].Value));
                }

                txt_total.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(total), 2, MidpointRounding.AwayFromZero));
                txt_total.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));


            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void dgv_ItemDteails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_KotDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double total = 0;
                for (int r = 0; r < dgv_KotDetails.Rows.Count; r++)
                {
                    total += (Convert.ToDouble(dgv_KotDetails[5, r].Value));
                }
                txt_total.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(total), 2, MidpointRounding.AwayFromZero));
                txt_total1.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));
                txt_total.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));

            }

            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void rd_dinein_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_dinein.Checked == true)
            {
                cbox_Token.Enabled = false;
                cbox_Token.SelectedIndex = -1;
                //cbox_Token.Text = "";
                rd_takeaway.Visible = true;
                cbox_table.Enabled = true;
                cbox_waiter.Enabled = true;
                btn_kot.Enabled = true;
                dgv_ItemDteails.Rows.Clear();
                dgv_KotDetails.Rows.Clear();
                cbox_Token.Text = "";
                cbox_table.SelectedIndex = 0;
                cbox_waiter.SelectedIndex = 0;
                txt_total.Text = "0";
                txt_total1.Text = "0.00";
                txttax.Text = "0";
                txt_discount.Text = "0";
                cbox_table.Focus();

                SetDefaultWaiter();
            }
        }

        private void rd_takeaway_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_takeaway.Checked == true)
            {
                custst = "2";
                cbox_Token.Enabled = true;
                //cbox_Token.SelectedIndex = 0;
                cbox_table.Enabled = false;
                cbox_waiter.Enabled = false;
                
                btn_kot.Enabled = true;
                dgv_ItemDteails.Rows.Clear();
                dgv_KotDetails.Rows.Clear();
                txt_total1.Text = "0.00";
                txt_discount.Text = "0";
                cbox_Token.Text = "";
                txt_total.Text = "0";
                txttax.Text = "0";
                cbox_table.Focus();
                cbox_Token.Focus();
                cbox_table.SelectedIndex = 0;
                cbox_waiter.SelectedIndex = 0;

                SetDefaultWaiter();
            }
        }

        private void cbox_Token_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ItemDetailClear();
                dgv_KotDetails.Rows.Clear();
                if (cbox_Token.Text != string.Empty)
                {

                    checkradiostatus();
                    cbox_waiter.Enabled = false;
                    DataTable dt = new DataTable();
                    dt = obj.GetKotDetailsByToken(cbox_Token.Text,tokenst);
                    if (dt.Rows.Count > 0)
                    {
                        for (int d = 0; d < dt.Rows.Count; d++)
                        {
                            dgv_KotDetails.Rows.Add();
                            dgv_KotDetails[0, d].Value = d + 1;
                            int code = Convert.ToInt32(dt.Rows[d]["ItemId"].ToString());
                            dgv_KotDetails[1, d].Value = dt.Rows[d]["ItemCode"].ToString();
                            dgv_KotDetails[2, d].Value = dt.Rows[d]["ItemName"].ToString();
                            dgv_KotDetails[3, d].Value = Convert.ToDouble(dt.Rows[d]["Quantity"]).ToString("F2");
                            dgv_KotDetails[4, d].Value = Convert.ToDouble(dt.Rows[d]["Rate"]).ToString("F2");
                            dgv_KotDetails[5, d].Value = Convert.ToDouble(dt.Rows[d]["Amount"]).ToString("F2");
                            dgv_KotDetails[8, d].Value = dt.Rows[d]["ItemId"].ToString();
                            dgv_KotDetails[9, d].Value = dt.Rows[d]["Id"].ToString();

                            if (dt.Rows[d]["CustomerStatus"].ToString() == "1")
                            {
                                rd_dinein.Checked = true;
                            }
                            if (dt.Rows[d]["CustomerStatus"].ToString() == "2")
                            {
                                rd_takeaway.Checked = true;
                            }
                            DataTable dt1 = new DataTable();
                            dt1 = obj.GetSt(code);
                            if (Convert.ToInt32(dt1.Rows[0]["ChangeSellpricestatus"].ToString()) == 1)
                            {
                                this.dgv_KotDetails.Rows[d].Cells["dataGridViewTextBoxColumn5"].ReadOnly = false;
                            }
                            else
                                this.dgv_KotDetails.Rows[d].Cells["dataGridViewTextBoxColumn5"].ReadOnly = true;



                            dgv_KotDetails[10, d].Value = dt.Rows[d]["TableId"].ToString();
                            dgv_KotDetails[11, d].Value = dt.Rows[d]["WaiterId"].ToString();
                            dgv_KotDetails[12, d].Value = dt.Rows[d]["Token"].ToString();
                            dgv_KotDetails[14, d].Value = dt.Rows[d]["DetaileID"].ToString();
                        }
                    }

                    double total = 0;
                    for (int r = 0; r < dgv_KotDetails.Rows.Count; r++)
                    {
                        total += (Convert.ToDouble(dgv_KotDetails[5, r].Value));
                    }
                    txt_total.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(total), 2, MidpointRounding.AwayFromZero));
                    txt_total1.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));
                    txt_total.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));

                    //------------GST Tax Calculation 5% -------------------//
                    txt_total.Text = Convert.ToString(Convert.ToString(decimal.Round(Convert.ToDecimal(((Convert.ToDouble(txt_total1.Text) * 5) / 100) + Convert.ToDouble(txt_total1.Text)), 2, MidpointRounding.AwayFromZero)));
                    txttax.Text = Convert.ToString(Convert.ToDecimal(txt_total.Text) - Convert.ToDecimal(txt_total1.Text));
                    //------------------------------------------------------//


                    //------Round Off-------------------//
                    double AmtWithRoundOff = 0;
                    AmtWithRoundOff = CalcAmtRoundOff(Convert.ToDouble(txt_total.Text));
                    txt_total.Text = AmtWithRoundOff.ToString();
                    //----------------------------------//

                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }
        int k = 0;
        private void btnAdd_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnReset_Paint(object sender, PaintEventArgs e)
        
         {

        }


        public static GraphicsPath GetRoundedRect(RectangleF r, float radiusX, float radiusY)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.StartFigure();
            r = new RectangleF(r.Left, r.Top, r.Width, r.Height);
            if (radiusX <= 0.0F || radiusY <= 0.0F)
            {
                gp.AddRectangle(r);
            }
            else
            {
                try
                {
                    //arcs work with diameters (radius * 2)
                    PointF d = new PointF(Math.Min(radiusX * 2, r.Width), Math.Min(radiusY * 2, r.Height));
                    gp.AddArc(r.X, r.Y, d.X, d.Y, 180, 90);
                    gp.AddArc(r.Right - d.X, r.Y, d.X - 1, d.Y, 270, 90);
                    gp.AddArc(r.Right - d.X, (r.Bottom) - d.Y - 1, d.X - 1, d.Y, 0, 90);
                    gp.AddArc(r.X, (r.Bottom) - d.Y - 1, d.X - 1, d.Y, 90, 90);
                }
                catch (Exception w)
                {

                }
            }
            gp.CloseFigure();
            return gp;
        }
        public static Color ColorFromHex(string hex)
        {
            if (hex.StartsWith("#"))
                hex = hex.Substring(1);

            if (hex.Length != 6) throw new Exception("Color not valid");

            return Color.FromArgb(
                int.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber),
                int.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber),
                int.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber));
        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            k = 1;
            btnReset.Paint += new System.Windows.Forms.PaintEventHandler(this.btnReset_Paint);
            //cbox_waiter.Focus();
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            k = 0;
            btnReset.Paint += new System.Windows.Forms.PaintEventHandler(this.btnReset_Paint);
        }

        private void rd_counterBill_CheckedChanged(object sender, EventArgs e)
        {
            if (c != 1)
            {
                if (rd_counterBill.Checked == true)
                {
                    // cbox_Token.SelectedIndex = 0;
                    cbox_Token.Enabled = false;
                    cbox_table.Enabled = false;
                    cbox_waiter.Enabled = false;
                    cbox_ItemCode.Enabled = true;
                    cbox_Token.SelectedIndex = -1;
                    btn_kot.Enabled = false;
                    dgv_ItemDteails.Rows.Clear();
                    dgv_KotDetails.Rows.Clear();

                    
                    //cbox_ItemCode.SelectedIndex = 0;
                    txt_total.Text = "0";
                    txt_total1.Text = "0.00";
                    txt_discount.Text = "0";
                    txttax.Text = "0";
                    //txt_total1.Text = Convert.ToString(Convert.ToString(decimal.Round(Convert.ToDecimal(((Convert.ToDouble(txt_total.Text) * 5) / 100) + Convert.ToDouble(txt_total.Text)), 2, MidpointRounding.AwayFromZero)));
                    //txttax.Text = Convert.ToString(Convert.ToDecimal(txt_total1.Text) - Convert.ToDecimal(txt_total.Text));
                    // cbox_table.Focus();

                    cbox_ItemCode.Focus();
                    cbox_Token.Text = "";
                    cbox_table.SelectedIndex = 0;
                    cbox_waiter.SelectedIndex = 0;

                    

                }

            }
        }

        private void cbox_ItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (Convert.ToDouble(cbox_ItemName.SelectedValue) == 0)
                    cbox_ItemName.Focus();
                else
                    txt_Quantity.Focus();
            }
            if (e.KeyData == Keys.F1)
            {

                ItemSearch s = new ItemSearch();
                s.ShowDialog();
                if (s.dgr == DialogResult.OK)
                {
                    cbox_ItemName.SelectedValue = s.id;
                    txt_Quantity.Focus();
                }
            }
            if (e.KeyData == Keys.F3)
            {
                PendingOT_S bs = new PendingOT_S();
                bs.ShowDialog();



            }
        }

        private void txt_Quantity_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                if (txt_Quantity.Text == "0")
                    txt_Quantity.Focus();
                else
                    
            addst = "0";
            string st = check();
            try
            {
                if (st == "1")
                {
                    for (int i = 0; i < dgv_ItemDteails.Rows.Count; i++)
                    {
                        if (cbox_ItemName.SelectedValue.ToString() == dgv_ItemDteails[9, i].Value.ToString())
                        {
                            dgv_ItemDteails[3, i].Value = Convert.ToDouble(dgv_ItemDteails[3, i].Value) + Convert.ToDouble(txt_Quantity.Text);
                            dgv_ItemDteails[5, i].Value = Convert.ToString(Convert.ToDouble(dgv_ItemDteails[4, i].Value) * (Convert.ToDouble(dgv_ItemDteails[3, i].Value)));
                            addst = "1";
                        }
                    }
                    if (rd_counterBill.Checked == true)
                    {
                        if (addst == "0")
                        {
                            dgv_ItemDteails.Rows.Add();
                            i = dgv_ItemDteails.Rows.Count - 1;
                            dgv_ItemDteails[0, i].Value = i + 1;
                            dgv_ItemDteails[1, i].Value = cbox_ItemCode.Text;
                            dgv_ItemDteails[2, i].Value = cbox_ItemName.Text;
                            dgv_ItemDteails[3, i].Value = Convert.ToDouble(txt_Quantity.Text).ToString("F2");
                            dgv_ItemDteails[4, i].Value = Convert.ToDouble(txt_Rate.Text).ToString("F2");
                            dgv_ItemDteails[5, i].Value = Convert.ToDouble(txt_totalAmount.Text).ToString("F2");
                            dgv_ItemDteails[6, i].Value = cbox_table.Text;
                            dgv_ItemDteails[7, i].Value = cbox_waiter.Text;
                            dgv_ItemDteails[9, i].Value = cbox_ItemName.SelectedValue.ToString();
                            dgv_ItemDteails[10, i].Value = "0";
                            dgv_ItemDteails[11, i].Value = "0";
                            dgv_ItemDteails[12, i].Value = "0";
                            dgv_ItemDteails[13, i].Value = txtdepartment.Text; 
                        }
                    }
                    else
                    {
                        if (rd_takeaway.Checked == true)
                        {
                            if (addst == "0")
                            {
                                dgv_ItemDteails.Rows.Add();
                                i = dgv_ItemDteails.Rows.Count - 1;
                                dgv_ItemDteails[0, i].Value = i + 1;
                                dgv_ItemDteails[1, i].Value = cbox_ItemCode.Text;
                                dgv_ItemDteails[2, i].Value = cbox_ItemName.Text;
                                dgv_ItemDteails[3, i].Value = Convert.ToDouble(txt_Quantity.Text).ToString("F2");
                                dgv_ItemDteails[4, i].Value = Convert.ToDouble(txt_Rate.Text).ToString("F2");
                                dgv_ItemDteails[5, i].Value = Convert.ToDouble(txt_totalAmount.Text).ToString("F2");
                                // dgv_ItemDteails[6, i].Value = cbox_table.Text;
                                //dgv_ItemDteails[7, i].Value = cbox_waiter.Text;
                                dgv_ItemDteails[9, i].Value = cbox_ItemName.SelectedValue.ToString();
                                dgv_ItemDteails[10, i].Value = "0";
                                dgv_ItemDteails[11, i].Value = "0";
                                dgv_ItemDteails[12, i].Value = cbox_Token.Text;
                                dgv_ItemDteails[13, i].Value = txtdepartment.Text;
                            }
                        }
                        else
                        {
                            if (addst == "0")
                            {
                                dgv_ItemDteails.Rows.Add();
                                i = dgv_ItemDteails.Rows.Count - 1;
                                dgv_ItemDteails[0, i].Value = i + 1;
                                dgv_ItemDteails[1, i].Value = cbox_ItemCode.Text;
                                dgv_ItemDteails[2, i].Value = cbox_ItemName.Text;
                                dgv_ItemDteails[3, i].Value = Convert.ToDouble(txt_Quantity.Text).ToString("F2");
                                dgv_ItemDteails[4, i].Value = Convert.ToDouble(txt_Rate.Text).ToString("F2");
                                dgv_ItemDteails[5, i].Value = Convert.ToDouble(txt_totalAmount.Text).ToString("F2");
                                dgv_ItemDteails[6, i].Value = cbox_table.Text;
                                dgv_ItemDteails[7, i].Value = cbox_waiter.Text.ToString();
                                dgv_ItemDteails[9, i].Value = cbox_ItemName.SelectedValue.ToString();
                                dgv_ItemDteails[10, i].Value = cbox_waiter.SelectedValue.ToString();
                                dgv_ItemDteails[11, i].Value = cbox_table.SelectedValue.ToString();
                                dgv_ItemDteails[12, i].Value = "0";
                                dgv_ItemDteails[13, i].Value = txtdepartment.Text;

                            }
                        }
                    }
                    dgv_ItemDteails.FirstDisplayedScrollingRowIndex = (dgv_ItemDteails.Rows.Count) - 1;
                    txt_total.Text = "0";
                    //for (int s = 0; s < dgv_ItemDteails.Rows.Count; s++)
                    //{
                    //    txt_total.Text = Convert.ToString(Convert.ToString(decimal.Round(Convert.ToDecimal((Convert.ToDouble(txt_total.Text) + Convert.ToDouble(dgv_ItemDteails[5, s].Value))), 2, MidpointRounding.AwayFromZero)));
                    //    txt_total1.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));
                    //}

                    //decimal Tot = 0;
                    //double Tot1 = 0;
                    //for (int s = 0; s < dgv_ItemDteails.Rows.Count; s++)
                    //{
                    //    Tot += (decimal.Round(Convert.ToDecimal((Convert.ToDouble(dgv_ItemDteails[5, s].Value))), 2, MidpointRounding.AwayFromZero));
                    //    txt_total.Text = Tot.ToString();
                    //    //txt_total1.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));
                    //    Tot1 += Convert.ToDouble(string.Format("{0:0.00}", Convert.ToDouble(dgv_ItemDteails["Column10", s].Value) * Convert.ToDouble(dgv_ItemDteails["Column4", s].Value)));
                    //    txt_total1.Text = Tot1.ToString();
                    //}
                    ////------------GST Tax Calculation 5% -------------------//
                    //txt_total.Text = Convert.ToString(Convert.ToString(decimal.Round(Convert.ToDecimal(((Convert.ToDouble(txt_total1.Text) * 5) / 100) + Convert.ToDouble(txt_total1.Text)), 2, MidpointRounding.AwayFromZero)));
                    //txttax.Text = Convert.ToString(Convert.ToDecimal(txt_total.Text) - Convert.ToDecimal(txt_total1.Text));
                    ////------------------------------------------------------//


                   
                    if (dgv_KotDetails.Rows.Count <= 0)
                    {
                        FindGstWhenNoKotGrid();
                    }
                    else
                    {
                        FindGstWhenValueInKotGrid();
                    }

                    //------Round Off-------------------//
                    double AmtWithRoundOff = 0;
                    AmtWithRoundOff = CalcAmtRoundOff(Convert.ToDouble(txt_total.Text));
                    txt_total.Text = AmtWithRoundOff.ToString();
                    //----------------------------------//


                    cbox_waiter.Enabled = false;
                    cbox_ItemCode.SelectedIndex = 0;
                    txt_Quantity.Text = "";
                    txt_Rate.Text = "";
                    lbUnit.Text = "";
                    txt_ProductStock.Text = "";
                    cbox_ItemCode.Focus();
                    //cbox_waiter.Focus();
                    h = 1;
                    ////default waiter
                    //if (cbox_waiter.Items.Count > 0)
                    //    cbox_waiter.SelectedIndex = 1;
                    //else
                    //    cbox_waiter.Text = "Waiter1";

                    ////*************************
                    cbox_ItemCode.Focus();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

                  

            }
        

        private void txt_Rate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnAdd.Focus();
            }

        }

        private void btnAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                addst = "0";
                string st = check();
                try
                {
                    if (st == "1")
                    {
                        for (int i = 0; i < dgv_ItemDteails.Rows.Count; i++)
                        {
                            if (cbox_ItemName.SelectedValue.ToString() == dgv_ItemDteails[9, i].Value.ToString())
                            {
                                dgv_ItemDteails[3, i].Value = Convert.ToDouble(dgv_ItemDteails[3, i].Value) + Convert.ToDouble(txt_Quantity.Text);
                                dgv_ItemDteails[5, i].Value = Convert.ToString(Convert.ToDouble(dgv_ItemDteails[4, i].Value) * (Convert.ToDouble(dgv_ItemDteails[3, i].Value)));
                                addst = "1";
                            }
                        }
                        if (rd_counterBill.Checked == true)
                        {
                            if (addst == "0")
                            {
                                dgv_ItemDteails.Rows.Add();
                                i = dgv_ItemDteails.Rows.Count - 1;
                                dgv_ItemDteails[0, i].Value = i + 1;
                                dgv_ItemDteails[1, i].Value = cbox_ItemCode.Text;
                                dgv_ItemDteails[2, i].Value = cbox_ItemName.Text;
                                dgv_ItemDteails[3, i].Value = Convert.ToDouble(txt_Quantity.Text).ToString("F2");
                                dgv_ItemDteails[4, i].Value = Convert.ToDouble(txt_Rate.Text).ToString("F2");
                                dgv_ItemDteails[5, i].Value = Convert.ToDouble(txt_totalAmount.Text).ToString("F2");
                                dgv_ItemDteails[6, i].Value = cbox_table.Text;
                                dgv_ItemDteails[7, i].Value = cbox_waiter.Text;
                                dgv_ItemDteails[9, i].Value = cbox_ItemName.SelectedValue.ToString();
                                dgv_ItemDteails[10, i].Value = "0";
                                dgv_ItemDteails[11, i].Value = "0";
                                dgv_ItemDteails[12, i].Value = "0";
                                dgv_ItemDteails[13, i].Value = txtdepartment.Text;
                            }
                        }
                        else
                        {
                            if (rd_takeaway.Checked == true)
                            {
                                if (addst == "0")
                                {
                                    dgv_ItemDteails.Rows.Add();
                                    i = dgv_ItemDteails.Rows.Count - 1;
                                    dgv_ItemDteails[0, i].Value = i + 1;
                                    dgv_ItemDteails[1, i].Value = cbox_ItemCode.Text;
                                    dgv_ItemDteails[2, i].Value = cbox_ItemName.Text;
                                    dgv_ItemDteails[3, i].Value = Convert.ToDouble(txt_Quantity.Text).ToString("F2");
                                    dgv_ItemDteails[4, i].Value = Convert.ToDouble(txt_Rate.Text).ToString("F2");
                                    dgv_ItemDteails[5, i].Value = Convert.ToDouble(txt_totalAmount.Text).ToString("F2");
                                    dgv_ItemDteails[9, i].Value = cbox_ItemName.SelectedValue.ToString();
                                    dgv_ItemDteails[10, i].Value = "0";
                                    dgv_ItemDteails[11, i].Value = "0";
                                    dgv_ItemDteails[12, i].Value = cbox_Token.Text;
                                    dgv_ItemDteails[13, i].Value = txtdepartment.Text;
                                }
                            }
                            else
                            {
                                if (addst == "0")
                                {
                                    dgv_ItemDteails.Rows.Add();
                                    i = dgv_ItemDteails.Rows.Count - 1;
                                    dgv_ItemDteails[0, i].Value = i + 1;
                                    dgv_ItemDteails[1, i].Value = cbox_ItemCode.Text;
                                    dgv_ItemDteails[2, i].Value = cbox_ItemName.Text;
                                    dgv_ItemDteails[3, i].Value = Convert.ToDouble(txt_Quantity.Text).ToString("F2");
                                    dgv_ItemDteails[4, i].Value = Convert.ToDouble(txt_Rate.Text).ToString("F2");
                                    dgv_ItemDteails[5, i].Value = Convert.ToDouble(txt_totalAmount.Text).ToString("F2");
                                    dgv_ItemDteails[6, i].Value = cbox_table.Text;
                                    dgv_ItemDteails[7, i].Value = cbox_waiter.Text.ToString();
                                    dgv_ItemDteails[9, i].Value = cbox_ItemName.SelectedValue.ToString();
                                    dgv_ItemDteails[10, i].Value = cbox_waiter.SelectedValue.ToString();
                                    dgv_ItemDteails[11, i].Value = cbox_table.SelectedValue.ToString();
                                    dgv_ItemDteails[12, i].Value = "0";
                                    dgv_ItemDteails[13, i].Value = txtdepartment.Text;
                                }
                            }
                        }
                        dgv_ItemDteails.FirstDisplayedScrollingRowIndex = (dgv_ItemDteails.Rows.Count) - 1;
                        txt_total.Text = "0";
                        for (int s = 0; s < dgv_ItemDteails.Rows.Count; s++)
                        {
                            txt_total.Text = Convert.ToString(Convert.ToString(decimal.Round(Convert.ToDecimal((Convert.ToDouble(txt_total.Text) + Convert.ToDouble(dgv_ItemDteails[5, s].Value))), 2, MidpointRounding.AwayFromZero)));
                            txt_total1.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));
                        }
                        cbox_waiter.Enabled = false;
                        cbox_ItemCode.SelectedIndex = 0;
                        txt_Quantity.Text = "";
                        txt_Rate.Text = "";
                        lbUnit.Text = "";
                        txt_ProductStock.Text = "";
                        cbox_ItemCode.Focus();
                        //cbox_waiter.Focus();
                        h = 1;
                        ////default waiter
                        //if (cbox_waiter.Items.Count > 0)
                        //    cbox_waiter.SelectedIndex = 1;
                        //else
                        //    cbox_waiter.Text = "Waiter1";

                        ////*************************
                        cbox_ItemCode.Focus();

                        dgv_ItemDteails.Focus();
                    }
                }

                catch (Exception ex)
                {
                    File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
                }
            }
        }
            
        
    
                
            
            

        private void dgv_ItemDteails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_kot.Focus();
            }


        }

        private void btn_kot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cbox_Token.Focus();
            }
        }

        private void Billing_KeyDown(object sender, KeyEventArgs e)
        {

        }
        string id;
        private void cbox_waiter_KeyDown(object sender, KeyEventArgs e)       
        
        {
            if (e.KeyData == Keys.Enter)
            {

                cbox_ItemCode.Focus();
            }
            if (e.KeyData == Keys.F1)
            {
                waiters_list ws = new waiters_list(wId);
                ws.ShowDialog(); 
      
               cbox_waiter.SelectedValue = ws.wId;
                
            }
        }
        private void cbox_Token_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cbox_ItemCode.Focus();
                
            }
        }

        private void cbox_table_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgv_KotDetails.Rows.Count > 0)
            {
                cbox_ItemCode.Focus();
            }

            if (e.KeyData == Keys.Enter)
            {

                if (h == 1)
                {
                    // cbox_waiter.SelectedValue = dr1[0].ToString();

                    //cbox_ItemCode.Focus();
                    cbox_waiter.Focus();
                }
                else
                {
                    cbox_waiter.Focus();
                    //cbox_ItemCode.Focus();
                }
            }
        }

        private void rd_dinein_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cbox_table.Focus();
            }
        }

        private void rd_takeaway_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cbox_Token.Focus();
            }
        }

        private void rd_counterBill_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cbox_ItemCode.Focus();
            }
        }

        private void cbox_ItemCode_KeyDown(object sender, KeyEventArgs e)
        
        {
            if (e.KeyData == Keys.Enter)
            {
               // txt_Quantity.Focus(); 
                cbox_ItemName.Focus();
            }
            if (e.KeyData == Keys.F1)
            {
                cbox_ItemName.Focus();
            }
        }

        private void bttn_newcategory_Click(object sender, EventArgs e)
        {
            try
            {
                Item it = new Item();
                it.ShowDialog();
                DataSet ds1 = new DataSet();
                ds1 = obj.GetItemCode();
                cbox_ItemName.DataSource = ds1.Tables[0];
                cbox_ItemName.DisplayMember = "ItemName";
                cbox_ItemName.ValueMember = "Id";
                cbox_ItemCode.DataSource = ds1.Tables[0];
                cbox_ItemCode.DisplayMember = "ItemCode";
                cbox_ItemCode.ValueMember = "Id";
                DataRow dr1 = ds1.Tables[0].NewRow();
                dr1["ItemName"] = "--Select One--";
                dr1["ItemCode"] = "--Select One--";
                dr1["Id"] = "0";
                ds1.Tables[0].Rows.InsertAt(dr1, 0);
                cbox_ItemCode.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }    
        private void txtMobile_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }
        private void dgv_ItemDteails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        } 
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ch_preview_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

       // int DiscStatus = 0;
        private void txt_discount_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_discount.Text == "")
                {
                    txt_discount.Text = "0";
                }
                if (txt_discount.Text.EndsWith("0") == true)
                {
                    txt_discount.Text = Convert.ToDouble(txt_discount.Text).ToString();
                    txt_discount.Select(txt_discount.Text.Length, 0);
                }
                string Str = txt_discount.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                int c = txt_discount.Text.Count(x => x == '.');
                if (c > 1)
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_discount.Text = "0";
                }
                else
                {
                    if (txt_discount.Text.EndsWith(".") == false)
                    {
                        if (isNum)
                        {
                            if (txt_discount.Text != "" && txt_Rate.Text != "")
                            {
                                double TotWithDisc = 0;
                                txt_discount.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(txt_discount.Text), 2, MidpointRounding.AwayFromZero));
                              //  txt_total1.Text = Convert.ToString(decimal.Round(Convert.ToDecimal((Convert.ToDouble(txt_total.Text)) - (Convert.ToDouble(txt_discount.Text))), 2, MidpointRounding.AwayFromZero));

                               // txt_total1.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total1.Text));
                                TotWithDisc = CalcTotalDiscount(Convert.ToDouble(txt_total1.Text), Convert.ToDouble(txt_discount.Text),Convert.ToDouble(txttax.Text));
                                txt_total.Text = TotWithDisc.ToString();
                                txt_discount.Select(txt_discount.Text.Length, 0);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_Quantity.Text = "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // txt_total1.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text == "" ? "0.00" : txt_total.Text));
            //txt_total1.Text = Convert.ToString(Convert.ToString(decimal.Round(Convert.ToDecimal(((Convert.ToDouble(txt_total.Text) * 5) / 100) + Convert.ToDouble(txt_total.Text)), 2, MidpointRounding.AwayFromZero)));
            //txttax.Text = Convert.ToString(Convert.ToDecimal(txt_total1.Text) - Convert.ToDecimal(txt_total.Text));
        }

        private void txt_total1_TextChanged(object sender, EventArgs e)
        {

        }
        string remarks;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ch_complimet.Checked == true)
                {
                    DialogResult dr = MessageBox.Show("If you select complimentary, Food will be free of cost \n Do you Want Continue ? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        txt_discount.Enabled = false;
                        txt_discount.Text = "0";
                        combliment = 1;
                        ComplimentaryRemarks cc = new ComplimentaryRemarks();
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
                        txt_discount.Enabled = true;
                    }
                }
                else
                {
                    combliment = 0;
                    txt_discount.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Str = txtMobile.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {

                    //txtMobile.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(txtMobile.Text), 2, MidpointRounding.AwayFromZero));
                    //txt_totalAmount.Text = Convert.ToString(decimal.Round(Convert.ToDecimal((Convert.ToDouble(txt_Quantity.Text)) * (Convert.ToDouble(txt_Rate.Text))), 2, MidpointRounding.AwayFromZero));

                    //txt_total.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));
                    txtMobile.Select(txtMobile.Text.Length, 0);

                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cbox_ItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbox_ItemName.DroppedDown)
            {
                cbox_ItemName.Focus();

            }

        }

        private void cbox_table_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbox_table.DroppedDown)
            {
                cbox_table.Focus();

            }
        }

        private void cbox_Token_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbox_Token.DroppedDown)
            {
                cbox_Token.Focus();

            }
        }

        private void cbox_waiter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbox_waiter.DroppedDown)
            {
                cbox_waiter.Focus();

            }
        }
        string creditst = "0";
        public string payableamont;
        string customerid;
        string customerstatus;
        string paidamnt;

        private void btn_creditbill_Click(object sender, EventArgs e)
        {
            checkbilltype();
            payableamont = txt_total1.Text;
            CreditCustomer cc = new CreditCustomer(payableamont);
            cc.ShowDialog();
            if (cc.dr == DialogResult.OK)
            {
                creditst = "1";
                paidamnt = cc.paidamnt;
                customerstatus = cc.custst;
                customerid = cc.custid;

                DataTable dt = new DataTable();
                dt = obj.EditCustomer(customerid);
                if (dt.Rows.Count > 0)
                {
                    txtEmail.Text = dt.Rows[0]["email"].ToString();
                    txtMobile.Text = dt.Rows[0]["phone"].ToString();
                    txtCustName.Text = dt.Rows[0]["customer_name"].ToString();
                }
                groupBox7.Enabled = false;
                grp_token.Enabled = false;
                btnAdd.Enabled = false;
                btn_printBill.Enabled = false;

                try
                {
                    if (txtInvoiceNumber.Text != "")
                    {
                        if (rd_counterBill.Checked == true)
                        {
                            if (dgv_ItemDteails.Rows.Count > 0)
                            {
                                string customerst;
                                if (creditst == "0")
                                {
                                    customerst = "0";
                                }
                                else
                                {
                                    customerst = customerstatus;
                                }

                                string msg = obj.InsertInvoiceMaster(txtInvoiceNumber.Text, Convert.ToDateTime(globalvariable.StoreDate), txtCustName.Text, txtMobile.Text, txtEmail.Text, 3, txt_total.Text, combliment,
                                    txt_discount.Text, paidamnt, customerst, customerid, "0.00", user, billtype, Convert.ToDateTime(globalvariable.StoreDate)
                                    , 0, txt_total1.Text, "0.00", "Billing", txttax.Text == "" ? "0.00" : txttax.Text);//Convert.ToDateTime(globalvariable.StoreDate)//dtpDate.Value
                                if (combliment == 1)
                                {
                                    obj.InsertComplimentary(msg, remarks);
                                }
                                if (msg == "0")
                                {
                                    MessageBox.Show("Sorry,This invoice number already exists.Please try other one", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtInvoiceNumber.Focus();
                                }
                                else
                                {
                                    for (int i = 0; i < dgv_ItemDteails.Rows.Count; i++)
                                    {
                                        obj.InsertInvoiceDetails(msg, dgv_ItemDteails[9, i].Value.ToString(), dgv_ItemDteails[3, i].Value.ToString(), dgv_ItemDteails[4, i].Value.ToString(), dgv_ItemDteails[5, i].Value.ToString(), "0", "0", "0", "0");
                                    }
                                    if (ch_preview.Checked == true)
                                    {
                                        FrmPrintBillCounter fp = new FrmPrintBillCounter(msg, counterId);
                                        fp.Show();
                                    }
                                    else
                                    {
                                        dtCounterBill = obj.PrintBillCounter(msg);
                                        PrintCounterBill();
                                    }
                                    clear();
                                    // MessageBox.Show("Invoice successfully created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // cbox_ItemName.Focus();
                                    rd_dinein.Checked = true;
                                    cbox_table.Focus();
                                    SqlDataReader drr = obj.GetSettings();
                                    if (drr.Read())
                                    {
                                        if (drr[1].ToString() == "1")
                                        {

                                            SqlDataReader dr1r = obj.GetInvoiceNo();
                                            if (dr1r.Read())
                                            {
                                                txtInvoiceNumber.Text = dr1r[0].ToString();
                                                txtInvoiceNumber.Enabled = false;
                                                dr1r.Close();
                                            }
                                            else
                                            {
                                                txtInvoiceNumber.Enabled = true;
                                            }
                                        }
                                        drr.Close();
                                    }
                                    else
                                    {
                                        txtInvoiceNumber.Text = "";
                                    }
                                    txt_total.Text = "0.00";
                                    dgv_KotDetails.Rows.Clear();
                                    cbox_table.SelectedIndex = 0;
                                    cbox_waiter.SelectedIndex = 0;
                                    dgv_ItemDteails.Rows.Clear();
                                    groupBox7.Enabled = true;
                                    grp_token.Enabled = true;
                                    btnAdd.Enabled = true;
                                    btn_printBill.Enabled = true;
                                    clear();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please add item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }

                        else
                        {

                            if (dgv_KotDetails.Rows.Count > 0)
                            {
                                if (dgv_ItemDteails.Rows.Count > 0)
                                {
                                    MessageBox.Show("Please print KOT for the selected items and then print bill.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    btn_kot.Focus();
                                }
                                else
                                {
                                    if (rd_dinein.Checked == true)
                                    {
                                        status = 1;
                                    }
                                    if (rd_takeaway.Checked == true)
                                    {
                                        status = 2;
                                    }
                                    string customerst;
                                    if (creditst == "0")
                                    {
                                        customerst = "0";
                                    }
                                    else
                                    {
                                        customerst = customerstatus;
                                    }
                                    msg1 = obj.InsertInvoiceMaster(txtInvoiceNumber.Text, Convert.ToDateTime(globalvariable.StoreDate), txtCustName.Text, txtMobile.Text, txtEmail.Text, status, txt_total.Text, combliment, txt_discount.Text, paidamnt, customerst,
                                        customerid, "0.00", user, billtype, Convert.ToDateTime(globalvariable.StoreDate), 0, txt_total1.Text, "0.00", "Billing", txttax.Text == "" ? "0.00" : txttax.Text);
                                    if (combliment == 1)//Convert.ToDateTime(globalvariable.StoreDate)//dtpDate.Value
                                    {
                                        obj.InsertComplimentary(msg1, remarks);
                                    }
                                    if (msg1 == "0")
                                    {
                                        MessageBox.Show("Sorry,This invoice number already exists.Please try other one", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtInvoiceNumber.Focus();
                                    }
                                    else
                                    {
                                        for (int i = 0; i < dgv_KotDetails.Rows.Count; i++)
                                        {
                                            obj.InsertInvoiceDetails(msg1, dgv_KotDetails[8, i].Value.ToString(), dgv_KotDetails[3, i].Value.ToString(), dgv_KotDetails[4, i].Value.ToString(), dgv_KotDetails[5, i].Value.ToString(), dgv_KotDetails[9, i].Value.ToString(), dgv_KotDetails[10, i].Value.ToString(), dgv_KotDetails[11, i].Value.ToString(), dgv_KotDetails[12, i].Value.ToString());
                                        }
                                        if (ch_preview.Checked == true)
                                        {
                                            if (rd_dinein.Checked == true)
                                            {
                                                FrmPrintBill billObj = new FrmPrintBill(msg1, counterId);
                                                billObj.Show();
                                            }
                                            if (rd_takeaway.Checked == true)
                                            {
                                                FrmPrintBillCounter billObj = new FrmPrintBillCounter(msg1, counterId);
                                                billObj.Show();
                                            }

                                            //FrmPrintBillCounter fp = new FrmPrintBillCounter(msg1);
                                            //fp.Show();
                                        }
                                        else
                                        {
                                            if (rd_dinein.Checked == true)
                                            {
                                                dtBill = obj.PrintBill(msg1);
                                                PrintBill();
                                            }
                                            if (rd_takeaway.Checked == true)
                                            {
                                                dtCounterBill = obj.PrintBillCounter(msg1);
                                                PrintCounterBill();
                                            }
                                        }
                                        //MessageBox.Show("Invoice successfully created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        SqlDataReader drr = obj.GetSettings();
                                        if (drr.Read())
                                        {
                                            if (drr[1].ToString() == "1")
                                            {
                                                SqlDataReader dr1r = obj.GetInvoiceNo();
                                                if (dr1r.Read())
                                                {
                                                    txtInvoiceNumber.Text = dr1r[0].ToString();
                                                    txtInvoiceNumber.Enabled = false;
                                                    dr1r.Close();
                                                }
                                                else
                                                {
                                                    txtInvoiceNumber.Enabled = true;
                                                }
                                            }
                                            drr.Close();
                                        }
                                        else
                                        {
                                            txtInvoiceNumber.Text = "";
                                        }
                                        txt_total1.Text = "0.00";
                                        txt_discount.Text = "0";
                                        txt_total.Text = "0.00";
                                        //cbox_Token.SelectedIndex = 0;
                                        dgv_KotDetails.Rows.Clear();
                                        cbox_table.SelectedIndex = 0;
                                        cbox_waiter.SelectedIndex = 0;
                                        dgv_ItemDteails.Rows.Clear();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please print KOT then print bill.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cbox_ItemCode.Focus();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter invoice no", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtInvoiceNumber.Focus();
                    }
                    ch_complimet.Checked = false;
                }
                catch (Exception ex)
                {
                    File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
                }





            }
        }
       
        private void dgv_ItemDteails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //for (int i = 0; i < dgv_ItemDteails.Rows.Count; i++)
            //{
            //    qty = this.dgv_ItemDteails[4, i].Value.ToString();
            //}
            if (rd_counterBill.Checked == true)
            {
                btn_creditbill.Enabled = true;
            }
        }

        private void dgv_KotDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btn_creditbill.Enabled = true;
        }

        private void grp_token_Enter(object sender, EventArgs e)
        {

        }

        private void btn_paymode_Click(object sender, EventArgs e)
        {
            Paymode ob = new Paymode();
            ob.ShowDialog();
        }

        private void cbox_ItemCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbox_ItemCode.DroppedDown)
            {
                cbox_ItemCode.Focus();

            }
        }
        string billingst, cusst,m="";
private void dgv_KotDetails_CellClick(object sender, DataGridViewCellEventArgs e)
{
try
{
    string custst = "1";
    if (e.RowIndex >= 0 && e.ColumnIndex == 16)
    {

     
            //string s = dgv_KotDetails[18, e.RowIndex].Value.ToString();
            m = dgv_KotDetails[9, e.RowIndex].Value.ToString();

            obj.InsertKotDetail(m, dgv_KotDetails[11, e.RowIndex].Value.ToString(), this.dgv_KotDetails[3, e.RowIndex].Value.ToString(), this.dgv_KotDetails[4, e.RowIndex].Value.ToString(), dgv_KotDetails[5, e.RowIndex].Value.ToString());
            
        
            DataTable dt = new DataTable();
            dt = obj.PrintKot(m);
            dtKOT = dt;
            PrintKOT();
            clear();

        }

if (e.RowIndex >= 0)
{
if (e.ColumnIndex == 13)
{
    if (rd_counterBill.Checked == true)
    {
        billingst = "3";
        custst = "3";
    }
    if (rd_dinein.Checked == true)
    {
        billingst = "1";
        custst = "1";
    }
    if (rd_takeaway.Checked == true)
    {
        billingst = "2";
        custst = "2";
    }


    if (DeleteStatus == "1")
    {
        DialogResult dr = MessageBox.Show("Are you sure to delete this kot ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dr == DialogResult.Yes)
        {



            string id = obj.InsertDeletedKotMaster(txtCustName.Text, txtMobile.Text, txtEmail.Text, txt_total1.Text, billingst, dgv_KotDetails[10, e.RowIndex].Value.ToString(), dgv_KotDetails[11, e.RowIndex].Value.ToString(), custst, dgv_KotDetails[12, e.RowIndex].Value.ToString(), dtpDate.Value, dgv_KotDetails[9, e.RowIndex].Value.ToString());
            obj.InsertDeletedKotDetail(id, dgv_KotDetails[8, e.RowIndex].Value.ToString(), dgv_KotDetails[3, e.RowIndex].Value.ToString(), dgv_KotDetails[4, e.RowIndex].Value.ToString(), dgv_KotDetails[5, e.RowIndex].Value.ToString());
            obj.DeleteKotDetaile(dgv_KotDetails[14, e.RowIndex].Value.ToString());
            txt_total.Text = (Convert.ToDouble(txt_total.Text) - Convert.ToDouble(dgv_KotDetails[5, e.RowIndex].Value.ToString())).ToString("F2");
            obj.DeleteKotMaster(dgv_KotDetails[9, e.RowIndex].Value.ToString());
            dgv_KotDetails.Rows.Remove(dgv_KotDetails.Rows[e.RowIndex]);



            if (dgv_KotDetails.Rows.Count <= 0)
            {
                FindGstWhenNoKotGrid();
            }
            else
            {
                FindGstWhenValueInKotGrid();
            }

            if (dgv_ItemDteails.Rows.Count == 0 && dgv_KotDetails.Rows.Count == 0)
            {
                txt_total.Text = "0.00";
                txttax.Text = "0.00";
                txt_total1.Text = "0.00";
            }
            //------Round Off-------------------//
            double AmtWithRoundOff = 0;
            AmtWithRoundOff = CalcAmtRoundOff(Convert.ToDouble(txt_total.Text));
            txt_total.Text = AmtWithRoundOff.ToString();
            //----------------------------------//

        }
    }
    else 
    {


        DeletePassword dp = new DeletePassword();
        dp.ShowDialog();

        if (dp.Dr == DialogResult.OK)
        {
            string id = obj.InsertDeletedKotMaster(txtCustName.Text, txtMobile.Text, txtEmail.Text, txt_total1.Text, billingst, dgv_KotDetails[10, e.RowIndex].Value.ToString(), dgv_KotDetails[11, e.RowIndex].Value.ToString(), custst, dgv_KotDetails[12, e.RowIndex].Value.ToString(), dtpDate.Value, dgv_KotDetails[9, e.RowIndex].Value.ToString());
            obj.InsertDeletedKotDetail(id, dgv_KotDetails[8, e.RowIndex].Value.ToString(), dgv_KotDetails[3, e.RowIndex].Value.ToString(), dgv_KotDetails[4, e.RowIndex].Value.ToString(), dgv_KotDetails[5, e.RowIndex].Value.ToString());
            obj.DeleteKotDetaile(dgv_KotDetails[14, e.RowIndex].Value.ToString());
            txt_total.Text = (Convert.ToDouble(txt_total.Text) - Convert.ToDouble(dgv_KotDetails[5, e.RowIndex].Value.ToString())).ToString("F2");
            obj.DeleteKotMaster(dgv_KotDetails[9, e.RowIndex].Value.ToString());
            dgv_KotDetails.Rows.Remove(dgv_KotDetails.Rows[e.RowIndex]);
        }
    }
}
}
}

catch (Exception ex)
{
File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
}
}

        private void cbox_waiter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radiocredit_CheckedChanged(object sender, EventArgs e)
        {
            if (radiocredit.Checked == true)
            {
                cmbcustomer.Visible = true;
                cmbcustomer.SelectedIndex = 0;
                txtreceivable.Visible = true;
                lbreceivable.Visible = true;

                txtMobile.Text = txtEmail.Text = "";
                cmbcustomer.Focus();
            }
            else
            {
                cmbcustomer.Visible = false;
                cmbcustomer.Visible = false;
                txtreceivable.Visible = false;
                lbreceivable.Visible = false;
            }
        }

        private void radiocash_CheckedChanged(object sender, EventArgs e)
        {
            if (radiocash.Checked == true)
            {
                txtCustName.Text = "CASH";
                txtMobile.ReadOnly = false; txtEmail.ReadOnly = false;
                txtMobile.Text = txtEmail.Text = "";
                txtCustName.Focus();
            }
            else
            {
                txtMobile.ReadOnly = true; txtEmail.ReadOnly = true;
            }
        }

        private void cmbcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (radiocredit.Checked == false)
                return;
            if (cmbcustomer.SelectedValue == null)
                return;
            txtreceivable.Text = txtMobile.Text = txtEmail.Text = "";
            //retrieve customerbalance
            DataTable dtc = new DataTable();
            dtc = obj.GetCustrecievableamount(Convert.ToInt32(cmbcustomer.SelectedValue.ToString()));
            if (dtc.Rows.Count > 0)
            {

                txtreceivable.Text = dtc.Rows[0]["Amount"].ToString();
            }



            DataTable dt = new DataTable();
            dt = obj.GetCustDetailsBilling(cmbcustomer.SelectedValue.ToString());
            if (dt.Rows.Count > 0)
            {
                //txtTinNo.Text = dt.Rows[0]["tin_no"].ToString();
                ////txtUserBalance.Text = dt.Rows[0]["Balance"].ToString();
                txtMobile.Text = dt.Rows[0]["phone"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
            }

        }

        private void cmbcustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Tab) || (e.KeyCode == Keys.Enter))
            {
                cbox_table.Focus();
            }
        }

        private void grp_table_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void btnReset_Enter(object sender, EventArgs e)
        {
            //    if (e.KeyData == Keys.Enter)
            //    {
            cbox_waiter.Focus();

            //    }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void labeld_Click(object sender, EventArgs e)
        {

        }

        private void dgv_KotDetails_Click(object sender, EventArgs e)
        {
        }

        private void dgv_KotDetails_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 16)
            {
                int i = e.RowIndex;

                //string s = dgv_KotDetails[18, e.RowIndex].Value.ToString();
                m = dgv_KotDetails[9, e.RowIndex].Value.ToString();
                obj.InsertKotDetail(m, dgv_KotDetails[11, e.RowIndex].Value.ToString(), this.dgv_KotDetails[3, e.RowIndex].Value.ToString(), this.dgv_KotDetails[4, e.RowIndex].Value.ToString(), dgv_KotDetails[5, e.RowIndex].Value.ToString());


                DataTable dt = new DataTable();
                dt = obj.PrintKot(m);
                dtKOT = dt;
                PrintKOT();
                clear();
            }
            }
        int tid;
        DataTable dtKOTdetails; 
        private void txt_Quantity_Leave(object sender, EventArgs e)
        {
            btnAdd.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = obj.GetKotDetails(cbox_table.SelectedValue.ToString());
            if (dt.Rows.Count >0)

            dtKOTdetails = dt;
             PrintKOTdetails();
             clear();


            

        }
        public void PrintKOTdetails() 
        {
            try
            {
                //PrintDocument doc = new PrintDocument();
                //doc.PrintPage += this.Doc_PrintPageKOT;
                ////doc.PrinterSettings.PrinterName = "VENDOR THERMAL PRINTER";
                //doc.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                PrintDocument doc1 = new PrintDocument();
                doc1.PrintPage += this.Doc_PrintKOTdetails;
                doc1.PrinterSettings.PrinterName = File.ReadAllText("Printer.txt");
                doc1.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                //doc.OriginAtMargins = true;

                try
                {
                    doc1.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                 
                }
                
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }
        private void Doc_PrintKOTdetails(object sender, PrintPageEventArgs e)
        {
            try
            {
              
                if (dtKOTdetails.Rows.Count > 0)
                { 
                    float x = e.MarginBounds.Left;
                    float y = 10;
                    int widtableh = e.PageBounds.Width;
                    int height = e.PageBounds.Height;
                    float lineHeight = font20.GetHeight(e.Graphics);
                    float xSlno = 0;
                    float xitemaname = 40;
                    float xquantity = 200; 
                    //e.Graphics.DrawString(" Dinnies Family Restaurant", font15, new SolidBrush(Color.Black), 0, y);
                    //lineHeight = font15.GetHeight(e.Graphics);
                    //y += lineHeight;
                    e.Graphics.DrawString("                   KOTDetails", font12, new SolidBrush(Color.Black), 0, y);
                    lineHeight = font12.GetHeight(e.Graphics);
                    y += lineHeight;
                    y += 3;
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(260, Convert.ToInt32(y)));
                    y += 3;
                    if (counterId != 0)
                    {  
                        DataTable dt = new DataTable();
                        dt = obj.EditCounter(counterId.ToString());
                        if (dt.Rows.Count > 0)
                        {
                            e.Graphics.DrawString("Counter : " + dt.Rows[0]["counter_name"].ToString().ToString(), font9, sBrush, 0, y);//f=1
                        }

                        //lineHeight = font9.GetHeight(e.Graphics);
                        //y += lineHeight;
                        //e.Graphics.DrawString("Cashier : " + obj.GetUsernameById(File.ReadAllText("user.txt")), font9, sBrush, 0, y);
                        //lineHeight = font9.GetHeight(e.Graphics);
                        //y += lineHeight;
                        e.Graphics.DrawString("Date: " + dtKOTdetails.Rows[0]["Date"].ToString(), font9, sBrush, 0, y);
                        lineHeight = font9.GetHeight(e.Graphics);
                        y += lineHeight;

                    }   
                    e.Graphics.DrawString("Table No: " + dtKOTdetails.Rows[0]["TableName"].ToString(), font9, sBrush, 0, y);
                    lineHeight = font9.GetHeight(e.Graphics);
                    y += lineHeight;      
                    e.Graphics.DrawString("Waiter: " + dtKOTdetails.Rows[0]["Waiter"].ToString(), font9, sBrush, 0, y);
                    lineHeight = font9.GetHeight(e.Graphics);
                    y += lineHeight;

                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(260, Convert.ToInt32(y)));
                    y += 3;
                    e.Graphics.DrawString("SNO", font9, sBrush, xSlno, y);
                    e.Graphics.DrawString("ITEM", font9, sBrush, xitemaname, y);
                    e.Graphics.DrawString("QTY", font9, sBrush, xquantity, y);

                    y += lineHeight;

                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(260, Convert.ToInt32(y)));
                    y += 3;
                    //lineHeight = font9.GetHeight(e.Graphics);
                    int slnum = 1;
                    for (int i = 0; i < dgv_KotDetails.Rows.Count; i++)
                    {
                        e.Graphics.DrawString(slnum.ToString(), font9, sBrush, xSlno, y);
                        e.Graphics.DrawString(dtKOTdetails.Rows[i]["ItemName"].ToString(), font9, sBrush, xitemaname, y);
                        e.Graphics.DrawString(dtKOTdetails.Rows[i]["Quantity"].ToString(), font9, sBrush, xquantity, y);
                       // e.Graphics.DrawString(dtKOTdetails.Rows[i]["Rate"].ToString(), font8, sBrush, xprice, y);
                        //e.Graphics.DrawString(dtKOTdetails.Rows[i]["Amount"].ToString(), font8, sBrush, xamount, y);

                        //total += Convert.ToDouble(dtKOTdetails.Rows[i]["Amount"]);
                        slnum += 1;
                        y += lineHeight;
                    }
                    //tot = total;
                    y += 3;
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(260, Convert.ToInt32(y)));
                    y += 3;
                  
                    lineHeight = font9.GetHeight(e.Graphics);
                    y += lineHeight;
                    y += lineHeight;        
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void txt_packing_Click(object sender, EventArgs e)
        {
            //Calculator Obj = new Calculator();
            //Obj.ShowDialog();
            //if (Obj.dgrslt == DialogResult.OK)
            //{
            //double pckcharge;
            //    //= Obj.Qty;
            //txt_packing.Text = pckcharge.ToString("F2");
            //}

            //else
            //{
            //    txt_packing.Text = "0.00";
            //}
        }

        private void txt_packing_TextChanged(object sender, EventArgs e)
        {
            txt_total1.Text = (Convert.ToDouble(txt_total.Text) + Convert.ToDouble(txt_packing.Text) - Convert.ToDouble(txt_discount.Text)).ToString("F2");
        }

        private void cbox_ItemName_SelectedValueChanged(object sender, EventArgs e)
        {
        }
        private void rb_homedelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_homedelivery.Checked == true)
            {
                cusst = "4";
                cbox_Token.Enabled = true;
                cbox_table.Enabled = false;
                cbox_waiter.Enabled = false;
                btn_kot.Enabled = true;
                cbox_Token.Focus();
                dgv_ItemDteails.Rows.Clear();
                dgv_KotDetails.Rows.Clear();
                
                txt_discount.Text = "";
                txt_total.Text = "";
                txt_total1.Text = "";
                txt_total1.Text = "0.00";
                txt_discount.Text = "0";
                cbox_table.SelectedIndex = 0;
                cbox_waiter.SelectedIndex = 0; 

            }

        }

        private void btn_cashReceipt_Click(object sender, EventArgs e)
        {
            Payment pt = new Payment();
            pt.ShowDialog();
        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void txtDiscountPercent_Click(object sender, EventArgs e)
        {
            txtDiscountPercent.SelectAll();
        }

        private void txtDiscountPercent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_discount.Focus();
                //if (DiscStatus == 0)
                //{

                    try
                    {
                        if (txtDiscountPercent.Text == "")
                        {
                            txtDiscountPercent.Text = "0";
                        }

                        string Str = txtDiscountPercent.Text.Trim();
                        double Num;
                        bool isNum = double.TryParse(Str, out Num);
                        if (isNum)
                        {
                            if (txtDiscountPercent.Text == "")
                            {
                                txtDiscountPercent.Text = "0";
                            }
                            //if ((txtDiscountPercent.Text != "") && (txtDiscountPercent.Text != "."))
                            //{


                            //}
                            if ((txtDiscountPercent.Text == "") || (txt_total1.Text == ""))
                            {
                                return;
                            }
                            else
                            {
                                double dis = Convert.ToDouble(txtDiscountPercent.Text);
                                double Netamt = Convert.ToDouble(txt_total1.Text);
                                txt_discount.Text = ((dis * Netamt) / 100).ToString("F2");
                            }

                        }

                        else
                        {
                            MessageBox.Show("Invalid number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtDiscountPercent.Text = "0";
                        }
                    }
                    catch (Exception ex)
                    {
                        File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
                    }
                }
          //  }
        }

        private void txtDiscountPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void label12_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void txttax_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
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
                string[] values = Convert.ToString(Convert.ToDouble( AmtRound).ToString("F2")).Split(new char[] { '.' });
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

        string GstTot = "0";
        string GstTot1 = "0";
        string GstTax = "0";
        string GstTotKot = "0";
        string GstTot1Kot = "0";
        string GstTaxKot = "0";
        string GStTotAmt = "0";

        private void GstCalculation()
        {
            decimal Tot = 0;
            double Tot1 = 0;
            for (int s = 0; s < dgv_ItemDteails.Rows.Count; s++)
            {
                Tot += (decimal.Round(Convert.ToDecimal((Convert.ToDouble(dgv_ItemDteails[5, s].Value))), 2, MidpointRounding.AwayFromZero));
                GstTot = Tot.ToString();
                Tot1 += Convert.ToDouble(string.Format("{0:0.00}", Convert.ToDouble(dgv_ItemDteails["Column10", s].Value) * Convert.ToDouble(dgv_ItemDteails["Column4", s].Value)));
                GstTot1 = Tot1.ToString();
            }
            //------------GST Tax Calculation 5% -------------------//
            GstTot = Convert.ToString(Convert.ToString(decimal.Round(Convert.ToDecimal(((Convert.ToDouble(GstTot1) * 5) / 100) + Convert.ToDouble(GstTot1)), 2, MidpointRounding.AwayFromZero)));
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
            double total = 0;
            for (int r = 0; r < dgv_KotDetails.Rows.Count; r++)
            {
                total += (Convert.ToDouble(dgv_KotDetails[5, r].Value));
            }


            GstTot1Kot = Convert.ToString((decimal.Round(Convert.ToDecimal(total), 2, MidpointRounding.AwayFromZero)));
            GstTotKot = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));
            
            //------------GST Tax Calculation 5% -------------------//
            GstTotKot = Convert.ToString(Convert.ToString(decimal.Round(Convert.ToDecimal(((Convert.ToDouble(GstTot1Kot) * 5) / 100) + Convert.ToDouble(GstTot1Kot)), 2, MidpointRounding.AwayFromZero)));
            GstTaxKot = Convert.ToString(Convert.ToDecimal(GstTotKot) - Convert.ToDecimal(GstTot1Kot));
            //------------------------------------------------------//

            
        }


        private void GstClear()
        {
            GstTot = "0";
            GstTot1 = "0";
            GstTax = "0";
            GStTotAmt = "0";
        }
        private void GstClearKot()
        {
            GstTotKot = "0";
            GstTot1Kot = "0";
            GstTaxKot = "0";
            GStTotAmt = "0";
        }


        private void FindGstWhenNoKotGrid()
        {
            decimal Tot = 0;
            double Tot1 = 0;

            for (int s = 0; s < dgv_ItemDteails.Rows.Count; s++)
            {
                Tot += (decimal.Round(Convert.ToDecimal((Convert.ToDouble(dgv_ItemDteails[5, s].Value))), 2, MidpointRounding.AwayFromZero));
                txt_total.Text = Tot.ToString();
                //txt_total1.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));
                Tot1 += Convert.ToDouble(string.Format("{0:0.00}", Convert.ToDouble(dgv_ItemDteails["Column10", s].Value) * Convert.ToDouble(dgv_ItemDteails["Column4", s].Value)));
                txt_total1.Text = Tot1.ToString();
            }
            //------------GST Tax Calculation 5% -------------------//
            txt_total.Text = Convert.ToString(Convert.ToString(decimal.Round(Convert.ToDecimal(((Convert.ToDouble(txt_total1.Text) * 5) / 100) + Convert.ToDouble(txt_total1.Text)), 2, MidpointRounding.AwayFromZero)));
            txttax.Text = Convert.ToString(Convert.ToDecimal(txt_total.Text) - Convert.ToDecimal(txt_total1.Text));
            //------------------------------------------------------//
            //------Round Off-------------------//
            double AmtWithRoundOff = 0;
            AmtWithRoundOff = CalcAmtRoundOff(Convert.ToDouble(txt_total.Text));
            txt_total.Text = AmtWithRoundOff.ToString();
            //----------------------------------//
        }


        private void FindGstWhenValueInKotGrid()
        {
            string GStTotAmtWithoutRoundOff = "0";
            GstCalculation();
            GstCalculationKot();
            GStTotAmtWithoutRoundOff = (Convert.ToDouble(GstTot) + Convert.ToDouble(GstTotKot)).ToString();

            txt_total1.Text = (Convert.ToDouble(GstTot1) + Convert.ToDouble(GstTot1Kot)).ToString();
            txt_total.Text = GStTotAmtWithoutRoundOff;
            txttax.Text = (Convert.ToDouble(GstTax) + Convert.ToDouble(GstTaxKot)).ToString();
            //------------------------------------------------------//

            GStTotAmt = CalcAmtRoundOff(Convert.ToDouble(GStTotAmtWithoutRoundOff)).ToString();

            GStTotAmtWithoutRoundOff = "0";
            GstClear();
            GstClearKot();

        }


        private double CalcTotalDiscount(double TotWithoutDisc,double DiscAmt,double DiscTax)
        {
            double TotWithDisc=0;
            double TotWithDiscTax = 0;

            TotWithDisc = Math.Round((TotWithoutDisc+DiscTax),0) ;
            TotWithDiscTax = TotWithDisc - DiscAmt;
            return TotWithDiscTax;
        }

        private void SetDefaultWaiter()
        {
            if (cbox_waiter.Items.Count > 0)
                cbox_waiter.SelectedIndex = 1;
            else
                cbox_waiter.SelectedIndex = 0;
        }



        private void CheckTaxAmoutInBill()
        {
            decimal ItemTot = 0;
            decimal BillTot = 0;
            string BillTotWithTax = "0";
            string BillTotWithTaxWithROff = "0";
            for (int s = 0; s < dgv_KotDetails.Rows.Count; s++)
            {
                ItemTot += (decimal.Round(Convert.ToDecimal((Convert.ToDouble(dgv_KotDetails["dataGridViewTextBoxColumn6", s].Value))), 2, MidpointRounding.AwayFromZero));

            }
            for (int s = 0; s < dgv_ItemDteails.Rows.Count; s++)
            {
                ItemTot += (decimal.Round(Convert.ToDecimal((Convert.ToDouble(dgv_ItemDteails["Column8", s].Value))), 2, MidpointRounding.AwayFromZero));

            }

            BillTot = Convert.ToDecimal(txt_total.Text == "" ? "0" : txt_total.Text);

            if (BillTot == ItemTot)
            {
                //------------GST Tax Calculation 5% -------------------//
                BillTotWithTax = Convert.ToString(Convert.ToString(decimal.Round(Convert.ToDecimal(((Convert.ToDouble(BillTot) * 5) / 100) + Convert.ToDouble(BillTot)), 2, MidpointRounding.AwayFromZero)));


                BillTotWithTaxWithROff = CalcAmtRoundOff(Convert.ToDouble(BillTotWithTax)).ToString();

                txt_total.Text = BillTotWithTaxWithROff;
            }

        }



        }
        }
    


