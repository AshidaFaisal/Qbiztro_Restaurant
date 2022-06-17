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
    public partial class FrmGoodsReceiptBrief : Form
    {
        public FrmGoodsReceiptBrief()
        {
            InitializeComponent();
        }

        int dealer, item, mode;
        DateTime start, end;
        public FrmGoodsReceiptBrief(int deal, int itm, int mod, DateTime st, DateTime en)
        {
            InitializeComponent();
            dealer = deal;
            item = itm;
            mode = mod;
            start = st;
            end = en;
        }

        private void FrmGoodsReceiptBrief_Load(object sender, EventArgs e)
        {

            try
            {
                // TODO: This line of code loads data into the 'dbBizcarePosDataSet34.spReportGoodsReceipt' table. You can move, or remove it, as needed.

                //this.spReportGoodsReceiptTableAdapter.Fill(this.dbBizcarePosDataSet34.spReportGoodsReceipt, dealer, start, end, item, mode);
                this.spReportGoodsReceiptTableAdapter.Fill(this.dbBizcarePosDataSet34.spReportGoodsReceipt, dealer, start, end, item, mode);
                this.reportViewer1.RefreshReport();
            }

            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

      
        }
        //void SubreportProcessingEventHandler(object sender, SubreportProcessingEventArgs e)
        //{
        //    int Id = Convert.ToInt32(e.Parameters["Id"].Values[0]);
        //    this.SpReportGoodsReceiptDetaildTableAdapter.Fill(this.dbBizcarePosDataSet35.SpReportGoodsReceiptDetaild, Id);
        //    e.DataSources.Add(new ReportDataSource("DataSet1", (DataTable)this.dbBizcarePosDataSet35.SpReportGoodsReceiptDetaild));
        //}

        private void FrmGoodsReceiptMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }

        private void FrmGoodsReceiptBrief_SizeChanged(object sender, EventArgs e)
        {
            reportViewer1.Width = this.Width - 20;
            reportViewer1.Height = this.Height - 20;
        }

        private void reportViewer1_SizeChanged(object sender, EventArgs e)
        {
            reportViewer1.Width = this.Width - 20;
            reportViewer1.Height = this.Height - 20;

        }


    }
}
