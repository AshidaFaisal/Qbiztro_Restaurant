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
    public partial class StockReport : Form
    {
        public StockReport()
        {
            InitializeComponent();
        }
        int mode;
        public StockReport(int mode1)
        {
            InitializeComponent();
            mode = mode1;
        }
        private void StockReport_Load(object sender, EventArgs e)
        {
            try
            {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetStkReportnew.spGetStock' table. You can move, or remove it, as needed.
            this.spGetStockTableAdapter.Fill(this.dbBizcarePosDataSetStkReportnew.spGetStock,mode);
          
                // TODO: This line of code loads data into the 'dbBizcarePosDataSet3.spGetStock' table. You can move, or remove it, as needed.
            //this.spGetStockTableAdapter.Fill(this.dbBizcarePosDataSet3.spGetStock);

            this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void reportViewer1_ReportRefresh(object sender, CancelEventArgs e)
        {
            try
            {
           // this.spGetStockTableAdapter.Fill(this.dbBizcarePosDataSet3.spGetStock);

            this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
