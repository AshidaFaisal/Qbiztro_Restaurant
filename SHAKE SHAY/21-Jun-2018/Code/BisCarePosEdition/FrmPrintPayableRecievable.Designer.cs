namespace BisCarePosEdition
{
    partial class FrmPrintPayableRecievable
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
            this.dbBizcarePosDataSetReceivableReport = new BisCarePosEdition.dbBizcarePosDataSetReceivableReport();
            this.spReportRecievableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spReportRecievableTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetReceivableReportTableAdapters.spReportRecievableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReceivableReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportRecievableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spReportRecievableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportReceivable.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(858, 476);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbBizcarePosDataSetReceivableReport
            // 
            this.dbBizcarePosDataSetReceivableReport.DataSetName = "dbBizcarePosDataSetReceivableReport";
            this.dbBizcarePosDataSetReceivableReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spReportRecievableBindingSource
            // 
            this.spReportRecievableBindingSource.DataMember = "spReportRecievable";
            this.spReportRecievableBindingSource.DataSource = this.dbBizcarePosDataSetReceivableReport;
            // 
            // spReportRecievableTableAdapter
            // 
            this.spReportRecievableTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintPayableRecievable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 476);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmPrintPayableRecievable";
            this.Text = "Payable Receivable Report";
            this.Load += new System.EventHandler(this.FrmPrintPayableRecievable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReceivableReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportRecievableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReportRecievableBindingSource;
        private dbBizcarePosDataSetReceivableReport dbBizcarePosDataSetReceivableReport;
        private dbBizcarePosDataSetReceivableReportTableAdapters.spReportRecievableTableAdapter spReportRecievableTableAdapter;
    }
}