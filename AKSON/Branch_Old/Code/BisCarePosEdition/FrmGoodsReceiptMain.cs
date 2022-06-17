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
    public partial class FrmGoodsReceiptMain : Form
    {
        public FrmGoodsReceiptMain()
        {
            InitializeComponent();
        }

         int dealer, item, mode;
        DateTime start, end;
        public FrmGoodsReceiptMain(int deal, int itm, int mod, DateTime st, DateTime en)
        {
            InitializeComponent();
            dealer = deal;
            item = itm;
            mode = mod;
            start = st;
            end = en;
        }

        private void FrmGoodsReceiptMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSet40.SpReportGoodsReceiptDetaild' table. You can move, or remove it, as needed.
            this.SpReportGoodsReceiptDetaildTableAdapter.Fill(this.dbBizcarePosDataSet42.SpReportGoodsReceiptDetaild, dealer, start, end, item, mode);

            this.reportViewer2.RefreshReport();
        }

        private void reportViewer1_SizeChanged(object sender, EventArgs e)
        {
            reportViewer2.Width = this.Width - 20;
            reportViewer2.Width = this.Width - 20;
        }

        private void FrmGoodsReceiptMain_SizeChanged(object sender, EventArgs e)
        {
            reportViewer2.Width = this.Width - 20;
            reportViewer2.Height = this.Height - 20;
        }
    }
}
