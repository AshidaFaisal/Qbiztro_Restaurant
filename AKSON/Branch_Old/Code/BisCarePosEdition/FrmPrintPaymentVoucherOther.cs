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
    public partial class FrmPrintPaymentVoucherOther : Form
    {
        public FrmPrintPaymentVoucherOther()
        {
            InitializeComponent();
        }
        int PID;
        public FrmPrintPaymentVoucherOther(int ID)
        {
            InitializeComponent();
            PID = ID;
        }
        private void FrmPrintPaymentVoucherOther_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetPrintPaymentVOther.Sp_PrintPaymentVoucherMaster' table. You can move, or remove it, as needed.
            this.Sp_PrintPaymentVoucherMasterTableAdapter.Fill(this.dbBizcarePosDataSetPrintPaymentVOther.Sp_PrintPaymentVoucherMaster, PID);

            this.reportViewer1.RefreshReport();
        }
    }
}
