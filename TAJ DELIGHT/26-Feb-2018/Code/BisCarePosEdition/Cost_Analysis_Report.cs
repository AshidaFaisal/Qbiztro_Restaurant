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
    public partial class Cost_Analysis_Report : Form
    {
        public Cost_Analysis_Report()
        {
            InitializeComponent();
        }

        private void Cost_Analysis_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DB_QbiztroDataSet.SP_Cost_Analysis_Report' table. You can move, or remove it, as needed.
            this.SP_Cost_Analysis_ReportTableAdapter.Fill(this.DB_QbiztroDataSet.SP_Cost_Analysis_Report);

            this.reportViewer1.RefreshReport();
        }
    }
}
