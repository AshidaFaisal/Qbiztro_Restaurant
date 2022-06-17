namespace BisCarePosEdition
{
    partial class FrmPrintReceiptVoucher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbBizcarePosDataSetreceiptm = new BisCarePosEdition.dbBizcarePosDataSetreceiptm();
            this.Sp_PrintReceiptVoucherMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sp_PrintReceiptVoucherMasterTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetreceiptmTableAdapters.Sp_PrintReceiptVoucherMasterTableAdapter();
            this.dbBizcarePosDataSetrd = new BisCarePosEdition.dbBizcarePosDataSetrd();
            this.Sp_PrintReceiptVoucherDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sp_PrintReceiptVoucherDetailsTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetrdTableAdapters.Sp_PrintReceiptVoucherDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetreceiptm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintReceiptVoucherMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintReceiptVoucherDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sp_PrintReceiptVoucherMasterBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.Sp_PrintReceiptVoucherDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportReceptVoucher.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(989, 507);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbBizcarePosDataSetreceiptm
            // 
            this.dbBizcarePosDataSetreceiptm.DataSetName = "dbBizcarePosDataSetreceiptm";
            this.dbBizcarePosDataSetreceiptm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sp_PrintReceiptVoucherMasterBindingSource
            // 
            this.Sp_PrintReceiptVoucherMasterBindingSource.DataMember = "Sp_PrintReceiptVoucherMaster";
            this.Sp_PrintReceiptVoucherMasterBindingSource.DataSource = this.dbBizcarePosDataSetreceiptm;
            // 
            // Sp_PrintReceiptVoucherMasterTableAdapter
            // 
            this.Sp_PrintReceiptVoucherMasterTableAdapter.ClearBeforeFill = true;
            // 
            // dbBizcarePosDataSetrd
            // 
            this.dbBizcarePosDataSetrd.DataSetName = "dbBizcarePosDataSetrd";
            this.dbBizcarePosDataSetrd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sp_PrintReceiptVoucherDetailsBindingSource
            // 
            this.Sp_PrintReceiptVoucherDetailsBindingSource.DataMember = "Sp_PrintReceiptVoucherDetails";
            this.Sp_PrintReceiptVoucherDetailsBindingSource.DataSource = this.dbBizcarePosDataSetrd;
            // 
            // Sp_PrintReceiptVoucherDetailsTableAdapter
            // 
            this.Sp_PrintReceiptVoucherDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintReceiptVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 507);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmPrintReceiptVoucher";
            this.Text = "Receipt Voucher Print";
            this.Load += new System.EventHandler(this.FrmPrintReceiptVoucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetreceiptm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintReceiptVoucherMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintReceiptVoucherDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sp_PrintReceiptVoucherMasterBindingSource;
        private dbBizcarePosDataSetreceiptm dbBizcarePosDataSetreceiptm;
        private System.Windows.Forms.BindingSource Sp_PrintReceiptVoucherDetailsBindingSource;
        private dbBizcarePosDataSetrd dbBizcarePosDataSetrd;
        private dbBizcarePosDataSetreceiptmTableAdapters.Sp_PrintReceiptVoucherMasterTableAdapter Sp_PrintReceiptVoucherMasterTableAdapter;
        private dbBizcarePosDataSetrdTableAdapters.Sp_PrintReceiptVoucherDetailsTableAdapter Sp_PrintReceiptVoucherDetailsTableAdapter;
    }
}