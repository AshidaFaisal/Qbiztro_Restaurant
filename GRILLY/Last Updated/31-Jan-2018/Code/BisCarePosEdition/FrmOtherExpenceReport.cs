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
    public partial class FrmOtherExpenceReport : Form
    {
        public FrmOtherExpenceReport()
        {
            InitializeComponent();
        }
        DateTime start, end;
        int mode;
        string type;
        public FrmOtherExpenceReport(DateTime end1, string start1, string type1, int mode1)
        {
            InitializeComponent();
            start = Convert.ToDateTime(start1);
            end = end1;
            type = type1;
            mode = mode1;
        }
        private void FrmOtherExpenceReport_Load(object sender, EventArgs e)
        {
            try
            {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetReportOtherExpenceType.spReportOtherExpence' table. You can move, or remove it, as needed.
            this.spReportOtherExpenceTableAdapter.Fill(this.dbBizcarePosDataSetReportOtherExpenceType.spReportOtherExpence, start, end, type, mode);

            this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void FrmOtherExpenceReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
