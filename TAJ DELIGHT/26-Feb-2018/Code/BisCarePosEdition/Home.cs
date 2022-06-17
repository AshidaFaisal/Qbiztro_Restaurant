using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace BisCarePosEdition
{
    public partial class Home : Form
    {
        private int childFormNumber = 0;

        public Home()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        Codebehind obj = new Codebehind();
        Codebehind ObjCode = new Codebehind();
        string userid;
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void itemMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Item");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["Item"] as Item) == null)
                    {
                        Item Obj = new Item();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["Item"].Focus();
                      

                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Brand Obj = new Brand();
            Obj.MdiParent = this;
            Obj.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Category");
            if (dt.Rows.Count > 0)
            {

                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    Category Obj = new Category();
                if ((Application.OpenForms["Category"] as Category) == null)
                {
                    //Form is already open
                   
                    Obj.MdiParent = this;
                    Obj.Show();
                }
                else
                {
                    Application.OpenForms["Category"].Focus();  

                }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void taxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Tax");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["Tax"] as Tax) == null)
                    {
                        Tax Obj = new Tax();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["Tax"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
   
        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Unit");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {

                    if ((Application.OpenForms["Unit"] as Unit) == null)
                    {


                        Unit Obj = new Unit();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["Unit"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            } 
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Table");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["Tables"] as Tables) == null)
                    {
                        Tables Obj = new Tables();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["Tables"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void waiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Waiter");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["waiter"] as waiter) == null)
                    {
                        waiter Obj = new waiter();
                        Obj.MdiParent = this;
                        Obj.WindowState = FormWindowState.Minimized;
                        Obj.Show();
                        Obj.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        Application.OpenForms["waiter"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           
        }
        public string na;
        private void billingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Billing");
            if (dt.Rows.Count > 0)
            {
                if ( (dt.Rows[0][1].ToString() == "1"))
                {
                    Billing Obj = new Billing();
                 //Obj.MdiParent = this;
                    Obj.Show();
                }

                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void pendingKOTsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "PendingKOT");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["PendingOT_S"] as PendingOT_S) == null)
                    {
                        PendingOT_S Obj = new PendingOT_S();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["PendingOT_S"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void deleteKOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "DeleteKOT");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["DeleteKot"] as DeleteKot) == null)
                    {
                        DeleteKot Obj = new DeleteKot();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["DeleteKot"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void searchBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            if ((Application.OpenForms["SearchBill"] as SearchBill) == null)
            {
                SearchBill Obj = new SearchBill();
                Obj.MdiParent = this;
                Obj.Show();
            }
            else
            {
                Application.OpenForms["SearchBill"].Focus();


            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void deleteBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "DeleteBill");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["DeleteBill"] as DeleteBill) == null)
                    {
                        DeleteBill Obj = new DeleteBill();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["DeleteBill"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "SalesReport");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["SalesReport"] as SalesReport) == null)
                    {
                        SalesReport Obj = new SalesReport();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["SalesReport"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void dailySalesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "DailySalesReport");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["DilySalesReport"] as DilySalesReport) == null)
                    {
                        DilySalesReport Obj = new DilySalesReport();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["DilySalesReport"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
           
        }

        private void stockEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "StockEntry");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["StockEntry"] as StockEntry) == null)
                    {
                        StockEntry Obj = new StockEntry();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["StockEntry"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void otherIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "OtherIncome");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["OtherIncomeNew"] as OtherIncomeNew) == null)
                    {
                        OtherIncomeNew Obj = new OtherIncomeNew();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["OtherIncomeNew"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
          
        }

        private void otherExpenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "OtherExpence");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["OtherExpenceNew"] as OtherExpences) == null)
                    {
                        OtherExpences Obj = new OtherExpences();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["OtherExpenceNew"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void deletedInvoiceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "DeletedInvoiceReportDetaile");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["DeletedInvoiceReport"] as DeletedInvoiceReport) == null)
                    {
                        DeletedInvoiceReport Obj = new DeletedInvoiceReport();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["DeletedInvoiceReport"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void deletedKOTReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "DeletedKOTRepot");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["ReportDeletedKotDetails"] as ReportDeletedKotDetails) == null)
                    {
                        ReportDeletedKotDetails Obj = new ReportDeletedKotDetails();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["ReportDeletedKotDetails"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void otherExpenceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "OtherExpenceReport");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["ReportOtherExpence"] as ReportOtherExpence) == null)
                    {
                        ReportOtherExpence Obj = new ReportOtherExpence();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["ReportOtherExpence"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            } 
        }

        private void otherIncomeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "OtherIncomeReport");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["ReportOtherIncome"] as ReportOtherIncome) == null)
                    {

                        ReportOtherIncome Obj = new ReportOtherIncome();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["ReportOtherIncome"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
           
        }
        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    //if (keyData == Keys.B)
        //    //{
        //    //    Billing Obj = new Billing();
        //    //    Obj.MdiParent = this;
        //    //    Obj.Show();
        //    //}
        //    //if (keyData == Keys.F2)
        //    //{
        //    //    Billing Obj = new Billing();
        //    //    Obj.MdiParent = this;
        //    //    Obj.Show();
        //    //}
        //    //if (keyData == Keys.F3)
        //    //{
        //    //    PendingOT_S Obj = new PendingOT_S();
        //    //    Obj.MdiParent = this;
        //    //    Obj.Show();
        //    //}
        //    //if (keyData == Keys.F4)
        //    //{
        //    //    DeleteKot Obj = new DeleteKot();
        //    //    Obj.MdiParent = this;
        //    //    Obj.Show();
              
        //    //}
        //    //if (keyData == Keys.F5)
        //    //{
        //    //    SearchBill Obj = new SearchBill();
        //    //    Obj.MdiParent = this;
        //    //    Obj.Show();
        //    //}
        //    //if (keyData == Keys.F6)
        //    //{
        //    //    DeleteBill Obj = new DeleteBill();
        //    //    Obj.MdiParent = this;
        //    //    Obj.Show();
        //    //}
        //    //if (keyData == Keys.F7)
        //    //{
        //    //    Item Obj = new Item();
        //    //    Obj.MdiParent = this;
        //    //    Obj.Show();
        //    //}
        //    //return base.ProcessCmdKey(ref msg, keyData);
        //}
        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void designationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           
        }

        private void userAccountTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void userRightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void counterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           try
           {
            DialogResult dr = MessageBox.Show("You Are About to Logout. Do You Wish To Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                userid = File.ReadAllText("user.txt");
                int counterid = Convert.ToInt32(File.ReadAllText("counter.txt"));
                ObjCode.updatelogin(userid, DateTime.Now, Convert.ToDateTime(globalvariable.StoreDate), counterid, "changestatus");
                //if (msg == "1")
                //{
                //    LogoutStat = 1;
                //    this.Close();
                //}
                //else
                    this.Close();
            }
           }
           catch (Exception ex)
           {
               File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
           }
        }
        int LogoutStat = 0;
        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (LogoutStat == 0)
                {
                    userid = File.ReadAllText("user.txt");
                    int counterid = Convert.ToInt32(File.ReadAllText("counter.txt"));
                    ObjCode.updatelogin(userid, DateTime.Now, Convert.ToDateTime(globalvariable.StoreDate), counterid, "changestatus");
                    //if (msg == "1")
                    //{
                    //    this.Close();
                    //}
                    //else
                        this.Close();
                    //MessageBox.Show(msg);
                }
            }
            catch
            {
                this.Close();
            }
        }

        private void clearTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           try
           {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "ClearTransactions");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                   DialogResult dr = MessageBox.Show("This will clear all your Transactions. Do you wish to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                   if (dr == DialogResult.Yes)

                   {
                      // obj.ClearTrnsactions();
                       ClearTransactions ct = new ClearTransactions();
                       ct.ShowDialog();

                       //MessageBox.Show("Transactions successfully cleared.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           }
           catch (Exception ex)
           {
               File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
           }
        }

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           try
           {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "BackUp");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][1].ToString() == "1")
                {
                    if ((Application.OpenForms["BackupDB"] as BackupDB) == null)
                    {
                        BackupDB Obj = new BackupDB();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["BackupDB"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           }
           catch (Exception ex)
           {
               File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
           }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "ResetDB");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][1].ToString() == "1")
                {
                    DialogResult dgResult = MessageBox.Show("This Will Erase All Your Data. Do You Want To Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dgResult == DialogResult.Yes)
                    {
                        ResetDB Rdb = new ResetDB();
                        
                        Rdb.ShowDialog();
                        if (Rdb.Dr == DialogResult.OK)
                            this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void passwordChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void restoreDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Restore");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["RestoreDB"] as RestoreDB) == null)
                    {
                        RestoreDB Obj = new RestoreDB();
                       // Obj.MdiParent = this;
                        Obj.ShowDialog();
                        if (Obj.dr == DialogResult.OK)
                            this.Close();
                    }
                    else
                    {
                        Application.OpenForms["RestoreDB"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void restuarantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void userAccountTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "UserAccountType");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["UserAccountType"] as UserAccountType) == null)
                    {
                        UserAccountType Obj = new UserAccountType();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["UserAccountType"].Focus();


                    }

                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
            
        }

        private void designationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Designation");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["Designation"] as Designation) == null)
                    {
                        Designation Obj = new Designation();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["Designation"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void newUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "User");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["User"] as User) == null)
                    {
                        User Obj = new User();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["User"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void paswordChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "ChangePassword");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["PasswordChange"] as PasswordChange) == null)
                    {
                        PasswordChange Obj = new PasswordChange();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["PasswordChange"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void userRightsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "UserRights");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["UserRightscs"] as UserRightscs) == null)
                    {
                        UserRightscs Obj = new UserRightscs();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["UserRightscs"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void counterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Counter");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["Counter"] as Counter) == null)
                    {
                        Counter Obj = new Counter();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["Counter"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void invoiceSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            // CloseOpenForms();
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Setting");
            if (dt.Rows.Count > 0)
            {
                //if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                //{
                //    Settings Obj = new Settings();
                //    Obj.MdiParent = this;
                //    Obj.Show();
                //}
                //else
                //{
                //    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void restuarantToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Restuarant");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["Restuarant"] as Restuarant) == null)
                    {
                        Restuarant Obj = new Restuarant();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["Restuarant"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void receipeManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "ItemMapping");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["item_mapping"] as item_mapping) == null)
                    {
                        item_mapping Obj = new item_mapping();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["item_mapping"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void adminToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            //ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            //TSMI.ForeColor = Color.Black;
        }

        private void logOutToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            //ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            //TSMI.ForeColor = Color.Red;
        }

        private void logOutToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            //ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            //TSMI.ForeColor = Color.Red;
        }

        private void menuStrip_MouseEnter(object sender, EventArgs e)
        {
            //ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            //TSMI.ForeColor = Color.Red;
        }

        private void stockReportByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "SalesReportByDate");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["SalesReportByDate"] as SalesReportByDate) == null)
                    {
                        SalesReportByDate Obj = new SalesReportByDate();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["SalesReportByDate"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "StockReport");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["StockReport"] as StockReport) == null)
                    {
                        StockReport Obj = new StockReport();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["StockReport"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
             try
             {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "StockReport");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                  dtCounterBill=  cb.ReportofStock();
                  PrintCounterBill();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             }
             catch (Exception ex)
             {
                 File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
             }

        }
        Codebehind cb = new Codebehind();
        DataTable dtCounterBill;
        Font font20 = new Font("Arial", 20, GraphicsUnit.Point);
        Font font15 = new Font("Arial", 15, GraphicsUnit.Point);
        Font font8 = new Font("Arial", 8, GraphicsUnit.Point);
        Font font9 = new Font("Arial", 9, GraphicsUnit.Point);
        Font font10 = new Font("Arial", 10, GraphicsUnit.Point);
        Font font12 = new Font("Arial", 12, GraphicsUnit.Point);
        SolidBrush sBrush = new SolidBrush(Color.Black);
        public void PrintCounterBill()
        {
            try
            {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.Doc_PrintPageCounterBill;
            //doc.PrinterSettings.PrinterName = "VENDOR THERMAL PRINTER";
            doc.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            //doc.OriginAtMargins = true;
            try
            {
                doc.Print();
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

              
                float xitemaname = 0;
                float xcat = 200;
                float xprice = 260;
               // float xquantity = 330;
                float xpurchase = 330;
                 float xtotalsale = 400;
                 float xavailablestock = 470;
                e.Graphics.DrawString("    THANINAADAN", font20, new SolidBrush(Color.Black), 0, y);
                y += lineHeight;
                e.Graphics.DrawString("  Family Restaurant", font20, new SolidBrush(Color.Black), 0, y);
                y += lineHeight;
                e.Graphics.DrawString("             Opp Petrol Pump, Kottamkulam", font10, new SolidBrush(Color.Black), 0, y);
                lineHeight = font10.GetHeight(e.Graphics);
                y += lineHeight;
                //e.Graphics.DrawString("                  Perinjanam-680686", font10, new SolidBrush(Color.Black), 0, y);
                //y += lineHeight;
                //e.Graphics.DrawString("       Email: thaninaadanfamilyrestaurant@gmail.com", font10, new SolidBrush(Color.Black), 0, y);
                //y += lineHeight;
                e.Graphics.DrawString("                  SALES  REPORT BY DATE", font12, new SolidBrush(Color.Black), 0, y);
                lineHeight = font12.GetHeight(e.Graphics);
                y += lineHeight;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(470, Convert.ToInt32(y)));

                y += 3;

                //e.Graphics.DrawString(dtable.Rows[0]["waitername"].ToString() + "  Table no. " + dtable.Rows[0]["tableno"].ToString(), font10, sBrush, 0, y);
                //lineHeight = font10.GetHeight(e.Graphics);
                //y += lineHeight;

                //e.Graphics.DrawString("Start Date: " + dtp_start.Value + ",    End Date: " + dtp_end.Value, font9, sBrush, 0, y);
                //lineHeight = font9.GetHeight(e.Graphics);
                //y += lineHeight;

                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(470, Convert.ToInt32(y)));
                y += 3;
                //e.Graphics.DrawString("KotNo", font9, sBrush, xSlno, y);
                //e.Graphics.DrawString("Bill Type", font9, sBrush, xbilltype, y);
                e.Graphics.DrawString("Category", font9, sBrush, xcat, y);
                e.Graphics.DrawString("Item Name", font9, sBrush, xitemaname, y);
                e.Graphics.DrawString("Unit", font9, sBrush, xprice, y);
                e.Graphics.DrawString("Total Purchase", font9, sBrush, xpurchase, y);
                e.Graphics.DrawString("Total Sale", font9, sBrush, xtotalsale, y);
                e.Graphics.DrawString("Available Stock", font9, sBrush, xavailablestock, y);
                //e.Graphics.DrawString("Deleted Kot Date", font9, sBrush, xdate, y);
                y += lineHeight;
                y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(470, Convert.ToInt32(y)));
                y += 3;

                double total = 0;
                lineHeight = font8.GetHeight(e.Graphics);
                int slnum = 1;
                for (int i = 0; i < dtCounterBill.Rows.Count; i++)
                {
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["KOTNo"].ToString(), font8, sBrush, xSlno, y);
                    //e.Graphics.DrawString(dtCounterBill.Rows[i]["Status1"].ToString(), font9, sBrush, xbilltype, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["Category"].ToString(), font9, sBrush, xcat, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["ItemName"].ToString(), font8, sBrush, xitemaname, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["Unit"].ToString(), font8, sBrush, xprice, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["TotalPurchase"].ToString(), font9, sBrush, xpurchase, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["TotalSale"].ToString(), font9, sBrush, xtotalsale, y);
                    e.Graphics.DrawString(dtCounterBill.Rows[i]["AvailableStock"].ToString(), font9, sBrush, xavailablestock, y);

                    //total += Convert.ToDouble(dtCounterBill.Rows[i]["amount"]);
                    //slnum += 1;
                    //y += lineHeight;
                }
                //tot = total;
                //y += 3;
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, Convert.ToInt32(y)), new Point(470, Convert.ToInt32(y)));
                y += 7;
                //e.Graphics.DrawString("Total : Rs." + total.ToString("F2"), font15, sBrush, 40, y);
                //lineHeight = font20.GetHeight(e.Graphics);
                //y += lineHeight;
                //e.Graphics.DrawString("   This bill incl. all establish and service charge.", font9, sBrush, 0, y);
                //y += lineHeight;
                e.Graphics.DrawString("              Thank you, See you soon.", font10, sBrush, 0, y);
            }

        }

        private void deletedInvoiceReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "DeletedInvoiceReport");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    if ((Application.OpenForms["DeletedInvoiceReport"] as DeletedInvoiceReport) == null)
                    {
                        DeletedInvoiceReportShort Obj = new DeletedInvoiceReportShort();
                        Obj.MdiParent = this;
                        Obj.Show();
                    }
                    else
                    {
                        Application.OpenForms["DeletedInvoiceReport"].Focus();


                    }
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }                                 

        }

        private void touchBillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TouchBilling ObjTouch = new TouchBilling();
            //ObjTouch.ShowDialog();
        }

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }

    }
}
