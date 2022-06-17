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
    public partial class FrmPrintReceiptVoucher : Form
    {
        public FrmPrintReceiptVoucher()
        {
            InitializeComponent();
        }
        int RID;
        public FrmPrintReceiptVoucher(int ID)
        {
            InitializeComponent();
            RID = ID;
        }
        private void FrmPrintReceiptVoucher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetreceiptm.Sp_PrintReceiptVoucherMaster' table. You can move, or remove it, as needed.
            this.Sp_PrintReceiptVoucherMasterTableAdapter.Fill(this.dbBizcarePosDataSetreceiptm.Sp_PrintReceiptVoucherMaster, RID);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetrd.Sp_PrintReceiptVoucherDetails' table. You can move, or remove it, as needed.
            this.Sp_PrintReceiptVoucherDetailsTableAdapter.Fill(this.dbBizcarePosDataSetrd.Sp_PrintReceiptVoucherDetails, RID);

            this.reportViewer1.RefreshReport();
        }
    }
}
