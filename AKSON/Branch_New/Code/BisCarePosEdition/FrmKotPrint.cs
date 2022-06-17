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
    public partial class FrmKotPrint : Form
    {
        string id,tok;
        int counter;
        public FrmKotPrint()
        {
            InitializeComponent();
        }
        public FrmKotPrint(string kotid,int cid)
        {
            InitializeComponent();
            id = kotid;
           counter = cid;
        }

        private void FrmKotPrint_Load(object sender, EventArgs e)
        {
            try
            {
            // TODO: This line of code loads data into the 'dbBizcarePosOldDataSet.sp_EditCounter' table. You can move, or remove it, as needed.
            this.sp_EditCounterTableAdapter.Fill(this.dbBizcarePosOldDataSet.sp_EditCounter,counter);
           
                // TODO: This line of code loads data into the 'dbBizcarePosDataSet5.spPrintKot' table. You can move, or remove it, as needed.
                this.spPrintKotTableAdapter.Fill(this.dbBizcarePosDataSet5.spPrintKot, Convert.ToInt32(id));

           // TODO: This line of code loads data into the 'dbBizcarePosDataSet6.SpgetRestaurent' table. You can move, or remove it, as needed.
            this.SpgetRestaurentTableAdapter.Fill(this.dbBizcarePosDataSet6.SpgetRestaurent);

            this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void FrmKotPrint_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
