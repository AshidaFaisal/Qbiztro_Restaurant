namespace BisCarePosEdition
{
    partial class FrmReportOtherIncomeType
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
            this.spReportOtherIncomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSetReportOtherIncomeType = new BisCarePosEdition.dbBizcarePosDataSetReportOtherIncomeType();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spReportOtherIncomeTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetReportOtherIncomeTypeTableAdapters.spReportOtherIncomeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spReportOtherIncomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReportOtherIncomeType)).BeginInit();
            this.SuspendLayout();
            // 
            // spReportOtherIncomeBindingSource
            // 
            this.spReportOtherIncomeBindingSource.DataMember = "spReportOtherIncome";
            this.spReportOtherIncomeBindingSource.DataSource = this.dbBizcarePosDataSetReportOtherIncomeType;
            // 
            // dbBizcarePosDataSetReportOtherIncomeType
            // 
            this.dbBizcarePosDataSetReportOtherIncomeType.DataSetName = "dbBizcarePosDataSetReportOtherIncomeType";
            this.dbBizcarePosDataSetReportOtherIncomeType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spReportOtherIncomeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportOtherIncomeType.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(825, 635);
            this.reportViewer1.TabIndex = 0;
            // 
            // spReportOtherIncomeTableAdapter
            // 
            this.spReportOtherIncomeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportOtherIncomeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 635);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportOtherIncomeType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Other Income Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReportOtherIncomeType_FormClosing);
            this.Load += new System.EventHandler(this.FrmReportOtherIncomeType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spReportOtherIncomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReportOtherIncomeType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReportOtherIncomeBindingSource;
        private dbBizcarePosDataSetReportOtherIncomeType dbBizcarePosDataSetReportOtherIncomeType;
        private dbBizcarePosDataSetReportOtherIncomeTypeTableAdapters.spReportOtherIncomeTableAdapter spReportOtherIncomeTableAdapter;
    }
}