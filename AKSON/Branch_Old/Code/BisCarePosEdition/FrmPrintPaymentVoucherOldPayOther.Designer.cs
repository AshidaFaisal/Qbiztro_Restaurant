namespace BisCarePosEdition
{
    partial class FrmPrintPaymentVoucherOldPayOther
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
            this.dbBizcarePosDataSetPrintPaymentVOldOther = new BisCarePosEdition.dbBizcarePosDataSetPrintPaymentVOldOther();
            this.Sp_PrintPaymentVoucherMasterOldPayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sp_PrintPaymentVoucherMasterOldPayTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetPrintPaymentVOldOtherTableAdapters.Sp_PrintPaymentVoucherMasterOldPayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetPrintPaymentVOldOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintPaymentVoucherMasterOldPayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sp_PrintPaymentVoucherMasterOldPayBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportPaymentVOldOther.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(845, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbBizcarePosDataSetPrintPaymentVOldOther
            // 
            this.dbBizcarePosDataSetPrintPaymentVOldOther.DataSetName = "dbBizcarePosDataSetPrintPaymentVOldOther";
            this.dbBizcarePosDataSetPrintPaymentVOldOther.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sp_PrintPaymentVoucherMasterOldPayBindingSource
            // 
            this.Sp_PrintPaymentVoucherMasterOldPayBindingSource.DataMember = "Sp_PrintPaymentVoucherMasterOldPay";
            this.Sp_PrintPaymentVoucherMasterOldPayBindingSource.DataSource = this.dbBizcarePosDataSetPrintPaymentVOldOther;
            // 
            // Sp_PrintPaymentVoucherMasterOldPayTableAdapter
            // 
            this.Sp_PrintPaymentVoucherMasterOldPayTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintPaymentVoucherOldPayOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 449);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmPrintPaymentVoucherOldPayOther";
            this.Text = "Payment Voucher Print";
            this.Load += new System.EventHandler(this.FrmPrintPaymentVoucherOldPayOther_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetPrintPaymentVOldOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintPaymentVoucherMasterOldPayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sp_PrintPaymentVoucherMasterOldPayBindingSource;
        private dbBizcarePosDataSetPrintPaymentVOldOther dbBizcarePosDataSetPrintPaymentVOldOther;
        private dbBizcarePosDataSetPrintPaymentVOldOtherTableAdapters.Sp_PrintPaymentVoucherMasterOldPayTableAdapter Sp_PrintPaymentVoucherMasterOldPayTableAdapter;
    }
}