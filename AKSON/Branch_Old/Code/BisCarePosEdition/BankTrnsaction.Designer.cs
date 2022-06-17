namespace BisCarePosEdition
{
    partial class BankTrnsaction
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
            this.bttn_reset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gv_transaction = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bttn_search = new System.Windows.Forms.Button();
            this.dtp_enddate = new System.Windows.Forms.DateTimePicker();
            this.dtp_startdate = new System.Windows.Forms.DateTimePicker();
            this.cmb_edittype = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_editbank = new System.Windows.Forms.ComboBox();
            this.cbox_date = new System.Windows.Forms.CheckBox();
            this.cbox_type = new System.Windows.Forms.CheckBox();
            this.cbox_bank = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttn_newcategory = new System.Windows.Forms.Button();
            this.cmb_newtype = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_amt = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.cmb_newbank = new System.Windows.Forms.ComboBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bttn_save = new System.Windows.Forms.Button();
            this.bttn_cancel = new System.Windows.Forms.Button();
            this.bttn_delete = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_transaction)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttn_reset
            // 
            this.bttn_reset.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_reset.Image = global::BisCarePosEdition.Properties.Resources.reset;
            this.bttn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_reset.Location = new System.Drawing.Point(449, 336);
            this.bttn_reset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttn_reset.Name = "bttn_reset";
            this.bttn_reset.Size = new System.Drawing.Size(110, 32);
            this.bttn_reset.TabIndex = 9;
            this.bttn_reset.Text = "  Reset";
            this.bttn_reset.UseVisualStyleBackColor = false;
            this.bttn_reset.Click += new System.EventHandler(this.bttn_reset_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gv_transaction);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(318, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(558, 317);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // gv_transaction
            // 
            this.gv_transaction.AllowUserToAddRows = false;
            this.gv_transaction.AllowUserToDeleteRows = false;
            this.gv_transaction.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gv_transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_transaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.gv_transaction.Location = new System.Drawing.Point(9, 143);
            this.gv_transaction.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gv_transaction.Name = "gv_transaction";
            this.gv_transaction.ReadOnly = true;
            this.gv_transaction.Size = new System.Drawing.Size(536, 161);
            this.gv_transaction.TabIndex = 1;
            this.gv_transaction.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_transaction_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Bank";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Description";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Amount";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "BankID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bttn_search);
            this.groupBox4.Controls.Add(this.dtp_enddate);
            this.groupBox4.Controls.Add(this.dtp_startdate);
            this.groupBox4.Controls.Add(this.cmb_edittype);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cmb_editbank);
            this.groupBox4.Controls.Add(this.cbox_date);
            this.groupBox4.Controls.Add(this.cbox_type);
            this.groupBox4.Controls.Add(this.cbox_bank);
            this.groupBox4.Location = new System.Drawing.Point(9, 16);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(536, 122);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // bttn_search
            // 
            this.bttn_search.Image = global::BisCarePosEdition.Properties.Resources.Search;
            this.bttn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_search.Location = new System.Drawing.Point(414, 85);
            this.bttn_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttn_search.Name = "bttn_search";
            this.bttn_search.Size = new System.Drawing.Size(110, 32);
            this.bttn_search.TabIndex = 6;
            this.bttn_search.Text = "      Search";
            this.bttn_search.UseVisualStyleBackColor = false;
            this.bttn_search.Click += new System.EventHandler(this.bttn_search_Click);
            // 
            // dtp_enddate
            // 
            this.dtp_enddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_enddate.Location = new System.Drawing.Point(196, 89);
            this.dtp_enddate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtp_enddate.Name = "dtp_enddate";
            this.dtp_enddate.Size = new System.Drawing.Size(156, 24);
            this.dtp_enddate.TabIndex = 5;
            // 
            // dtp_startdate
            // 
            this.dtp_startdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_startdate.Location = new System.Drawing.Point(196, 58);
            this.dtp_startdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtp_startdate.Name = "dtp_startdate";
            this.dtp_startdate.Size = new System.Drawing.Size(156, 24);
            this.dtp_startdate.TabIndex = 4;
            // 
            // cmb_edittype
            // 
            this.cmb_edittype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_edittype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_edittype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_edittype.FormattingEnabled = true;
            this.cmb_edittype.Items.AddRange(new object[] {
            "--Select One--",
            "Deposit",
            "Withdrawal"});
            this.cmb_edittype.Location = new System.Drawing.Point(368, 19);
            this.cmb_edittype.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_edittype.Name = "cmb_edittype";
            this.cmb_edittype.Size = new System.Drawing.Size(156, 24);
            this.cmb_edittype.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "End Date ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Start Date ";
            // 
            // cmb_editbank
            // 
            this.cmb_editbank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_editbank.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_editbank.FormattingEnabled = true;
            this.cmb_editbank.Location = new System.Drawing.Point(97, 19);
            this.cmb_editbank.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_editbank.Name = "cmb_editbank";
            this.cmb_editbank.Size = new System.Drawing.Size(156, 24);
            this.cmb_editbank.TabIndex = 2;
            this.cmb_editbank.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_editbank_MouseClick);
            // 
            // cbox_date
            // 
            this.cbox_date.AutoSize = true;
            this.cbox_date.Checked = true;
            this.cbox_date.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbox_date.Location = new System.Drawing.Point(14, 63);
            this.cbox_date.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbox_date.Name = "cbox_date";
            this.cbox_date.Size = new System.Drawing.Size(75, 21);
            this.cbox_date.TabIndex = 1;
            this.cbox_date.Text = "By Date";
            this.cbox_date.UseVisualStyleBackColor = true;
            this.cbox_date.CheckedChanged += new System.EventHandler(this.cbox_date_CheckedChanged);
            // 
            // cbox_type
            // 
            this.cbox_type.AutoSize = true;
            this.cbox_type.Location = new System.Drawing.Point(286, 22);
            this.cbox_type.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbox_type.Name = "cbox_type";
            this.cbox_type.Size = new System.Drawing.Size(76, 21);
            this.cbox_type.TabIndex = 1;
            this.cbox_type.Text = "By Type";
            this.cbox_type.UseVisualStyleBackColor = true;
            this.cbox_type.CheckedChanged += new System.EventHandler(this.cbox_type_CheckedChanged);
            this.cbox_type.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbox_type_MouseClick);
            // 
            // cbox_bank
            // 
            this.cbox_bank.AutoSize = true;
            this.cbox_bank.Location = new System.Drawing.Point(14, 21);
            this.cbox_bank.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbox_bank.Name = "cbox_bank";
            this.cbox_bank.Size = new System.Drawing.Size(76, 21);
            this.cbox_bank.TabIndex = 0;
            this.cbox_bank.Text = "By Bank";
            this.cbox_bank.UseVisualStyleBackColor = true;
            this.cbox_bank.CheckedChanged += new System.EventHandler(this.cbox_bank_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttn_newcategory);
            this.groupBox1.Controls.Add(this.cmb_newtype);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_amt);
            this.groupBox1.Controls.Add(this.txt_description);
            this.groupBox1.Controls.Add(this.cmb_newbank);
            this.groupBox1.Controls.Add(this.dtp_date);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(298, 317);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bank Transaction";
            // 
            // bttn_newcategory
            // 
            this.bttn_newcategory.BackColor = System.Drawing.Color.Transparent;
            this.bttn_newcategory.FlatAppearance.BorderSize = 0;
            this.bttn_newcategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bttn_newcategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttn_newcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_newcategory.Image = global::BisCarePosEdition.Properties.Resources.Add_;
            this.bttn_newcategory.Location = new System.Drawing.Point(256, 128);
            this.bttn_newcategory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bttn_newcategory.Name = "bttn_newcategory";
            this.bttn_newcategory.Size = new System.Drawing.Size(25, 25);
            this.bttn_newcategory.TabIndex = 50;
            this.bttn_newcategory.UseVisualStyleBackColor = false;
            this.bttn_newcategory.Click += new System.EventHandler(this.bttn_newcategory_Click);
            // 
            // cmb_newtype
            // 
            this.cmb_newtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_newtype.FormattingEnabled = true;
            this.cmb_newtype.Items.AddRange(new object[] {
            "--Select One--",
            "Deposit",
            "Withdrawal"});
            this.cmb_newtype.Location = new System.Drawing.Point(105, 29);
            this.cmb_newtype.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_newtype.Name = "cmb_newtype";
            this.cmb_newtype.Size = new System.Drawing.Size(176, 24);
            this.cmb_newtype.TabIndex = 0;
            this.cmb_newtype.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_newtype_MouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Type ";
            // 
            // txt_amt
            // 
            this.txt_amt.Location = new System.Drawing.Point(105, 280);
            this.txt_amt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_amt.MaxLength = 10;
            this.txt_amt.Name = "txt_amt";
            this.txt_amt.Size = new System.Drawing.Size(176, 24);
            this.txt_amt.TabIndex = 5;
            this.txt_amt.Text = "0";
            this.txt_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_amt.TextChanged += new System.EventHandler(this.txt_amt_TextChanged);
            this.txt_amt.DoubleClick += new System.EventHandler(this.txt_amt_DoubleClick);
            this.txt_amt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amt_KeyPress);
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(105, 174);
            this.txt_description.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(176, 82);
            this.txt_description.TabIndex = 4;
            this.txt_description.TextChanged += new System.EventHandler(this.txt_description_TextChanged);
            // 
            // cmb_newbank
            // 
            this.cmb_newbank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_newbank.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_newbank.FormattingEnabled = true;
            this.cmb_newbank.Location = new System.Drawing.Point(105, 128);
            this.cmb_newbank.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_newbank.Name = "cmb_newbank";
            this.cmb_newbank.Size = new System.Drawing.Size(146, 24);
            this.cmb_newbank.TabIndex = 2;
            this.cmb_newbank.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_newbank_MouseClick);
            // 
            // dtp_date
            // 
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(105, 79);
            this.dtp_date.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(176, 24);
            this.dtp_date.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bank Name ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount ";
            // 
            // bttn_save
            // 
            this.bttn_save.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.bttn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_save.Location = new System.Drawing.Point(213, 336);
            this.bttn_save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(110, 32);
            this.bttn_save.TabIndex = 7;
            this.bttn_save.Text = " Save";
            this.bttn_save.UseVisualStyleBackColor = false;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            // 
            // bttn_cancel
            // 
            this.bttn_cancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.bttn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_cancel.Location = new System.Drawing.Point(566, 336);
            this.bttn_cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttn_cancel.Name = "bttn_cancel";
            this.bttn_cancel.Size = new System.Drawing.Size(110, 32);
            this.bttn_cancel.TabIndex = 10;
            this.bttn_cancel.Text = "   Close";
            this.bttn_cancel.UseVisualStyleBackColor = false;
            this.bttn_cancel.Click += new System.EventHandler(this.bttn_cancel_Click);
            // 
            // bttn_delete
            // 
            this.bttn_delete.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_delete.Image = global::BisCarePosEdition.Properties.Resources.delete6;
            this.bttn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_delete.Location = new System.Drawing.Point(331, 336);
            this.bttn_delete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttn_delete.Name = "bttn_delete";
            this.bttn_delete.Size = new System.Drawing.Size(110, 32);
            this.bttn_delete.TabIndex = 8;
            this.bttn_delete.Text = "  Delete";
            this.bttn_delete.UseVisualStyleBackColor = false;
            this.bttn_delete.Click += new System.EventHandler(this.bttn_delete_Click);
            // 
            // BankTrnsaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 383);
            this.Controls.Add(this.bttn_reset);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.bttn_cancel);
            this.Controls.Add(this.bttn_delete);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BankTrnsaction";
            this.Text = "Bank Transaction";
            this.Load += new System.EventHandler(this.BankTrnsaction_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_transaction)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_reset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gv_transaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bttn_search;
        private System.Windows.Forms.DateTimePicker dtp_enddate;
        private System.Windows.Forms.DateTimePicker dtp_startdate;
        private System.Windows.Forms.ComboBox cmb_edittype;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_editbank;
        private System.Windows.Forms.CheckBox cbox_date;
        private System.Windows.Forms.CheckBox cbox_type;
        private System.Windows.Forms.CheckBox cbox_bank;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttn_newcategory;
        private System.Windows.Forms.ComboBox cmb_newtype;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_amt;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.ComboBox cmb_newbank;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.Button bttn_cancel;
        private System.Windows.Forms.Button bttn_delete;
    }
}