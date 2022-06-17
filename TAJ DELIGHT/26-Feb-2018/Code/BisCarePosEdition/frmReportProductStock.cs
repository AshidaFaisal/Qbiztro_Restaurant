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
    public partial class frmReportProductStock : Form
    {
        public frmReportProductStock()
        {
            InitializeComponent();
        }
        DateTime start, end;
        int item, cat;

        int mode;



        public frmReportProductStock(DateTime start1, DateTime end1, int mode1, int cat1, int item1)
        {
            InitializeComponent();
            start =start1;
            end = end1;
            mode = mode1;
            cat = cat1;
            item = item1;
           
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void frmReportProductStock_Load( object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'DataSet_ReportProductStock.SP_R_ProductStockReport' table. You can move, or remove it, as needed.
                this.SP_R_ProductStockReportTableAdapter.Fill(this.DataSet_ReportProductStock.SP_R_ProductStockReport, start, end, mode, cat, item);
                // TODO: This line of code loads data into the 'dbBizcarePosDataSet2.spReportDates' table. You can move, or remove it, as needed.
                this.spReportDatesTableAdapter.Fill(this.dbBizcarePosDataSet2.spReportDates, start, end);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        private void FrmSaleReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
