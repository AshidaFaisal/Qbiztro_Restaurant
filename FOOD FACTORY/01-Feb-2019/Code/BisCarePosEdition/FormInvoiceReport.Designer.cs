namespace BisCarePosEdition
{
    partial class FormInvoiceReport
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
            this.DB_AdhidhiDataSetinvoice = new BisCarePosEdition.DB_AdhidhiDataSetinvoice();
            this.SP_Invoice_ReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_Invoice_ReportsTableAdapter = new BisCarePosEdition.DB_AdhidhiDataSetinvoiceTableAdapters.SP_Invoice_ReportsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DB_AdhidhiDataSetinvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Invoice_ReportsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_Invoice_ReportsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.Report_invoice.rdlc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // DB_AdhidhiDataSetinvoice
            // 
            this.DB_AdhidhiDataSetinvoice.DataSetName = "DB_AdhidhiDataSetinvoice";
            this.DB_AdhidhiDataSetinvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_Invoice_ReportsBindingSource
            // 
            this.SP_Invoice_ReportsBindingSource.DataMember = "SP_Invoice_Reports";
            this.SP_Invoice_ReportsBindingSource.DataSource = this.DB_AdhidhiDataSetinvoice;
            // 
            // SP_Invoice_ReportsTableAdapter
            // 
            this.SP_Invoice_ReportsTableAdapter.ClearBeforeFill = true;
            // 
            // FormInvoiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormInvoiceReport";
            this.Text = "FormInvoiceReport";
            this.Load += new System.EventHandler(this.FormInvoiceReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DB_AdhidhiDataSetinvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Invoice_ReportsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_Invoice_ReportsBindingSource;
        private DB_AdhidhiDataSetinvoice DB_AdhidhiDataSetinvoice;
        private DB_AdhidhiDataSetinvoiceTableAdapters.SP_Invoice_ReportsTableAdapter SP_Invoice_ReportsTableAdapter;
    }
}