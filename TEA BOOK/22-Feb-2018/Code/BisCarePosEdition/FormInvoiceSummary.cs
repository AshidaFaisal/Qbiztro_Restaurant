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
    public partial class FormInvoiceSummary : Form
    {
        public FormInvoiceSummary()
        {
            InitializeComponent();
        }
        DateTime start, end;

        public FormInvoiceSummary(DateTime end1, string start1)
        {
            InitializeComponent();
            start = Convert.ToDateTime(start1);
            end = end1;

        }
        private void FormInvoiceSummary_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'InvoiceReport.spReportInvoiceSummary' table. You can move, or remove it, as needed.
                this.spReportInvoiceSummaryTableAdapter.Fill(this.InvoiceReport.spReportInvoiceSummary, start, end);
                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
            }
        }
    }
}
