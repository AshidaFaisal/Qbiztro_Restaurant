namespace BisCarePosEdition
{
    partial class FrmReportOtherExpence
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
            this.dbBizcarePosDataSetReportOtherExpence = new BisCarePosEdition.dbBizcarePosDataSetReportOtherExpence();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spReportOtherExpenceTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetReportOtherExpenceTableAdapters.spReportOtherExpenceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spReportOtherExpenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReportOtherExpence)).BeginInit();
            this.SuspendLayout();
            // 
            // spReportOtherExpenceBindingSource
            // 
            this.spReportOtherExpenceBindingSource.DataMember = "spReportOtherExpence";
            this.spReportOtherExpenceBindingSource.DataSource = this.dbBizcarePosDataSetReportOtherExpence;
            // 
            // dbBizcarePosDataSetReportOtherExpence
            // 
            this.dbBizcarePosDataSetReportOtherExpence.DataSetName = "dbBizcarePosDataSetReportOtherExpence";
            this.dbBizcarePosDataSetReportOtherExpence.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spReportOtherExpenceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportOtherExpence.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(769, 588);
            this.reportViewer1.TabIndex = 0;
            // 
            // spReportOtherExpenceTableAdapter
            // 
            this.spReportOtherExpenceTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportOtherExpence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 588);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportOtherExpence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Other Expense Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReportOtherExpence_FormClosing);
            this.Load += new System.EventHandler(this.FrmReportOtherExpence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spReportOtherExpenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReportOtherExpence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReportOtherExpenceBindingSource;
        private dbBizcarePosDataSetReportOtherExpence dbBizcarePosDataSetReportOtherExpence;
        private dbBizcarePosDataSetReportOtherExpenceTableAdapters.spReportOtherExpenceTableAdapter spReportOtherExpenceTableAdapter;
    }
}