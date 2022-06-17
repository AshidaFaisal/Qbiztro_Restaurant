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
    public partial class FrmPrintPayableRecievable : Form
    {
        public FrmPrintPayableRecievable()
        {
            InitializeComponent();
        }
        DateTime StartDate, Enddate;
        int Custid, Statchk, Mode;

        public FrmPrintPayableRecievable(DateTime strt, DateTime end, int id, int mod, int chk)
        {
            InitializeComponent();

            StartDate = strt;
            Enddate = end;
            Custid = id;
            Statchk = chk;
            Mode = mod;
        }
        private void FrmPrintPayableRecievable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetReceivableReport.spReportRecievable' table. You can move, or remove it, as needed.
            this.spReportRecievableTableAdapter.Fill(this.dbBizcarePosDataSetReceivableReport.spReportRecievable, StartDate, Enddate, Custid, Mode);

            this.reportViewer1.RefreshReport();
        }
    }
}
