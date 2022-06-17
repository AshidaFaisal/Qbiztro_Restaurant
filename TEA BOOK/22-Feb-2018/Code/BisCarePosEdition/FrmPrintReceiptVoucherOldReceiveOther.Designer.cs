namespace BisCarePosEdition
{
    partial class FrmPrintReceiptVoucherOldReceiveOther
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbBizcarePosDataSetPrintReceiptVoucherOldReceiveOther = new BisCarePosEdition.dbBizcarePosDataSetPrintReceiptVoucherOldReceiveOther();
            this.Sp_PrintReceiptVoucherOldPayMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sp_PrintReceiptVoucherOldPayMasterTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetPrintReceiptVoucherOldReceiveOtherTableAdapters.Sp_PrintReceiptVoucherOldPayMasterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetPrintReceiptVoucherOldReceiveOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintReceiptVoucherOldPayMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sp_PrintReceiptVoucherOldPayMasterBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportReceiptOldPayOther.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(946, 446);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbBizcarePosDataSetPrintReceiptVoucherOldReceiveOther
            // 
            this.dbBizcarePosDataSetPrintReceiptVoucherOldReceiveOther.DataSetName = "dbBizcarePosDataSetPrintReceiptVoucherOldReceiveOther";
            this.dbBizcarePosDataSetPrintReceiptVoucherOldReceiveOther.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sp_PrintReceiptVoucherOldPayMasterBindingSource
            // 
            this.Sp_PrintReceiptVoucherOldPayMasterBindingSource.DataMember = "Sp_PrintReceiptVoucherOldPayMaster";
            this.Sp_PrintReceiptVoucherOldPayMasterBindingSource.DataSource = this.dbBizcarePosDataSetPrintReceiptVoucherOldReceiveOther;
            // 
            // Sp_PrintReceiptVoucherOldPayMasterTableAdapter
            // 
            this.Sp_PrintReceiptVoucherOldPayMasterTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintReceiptVoucherOldReceiveOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 446);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmPrintReceiptVoucherOldReceiveOther";
            this.Text = "Receipt Voucher Print";
            this.Load += new System.EventHandler(this.FrmPrintReceiptVoucherOldReceiveOther_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetPrintReceiptVoucherOldReceiveOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintReceiptVoucherOldPayMasterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sp_PrintReceiptVoucherOldPayMasterBindingSource;
        private dbBizcarePosDataSetPrintReceiptVoucherOldReceiveOther dbBizcarePosDataSetPrintReceiptVoucherOldReceiveOther;
        private dbBizcarePosDataSetPrintReceiptVoucherOldReceiveOtherTableAdapters.Sp_PrintReceiptVoucherOldPayMasterTableAdapter Sp_PrintReceiptVoucherOldPayMasterTableAdapter;
    }
}