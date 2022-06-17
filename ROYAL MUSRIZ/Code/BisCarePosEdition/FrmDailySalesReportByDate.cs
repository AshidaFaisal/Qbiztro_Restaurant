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
    public partial class FrmDailySalesReportByDate : Form
    {
        public FrmDailySalesReportByDate()
        {
            InitializeComponent();
        }
        int mode, status, getsaletype;
        DateTime st, en;
        string stype;
        public FrmDailySalesReportByDate(int mode1, int status1, DateTime start, DateTime end, int getsaletype1)
        {

            InitializeComponent();
            mode = mode1;
            status = status1;
            st = start;
            en = end;
            getsaletype = getsaletype1;
            stype = getsaletypee(getsaletype);
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

        private void FrmDailySalesReportByDate_Load(object sender, EventArgs e)
        {
            try
            {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSet26.spGetDailySaleReportByDate' table. You can move, or remove it, as needed.
                this.spGetDailySaleReportByDateTableAdapter.Fill(this.dbBizcarePosDataSet26.spGetDailySaleReportByDate, mode, status, st, en, getsaletype);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSet27.spGetDailySaleReportByDateCompliment' table. You can move, or remove it, as needed.
                this.spGetDailySaleReportByDateComplimentTableAdapter.Fill(this.dbBizcarePosDataSet27.spGetDailySaleReportByDateCompliment, mode, status, st, en, getsaletype);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetGetInvoiceMstrAmount.SpGetInvoiceMasterAmounts' table. You can move, or remove it, as needed.
                this.SpGetInvoiceMasterAmountsTableAdapter.Fill(this.dbBizcarePosDataSetGetInvoiceMstrAmount.SpGetInvoiceMasterAmounts, mode, status, st, en);

                ReportParameter[] param = new ReportParameter[1];
                param[0] = new ReportParameter("saletype", stype);
                reportViewer1.LocalReport.SetParameters(param);

            this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
            

        }

        private void FrmDailySalesReportByDate_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
