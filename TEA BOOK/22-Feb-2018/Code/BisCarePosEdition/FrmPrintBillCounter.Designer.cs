namespace BisCarePosEdition
{
    partial class FrmPrintBillCounter
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbBizcarePosDataSet19 = new BisCarePosEdition.dbBizcarePosDataSet19();
            this.SpgetRestaurentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SpgetRestaurentTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet19TableAdapters.SpgetRestaurentTableAdapter();
            this.dbBizcarePosDataSet23 = new BisCarePosEdition.dbBizcarePosDataSet23();
            this.spPrintBillCounterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spPrintBillCounterTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet23TableAdapters.spPrintBillCounterTableAdapter();
            this.dbBizcarePosDataSet33 = new BisCarePosEdition.dbBizcarePosDataSet33();
            this.sp_EditCounterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_EditCounterTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet33TableAdapters.sp_EditCounterTableAdapter();
            this.dbBizcarePosDataSetGetInvoiceAMnt = new BisCarePosEdition.dbBizcarePosDataSetGetInvoiceAMnt();
            this.SpGetInvoiceAmountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SpGetInvoiceAmountsTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetGetInvoiceAMntTableAdapters.SpGetInvoiceAmountsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpgetRestaurentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPrintBillCounterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_EditCounterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetGetInvoiceAMnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpGetInvoiceAmountsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.SpgetRestaurentBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.spPrintBillCounterBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.sp_EditCounterBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.SpGetInvoiceAmountsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.PrintCounter.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(762, 379);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dbBizcarePosDataSet19
            // 
            this.dbBizcarePosDataSet19.DataSetName = "dbBizcarePosDataSet19";
            this.dbBizcarePosDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SpgetRestaurentBindingSource
            // 
            this.SpgetRestaurentBindingSource.DataMember = "SpgetRestaurent";
            this.SpgetRestaurentBindingSource.DataSource = this.dbBizcarePosDataSet19;
            // 
            // SpgetRestaurentTableAdapter
            // 
            this.SpgetRestaurentTableAdapter.ClearBeforeFill = true;
            // 
            // dbBizcarePosDataSet23
            // 
            this.dbBizcarePosDataSet23.DataSetName = "dbBizcarePosDataSet23";
            this.dbBizcarePosDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spPrintBillCounterBindingSource
            // 
            this.spPrintBillCounterBindingSource.DataMember = "spPrintBillCounter";
            this.spPrintBillCounterBindingSource.DataSource = this.dbBizcarePosDataSet23;
            // 
            // spPrintBillCounterTableAdapter
            // 
            this.spPrintBillCounterTableAdapter.ClearBeforeFill = true;
            // 
            // dbBizcarePosDataSet33
            // 
            this.dbBizcarePosDataSet33.DataSetName = "dbBizcarePosDataSet33";
            this.dbBizcarePosDataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_EditCounterBindingSource
            // 
            this.sp_EditCounterBindingSource.DataMember = "sp_EditCounter";
            this.sp_EditCounterBindingSource.DataSource = this.dbBizcarePosDataSet33;
            // 
            // sp_EditCounterTableAdapter
            // 
            this.sp_EditCounterTableAdapter.ClearBeforeFill = true;
            // 
            // dbBizcarePosDataSetGetInvoiceAMnt
            // 
            this.dbBizcarePosDataSetGetInvoiceAMnt.DataSetName = "dbBizcarePosDataSetGetInvoiceAMnt";
            this.dbBizcarePosDataSetGetInvoiceAMnt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SpGetInvoiceAmountsBindingSource
            // 
            this.SpGetInvoiceAmountsBindingSource.DataMember = "SpGetInvoiceAmounts";
            this.SpGetInvoiceAmountsBindingSource.DataSource = this.dbBizcarePosDataSetGetInvoiceAMnt;
            // 
            // SpGetInvoiceAmountsTableAdapter
            // 
            this.SpGetInvoiceAmountsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintBillCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 379);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmPrintBillCounter";
            this.Text = "Print Bill";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrintBillCounter_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrintBillCounter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpgetRestaurentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPrintBillCounterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_EditCounterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetGetInvoiceAMnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpGetInvoiceAmountsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SpgetRestaurentBindingSource;
        private dbBizcarePosDataSet19 dbBizcarePosDataSet19;
        private System.Windows.Forms.BindingSource spPrintBillCounterBindingSource;
        private dbBizcarePosDataSet23 dbBizcarePosDataSet23;
        private System.Windows.Forms.BindingSource sp_EditCounterBindingSource;
        private dbBizcarePosDataSet33 dbBizcarePosDataSet33;
        private System.Windows.Forms.BindingSource SpGetInvoiceAmountsBindingSource;
        private dbBizcarePosDataSetGetInvoiceAMnt dbBizcarePosDataSetGetInvoiceAMnt;
        private dbBizcarePosDataSet19TableAdapters.SpgetRestaurentTableAdapter SpgetRestaurentTableAdapter;
        private dbBizcarePosDataSet23TableAdapters.spPrintBillCounterTableAdapter spPrintBillCounterTableAdapter;
        private dbBizcarePosDataSet33TableAdapters.sp_EditCounterTableAdapter sp_EditCounterTableAdapter;
        private dbBizcarePosDataSetGetInvoiceAMntTableAdapters.SpGetInvoiceAmountsTableAdapter SpGetInvoiceAmountsTableAdapter;
    }
}