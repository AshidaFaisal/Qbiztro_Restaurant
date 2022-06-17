namespace BisCarePosEdition
{
    partial class Frmsaleanalysisreport1
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
            this.SP_SALE_ANALYSIS_REPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DB_QbiztroDataSet1 = new BisCarePosEdition.DB_QbiztroDataSet1();
            this.SP_SALE_ANALYSIS_REPORTTableAdapter = new BisCarePosEdition.DB_QbiztroDataSet1TableAdapters.SP_SALE_ANALYSIS_REPORTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_SALE_ANALYSIS_REPORTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_QbiztroDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SP_SALE_ANALYSIS_REPORTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.SaleAnalysisReports.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 252);
            this.reportViewer1.TabIndex = 0;
            // 
            // SP_SALE_ANALYSIS_REPORTBindingSource
            // 
            this.SP_SALE_ANALYSIS_REPORTBindingSource.DataMember = "SP_SALE_ANALYSIS_REPORT";
            this.SP_SALE_ANALYSIS_REPORTBindingSource.DataSource = this.DB_QbiztroDataSet1;
            // 
            // DB_QbiztroDataSet1
            // 
            this.DB_QbiztroDataSet1.DataSetName = "DB_QbiztroDataSet1";
            this.DB_QbiztroDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_SALE_ANALYSIS_REPORTTableAdapter
            // 
            this.SP_SALE_ANALYSIS_REPORTTableAdapter.ClearBeforeFill = true;
            // 
            // Frmsaleanalysisreport1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 252);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frmsaleanalysisreport1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmsaleanalysisreport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmsaleanalysisreport1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_SALE_ANALYSIS_REPORTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_QbiztroDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_SALE_ANALYSIS_REPORTBindingSource;
        private DB_QbiztroDataSet1 DB_QbiztroDataSet1;
        private DB_QbiztroDataSet1TableAdapters.SP_SALE_ANALYSIS_REPORTTableAdapter SP_SALE_ANALYSIS_REPORTTableAdapter;
    }
}