namespace BisCarePosEdition
{
    partial class FrmProductStockReport
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
            this.spReportDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSet2 = new BisCarePosEdition.dbBizcarePosDataSet2();
            this.spSalesReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSet24 = new BisCarePosEdition.dbBizcarePosDataSet24();
            this.spSalesReportComplimentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSet25 = new BisCarePosEdition.dbBizcarePosDataSet25();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spReportDatesTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet2TableAdapters.spReportDatesTableAdapter();
            this.spSalesReportTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet24TableAdapters.spSalesReportTableAdapter();
            this.spSalesReportComplimentTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet25TableAdapters.spSalesReportComplimentTableAdapter();
            this.dbBizcarePosDataSetBankTransReport = new BisCarePosEdition.dbBizcarePosDataSetBankTransReport();
            this.Sp_ReportBankTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sp_ReportBankTransactionTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetBankTransReportTableAdapters.Sp_ReportBankTransactionTableAdapter();
            this.dataSet_ReportProductStock = new BisCarePosEdition.DataSet_ReportProductStock();
            this.dataSetReportProductStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReportProductStockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spReportDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSalesReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSalesReportComplimentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetBankTransReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_ReportBankTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ReportProductStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportProductStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportProductStockBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // spReportDatesBindingSource
            // 
            this.spReportDatesBindingSource.DataMember = "spReportDates";
            this.spReportDatesBindingSource.DataSource = this.dbBizcarePosDataSet2;
            // 
            // dbBizcarePosDataSet2
            // 
            this.dbBizcarePosDataSet2.DataSetName = "dbBizcarePosDataSet2";
            this.dbBizcarePosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spSalesReportBindingSource
            // 
            this.spSalesReportBindingSource.DataMember = "spSalesReport";
            this.spSalesReportBindingSource.DataSource = this.dbBizcarePosDataSet24;
            // 
            // dbBizcarePosDataSet24
            // 
            this.dbBizcarePosDataSet24.DataSetName = "dbBizcarePosDataSet24";
            this.dbBizcarePosDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spSalesReportComplimentBindingSource
            // 
            this.spSalesReportComplimentBindingSource.DataMember = "spSalesReportCompliment";
            this.spSalesReportComplimentBindingSource.DataSource = this.dbBizcarePosDataSet25;
            // 
            // dbBizcarePosDataSet25
            // 
            this.dbBizcarePosDataSet25.DataSetName = "dbBizcarePosDataSet25";
            this.dbBizcarePosDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sp_ReportBankTransactionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportBankTransReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(854, 580);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // spReportDatesTableAdapter
            // 
            this.spReportDatesTableAdapter.ClearBeforeFill = true;
            // 
            // spSalesReportTableAdapter
            // 
            this.spSalesReportTableAdapter.ClearBeforeFill = true;
            // 
            // spSalesReportComplimentTableAdapter
            // 
            this.spSalesReportComplimentTableAdapter.ClearBeforeFill = true;
            // 
            // dbBizcarePosDataSetBankTransReport
            // 
            this.dbBizcarePosDataSetBankTransReport.DataSetName = "dbBizcarePosDataSetBankTransReport";
            this.dbBizcarePosDataSetBankTransReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sp_ReportBankTransactionBindingSource
            // 
            this.Sp_ReportBankTransactionBindingSource.DataMember = "Sp_ReportBankTransaction";
            this.Sp_ReportBankTransactionBindingSource.DataSource = this.dbBizcarePosDataSetBankTransReport;
            // 
            // Sp_ReportBankTransactionTableAdapter
            // 
            this.Sp_ReportBankTransactionTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet_ReportProductStock
            // 
            this.dataSet_ReportProductStock.DataSetName = "DataSet_ReportProductStock";
            this.dataSet_ReportProductStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetReportProductStockBindingSource
            // 
            this.dataSetReportProductStockBindingSource.DataSource = this.dataSet_ReportProductStock;
            this.dataSetReportProductStockBindingSource.Position = 0;
            // 
            // dataSetReportProductStockBindingSource1
            // 
            this.dataSetReportProductStockBindingSource1.DataSource = this.dataSet_ReportProductStock;
            this.dataSetReportProductStockBindingSource1.Position = 0;
            // 
            // FrmProductStockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 580);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmProductStockReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Stock Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSaleReport_FormClosing);
            this.Load += new System.EventHandler(this.FrmSaleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spReportDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSalesReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSalesReportComplimentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetBankTransReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_ReportBankTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ReportProductStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportProductStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportProductStockBindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource Sp_ReportBankTransactionBindingSource;
        private dbBizcarePosDataSetBankTransReport dbBizcarePosDataSetBankTransReport;
        private dbBizcarePosDataSetBankTransReportTableAdapters.Sp_ReportBankTransactionTableAdapter Sp_ReportBankTransactionTableAdapter;
        private DataSet_ReportProductStock dataSet_ReportProductStock;
        private System.Windows.Forms.BindingSource dataSetReportProductStockBindingSource;
        private System.Windows.Forms.BindingSource dataSetReportProductStockBindingSource1;
    }
}