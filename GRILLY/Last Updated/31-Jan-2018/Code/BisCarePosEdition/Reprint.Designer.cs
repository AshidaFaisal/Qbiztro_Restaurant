namespace BisCarePosEdition
{
    partial class Reprint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reprint));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_reprint = new System.Windows.Forms.DataGridView();
            this.Invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Print = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reprint)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_reprint);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 611);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgv_reprint
            // 
            this.dgv_reprint.AllowUserToAddRows = false;
            this.dgv_reprint.AllowUserToDeleteRows = false;
            this.dgv_reprint.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_reprint.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_reprint.ColumnHeadersHeight = 40;
            this.dgv_reprint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Invoice,
            this.InvoiceDate,
            this.TotalAmount,
            this.User,
            this.Print});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_reprint.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_reprint.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_reprint.Location = new System.Drawing.Point(11, 15);
            this.dgv_reprint.Name = "dgv_reprint";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_reprint.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_reprint.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_reprint.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_reprint.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_reprint.RowTemplate.Height = 40;
            this.dgv_reprint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_reprint.Size = new System.Drawing.Size(770, 586);
            this.dgv_reprint.TabIndex = 1;
            this.dgv_reprint.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reprint_CellClick);
            this.dgv_reprint.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reprint_CellContentClick);
            // 
            // Invoice
            // 
            this.Invoice.HeaderText = " Invoice";
            this.Invoice.Name = "Invoice";
            this.Invoice.Width = 120;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.HeaderText = " Invoice  Date";
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.Width = 240;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Total  Amount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Width = 160;
            // 
            // User
            // 
            this.User.HeaderText = " User";
            this.User.Name = "User";
            this.User.Width = 90;
            // 
            // Print
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.Print.DefaultCellStyle = dataGridViewCellStyle2;
            this.Print.HeaderText = "";
            this.Print.Image = global::BisCarePosEdition.Properties.Resources.printer1;
            this.Print.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Print.Name = "Print";
            this.Print.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Print.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Print.Width = 150;
            // 
            // Reprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 625);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reprint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reprint";
            this.Load += new System.EventHandler(this.Reprint_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reprint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_reprint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewImageColumn Print;
    }
}