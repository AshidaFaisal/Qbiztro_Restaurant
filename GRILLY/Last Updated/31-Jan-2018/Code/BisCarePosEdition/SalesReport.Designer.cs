namespace BisCarePosEdition
{
    partial class SalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmb_user = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_user = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioalltype = new System.Windows.Forms.RadioButton();
            this.radiocredit = new System.Windows.Forms.RadioButton();
            this.radiocash = new System.Windows.Forms.RadioButton();
            this.ch_BillType = new System.Windows.Forms.CheckBox();
            this.grp_BillType = new System.Windows.Forms.GroupBox();
            this.rbtnNonAC = new System.Windows.Forms.RadioButton();
            this.rbtnAC = new System.Windows.Forms.RadioButton();
            this.rd_all = new System.Windows.Forms.RadioButton();
            this.rd_counterBill = new System.Windows.Forms.RadioButton();
            this.rd_takeaway = new System.Windows.Forms.RadioButton();
            this.rd_Dinein = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.grp_Item = new System.Windows.Forms.GroupBox();
            this.cmb_item = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ch_item = new System.Windows.Forms.CheckBox();
            this.grpCat = new System.Windows.Forms.GroupBox();
            this.cmb_Cat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ch_Cat = new System.Windows.Forms.CheckBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_viewreport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rd_weekly = new System.Windows.Forms.RadioButton();
            this.rd_custom = new System.Windows.Forms.RadioButton();
            this.rd_monthly = new System.Windows.Forms.RadioButton();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grp_Waiter = new System.Windows.Forms.GroupBox();
            this.cmb_Waiter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ch_Waiter = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grp_BillType.SuspendLayout();
            this.grp_Item.SuspendLayout();
            this.grpCat.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grp_Waiter.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.chk_user);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.ch_BillType);
            this.groupBox1.Controls.Add(this.grp_BillType);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.grp_Item);
            this.groupBox1.Controls.Add(this.ch_item);
            this.groupBox1.Controls.Add(this.grpCat);
            this.groupBox1.Controls.Add(this.ch_Cat);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_viewreport);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.grp_Waiter);
            this.groupBox1.Controls.Add(this.ch_Waiter);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "fn";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmb_user);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(22, 252);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(308, 71);
            this.groupBox5.TabIndex = 53;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select Cashier";
            // 
            // cmb_user
            // 
            this.cmb_user.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_user.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_user.FormattingEnabled = true;
            this.cmb_user.Location = new System.Drawing.Point(82, 28);
            this.cmb_user.Name = "cmb_user";
            this.cmb_user.Size = new System.Drawing.Size(219, 24);
            this.cmb_user.TabIndex = 0;
            this.cmb_user.SelectedIndexChanged += new System.EventHandler(this.cmb_user_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cashier";
            // 
            // chk_user
            // 
            this.chk_user.AutoSize = true;
            this.chk_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_user.Location = new System.Drawing.Point(22, 223);
            this.chk_user.Name = "chk_user";
            this.chk_user.Size = new System.Drawing.Size(119, 20);
            this.chk_user.TabIndex = 52;
            this.chk_user.Text = "Include Cashier";
            this.chk_user.UseVisualStyleBackColor = true;
            this.chk_user.CheckedChanged += new System.EventHandler(this.chk_user_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioalltype);
            this.groupBox4.Controls.Add(this.radiocredit);
            this.groupBox4.Controls.Add(this.radiocash);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(13, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(324, 86);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select SaleType";
            // 
            // radioalltype
            // 
            this.radioalltype.AutoSize = true;
            this.radioalltype.Checked = true;
            this.radioalltype.Location = new System.Drawing.Point(42, 35);
            this.radioalltype.Name = "radioalltype";
            this.radioalltype.Size = new System.Drawing.Size(41, 20);
            this.radioalltype.TabIndex = 54;
            this.radioalltype.TabStop = true;
            this.radioalltype.Text = "All";
            this.radioalltype.UseVisualStyleBackColor = true;
            this.radioalltype.CheckedChanged += new System.EventHandler(this.radioalltype_CheckedChanged);
            // 
            // radiocredit
            // 
            this.radiocredit.AutoSize = true;
            this.radiocredit.Location = new System.Drawing.Point(222, 36);
            this.radiocredit.Name = "radiocredit";
            this.radiocredit.Size = new System.Drawing.Size(61, 20);
            this.radiocredit.TabIndex = 53;
            this.radiocredit.Text = "Credit";
            this.radiocredit.UseVisualStyleBackColor = true;
            this.radiocredit.CheckedChanged += new System.EventHandler(this.radiocredit_CheckedChanged);
            // 
            // radiocash
            // 
            this.radiocash.AutoSize = true;
            this.radiocash.Location = new System.Drawing.Point(123, 35);
            this.radiocash.Name = "radiocash";
            this.radiocash.Size = new System.Drawing.Size(57, 20);
            this.radiocash.TabIndex = 52;
            this.radiocash.Text = "Cash";
            this.radiocash.UseVisualStyleBackColor = true;
            this.radiocash.CheckedChanged += new System.EventHandler(this.radiocash_CheckedChanged);
            // 
            // ch_BillType
            // 
            this.ch_BillType.AutoSize = true;
            this.ch_BillType.Checked = true;
            this.ch_BillType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_BillType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_BillType.Location = new System.Drawing.Point(658, 15);
            this.ch_BillType.Name = "ch_BillType";
            this.ch_BillType.Size = new System.Drawing.Size(126, 20);
            this.ch_BillType.TabIndex = 49;
            this.ch_BillType.Text = "Include Bill Type";
            this.ch_BillType.UseVisualStyleBackColor = true;
            this.ch_BillType.Visible = false;
            // 
            // grp_BillType
            // 
            this.grp_BillType.Controls.Add(this.rbtnNonAC);
            this.grp_BillType.Controls.Add(this.rbtnAC);
            this.grp_BillType.Controls.Add(this.rd_all);
            this.grp_BillType.Controls.Add(this.rd_counterBill);
            this.grp_BillType.Controls.Add(this.rd_takeaway);
            this.grp_BillType.Controls.Add(this.rd_Dinein);
            this.grp_BillType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_BillType.Location = new System.Drawing.Point(658, 41);
            this.grp_BillType.Name = "grp_BillType";
            this.grp_BillType.Size = new System.Drawing.Size(299, 129);
            this.grp_BillType.TabIndex = 48;
            this.grp_BillType.TabStop = false;
            this.grp_BillType.Text = "Bill Type";
            // 
            // rbtnNonAC
            // 
            this.rbtnNonAC.AutoSize = true;
            this.rbtnNonAC.Location = new System.Drawing.Point(174, 89);
            this.rbtnNonAC.Name = "rbtnNonAC";
            this.rbtnNonAC.Size = new System.Drawing.Size(106, 21);
            this.rbtnNonAC.TabIndex = 53;
            this.rbtnNonAC.TabStop = true;
            this.rbtnNonAC.Text = "Non AC Sale";
            this.rbtnNonAC.UseVisualStyleBackColor = true;
            this.rbtnNonAC.CheckedChanged += new System.EventHandler(this.rbtnNonAC_CheckedChanged);
            // 
            // rbtnAC
            // 
            this.rbtnAC.AutoSize = true;
            this.rbtnAC.Location = new System.Drawing.Point(28, 89);
            this.rbtnAC.Name = "rbtnAC";
            this.rbtnAC.Size = new System.Drawing.Size(76, 21);
            this.rbtnAC.TabIndex = 52;
            this.rbtnAC.TabStop = true;
            this.rbtnAC.Text = "AC Sale";
            this.rbtnAC.UseVisualStyleBackColor = true;
            // 
            // rd_all
            // 
            this.rd_all.AutoSize = true;
            this.rd_all.Checked = true;
            this.rd_all.Location = new System.Drawing.Point(28, 35);
            this.rd_all.Name = "rd_all";
            this.rd_all.Size = new System.Drawing.Size(41, 21);
            this.rd_all.TabIndex = 51;
            this.rd_all.TabStop = true;
            this.rd_all.Text = "All";
            this.rd_all.UseVisualStyleBackColor = true;
            // 
            // rd_counterBill
            // 
            this.rd_counterBill.AutoSize = true;
            this.rd_counterBill.Location = new System.Drawing.Point(28, 62);
            this.rd_counterBill.Name = "rd_counterBill";
            this.rd_counterBill.Size = new System.Drawing.Size(98, 21);
            this.rd_counterBill.TabIndex = 50;
            this.rd_counterBill.Text = "Counter Bill";
            this.rd_counterBill.UseVisualStyleBackColor = true;
            this.rd_counterBill.CheckedChanged += new System.EventHandler(this.rd_counterBill_CheckedChanged);
            // 
            // rd_takeaway
            // 
            this.rd_takeaway.AutoSize = true;
            this.rd_takeaway.Location = new System.Drawing.Point(174, 62);
            this.rd_takeaway.Name = "rd_takeaway";
            this.rd_takeaway.Size = new System.Drawing.Size(95, 21);
            this.rd_takeaway.TabIndex = 49;
            this.rd_takeaway.Text = "Take Away";
            this.rd_takeaway.UseVisualStyleBackColor = true;
            this.rd_takeaway.CheckedChanged += new System.EventHandler(this.rd_takeaway_CheckedChanged);
            // 
            // rd_Dinein
            // 
            this.rd_Dinein.AutoSize = true;
            this.rd_Dinein.Location = new System.Drawing.Point(174, 35);
            this.rd_Dinein.Name = "rd_Dinein";
            this.rd_Dinein.Size = new System.Drawing.Size(70, 21);
            this.rd_Dinein.TabIndex = 48;
            this.rd_Dinein.Text = "Dine In";
            this.rd_Dinein.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(246, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 34);
            this.button1.TabIndex = 45;
            this.button1.Text = "Print Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grp_Item
            // 
            this.grp_Item.Controls.Add(this.cmb_item);
            this.grp_Item.Controls.Add(this.label2);
            this.grp_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Item.Location = new System.Drawing.Point(342, 218);
            this.grp_Item.Name = "grp_Item";
            this.grp_Item.Size = new System.Drawing.Size(308, 96);
            this.grp_Item.TabIndex = 44;
            this.grp_Item.TabStop = false;
            this.grp_Item.Text = "Select Item";
            // 
            // cmb_item
            // 
            this.cmb_item.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_item.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_item.FormattingEnabled = true;
            this.cmb_item.Location = new System.Drawing.Point(61, 44);
            this.cmb_item.Name = "cmb_item";
            this.cmb_item.Size = new System.Drawing.Size(219, 24);
            this.cmb_item.TabIndex = 0;
            this.cmb_item.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_item_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item ";
            // 
            // ch_item
            // 
            this.ch_item.AutoSize = true;
            this.ch_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_item.Location = new System.Drawing.Point(342, 179);
            this.ch_item.Name = "ch_item";
            this.ch_item.Size = new System.Drawing.Size(98, 20);
            this.ch_item.TabIndex = 3;
            this.ch_item.Text = "Include Item";
            this.ch_item.UseVisualStyleBackColor = true;
            this.ch_item.CheckedChanged += new System.EventHandler(this.ch_item_CheckedChanged);
            // 
            // grpCat
            // 
            this.grpCat.Controls.Add(this.cmb_Cat);
            this.grpCat.Controls.Add(this.label5);
            this.grpCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCat.Location = new System.Drawing.Point(343, 50);
            this.grpCat.Name = "grpCat";
            this.grpCat.Size = new System.Drawing.Size(308, 109);
            this.grpCat.TabIndex = 39;
            this.grpCat.TabStop = false;
            this.grpCat.Text = "Select Category";
            // 
            // cmb_Cat
            // 
            this.cmb_Cat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Cat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Cat.FormattingEnabled = true;
            this.cmb_Cat.Location = new System.Drawing.Point(82, 28);
            this.cmb_Cat.Name = "cmb_Cat";
            this.cmb_Cat.Size = new System.Drawing.Size(219, 24);
            this.cmb_Cat.TabIndex = 0;
            this.cmb_Cat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Cat_KeyDown);
            this.cmb_Cat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Cat_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Category";
            // 
            // ch_Cat
            // 
            this.ch_Cat.AutoSize = true;
            this.ch_Cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_Cat.Location = new System.Drawing.Point(343, 21);
            this.ch_Cat.Name = "ch_Cat";
            this.ch_Cat.Size = new System.Drawing.Size(128, 20);
            this.ch_Cat.TabIndex = 2;
            this.ch_Cat.Text = "Include Category";
            this.ch_Cat.UseVisualStyleBackColor = true;
            this.ch_Cat.CheckedChanged += new System.EventHandler(this.ch_Cat_CheckedChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(626, 329);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(128, 34);
            this.btn_cancel.TabIndex = 41;
            this.btn_cancel.Text = "Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseEnter += new System.EventHandler(this.btn_viewreport_MouseEnter);
            this.btn_cancel.MouseLeave += new System.EventHandler(this.btn_viewreport_MouseLeave);
            // 
            // btn_viewreport
            // 
            this.btn_viewreport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_viewreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewreport.Image = global::BisCarePosEdition.Properties.Resources.Reportnew;
            this.btn_viewreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viewreport.Location = new System.Drawing.Point(446, 329);
            this.btn_viewreport.Name = "btn_viewreport";
            this.btn_viewreport.Size = new System.Drawing.Size(163, 34);
            this.btn_viewreport.TabIndex = 40;
            this.btn_viewreport.Text = "View Report";
            this.btn_viewreport.UseVisualStyleBackColor = false;
            this.btn_viewreport.Click += new System.EventHandler(this.btn_viewreport_Click);
            this.btn_viewreport.MouseEnter += new System.EventHandler(this.btn_viewreport_MouseEnter);
            this.btn_viewreport.MouseLeave += new System.EventHandler(this.btn_viewreport_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dtp_start);
            this.groupBox2.Controls.Add(this.dtp_end);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 115);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rd_weekly);
            this.groupBox3.Controls.Add(this.rd_custom);
            this.groupBox3.Controls.Add(this.rd_monthly);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 47);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            // 
            // rd_weekly
            // 
            this.rd_weekly.AutoSize = true;
            this.rd_weekly.Location = new System.Drawing.Point(211, 19);
            this.rd_weekly.Name = "rd_weekly";
            this.rd_weekly.Size = new System.Drawing.Size(91, 20);
            this.rd_weekly.TabIndex = 7;
            this.rd_weekly.TabStop = true;
            this.rd_weekly.Text = "This Week";
            this.rd_weekly.UseVisualStyleBackColor = true;
            this.rd_weekly.CheckedChanged += new System.EventHandler(this.rd_weekly_CheckedChanged);
            // 
            // rd_custom
            // 
            this.rd_custom.AutoSize = true;
            this.rd_custom.Location = new System.Drawing.Point(7, 19);
            this.rd_custom.Name = "rd_custom";
            this.rd_custom.Size = new System.Drawing.Size(71, 20);
            this.rd_custom.TabIndex = 5;
            this.rd_custom.TabStop = true;
            this.rd_custom.Text = "Custom";
            this.rd_custom.UseVisualStyleBackColor = true;
            // 
            // rd_monthly
            // 
            this.rd_monthly.AutoSize = true;
            this.rd_monthly.Location = new System.Drawing.Point(98, 19);
            this.rd_monthly.Name = "rd_monthly";
            this.rd_monthly.Size = new System.Drawing.Size(91, 20);
            this.rd_monthly.TabIndex = 6;
            this.rd_monthly.TabStop = true;
            this.rd_monthly.Text = "This Month";
            this.rd_monthly.UseVisualStyleBackColor = true;
            this.rd_monthly.CheckedChanged += new System.EventHandler(this.rd_monthly_CheckedChanged);
            // 
            // dtp_start
            // 
            this.dtp_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start.Location = new System.Drawing.Point(96, 51);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(179, 22);
            this.dtp_start.TabIndex = 0;
            this.dtp_start.ValueChanged += new System.EventHandler(this.dtp_start_ValueChanged);
            this.dtp_start.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_start_KeyDown);
            // 
            // dtp_end
            // 
            this.dtp_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(94, 83);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(179, 22);
            this.dtp_end.TabIndex = 1;
            this.dtp_end.ValueChanged += new System.EventHandler(this.dtp_end_ValueChanged);
            this.dtp_end.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_end_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Date ";
            // 
            // grp_Waiter
            // 
            this.grp_Waiter.Controls.Add(this.cmb_Waiter);
            this.grp_Waiter.Controls.Add(this.label4);
            this.grp_Waiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Waiter.Location = new System.Drawing.Point(658, 223);
            this.grp_Waiter.Name = "grp_Waiter";
            this.grp_Waiter.Size = new System.Drawing.Size(315, 91);
            this.grp_Waiter.TabIndex = 38;
            this.grp_Waiter.TabStop = false;
            this.grp_Waiter.Text = "Select Waiter";
            this.grp_Waiter.Enter += new System.EventHandler(this.grp_Waiter_Enter);
            // 
            // cmb_Waiter
            // 
            this.cmb_Waiter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Waiter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Waiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Waiter.FormattingEnabled = true;
            this.cmb_Waiter.Location = new System.Drawing.Point(99, 36);
            this.cmb_Waiter.Name = "cmb_Waiter";
            this.cmb_Waiter.Size = new System.Drawing.Size(188, 24);
            this.cmb_Waiter.TabIndex = 0;
            this.cmb_Waiter.SelectedIndexChanged += new System.EventHandler(this.cmb_Waiter_SelectedIndexChanged);
            this.cmb_Waiter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Waiter_KeyDown);
            this.cmb_Waiter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Waiter_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Waiter Name";
            // 
            // ch_Waiter
            // 
            this.ch_Waiter.AutoSize = true;
            this.ch_Waiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_Waiter.Location = new System.Drawing.Point(676, 196);
            this.ch_Waiter.Name = "ch_Waiter";
            this.ch_Waiter.Size = new System.Drawing.Size(112, 20);
            this.ch_Waiter.TabIndex = 1;
            this.ch_Waiter.Text = "Include Waiter";
            this.ch_Waiter.UseVisualStyleBackColor = true;
            this.ch_Waiter.CheckedChanged += new System.EventHandler(this.ch_Waiter_CheckedChanged);
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(984, 364);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grp_BillType.ResumeLayout(false);
            this.grp_BillType.PerformLayout();
            this.grp_Item.ResumeLayout(false);
            this.grp_Item.PerformLayout();
            this.grpCat.ResumeLayout(false);
            this.grpCat.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grp_Waiter.ResumeLayout(false);
            this.grp_Waiter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpCat;
        private System.Windows.Forms.ComboBox cmb_Cat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ch_Cat;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_viewreport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grp_Waiter;
        private System.Windows.Forms.ComboBox cmb_Waiter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ch_Waiter;
        private System.Windows.Forms.GroupBox grp_Item;
        private System.Windows.Forms.ComboBox cmb_item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ch_item;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rd_weekly;
        private System.Windows.Forms.RadioButton rd_monthly;
        private System.Windows.Forms.RadioButton rd_custom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ch_BillType;
        private System.Windows.Forms.GroupBox grp_BillType;
        private System.Windows.Forms.RadioButton rbtnNonAC;
        private System.Windows.Forms.RadioButton rbtnAC;
        private System.Windows.Forms.RadioButton rd_all;
        private System.Windows.Forms.RadioButton rd_counterBill;
        private System.Windows.Forms.RadioButton rd_takeaway;
        private System.Windows.Forms.RadioButton rd_Dinein;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioalltype;
        private System.Windows.Forms.RadioButton radiocredit;
        private System.Windows.Forms.RadioButton radiocash;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmb_user;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_user;
    }
}