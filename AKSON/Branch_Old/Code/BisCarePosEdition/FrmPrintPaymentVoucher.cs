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
    public partial class FrmPrintPaymentVoucher : Form
    {
        public FrmPrintPaymentVoucher()
        {
            InitializeComponent();
        }
        int PID;
        public FrmPrintPaymentVoucher(int ID)
        {
            InitializeComponent();
            PID = ID;
        }
        private void FrmPrintPaymentVoucher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetPrintPaymentVDetails.Sp_PrintPaymentVoucherDetails' table. You can move, or remove it, as needed.
            this.Sp_PrintPaymentVoucherDetailsTableAdapter.Fill(this.dbBizcarePosDataSetPrintPaymentVDetails.Sp_PrintPaymentVoucherDetails, PID);
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetPrintPaymentMaster.Sp_PrintPaymentVoucherMaster' table. You can move, or remove it, as needed.
            this.Sp_PrintPaymentVoucherMasterTableAdapter.Fill(this.dbBizcarePosDataSetPrintPaymentMaster.Sp_PrintPaymentVoucherMaster, PID);

            this.reportViewer1.RefreshReport();
        }
    }
}
