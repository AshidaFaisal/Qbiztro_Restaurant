namespace BisCarePosEdition
{
    partial class FrmReportOtherIncome
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
            this.dbBizcarePosDataSetReportOtherIncome = new BisCarePosEdition.dbBizcarePosDataSetReportOtherIncome();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spReportOtherIncomeTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetReportOtherIncomeTableAdapters.spReportOtherIncomeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spReportOtherIncomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReportOtherIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // spReportOtherIncomeBindingSource
            // 
            this.spReportOtherIncomeBindingSource.DataMember = "spReportOtherIncome";
            this.spReportOtherIncomeBindingSource.DataSource = this.dbBizcarePosDataSetReportOtherIncome;
            // 
            // dbBizcarePosDataSetReportOtherIncome
            // 
            this.dbBizcarePosDataSetReportOtherIncome.DataSetName = "dbBizcarePosDataSetReportOtherIncome";
            this.dbBizcarePosDataSetReportOtherIncome.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spReportOtherIncomeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportOtherIncome.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(774, 564);
            this.reportViewer1.TabIndex = 0;
            // 
            // spReportOtherIncomeTableAdapter
            // 
            this.spReportOtherIncomeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportOtherIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 564);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportOtherIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Other Income Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReportOtherIncome_FormClosing);
            this.Load += new System.EventHandler(this.FrmReportOtherIncome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spReportOtherIncomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReportOtherIncome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReportOtherIncomeBindingSource;
        private dbBizcarePosDataSetReportOtherIncome dbBizcarePosDataSetReportOtherIncome;
        private dbBizcarePosDataSetReportOtherIncomeTableAdapters.spReportOtherIncomeTableAdapter spReportOtherIncomeTableAdapter;
    }
}