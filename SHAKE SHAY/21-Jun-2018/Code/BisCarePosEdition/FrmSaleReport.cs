using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;


namespace BisCarePosEdition
{
    public partial class FrmSaleReport : Form
    {
        public FrmSaleReport()
        {
            InitializeComponent();
        }
        DateTime start, end;
        int item, cat, waiter, getsaletype, cashierid;
           
        int mode;
        string stype, cashiername;

        public FrmSaleReport(int item1, int cat1, int mode1, int waiter1, string start1, DateTime end1, int getsaletype1,  int cashierid1, string cashiername1)
        {
            InitializeComponent();
            start = Convert.ToDateTime(start1);
            end = end1;
            mode = mode1;
            cat = cat1;
            item = item1;
            waiter = waiter1;
            getsaletype = getsaletype1;
            stype = getsaletypee(getsaletype);
            cashierid = cashierid1;
            cashiername = cashiername1;
        }
        public string getsaletypee(int saletypee)
        {
            string k = "  ";
            if (saletypee == 2)
            {
                k = "( CASH SALES )";
            }
            else if (saletypee == 3)
            {
                k = "( CREDIT SALES )";
            }

            return k;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }
        
       
        private void FrmSaleReport_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbBizcarePosDataSet2.spReportDates' table. You can move, or remove it, as needed.
                this.spReportDatesTableAdapter.Fill(this.dbBizcarePosDataSet2.spReportDates, start, end);
                // TODO: This line of code loads data into the 'dbBizcarePosDataSet24.spSalesReport' table. You can move, or remove it, as needed.
                this.spSalesReportTableAdapter.Fill(this.dbBizcarePosDataSet24.spSalesReport, start, end, mode, cat, item, waiter, getsaletype, cashierid);
                // TODO: This line of code loads data into the 'dbBizcarePosDataSet25.spSalesReportCompliment' table. You can move, or remove it, as needed.
                this.spSalesReportComplimentTableAdapter.Fill(this.dbBizcarePosDataSet25.spSalesReportCompliment, start, end, mode, cat, item, waiter, getsaletype, cashierid);
                //// TODO: This line of code loads data into the 'dbBizcarePosDataSet2.spReportDates' table. You can move, or remove it, as needed.
                //this.spReportDatesTableAdapter.Fill(this.dbBizcarePosDataSet2.spReportDates,start,end);
                //// TODO: This line of code loads data into the 'dbBizcarePosDataSetReportSales.spSalesReport' table. You can move, or remove it, as needed.
                //this.spSalesReportTableAdapter.Fill(this.dbBizcarePosDataSetReportSales.spSalesReport,start,end,mode,cat,item,waiter);   

                ReportParameter[] param = new ReportParameter[1];
                param[0] = new ReportParameter("saletype", stype);
                reportViewer1.LocalReport.SetParameters(param);

                string Cashier = "";
                if (cashierid > 0) // if user selected
                    Cashier = "Cashier : " + cashiername;
                ReportParameter[] param2 = new ReportParameter[1];
                param2[0] = new ReportParameter("Cashier", Cashier);
                reportViewer1.LocalReport.SetParameters(param2);

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


            this.reportViewer1.RefreshReport();
        }

        private void FrmSaleReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
