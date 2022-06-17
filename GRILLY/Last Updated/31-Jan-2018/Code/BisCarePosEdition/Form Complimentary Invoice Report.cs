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
    public partial class Form_Complimentary_Invoice_Report : Form
    {
        public Form_Complimentary_Invoice_Report(DateTime start,DateTime end)
        {
            InitializeComponent();
            st = start;
            ed = end;
           // sta = staff;
        }
        DateTime st, ed;
        int sta;
        private void Form_Complimentary_Invoice_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DB_AdhidhiDataSet.SP_COmplementary_Invoice_Reports' table. You can move, or remove it, as needed.
            this.SP_COmplementary_Invoice_ReportsTableAdapter.Fill(this.DB_AdhidhiDataSet.SP_COmplementary_Invoice_Reports,st,ed);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
