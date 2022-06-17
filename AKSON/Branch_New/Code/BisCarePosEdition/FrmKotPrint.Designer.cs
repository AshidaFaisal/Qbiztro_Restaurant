namespace BisCarePosEdition
{
    partial class FrmKotPrint
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
            this.spPrintKotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSet5 = new BisCarePosEdition.dbBizcarePosDataSet5();
            this.SpgetRestaurentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosDataSet6 = new BisCarePosEdition.dbBizcarePosDataSet6();
            this.sp_EditCounterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBizcarePosOldDataSet = new BisCarePosEdition.dbBizcarePosOldDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spPrintKotTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet5TableAdapters.spPrintKotTableAdapter();
            this.SpgetRestaurentTableAdapter = new BisCarePosEdition.dbBizcarePosDataSet6TableAdapters.SpgetRestaurentTableAdapter();
            this.sp_EditCounterTableAdapter = new BisCarePosEdition.dbBizcarePosOldDataSetTableAdapters.sp_EditCounterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spPrintKotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpgetRestaurentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_EditCounterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosOldDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // spPrintKotBindingSource
            // 
            this.spPrintKotBindingSource.DataMember = "spPrintKot";
            this.spPrintKotBindingSource.DataSource = this.dbBizcarePosDataSet5;
            // 
            // dbBizcarePosDataSet5
            // 
            this.dbBizcarePosDataSet5.DataSetName = "dbBizcarePosDataSet5";
            this.dbBizcarePosDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SpgetRestaurentBindingSource
            // 
            this.SpgetRestaurentBindingSource.DataMember = "SpgetRestaurent";
            this.SpgetRestaurentBindingSource.DataSource = this.dbBizcarePosDataSet6;
            // 
            // dbBizcarePosDataSet6
            // 
            this.dbBizcarePosDataSet6.DataSetName = "dbBizcarePosDataSet6";
            this.dbBizcarePosDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_EditCounterBindingSource
            // 
            this.sp_EditCounterBindingSource.DataMember = "sp_EditCounter";
            this.sp_EditCounterBindingSource.DataSource = this.dbBizcarePosOldDataSet;
            // 
            // dbBizcarePosOldDataSet
            // 
            this.dbBizcarePosOldDataSet.DataSetName = "dbBizcarePosOldDataSet";
            this.dbBizcarePosOldDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spPrintKotBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.SpgetRestaurentBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.sp_EditCounterBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.PrintKot.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(841, 487);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // spPrintKotTableAdapter
            // 
            this.spPrintKotTableAdapter.ClearBeforeFill = true;
            // 
            // SpgetRestaurentTableAdapter
            // 
            this.SpgetRestaurentTableAdapter.ClearBeforeFill = true;
            // 
            // sp_EditCounterTableAdapter
            // 
            this.sp_EditCounterTableAdapter.ClearBeforeFill = true;
            // 
            // FrmKotPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 487);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmKotPrint";
            this.Text = "KOT Print";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKotPrint_FormClosing);
            this.Load += new System.EventHandler(this.FrmKotPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spPrintKotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpgetRestaurentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_EditCounterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosOldDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spPrintKotBindingSource;
        private dbBizcarePosDataSet5 dbBizcarePosDataSet5;
        private System.Windows.Forms.BindingSource SpgetRestaurentBindingSource;
        private dbBizcarePosDataSet6 dbBizcarePosDataSet6;
        private dbBizcarePosDataSet5TableAdapters.spPrintKotTableAdapter spPrintKotTableAdapter;
        private dbBizcarePosDataSet6TableAdapters.SpgetRestaurentTableAdapter SpgetRestaurentTableAdapter;
        private System.Windows.Forms.BindingSource sp_EditCounterBindingSource;
        private dbBizcarePosOldDataSet dbBizcarePosOldDataSet;
        private dbBizcarePosOldDataSetTableAdapters.sp_EditCounterTableAdapter sp_EditCounterTableAdapter;
    }
}