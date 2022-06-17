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
    public partial class FrmDeletedComplimentaryReport : Form
    {
        public FrmDeletedComplimentaryReport()
        {
            InitializeComponent();
        }
        DateTime st, en; 
        public FrmDeletedComplimentaryReport(DateTime end,DateTime start)
        {
            InitializeComponent();
            st = start;
            en = end;
        }

        private void FrmDeletedComplimentaryReport_Load(object sender, EventArgs e)
        {
           try
           {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSet29.spReportDeletedInvoiceCompliment' table. You can move, or remove it, as needed.
            this.spReportDeletedInvoiceComplimentTableAdapter.Fill(this.dbBizcarePosDataSet29.spReportDeletedInvoiceCompliment,st,en);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSet30.spGetRestuarant' table. You can move, or remove it, as needed.
            this.spGetRestuarantTableAdapter.Fill(this.dbBizcarePosDataSet30.spGetRestuarant);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSet.spReportDates' table. You can move, or remove it, as needed.
            this.spReportDatesTableAdapter.Fill(this.dbBizcarePosDataSet.spReportDates, st, en);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetReportDeletedInvoiceDetailsnew.spReportDeletedInvoiceDetails' table. You can move, or remove it, as needed.
           // this.spReportDeletedInvoiceDetailsTableAdapter.Fill(this.dbBizcarePosDataSetReportDeletedInvoiceDetailsnew.spReportDeletedInvoiceDetails);
            //// TODO: This line of code loads data into the 'dbBizcarePosDataSet29.spReportDeletedInvoiceCompliment' table. You can move, or remove it, as needed.
            //this.spReportDeletedInvoiceComplimentTableAdapter.Fill(this.dbBizcarePosDataSet29.spReportDeletedInvoiceCompliment,st,en);
            //// TODO: This line of code loads data into the 'dbBizcarePosDataSet30.spGetRestuarant' table. You can move, or remove it, as needed.
            //this.spGetRestuarantTableAdapter.Fill(this.dbBizcarePosDataSet30.spGetRestuarant);
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

        private void FrmDeletedComplimentaryReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }

    }
}
