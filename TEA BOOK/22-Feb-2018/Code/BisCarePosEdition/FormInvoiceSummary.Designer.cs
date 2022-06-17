namespace BisCarePosEdition
{
    partial class FormInvoiceSummary
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
            this.spReportInvoiceSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InvoiceReport = new BisCarePosEdition.InvoiceReport();
            this.spReportInvoiceSummaryTableAdapter = new BisCarePosEdition.InvoiceReportTableAdapters.spReportInvoiceSummaryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spReportInvoiceSummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceReport)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spReportInvoiceSummaryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportInvoiceSummary.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(889, 505);
            this.reportViewer1.TabIndex = 0;
            // 
            // spReportInvoiceSummaryBindingSource
            // 
            this.spReportInvoiceSummaryBindingSource.DataMember = "spReportInvoiceSummary";
            this.spReportInvoiceSummaryBindingSource.DataSource = this.InvoiceReport;
            // 
            // InvoiceReport
            // 
            this.InvoiceReport.DataSetName = "InvoiceReport";
            this.InvoiceReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spReportInvoiceSummaryTableAdapter
            // 
            this.spReportInvoiceSummaryTableAdapter.ClearBeforeFill = true;
            // 
            // FormInvoiceSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 505);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormInvoiceSummary";
            this.Text = "FormInvoiceSummary";
            this.Load += new System.EventHandler(this.FormInvoiceSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spReportInvoiceSummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReportInvoiceSummaryBindingSource;
        private InvoiceReport InvoiceReport;
        private InvoiceReportTableAdapters.spReportInvoiceSummaryTableAdapter spReportInvoiceSummaryTableAdapter;
    }
}