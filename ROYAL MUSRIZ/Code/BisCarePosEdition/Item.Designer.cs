namespace BisCarePosEdition
{
    partial class Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item));
            this.Cmb_UnitType = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmb_catname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_itemcode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_itemname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rb_edit = new System.Windows.Forms.RadioButton();
            this.Rb_new = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.Cmb_itemname = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gb_image = new System.Windows.Forms.GroupBox();
            this.chk_changeprice = new System.Windows.Forms.CheckBox();
            this.lbl_delivery = new System.Windows.Forms.Label();
            this.txt_homedelivery = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cmb_department = new System.Windows.Forms.ComboBox();
            this.bttn_reset = new System.Windows.Forms.Button();
            this.txtSellPriceNonAC = new System.Windows.Forms.TextBox();
            this.lblSellNonAc = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rd_countersale = new System.Windows.Forms.RadioButton();
            this.rd_Ingradiant = new System.Windows.Forms.RadioButton();
            this.rd_Prodect = new System.Windows.Forms.RadioButton();
            this.btn_NewUnit = new System.Windows.Forms.Button();
            this.bttn_newcategory = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_sellprice = new System.Windows.Forms.TextBox();
            this.lbl_Sell = new System.Windows.Forms.Label();
            this.txt_codeprice = new System.Windows.Forms.TextBox();
            this.txt_arabic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.pb_photo = new System.Windows.Forms.PictureBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.lbl_image = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_taxid = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rb_multiple = new System.Windows.Forms.RadioButton();
            this.rb_single = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Txt_OrgsellPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.gb_image.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmb_UnitType
            // 
            this.Cmb_UnitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_UnitType.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_UnitType.FormattingEnabled = true;
            this.Cmb_UnitType.Location = new System.Drawing.Point(545, 124);
            this.Cmb_UnitType.Name = "Cmb_UnitType";
            this.Cmb_UnitType.Size = new System.Drawing.Size(173, 24);
            this.Cmb_UnitType.TabIndex = 7;
            this.Cmb_UnitType.SelectedIndexChanged += new System.EventHandler(this.Cmb_UnitType_SelectedIndexChanged);
            this.Cmb_UnitType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_UnitType_KeyDown);
            this.Cmb_UnitType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cmb_UnitType_MouseClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(485, 127);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 17);
            this.label16.TabIndex = 65;
            this.label16.Text = "Unit";
            // 
            // cmb_catname
            // 
            this.cmb_catname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_catname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_catname.DropDownWidth = 300;
            this.cmb_catname.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_catname.FormattingEnabled = true;
            this.cmb_catname.Location = new System.Drawing.Point(132, 120);
            this.cmb_catname.Name = "cmb_catname";
            this.cmb_catname.Size = new System.Drawing.Size(227, 24);
            this.cmb_catname.TabIndex = 3;
            this.cmb_catname.SelectedIndexChanged += new System.EventHandler(this.cmb_catname_SelectedIndexChanged);
            this.cmb_catname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_catname_KeyDown);
            this.cmb_catname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_catname_KeyPress);
            this.cmb_catname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_catname_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(9, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 60;
            this.label9.Text = "Item Name";
            // 
            // txt_itemcode
            // 
            this.txt_itemcode.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemcode.Location = new System.Drawing.Point(132, 203);
            this.txt_itemcode.MaxLength = 15;
            this.txt_itemcode.Name = "txt_itemcode";
            this.txt_itemcode.Size = new System.Drawing.Size(229, 24);
            this.txt_itemcode.TabIndex = 5;
            this.txt_itemcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_itemcode_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(9, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 17);
            this.label13.TabIndex = 61;
            this.label13.Text = "Item Code";
            // 
            // txt_itemname
            // 
            this.txt_itemname.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemname.Location = new System.Drawing.Point(132, 243);
            this.txt_itemname.MaxLength = 50;
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Size = new System.Drawing.Size(229, 24);
            this.txt_itemname.TabIndex = 6;
            this.txt_itemname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_itemname_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rb_edit);
            this.groupBox2.Controls.Add(this.Rb_new);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 47);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // Rb_edit
            // 
            this.Rb_edit.AutoSize = true;
            this.Rb_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_edit.ForeColor = System.Drawing.Color.Black;
            this.Rb_edit.Location = new System.Drawing.Point(122, 18);
            this.Rb_edit.Name = "Rb_edit";
            this.Rb_edit.Size = new System.Drawing.Size(50, 21);
            this.Rb_edit.TabIndex = 1;
            this.Rb_edit.Text = "Edit";
            this.Rb_edit.UseVisualStyleBackColor = true;
            this.Rb_edit.CheckedChanged += new System.EventHandler(this.Rb_edit_CheckedChanged);
            this.Rb_edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Rb_edit_KeyDown);
            // 
            // Rb_new
            // 
            this.Rb_new.AutoSize = true;
            this.Rb_new.Checked = true;
            this.Rb_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_new.ForeColor = System.Drawing.Color.Black;
            this.Rb_new.Location = new System.Drawing.Point(14, 19);
            this.Rb_new.Name = "Rb_new";
            this.Rb_new.Size = new System.Drawing.Size(53, 21);
            this.Rb_new.TabIndex = 0;
            this.Rb_new.TabStop = true;
            this.Rb_new.Text = "New";
            this.Rb_new.UseVisualStyleBackColor = true;
            this.Rb_new.CheckedChanged += new System.EventHandler(this.Rb_new_CheckedChanged);
            this.Rb_new.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Rb_new_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(370, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 67;
            this.label6.Text = "Barcode(EAN)";
            this.label6.Visible = false;
            // 
            // txt_barcode
            // 
            this.txt_barcode.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcode.Location = new System.Drawing.Point(453, 317);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(173, 24);
            this.txt_barcode.TabIndex = 6;
            this.txt_barcode.Visible = false;
            // 
            // Cmb_itemname
            // 
            this.Cmb_itemname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_itemname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_itemname.DropDownWidth = 400;
            this.Cmb_itemname.Enabled = false;
            this.Cmb_itemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_itemname.FormattingEnabled = true;
            this.Cmb_itemname.Location = new System.Drawing.Point(453, 25);
            this.Cmb_itemname.Name = "Cmb_itemname";
            this.Cmb_itemname.Size = new System.Drawing.Size(265, 24);
            this.Cmb_itemname.TabIndex = 1;
            this.Cmb_itemname.SelectedIndexChanged += new System.EventHandler(this.Cmb_itemname_SelectedIndexChanged);
            this.Cmb_itemname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_itemname_KeyDown);
            this.Cmb_itemname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_itemname_KeyPress);
            this.Cmb_itemname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cmb_itemname_MouseClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(354, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 17);
            this.label14.TabIndex = 70;
            this.label14.Text = "Item Name";
            // 
            // gb_image
            // 
            this.gb_image.BackColor = System.Drawing.Color.Transparent;
            this.gb_image.Controls.Add(this.Txt_OrgsellPrice);
            this.gb_image.Controls.Add(this.label5);
            this.gb_image.Controls.Add(this.chk_changeprice);
            this.gb_image.Controls.Add(this.lbl_delivery);
            this.gb_image.Controls.Add(this.txt_homedelivery);
            this.gb_image.Controls.Add(this.label2);
            this.gb_image.Controls.Add(this.button2);
            this.gb_image.Controls.Add(this.cmb_department);
            this.gb_image.Controls.Add(this.bttn_reset);
            this.gb_image.Controls.Add(this.txtSellPriceNonAC);
            this.gb_image.Controls.Add(this.lblSellNonAc);
            this.gb_image.Controls.Add(this.txt_itemcode);
            this.gb_image.Controls.Add(this.groupBox3);
            this.gb_image.Controls.Add(this.btn_NewUnit);
            this.gb_image.Controls.Add(this.bttn_newcategory);
            this.gb_image.Controls.Add(this.btn_cancel);
            this.gb_image.Controls.Add(this.Btn_Delete);
            this.gb_image.Controls.Add(this.btn_save);
            this.gb_image.Controls.Add(this.Cmb_itemname);
            this.gb_image.Controls.Add(this.label14);
            this.gb_image.Controls.Add(this.groupBox2);
            this.gb_image.Controls.Add(this.txt_sellprice);
            this.gb_image.Controls.Add(this.lbl_Sell);
            this.gb_image.Controls.Add(this.txt_codeprice);
            this.gb_image.Controls.Add(this.cmb_catname);
            this.gb_image.Controls.Add(this.txt_arabic);
            this.gb_image.Controls.Add(this.txt_itemname);
            this.gb_image.Controls.Add(this.label13);
            this.gb_image.Controls.Add(this.label4);
            this.gb_image.Controls.Add(this.label9);
            this.gb_image.Controls.Add(this.label1);
            this.gb_image.Controls.Add(this.label16);
            this.gb_image.Controls.Add(this.Cmb_UnitType);
            this.gb_image.Controls.Add(this.lbl_cost);
            this.gb_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_image.Location = new System.Drawing.Point(7, 4);
            this.gb_image.Name = "gb_image";
            this.gb_image.Size = new System.Drawing.Size(759, 381);
            this.gb_image.TabIndex = 1;
            this.gb_image.TabStop = false;
            this.gb_image.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chk_changeprice
            // 
            this.chk_changeprice.AutoSize = true;
            this.chk_changeprice.Location = new System.Drawing.Point(132, 274);
            this.chk_changeprice.Name = "chk_changeprice";
            this.chk_changeprice.Size = new System.Drawing.Size(131, 21);
            this.chk_changeprice.TabIndex = 94;
            this.chk_changeprice.Text = "Price Changable";
            this.chk_changeprice.UseVisualStyleBackColor = true;
            // 
            // lbl_delivery
            // 
            this.lbl_delivery.AutoSize = true;
            this.lbl_delivery.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_delivery.ForeColor = System.Drawing.Color.Black;
            this.lbl_delivery.Location = new System.Drawing.Point(379, 302);
            this.lbl_delivery.Name = "lbl_delivery";
            this.lbl_delivery.Size = new System.Drawing.Size(153, 17);
            this.lbl_delivery.TabIndex = 93;
            this.lbl_delivery.Text = "Sell Price Home Delivery";
            this.lbl_delivery.Visible = false;
            // 
            // txt_homedelivery
            // 
            this.txt_homedelivery.Location = new System.Drawing.Point(545, 290);
            this.txt_homedelivery.Name = "txt_homedelivery";
            this.txt_homedelivery.Size = new System.Drawing.Size(173, 23);
            this.txt_homedelivery.TabIndex = 10;
            this.txt_homedelivery.Text = "0.00";
            this.txt_homedelivery.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_homedelivery.Visible = false;
            this.txt_homedelivery.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_homedelivery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_homedelivery_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 91;
            this.label2.Text = "Department Name";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(367, 168);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 25);
            this.button2.TabIndex = 90;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmb_department
            // 
            this.cmb_department.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_department.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_department.Enabled = false;
            this.cmb_department.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_department.FormattingEnabled = true;
            this.cmb_department.Location = new System.Drawing.Point(132, 166);
            this.cmb_department.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_department.Name = "cmb_department";
            this.cmb_department.Size = new System.Drawing.Size(227, 27);
            this.cmb_department.TabIndex = 89;
            this.cmb_department.SelectedIndexChanged += new System.EventHandler(this.cmb_department_SelectedIndexChanged);
            this.cmb_department.Click += new System.EventHandler(this.cmb_department_Click);
            this.cmb_department.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_department_KeyDown);
            this.cmb_department.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_department_MouseClick);
            // 
            // bttn_reset
            // 
            this.bttn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.bttn_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_reset.Image = ((System.Drawing.Image)(resources.GetObject("bttn_reset.Image")));
            this.bttn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_reset.Location = new System.Drawing.Point(485, 334);
            this.bttn_reset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttn_reset.Name = "bttn_reset";
            this.bttn_reset.Size = new System.Drawing.Size(110, 32);
            this.bttn_reset.TabIndex = 13;
            this.bttn_reset.Text = "     Reset";
            this.bttn_reset.UseVisualStyleBackColor = false;
            this.bttn_reset.Click += new System.EventHandler(this.bttn_reset_Click);
            // 
            // txtSellPriceNonAC
            // 
            this.txtSellPriceNonAC.BackColor = System.Drawing.Color.White;
            this.txtSellPriceNonAC.Location = new System.Drawing.Point(545, 219);
            this.txtSellPriceNonAC.Name = "txtSellPriceNonAC";
            this.txtSellPriceNonAC.ReadOnly = true;
            this.txtSellPriceNonAC.Size = new System.Drawing.Size(173, 23);
            this.txtSellPriceNonAC.TabIndex = 9;
            this.txtSellPriceNonAC.Text = "0.00";
            this.txtSellPriceNonAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSellPriceNonAC.TextChanged += new System.EventHandler(this.txtSellPriceNonAC_TextChanged);
            this.txtSellPriceNonAC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSellPriceNonAC_KeyDown);
            // 
            // lblSellNonAc
            // 
            this.lblSellNonAc.AutoSize = true;
            this.lblSellNonAc.Location = new System.Drawing.Point(420, 223);
            this.lblSellNonAc.Name = "lblSellNonAc";
            this.lblSellNonAc.Size = new System.Drawing.Size(119, 17);
            this.lblSellNonAc.TabIndex = 86;
            this.lblSellNonAc.Text = "Sell Price Non AC";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rd_countersale);
            this.groupBox3.Controls.Add(this.rd_Ingradiant);
            this.groupBox3.Controls.Add(this.rd_Prodect);
            this.groupBox3.Location = new System.Drawing.Point(9, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 47);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // rd_countersale
            // 
            this.rd_countersale.AutoSize = true;
            this.rd_countersale.ForeColor = System.Drawing.Color.Black;
            this.rd_countersale.Location = new System.Drawing.Point(177, 16);
            this.rd_countersale.Name = "rd_countersale";
            this.rd_countersale.Size = new System.Drawing.Size(108, 21);
            this.rd_countersale.TabIndex = 2;
            this.rd_countersale.Text = "Counter Sale";
            this.rd_countersale.UseVisualStyleBackColor = true;
            this.rd_countersale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rd_Ingradiant
            // 
            this.rd_Ingradiant.AutoSize = true;
            this.rd_Ingradiant.ForeColor = System.Drawing.Color.Black;
            this.rd_Ingradiant.Location = new System.Drawing.Point(87, 16);
            this.rd_Ingradiant.Name = "rd_Ingradiant";
            this.rd_Ingradiant.Size = new System.Drawing.Size(89, 21);
            this.rd_Ingradiant.TabIndex = 1;
            this.rd_Ingradiant.Text = "Ingredient";
            this.rd_Ingradiant.UseVisualStyleBackColor = true;
            this.rd_Ingradiant.CheckedChanged += new System.EventHandler(this.rd_Ingradiant_CheckedChanged);
            this.rd_Ingradiant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rd_Ingradiant_KeyDown);
            // 
            // rd_Prodect
            // 
            this.rd_Prodect.AutoSize = true;
            this.rd_Prodect.Checked = true;
            this.rd_Prodect.ForeColor = System.Drawing.Color.Black;
            this.rd_Prodect.Location = new System.Drawing.Point(8, 16);
            this.rd_Prodect.Name = "rd_Prodect";
            this.rd_Prodect.Size = new System.Drawing.Size(75, 21);
            this.rd_Prodect.TabIndex = 0;
            this.rd_Prodect.TabStop = true;
            this.rd_Prodect.Text = "Product";
            this.rd_Prodect.UseVisualStyleBackColor = true;
            this.rd_Prodect.CheckedChanged += new System.EventHandler(this.rd_Prodect_CheckedChanged);
            this.rd_Prodect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rd_Prodect_KeyDown);
            // 
            // btn_NewUnit
            // 
            this.btn_NewUnit.BackColor = System.Drawing.Color.Transparent;
            this.btn_NewUnit.FlatAppearance.BorderSize = 0;
            this.btn_NewUnit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_NewUnit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_NewUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewUnit.Image = ((System.Drawing.Image)(resources.GetObject("btn_NewUnit.Image")));
            this.btn_NewUnit.Location = new System.Drawing.Point(724, 124);
            this.btn_NewUnit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_NewUnit.Name = "btn_NewUnit";
            this.btn_NewUnit.Size = new System.Drawing.Size(25, 25);
            this.btn_NewUnit.TabIndex = 8;
            this.btn_NewUnit.UseVisualStyleBackColor = false;
            this.btn_NewUnit.Click += new System.EventHandler(this.btn_NewUnit_Click);
            // 
            // bttn_newcategory
            // 
            this.bttn_newcategory.BackColor = System.Drawing.Color.Transparent;
            this.bttn_newcategory.FlatAppearance.BorderSize = 0;
            this.bttn_newcategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bttn_newcategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttn_newcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_newcategory.Image = ((System.Drawing.Image)(resources.GetObject("bttn_newcategory.Image")));
            this.bttn_newcategory.Location = new System.Drawing.Point(367, 123);
            this.bttn_newcategory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bttn_newcategory.Name = "bttn_newcategory";
            this.bttn_newcategory.Size = new System.Drawing.Size(23, 25);
            this.bttn_newcategory.TabIndex = 4;
            this.bttn_newcategory.UseVisualStyleBackColor = false;
            this.bttn_newcategory.Click += new System.EventHandler(this.bttn_newcategory_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(367, 334);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 32);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseEnter += new System.EventHandler(this.btn_save_MouseEnter);
            this.btn_cancel.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.Btn_Delete.Image = global::BisCarePosEdition.Properties.Resources.delete6;
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Delete.Location = new System.Drawing.Point(246, 334);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(110, 32);
            this.Btn_Delete.TabIndex = 11;
            this.Btn_Delete.Text = "   Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            this.Btn_Delete.MouseEnter += new System.EventHandler(this.btn_save_MouseEnter);
            this.Btn_Delete.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(130, 334);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(110, 32);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.MouseEnter += new System.EventHandler(this.btn_save_MouseEnter);
            this.btn_save.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            // 
            // txt_sellprice
            // 
            this.txt_sellprice.BackColor = System.Drawing.Color.White;
            this.txt_sellprice.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sellprice.Location = new System.Drawing.Point(545, 261);
            this.txt_sellprice.MaxLength = 8;
            this.txt_sellprice.Name = "txt_sellprice";
            this.txt_sellprice.ReadOnly = true;
            this.txt_sellprice.Size = new System.Drawing.Size(173, 24);
            this.txt_sellprice.TabIndex = 8;
            this.txt_sellprice.Text = "0.00";
            this.txt_sellprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_sellprice.TextChanged += new System.EventHandler(this.txt_sellprice_TextChanged);
            this.txt_sellprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_sellprice_KeyDown);
            this.txt_sellprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sellprice_KeyPress);
            // 
            // lbl_Sell
            // 
            this.lbl_Sell.AutoSize = true;
            this.lbl_Sell.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sell.ForeColor = System.Drawing.Color.Black;
            this.lbl_Sell.Location = new System.Drawing.Point(467, 267);
            this.lbl_Sell.Name = "lbl_Sell";
            this.lbl_Sell.Size = new System.Drawing.Size(60, 17);
            this.lbl_Sell.TabIndex = 84;
            this.lbl_Sell.Text = "Sell Price";
            // 
            // txt_codeprice
            // 
            this.txt_codeprice.Enabled = false;
            this.txt_codeprice.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codeprice.Location = new System.Drawing.Point(545, 261);
            this.txt_codeprice.MaxLength = 8;
            this.txt_codeprice.Name = "txt_codeprice";
            this.txt_codeprice.Size = new System.Drawing.Size(173, 24);
            this.txt_codeprice.TabIndex = 8;
            this.txt_codeprice.Text = "0.00";
            this.txt_codeprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_codeprice.Visible = false;
            this.txt_codeprice.TextChanged += new System.EventHandler(this.txt_codeprice_TextChanged);
            this.txt_codeprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_codeprice_KeyDown);
            this.txt_codeprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codeprice_KeyPress);
            // 
            // txt_arabic
            // 
            this.txt_arabic.Enabled = false;
            this.txt_arabic.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_arabic.Location = new System.Drawing.Point(130, 300);
            this.txt_arabic.MaxLength = 50;
            this.txt_arabic.Name = "txt_arabic";
            this.txt_arabic.Size = new System.Drawing.Size(229, 24);
            this.txt_arabic.TabIndex = 6;
            this.txt_arabic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_arabic.Visible = false;
            this.txt_arabic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_itemname_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 60;
            this.label4.Text = "Item Arabic";
            this.label4.Visible = false;
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Enabled = false;
            this.lbl_cost.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cost.ForeColor = System.Drawing.Color.Black;
            this.lbl_cost.Location = new System.Drawing.Point(463, 268);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(69, 17);
            this.lbl_cost.TabIndex = 80;
            this.lbl_cost.Text = "Cost Price";
            this.lbl_cost.Visible = false;
            this.lbl_cost.Click += new System.EventHandler(this.lbl_cost_Click);
            // 
            // pb_photo
            // 
            this.pb_photo.Location = new System.Drawing.Point(775, 53);
            this.pb_photo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_photo.Name = "pb_photo";
            this.pb_photo.Size = new System.Drawing.Size(259, 225);
            this.pb_photo.TabIndex = 96;
            this.pb_photo.TabStop = false;
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btn_browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.Image = global::BisCarePosEdition.Properties.Resources.Browse2;
            this.btn_browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_browse.Location = new System.Drawing.Point(919, 284);
            this.btn_browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(115, 32);
            this.btn_browse.TabIndex = 95;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            this.btn_browse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_browse_KeyDown);
            // 
            // lbl_image
            // 
            this.lbl_image.AutoSize = true;
            this.lbl_image.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_image.ForeColor = System.Drawing.Color.Black;
            this.lbl_image.Location = new System.Drawing.Point(772, 32);
            this.lbl_image.Name = "lbl_image";
            this.lbl_image.Size = new System.Drawing.Size(78, 17);
            this.lbl_image.TabIndex = 94;
            this.lbl_image.Text = "Item Image";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(254, 309);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_taxid
            // 
            this.cmb_taxid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_taxid.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_taxid.FormattingEnabled = true;
            this.cmb_taxid.Location = new System.Drawing.Point(103, 307);
            this.cmb_taxid.Name = "cmb_taxid";
            this.cmb_taxid.Size = new System.Drawing.Size(144, 24);
            this.cmb_taxid.TabIndex = 9;
            this.cmb_taxid.Visible = false;
            this.cmb_taxid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_taxid_KeyDown);
            this.cmb_taxid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_taxid_MouseClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(69, 317);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 17);
            this.label12.TabIndex = 85;
            this.label12.Text = "Tax";
            this.label12.Visible = false;
            // 
            // rb_multiple
            // 
            this.rb_multiple.AutoSize = true;
            this.rb_multiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_multiple.Location = new System.Drawing.Point(552, 317);
            this.rb_multiple.Name = "rb_multiple";
            this.rb_multiple.Size = new System.Drawing.Size(74, 21);
            this.rb_multiple.TabIndex = 11;
            this.rb_multiple.TabStop = true;
            this.rb_multiple.Text = "multiple";
            this.rb_multiple.UseVisualStyleBackColor = true;
            this.rb_multiple.Visible = false;
            // 
            // rb_single
            // 
            this.rb_single.AutoSize = true;
            this.rb_single.Checked = true;
            this.rb_single.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_single.Location = new System.Drawing.Point(460, 317);
            this.rb_single.Name = "rb_single";
            this.rb_single.Size = new System.Drawing.Size(65, 21);
            this.rb_single.TabIndex = 10;
            this.rb_single.TabStop = true;
            this.rb_single.Text = "Single";
            this.rb_single.UseVisualStyleBackColor = true;
            this.rb_single.Visible = false;
            this.rb_single.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_single_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Item Type";
            this.label3.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Txt_OrgsellPrice
            // 
            this.Txt_OrgsellPrice.Location = new System.Drawing.Point(545, 170);
            this.Txt_OrgsellPrice.Name = "Txt_OrgsellPrice";
            this.Txt_OrgsellPrice.Size = new System.Drawing.Size(173, 23);
            this.Txt_OrgsellPrice.TabIndex = 95;
            this.Txt_OrgsellPrice.Text = "0.00";
            this.Txt_OrgsellPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_OrgsellPrice.TextChanged += new System.EventHandler(this.Txt_OrgsellPrice_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 96;
            this.label5.Text = "Org Sell Price";
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 397);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.pb_photo);
            this.Controls.Add(this.gb_image);
            this.Controls.Add(this.rb_single);
            this.Controls.Add(this.lbl_image);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_multiple);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_taxid);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item";
            this.Load += new System.EventHandler(this.Item_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gb_image.ResumeLayout(false);
            this.gb_image.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cmb_UnitType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmb_catname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_itemcode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_itemname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Rb_edit;
        private System.Windows.Forms.RadioButton Rb_new;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.ComboBox Cmb_itemname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gb_image;
        private System.Windows.Forms.RadioButton rb_multiple;
        private System.Windows.Forms.RadioButton rb_single;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_taxid;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.TextBox txt_sellprice;
        private System.Windows.Forms.Label lbl_Sell;
        private System.Windows.Forms.TextBox txt_codeprice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_NewUnit;
        private System.Windows.Forms.Button bttn_newcategory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rd_Ingradiant;
        private System.Windows.Forms.RadioButton rd_Prodect;
        private System.Windows.Forms.TextBox txtSellPriceNonAC;
        private System.Windows.Forms.Label lblSellNonAc;
        private System.Windows.Forms.RadioButton rd_countersale;
        private System.Windows.Forms.Button bttn_reset;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmb_department;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_delivery;
        private System.Windows.Forms.TextBox txt_homedelivery;
        private System.Windows.Forms.Label lbl_image;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.PictureBox pb_photo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_arabic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_changeprice;
        private System.Windows.Forms.TextBox Txt_OrgsellPrice;
        private System.Windows.Forms.Label label5;
    }
}