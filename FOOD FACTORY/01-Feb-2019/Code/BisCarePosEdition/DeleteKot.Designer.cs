namespace BisCarePosEdition
{
    partial class DeleteKot
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.dgv_SearchKOT = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_token = new System.Windows.Forms.RadioButton();
            this.rd_table = new System.Windows.Forms.RadioButton();
            this.grpToken = new System.Windows.Forms.GroupBox();
            this.cboxTokenKOT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxToken = new System.Windows.Forms.ComboBox();
            this.grpTable = new System.Windows.Forms.GroupBox();
            this.cboxTableKOT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxTable = new System.Windows.Forms.ComboBox();
            this.dgv_test = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchKOT)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpToken.SuspendLayout();
            this.grpTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_test)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_del);
            this.groupBox1.Controls.Add(this.dgv_SearchKOT);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(837, 586);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(705, 546);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(110, 32);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Close";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            this.btn_reset.MouseEnter += new System.EventHandler(this.btn_del_MouseEnter);
            this.btn_reset.MouseLeave += new System.EventHandler(this.btn_del_MouseLeave);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Image = global::BisCarePosEdition.Properties.Resources.delete6;
            this.btn_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_del.Location = new System.Drawing.Point(589, 546);
            this.btn_del.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(110, 32);
            this.btn_del.TabIndex = 2;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            this.btn_del.MouseEnter += new System.EventHandler(this.btn_del_MouseEnter);
            this.btn_del.MouseLeave += new System.EventHandler(this.btn_del_MouseLeave);
            // 
            // dgv_SearchKOT
            // 
            this.dgv_SearchKOT.AllowUserToAddRows = false;
            this.dgv_SearchKOT.AllowUserToDeleteRows = false;
            this.dgv_SearchKOT.ColumnHeadersHeight = 30;
            this.dgv_SearchKOT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn9,
            this.Column2,
            this.Column4,
            this.dataGridViewTextBoxColumn12});
            this.dgv_SearchKOT.Location = new System.Drawing.Point(9, 219);
            this.dgv_SearchKOT.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_SearchKOT.Name = "dgv_SearchKOT";
            this.dgv_SearchKOT.ReadOnly = true;
            this.dgv_SearchKOT.RowHeadersWidth = 5;
            this.dgv_SearchKOT.Size = new System.Drawing.Size(808, 310);
            this.dgv_SearchKOT.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "SlNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "KOT NO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Item Code";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Date";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rd_token);
            this.groupBox2.Controls.Add(this.rd_table);
            this.groupBox2.Controls.Add(this.grpToken);
            this.groupBox2.Controls.Add(this.grpTable);
            this.groupBox2.Location = new System.Drawing.Point(9, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(808, 197);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // rd_token
            // 
            this.rd_token.AutoSize = true;
            this.rd_token.Location = new System.Drawing.Point(168, 20);
            this.rd_token.Margin = new System.Windows.Forms.Padding(4);
            this.rd_token.Name = "rd_token";
            this.rd_token.Size = new System.Drawing.Size(108, 23);
            this.rd_token.TabIndex = 1;
            this.rd_token.Text = "Token Wise";
            this.rd_token.UseVisualStyleBackColor = true;
            this.rd_token.CheckedChanged += new System.EventHandler(this.rd_token_CheckedChanged_1);
            // 
            // rd_table
            // 
            this.rd_table.AutoSize = true;
            this.rd_table.Checked = true;
            this.rd_table.Location = new System.Drawing.Point(24, 20);
            this.rd_table.Margin = new System.Windows.Forms.Padding(4);
            this.rd_table.Name = "rd_table";
            this.rd_table.Size = new System.Drawing.Size(103, 23);
            this.rd_table.TabIndex = 0;
            this.rd_table.TabStop = true;
            this.rd_table.Text = "Table Wise";
            this.rd_table.UseVisualStyleBackColor = true;
            this.rd_table.CheckedChanged += new System.EventHandler(this.rd_table_CheckedChanged_1);
            // 
            // grpToken
            // 
            this.grpToken.Controls.Add(this.cboxTokenKOT);
            this.grpToken.Controls.Add(this.label4);
            this.grpToken.Controls.Add(this.label3);
            this.grpToken.Controls.Add(this.cboxToken);
            this.grpToken.Location = new System.Drawing.Point(374, 64);
            this.grpToken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpToken.Name = "grpToken";
            this.grpToken.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpToken.Size = new System.Drawing.Size(389, 120);
            this.grpToken.TabIndex = 3;
            this.grpToken.TabStop = false;
            this.grpToken.Text = "Token wise";
            // 
            // cboxTokenKOT
            // 
            this.cboxTokenKOT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxTokenKOT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxTokenKOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTokenKOT.FormattingEnabled = true;
            this.cboxTokenKOT.Location = new System.Drawing.Point(147, 72);
            this.cboxTokenKOT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxTokenKOT.Name = "cboxTokenKOT";
            this.cboxTokenKOT.Size = new System.Drawing.Size(226, 24);
            this.cboxTokenKOT.TabIndex = 1;
            this.cboxTokenKOT.SelectedIndexChanged += new System.EventHandler(this.cboxTokenKOT_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select Token";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select KOT";
            // 
            // cboxToken
            // 
            this.cboxToken.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxToken.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxToken.FormattingEnabled = true;
            this.cboxToken.Location = new System.Drawing.Point(147, 34);
            this.cboxToken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxToken.Name = "cboxToken";
            this.cboxToken.Size = new System.Drawing.Size(226, 24);
            this.cboxToken.TabIndex = 0;
            this.cboxToken.SelectedIndexChanged += new System.EventHandler(this.cboxToken_SelectedIndexChanged);
            // 
            // grpTable
            // 
            this.grpTable.Controls.Add(this.cboxTableKOT);
            this.grpTable.Controls.Add(this.label2);
            this.grpTable.Controls.Add(this.label1);
            this.grpTable.Controls.Add(this.cboxTable);
            this.grpTable.Location = new System.Drawing.Point(24, 54);
            this.grpTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTable.Name = "grpTable";
            this.grpTable.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTable.Size = new System.Drawing.Size(344, 130);
            this.grpTable.TabIndex = 2;
            this.grpTable.TabStop = false;
            this.grpTable.Text = "Table wise";
            // 
            // cboxTableKOT
            // 
            this.cboxTableKOT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxTableKOT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxTableKOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTableKOT.FormattingEnabled = true;
            this.cboxTableKOT.Location = new System.Drawing.Point(114, 76);
            this.cboxTableKOT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxTableKOT.Name = "cboxTableKOT";
            this.cboxTableKOT.Size = new System.Drawing.Size(225, 24);
            this.cboxTableKOT.TabIndex = 1;
            this.cboxTableKOT.SelectedIndexChanged += new System.EventHandler(this.cboxTableKOT_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select KOT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Table";
            // 
            // cboxTable
            // 
            this.cboxTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTable.FormattingEnabled = true;
            this.cboxTable.Location = new System.Drawing.Point(114, 44);
            this.cboxTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxTable.Name = "cboxTable";
            this.cboxTable.Size = new System.Drawing.Size(225, 24);
            this.cboxTable.TabIndex = 0;
            this.cboxTable.SelectedIndexChanged += new System.EventHandler(this.cboxTable_SelectedIndexChanged);
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
            this.Column7});
            this.dgv_test.Location = new System.Drawing.Point(394, 715);
            this.dgv_test.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_test.Name = "dgv_test";
            this.dgv_test.ReadOnly = true;
            this.dgv_test.Size = new System.Drawing.Size(270, 61);
            this.dgv_test.TabIndex = 4;
            this.dgv_test.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kotid";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Item";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Qty";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "rate";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "amount";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // DeleteKot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(847, 603);
            this.Controls.Add(this.dgv_test);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteKot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete KOT";
            this.Load += new System.EventHandler(this.SearchKot_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchKOT)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpToken.ResumeLayout(false);
            this.grpToken.PerformLayout();
            this.grpTable.ResumeLayout(false);
            this.grpTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_test)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_SearchKOT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpToken;
        private System.Windows.Forms.ComboBox cboxToken;
        private System.Windows.Forms.GroupBox grpTable;
        private System.Windows.Forms.ComboBox cboxTable;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.ComboBox cboxTokenKOT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxTableKOT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rd_token;
        private System.Windows.Forms.RadioButton rd_table;
        private System.Windows.Forms.DataGridView dgv_test;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;

    }
}