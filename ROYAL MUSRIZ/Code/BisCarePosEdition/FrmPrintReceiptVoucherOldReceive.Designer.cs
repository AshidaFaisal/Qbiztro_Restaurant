namespace BisCarePosEdition
{
    partial class FrmPrintReceiptVoucherOldReceive
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
            this.dbBizcarePosDataSetPrintReceiptVoucherOldReceive = new BisCarePosEdition.dbBizcarePosDataSetPrintReceiptVoucherOldReceive();
            this.Sp_PrintReceiptVoucherOldPayMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sp_PrintReceiptVoucherOldPayMasterTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetPrintReceiptVoucherOldReceiveTableAdapters.Sp_PrintReceiptVoucherOldPayMasterTableAdapter();
            this.dbBizcarePosDataSetPaymentVoucherOldPayReceive = new BisCarePosEdition.dbBizcarePosDataSetPaymentVoucherOldPayReceive();
            this.Sp_PrintReceiptVoucherOldReceiveDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sp_PrintReceiptVoucherOldReceiveDetailsTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetPaymentVoucherOldPayReceiveTableAdapters.Sp_PrintReceiptVoucherOldReceiveDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetPrintReceiptVoucherOldReceive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintReceiptVoucherOldPayMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetPaymentVoucherOldPayReceive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintReceiptVoucherOldReceiveDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sp_PrintReceiptVoucherOldPayMasterBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.Sp_PrintReceiptVoucherOldReceiveDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportReceiptVoucherOldPayReceive.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(936, 413);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbBizcarePosDataSetPrintReceiptVoucherOldReceive
            // 
            this.dbBizcarePosDataSetPrintReceiptVoucherOldReceive.DataSetName = "dbBizcarePosDataSetPrintReceiptVoucherOldReceive";
            this.dbBizcarePosDataSetPrintReceiptVoucherOldReceive.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sp_PrintReceiptVoucherOldPayMasterBindingSource
            // 
            this.Sp_PrintReceiptVoucherOldPayMasterBindingSource.DataMember = "Sp_PrintReceiptVoucherOldPayMaster";
            this.Sp_PrintReceiptVoucherOldPayMasterBindingSource.DataSource = this.dbBizcarePosDataSetPrintReceiptVoucherOldReceive;
            // 
            // Sp_PrintReceiptVoucherOldPayMasterTableAdapter
            // 
            this.Sp_PrintReceiptVoucherOldPayMasterTableAdapter.ClearBeforeFill = true;
            // 
            // dbBizcarePosDataSetPaymentVoucherOldPayReceive
            // 
            this.dbBizcarePosDataSetPaymentVoucherOldPayReceive.DataSetName = "dbBizcarePosDataSetPaymentVoucherOldPayReceive";
            this.dbBizcarePosDataSetPaymentVoucherOldPayReceive.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sp_PrintReceiptVoucherOldReceiveDetailsBindingSource
            // 
            this.Sp_PrintReceiptVoucherOldReceiveDetailsBindingSource.DataMember = "Sp_PrintReceiptVoucherOldReceiveDetails";
            this.Sp_PrintReceiptVoucherOldReceiveDetailsBindingSource.DataSource = this.dbBizcarePosDataSetPaymentVoucherOldPayReceive;
            // 
            // Sp_PrintReceiptVoucherOldReceiveDetailsTableAdapter
            // 
            this.Sp_PrintReceiptVoucherOldReceiveDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintReceiptVoucherOldReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 413);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrintReceiptVoucherOldReceive";
            this.Text = "Receipt Voucher Print";
            this.Load += new System.EventHandler(this.FrmPrintReceiptVoucherOldReceive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetPrintReceiptVoucherOldReceive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintReceiptVoucherOldPayMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetPaymentVoucherOldPayReceive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintReceiptVoucherOldReceiveDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sp_PrintReceiptVoucherOldPayMasterBindingSource;
        private dbBizcarePosDataSetPrintReceiptVoucherOldReceive dbBizcarePosDataSetPrintReceiptVoucherOldReceive;
        private System.Windows.Forms.BindingSource Sp_PrintReceiptVoucherOldReceiveDetailsBindingSource;
        private dbBizcarePosDataSetPaymentVoucherOldPayReceive dbBizcarePosDataSetPaymentVoucherOldPayReceive;
        private dbBizcarePosDataSetPrintReceiptVoucherOldReceiveTableAdapters.Sp_PrintReceiptVoucherOldPayMasterTableAdapter Sp_PrintReceiptVoucherOldPayMasterTableAdapter;
        private dbBizcarePosDataSetPaymentVoucherOldPayReceiveTableAdapters.Sp_PrintReceiptVoucherOldReceiveDetailsTableAdapter Sp_PrintReceiptVoucherOldReceiveDetailsTableAdapter;
    }
}