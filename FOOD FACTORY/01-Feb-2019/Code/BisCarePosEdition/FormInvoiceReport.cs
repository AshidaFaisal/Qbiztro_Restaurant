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
    public partial class FormInvoiceReport : Form
    {
        public FormInvoiceReport(DateTime start,DateTime end)
        {
            InitializeComponent();
            st = start;
            ed = end;

        }
        DateTime st, ed;
        private void FormInvoiceReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DB_AdhidhiDataSetinvoice.SP_Invoice_Reports' table. You can move, or remove it, as needed.
            this.SP_Invoice_ReportsTableAdapter.Fill(this.DB_AdhidhiDataSetinvoice.SP_Invoice_Reports, st, ed);

            this.reportViewer1.RefreshReport();
        }
    }
}
