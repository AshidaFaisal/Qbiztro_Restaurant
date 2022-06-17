namespace BisCarePosEdition
{
    partial class SearchBill
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
            this.dgv_SearchInvoice = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grp_tableWaiter = new System.Windows.Forms.GroupBox();
            this.chkTable = new System.Windows.Forms.CheckBox();
            this.chkWaiter = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grp_custtype = new System.Windows.Forms.GroupBox();
            this.rd_CounterBill = new System.Windows.Forms.RadioButton();
            this.rd_TakeAway = new System.Windows.Forms.RadioButton();
            this.rd_DineIn = new System.Windows.Forms.RadioButton();
            this.grpWaiter = new System.Windows.Forms.GroupBox();
            this.cboxWaiter = new System.Windows.Forms.ComboBox();
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.cboxItem = new System.Windows.Forms.ComboBox();
            this.grpbxDates = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTable = new System.Windows.Forms.GroupBox();
            this.cboxTable = new System.Windows.Forms.ComboBox();
            this.grp_Invoice = new System.Windows.Forms.GroupBox();
            this.cboxInvoice = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkbxItem = new System.Windows.Forms.CheckBox();
            this.chkInvoice = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchInvoice)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grp_tableWaiter.SuspendLayout();
            this.grp_custtype.SuspendLayout();
            this.grpWaiter.SuspendLayout();
            this.grpItem.SuspendLayout();
            this.grpbxDates.SuspendLayout();
            this.grpTable.SuspendLayout();
            this.grp_Invoice.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_SearchInvoice);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 474);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgv_SearchInvoice
            // 
            this.dgv_SearchInvoice.AllowUserToAddRows = false;
            this.dgv_SearchInvoice.AllowUserToDeleteRows = false;
            this.dgv_SearchInvoice.ColumnHeadersHeight = 30;
            this.dgv_SearchInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column1,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn12});
            this.dgv_SearchInvoice.Location = new System.Drawing.Point(5, 209);
            this.dgv_SearchInvoice.Name = "dgv_SearchInvoice";
            this.dgv_SearchInvoice.ReadOnly = true;
            this.dgv_SearchInvoice.RowHeadersWidth = 5;
            this.dgv_SearchInvoice.Size = new System.Drawing.Size(823, 257);
            this.dgv_SearchInvoice.TabIndex = 4;
            this.dgv_SearchInvoice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SearchInvoice_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "SlNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Invoice NO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Customer Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 265;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Total Amount";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 130;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Date";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 280;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grp_tableWaiter);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.grp_custtype);
            this.groupBox2.Controls.Add(this.grpWaiter);
            this.groupBox2.Controls.Add(this.grpItem);
            this.groupBox2.Controls.Add(this.grpbxDates);
            this.groupBox2.Controls.Add(this.grpTable);
            this.groupBox2.Controls.Add(this.grp_Invoice);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(822, 191);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // grp_tableWaiter
            // 
            this.grp_tableWaiter.Controls.Add(this.chkTable);
            this.grp_tableWaiter.Controls.Add(this.chkWaiter);
            this.grp_tableWaiter.Location = new System.Drawing.Point(561, 22);
            this.grp_tableWaiter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grp_tableWaiter.Name = "grp_tableWaiter";
            this.grp_tableWaiter.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grp_tableWaiter.Size = new System.Drawing.Size(250, 52);
            this.grp_tableWaiter.TabIndex = 10;
            this.grp_tableWaiter.TabStop = false;
            // 
            // chkTable
            // 
            this.chkTable.AutoSize = true;
            this.chkTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTable.Location = new System.Drawing.Point(17, 22);
            this.chkTable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkTable.Name = "chkTable";
            this.chkTable.Size = new System.Drawing.Size(112, 21);
            this.chkTable.TabIndex = 1;
            this.chkTable.Text = "Include Table";
            this.chkTable.UseVisualStyleBackColor = true;
            this.chkTable.CheckedChanged += new System.EventHandler(this.chkTable_CheckedChanged);
            // 
            // chkWaiter
            // 
            this.chkWaiter.AutoSize = true;
            this.chkWaiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWaiter.Location = new System.Drawing.Point(129, 22);
            this.chkWaiter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkWaiter.Name = "chkWaiter";
            this.chkWaiter.Size = new System.Drawing.Size(117, 21);
            this.chkWaiter.TabIndex = 2;
            this.chkWaiter.Text = "Include Waiter";
            this.chkWaiter.UseVisualStyleBackColor = true;
            this.chkWaiter.CheckedChanged += new System.EventHandler(this.chkWaiter_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(694, 139);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 32);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnSearch_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::BisCarePosEdition.Properties.Resources.search4;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(580, 139);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 32);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "     Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseEnter += new System.EventHandler(this.btnSearch_MouseEnter);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            // 
            // grp_custtype
            // 
            this.grp_custtype.Controls.Add(this.rd_CounterBill);
            this.grp_custtype.Controls.Add(this.rd_TakeAway);
            this.grp_custtype.Controls.Add(this.rd_DineIn);
            this.grp_custtype.Location = new System.Drawing.Point(6, 19);
            this.grp_custtype.Name = "grp_custtype";
            this.grp_custtype.Size = new System.Drawing.Size(119, 102);
            this.grp_custtype.TabIndex = 7;
            this.grp_custtype.TabStop = false;
            this.grp_custtype.Enter += new System.EventHandler(this.grp_custtype_Enter);
            // 
            // rd_CounterBill
            // 
            this.rd_CounterBill.AutoSize = true;
            this.rd_CounterBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_CounterBill.Location = new System.Drawing.Point(10, 40);
            this.rd_CounterBill.Name = "rd_CounterBill";
            this.rd_CounterBill.Size = new System.Drawing.Size(98, 21);
            this.rd_CounterBill.TabIndex = 2;
            this.rd_CounterBill.Text = "Counter Bill";
            this.rd_CounterBill.UseVisualStyleBackColor = true;
            this.rd_CounterBill.CheckedChanged += new System.EventHandler(this.rd_CounterBill_CheckedChanged);
            // 
            // rd_TakeAway
            // 
            this.rd_TakeAway.AutoSize = true;
            this.rd_TakeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_TakeAway.Location = new System.Drawing.Point(10, 67);
            this.rd_TakeAway.Name = "rd_TakeAway";
            this.rd_TakeAway.Size = new System.Drawing.Size(95, 21);
            this.rd_TakeAway.TabIndex = 1;
            this.rd_TakeAway.Text = "Take Away";
            this.rd_TakeAway.UseVisualStyleBackColor = true;
            this.rd_TakeAway.CheckedChanged += new System.EventHandler(this.rd_TakeAway_CheckedChanged);
            // 
            // rd_DineIn
            // 
            this.rd_DineIn.AutoSize = true;
            this.rd_DineIn.Checked = true;
            this.rd_DineIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_DineIn.Location = new System.Drawing.Point(10, 13);
            this.rd_DineIn.Name = "rd_DineIn";
            this.rd_DineIn.Size = new System.Drawing.Size(70, 21);
            this.rd_DineIn.TabIndex = 0;
            this.rd_DineIn.TabStop = true;
            this.rd_DineIn.Text = "Dine In";
            this.rd_DineIn.UseVisualStyleBackColor = true;
            this.rd_DineIn.CheckedChanged += new System.EventHandler(this.rd_DineIn_CheckedChanged);
            // 
            // grpWaiter
            // 
            this.grpWaiter.Controls.Add(this.cboxWaiter);
            this.grpWaiter.Location = new System.Drawing.Point(562, 77);
            this.grpWaiter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpWaiter.Name = "grpWaiter";
            this.grpWaiter.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpWaiter.Size = new System.Drawing.Size(242, 43);
            this.grpWaiter.TabIndex = 4;
            this.grpWaiter.TabStop = false;
            this.grpWaiter.Text = "Select Waiter";
            // 
            // cboxWaiter
            // 
            this.cboxWaiter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxWaiter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxWaiter.FormattingEnabled = true;
            this.cboxWaiter.Location = new System.Drawing.Point(4, 16);
            this.cboxWaiter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboxWaiter.Name = "cboxWaiter";
            this.cboxWaiter.Size = new System.Drawing.Size(218, 24);
            this.cboxWaiter.TabIndex = 0;
            this.cboxWaiter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxWaiter_KeyPress);
            // 
            // grpItem
            // 
            this.grpItem.Controls.Add(this.cboxItem);
            this.grpItem.Location = new System.Drawing.Point(199, 129);
            this.grpItem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpItem.Name = "grpItem";
            this.grpItem.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpItem.Size = new System.Drawing.Size(366, 44);
            this.grpItem.TabIndex = 6;
            this.grpItem.TabStop = false;
            this.grpItem.Text = "Select Item";
            // 
            // cboxItem
            // 
            this.cboxItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxItem.FormattingEnabled = true;
            this.cboxItem.Location = new System.Drawing.Point(4, 17);
            this.cboxItem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboxItem.Name = "cboxItem";
            this.cboxItem.Size = new System.Drawing.Size(351, 24);
            this.cboxItem.TabIndex = 0;
            this.cboxItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxItem_KeyPress);
            // 
            // grpbxDates
            // 
            this.grpbxDates.Controls.Add(this.dtpEndDate);
            this.grpbxDates.Controls.Add(this.dtpStartDate);
            this.grpbxDates.Controls.Add(this.label2);
            this.grpbxDates.Controls.Add(this.label1);
            this.grpbxDates.Location = new System.Drawing.Point(130, 22);
            this.grpbxDates.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpbxDates.Name = "grpbxDates";
            this.grpbxDates.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpbxDates.Size = new System.Drawing.Size(170, 101);
            this.grpbxDates.TabIndex = 4;
            this.grpbxDates.TabStop = false;
            this.grpbxDates.Text = "Select Dates";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(63, 66);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(96, 24);
            this.dtpEndDate.TabIndex = 3;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(63, 22);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(96, 24);
            this.dtpStartDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date";
            // 
            // grpTable
            // 
            this.grpTable.Controls.Add(this.cboxTable);
            this.grpTable.Location = new System.Drawing.Point(304, 76);
            this.grpTable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpTable.Name = "grpTable";
            this.grpTable.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpTable.Size = new System.Drawing.Size(250, 46);
            this.grpTable.TabIndex = 5;
            this.grpTable.TabStop = false;
            this.grpTable.Text = "Select Table";
            // 
            // cboxTable
            // 
            this.cboxTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxTable.FormattingEnabled = true;
            this.cboxTable.Location = new System.Drawing.Point(9, 16);
            this.cboxTable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboxTable.Name = "cboxTable";
            this.cboxTable.Size = new System.Drawing.Size(228, 24);
            this.cboxTable.TabIndex = 0;
            this.cboxTable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxTable_KeyPress);
            // 
            // grp_Invoice
            // 
            this.grp_Invoice.Controls.Add(this.cboxInvoice);
            this.grp_Invoice.Location = new System.Drawing.Point(5, 129);
            this.grp_Invoice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grp_Invoice.Name = "grp_Invoice";
            this.grp_Invoice.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grp_Invoice.Size = new System.Drawing.Size(190, 44);
            this.grp_Invoice.TabIndex = 4;
            this.grp_Invoice.TabStop = false;
            this.grp_Invoice.Text = "Select Invoice No";
            // 
            // cboxInvoice
            // 
            this.cboxInvoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxInvoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxInvoice.FormattingEnabled = true;
            this.cboxInvoice.Location = new System.Drawing.Point(11, 17);
            this.cboxInvoice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboxInvoice.Name = "cboxInvoice";
            this.cboxInvoice.Size = new System.Drawing.Size(165, 24);
            this.cboxInvoice.TabIndex = 0;
            this.cboxInvoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxInvoice_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkbxItem);
            this.groupBox3.Controls.Add(this.chkInvoice);
            this.groupBox3.Location = new System.Drawing.Point(304, 22);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(253, 52);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // chkbxItem
            // 
            this.chkbxItem.AutoSize = true;
            this.chkbxItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxItem.Location = new System.Drawing.Point(148, 19);
            this.chkbxItem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkbxItem.Name = "chkbxItem";
            this.chkbxItem.Size = new System.Drawing.Size(102, 21);
            this.chkbxItem.TabIndex = 3;
            this.chkbxItem.Text = "Include Item";
            this.chkbxItem.UseVisualStyleBackColor = true;
            this.chkbxItem.CheckedChanged += new System.EventHandler(this.chkbxItem_CheckedChanged);
            // 
            // chkInvoice
            // 
            this.chkInvoice.AutoSize = true;
            this.chkInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInvoice.Location = new System.Drawing.Point(9, 19);
            this.chkInvoice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkInvoice.Name = "chkInvoice";
            this.chkInvoice.Size = new System.Drawing.Size(138, 21);
            this.chkInvoice.TabIndex = 0;
            this.chkInvoice.Text = "Include InvoiceNo";
            this.chkInvoice.UseVisualStyleBackColor = true;
            this.chkInvoice.CheckedChanged += new System.EventHandler(this.chkInvoice_CheckedChanged);
            // 
            // SearchBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(853, 484);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Bill";
            this.Load += new System.EventHandler(this.DeleteBill_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchInvoice)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grp_tableWaiter.ResumeLayout(false);
            this.grp_tableWaiter.PerformLayout();
            this.grp_custtype.ResumeLayout(false);
            this.grp_custtype.PerformLayout();
            this.grpWaiter.ResumeLayout(false);
            this.grpItem.ResumeLayout(false);
            this.grpbxDates.ResumeLayout(false);
            this.grpbxDates.PerformLayout();
            this.grpTable.ResumeLayout(false);
            this.grp_Invoice.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpItem;
        private System.Windows.Forms.ComboBox cboxItem;
        private System.Windows.Forms.GroupBox grpTable;
        private System.Windows.Forms.ComboBox cboxTable;
        private System.Windows.Forms.GroupBox grp_Invoice;
        private System.Windows.Forms.ComboBox cboxInvoice;
        private System.Windows.Forms.GroupBox grpbxDates;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpWaiter;
        private System.Windows.Forms.ComboBox cboxWaiter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkbxItem;
        private System.Windows.Forms.CheckBox chkTable;
        private System.Windows.Forms.CheckBox chkInvoice;
        private System.Windows.Forms.DataGridView dgv_SearchInvoice;
        private System.Windows.Forms.GroupBox grp_custtype;
        private System.Windows.Forms.RadioButton rd_CounterBill;
        private System.Windows.Forms.RadioButton rd_TakeAway;
        private System.Windows.Forms.RadioButton rd_DineIn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chkWaiter;
        private System.Windows.Forms.GroupBox grp_tableWaiter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}