namespace BisCarePosEdition
{
    partial class Form_Complimentary_Invoice_Report
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
            this.SP_COmplementary_Invoice_ReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DB_AdhidhiDataSet = new BisCarePosEdition.DB_AdhidhiDataSet();
            this.SP_COmplementary_Invoice_ReportsTableAdapter = new BisCarePosEdition.DB_AdhidhiDataSetTableAdapters.SP_COmplementary_Invoice_ReportsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_COmplementary_Invoice_ReportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_AdhidhiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_COmplementary_Invoice_ReportsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.Report_Complimentary_invoice.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(431, 261);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // SP_COmplementary_Invoice_ReportsBindingSource
            // 
            this.SP_COmplementary_Invoice_ReportsBindingSource.DataMember = "SP_COmplementary_Invoice_Reports";
            this.SP_COmplementary_Invoice_ReportsBindingSource.DataSource = this.DB_AdhidhiDataSet;
            // 
            // DB_AdhidhiDataSet
            // 
            this.DB_AdhidhiDataSet.DataSetName = "DB_AdhidhiDataSet";
            this.DB_AdhidhiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_COmplementary_Invoice_ReportsTableAdapter
            // 
            this.SP_COmplementary_Invoice_ReportsTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Complimentary_Invoice_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_Complimentary_Invoice_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm Complimentary Invoice Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Complimentary_Invoice_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_COmplementary_Invoice_ReportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_AdhidhiDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_COmplementary_Invoice_ReportsBindingSource;
        private DB_AdhidhiDataSet DB_AdhidhiDataSet;
        private DB_AdhidhiDataSetTableAdapters.SP_COmplementary_Invoice_ReportsTableAdapter SP_COmplementary_Invoice_ReportsTableAdapter;
    }
}