namespace BisCarePosEdition
{
    partial class StockEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockEntry));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lbll_total = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.cmb_itemname = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPayable = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cboxPurchaser = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPayingAmt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.BTN_RESET = new System.Windows.Forms.Button();
            this.txt_totala = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtsid = new System.Windows.Forms.TextBox();
            this.lb_quantity = new System.Windows.Forms.Label();
            this.bttn_newcategory = new System.Windows.Forms.Button();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lbl_itemname = new System.Windows.Forms.Label();
            this.lbl_unitprice = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.txt_totalamount = new System.Windows.Forms.TextBox();
            this.cmb_itemcode = new System.Windows.Forms.ComboBox();
            this.txt_unitprice = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_itemcode = new System.Windows.Forms.Label();
            this.gv_stock = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_search = new System.Windows.Forms.Button();
            this.dtp_stockdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.grp_dealerIn = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDealerRefNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rb_OldStock = new System.Windows.Forms.RadioButton();
            this.rbtnNormal = new System.Windows.Forms.RadioButton();
            this.Gr_Dealer = new System.Windows.Forms.GroupBox();
            this.btnNewCust = new System.Windows.Forms.Button();
            this.txtTinNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxCustomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_countersale = new System.Windows.Forms.RadioButton();
            this.rd_Ingradiant = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_stock)).BeginInit();
            this.grp_dealerIn.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Gr_Dealer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(911, 695);
            this.txt_total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(135, 24);
            this.txt_total.TabIndex = 29;
            this.txt_total.Text = "0";
            this.txt_total.Visible = false;
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // lbll_total
            // 
            this.lbll_total.AutoSize = true;
            this.lbll_total.Location = new System.Drawing.Point(804, 698);
            this.lbll_total.Name = "lbll_total";
            this.lbll_total.Size = new System.Drawing.Size(100, 17);
            this.lbll_total.TabIndex = 28;
            this.lbll_total.Text = "Total Amount :";
            this.lbll_total.Visible = false;
            this.lbll_total.Click += new System.EventHandler(this.lbll_total_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(768, 84);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(110, 32);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            this.btn_add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_add_KeyDown);
            this.btn_add.MouseEnter += new System.EventHandler(this.btn_search_MouseEnter);
            this.btn_add.MouseLeave += new System.EventHandler(this.btn_search_MouseLeave);
            // 
            // cmb_itemname
            // 
            this.cmb_itemname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_itemname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_itemname.FormattingEnabled = true;
            this.cmb_itemname.Location = new System.Drawing.Point(89, 53);
            this.cmb_itemname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_itemname.Name = "cmb_itemname";
            this.cmb_itemname.Size = new System.Drawing.Size(245, 24);
            this.cmb_itemname.TabIndex = 2;
            this.cmb_itemname.SelectedIndexChanged += new System.EventHandler(this.cmb_itemname_SelectedIndexChanged);
            this.cmb_itemname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_itemname_KeyDown);
            this.cmb_itemname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_itemname_KeyPress);
            this.cmb_itemname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_itemname_MouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPayable);
            this.groupBox3.Controls.Add(this.text1);
            this.groupBox3.Controls.Add(this.txtRemarks);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.cboxPurchaser);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtDiscount);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtBalance);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.txtPayingAmt);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btn_save);
            this.groupBox3.Controls.Add(this.btn_cancel);
            this.groupBox3.Controls.Add(this.BTN_RESET);
            this.groupBox3.Controls.Add(this.txt_totala);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.gv_stock);
            this.groupBox3.Controls.Add(this.btn_search);
            this.groupBox3.Location = new System.Drawing.Point(3, 127);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox3.Size = new System.Drawing.Size(904, 473);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtPayable
            // 
            this.txtPayable.Enabled = false;
            this.txtPayable.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtPayable.Location = new System.Drawing.Point(389, 380);
            this.txtPayable.MaxLength = 8;
            this.txtPayable.Name = "txtPayable";
            this.txtPayable.Size = new System.Drawing.Size(195, 30);
            this.txtPayable.TabIndex = 107;
            this.txtPayable.Text = "0.00";
            this.txtPayable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPayable.TextChanged += new System.EventHandler(this.txtPayable_TextChanged);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Location = new System.Drawing.Point(275, 389);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(108, 17);
            this.text1.TabIndex = 108;
            this.text1.Text = "Payable Amount";
            this.text1.Click += new System.EventHandler(this.text1_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(94, 300);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(162, 63);
            this.txtRemarks.TabIndex = 103;
            this.txtRemarks.TextChanged += new System.EventHandler(this.txtRemarks_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(34, 304);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 17);
            this.label23.TabIndex = 104;
            this.label23.Text = "Remarks";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // cboxPurchaser
            // 
            this.cboxPurchaser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPurchaser.FormattingEnabled = true;
            this.cboxPurchaser.Location = new System.Drawing.Point(94, 386);
            this.cboxPurchaser.Name = "cboxPurchaser";
            this.cboxPurchaser.Size = new System.Drawing.Size(162, 24);
            this.cboxPurchaser.TabIndex = 100;
            this.cboxPurchaser.SelectedIndexChanged += new System.EventHandler(this.cboxPurchaser_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 393);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 17);
            this.label16.TabIndex = 102;
            this.label16.Text = "Purchased By";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtDiscount.Location = new System.Drawing.Point(389, 339);
            this.txtDiscount.MaxLength = 8;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(195, 30);
            this.txtDiscount.TabIndex = 98;
            this.txtDiscount.Text = "0.00";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(321, 354);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 17);
            this.label13.TabIndex = 99;
            this.label13.Text = "Discount";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtBalance.Location = new System.Drawing.Point(690, 369);
            this.txtBalance.MaxLength = 8;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(194, 40);
            this.txtBalance.TabIndex = 95;
            this.txtBalance.Text = "0.00";
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBalance.TextChanged += new System.EventHandler(this.txtBalance_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(630, 393);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 17);
            this.label22.TabIndex = 96;
            this.label22.Text = "Balance";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // txtPayingAmt
            // 
            this.txtPayingAmt.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtPayingAmt.Location = new System.Drawing.Point(389, 303);
            this.txtPayingAmt.MaxLength = 8;
            this.txtPayingAmt.Name = "txtPayingAmt";
            this.txtPayingAmt.Size = new System.Drawing.Size(195, 30);
            this.txtPayingAmt.TabIndex = 48;
            this.txtPayingAmt.Text = "0.00";
            this.txtPayingAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPayingAmt.TextChanged += new System.EventHandler(this.txtPayingAmt_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(296, 319);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 17);
            this.label17.TabIndex = 49;
            this.label17.Text = "Paid Amount";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(205, 429);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(110, 32);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "  Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            this.btn_update.MouseEnter += new System.EventHandler(this.btn_search_MouseEnter);
            this.btn_update.MouseLeave += new System.EventHandler(this.btn_search_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::BisCarePosEdition.Properties.Resources.delete6;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(321, 429);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.btn_search_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.btn_search_MouseLeave);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(89, 429);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(110, 32);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.MouseEnter += new System.EventHandler(this.btn_search_MouseEnter);
            this.btn_save.MouseLeave += new System.EventHandler(this.btn_search_MouseLeave);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(669, 429);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 32);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "  Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseEnter += new System.EventHandler(this.btn_search_MouseEnter);
            this.btn_cancel.MouseLeave += new System.EventHandler(this.btn_search_MouseLeave);
            // 
            // BTN_RESET
            // 
            this.BTN_RESET.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTN_RESET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RESET.Image = global::BisCarePosEdition.Properties.Resources.reset1;
            this.BTN_RESET.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_RESET.Location = new System.Drawing.Point(553, 429);
            this.BTN_RESET.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_RESET.Name = "BTN_RESET";
            this.BTN_RESET.Size = new System.Drawing.Size(110, 32);
            this.BTN_RESET.TabIndex = 6;
            this.BTN_RESET.Text = "Reset";
            this.BTN_RESET.UseVisualStyleBackColor = false;
            this.BTN_RESET.Click += new System.EventHandler(this.BTN_RESET_Click);
            this.BTN_RESET.MouseEnter += new System.EventHandler(this.btn_search_MouseEnter);
            this.BTN_RESET.MouseLeave += new System.EventHandler(this.btn_search_MouseLeave);
            // 
            // txt_totala
            // 
            this.txt_totala.Enabled = false;
            this.txt_totala.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totala.Location = new System.Drawing.Point(690, 307);
            this.txt_totala.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txt_totala.MaxLength = 8;
            this.txt_totala.Name = "txt_totala";
            this.txt_totala.Size = new System.Drawing.Size(193, 40);
            this.txt_totala.TabIndex = 47;
            this.txt_totala.Text = "0.00";
            this.txt_totala.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_totala.TextChanged += new System.EventHandler(this.txt_totala_TextChanged);
            this.txt_totala.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_totala_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 330);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Total Amount ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtsid);
            this.groupBox4.Controls.Add(this.lb_quantity);
            this.groupBox4.Controls.Add(this.bttn_newcategory);
            this.groupBox4.Controls.Add(this.lbl_description);
            this.groupBox4.Controls.Add(this.cmb_itemname);
            this.groupBox4.Controls.Add(this.txt_description);
            this.groupBox4.Controls.Add(this.lbl_itemname);
            this.groupBox4.Controls.Add(this.btn_add);
            this.groupBox4.Controls.Add(this.lbl_unitprice);
            this.groupBox4.Controls.Add(this.txt_qty);
            this.groupBox4.Controls.Add(this.lbl_quantity);
            this.groupBox4.Controls.Add(this.txt_totalamount);
            this.groupBox4.Controls.Add(this.cmb_itemcode);
            this.groupBox4.Controls.Add(this.txt_unitprice);
            this.groupBox4.Controls.Add(this.lbl_total);
            this.groupBox4.Controls.Add(this.lbl_itemcode);
            this.groupBox4.Location = new System.Drawing.Point(7, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox4.Size = new System.Drawing.Size(886, 135);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // txtsid
            // 
            this.txtsid.Location = new System.Drawing.Point(841, 14);
            this.txtsid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsid.MaxLength = 6;
            this.txtsid.Name = "txtsid";
            this.txtsid.ReadOnly = true;
            this.txtsid.Size = new System.Drawing.Size(40, 24);
            this.txtsid.TabIndex = 97;
            this.txtsid.Text = "0";
            this.txtsid.Visible = false;
            this.txtsid.TextChanged += new System.EventHandler(this.txtsid_TextChanged);
            // 
            // lb_quantity
            // 
            this.lb_quantity.AutoSize = true;
            this.lb_quantity.Location = new System.Drawing.Point(765, 20);
            this.lb_quantity.Name = "lb_quantity";
            this.lb_quantity.Size = new System.Drawing.Size(16, 17);
            this.lb_quantity.TabIndex = 96;
            this.lb_quantity.Text = "q";
            this.lb_quantity.Click += new System.EventHandler(this.lb_quantity_Click);
            // 
            // bttn_newcategory
            // 
            this.bttn_newcategory.BackColor = System.Drawing.Color.Transparent;
            this.bttn_newcategory.FlatAppearance.BorderSize = 0;
            this.bttn_newcategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bttn_newcategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttn_newcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_newcategory.Image = ((System.Drawing.Image)(resources.GetObject("bttn_newcategory.Image")));
            this.bttn_newcategory.Location = new System.Drawing.Point(340, 14);
            this.bttn_newcategory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bttn_newcategory.Name = "bttn_newcategory";
            this.bttn_newcategory.Size = new System.Drawing.Size(25, 25);
            this.bttn_newcategory.TabIndex = 95;
            this.bttn_newcategory.UseVisualStyleBackColor = false;
            this.bttn_newcategory.Click += new System.EventHandler(this.bttn_newcategory_Click);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(422, 99);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(76, 17);
            this.lbl_description.TabIndex = 11;
            this.lbl_description.Text = "Description";
            this.lbl_description.Click += new System.EventHandler(this.lbl_description_Click);
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(506, 76);
            this.txt_description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(254, 40);
            this.txt_description.TabIndex = 6;
            this.txt_description.TextChanged += new System.EventHandler(this.txt_description_TextChanged);
            this.txt_description.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_description_KeyDown);
            // 
            // lbl_itemname
            // 
            this.lbl_itemname.AutoSize = true;
            this.lbl_itemname.Location = new System.Drawing.Point(5, 60);
            this.lbl_itemname.Name = "lbl_itemname";
            this.lbl_itemname.Size = new System.Drawing.Size(79, 17);
            this.lbl_itemname.TabIndex = 0;
            this.lbl_itemname.Text = "Item Name ";
            this.lbl_itemname.Click += new System.EventHandler(this.lbl_itemname_Click);
            // 
            // lbl_unitprice
            // 
            this.lbl_unitprice.AutoSize = true;
            this.lbl_unitprice.Location = new System.Drawing.Point(15, 99);
            this.lbl_unitprice.Name = "lbl_unitprice";
            this.lbl_unitprice.Size = new System.Drawing.Size(69, 17);
            this.lbl_unitprice.TabIndex = 1;
            this.lbl_unitprice.Text = "Unit Price ";
            this.lbl_unitprice.Click += new System.EventHandler(this.lbl_unitprice_Click);
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(506, 13);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_qty.MaxLength = 6;
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(253, 24);
            this.txt_qty.TabIndex = 4;
            this.txt_qty.Text = "0";
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            this.txt_qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_qty_KeyDown);
            this.txt_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qty_KeyPress);
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(438, 20);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(61, 17);
            this.lbl_quantity.TabIndex = 2;
            this.lbl_quantity.Text = "Quantity";
            this.lbl_quantity.Click += new System.EventHandler(this.lbl_quantity_Click);
            // 
            // txt_totalamount
            // 
            this.txt_totalamount.Enabled = false;
            this.txt_totalamount.Location = new System.Drawing.Point(506, 46);
            this.txt_totalamount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_totalamount.MaxLength = 8;
            this.txt_totalamount.Name = "txt_totalamount";
            this.txt_totalamount.Size = new System.Drawing.Size(254, 24);
            this.txt_totalamount.TabIndex = 5;
            this.txt_totalamount.Text = "0.00";
            this.txt_totalamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_totalamount.TextChanged += new System.EventHandler(this.txt_totalamount_TextChanged);
            this.txt_totalamount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_totalamount_KeyDown);
            this.txt_totalamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_totalamount_KeyPress);
            // 
            // cmb_itemcode
            // 
            this.cmb_itemcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_itemcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_itemcode.FormattingEnabled = true;
            this.cmb_itemcode.Location = new System.Drawing.Point(89, 13);
            this.cmb_itemcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_itemcode.Name = "cmb_itemcode";
            this.cmb_itemcode.Size = new System.Drawing.Size(245, 24);
            this.cmb_itemcode.TabIndex = 1;
            this.cmb_itemcode.SelectedIndexChanged += new System.EventHandler(this.cmb_itemcode_SelectedIndexChanged);
            this.cmb_itemcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_itemcode_KeyDown);
            this.cmb_itemcode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_itemcode_MouseClick);
            // 
            // txt_unitprice
            // 
            this.txt_unitprice.Location = new System.Drawing.Point(89, 92);
            this.txt_unitprice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_unitprice.MaxLength = 6;
            this.txt_unitprice.Name = "txt_unitprice";
            this.txt_unitprice.Size = new System.Drawing.Size(245, 24);
            this.txt_unitprice.TabIndex = 3;
            this.txt_unitprice.Text = "0.00";
            this.txt_unitprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_unitprice.TextChanged += new System.EventHandler(this.txt_unitprice_TextChanged);
            this.txt_unitprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_unitprice_KeyDown);
            this.txt_unitprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_unitprice_KeyPress);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(407, 53);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(91, 17);
            this.lbl_total.TabIndex = 3;
            this.lbl_total.Text = "Total Amount";
            this.lbl_total.Click += new System.EventHandler(this.lbl_total_Click);
            // 
            // lbl_itemcode
            // 
            this.lbl_itemcode.AutoSize = true;
            this.lbl_itemcode.Location = new System.Drawing.Point(8, 22);
            this.lbl_itemcode.Name = "lbl_itemcode";
            this.lbl_itemcode.Size = new System.Drawing.Size(76, 17);
            this.lbl_itemcode.TabIndex = 22;
            this.lbl_itemcode.Text = "Item Code ";
            this.lbl_itemcode.Click += new System.EventHandler(this.lbl_itemcode_Click);
            // 
            // gv_stock
            // 
            this.gv_stock.AllowUserToAddRows = false;
            this.gv_stock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gv_stock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column11,
            this.Column12,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column10});
            this.gv_stock.Location = new System.Drawing.Point(5, 155);
            this.gv_stock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gv_stock.Name = "gv_stock";
            this.gv_stock.RowHeadersWidth = 5;
            this.gv_stock.Size = new System.Drawing.Size(888, 138);
            this.gv_stock.TabIndex = 1;
            this.gv_stock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_stock_CellClick);
            this.gv_stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_stock_CellContentClick);
            this.gv_stock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_stock_CellDoubleClick);
            this.gv_stock.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_stock_CellEndEdit);
            this.gv_stock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gv_stock_KeyDown);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "SlNo";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 40;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Item Code";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            this.Column11.Width = 80;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Item Type";
            this.Column12.Name = "Column12";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total Amount";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Description";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "itemid";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Delete";
            this.Column9.Image = global::BisCarePosEdition.Properties.Resources.delete6;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "id";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Image = global::BisCarePosEdition.Properties.Resources.search4;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(437, 429);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(110, 32);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "        Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            this.btn_search.MouseEnter += new System.EventHandler(this.btn_search_MouseEnter);
            this.btn_search.MouseLeave += new System.EventHandler(this.btn_search_MouseLeave);
            // 
            // dtp_stockdate
            // 
            this.dtp_stockdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_stockdate.Location = new System.Drawing.Point(53, 20);
            this.dtp_stockdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_stockdate.Name = "dtp_stockdate";
            this.dtp_stockdate.Size = new System.Drawing.Size(195, 24);
            this.dtp_stockdate.TabIndex = 105;
            this.dtp_stockdate.ValueChanged += new System.EventHandler(this.dtp_stockdate_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 106;
            this.label4.Text = "Date ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // grp_dealerIn
            // 
            this.grp_dealerIn.Controls.Add(this.label11);
            this.grp_dealerIn.Controls.Add(this.txtDealerRefNo);
            this.grp_dealerIn.Location = new System.Drawing.Point(596, 70);
            this.grp_dealerIn.Name = "grp_dealerIn";
            this.grp_dealerIn.Size = new System.Drawing.Size(314, 53);
            this.grp_dealerIn.TabIndex = 33;
            this.grp_dealerIn.TabStop = false;
            this.grp_dealerIn.Enter += new System.EventHandler(this.grp_dealerIn_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Dealer Reference No";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtDealerRefNo
            // 
            this.txtDealerRefNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDealerRefNo.Location = new System.Drawing.Point(145, 16);
            this.txtDealerRefNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDealerRefNo.Name = "txtDealerRefNo";
            this.txtDealerRefNo.Size = new System.Drawing.Size(162, 23);
            this.txtDealerRefNo.TabIndex = 3;
            this.txtDealerRefNo.TextChanged += new System.EventHandler(this.txtDealerRefNo_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rb_OldStock);
            this.groupBox2.Controls.Add(this.rbtnNormal);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(295, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(281, 45);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Purchase Type";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Rb_OldStock
            // 
            this.Rb_OldStock.AutoSize = true;
            this.Rb_OldStock.Location = new System.Drawing.Point(139, 16);
            this.Rb_OldStock.Name = "Rb_OldStock";
            this.Rb_OldStock.Size = new System.Drawing.Size(85, 21);
            this.Rb_OldStock.TabIndex = 2;
            this.Rb_OldStock.TabStop = true;
            this.Rb_OldStock.Text = "Old Stock";
            this.Rb_OldStock.UseVisualStyleBackColor = true;
            this.Rb_OldStock.CheckedChanged += new System.EventHandler(this.Rb_OldStock_CheckedChanged);
            // 
            // rbtnNormal
            // 
            this.rbtnNormal.AutoSize = true;
            this.rbtnNormal.Checked = true;
            this.rbtnNormal.Location = new System.Drawing.Point(46, 18);
            this.rbtnNormal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnNormal.Name = "rbtnNormal";
            this.rbtnNormal.Size = new System.Drawing.Size(62, 21);
            this.rbtnNormal.TabIndex = 0;
            this.rbtnNormal.TabStop = true;
            this.rbtnNormal.Text = "Direct";
            this.rbtnNormal.UseVisualStyleBackColor = true;
            this.rbtnNormal.CheckedChanged += new System.EventHandler(this.rbtnNormal_CheckedChanged);
            // 
            // Gr_Dealer
            // 
            this.Gr_Dealer.Controls.Add(this.btnNewCust);
            this.Gr_Dealer.Controls.Add(this.txtTinNo);
            this.Gr_Dealer.Controls.Add(this.label2);
            this.Gr_Dealer.Controls.Add(this.cboxCustomer);
            this.Gr_Dealer.Controls.Add(this.label3);
            this.Gr_Dealer.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gr_Dealer.Location = new System.Drawing.Point(5, 70);
            this.Gr_Dealer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gr_Dealer.Name = "Gr_Dealer";
            this.Gr_Dealer.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gr_Dealer.Size = new System.Drawing.Size(584, 53);
            this.Gr_Dealer.TabIndex = 32;
            this.Gr_Dealer.TabStop = false;
            this.Gr_Dealer.Text = "Dealer Details";
            this.Gr_Dealer.Enter += new System.EventHandler(this.Gr_Dealer_Enter);
            // 
            // btnNewCust
            // 
            this.btnNewCust.BackColor = System.Drawing.Color.Transparent;
            this.btnNewCust.FlatAppearance.BorderSize = 0;
            this.btnNewCust.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNewCust.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNewCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCust.Image = global::BisCarePosEdition.Properties.Resources.Add_;
            this.btnNewCust.Location = new System.Drawing.Point(339, 18);
            this.btnNewCust.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNewCust.Name = "btnNewCust";
            this.btnNewCust.Size = new System.Drawing.Size(25, 25);
            this.btnNewCust.TabIndex = 1;
            this.btnNewCust.UseVisualStyleBackColor = false;
            this.btnNewCust.Click += new System.EventHandler(this.btnNewCust_Click);
            // 
            // txtTinNo
            // 
            this.txtTinNo.Enabled = false;
            this.txtTinNo.Location = new System.Drawing.Point(425, 18);
            this.txtTinNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTinNo.Name = "txtTinNo";
            this.txtTinNo.Size = new System.Drawing.Size(139, 24);
            this.txtTinNo.TabIndex = 2;
            this.txtTinNo.TextChanged += new System.EventHandler(this.txtTinNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "TIN No";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboxCustomer
            // 
            this.cboxCustomer.FormattingEnabled = true;
            this.cboxCustomer.Location = new System.Drawing.Point(58, 19);
            this.cboxCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCustomer.Name = "cboxCustomer";
            this.cboxCustomer.Size = new System.Drawing.Size(276, 24);
            this.cboxCustomer.TabIndex = 0;
            this.cboxCustomer.SelectedIndexChanged += new System.EventHandler(this.cboxCustomer_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_countersale);
            this.groupBox1.Controls.Add(this.rd_Ingradiant);
            this.groupBox1.Location = new System.Drawing.Point(582, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 46);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rd_countersale
            // 
            this.rd_countersale.AutoSize = true;
            this.rd_countersale.ForeColor = System.Drawing.Color.Black;
            this.rd_countersale.Location = new System.Drawing.Point(153, 21);
            this.rd_countersale.Name = "rd_countersale";
            this.rd_countersale.Size = new System.Drawing.Size(104, 21);
            this.rd_countersale.TabIndex = 2;
            this.rd_countersale.Text = "Counter Sale";
            this.rd_countersale.UseVisualStyleBackColor = true;
            this.rd_countersale.CheckedChanged += new System.EventHandler(this.rd_countersale_CheckedChanged_1);
            // 
            // rd_Ingradiant
            // 
            this.rd_Ingradiant.AutoSize = true;
            this.rd_Ingradiant.Checked = true;
            this.rd_Ingradiant.ForeColor = System.Drawing.Color.Black;
            this.rd_Ingradiant.Location = new System.Drawing.Point(36, 20);
            this.rd_Ingradiant.Name = "rd_Ingradiant";
            this.rd_Ingradiant.Size = new System.Drawing.Size(88, 21);
            this.rd_Ingradiant.TabIndex = 1;
            this.rd_Ingradiant.TabStop = true;
            this.rd_Ingradiant.Text = "Ingredient";
            this.rd_Ingradiant.UseVisualStyleBackColor = true;
            this.rd_Ingradiant.CheckedChanged += new System.EventHandler(this.rd_Ingradiant_CheckedChanged_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Location = new System.Drawing.Point(4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(905, 68);
            this.groupBox5.TabIndex = 109;
            this.groupBox5.TabStop = false;
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtp_stockdate);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(6, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(273, 46);
            this.groupBox6.TabIndex = 99;
            this.groupBox6.TabStop = false;
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // StockEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(917, 603);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.grp_dealerIn);
            this.Controls.Add(this.Gr_Dealer);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lbll_total);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goods Receipt";
            this.Load += new System.EventHandler(this.StockEntry_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_stock)).EndInit();
            this.grp_dealerIn.ResumeLayout(false);
            this.grp_dealerIn.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Gr_Dealer.ResumeLayout(false);
            this.Gr_Dealer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbll_total;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cmb_itemname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_totala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Button BTN_RESET;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lbl_itemname;
        private System.Windows.Forms.Label lbl_unitprice;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.TextBox txt_totalamount;
        private System.Windows.Forms.ComboBox cmb_itemcode;
        private System.Windows.Forms.TextBox txt_unitprice;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_itemcode;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView gv_stock;
        private System.Windows.Forms.Button bttn_newcategory;
        private System.Windows.Forms.Label lb_quantity;
        private System.Windows.Forms.GroupBox grp_dealerIn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDealerRefNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Rb_OldStock;
        private System.Windows.Forms.RadioButton rbtnNormal;
        private System.Windows.Forms.GroupBox Gr_Dealer;
        private System.Windows.Forms.Button btnNewCust;
        private System.Windows.Forms.TextBox txtTinNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_countersale;
        private System.Windows.Forms.RadioButton rd_Ingradiant;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtPayingAmt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cboxPurchaser;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtp_stockdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPayable;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.TextBox txtsid;
    }
}