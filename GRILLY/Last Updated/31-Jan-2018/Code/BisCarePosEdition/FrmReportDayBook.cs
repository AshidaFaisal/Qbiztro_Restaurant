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
    public partial class FrmReportDayBook : Form
    {
        public FrmReportDayBook()
        {
            InitializeComponent();
        }
        DateTime StartDate, EndDate;
        public FrmReportDayBook(DateTime Start, DateTime End)
        {
            InitializeComponent();
            StartDate = Start;
            EndDate = End;
        }
        private void FrmReportDayBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetDayBookReport.spDayBook' table. You can move, or remove it, as needed.
            this.spDayBookTableAdapter.Fill(this.dbBizcarePosDataSetDayBookReport.spDayBook, StartDate, EndDate);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetDayBookBasic.spDayBookBasic' table. You can move, or remove it, as needed.
            this.spDayBookBasicTableAdapter.Fill(this.dbBizcarePosDataSetDayBookBasic.spDayBookBasic, StartDate, EndDate);

            this.reportViewer1.RefreshReport();
        }
    }
}
