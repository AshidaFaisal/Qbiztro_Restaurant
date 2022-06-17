namespace BisCarePosEdition
{
    partial class FrmReportPayable
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
            this.dbBizcarePosDataSetPayableReport = new BisCarePosEdition.dbBizcarePosDataSetPayableReport();
            this.spReportPayableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spReportPayableTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetPayableReportTableAdapters.spReportPayableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetPayableReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportPayableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spReportPayableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportPayable.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(816, 491);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbBizcarePosDataSetPayableReport
            // 
            this.dbBizcarePosDataSetPayableReport.DataSetName = "dbBizcarePosDataSetPayableReport";
            this.dbBizcarePosDataSetPayableReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spReportPayableBindingSource
            // 
            this.spReportPayableBindingSource.DataMember = "spReportPayable";
            this.spReportPayableBindingSource.DataSource = this.dbBizcarePosDataSetPayableReport;
            // 
            // spReportPayableTableAdapter
            // 
            this.spReportPayableTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportPayable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 491);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportPayable";
            this.Text = "Payable Report";
            this.Load += new System.EventHandler(this.FrmReportPayable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetPayableReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportPayableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReportPayableBindingSource;
        private dbBizcarePosDataSetPayableReport dbBizcarePosDataSetPayableReport;
        private dbBizcarePosDataSetPayableReportTableAdapters.spReportPayableTableAdapter spReportPayableTableAdapter;
    }
}