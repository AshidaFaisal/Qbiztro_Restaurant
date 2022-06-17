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
    public partial class FrmPrintPaymentVoucherOldPayOther : Form
    {
        public FrmPrintPaymentVoucherOldPayOther()
        {
            InitializeComponent();
        }
        int PID;
        public FrmPrintPaymentVoucherOldPayOther(int ID)
        {
            InitializeComponent();
            PID = ID;
        }
        private void FrmPrintPaymentVoucherOldPayOther_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetPrintPaymentVOldOther.Sp_PrintPaymentVoucherMasterOldPay' table. You can move, or remove it, as needed.
            this.Sp_PrintPaymentVoucherMasterOldPayTableAdapter.Fill(this.dbBizcarePosDataSetPrintPaymentVOldOther.Sp_PrintPaymentVoucherMasterOldPay, PID);

            this.reportViewer1.RefreshReport();
        }
    }
}
