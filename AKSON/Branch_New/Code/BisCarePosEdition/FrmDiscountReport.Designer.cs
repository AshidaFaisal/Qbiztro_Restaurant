namespace BisCarePosEdition
{
    partial class FrmDiscountReport
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
            this.DS_DiscountReport = new BisCarePosEdition.DS_DiscountReport();
            this.SP_R_InvoiceDiscountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_R_InvoiceDiscountTableAdapter = new BisCarePosEdition.DS_DiscountReportTableAdapters.SP_R_InvoiceDiscountTableAdapter();
            this.dbBizcarePosDataSet31 = new BisCarePosEdition.dbBizcarePosDataSet31();
            this.spReportDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spReportDatesTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet31TableAdapters.spReportDatesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DS_DiscountReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_R_InvoiceDiscountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_R_InvoiceDiscountBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.spReportDatesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.RDLC_InvoiceDiscountReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // DS_DiscountReport
            // 
            this.DS_DiscountReport.DataSetName = "DS_DiscountReport";
            this.DS_DiscountReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_R_InvoiceDiscountBindingSource
            // 
            this.SP_R_InvoiceDiscountBindingSource.DataMember = "SP_R_InvoiceDiscount";
            this.SP_R_InvoiceDiscountBindingSource.DataSource = this.DS_DiscountReport;
            // 
            // SP_R_InvoiceDiscountTableAdapter
            // 
            this.SP_R_InvoiceDiscountTableAdapter.ClearBeforeFill = true;
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
            // spReportDatesTableAdapter
            // 
            this.spReportDatesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDiscountReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmDiscountReport";
            this.Text = "FrmDiscountReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDiscountReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_DiscountReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_R_InvoiceDiscountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDatesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_R_InvoiceDiscountBindingSource;
        private DS_DiscountReport DS_DiscountReport;
        private System.Windows.Forms.BindingSource spReportDatesBindingSource;
        private dbBizcarePosDataSet31 dbBizcarePosDataSet31;
        private DS_DiscountReportTableAdapters.SP_R_InvoiceDiscountTableAdapter SP_R_InvoiceDiscountTableAdapter;
        private dbBizcarePosDataSet31TableAdapters.spReportDatesTableAdapter spReportDatesTableAdapter;
    }
}