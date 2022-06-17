namespace BisCarePosEdition
{
    partial class FrmDeletedComplimentaryReport
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
            this.spReportDeletedInvoiceComplimentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSet29 = new BisCarePosEdition.dbBizcarePosDataSet29();
            this.spGetRestuarantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSet30 = new BisCarePosEdition.dbBizcarePosDataSet30();
            this.spReportDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSet = new BisCarePosEdition.dbBizcarePosDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spReportDeletedInvoiceComplimentTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet29TableAdapters.spReportDeletedInvoiceComplimentTableAdapter();
            this.spGetRestuarantTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet30TableAdapters.spGetRestuarantTableAdapter();
            this.dbBizcarePosDataSetReportDeletedInvoiceDetailsnew = new BisCarePosEdition.dbBizcarePosDataSetReportDeletedInvoiceDetailsnew();
            this.spReportDeletedInvoiceDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spReportDeletedInvoiceDetailsTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetReportDeletedInvoiceDetailsnewTableAdapters.spReportDeletedInvoiceDetailsTableAdapter();
            this.spReportDatesTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetTableAdapters.spReportDatesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDeletedInvoiceComplimentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetRestuarantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReportDeletedInvoiceDetailsnew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDeletedInvoiceDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // spGetRestuarantBindingSource
            // 
            this.spGetRestuarantBindingSource.DataMember = "spGetRestuarant";
            this.spGetRestuarantBindingSource.DataSource = this.dbBizcarePosDataSet30;
            // 
            // dbBizcarePosDataSet30
            // 
            this.dbBizcarePosDataSet30.DataSetName = "dbBizcarePosDataSet30";
            this.dbBizcarePosDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spReportDeletedInvoiceComplimentBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.spGetRestuarantBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.spReportDatesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportofDeletedInvoiceComplimentary.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(824, 344);
            this.reportViewer1.TabIndex = 0;
            // 
            // spReportDeletedInvoiceComplimentTableAdapter
            // 
            this.spReportDeletedInvoiceComplimentTableAdapter.ClearBeforeFill = true;
            // 
            // spGetRestuarantTableAdapter
            // 
            this.spGetRestuarantTableAdapter.ClearBeforeFill = true;
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
            // spReportDatesTableAdapter
            // 
            this.spReportDatesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDeletedComplimentaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 344);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmDeletedComplimentaryReport";
            this.Text = " Deleted Complimentary Invoice Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDeletedComplimentaryReport_FormClosing);
            this.Load += new System.EventHandler(this.FrmDeletedComplimentaryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spReportDeletedInvoiceComplimentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetRestuarantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReportDeletedInvoiceDetailsnew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDeletedInvoiceDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReportDeletedInvoiceComplimentBindingSource;
        private dbBizcarePosDataSet29 dbBizcarePosDataSet29;
        private System.Windows.Forms.BindingSource spGetRestuarantBindingSource;
        private dbBizcarePosDataSet30 dbBizcarePosDataSet30;
        private dbBizcarePosDataSet29TableAdapters.spReportDeletedInvoiceComplimentTableAdapter spReportDeletedInvoiceComplimentTableAdapter;
        private dbBizcarePosDataSet30TableAdapters.spGetRestuarantTableAdapter spGetRestuarantTableAdapter;
        private System.Windows.Forms.BindingSource spReportDeletedInvoiceDetailsBindingSource;
        private dbBizcarePosDataSetReportDeletedInvoiceDetailsnew dbBizcarePosDataSetReportDeletedInvoiceDetailsnew;
        private dbBizcarePosDataSetReportDeletedInvoiceDetailsnewTableAdapters.spReportDeletedInvoiceDetailsTableAdapter spReportDeletedInvoiceDetailsTableAdapter;
        private System.Windows.Forms.BindingSource spReportDatesBindingSource;
        private dbBizcarePosDataSet dbBizcarePosDataSet;
        private dbBizcarePosDataSetTableAdapters.spReportDatesTableAdapter spReportDatesTableAdapter;
    }
}