using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BisCarePosEdition
{
    public partial class FrmDiscountReport : Form
    {
        public FrmDiscountReport()
        {
            InitializeComponent();
        }
         DateTime start, end;
        public FrmDiscountReport(DateTime st , DateTime en)
        {
            InitializeComponent();
            start = st;
            end = en;
        }
        private void FrmDiscountReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS_DiscountReport.SP_R_InvoiceDiscount' table. You can move, or remove it, as needed.
            this.SP_R_InvoiceDiscountTableAdapter.Fill(this.DS_DiscountReport.SP_R_InvoiceDiscount, start, end);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSet31.spReportDates' table. You can move, or remove it, as needed.
            this.spReportDatesTableAdapter.Fill(this.dbBizcarePosDataSet31.spReportDates, start, end);
            //this.spReportDatesTableAdapter.Fill(this.dbBizcarePosDataSet31.spReportDates, start, end);
            this.reportViewer1.RefreshReport();
        }
        private void FrmDiscountReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
