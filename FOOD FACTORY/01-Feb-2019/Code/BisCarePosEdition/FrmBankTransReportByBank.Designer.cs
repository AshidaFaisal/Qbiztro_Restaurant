namespace BisCarePosEdition
{
    partial class FrmBankTransReportByBank
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbBizcarePosDataSetBankTransBank = new BisCarePosEdition.dbBizcarePosDataSetBankTransBank();
            this.Sp_ReportBankTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sp_ReportBankTransactionTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetBankTransBankTableAdapters.Sp_ReportBankTransactionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetBankTransBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_ReportBankTransactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sp_ReportBankTransactionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportBankTransactionBank.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(799, 460);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbBizcarePosDataSetBankTransBank
            // 
            this.dbBizcarePosDataSetBankTransBank.DataSetName = "dbBizcarePosDataSetBankTransBank";
            this.dbBizcarePosDataSetBankTransBank.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sp_ReportBankTransactionBindingSource
            // 
            this.Sp_ReportBankTransactionBindingSource.DataMember = "Sp_ReportBankTransaction";
            this.Sp_ReportBankTransactionBindingSource.DataSource = this.dbBizcarePosDataSetBankTransBank;
            // 
            // Sp_ReportBankTransactionTableAdapter
            // 
            this.Sp_ReportBankTransactionTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBankTransReportByBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 460);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBankTransReportByBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bank Transaction Report";
            this.Load += new System.EventHandler(this.FrmBankTransReportByBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetBankTransBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_ReportBankTransactionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sp_ReportBankTransactionBindingSource;
        private dbBizcarePosDataSetBankTransBank dbBizcarePosDataSetBankTransBank;
        private dbBizcarePosDataSetBankTransBankTableAdapters.Sp_ReportBankTransactionTableAdapter Sp_ReportBankTransactionTableAdapter;
    }
}