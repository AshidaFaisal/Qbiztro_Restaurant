namespace BisCarePosEdition
{
    partial class FrmReportDayBook
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
            this.dbBizcarePosDataSetDayBookReport = new BisCarePosEdition.dbBizcarePosDataSetDayBookReport();
            this.spDayBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spDayBookTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetDayBookReportTableAdapters.spDayBookTableAdapter();
            this.dbBizcarePosDataSetDayBookBasic = new BisCarePosEdition.dbBizcarePosDataSetDayBookBasic();
            this.spDayBookBasicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spDayBookBasicTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetDayBookBasicTableAdapters.spDayBookBasicTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetDayBookReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDayBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetDayBookBasic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDayBookBasicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spDayBookBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.spDayBookBasicBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportDayBook.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(884, 433);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbBizcarePosDataSetDayBookReport
            // 
            this.dbBizcarePosDataSetDayBookReport.DataSetName = "dbBizcarePosDataSetDayBookReport";
            this.dbBizcarePosDataSetDayBookReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spDayBookBindingSource
            // 
            this.spDayBookBindingSource.DataMember = "spDayBook";
            this.spDayBookBindingSource.DataSource = this.dbBizcarePosDataSetDayBookReport;
            // 
            // spDayBookTableAdapter
            // 
            this.spDayBookTableAdapter.ClearBeforeFill = true;
            // 
            // dbBizcarePosDataSetDayBookBasic
            // 
            this.dbBizcarePosDataSetDayBookBasic.DataSetName = "dbBizcarePosDataSetDayBookBasic";
            this.dbBizcarePosDataSetDayBookBasic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spDayBookBasicBindingSource
            // 
            this.spDayBookBasicBindingSource.DataMember = "spDayBookBasic";
            this.spDayBookBasicBindingSource.DataSource = this.dbBizcarePosDataSetDayBookBasic;
            // 
            // spDayBookBasicTableAdapter
            // 
            this.spDayBookBasicTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportDayBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 433);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportDayBook";
            this.Text = "Day Book Report";
            this.Load += new System.EventHandler(this.FrmReportDayBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetDayBookReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDayBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetDayBookBasic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDayBookBasicBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spDayBookBindingSource;
        private dbBizcarePosDataSetDayBookReport dbBizcarePosDataSetDayBookReport;
        private System.Windows.Forms.BindingSource spDayBookBasicBindingSource;
        private dbBizcarePosDataSetDayBookBasic dbBizcarePosDataSetDayBookBasic;
        private dbBizcarePosDataSetDayBookReportTableAdapters.spDayBookTableAdapter spDayBookTableAdapter;
        private dbBizcarePosDataSetDayBookBasicTableAdapters.spDayBookBasicTableAdapter spDayBookBasicTableAdapter;
    }
}