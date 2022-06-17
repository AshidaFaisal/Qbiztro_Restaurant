namespace BisCarePosEdition
{
    partial class FrmDeletedKotDetails
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
            this.spReportDeletedKotDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSetReportDeleatedKotDetails = new BisCarePosEdition.dbBizcarePosDataSetReportDeleatedKotDetails();
            this.spReportDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSet1 = new BisCarePosEdition.dbBizcarePosDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spReportDeletedKotDetailTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetReportDeleatedKotDetailsTableAdapters.spReportDeletedKotDetailTableAdapter();
            this.dbBizcarePosDataSetReportDeleteKotDetailsnew = new BisCarePosEdition.dbBizcarePosDataSetReportDeleteKotDetailsnew();
            this.spReportDatesTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet1TableAdapters.spReportDatesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDeletedKotDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReportDeleatedKotDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReportDeleteKotDetailsnew)).BeginInit();
            this.SuspendLayout();
            // 
            // spReportDeletedKotDetailBindingSource
            // 
            this.spReportDeletedKotDetailBindingSource.DataMember = "spReportDeletedKotDetail";
            this.spReportDeletedKotDetailBindingSource.DataSource = this.dbBizcarePosDataSetReportDeleatedKotDetails;
            // 
            // dbBizcarePosDataSetReportDeleatedKotDetails
            // 
            this.dbBizcarePosDataSetReportDeleatedKotDetails.DataSetName = "dbBizcarePosDataSetReportDeleatedKotDetails";
            this.dbBizcarePosDataSetReportDeleatedKotDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spReportDatesBindingSource
            // 
            this.spReportDatesBindingSource.DataMember = "spReportDates";
            this.spReportDatesBindingSource.DataSource = this.dbBizcarePosDataSet1;
            // 
            // dbBizcarePosDataSet1
            // 
            this.dbBizcarePosDataSet1.DataSetName = "dbBizcarePosDataSet1";
            this.dbBizcarePosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spReportDeletedKotDetailBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.spReportDatesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportDeletedKotDetails.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(766, 568);
            this.reportViewer1.TabIndex = 0;
            // 
            // spReportDeletedKotDetailTableAdapter
            // 
            this.spReportDeletedKotDetailTableAdapter.ClearBeforeFill = true;
            // 
            // dbBizcarePosDataSetReportDeleteKotDetailsnew
            // 
            this.dbBizcarePosDataSetReportDeleteKotDetailsnew.DataSetName = "dbBizcarePosDataSetReportDeleteKotDetailsnew";
            this.dbBizcarePosDataSetReportDeleteKotDetailsnew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spReportDatesTableAdapter
            // 
            this.spReportDatesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDeletedKotDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 568);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmDeletedKotDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deleted KOT Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDeletedKotDetails_FormClosing);
            this.Load += new System.EventHandler(this.FrmDeletedKotDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spReportDeletedKotDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReportDeleatedKotDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetReportDeleteKotDetailsnew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReportDeletedKotDetailBindingSource;
        private dbBizcarePosDataSetReportDeleatedKotDetails dbBizcarePosDataSetReportDeleatedKotDetails;
        private dbBizcarePosDataSetReportDeleatedKotDetailsTableAdapters.spReportDeletedKotDetailTableAdapter spReportDeletedKotDetailTableAdapter;
        private dbBizcarePosDataSetReportDeleteKotDetailsnew dbBizcarePosDataSetReportDeleteKotDetailsnew;
        private System.Windows.Forms.BindingSource spReportDatesBindingSource;
        private dbBizcarePosDataSet1 dbBizcarePosDataSet1;
        private dbBizcarePosDataSet1TableAdapters.spReportDatesTableAdapter spReportDatesTableAdapter;
    }
}