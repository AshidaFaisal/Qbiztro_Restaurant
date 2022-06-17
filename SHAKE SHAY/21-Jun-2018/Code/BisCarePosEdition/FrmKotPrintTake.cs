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
    public partial class FrmKotPrintTake : Form
    {
        public FrmKotPrintTake()
        {
            InitializeComponent();
        }
        string kotid;
        int counter;
        public FrmKotPrintTake(string kot, int coun)
        {
            InitializeComponent();
            kotid=kot;
            counter = coun;
        }

        private void FrmKotPrintTake_Load(object sender, EventArgs e)
        {
            try
            {
            // TODO: This line of code loads data into the 'dbBizcarePosOldDataSet2.sp_EditCounter' table. You can move, or remove it, as needed.
            this.sp_EditCounterTableAdapter.Fill(this.dbBizcarePosOldDataSet2.sp_EditCounter,counter);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSet7.spPrintKotTake' table. You can move, or remove it, as needed.
            this.spPrintKotTakeTableAdapter.Fill(this.dbBizcarePosDataSet7.spPrintKotTake,Convert.ToInt32(kotid));
            // TODO: This line of code loads data into the 'dbBizcarePosDataSet7.SpgetRestaurent' table. You can move, or remove it, as needed.
            this.SpgetRestaurentTableAdapter.Fill(this.dbBizcarePosDataSet7.SpgetRestaurent);

            this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void FrmKotPrintTake_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
