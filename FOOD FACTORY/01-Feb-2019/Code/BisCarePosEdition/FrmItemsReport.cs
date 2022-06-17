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
    public partial class FrmItemsReport : Form
    {
        public FrmItemsReport()
        {
            InitializeComponent();
        }

        private void FrmItemsReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetItemReport.SP_Items_Report' table. You can move, or remove it, as needed.
            this.SP_Items_ReportTableAdapter.Fill(this.DataSetItemReport.SP_Items_Report);

            this.reportViewer1.RefreshReport();
        }
    }
}
