namespace BisCarePosEdition
{
    partial class frmDeletedInvoiceReportShort
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spReportDeletedInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSet31 = new BisCarePosEdition.dbBizcarePosDataSet31();
            this.spReportDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spReportDeletedInvoiceComplimentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spReportDeletedInvoiceComplimentTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet31TableAdapters.spReportDeletedInvoiceComplimentTableAdapter();
            this.spReportDatesTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet31TableAdapters.spReportDatesTableAdapter();
            this.spReportDeletedInvoiceTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet31TableAdapters.spReportDeletedInvoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDeletedInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDeletedInvoiceComplimentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spReportDeletedInvoiceBindingSource
            // 
            this.spReportDeletedInvoiceBindingSource.DataMember = "spReportDeletedInvoice";
            this.spReportDeletedInvoiceBindingSource.DataSource = this.dbBizcarePosDataSet31;
            // 
            // dbBizcarePosDataSet31
            // 
            this.dbBizcarePosDataSet31.DataSetName = "dbBizcarePosDataSet31";
            this.dbBizcarePosDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spReportDatesBindingSource
            // 
            this.spReportDatesBindingSource.DataMember = "spReportDates";
            this.spReportDatesBindingSource.DataSource = this.dbBizcarePosDataSet31;
            // 
            // spReportDeletedInvoiceComplimentBindingSource
            // 
            this.spReportDeletedInvoiceComplimentBindingSource.DataMember = "spReportDeletedInvoiceCompliment";
            this.spReportDeletedInvoiceComplimentBindingSource.DataSource = this.dbBizcarePosDataSet31;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spReportDeletedInvoiceBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.spReportDatesBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.spReportDeletedInvoiceComplimentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportDeletedInvoieShort.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(972, 551);
            this.reportViewer1.TabIndex = 0;
            // 
            // spReportDeletedInvoiceComplimentTableAdapter
            // 
            this.spReportDeletedInvoiceComplimentTableAdapter.ClearBeforeFill = true;
            // 
            // spReportDatesTableAdapter
            // 
            this.spReportDatesTableAdapter.ClearBeforeFill = true;
            // 
            // spReportDeletedInvoiceTableAdapter
            // 
            this.spReportDeletedInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // frmDeletedInvoiceReportShort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 551);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmDeletedInvoiceReportShort";
            this.Text = "Deleted Invoice Report ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDeletedInvoiceReportShort_FormClosing);
            this.Load += new System.EventHandler(this.frmDeletedInvoiceReportShort_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spReportDeletedInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDeletedInvoiceComplimentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReportDeletedInvoiceComplimentBindingSource;
        private dbBizcarePosDataSet31 dbBizcarePosDataSet31;
        private System.Windows.Forms.BindingSource spReportDatesBindingSource;
        private dbBizcarePosDataSet31TableAdapters.spReportDeletedInvoiceComplimentTableAdapter spReportDeletedInvoiceComplimentTableAdapter;
        private dbBizcarePosDataSet31TableAdapters.spReportDatesTableAdapter spReportDatesTableAdapter;
        private System.Windows.Forms.BindingSource spReportDeletedInvoiceBindingSource;
        private dbBizcarePosDataSet31TableAdapters.spReportDeletedInvoiceTableAdapter spReportDeletedInvoiceTableAdapter;
    }
}