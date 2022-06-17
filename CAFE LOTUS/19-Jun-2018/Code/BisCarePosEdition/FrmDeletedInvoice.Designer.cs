namespace BisCarePosEdition
{
    partial class FrmDeletedInvoice
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
            this.spReportDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSet = new BisCarePosEdition.dbBizcarePosDataSet();
            this.spReportDeletedInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSet28 = new BisCarePosEdition.dbBizcarePosDataSet28();
            this.spReportDeletedInvoiceComplimentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSet29 = new BisCarePosEdition.dbBizcarePosDataSet29();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spReportDatesTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetTableAdapters.spReportDatesTableAdapter();
            this.spReportDeletedInvoiceTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet28TableAdapters.spReportDeletedInvoiceTableAdapter();
            this.spReportDeletedInvoiceComplimentTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet29TableAdapters.spReportDeletedInvoiceComplimentTableAdapter();
            this.dbBizcarePosDataSetReportDeletedInvoiceDetailsnew = new BisCarePosEdition.dbBizcarePosDataSetReportDeletedInvoiceDetailsnew();
            this.spReportDeletedInvoiceDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spReportDeletedInvoiceDetailsTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetReportDeletedInvoiceDetailsnewTableAdapters.spReportDeletedInvoiceDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDeletedInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDeletedInvoiceComplimentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReportDeletedInvoiceDetailsnew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDeletedInvoiceDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spReportDatesBindingSource
            // 
            this.spReportDatesBindingSource.DataMember = "spReportDates";
            this.spReportDatesBindingSource.DataSource = this.dbBizcarePosDataSet;
            // 
            // dbBizcarePosDataSet
            // 
            this.dbBizcarePosDataSet.DataSetName = "dbBizcarePosDataSet";
            this.dbBizcarePosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spReportDeletedInvoiceBindingSource
            // 
            this.spReportDeletedInvoiceBindingSource.DataMember = "spReportDeletedInvoice";
            this.spReportDeletedInvoiceBindingSource.DataSource = this.dbBizcarePosDataSet28;
            // 
            // dbBizcarePosDataSet28
            // 
            this.dbBizcarePosDataSet28.DataSetName = "dbBizcarePosDataSet28";
            this.dbBizcarePosDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spReportDeletedInvoiceComplimentBindingSource
            // 
            this.spReportDeletedInvoiceComplimentBindingSource.DataMember = "spReportDeletedInvoiceCompliment";
            this.spReportDeletedInvoiceComplimentBindingSource.DataSource = this.dbBizcarePosDataSet29;
            // 
            // dbBizcarePosDataSet29
            // 
            this.dbBizcarePosDataSet29.DataSetName = "dbBizcarePosDataSet29";
            this.dbBizcarePosDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.spReportDatesBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.spReportDeletedInvoiceBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.spReportDeletedInvoiceComplimentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportDeletedInvoiceMaster.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(973, 664);
            this.reportViewer1.TabIndex = 0;
            // 
            // spReportDatesTableAdapter
            // 
            this.spReportDatesTableAdapter.ClearBeforeFill = true;
            // 
            // spReportDeletedInvoiceTableAdapter
            // 
            this.spReportDeletedInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // spReportDeletedInvoiceComplimentTableAdapter
            // 
            this.spReportDeletedInvoiceComplimentTableAdapter.ClearBeforeFill = true;
            // 
            // dbBizcarePosDataSetReportDeletedInvoiceDetailsnew
            // 
            this.dbBizcarePosDataSetReportDeletedInvoiceDetailsnew.DataSetName = "dbBizcarePosDataSetReportDeletedInvoiceDetailsnew";
            this.dbBizcarePosDataSetReportDeletedInvoiceDetailsnew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spReportDeletedInvoiceDetailsBindingSource
            // 
            this.spReportDeletedInvoiceDetailsBindingSource.DataMember = "spReportDeletedInvoiceDetails";
            this.spReportDeletedInvoiceDetailsBindingSource.DataSource = this.dbBizcarePosDataSetReportDeletedInvoiceDetailsnew;
            // 
            // spReportDeletedInvoiceDetailsTableAdapter
            // 
            this.spReportDeletedInvoiceDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDeletedInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 664);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmDeletedInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deleted Invoice Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDeletedInvoice_FormClosing);
            this.Load += new System.EventHandler(this.FrmDeletedInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spReportDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDeletedInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDeletedInvoiceComplimentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReportDeletedInvoiceDetailsnew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDeletedInvoiceDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReportDatesBindingSource;
        private dbBizcarePosDataSet dbBizcarePosDataSet;
        private System.Windows.Forms.BindingSource spReportDeletedInvoiceBindingSource;
        private dbBizcarePosDataSet28 dbBizcarePosDataSet28;
        private System.Windows.Forms.BindingSource spReportDeletedInvoiceComplimentBindingSource;
        private dbBizcarePosDataSet29 dbBizcarePosDataSet29;
        private dbBizcarePosDataSetTableAdapters.spReportDatesTableAdapter spReportDatesTableAdapter;
        private dbBizcarePosDataSet28TableAdapters.spReportDeletedInvoiceTableAdapter spReportDeletedInvoiceTableAdapter;
        private dbBizcarePosDataSet29TableAdapters.spReportDeletedInvoiceComplimentTableAdapter spReportDeletedInvoiceComplimentTableAdapter;
        private System.Windows.Forms.BindingSource spReportDeletedInvoiceDetailsBindingSource;
        private dbBizcarePosDataSetReportDeletedInvoiceDetailsnew dbBizcarePosDataSetReportDeletedInvoiceDetailsnew;
        private dbBizcarePosDataSetReportDeletedInvoiceDetailsnewTableAdapters.spReportDeletedInvoiceDetailsTableAdapter spReportDeletedInvoiceDetailsTableAdapter;
    }
}