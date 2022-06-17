namespace BisCarePosEdition
{
    partial class FrmGoodsReceiptBrief
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
            this.dbBizcarePosDataSet34 = new BisCarePosEdition.dbBizcarePosDataSet34();
            this.spReportGoodsReceiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spReportGoodsReceiptTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet34TableAdapters.spReportGoodsReceiptTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportGoodsReceiptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spReportGoodsReceiptBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(916, 504);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.SizeChanged += new System.EventHandler(this.reportViewer1_SizeChanged);
            // 
            // dbBizcarePosDataSet34
            // 
            this.dbBizcarePosDataSet34.DataSetName = "dbBizcarePosDataSet34";
            this.dbBizcarePosDataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spReportGoodsReceiptBindingSource
            // 
            this.spReportGoodsReceiptBindingSource.DataMember = "spReportGoodsReceipt";
            this.spReportGoodsReceiptBindingSource.DataSource = this.dbBizcarePosDataSet34;
            // 
            // spReportGoodsReceiptTableAdapter
            // 
            this.spReportGoodsReceiptTableAdapter.ClearBeforeFill = true;
            // 
            // FrmGoodsReceiptBrief
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 466);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmGoodsReceiptBrief";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGoodsReceiptBrief";
            this.Load += new System.EventHandler(this.FrmGoodsReceiptBrief_Load);
            this.SizeChanged += new System.EventHandler(this.FrmGoodsReceiptBrief_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportGoodsReceiptBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReportGoodsReceiptBindingSource;
        private dbBizcarePosDataSet34 dbBizcarePosDataSet34;
        private dbBizcarePosDataSet34TableAdapters.spReportGoodsReceiptTableAdapter spReportGoodsReceiptTableAdapter;
    }
}