namespace BisCarePosEdition
{
    partial class Bills
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
            this.dgv_bills = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgv_billdetails = new System.Windows.Forms.DataGridView();
            this.Sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_billdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_bills
            // 
            this.dgv_bills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Invoice,
            this.Date,
            this.TotalAmount,
            this.Details});
            this.dgv_bills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_bills.Location = new System.Drawing.Point(0, 0);
            this.dgv_bills.Name = "dgv_bills";
            this.dgv_bills.Size = new System.Drawing.Size(544, 500);
            this.dgv_bills.TabIndex = 0;
            this.dgv_bills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bills_CellClick_1);
            this.dgv_bills.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bills_CellContentClick);
            this.dgv_bills.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bills_CellContentDoubleClick);
            this.dgv_bills.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bills_CellClick);
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            // 
            // Invoice
            // 
            this.Invoice.HeaderText = "Invoice";
            this.Invoice.Name = "Invoice";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.Name = "TotalAmount";
            // 
            // Details
            // 
            this.Details.HeaderText = "Details";
            this.Details.Name = "Details";
            this.Details.Text = "Details";
            this.Details.UseColumnTextForButtonValue = true;
            // 
            // dgv_billdetails
            // 
            this.dgv_billdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_billdetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sno,
            this.ItemCode,
            this.ItemName});
            this.dgv_billdetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_billdetails.Location = new System.Drawing.Point(0, 0);
            this.dgv_billdetails.Name = "dgv_billdetails";
            this.dgv_billdetails.Size = new System.Drawing.Size(544, 500);
            this.dgv_billdetails.TabIndex = 1;
            this.dgv_billdetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_billdetails_CellClick);
            this.dgv_billdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_billdetails_CellContentClick);
            // 
            // Sno
            // 
            this.Sno.HeaderText = "Sno";
            this.Sno.Name = "Sno";
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "ItemCode";
            this.ItemCode.Name = "ItemCode";
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            // 
            // Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(544, 500);
            this.Controls.Add(this.dgv_bills);
            this.Controls.Add(this.dgv_billdetails);
            this.Name = "Bills";
            this.Text = "Bills";
            this.Load += new System.EventHandler(this.Bills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_billdetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_bills;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
        private System.Windows.Forms.DataGridView dgv_billdetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
    }
}