namespace BisCarePosEdition
{
    partial class FrmOtherExpenceReport
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
            this.spReportOtherExpenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSetReportOtherExpenceType = new BisCarePosEdition.dbBizcarePosDataSetReportOtherExpenceType();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spReportOtherExpenceTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetReportOtherExpenceTypeTableAdapters.spReportOtherExpenceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spReportOtherExpenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReportOtherExpenceType)).BeginInit();
            this.SuspendLayout();
            // 
            // spReportOtherExpenceBindingSource
            // 
            this.spReportOtherExpenceBindingSource.DataMember = "spReportOtherExpence";
            this.spReportOtherExpenceBindingSource.DataSource = this.dbBizcarePosDataSetReportOtherExpenceType;
            // 
            // dbBizcarePosDataSetReportOtherExpenceType
            // 
            this.dbBizcarePosDataSetReportOtherExpenceType.DataSetName = "dbBizcarePosDataSetReportOtherExpenceType";
            this.dbBizcarePosDataSetReportOtherExpenceType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spReportOtherExpenceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportOtherExpenceType.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(795, 646);
            this.reportViewer1.TabIndex = 0;
            // 
            // spReportOtherExpenceTableAdapter
            // 
            this.spReportOtherExpenceTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOtherExpenceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 646);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmOtherExpenceReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Other Expence Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOtherExpenceReport_FormClosing);
            this.Load += new System.EventHandler(this.FrmOtherExpenceReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spReportOtherExpenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReportOtherExpenceType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReportOtherExpenceBindingSource;
        private dbBizcarePosDataSetReportOtherExpenceType dbBizcarePosDataSetReportOtherExpenceType;
        private dbBizcarePosDataSetReportOtherExpenceTypeTableAdapters.spReportOtherExpenceTableAdapter spReportOtherExpenceTableAdapter;
    }
}