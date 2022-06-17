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
    public partial class frmDeletedInvoiceReportShort : Form
    {
        public frmDeletedInvoiceReportShort()
        {
            InitializeComponent();
        }
        
        DateTime start, end;
        public frmDeletedInvoiceReportShort(DateTime st , DateTime en)
        {
            InitializeComponent();
            start = st;
            end = en;
        }
        
        private void frmDeletedInvoiceReportShort_Load(object sender, EventArgs e)
        {
            try
            {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSet31.spReportDeletedInvoice' table. You can move, or remove it, as needed.
            this.spReportDeletedInvoiceTableAdapter.Fill(this.dbBizcarePosDataSet31.spReportDeletedInvoice, start, end);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSet31.spReportDeletedInvoiceCompliment' table. You can move, or remove it, as needed.
            this.spReportDeletedInvoiceComplimentTableAdapter.Fill(this.dbBizcarePosDataSet31.spReportDeletedInvoiceCompliment,start,end);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSet31.spReportDates' table. You can move, or remove it, as needed.
            this.spReportDatesTableAdapter.Fill(this.dbBizcarePosDataSet31.spReportDates, start, end);

            this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void frmDeletedInvoiceReportShort_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
