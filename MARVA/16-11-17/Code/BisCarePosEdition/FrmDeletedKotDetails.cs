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
    public partial class FrmDeletedKotDetails : Form
    {
        public FrmDeletedKotDetails()
        {
            InitializeComponent();
        }
        DateTime start, end;
        public FrmDeletedKotDetails(string start1,DateTime end1)
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
        private void FrmDeletedKotDetails_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbBizcarePosDataSet1.spReportDates' table. You can move, or remove it, as needed.
                this.spReportDatesTableAdapter.Fill(this.dbBizcarePosDataSet1.spReportDates, start, end);
                // TODO: This line of code loads data into the 'dbBizcarePosDataSetReportDeleatedKotDetails.spReportDeletedKotDetail' table. You can move, or remove it, as needed.
                this.spReportDeletedKotDetailTableAdapter.Fill(this.dbBizcarePosDataSetReportDeleatedKotDetails.spReportDeletedKotDetail, start, end);
                // TODO: This line of code loads data into the 'dbBizcarePosDataSetReportDeleatedKotDetails.spReportDeletedKotDetail' table. You can move, or remove it, as needed.


                this.reportViewer1.RefreshReport();
            }
 catch (Exception ex)
 {
     File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
 }


        }

        private void FrmDeletedKotDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
