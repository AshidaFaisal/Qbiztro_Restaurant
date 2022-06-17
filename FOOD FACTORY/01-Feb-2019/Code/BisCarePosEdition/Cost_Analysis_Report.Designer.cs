namespace BisCarePosEdition
{
    partial class Cost_Analysis_Report
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DB_QbiztroDataSet = new BisCarePosEdition.DB_QbiztroDataSet();
            this.SP_Cost_Analysis_ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_Cost_Analysis_ReportTableAdapter = new BisCarePosEdition.DB_QbiztroDataSetTableAdapters.SP_Cost_Analysis_ReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DB_QbiztroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Cost_Analysis_ReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SP_Cost_Analysis_ReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.Report_Cost_Analysis.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(601, 430);
            this.reportViewer1.TabIndex = 0;
            // 
            // DB_QbiztroDataSet
            // 
            this.DB_QbiztroDataSet.DataSetName = "DB_QbiztroDataSet";
            this.DB_QbiztroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_Cost_Analysis_ReportBindingSource
            // 
            this.SP_Cost_Analysis_ReportBindingSource.DataMember = "SP_Cost_Analysis_Report";
            this.SP_Cost_Analysis_ReportBindingSource.DataSource = this.DB_QbiztroDataSet;
            // 
            // SP_Cost_Analysis_ReportTableAdapter
            // 
            this.SP_Cost_Analysis_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // Cost_Analysis_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 430);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Cost_Analysis_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cost Analysis Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cost_Analysis_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DB_QbiztroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Cost_Analysis_ReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_Cost_Analysis_ReportBindingSource;
        private DB_QbiztroDataSet DB_QbiztroDataSet;
        private DB_QbiztroDataSetTableAdapters.SP_Cost_Analysis_ReportTableAdapter SP_Cost_Analysis_ReportTableAdapter;
    }
}