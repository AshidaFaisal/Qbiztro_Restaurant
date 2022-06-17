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
    public partial class Frmsaleanalysisreport1 : Form
    {
        public Frmsaleanalysisreport1(DateTime st,DateTime ed)
        {
            InitializeComponent();
            start = st;
            end = ed;
        }
        DateTime start, end;
        private void Frmsaleanalysisreport1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DB_QbiztroDataSet1.SP_SALE_ANALYSIS_REPORT' table. You can move, or remove it, as needed.
            this.SP_SALE_ANALYSIS_REPORTTableAdapter.Fill(this.DB_QbiztroDataSet1.SP_SALE_ANALYSIS_REPORT,start,end);

            this.reportViewer1.RefreshReport();
        }
    }
}
