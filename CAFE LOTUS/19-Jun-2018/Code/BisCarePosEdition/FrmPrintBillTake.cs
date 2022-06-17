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
    public partial class FrmPrintBillTake : Form
    {
        public FrmPrintBillTake()
        {
            InitializeComponent();
        }

        private void FrmPrintBillTake_Load(object sender, EventArgs e)
        {
            try
            {
            this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void FrmPrintBillTake_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }

    }
}
