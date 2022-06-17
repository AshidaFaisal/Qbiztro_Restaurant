namespace BisCarePosEdition
{
    partial class FrmDailySalesReport
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
            this.spGetDailySaleReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSetReportDailySalesReport = new BisCarePosEdition.dbBizcarePosDataSetReportDailySalesReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spGetDailySaleReportTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetReportDailySalesReportTableAdapters.spGetDailySaleReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spGetDailySaleReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReportDailySalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // spGetDailySaleReportBindingSource
            // 
            this.spGetDailySaleReportBindingSource.DataMember = "spGetDailySaleReport";
            this.spGetDailySaleReportBindingSource.DataSource = this.dbBizcarePosDataSetReportDailySalesReport;
            // 
            // dbBizcarePosDataSetReportDailySalesReport
            // 
            this.dbBizcarePosDataSetReportDailySalesReport.DataSetName = "dbBizcarePosDataSetReportDailySalesReport";
            this.dbBizcarePosDataSetReportDailySalesReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spGetDailySaleReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportDailySales.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(788, 540);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // spGetDailySaleReportTableAdapter
            // 
            this.spGetDailySaleReportTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDailySalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 540);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmDailySalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Sales Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDailySalesReport_FormClosing);
            this.Load += new System.EventHandler(this.FrmDailySalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spGetDailySaleReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReportDailySalesReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spGetDailySaleReportBindingSource;
        private dbBizcarePosDataSetReportDailySalesReport dbBizcarePosDataSetReportDailySalesReport;
        private dbBizcarePosDataSetReportDailySalesReportTableAdapters.spGetDailySaleReportTableAdapter spGetDailySaleReportTableAdapter;
    }
}