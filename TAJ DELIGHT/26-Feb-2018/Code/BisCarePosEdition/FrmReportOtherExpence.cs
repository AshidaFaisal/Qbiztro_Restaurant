using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BisCarePosEdition
{
    public partial class FrmReportOtherExpence : Form
    {
        public FrmReportOtherExpence()
        {
            InitializeComponent();
        }
        DateTime start, end;
        int mode;
        string type;
        public FrmReportOtherExpence(DateTime end1,string start1,string type1,int mode1)
        {
            InitializeComponent();
            start = Convert.ToDateTime(start1);
            end = end1;
            type = type1;
            mode = mode1;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void FrmReportOtherExpence_Load(object sender, EventArgs e)
        {
            try
            {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetReportOtherExpence.spReportOtherExpence' table. You can move, or remove it, as needed.
            this.spReportOtherExpenceTableAdapter.Fill(this.dbBizcarePosDataSetReportOtherExpence.spReportOtherExpence,start,end,type,mode);

            this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void FrmReportOtherExpence_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
