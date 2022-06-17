namespace BisCarePosEdition
{
    partial class frmReportProductStock
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
            this.SP_R_ProductStockReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_ReportProductStock = new BisCarePosEdition.DataSet_ReportProductStock();
            this.spReportDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSet2 = new BisCarePosEdition.dbBizcarePosDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_R_ProductStockReportTableAdapter = new BisCarePosEdition.DataSet_ReportProductStockTableAdapters.SP_R_ProductStockReportTableAdapter();
            this.spReportDatesTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet2TableAdapters.spReportDatesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_R_ProductStockReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_ReportProductStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_R_ProductStockReportBindingSource
            // 
            this.SP_R_ProductStockReportBindingSource.DataMember = "SP_R_ProductStockReport";
            this.SP_R_ProductStockReportBindingSource.DataSource = this.DataSet_ReportProductStock;
            // 
            // DataSet_ReportProductStock
            // 
            this.DataSet_ReportProductStock.DataSetName = "DataSet_ReportProductStock";
            this.DataSet_ReportProductStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_R_ProductStockReportBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.spReportDatesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportProductStock.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // SP_R_ProductStockReportTableAdapter
            // 
            this.SP_R_ProductStockReportTableAdapter.ClearBeforeFill = true;
            // 
            // spReportDatesTableAdapter
            // 
            this.spReportDatesTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportProductStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportProductStock";
            this.Text = "Product Stock Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportProductStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_R_ProductStockReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_ReportProductStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_R_ProductStockReportBindingSource;
        private DataSet_ReportProductStock DataSet_ReportProductStock;
        private System.Windows.Forms.BindingSource spReportDatesBindingSource;
        private dbBizcarePosDataSet2 dbBizcarePosDataSet2;
        private DataSet_ReportProductStockTableAdapters.SP_R_ProductStockReportTableAdapter SP_R_ProductStockReportTableAdapter;
        private dbBizcarePosDataSet2TableAdapters.spReportDatesTableAdapter spReportDatesTableAdapter;
    }
}