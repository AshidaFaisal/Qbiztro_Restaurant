namespace BisCarePosEdition
{
    partial class FrmPrintReceiptVoucherOther
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
            this.dbBizcarePosDataSetReceiptOther = new BisCarePosEdition.dbBizcarePosDataSetReceiptOther();
            this.Sp_PrintReceiptVoucherMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sp_PrintReceiptVoucherMasterTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetReceiptOtherTableAdapters.Sp_PrintReceiptVoucherMasterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReceiptOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintReceiptVoucherMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sp_PrintReceiptVoucherMasterBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportReceiptDetailsOther.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(802, 506);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbBizcarePosDataSetReceiptOther
            // 
            this.dbBizcarePosDataSetReceiptOther.DataSetName = "dbBizcarePosDataSetReceiptOther";
            this.dbBizcarePosDataSetReceiptOther.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sp_PrintReceiptVoucherMasterBindingSource
            // 
            this.Sp_PrintReceiptVoucherMasterBindingSource.DataMember = "Sp_PrintReceiptVoucherMaster";
            this.Sp_PrintReceiptVoucherMasterBindingSource.DataSource = this.dbBizcarePosDataSetReceiptOther;
            // 
            // Sp_PrintReceiptVoucherMasterTableAdapter
            // 
            this.Sp_PrintReceiptVoucherMasterTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintReceiptVoucherOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 506);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmPrintReceiptVoucherOther";
            this.Text = "Receipt Voucher Print";
            this.Load += new System.EventHandler(this.FrmPrintReceiptVoucherOther_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReceiptOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_PrintReceiptVoucherMasterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sp_PrintReceiptVoucherMasterBindingSource;
        private dbBizcarePosDataSetReceiptOther dbBizcarePosDataSetReceiptOther;
        private dbBizcarePosDataSetReceiptOtherTableAdapters.Sp_PrintReceiptVoucherMasterTableAdapter Sp_PrintReceiptVoucherMasterTableAdapter;
    }
}