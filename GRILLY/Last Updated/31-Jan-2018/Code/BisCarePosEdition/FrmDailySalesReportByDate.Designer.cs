namespace BisCarePosEdition
{
    partial class FrmDailySalesReportByDate
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
            this.dbBizcarePosDataSet26 = new BisCarePosEdition.dbBizcarePosDataSet26();
            this.spGetDailySaleReportByDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetDailySaleReportByDateTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet26TableAdapters.spGetDailySaleReportByDateTableAdapter();
            this.dbBizcarePosDataSet27 = new BisCarePosEdition.dbBizcarePosDataSet27();
            this.spGetDailySaleReportByDateComplimentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetDailySaleReportByDateComplimentTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet27TableAdapters.spGetDailySaleReportByDateComplimentTableAdapter();
            this.dbBizcarePosDataSetGetInvoiceMstrAmount = new BisCarePosEdition.dbBizcarePosDataSetGetInvoiceMstrAmount();
            this.SpGetInvoiceMasterAmountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SpGetInvoiceMasterAmountsTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetGetInvoiceMstrAmountTableAdapters.SpGetInvoiceMasterAmountsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetDailySaleReportByDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetDailySaleReportByDateComplimentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetGetInvoiceMstrAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpGetInvoiceMasterAmountsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spGetDailySaleReportByDateBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.spGetDailySaleReportByDateComplimentBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.SpGetInvoiceMasterAmountsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.SalesReportByDate.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(789, 486);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dbBizcarePosDataSet26
            // 
            this.dbBizcarePosDataSet26.DataSetName = "dbBizcarePosDataSet26";
            this.dbBizcarePosDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spGetDailySaleReportByDateBindingSource
            // 
            this.spGetDailySaleReportByDateBindingSource.DataMember = "spGetDailySaleReportByDate";
            this.spGetDailySaleReportByDateBindingSource.DataSource = this.dbBizcarePosDataSet26;
            // 
            // spGetDailySaleReportByDateTableAdapter
            // 
            this.spGetDailySaleReportByDateTableAdapter.ClearBeforeFill = true;
            // 
            // dbBizcarePosDataSet27
            // 
            this.dbBizcarePosDataSet27.DataSetName = "dbBizcarePosDataSet27";
            this.dbBizcarePosDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spGetDailySaleReportByDateComplimentBindingSource
            // 
            this.spGetDailySaleReportByDateComplimentBindingSource.DataMember = "spGetDailySaleReportByDateCompliment";
            this.spGetDailySaleReportByDateComplimentBindingSource.DataSource = this.dbBizcarePosDataSet27;
            // 
            // spGetDailySaleReportByDateComplimentTableAdapter
            // 
            this.spGetDailySaleReportByDateComplimentTableAdapter.ClearBeforeFill = true;
            // 
            // dbBizcarePosDataSetGetInvoiceMstrAmount
            // 
            this.dbBizcarePosDataSetGetInvoiceMstrAmount.DataSetName = "dbBizcarePosDataSetGetInvoiceMstrAmount";
            this.dbBizcarePosDataSetGetInvoiceMstrAmount.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SpGetInvoiceMasterAmountsBindingSource
            // 
            this.SpGetInvoiceMasterAmountsBindingSource.DataMember = "SpGetInvoiceMasterAmounts";
            this.SpGetInvoiceMasterAmountsBindingSource.DataSource = this.dbBizcarePosDataSetGetInvoiceMstrAmount;
            // 
            // SpGetInvoiceMasterAmountsTableAdapter
            // 
            this.SpGetInvoiceMasterAmountsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDailySalesReportByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 486);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmDailySalesReportByDate";
            this.Text = "Daily Sales Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDailySalesReportByDate_FormClosing);
            this.Load += new System.EventHandler(this.FrmDailySalesReportByDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetDailySaleReportByDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetDailySaleReportByDateComplimentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetGetInvoiceMstrAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpGetInvoiceMasterAmountsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spGetDailySaleReportByDateBindingSource;
        private dbBizcarePosDataSet26 dbBizcarePosDataSet26;
        private System.Windows.Forms.BindingSource spGetDailySaleReportByDateComplimentBindingSource;
        private dbBizcarePosDataSet27 dbBizcarePosDataSet27;
        private System.Windows.Forms.BindingSource SpGetInvoiceMasterAmountsBindingSource;
        private dbBizcarePosDataSetGetInvoiceMstrAmount dbBizcarePosDataSetGetInvoiceMstrAmount;
        private dbBizcarePosDataSet26TableAdapters.spGetDailySaleReportByDateTableAdapter spGetDailySaleReportByDateTableAdapter;
        private dbBizcarePosDataSet27TableAdapters.spGetDailySaleReportByDateComplimentTableAdapter spGetDailySaleReportByDateComplimentTableAdapter;
        private dbBizcarePosDataSetGetInvoiceMstrAmountTableAdapters.SpGetInvoiceMasterAmountsTableAdapter SpGetInvoiceMasterAmountsTableAdapter;
    }
}