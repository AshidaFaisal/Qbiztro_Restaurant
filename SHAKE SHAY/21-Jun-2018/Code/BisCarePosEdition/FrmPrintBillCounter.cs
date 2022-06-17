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
    public partial class FrmPrintBillCounter : Form
    {
        public FrmPrintBillCounter()
        {
            InitializeComponent();
        }
        string invoice;
        int counter;
        public FrmPrintBillCounter(string msg, int coun)
        {
            InitializeComponent();
            invoice = msg;
            counter = coun;
        }

        private void FrmPrintBillCounter_Load(object sender, EventArgs e)
        {
            try
            {
          
            // TODO: This line of code loads data into the 'dbBizcarePosDataSet19.SpgetRestaurent' table. You can move, or remove it, as needed.
            this.SpgetRestaurentTableAdapter.Fill(this.dbBizcarePosDataSet19.SpgetRestaurent);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSet23.spPrintBillCounter' table. You can move, or remove it, as needed.
            this.spPrintBillCounterTableAdapter.Fill(this.dbBizcarePosDataSet23.spPrintBillCounter, invoice);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSet33.sp_EditCounter' table. You can move, or remove it, as needed.
            this.sp_EditCounterTableAdapter.Fill(this.dbBizcarePosDataSet33.sp_EditCounter, counter);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetGetInvoiceAMnt.SpGetInvoiceAmounts' table. You can move, or remove it, as needed.
            this.SpGetInvoiceAmountsTableAdapter.Fill(this.dbBizcarePosDataSetGetInvoiceAMnt.SpGetInvoiceAmounts, invoice);
           

            this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void FrmPrintBillCounter_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
