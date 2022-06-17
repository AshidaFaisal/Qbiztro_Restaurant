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
    public partial class FrmPrintBill : Form
    {
        public FrmPrintBill()
        {
            InitializeComponent();
        }
        string invoice;
        int cid;
        public FrmPrintBill(string msg,int coid)
        {
            InitializeComponent();
            invoice = msg;
            cid=coid;
        }

        private void FrmPrintBill_Load(object sender, EventArgs e)
        {
            try
            {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSet18.SpgetRestaurent' table. You can move, or remove it, as needed.
            this.SpgetRestaurentTableAdapter.Fill(this.dbBizcarePosDataSet18.SpgetRestaurent);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSet22.spPrintBill' table. You can move, or remove it, as needed.
            this.spPrintBillTableAdapter.Fill(this.dbBizcarePosDataSet22.spPrintBill,invoice);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSet32.sp_EditCounter' table. You can move, or remove it, as needed.
            this.sp_EditCounterTableAdapter.Fill(this.dbBizcarePosDataSet32.sp_EditCounter, cid);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetGetIvoiceAmount.SpGetInvoiceAmounts' table. You can move, or remove it, as needed.
            this.SpGetInvoiceAmountsTableAdapter.Fill(this.dbBizcarePosDataSetGetIvoiceAmount.SpGetInvoiceAmounts, invoice);
            

         
          

            this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void FrmPrintBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
