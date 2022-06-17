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
    public partial class FrmPrintReceiptVoucherOldReceive : Form
    {
        public FrmPrintReceiptVoucherOldReceive()
        {
            InitializeComponent();
        }
        int RID;
        public FrmPrintReceiptVoucherOldReceive(int ID)
        {
            InitializeComponent();
            RID = ID;
        }
        private void FrmPrintReceiptVoucherOldReceive_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetPrintReceiptVoucherOldReceive.Sp_PrintReceiptVoucherOldPayMaster' table. You can move, or remove it, as needed.
            this.Sp_PrintReceiptVoucherOldPayMasterTableAdapter.Fill(this.dbBizcarePosDataSetPrintReceiptVoucherOldReceive.Sp_PrintReceiptVoucherOldPayMaster,RID);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetPaymentVoucherOldPayReceive.Sp_PrintReceiptVoucherOldReceiveDetails' table. You can move, or remove it, as needed.
            this.Sp_PrintReceiptVoucherOldReceiveDetailsTableAdapter.Fill(this.dbBizcarePosDataSetPaymentVoucherOldPayReceive.Sp_PrintReceiptVoucherOldReceiveDetails,RID);

            this.reportViewer1.RefreshReport();
        }
    }
}
