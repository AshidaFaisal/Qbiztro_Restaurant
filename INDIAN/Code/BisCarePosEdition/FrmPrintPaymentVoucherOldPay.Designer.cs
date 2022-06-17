namespace BisCarePosEdition
{
    partial class FrmPrintPaymentVoucherOldPay
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
            this.dbBizcarePosDataSetPrintPaymentVMasterold = new BisCarePosEdition.dbBizcarePosDataSetPrintPaymentVMasterold();
            this.Sp_PrintPaymentVoucherMasterOldPayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sp_PrintPaymentVoucherMasterOldPayTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetPrintPaymentVMasteroldTableAdapters.Sp_PrintPaymentVoucherMasterOldPayTableAdapter();
            this.dbBizcarePosDataSetPrintPaymentVDetailsOld = new BisCarePosEdition.dbBizcarePosDataSetPrintPaymentVDetailsOld();
            this.Sp_PrintPaymentVoucherDetailsOldPayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sp_PrintPaymentVoucherDetailsOldPayTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetPrintPaymentVDetailsOldTableAdapters.Sp_PrintPaymentVoucherDetailsOldPayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetPrintPaymentVMasterold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintPaymentVoucherMasterOldPayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetPrintPaymentVDetailsOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintPaymentVoucherDetailsOldPayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sp_PrintPaymentVoucherMasterOldPayBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.Sp_PrintPaymentVoucherDetailsOldPayBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportPaymentVOldpay.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(794, 380);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbBizcarePosDataSetPrintPaymentVMasterold
            // 
            this.dbBizcarePosDataSetPrintPaymentVMasterold.DataSetName = "dbBizcarePosDataSetPrintPaymentVMasterold";
            this.dbBizcarePosDataSetPrintPaymentVMasterold.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sp_PrintPaymentVoucherMasterOldPayBindingSource
            // 
            this.Sp_PrintPaymentVoucherMasterOldPayBindingSource.DataMember = "Sp_PrintPaymentVoucherMasterOldPay";
            this.Sp_PrintPaymentVoucherMasterOldPayBindingSource.DataSource = this.dbBizcarePosDataSetPrintPaymentVMasterold;
            // 
            // Sp_PrintPaymentVoucherMasterOldPayTableAdapter
            // 
            this.Sp_PrintPaymentVoucherMasterOldPayTableAdapter.ClearBeforeFill = true;
            // 
            // dbBizcarePosDataSetPrintPaymentVDetailsOld
            // 
            this.dbBizcarePosDataSetPrintPaymentVDetailsOld.DataSetName = "dbBizcarePosDataSetPrintPaymentVDetailsOld";
            this.dbBizcarePosDataSetPrintPaymentVDetailsOld.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sp_PrintPaymentVoucherDetailsOldPayBindingSource
            // 
            this.Sp_PrintPaymentVoucherDetailsOldPayBindingSource.DataMember = "Sp_PrintPaymentVoucherDetailsOldPay";
            this.Sp_PrintPaymentVoucherDetailsOldPayBindingSource.DataSource = this.dbBizcarePosDataSetPrintPaymentVDetailsOld;
            // 
            // Sp_PrintPaymentVoucherDetailsOldPayTableAdapter
            // 
            this.Sp_PrintPaymentVoucherDetailsOldPayTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintPaymentVoucherOldPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 380);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmPrintPaymentVoucherOldPay";
            this.Text = "Payment Voucher Print";
            this.Load += new System.EventHandler(this.FrmPrintPaymentVoucherOldPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetPrintPaymentVMasterold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintPaymentVoucherMasterOldPayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetPrintPaymentVDetailsOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintPaymentVoucherDetailsOldPayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sp_PrintPaymentVoucherMasterOldPayBindingSource;
        private dbBizcarePosDataSetPrintPaymentVMasterold dbBizcarePosDataSetPrintPaymentVMasterold;
        private System.Windows.Forms.BindingSource Sp_PrintPaymentVoucherDetailsOldPayBindingSource;
        private dbBizcarePosDataSetPrintPaymentVDetailsOld dbBizcarePosDataSetPrintPaymentVDetailsOld;
        private dbBizcarePosDataSetPrintPaymentVMasteroldTableAdapters.Sp_PrintPaymentVoucherMasterOldPayTableAdapter Sp_PrintPaymentVoucherMasterOldPayTableAdapter;
        private dbBizcarePosDataSetPrintPaymentVDetailsOldTableAdapters.Sp_PrintPaymentVoucherDetailsOldPayTableAdapter Sp_PrintPaymentVoucherDetailsOldPayTableAdapter;
    }
}