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
    public partial class FrmPrintReceiptVoucherOther : Form
    {
        public FrmPrintReceiptVoucherOther()
        {
            InitializeComponent();
        }
        int RID;
        public FrmPrintReceiptVoucherOther(int ID)
        {
            InitializeComponent();
            RID = ID;
        }
        private void FrmPrintReceiptVoucherOther_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetReceiptOther.Sp_PrintReceiptVoucherMaster' table. You can move, or remove it, as needed.
            this.Sp_PrintReceiptVoucherMasterTableAdapter.Fill(this.dbBizcarePosDataSetReceiptOther.Sp_PrintReceiptVoucherMaster,RID);

            this.reportViewer1.RefreshReport();
        }
    }
}
