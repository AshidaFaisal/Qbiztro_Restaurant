using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace BisCarePosEdition
{
    public partial class Home_page : Form
    {
        Codebehind objcode = new Codebehind();
        public Home_page()
        {
            InitializeComponent();
        }
        public string parentid;
        private void Home_page_Load(object sender, EventArgs e)
        {
            Theme ObjTheme = new Theme();
            ObjTheme.setTheme();
            ApplyTheme();
            bttn_activities_Click(sender, e);
            }
           
        public Button btnchilds;
        Byte[] img;   
        private void CloseOpenForms()
        { 
            while (Application.OpenForms.Count > 1)
            {
                Application.OpenForms[Application.OpenForms.Count - 1].Close();
            }
        }
        string Userid ;
        private void btn_child_click(object sender, EventArgs e)
        {    
            string btnid = ((Button)sender).Tag.ToString();
            DataTable dtbuttons = new DataTable();
            string id = ((Button)sender).Tag.ToString();
            string buttonname = ((Button)sender).Text.ToString();
            dtbuttons = objcode.openformsbyid(id);
            DataTable dt = new DataTable();
            dt = objcode.GetFormUserRights(File.ReadAllText("user.txt"), buttonname);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if (dtbuttons.Rows[0]["Formname"].ToString() == "Designation")
                    {
                        Designation ds = new Designation();
                        ds.ShowDialog();
                        ds.TopLevel = false;
                        ds.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(ds);
                        ds.WindowState = FormWindowState.Maximized;
                    }
                    else  if (dtbuttons.Rows[0]["Formname"].ToString() == "NewForm")
                    {
                        NewForm nf = new NewForm();
                        nf.ShowDialog();
                        nf.TopLevel = false;
                        nf.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(nf);
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "Stock")
                    {
                        Stock sr = new Stock();
                        sr.ShowDialog();
                        sr.TopLevel = false;
                        sr.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(sr);
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "ChangePassword")
                    {
                        PasswordChange pc = new PasswordChange();
                        pc.ShowDialog();
                        pc.TopLevel = false;
                        pc.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(pc);
                        pc.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "Employee")
                    {
                        Employee eee = new Employee();
                        eee.ShowDialog();
                        eee.TopLevel = false;
                        eee.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(eee);
                        eee.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "ReportDeletedKotDetails")
                    {
                        ReportDeletedKotDetails ree = new ReportDeletedKotDetails();
                        ree.ShowDialog();
                        ree.TopLevel = false;
                        ree.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(ree);
                        ree.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "BackUp")
                    {
                        BackupDB bdb = new BackupDB();
                        bdb.ShowDialog();
                        bdb.TopLevel = false;
                        bdb.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(bdb);
                        bdb.WindowState = FormWindowState.Normal;

                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "Restuarant")
                    {
                        Restuarant rst = new Restuarant();
                        rst.ShowDialog();
                        rst.TopLevel = false;
                        rst.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(rst);
                        rst.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "Restore")
                    {
                        RestoreDB rdb = new RestoreDB();
                        rdb.ShowDialog();
                        rdb.TopLevel = false;
                        rdb.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(rdb);
                        rdb.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "Complimentary_Invoice_Report")
                    {
                        Complimentary_Invoice_Report rdb = new Complimentary_Invoice_Report();
                        rdb.ShowDialog();
                        rdb.TopLevel = false;
                        rdb.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(rdb);
                        rdb.WindowState = FormWindowState.Normal;
                    }
                      
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "ResetDB")
                    {
                        
                            ResetDB redb = new ResetDB();
                            redb.ShowDialog();
                            redb.TopLevel = false;
                            redb.AutoScroll = true;
                            if (globalvariable.formstatus == 1)
                            {
                                this.Close();
                            }
                            else
                            {
                                splitContainer2.Panel2.Controls.Add(redb);
                                redb.WindowState = FormWindowState.Normal;

                            }
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "Counter")
                    {
                        Counter ct = new Counter();
                        ct.ShowDialog();
                        ct.TopLevel = false;
                        ct.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(ct);
                        ct.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "User")
                    {
                        User us = new User();
                        us.ShowDialog();
                        us.TopLevel = false;
                        us.AutoScroll = false;
                        splitContainer2.Panel2.Controls.Add(us);
                        us.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "Billing Features")
                    {
                        Billing_Features bf = new Billing_Features();
                        bf.ShowDialog();
                        bf.TopLevel = false;
                        bf.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(bf);
                        bf.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "UserRights")
                    {
                        UserRightscs us = new UserRightscs();
                        us.ShowDialog();
                        us.TopLevel = false;
                        us.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(us);
                        us.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "ThemeRoller")
                    {
                        ThemeRoller tr = new ThemeRoller();
                        tr.ShowDialog();
                        tr.TopLevel = false;
                        tr.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(tr);
                        tr.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "UserAccountType")
                    {
                        UserAccountType uacc = new UserAccountType();
                        uacc.ShowDialog();
                        uacc.TopLevel = false;
                        uacc.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(uacc);
                        uacc.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "ClearTransactions")
                    {
                        ClearTransactions ct = new ClearTransactions();
                        ct.ShowDialog();
                        ct.TopLevel = false;
                        ct.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(ct);
                        ct.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "Item")
                    {
                        Item it = new Item();
                        it.ShowDialog();
                        it.TopLevel = false;
                        it.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(it);
                        it.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "Cost_Analysis_Report")
                    {
                        Cost_Analysis_Report it = new Cost_Analysis_Report();
                        it.ShowDialog();
                        it.TopLevel = false;
                        it.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(it);
                        it.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "Sale_Analysis_Report")
                    {
                        Sale_Analysis_Report it = new Sale_Analysis_Report();
                        it.ShowDialog();
                        it.TopLevel = false;
                        it.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(it);
                        it.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "Category")
                    {
                        Category ca = new Category();
                        ca.ShowDialog();
                        ca.TopLevel = false;
                        ca.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(ca);
                        ca.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "Table")
                    {
                        Tables ta = new Tables();
                        ta.ShowDialog();
                        ta.TopLevel = false;
                        ta.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(ta);
                        ta.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "Department")
                    {
                        Department dp = new Department();
                        dp.ShowDialog();
                        dp.TopLevel = false;
                        dp.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(dp);
                        dp.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "Brand")
                    {
                        Brand dp = new Brand();
                        dp.ShowDialog();
                        dp.TopLevel = false;
                        dp.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(dp);
                        //dp.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "Unit")
                    {
                        Unit dp = new Unit();
                        dp.ShowDialog();
                        dp.TopLevel = false;
                        dp.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(dp);
                        // dp.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "Customer")
                    {
                        Customer dp = new Customer();
                        dp.ShowDialog();
                        dp.TopLevel = false;
                        dp.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(dp);
                        //dp.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "Dealer")
                    {
                        Dealer dp = new Dealer();
                        dp.ShowDialog();
                        dp.TopLevel = false;
                        dp.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(dp);
                        //dp.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "Bank")
                    {
                        Bank dp = new Bank();
                        dp.ShowDialog();
                        dp.TopLevel = false;
                        dp.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(dp);
                        //dp.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "Tax")
                    {
                        Tax dp = new Tax();
                        dp.ShowDialog();
                        dp.TopLevel = false;
                        dp.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(dp);
                        //dp.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "PendingKOT")
                    {
                        PendingOT_S dp = new PendingOT_S();
                        dp.ShowDialog();
                        dp.TopLevel = false;
                        dp.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(dp);
                        // dp.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "DeleteKOT")
                    {
                        DeleteKot dk = new DeleteKot();
                        dk.ShowDialog();
                        dk.TopLevel = false;
                        dk.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(dk);
                        // dk.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "DeleteBill")
                    {
                        DeleteBill dbi = new DeleteBill();
                        dbi.ShowDialog();
                        dbi.TopLevel = false;
                        dbi.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(dbi);
                        //  dbi.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "SearchBill")
                    {
                        SearchBill sb = new SearchBill();
                        sb.ShowDialog();
                        sb.TopLevel = false;
                        sb.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(sb);
                        //   sb.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "GoodsReceipt")
                    {
                        StockEntry dp = new StockEntry();
                        dp.ShowDialog();
                        //ReceiptVoucher dp = new ReceiptVoucher();
                        //dp.ShowDialog();
                        dp.TopLevel = false;
                        dp.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(dp);
                        //  dp.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "OldPayableReceivable")
                    {
                        OldPayableReceivable op = new OldPayableReceivable();
                        op.ShowDialog();
                        op.TopLevel = false;
                        op.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(op);
                        //   op.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "ProductStock")
                    {
                        ProductStock dp = new ProductStock();
                        dp.ShowDialog();
                        dp.TopLevel = false;
                        dp.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(dp);
                        //    dp.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "ProductDamageEntry")
                    {
                        ProductDamageEntry dp = new ProductDamageEntry();
                        dp.ShowDialog();
                        dp.TopLevel = false;
                        dp.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(dp);
                        // dp.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "TouchBilling")
                    {
                        DataTable dtStoreStatus = new DataTable();
                        dtStoreStatus = objcode.GetStoreStatus();
                        if (dtStoreStatus.Rows.Count > 0 && dtStoreStatus.Rows[0]["Status"].ToString() == "Open")
                        {
                            TouchBilling tb = new TouchBilling();
                            tb.ShowDialog();
                            tb.TopLevel = false;
                            tb.AutoScroll = true;
                            splitContainer2.Panel2.Controls.Add(tb);
                            tb.WindowState = FormWindowState.Normal;
                        }
                        else
                            MessageBox.Show("Store Not Opened.......!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "SalesReport")
                    {
                        SalesReport sr = new SalesReport();
                        sr.ShowDialog();
                        sr.TopLevel = false;
                        sr.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(sr);
                        //   sr.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "DailySalesReport")
                    {
                        SalesReportByDate sd = new SalesReportByDate();
                        sd.ShowDialog();
                        sd.TopLevel = false;
                        sd.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(sd);
                        //sd.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "DeletedInvoiceReport")
                    {
                        DeletedInvoiceReport di = new DeletedInvoiceReport();
                        di.ShowDialog();
                        di.TopLevel = false;
                        di.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(di);
                        //di.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "DeletedInvoiceReportShort")
                    {
                        DeletedInvoiceReportShort dis = new DeletedInvoiceReportShort();
                        dis.ShowDialog();
                        dis.TopLevel = false;
                        dis.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(dis);
                        // dis.WindowState = FormWindowState.Normal;
                    }
                    
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "OtherExpenceReport")
                    {
                    ReportOtherExpence oer = new ReportOtherExpence();
                        oer.ShowDialog();
                        oer.TopLevel = false;
                        oer.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(oer);
                        //  oer.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "OtherIncomeReport")
                    {
                        ReportOtherIncome oir = new ReportOtherIncome();
                        oir.ShowDialog();
                        oir.TopLevel = false;
                        oir.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(oir);

                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "PayableReceivableReport")
                    {
                        ReportPayableRecievable sr = new ReportPayableRecievable();
                        sr.ShowDialog();
                        sr.TopLevel = false;
                        sr.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(sr);

                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "BankTransaction")
                    {
                        BankTrnsaction bt = new BankTrnsaction();
                        bt.ShowDialog();
                        bt.TopLevel = false;
                        bt.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(bt);
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "ProductStockReport")
                    {
                        ProductStockReport sr = new ProductStockReport();
                        sr.ShowDialog();
                        sr.TopLevel = false;
                        sr.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(sr);
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "DiscountReport")
                    {
                        DiscountReport dis = new DiscountReport();
                        dis.ShowDialog();
                        dis.TopLevel = false;
                        dis.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(dis);
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "Billing")
                    {
                        DataTable dtStoreStatus = new DataTable();
                        dtStoreStatus = objcode.GetStoreStatus();
                        if (dtStoreStatus.Rows.Count > 0 && dtStoreStatus.Rows[0]["Status"].ToString() == "Open")
                        {
                            Billing sr = new Billing();
                            sr.ShowDialog();
                            sr.TopLevel = false;
                            sr.AutoScroll = true;
                            splitContainer2.Panel2.Controls.Add(sr);
                        }
                        else
                            MessageBox.Show("Store Not Opened.......!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                            else if (dtbuttons.Rows[0]["Formname"].ToString() == "OtherIncome")
                             {
                           OtherIncomeNew oinew = new OtherIncomeNew();
                            oinew.ShowDialog();
                            oinew.TopLevel = false;
                            oinew.AutoScroll = true;
                            splitContainer2.Panel2.Controls.Add(oinew);
                          
                            }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "OtherExpences")
                            {
                            OtherExpences sr = new OtherExpences();
                            sr.ShowDialog();
                            sr.TopLevel = false;
                            sr.AutoScroll = true;
                            splitContainer2.Panel2.Controls.Add(sr);
                          
                            }
                            else if (dtbuttons.Rows[0]["Formname"].ToString() == "BankTransaction")
                            {
                            BankTrnsaction btr = new BankTrnsaction();
                            btr.ShowDialog();
                            btr.TopLevel = false;
                            btr.AutoScroll = true;
                            splitContainer2.Panel2.Controls.Add(btr);
                           
                            }
                            else if (dtbuttons.Rows[0]["Formname"].ToString() == "PaymentVoucher")
                            {
                            PaymentVoucher sr = new PaymentVoucher();
                            sr.ShowDialog();
                            sr.TopLevel = false;
                            sr.AutoScroll = true;
                            splitContainer2.Panel2.Controls.Add(sr);
                          
                            }
                            else if (dtbuttons.Rows[0]["Formname"].ToString() == "ReceiptVoucher")
                           {
                            ReceiptVoucher sr = new ReceiptVoucher();
                            sr.ShowDialog();
                            sr.TopLevel = false;
                            sr.AutoScroll = true;
                            splitContainer2.Panel2.Controls.Add(sr);
                            sr.WindowState = FormWindowState.Normal;
                           }
                      else if (dtbuttons.Rows[0]["Formname"].ToString() == "Waiter")
                       {
                        waiter sr = new waiter();
                        sr.ShowDialog();
                        sr.TopLevel = false;
                        sr.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(sr);
                        sr.WindowState = FormWindowState.Normal;
                    }
                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "item_mapping")
                    {
                        item_mapping sr = new item_mapping();
                        sr.ShowDialog();
                        sr.TopLevel = false;
                        sr.AutoScroll = true;
                        splitContainer2.Panel2.Controls.Add(sr);
                        sr.WindowState = FormWindowState.Normal;
                    }





                    else if (dtbuttons.Rows[0]["Formname"].ToString() == "Store_Operations")
                    {
                        dt = objcode.GetFormUserRights(File.ReadAllText("user.txt"), "Store_Operations");
                        if (dt.Rows.Count > 0)
                        {
                            if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                            {
                                Store_Operations sr = new Store_Operations();
                                sr.ShowDialog();
                                sr.TopLevel = false;
                                sr.AutoScroll = true;
                                splitContainer2.Panel2.Controls.Add(sr);
                                sr.WindowState = FormWindowState.Normal;
                            }
                            else
                            {
                                MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }   
                }
            }
        }
          
   
  
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        DataTable dtKOT, dtKOTTake, dtCounterBill, dtBill;
        int LogoutStat = 0;

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

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bttn_Administration_Click(object sender, EventArgs e)
        {
              
                  string user = File.ReadAllText("user.txt"); 
                  splitContainer2.Panel1.Controls.Clear();
                  DataTable dtbuttons = new DataTable();
                  dtbuttons = objcode.Getchildbuttons(user, "1");
                  if (dtbuttons.Rows.Count > 0)
                  {

                      TableLayoutPanel tblypanelDetailsCenter = new System.Windows.Forms.TableLayoutPanel();
                      splitContainer2.Panel1.Controls.Add(tblypanelDetailsCenter);
                      tblypanelDetailsCenter.AutoSize = true;
                      tblypanelDetailsCenter.ColumnCount = 1;
                      tblypanelDetailsCenter.Dock = System.Windows.Forms.DockStyle.Top;
                      this.splitContainer2.Panel1.AutoScroll = true;
                      //this.splitContainer2.Panel1.VerticalScroll.Visible = true;
                      tblypanelDetailsCenter.Margin = new System.Windows.Forms.Padding(0);
                      tblypanelDetailsCenter.Name = "tblypanelDetailsCenter";
                      tblypanelDetailsCenter.Controls.Clear();
                      tblypanelDetailsCenter.RowCount = dtbuttons.Rows.Count;
                      for (int i = 0; i < tblypanelDetailsCenter.RowCount; i++)
                      {
                          tblypanelDetailsCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, Convert.ToInt32(50)));
                         
                      }
                      for (int k = 0; k < dtbuttons.Rows.Count; k++)
                      {

                          Button btnchilds = new Button();
                          btnchilds.Name = "btnparent1" + k.ToString();
                          btnchilds.ForeColor = Color.FromArgb(Convert.ToInt32(dtbuttons.Rows[k]["LabelForeColor"].ToString()));
                          btnchilds.Font = new Font("Ariel", 12);
                          if (dtbuttons.Rows[k]["Formicon"] != "0x")
                          {
                              img = (byte[])dtbuttons.Rows[k]["Formicon"];
                              MemoryStream ms = new MemoryStream((byte[])dtbuttons.Rows[k]["Formicon"]);
                              if (ms.Length == 0)
                              {
                                  string FilePath = Application.StartupPath + " \\formimage\\" + "DefaultImage.ico";
                                  btnchilds.Image = Image.FromFile(FilePath);
                                  btnchilds.ImageAlign = ContentAlignment.MiddleLeft;
                                  btnchilds.TextAlign = ContentAlignment.MiddleCenter;
                                  //Location = new Point(10, 15);
                                  btnchilds.TextImageRelation = TextImageRelation.Overlay;
                                  btnchilds.FlatStyle = FlatStyle.Flat;

                              }
                              else
                              {
                                  btnchilds.Image = Image.FromStream(ms);
                                  btnchilds.ImageAlign = ContentAlignment.MiddleLeft;
                                  // Location = new Point(5, 15);
                                  btnchilds.TextAlign = ContentAlignment.MiddleCenter;
                                  btnchilds.TextImageRelation = TextImageRelation.Overlay;
                                  btnchilds.Refresh();
                                  btnchilds.FlatStyle = FlatStyle.Flat;
                              }
                          }
                          this.splitContainer2.Panel1.AutoScroll = true;
                          this.splitContainer2.Panel1.VerticalScroll.Visible = true;

                          btnchilds.BackColor = Color.FromArgb(Convert.ToInt32(dtbuttons.Rows[k]["ButtonBackColor"].ToString()));
                          btnchilds.Text = dtbuttons.Rows[k]["DisplayName"].ToString() == "" ? dtbuttons.Rows[k]["Formname"].ToString() : dtbuttons.Rows[k]["DisplayName"].ToString();
                          btnchilds.Tag = dtbuttons.Rows[k]["Id"].ToString();
                          parentid = btnchilds.Tag.ToString();
                          btnchilds.Dock = System.Windows.Forms.DockStyle.Fill;
                          tblypanelDetailsCenter.Controls.Add(btnchilds);
                          btnchilds.Click += new System.EventHandler(btn_child_click);



                      }

                  }
                  else
                  {
                      MessageBox.Show("You have no Rights to view this Section", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  }
              
                    
            
        }

        private void bttn_Masters_Click(object sender, EventArgs e)
        {
              
              string user = File.ReadAllText("user.txt");
            
                  splitContainer2.Panel1.Controls.Clear();
                  DataTable dtbuttons = new DataTable();

                  dtbuttons = objcode.Getchildbuttons(user," 2");
                  if (dtbuttons.Rows.Count > 0)
                  {

                      TableLayoutPanel tblypanelDetailsCenter = new System.Windows.Forms.TableLayoutPanel();
                      splitContainer2.Panel1.Controls.Add(tblypanelDetailsCenter);
                      tblypanelDetailsCenter.AutoSize = true;
                      tblypanelDetailsCenter.ColumnCount = 1;
                      //this.splitContainer2.Panel1.AutoScroll = true;
                      //this.splitContainer2.Panel1.VerticalScroll.Visible = true;
                      tblypanelDetailsCenter.Dock = System.Windows.Forms.DockStyle.Top;
                      tblypanelDetailsCenter.Margin = new System.Windows.Forms.Padding(0);
                      tblypanelDetailsCenter.Name = "tblypanelDetailsCenter";
                      tblypanelDetailsCenter.Controls.Clear();
                      tblypanelDetailsCenter.RowCount = dtbuttons.Rows.Count;
                      for (int i = 0; i < tblypanelDetailsCenter.RowCount; i++)
                      {
                          tblypanelDetailsCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, Convert.ToInt32(50)));
                      }

                      for (int k = 0; k < dtbuttons.Rows.Count; k++)
                      {

                          Button btnchilds = new Button();
                          btnchilds.Name = "btnparent1" + k.ToString();
                          btnchilds.ForeColor = Color.FromArgb(Convert.ToInt32(dtbuttons.Rows[k]["LabelForeColor"].ToString()));
                          btnchilds.Size = new Size(20, 30);
                          btnchilds.Dock = DockStyle.Fill;
                          btnchilds.Font = new Font("Ariel", 12);
                          if (dtbuttons.Rows[k]["Formicon"] != "0x")
                          {
                              img = (byte[])dtbuttons.Rows[k]["Formicon"];
                              MemoryStream ms = new MemoryStream((byte[])dtbuttons.Rows[k]["Formicon"]);
                              if (ms.Length == 0)
                              {
                                  string FilePath = Application.StartupPath + " \\formimage\\" + "DefaultImage.ico";
                                  btnchilds.Image = Image.FromFile(FilePath);
                                  btnchilds.ImageAlign = ContentAlignment.MiddleLeft;
                                  btnchilds.TextAlign = ContentAlignment.MiddleCenter;
                                  //Location = new Point(10, 15);
                                  btnchilds.TextImageRelation = TextImageRelation.Overlay;
                                  btnchilds.FlatStyle = FlatStyle.Flat;

                              }
                              else
                              {
                                  btnchilds.Image = Image.FromStream(ms);
                                  btnchilds.ImageAlign = ContentAlignment.MiddleLeft;
                                  // Location = new Point(5, 15);
                                  btnchilds.TextAlign = ContentAlignment.MiddleCenter;
                                  btnchilds.TextImageRelation = TextImageRelation.Overlay;
                                  btnchilds.Refresh();
                                  btnchilds.FlatStyle = FlatStyle.Flat;
                              }
                          }
                          btnchilds.BackColor = Color.FromArgb(Convert.ToInt32(dtbuttons.Rows[k]["ButtonBackColor"].ToString()));
                          btnchilds.Text = dtbuttons.Rows[k]["DisplayName"].ToString() == "" ? dtbuttons.Rows[k]["Formname"].ToString() : dtbuttons.Rows[k]["DisplayName"].ToString();
                          btnchilds.Tag = dtbuttons.Rows[k]["Id"].ToString();
                          parentid = btnchilds.Tag.ToString();
                          btnchilds.Dock = System.Windows.Forms.DockStyle.Fill;
                          tblypanelDetailsCenter.Controls.Add(btnchilds);
                          btnchilds.Click += new System.EventHandler(btn_child_click);



                      }

                  }
                  else
                  {
                      MessageBox.Show("You have no Rights to view this Section", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  }     
            }
        

        private void bttn_Finance_Click(object sender, EventArgs e)
        {
              
              string user = File.ReadAllText("user.txt");
              
                  splitContainer2.Panel1.Controls.Clear();
                  DataTable dtbuttons = new DataTable();

                  dtbuttons = objcode.Getchildbuttons(user, "3");
                  if (dtbuttons.Rows.Count > 0)
                  {

                      TableLayoutPanel tblypanelDetailsCenter = new System.Windows.Forms.TableLayoutPanel();
                      splitContainer2.Panel1.Controls.Add(tblypanelDetailsCenter);
                      tblypanelDetailsCenter.AutoSize = true;
                      tblypanelDetailsCenter.ColumnCount = 0;
                      tblypanelDetailsCenter.Dock = System.Windows.Forms.DockStyle.Top;
                      //this.splitContainer2.Panel1.AutoScroll = true;
                      //this.splitContainer2.Panel1.VerticalScroll.Visible = true;
                      tblypanelDetailsCenter.Margin = new System.Windows.Forms.Padding(0);
                      tblypanelDetailsCenter.Name = "tblypanelDetailsCenter";
                      tblypanelDetailsCenter.Controls.Clear();
                      tblypanelDetailsCenter.RowCount = dtbuttons.Rows.Count;
                      for (int i = 0; i < tblypanelDetailsCenter.RowCount; i++)
                      {
                       tblypanelDetailsCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, Convert.ToInt32(50)));
                         
                      }

                      for (int k = 0; k < dtbuttons.Rows.Count; k++)
                      {

                          Button btnchilds = new Button();
                          btnchilds.Name = "btnparent1" + k.ToString();
                          btnchilds.ForeColor = Color.FromArgb(Convert.ToInt32(dtbuttons.Rows[k]["LabelForeColor"].ToString()));
                          btnchilds.Font = new Font("Ariel", 12);
                          if (dtbuttons.Rows[k]["Formicon"] != "0x")
                          {
                              img = (byte[])dtbuttons.Rows[k]["Formicon"];
                              MemoryStream ms = new MemoryStream((byte[])dtbuttons.Rows[k]["Formicon"]);
                              if (ms.Length == 0)
                              {
                                  string FilePath = Application.StartupPath + " \\formimage\\" + "DefaultImage.ico";
                                  btnchilds.Image = Image.FromFile(FilePath);
                                  btnchilds.ImageAlign = ContentAlignment.MiddleLeft;
                                  btnchilds.TextAlign = ContentAlignment.MiddleCenter;
                                  //Location = new Point(10, 15);
                                  btnchilds.TextImageRelation = TextImageRelation.Overlay;
                                  btnchilds.FlatStyle = FlatStyle.Flat;

                              }
                              else
                              {
                                  btnchilds.Image = Image.FromStream(ms);
                                  btnchilds.ImageAlign = ContentAlignment.MiddleLeft;
                                  // Location = new Point(5, 15);
                                  btnchilds.TextAlign = ContentAlignment.MiddleCenter;
                                  btnchilds.TextImageRelation = TextImageRelation.Overlay;
                                  btnchilds.Refresh();
                                  btnchilds.FlatStyle = FlatStyle.Flat;
                              }
                          }
                          btnchilds.BackColor = Color.FromArgb(Convert.ToInt32(dtbuttons.Rows[k]["ButtonBackColor"].ToString()));
                          btnchilds.Text = dtbuttons.Rows[k]["DisplayName"].ToString() == "" ? dtbuttons.Rows[k]["Formname"].ToString() : dtbuttons.Rows[k]["DisplayName"].ToString();
                          btnchilds.Tag = dtbuttons.Rows[k]["Id"].ToString();
                          parentid = btnchilds.Tag.ToString();
                          btnchilds.Dock = System.Windows.Forms.DockStyle.Fill;
                          tblypanelDetailsCenter.Controls.Add(btnchilds);
                          btnchilds.Click += new System.EventHandler(btn_child_click);



                      }

                  }
                  else
                  {
                      MessageBox.Show("You have no Rights to view this Section", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  }
              
                    
            
        }

        private void bttn_activities_Click(object sender, EventArgs e)
        {
            string user = File.ReadAllText("user.txt");
            splitContainer2.Panel1.Controls.Clear();
            DataTable dtbuttons = new DataTable();
            dtbuttons = objcode.Getchildbuttons(user, "4");
            if (dtbuttons.Rows.Count > 0)
            {

                TableLayoutPanel tblypanelDetailsCenter = new System.Windows.Forms.TableLayoutPanel();
                splitContainer2.Panel1.Controls.Add(tblypanelDetailsCenter);
                tblypanelDetailsCenter.AutoSize = true;
                tblypanelDetailsCenter.ColumnCount = 1;
                tblypanelDetailsCenter.Dock = System.Windows.Forms.DockStyle.Top;
                //this.splitContainer2.Panel1.AutoScroll = true;
                //this.splitContainer2.Panel1.VerticalScroll.Visible = true;
                tblypanelDetailsCenter.Margin = new System.Windows.Forms.Padding(0);
                tblypanelDetailsCenter.Name = "tblypanelDetailsCenter";
                tblypanelDetailsCenter.Controls.Clear();
                tblypanelDetailsCenter.RowCount = dtbuttons.Rows.Count;
                for (int i = 0; i < tblypanelDetailsCenter.RowCount; i++)
                {
                    tblypanelDetailsCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, Convert.ToInt32(50)));
                }

                for (int k = 0; k < dtbuttons.Rows.Count; k++)
                {
                    Button btnchilds = new Button();
                    btnchilds.Name = "btnparent1" + k.ToString();
                    btnchilds.ForeColor = Color.FromArgb(Convert.ToInt32(dtbuttons.Rows[k]["LabelForeColor"].ToString()));
                    btnchilds.Font = new Font("Ariel", 12);
                    if (dtbuttons.Rows[k]["Formicon"] != "0x")
                    {
                        img = (byte[])dtbuttons.Rows[k]["Formicon"];
                        MemoryStream ms = new MemoryStream((byte[])dtbuttons.Rows[k]["Formicon"]);
                        if (ms.Length == 0)
                        {
                            string FilePath = Application.StartupPath + " \\formimage\\" + "DefaultImage.ico";
                            btnchilds.Image = Image.FromFile(FilePath);
                            btnchilds.ImageAlign = ContentAlignment.MiddleLeft;
                            btnchilds.TextAlign = ContentAlignment.MiddleCenter;
                            //Location = new Point(10, 15);
                            btnchilds.TextImageRelation = TextImageRelation.Overlay;
                            btnchilds.FlatStyle = FlatStyle.Flat;

                        }
                        else
                        {
                            btnchilds.Image = Image.FromStream(ms);
                            btnchilds.ImageAlign = ContentAlignment.MiddleLeft;
                            // Location = new Point(5, 15);
                            btnchilds.TextAlign = ContentAlignment.MiddleCenter;
                            btnchilds.TextImageRelation = TextImageRelation.Overlay;
                            btnchilds.Refresh();
                            btnchilds.FlatStyle = FlatStyle.Flat;
                        }
                    }
                    btnchilds.BackColor = Color.FromArgb(Convert.ToInt32(dtbuttons.Rows[k]["ButtonBackColor"].ToString()));
                    btnchilds.Text = dtbuttons.Rows[k]["DisplayName"].ToString() == "" ? dtbuttons.Rows[k]["Formname"].ToString() : dtbuttons.Rows[k]["DisplayName"].ToString();
                    btnchilds.Tag = dtbuttons.Rows[k]["Id"].ToString();
                    parentid = btnchilds.Tag.ToString();
                    btnchilds.Dock = System.Windows.Forms.DockStyle.Fill;
                    tblypanelDetailsCenter.Controls.Add(btnchilds);
                    btnchilds.Click += new System.EventHandler(btn_child_click);



                }

            }
            else
            {
                MessageBox.Show("You have no Rights to view this Section", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
              
                    
            
        }

        private void bttn_reprt_Click(object sender, EventArgs e)
        {
            string user = File.ReadAllText("user.txt");

            splitContainer2.Panel1.Controls.Clear();
            DataTable dtbuttons = new DataTable();

            dtbuttons = objcode.Getchildbuttons(user, "5");
            if (dtbuttons.Rows.Count > 0)
            {

                TableLayoutPanel tblypanelDetailsCenter = new System.Windows.Forms.TableLayoutPanel();
                splitContainer2.Panel1.Controls.Add(tblypanelDetailsCenter);
                tblypanelDetailsCenter.AutoSize = true;
                tblypanelDetailsCenter.ColumnCount = 1;
                tblypanelDetailsCenter.Dock = System.Windows.Forms.DockStyle.Top;
                //this.splitContainer2.Panel1.AutoScroll = true;
                //this.splitContainer2.Panel1.VerticalScroll.Visible = true;
                tblypanelDetailsCenter.Margin = new System.Windows.Forms.Padding(0);
                tblypanelDetailsCenter.Name = "tblypanelDetailsCenter";
                tblypanelDetailsCenter.Controls.Clear();
                tblypanelDetailsCenter.RowCount = dtbuttons.Rows.Count;
                for (int i = 0; i < tblypanelDetailsCenter.RowCount; i++)
                {
                    tblypanelDetailsCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, Convert.ToInt32(50)));
                }

                for (int k = 0; k < dtbuttons.Rows.Count; k++)
                {

                    Button btnchilds = new Button();
                    btnchilds.Name = "btnparent1" + k.ToString();
                    btnchilds.ForeColor = Color.FromArgb(Convert.ToInt32(dtbuttons.Rows[k]["LabelForeColor"].ToString()));
                    btnchilds.Font = new Font("Ariel", 12);
                    if (dtbuttons.Rows[k]["Formicon"] != "0x")
                    {
                        img = (byte[])dtbuttons.Rows[k]["Formicon"];
                        MemoryStream ms = new MemoryStream((byte[])dtbuttons.Rows[k]["Formicon"]);
                        if (ms.Length == 0)
                        {
                            string FilePath = Application.StartupPath + " \\formimage\\" + "DefaultImage.ico";
                            btnchilds.Image = Image.FromFile(FilePath);
                            btnchilds.ImageAlign = ContentAlignment.MiddleLeft;
                            btnchilds.TextAlign = ContentAlignment.MiddleCenter;
                            //Location = new Point(10, 15);
                            btnchilds.TextImageRelation = TextImageRelation.Overlay;
                            btnchilds.FlatStyle = FlatStyle.Flat;

                        }
                        else
                        {
                            btnchilds.Image = Image.FromStream(ms);
                            btnchilds.ImageAlign = ContentAlignment.MiddleLeft;
                            // Location = new Point(5, 15);
                            btnchilds.TextAlign = ContentAlignment.MiddleCenter;
                            btnchilds.TextImageRelation = TextImageRelation.Overlay;
                            btnchilds.Refresh();
                            btnchilds.FlatStyle = FlatStyle.Flat;
                        }
                    }
                    btnchilds.BackColor = Color.FromArgb(Convert.ToInt32(dtbuttons.Rows[k]["ButtonBackColor"].ToString()));
                    btnchilds.Text = dtbuttons.Rows[k]["DisplayName"].ToString() == "" ? dtbuttons.Rows[k]["Formname"].ToString() : dtbuttons.Rows[k]["DisplayName"].ToString();
                    btnchilds.Tag = dtbuttons.Rows[k]["Id"].ToString();
                    parentid = btnchilds.Tag.ToString();
                    btnchilds.Dock = System.Windows.Forms.DockStyle.Fill;
                    tblypanelDetailsCenter.Controls.Add(btnchilds);
                    btnchilds.Click += new System.EventHandler(btn_child_click);



                }

            }
            else
            {
                MessageBox.Show("You have no Rights to view this Section", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
              
                    
            
        }

        private void bttn_logout_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DialogResult dr = MessageBox.Show("you Are About to Logout ,Do U Wish to Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Userid = File.ReadAllText("User.txt");
                    //string msg = 
                    int counterid = Convert.ToInt32(File.ReadAllText("counter.txt"));
                    objcode.updatelogin(Userid, DateTime.Now,DateTime.Now , counterid, "changestatus");//Convert.ToDateTime(globalvariable.StoreDate)
                    //if (msg == " 1")
                    //{
                    //    LogoutStat = 1;
                        this.Close();
                    //}
                    ////else
                    //{
                    //    this.Close();
                    //}
                }

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);


            }
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Home_page_FormClosing(object sender, FormClosingEventArgs e)
        {

            Userid = File.ReadAllText("User.txt");
            //string msg = 
            int counterid = Convert.ToInt32(File.ReadAllText("counter.txt"));
            objcode.updatelogin(Userid, DateTime.Now,DateTime.Now, counterid, "changestatus");// Convert.ToDateTime(globalvariable.StoreDate)
        }
    }
        }


