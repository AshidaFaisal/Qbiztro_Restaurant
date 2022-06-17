namespace BisCarePosEdition
{
    partial class searchReceiptvoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchReceiptvoucher));
            this.chk_customer = new System.Windows.Forms.CheckBox();
            this.lblcustomer = new System.Windows.Forms.Label();
            this.cmb_editcustomer = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_Dealer = new System.Windows.Forms.ComboBox();
            this.Cbox_Dealer = new System.Windows.Forms.CheckBox();
            this.dgvEdit = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtto = new System.Windows.Forms.DateTimePicker();
            this.dtfrom = new System.Windows.Forms.DateTimePicker();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Rb_OldReceivable = new System.Windows.Forms.RadioButton();
            this.Rb_Invoice = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkvoucherNo = new System.Windows.Forms.CheckBox();
            this.txt_editvoucherno = new System.Windows.Forms.TextBox();
            this.lblvoucherno = new System.Windows.Forms.Label();
            this.gbdate = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbdate.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_customer
            // 
            this.chk_customer.AutoSize = true;
            this.chk_customer.Location = new System.Drawing.Point(6, 19);
            this.chk_customer.Name = "chk_customer";
            this.chk_customer.Size = new System.Drawing.Size(87, 21);
            this.chk_customer.TabIndex = 0;
            this.chk_customer.Text = "Customer";
            this.chk_customer.UseVisualStyleBackColor = true;
            this.chk_customer.CheckedChanged += new System.EventHandler(this.chk_customer_CheckedChanged);
            // 
            // lblcustomer
            // 
            this.lblcustomer.AutoSize = true;
            this.lblcustomer.Location = new System.Drawing.Point(19, 45);
            this.lblcustomer.Name = "lblcustomer";
            this.lblcustomer.Size = new System.Drawing.Size(72, 17);
            this.lblcustomer.TabIndex = 5;
            this.lblcustomer.Text = "Customer ";
            // 
            // cmb_editcustomer
            // 
            this.cmb_editcustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_editcustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_editcustomer.DropDownWidth = 250;
            this.cmb_editcustomer.Enabled = false;
            this.cmb_editcustomer.FormattingEnabled = true;
            this.cmb_editcustomer.Location = new System.Drawing.Point(90, 42);
            this.cmb_editcustomer.Name = "cmb_editcustomer";
            this.cmb_editcustomer.Size = new System.Drawing.Size(151, 24);
            this.cmb_editcustomer.TabIndex = 0;
            this.cmb_editcustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_editcustomer_KeyPress);
            this.cmb_editcustomer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_editcustomer_MouseClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.Cmb_Dealer);
            this.groupBox6.Controls.Add(this.Cbox_Dealer);
            this.groupBox6.Location = new System.Drawing.Point(277, 151);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(245, 79);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dealer";
            this.groupBox6.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dealer";
            // 
            // Cmb_Dealer
            // 
            this.Cmb_Dealer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_Dealer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Dealer.Enabled = false;
            this.Cmb_Dealer.FormattingEnabled = true;
            this.Cmb_Dealer.Location = new System.Drawing.Point(77, 47);
            this.Cmb_Dealer.Name = "Cmb_Dealer";
            this.Cmb_Dealer.Size = new System.Drawing.Size(151, 24);
            this.Cmb_Dealer.TabIndex = 14;
            // 
            // Cbox_Dealer
            // 
            this.Cbox_Dealer.AutoSize = true;
            this.Cbox_Dealer.Enabled = false;
            this.Cbox_Dealer.Location = new System.Drawing.Point(12, 23);
            this.Cbox_Dealer.Name = "Cbox_Dealer";
            this.Cbox_Dealer.Size = new System.Drawing.Size(66, 21);
            this.Cbox_Dealer.TabIndex = 0;
            this.Cbox_Dealer.Text = "Dealer";
            this.Cbox_Dealer.UseVisualStyleBackColor = true;
            this.Cbox_Dealer.CheckedChanged += new System.EventHandler(this.Cbox_Dealer_CheckedChanged);
            // 
            // dgvEdit
            // 
            this.dgvEdit.AllowUserToAddRows = false;
            this.dgvEdit.AllowUserToDeleteRows = false;
            this.dgvEdit.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvEdit.Location = new System.Drawing.Point(6, 19);
            this.dgvEdit.Name = "dgvEdit";
            this.dgvEdit.ReadOnly = true;
            this.dgvEdit.Size = new System.Drawing.Size(771, 179);
            this.dgvEdit.TabIndex = 27;
            this.dgvEdit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEdit_CellClick);
            this.dgvEdit.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEdit_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Voucher Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Voucher No";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Amount";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Description";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Paymode";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "RVId";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "customer_id ";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsearch.Location = new System.Drawing.Point(539, 148);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(110, 32);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "        Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_customer);
            this.groupBox1.Controls.Add(this.lblcustomer);
            this.groupBox1.Controls.Add(this.cmb_editcustomer);
            this.groupBox1.Location = new System.Drawing.Point(14, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // dtto
            // 
            this.dtto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtto.Location = new System.Drawing.Point(74, 85);
            this.dtto.Name = "dtto";
            this.dtto.Size = new System.Drawing.Size(148, 24);
            this.dtto.TabIndex = 2;
            // 
            // dtfrom
            // 
            this.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfrom.Location = new System.Drawing.Point(74, 51);
            this.dtfrom.Name = "dtfrom";
            this.dtfrom.Size = new System.Drawing.Size(148, 24);
            this.dtfrom.TabIndex = 1;
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Checked = true;
            this.chkDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDate.Location = new System.Drawing.Point(17, 25);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(82, 21);
            this.chkDate.TabIndex = 0;
            this.chkDate.Text = "Datewise";
            this.chkDate.UseVisualStyleBackColor = true;
            this.chkDate.CheckedChanged += new System.EventHandler(this.chkDate_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "To ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Rb_OldReceivable);
            this.groupBox5.Controls.Add(this.Rb_Invoice);
            this.groupBox5.Location = new System.Drawing.Point(16, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(255, 79);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // Rb_OldReceivable
            // 
            this.Rb_OldReceivable.AutoSize = true;
            this.Rb_OldReceivable.Location = new System.Drawing.Point(116, 21);
            this.Rb_OldReceivable.Name = "Rb_OldReceivable";
            this.Rb_OldReceivable.Size = new System.Drawing.Size(115, 21);
            this.Rb_OldReceivable.TabIndex = 1;
            this.Rb_OldReceivable.Text = "Old Receivable";
            this.Rb_OldReceivable.UseVisualStyleBackColor = true;
            // 
            // Rb_Invoice
            // 
            this.Rb_Invoice.AutoSize = true;
            this.Rb_Invoice.Checked = true;
            this.Rb_Invoice.Location = new System.Drawing.Point(17, 21);
            this.Rb_Invoice.Name = "Rb_Invoice";
            this.Rb_Invoice.Size = new System.Drawing.Size(70, 21);
            this.Rb_Invoice.TabIndex = 0;
            this.Rb_Invoice.TabStop = true;
            this.Rb_Invoice.Text = "Invoice";
            this.Rb_Invoice.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.Btn_Cancel);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.gbdate);
            this.groupBox2.Controls.Add(this.btnsearch);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 188);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search By";
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.Btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancel.Image")));
            this.Btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cancel.Location = new System.Drawing.Point(655, 148);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(110, 32);
            this.Btn_Cancel.TabIndex = 6;
            this.Btn_Cancel.Text = "  Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkvoucherNo);
            this.groupBox3.Controls.Add(this.txt_editvoucherno);
            this.groupBox3.Controls.Add(this.lblvoucherno);
            this.groupBox3.Location = new System.Drawing.Point(520, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 79);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Voucher No";
            // 
            // chkvoucherNo
            // 
            this.chkvoucherNo.AutoSize = true;
            this.chkvoucherNo.Location = new System.Drawing.Point(12, 19);
            this.chkvoucherNo.Name = "chkvoucherNo";
            this.chkvoucherNo.Size = new System.Drawing.Size(98, 21);
            this.chkvoucherNo.TabIndex = 0;
            this.chkvoucherNo.Text = "Voucher No";
            this.chkvoucherNo.UseVisualStyleBackColor = true;
            this.chkvoucherNo.CheckedChanged += new System.EventHandler(this.chkvoucherNo_CheckedChanged);
            // 
            // txt_editvoucherno
            // 
            this.txt_editvoucherno.Enabled = false;
            this.txt_editvoucherno.Location = new System.Drawing.Point(90, 44);
            this.txt_editvoucherno.Name = "txt_editvoucherno";
            this.txt_editvoucherno.Size = new System.Drawing.Size(138, 24);
            this.txt_editvoucherno.TabIndex = 1;
            this.txt_editvoucherno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_editvoucherno_MouseClick);
            this.txt_editvoucherno.DoubleClick += new System.EventHandler(this.txt_editvoucherno_DoubleClick);
            // 
            // lblvoucherno
            // 
            this.lblvoucherno.AutoSize = true;
            this.lblvoucherno.Location = new System.Drawing.Point(6, 47);
            this.lblvoucherno.Name = "lblvoucherno";
            this.lblvoucherno.Size = new System.Drawing.Size(83, 17);
            this.lblvoucherno.TabIndex = 13;
            this.lblvoucherno.Text = "Voucher No ";
            // 
            // gbdate
            // 
            this.gbdate.Controls.Add(this.dtto);
            this.gbdate.Controls.Add(this.dtfrom);
            this.gbdate.Controls.Add(this.chkDate);
            this.gbdate.Controls.Add(this.label14);
            this.gbdate.Controls.Add(this.label13);
            this.gbdate.Location = new System.Drawing.Point(277, 23);
            this.gbdate.Name = "gbdate";
            this.gbdate.Size = new System.Drawing.Size(237, 122);
            this.gbdate.TabIndex = 1;
            this.gbdate.TabStop = false;
            this.gbdate.Text = "Date Between";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "From ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvEdit);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(5, 196);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(783, 204);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // searchReceiptvoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 402);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "searchReceiptvoucher";
            this.Text = "Receipt Voucher Search";
            this.Load += new System.EventHandler(this.searchReceiptvoucher_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbdate.ResumeLayout(false);
            this.gbdate.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_customer;
        private System.Windows.Forms.Label lblcustomer;
        private System.Windows.Forms.ComboBox cmb_editcustomer;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_Dealer;
        private System.Windows.Forms.CheckBox Cbox_Dealer;
        private System.Windows.Forms.DataGridView dgvEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtto;
        private System.Windows.Forms.DateTimePicker dtfrom;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton Rb_OldReceivable;
        private System.Windows.Forms.RadioButton Rb_Invoice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkvoucherNo;
        private System.Windows.Forms.TextBox txt_editvoucherno;
        private System.Windows.Forms.Label lblvoucherno;
        private System.Windows.Forms.GroupBox gbdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}