namespace BisCarePosEdition
{
    partial class FrmPrintPaymentVoucherOther
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
            this.dbBizcarePosDataSetPrintPaymentVOther = new BisCarePosEdition.dbBizcarePosDataSetPrintPaymentVOther();
            this.Sp_PrintPaymentVoucherMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sp_PrintPaymentVoucherMasterTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetPrintPaymentVOtherTableAdapters.Sp_PrintPaymentVoucherMasterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetPrintPaymentVOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintPaymentVoucherMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sp_PrintPaymentVoucherMasterBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportPaymentVOther.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(784, 467);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbBizcarePosDataSetPrintPaymentVOther
            // 
            this.dbBizcarePosDataSetPrintPaymentVOther.DataSetName = "dbBizcarePosDataSetPrintPaymentVOther";
            this.dbBizcarePosDataSetPrintPaymentVOther.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sp_PrintPaymentVoucherMasterBindingSource
            // 
            this.Sp_PrintPaymentVoucherMasterBindingSource.DataMember = "Sp_PrintPaymentVoucherMaster";
            this.Sp_PrintPaymentVoucherMasterBindingSource.DataSource = this.dbBizcarePosDataSetPrintPaymentVOther;
            // 
            // Sp_PrintPaymentVoucherMasterTableAdapter
            // 
            this.Sp_PrintPaymentVoucherMasterTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintPaymentVoucherOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 467);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmPrintPaymentVoucherOther";
            this.Text = "Payment Voucher Print";
            this.Load += new System.EventHandler(this.FrmPrintPaymentVoucherOther_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetPrintPaymentVOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintPaymentVoucherMasterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sp_PrintPaymentVoucherMasterBindingSource;
        private dbBizcarePosDataSetPrintPaymentVOther dbBizcarePosDataSetPrintPaymentVOther;
        private dbBizcarePosDataSetPrintPaymentVOtherTableAdapters.Sp_PrintPaymentVoucherMasterTableAdapter Sp_PrintPaymentVoucherMasterTableAdapter;
    }
}