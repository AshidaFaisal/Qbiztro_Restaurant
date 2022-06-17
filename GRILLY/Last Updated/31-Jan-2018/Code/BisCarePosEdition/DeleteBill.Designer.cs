namespace BisCarePosEdition
{
    partial class DeleteBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteBill));
            this.grp_1 = new System.Windows.Forms.GroupBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.dgv_InvoiceDetails = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_ivoiceDetails = new System.Windows.Forms.GroupBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_BilType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_InvoiceNo = new System.Windows.Forms.TextBox();
            this.dgv_test = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InvoiceDetails)).BeginInit();
            this.grp_ivoiceDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_test)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_1
            // 
            this.grp_1.Controls.Add(this.btn_reset);
            this.grp_1.Controls.Add(this.btn_del);
            this.grp_1.Controls.Add(this.dgv_InvoiceDetails);
            this.grp_1.Controls.Add(this.grp_ivoiceDetails);
            this.grp_1.Controls.Add(this.groupBox1);
            this.grp_1.Location = new System.Drawing.Point(8, -5);
            this.grp_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_1.Name = "grp_1";
            this.grp_1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_1.Size = new System.Drawing.Size(869, 472);
            this.grp_1.TabIndex = 0;
            this.grp_1.TabStop = false;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(733, 419);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(128, 39);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Close";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            this.btn_reset.MouseEnter += new System.EventHandler(this.btn_reset_MouseEnter);
            this.btn_reset.MouseLeave += new System.EventHandler(this.btn_reset_MouseLeave);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Image = ((System.Drawing.Image)(resources.GetObject("btn_del.Image")));
            this.btn_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_del.Location = new System.Drawing.Point(598, 419);
            this.btn_del.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(128, 39);
            this.btn_del.TabIndex = 2;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            this.btn_del.MouseEnter += new System.EventHandler(this.btn_reset_MouseEnter);
            this.btn_del.MouseLeave += new System.EventHandler(this.btn_reset_MouseLeave);
            // 
            // dgv_InvoiceDetails
            // 
            this.dgv_InvoiceDetails.AllowUserToAddRows = false;
            this.dgv_InvoiceDetails.AllowUserToDeleteRows = false;
            this.dgv_InvoiceDetails.ColumnHeadersHeight = 30;
            this.dgv_InvoiceDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn9,
            this.Column2,
            this.Column4});
            this.dgv_InvoiceDetails.Location = new System.Drawing.Point(8, 148);
            this.dgv_InvoiceDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_InvoiceDetails.Name = "dgv_InvoiceDetails";
            this.dgv_InvoiceDetails.ReadOnly = true;
            this.dgv_InvoiceDetails.RowHeadersWidth = 5;
            this.dgv_InvoiceDetails.Size = new System.Drawing.Size(853, 261);
            this.dgv_InvoiceDetails.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Sl No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "KOT NO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Item Code";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 160;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 400;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // grp_ivoiceDetails
            // 
            this.grp_ivoiceDetails.Controls.Add(this.lbl_Name);
            this.grp_ivoiceDetails.Controls.Add(this.label8);
            this.grp_ivoiceDetails.Controls.Add(this.lbl_total);
            this.grp_ivoiceDetails.Controls.Add(this.lbl_BilType);
            this.grp_ivoiceDetails.Controls.Add(this.label4);
            this.grp_ivoiceDetails.Controls.Add(this.label2);
            this.grp_ivoiceDetails.Controls.Add(this.dtp_date);
            this.grp_ivoiceDetails.Controls.Add(this.label3);
            this.grp_ivoiceDetails.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ivoiceDetails.Location = new System.Drawing.Point(344, 16);
            this.grp_ivoiceDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_ivoiceDetails.Name = "grp_ivoiceDetails";
            this.grp_ivoiceDetails.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_ivoiceDetails.Size = new System.Drawing.Size(518, 119);
            this.grp_ivoiceDetails.TabIndex = 1;
            this.grp_ivoiceDetails.TabStop = false;
            this.grp_ivoiceDetails.Text = "Invoice Details";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(354, 86);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(0, 17);
            this.lbl_Name.TabIndex = 8;
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Customer Name:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(354, 33);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 17);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_BilType
            // 
            this.lbl_BilType.AutoSize = true;
            this.lbl_BilType.Location = new System.Drawing.Point(73, 79);
            this.lbl_BilType.Name = "lbl_BilType";
            this.lbl_BilType.Size = new System.Drawing.Size(0, 17);
            this.lbl_BilType.TabIndex = 5;
            this.lbl_BilType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "BillType:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Amount:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_date
            // 
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(73, 33);
            this.dtp_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(141, 24);
            this.dtp_date.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bill Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_InvoiceNo);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(325, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice No";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(185, 76);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 34);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "     Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseEnter += new System.EventHandler(this.btn_reset_MouseEnter);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btn_reset_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoice No";
            // 
            // txt_InvoiceNo
            // 
            this.txt_InvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InvoiceNo.Location = new System.Drawing.Point(87, 25);
            this.txt_InvoiceNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_InvoiceNo.Name = "txt_InvoiceNo";
            this.txt_InvoiceNo.Size = new System.Drawing.Size(226, 35);
            this.txt_InvoiceNo.TabIndex = 0;
            this.txt_InvoiceNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgv_test
            // 
            this.dgv_test.AllowUserToAddRows = false;
            this.dgv_test.AllowUserToDeleteRows = false;
            this.dgv_test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_test.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgv_test.Location = new System.Drawing.Point(212, 613);
            this.dgv_test.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_test.Name = "dgv_test";
            this.dgv_test.ReadOnly = true;
            this.dgv_test.Size = new System.Drawing.Size(265, 55);
            this.dgv_test.TabIndex = 4;
            this.dgv_test.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Token";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "WaiterId";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tablid";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Kot";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Amount";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "rate";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Quantity";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "ItemId";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 40;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "InvoiceId";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // DeleteBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(882, 474);
            this.Controls.Add(this.dgv_test);
            this.Controls.Add(this.grp_1);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Bill";
            this.Load += new System.EventHandler(this.DeleteBill_Load);
            this.grp_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InvoiceDetails)).EndInit();
            this.grp_ivoiceDetails.ResumeLayout(false);
            this.grp_ivoiceDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_test)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_1;
        private System.Windows.Forms.GroupBox grp_ivoiceDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_InvoiceNo;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_BilType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_InvoiceDetails;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.DataGridView dgv_test;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}