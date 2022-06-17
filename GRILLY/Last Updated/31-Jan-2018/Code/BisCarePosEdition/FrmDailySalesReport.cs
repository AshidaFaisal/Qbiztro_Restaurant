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
    public partial class FrmDailySalesReport : Form
    {
        public FrmDailySalesReport()
        {
            InitializeComponent();
        }
        int mode, status;
        //DateTime st, en;
        public FrmDailySalesReport(int mode1,int status1/*,DateTime start,DateTime end*/)
        {

            InitializeComponent();
            mode = mode1;
            status = status1;
            //st = start;
            //en = end;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void FrmDailySalesReport_Load(object sender, EventArgs e)
        {try
        {
            
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetReportDailySalesReport.spGetDailySaleReport' table. You can move, or remove it, as needed.
            this.spGetDailySaleReportTableAdapter.Fill(this.dbBizcarePosDataSetReportDailySalesReport.spGetDailySaleReport,mode,status);

            this.reportViewer1.RefreshReport();
        }
        catch (Exception ex)
        {
            File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
        }


        }

        private void FrmDailySalesReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
