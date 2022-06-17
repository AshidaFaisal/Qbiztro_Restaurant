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
    public partial class FrmReportPayable : Form
    {
        public FrmReportPayable()
        {
            InitializeComponent();
        }
        DateTime StartDate, Enddate;
        int Custid, Statchk, Mode;
        public FrmReportPayable(DateTime strt, DateTime end, int id, int mod, int chk)
        {
            InitializeComponent();
            StartDate = strt;
            Enddate = end;
            Custid = id;
            Statchk = chk;
            Mode = mod;
        }
        private void FrmReportPayable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetPayableReport.spReportPayable' table. You can move, or remove it, as needed.
            this.spReportPayableTableAdapter.Fill(this.dbBizcarePosDataSetPayableReport.spReportPayable, StartDate, Enddate, Custid, Mode);
            this.reportViewer1.RefreshReport();
        }
    }
}
