namespace BisCarePosEdition
{
    partial class FrmKotPrintTake
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
            this.spPrintKotTakeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSet7 = new BisCarePosEdition.dbBizcarePosDataSet7();
            this.SpgetRestaurentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_EditCounterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosOldDataSet2 = new BisCarePosEdition.dbBizcarePosOldDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spPrintKotTakeTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet7TableAdapters.spPrintKotTakeTableAdapter();
            this.SpgetRestaurentTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet7TableAdapters.SpgetRestaurentTableAdapter();
            this.sp_EditCounterTableAdapter = new BisCarePosEdition.dbBizcarePosOldDataSet2TableAdapters.sp_EditCounterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spPrintKotTakeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpgetRestaurentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_EditCounterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosOldDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // spPrintKotTakeBindingSource
            // 
            this.spPrintKotTakeBindingSource.DataMember = "spPrintKotTake";
            this.spPrintKotTakeBindingSource.DataSource = this.dbBizcarePosDataSet7;
            // 
            // dbBizcarePosDataSet7
            // 
            this.dbBizcarePosDataSet7.DataSetName = "dbBizcarePosDataSet7";
            this.dbBizcarePosDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SpgetRestaurentBindingSource
            // 
            this.SpgetRestaurentBindingSource.DataMember = "SpgetRestaurent";
            this.SpgetRestaurentBindingSource.DataSource = this.dbBizcarePosDataSet7;
            // 
            // sp_EditCounterBindingSource
            // 
            this.sp_EditCounterBindingSource.DataMember = "sp_EditCounter";
            this.sp_EditCounterBindingSource.DataSource = this.dbBizcarePosOldDataSet2;
            // 
            // dbBizcarePosOldDataSet2
            // 
            this.dbBizcarePosOldDataSet2.DataSetName = "dbBizcarePosOldDataSet2";
            this.dbBizcarePosOldDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spPrintKotTakeBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.SpgetRestaurentBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.sp_EditCounterBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.PrintKotTake.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(709, 418);
            this.reportViewer1.TabIndex = 0;
            // 
            // spPrintKotTakeTableAdapter
            // 
            this.spPrintKotTakeTableAdapter.ClearBeforeFill = true;
            // 
            // SpgetRestaurentTableAdapter
            // 
            this.SpgetRestaurentTableAdapter.ClearBeforeFill = true;
            // 
            // sp_EditCounterTableAdapter
            // 
            this.sp_EditCounterTableAdapter.ClearBeforeFill = true;
            // 
            // FrmKotPrintTake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 418);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmKotPrintTake";
            this.Text = "Print KOT Take Away";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKotPrintTake_FormClosing);
            this.Load += new System.EventHandler(this.FrmKotPrintTake_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spPrintKotTakeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpgetRestaurentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_EditCounterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosOldDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spPrintKotTakeBindingSource;
        private dbBizcarePosDataSet7 dbBizcarePosDataSet7;
        private System.Windows.Forms.BindingSource SpgetRestaurentBindingSource;
        private dbBizcarePosDataSet7TableAdapters.spPrintKotTakeTableAdapter spPrintKotTakeTableAdapter;
        private dbBizcarePosDataSet7TableAdapters.SpgetRestaurentTableAdapter SpgetRestaurentTableAdapter;
        private System.Windows.Forms.BindingSource sp_EditCounterBindingSource;
        private dbBizcarePosOldDataSet2 dbBizcarePosOldDataSet2;
        private dbBizcarePosOldDataSet2TableAdapters.sp_EditCounterTableAdapter sp_EditCounterTableAdapter;
    }
}