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
    public partial class FrmPrintReceiptVoucherOldReceiveOther : Form
    {
        public FrmPrintReceiptVoucherOldReceiveOther()
        {
            InitializeComponent();
        }
        int rid;
        public FrmPrintReceiptVoucherOldReceiveOther(int id)
        {
            InitializeComponent();
            rid = id;
        }
        private void FrmPrintReceiptVoucherOldReceiveOther_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetPrintReceiptVoucherOldReceiveOther.Sp_PrintReceiptVoucherOldPayMaster' table. You can move, or remove it, as needed.
            this.Sp_PrintReceiptVoucherOldPayMasterTableAdapter.Fill(this.dbBizcarePosDataSetPrintReceiptVoucherOldReceiveOther.Sp_PrintReceiptVoucherOldPayMaster,rid);

            this.reportViewer1.RefreshReport();
        }
    }
}
