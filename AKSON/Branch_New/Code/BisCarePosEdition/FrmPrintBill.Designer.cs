namespace BisCarePosEdition
{
    partial class FrmPrintBill
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
            this.SpgetRestaurentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSet18 = new BisCarePosEdition.dbBizcarePosDataSet18();
            this.spPrintBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSet22 = new BisCarePosEdition.dbBizcarePosDataSet22();
            this.sp_EditCounterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSet32 = new BisCarePosEdition.dbBizcarePosDataSet32();
            this.SpGetInvoiceAmountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSetGetIvoiceAmount = new BisCarePosEdition.dbBizcarePosDataSetGetIvoiceAmount();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SpgetRestaurentTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet18TableAdapters.SpgetRestaurentTableAdapter();
            this.spPrintBillTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet22TableAdapters.spPrintBillTableAdapter();
            this.sp_EditCounterTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet32TableAdapters.sp_EditCounterTableAdapter();
            this.SpGetInvoiceAmountsTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetGetIvoiceAmountTableAdapters.SpGetInvoiceAmountsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SpgetRestaurentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPrintBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_EditCounterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpGetInvoiceAmountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetGetIvoiceAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // SpgetRestaurentBindingSource
            // 
            this.SpgetRestaurentBindingSource.DataMember = "SpgetRestaurent";
            this.SpgetRestaurentBindingSource.DataSource = this.dbBizcarePosDataSet18;
            // 
            // dbBizcarePosDataSet18
            // 
            this.dbBizcarePosDataSet18.DataSetName = "dbBizcarePosDataSet18";
            this.dbBizcarePosDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spPrintBillBindingSource
            // 
            this.spPrintBillBindingSource.DataMember = "spPrintBill";
            this.spPrintBillBindingSource.DataSource = this.dbBizcarePosDataSet22;
            // 
            // dbBizcarePosDataSet22
            // 
            this.dbBizcarePosDataSet22.DataSetName = "dbBizcarePosDataSet22";
            this.dbBizcarePosDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_EditCounterBindingSource
            // 
            this.sp_EditCounterBindingSource.DataMember = "sp_EditCounter";
            this.sp_EditCounterBindingSource.DataSource = this.dbBizcarePosDataSet32;
            // 
            // dbBizcarePosDataSet32
            // 
            this.dbBizcarePosDataSet32.DataSetName = "dbBizcarePosDataSet32";
            this.dbBizcarePosDataSet32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SpGetInvoiceAmountsBindingSource
            // 
            this.SpGetInvoiceAmountsBindingSource.DataMember = "SpGetInvoiceAmounts";
            this.SpGetInvoiceAmountsBindingSource.DataSource = this.dbBizcarePosDataSetGetIvoiceAmount;
            // 
            // dbBizcarePosDataSetGetIvoiceAmount
            // 
            this.dbBizcarePosDataSetGetIvoiceAmount.DataSetName = "dbBizcarePosDataSetGetIvoiceAmount";
            this.dbBizcarePosDataSetGetIvoiceAmount.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.SpgetRestaurentBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.spPrintBillBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.sp_EditCounterBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.SpGetInvoiceAmountsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.PrintBill.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(799, 426);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // SpgetRestaurentTableAdapter
            // 
            this.SpgetRestaurentTableAdapter.ClearBeforeFill = true;
            // 
            // spPrintBillTableAdapter
            // 
            this.spPrintBillTableAdapter.ClearBeforeFill = true;
            // 
            // sp_EditCounterTableAdapter
            // 
            this.sp_EditCounterTableAdapter.ClearBeforeFill = true;
            // 
            // SpGetInvoiceAmountsTableAdapter
            // 
            this.SpGetInvoiceAmountsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 426);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmPrintBill";
            this.Text = "Print Bill";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrintBill_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrintBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpgetRestaurentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPrintBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_EditCounterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpGetInvoiceAmountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetGetIvoiceAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SpgetRestaurentBindingSource;
        private dbBizcarePosDataSet18 dbBizcarePosDataSet18;
        private System.Windows.Forms.BindingSource spPrintBillBindingSource;
        private dbBizcarePosDataSet22 dbBizcarePosDataSet22;
        private System.Windows.Forms.BindingSource sp_EditCounterBindingSource;
        private dbBizcarePosDataSet32 dbBizcarePosDataSet32;
        private System.Windows.Forms.BindingSource SpGetInvoiceAmountsBindingSource;
        private dbBizcarePosDataSetGetIvoiceAmount dbBizcarePosDataSetGetIvoiceAmount;
        private dbBizcarePosDataSet18TableAdapters.SpgetRestaurentTableAdapter SpgetRestaurentTableAdapter;
        private dbBizcarePosDataSet22TableAdapters.spPrintBillTableAdapter spPrintBillTableAdapter;
        private dbBizcarePosDataSet32TableAdapters.sp_EditCounterTableAdapter sp_EditCounterTableAdapter;
        private dbBizcarePosDataSetGetIvoiceAmountTableAdapters.SpGetInvoiceAmountsTableAdapter SpGetInvoiceAmountsTableAdapter;



    }
}