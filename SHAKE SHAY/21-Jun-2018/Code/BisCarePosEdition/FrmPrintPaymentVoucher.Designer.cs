namespace BisCarePosEdition
{
    partial class FrmPrintPaymentVoucher
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
            this.dbBizcarePosDataSetPrintPaymentVDetails = new BisCarePosEdition.dbBizcarePosDataSetPrintPaymentVDetails();
            this.Sp_PrintPaymentVoucherDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sp_PrintPaymentVoucherDetailsTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetPrintPaymentVDetailsTableAdapters.Sp_PrintPaymentVoucherDetailsTableAdapter();
            this.dbBizcarePosDataSetPrintPaymentMaster = new BisCarePosEdition.dbBizcarePosDataSetPrintPaymentMaster();
            this.Sp_PrintPaymentVoucherMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sp_PrintPaymentVoucherMasterTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetPrintPaymentMasterTableAdapters.Sp_PrintPaymentVoucherMasterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetPrintPaymentVDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintPaymentVoucherDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetPrintPaymentMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintPaymentVoucherMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sp_PrintPaymentVoucherDetailsBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.Sp_PrintPaymentVoucherMasterBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportPaymentVPrint.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(822, 481);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbBizcarePosDataSetPrintPaymentVDetails
            // 
            this.dbBizcarePosDataSetPrintPaymentVDetails.DataSetName = "dbBizcarePosDataSetPrintPaymentVDetails";
            this.dbBizcarePosDataSetPrintPaymentVDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sp_PrintPaymentVoucherDetailsBindingSource
            // 
            this.Sp_PrintPaymentVoucherDetailsBindingSource.DataMember = "Sp_PrintPaymentVoucherDetails";
            this.Sp_PrintPaymentVoucherDetailsBindingSource.DataSource = this.dbBizcarePosDataSetPrintPaymentVDetails;
            // 
            // Sp_PrintPaymentVoucherDetailsTableAdapter
            // 
            this.Sp_PrintPaymentVoucherDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // dbBizcarePosDataSetPrintPaymentMaster
            // 
            this.dbBizcarePosDataSetPrintPaymentMaster.DataSetName = "dbBizcarePosDataSetPrintPaymentMaster";
            this.dbBizcarePosDataSetPrintPaymentMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sp_PrintPaymentVoucherMasterBindingSource
            // 
            this.Sp_PrintPaymentVoucherMasterBindingSource.DataMember = "Sp_PrintPaymentVoucherMaster";
            this.Sp_PrintPaymentVoucherMasterBindingSource.DataSource = this.dbBizcarePosDataSetPrintPaymentMaster;
            // 
            // Sp_PrintPaymentVoucherMasterTableAdapter
            // 
            this.Sp_PrintPaymentVoucherMasterTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintPaymentVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 481);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmPrintPaymentVoucher";
            this.Text = "Payment Voucher Print";
            this.Load += new System.EventHandler(this.FrmPrintPaymentVoucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetPrintPaymentVDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintPaymentVoucherDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetPrintPaymentMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintPaymentVoucherMasterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sp_PrintPaymentVoucherDetailsBindingSource;
        private dbBizcarePosDataSetPrintPaymentVDetails dbBizcarePosDataSetPrintPaymentVDetails;
        private System.Windows.Forms.BindingSource Sp_PrintPaymentVoucherMasterBindingSource;
        private dbBizcarePosDataSetPrintPaymentMaster dbBizcarePosDataSetPrintPaymentMaster;
        private dbBizcarePosDataSetPrintPaymentVDetailsTableAdapters.Sp_PrintPaymentVoucherDetailsTableAdapter Sp_PrintPaymentVoucherDetailsTableAdapter;
        private dbBizcarePosDataSetPrintPaymentMasterTableAdapters.Sp_PrintPaymentVoucherMasterTableAdapter Sp_PrintPaymentVoucherMasterTableAdapter;
    }
}