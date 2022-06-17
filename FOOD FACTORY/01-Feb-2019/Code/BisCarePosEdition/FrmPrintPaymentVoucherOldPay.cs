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
    public partial class FrmPrintPaymentVoucherOldPay : Form
    {
        public FrmPrintPaymentVoucherOldPay()
        {
            InitializeComponent();
        }
        int PID;
        public FrmPrintPaymentVoucherOldPay(int ID)
        {
            InitializeComponent();
            PID = ID;
        }
        private void FrmPrintPaymentVoucherOldPay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetPrintPaymentVMasterold.Sp_PrintPaymentVoucherMasterOldPay' table. You can move, or remove it, as needed.
            this.Sp_PrintPaymentVoucherMasterOldPayTableAdapter.Fill(this.dbBizcarePosDataSetPrintPaymentVMasterold.Sp_PrintPaymentVoucherMasterOldPay, PID);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetPrintPaymentVDetailsOld.Sp_PrintPaymentVoucherDetailsOldPay' table. You can move, or remove it, as needed.
            this.Sp_PrintPaymentVoucherDetailsOldPayTableAdapter.Fill(this.dbBizcarePosDataSetPrintPaymentVDetailsOld.Sp_PrintPaymentVoucherDetailsOldPay, PID);

            this.reportViewer1.RefreshReport();
        }
    }
}
