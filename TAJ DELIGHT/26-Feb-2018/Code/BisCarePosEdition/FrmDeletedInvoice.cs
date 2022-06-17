using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace BisCarePosEdition
{
    public partial class FrmDeletedInvoice : Form
    {
        public FrmDeletedInvoice()
        {
            InitializeComponent();
        }
        DateTime start, end;
        public FrmDeletedInvoice(DateTime end1,string start1)
        {
            InitializeComponent();
            start = Convert.ToDateTime(start1);
            end = end1;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void FrmDeletedInvoice_Load(object sender, EventArgs e)
        {
            try
            {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetReportDeletedInvoiceDetailsnew.spReportDeletedInvoiceDetails' table. You can move, or remove it, as needed.
           // this.spReportDeletedInvoiceDetailsTableAdapter.Fill(this.dbBizcarePosDataSetReportDeletedInvoiceDetailsnew.spReportDeletedInvoiceDetails);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSet.spReportDates' table. You can move, or remove it, as needed.
            this.spReportDatesTableAdapter.Fill(this.dbBizcarePosDataSet.spReportDates,start,end);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSet28.spReportDeletedInvoice' table. You can move, or remove it, as needed.
            this.spReportDeletedInvoiceTableAdapter.Fill(this.dbBizcarePosDataSet28.spReportDeletedInvoice, start, end);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSet29.spReportDeletedInvoiceCompliment' table. You can move, or remove it, as needed.
            this.spReportDeletedInvoiceComplimentTableAdapter.Fill(this.dbBizcarePosDataSet29.spReportDeletedInvoiceCompliment, start, end);
           // // TODO: This line of code loads data into the 'dbBizcarePosDataSet.spReportDates' table. You can move, or remove it, as needed.
           //// this.spReportDatesTableAdapter.Fill(this.dbBizcarePosDataSet.spReportDates,start,end);
           //// // TODO: This line of code loads data into the 'dbBizcarePosDataSetReportDeletedInvoiceDetailsnew.spReportDeletedInvoiceDetails' table. You can move, or remove it, as needed.
            //this.spReportDeletedInvoiceDetailsTableAdapter.Fill(this.dbBizcarePosDataSetReportDeletedInvoiceDetailsnew.spReportDeletedInvoiceDetails);
           //// // TODO: This line of code loads data into the 'dbBizcarePosDataSetReportDeletedInvoiceMstr.spReportDeletedInvoice' table. You can move, or remove it, as needed.
           //// this.spReportDeletedInvoiceTableAdapter.Fill(this.dbBizcarePosDataSetReportDeletedInvoiceMstr.spReportDeletedInvoice,start,end);
           this.reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubreportProcessingEventHandler);


           this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }
        void SubreportProcessingEventHandler(object sender, SubreportProcessingEventArgs e)
        {
            try
            {
            int Id = Convert.ToInt32(e.Parameters["Id"].Values[0]);
            this.spReportDeletedInvoiceDetailsTableAdapter.Fill(this.dbBizcarePosDataSetReportDeletedInvoiceDetailsnew.spReportDeletedInvoiceDetails, Id);
            e.DataSources.Add(new ReportDataSource("DataSet1", (DataTable)this.dbBizcarePosDataSetReportDeletedInvoiceDetailsnew.spReportDeletedInvoiceDetails));
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


            }

        private void FrmDeletedInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
