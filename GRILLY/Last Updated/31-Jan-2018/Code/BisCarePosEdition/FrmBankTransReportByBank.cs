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
    public partial class FrmBankTransReportByBank : Form
    {
        public FrmBankTransReportByBank()
        {
            InitializeComponent();
        }
        int Bank_id, mode;
        string type;
        DateTime StartDate,EndDate;
     
        public FrmBankTransReportByBank(int id, string typ, DateTime sdate, DateTime edate, int mod)
        {
            InitializeComponent();

            Bank_id = id;
            type = typ;
            StartDate = sdate;
            EndDate = edate;
            mode = mod;
        }
        private void FrmBankTransReportByBank_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetBankTransBank.Sp_ReportBankTransaction' table. You can move, or remove it, as needed.
            this.Sp_ReportBankTransactionTableAdapter.Fill(this.dbBizcarePosDataSetBankTransBank.Sp_ReportBankTransaction, Bank_id, type, StartDate, EndDate, mode);

            this.reportViewer1.RefreshReport();
        }
    }
}
