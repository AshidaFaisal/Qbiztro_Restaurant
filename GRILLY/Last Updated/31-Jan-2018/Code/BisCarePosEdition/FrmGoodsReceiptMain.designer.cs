namespace BisCarePosEdition
{
    partial class FrmGoodsReceiptMain
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbBizcarePosDataSet42 = new BisCarePosEdition.dbBizcarePosDataSet42();
            this.SpReportGoodsReceiptDetaildBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SpReportGoodsReceiptDetaildTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet42TableAdapters.SpReportGoodsReceiptDetaildTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpReportGoodsReceiptDetaildBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SpReportGoodsReceiptDetaildBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.Report4.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(2, 2);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(916, 504);
            this.reportViewer2.TabIndex = 0;
            this.reportViewer2.SizeChanged += new System.EventHandler(this.reportViewer1_SizeChanged);
            // 
            // dbBizcarePosDataSet42
            // 
            this.dbBizcarePosDataSet42.DataSetName = "dbBizcarePosDataSet42";
            this.dbBizcarePosDataSet42.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SpReportGoodsReceiptDetaildBindingSource
            // 
            this.SpReportGoodsReceiptDetaildBindingSource.DataMember = "SpReportGoodsReceiptDetaild";
            this.SpReportGoodsReceiptDetaildBindingSource.DataSource = this.dbBizcarePosDataSet42;
            // 
            // SpReportGoodsReceiptDetaildTableAdapter
            // 
            this.SpReportGoodsReceiptDetaildTableAdapter.ClearBeforeFill = true;
            // 
            // FrmGoodsReceiptMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 466);
            this.Controls.Add(this.reportViewer2);
            this.Name = "FrmGoodsReceiptMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGoodsReceiptMain";
            this.Load += new System.EventHandler(this.FrmGoodsReceiptMain_Load);
            this.SizeChanged += new System.EventHandler(this.FrmGoodsReceiptMain_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpReportGoodsReceiptDetaildBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource SpReportGoodsReceiptDetaildBindingSource;
        private dbBizcarePosDataSet42 dbBizcarePosDataSet42;
        private dbBizcarePosDataSet42TableAdapters.SpReportGoodsReceiptDetaildTableAdapter SpReportGoodsReceiptDetaildTableAdapter;
    }
}