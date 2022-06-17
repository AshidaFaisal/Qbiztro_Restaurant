namespace BisCarePosEdition
{
    partial class FrmSaleReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbBizcarePosDataSet2 = new BisCarePosEdition.dbBizcarePosDataSet2();
            this.spReportDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spReportDatesTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet2TableAdapters.spReportDatesTableAdapter();
            this.dbBizcarePosDataSet24 = new BisCarePosEdition.dbBizcarePosDataSet24();
            this.spSalesReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spSalesReportTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet24TableAdapters.spSalesReportTableAdapter();
            this.dbBizcarePosDataSet25 = new BisCarePosEdition.dbBizcarePosDataSet25();
            this.spSalesReportComplimentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spSalesReportComplimentTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet25TableAdapters.spSalesReportComplimentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSalesReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSalesReportComplimentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.spReportDatesBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.spSalesReportBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.spSalesReportComplimentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportSales.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(854, 580);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // dbBizcarePosDataSet2
            // 
            this.dbBizcarePosDataSet2.DataSetName = "dbBizcarePosDataSet2";
            this.dbBizcarePosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spReportDatesBindingSource
            // 
            this.spReportDatesBindingSource.DataMember = "spReportDates";
            this.spReportDatesBindingSource.DataSource = this.dbBizcarePosDataSet2;
            // 
            // spReportDatesTableAdapter
            // 
            this.spReportDatesTableAdapter.ClearBeforeFill = true;
            // 
            // dbBizcarePosDataSet24
            // 
            this.dbBizcarePosDataSet24.DataSetName = "dbBizcarePosDataSet24";
            this.dbBizcarePosDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spSalesReportBindingSource
            // 
            this.spSalesReportBindingSource.DataMember = "spSalesReport";
            this.spSalesReportBindingSource.DataSource = this.dbBizcarePosDataSet24;
            // 
            // spSalesReportTableAdapter
            // 
            this.spSalesReportTableAdapter.ClearBeforeFill = true;
            // 
            // dbBizcarePosDataSet25
            // 
            this.dbBizcarePosDataSet25.DataSetName = "dbBizcarePosDataSet25";
            this.dbBizcarePosDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spSalesReportComplimentBindingSource
            // 
            this.spSalesReportComplimentBindingSource.DataMember = "spSalesReportCompliment";
            this.spSalesReportComplimentBindingSource.DataSource = this.dbBizcarePosDataSet25;
            // 
            // spSalesReportComplimentTableAdapter
            // 
            this.spSalesReportComplimentTableAdapter.ClearBeforeFill = true;
            // 
            // FrmSaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 580);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmSaleReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSaleReport_FormClosing);
            this.Load += new System.EventHandler(this.FrmSaleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSalesReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSalesReportComplimentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReportDatesBindingSource;
        private dbBizcarePosDataSet2 dbBizcarePosDataSet2;
        private System.Windows.Forms.BindingSource spSalesReportBindingSource;
        private dbBizcarePosDataSet24 dbBizcarePosDataSet24;
        private System.Windows.Forms.BindingSource spSalesReportComplimentBindingSource;
        private dbBizcarePosDataSet25 dbBizcarePosDataSet25;
        private dbBizcarePosDataSet2TableAdapters.spReportDatesTableAdapter spReportDatesTableAdapter;
        private dbBizcarePosDataSet24TableAdapters.spSalesReportTableAdapter spSalesReportTableAdapter;
        private dbBizcarePosDataSet25TableAdapters.spSalesReportComplimentTableAdapter spSalesReportComplimentTableAdapter;
    }
}