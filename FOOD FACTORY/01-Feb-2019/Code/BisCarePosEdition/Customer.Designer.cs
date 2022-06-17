namespace BisCarePosEdition
{
    partial class Customer
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
            this.button4 = new System.Windows.Forms.Button();
            this.Rb_edit = new System.Windows.Forms.RadioButton();
            this.txtCreditAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Rb_new = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tinno = new System.Windows.Forms.TextBox();
            this.txt_custCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_CreditPeriod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_custname = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.txt_phno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rd_English = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rd_Arabic = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_openingbal = new System.Windows.Forms.TextBox();
            this.txt_cstno = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = global::BisCarePosEdition.Properties.Resources.reset1;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(293, 283);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 32);
            this.button4.TabIndex = 49;
            this.button4.Text = " Reset";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Rb_edit
            // 
            this.Rb_edit.AutoSize = true;
            this.Rb_edit.Location = new System.Drawing.Point(116, 17);
            this.Rb_edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rb_edit.Name = "Rb_edit";
            this.Rb_edit.Size = new System.Drawing.Size(49, 21);
            this.Rb_edit.TabIndex = 1;
            this.Rb_edit.Text = "Edit";
            this.Rb_edit.UseVisualStyleBackColor = true;
            this.Rb_edit.CheckedChanged += new System.EventHandler(this.Rb_edit_CheckedChanged);
            // 
            // txtCreditAmount
            // 
            this.txtCreditAmount.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditAmount.Location = new System.Drawing.Point(373, 230);
            this.txtCreditAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCreditAmount.MaxLength = 6;
            this.txtCreditAmount.Name = "txtCreditAmount";
            this.txtCreditAmount.Size = new System.Drawing.Size(201, 24);
            this.txtCreditAmount.TabIndex = 8;
            this.txtCreditAmount.Text = "0";
            this.txtCreditAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCreditAmount.Visible = false;
            this.txtCreditAmount.TextChanged += new System.EventHandler(this.txtCreditAmount_TextChanged);
            this.txtCreditAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditAmount_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(292, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 47;
            this.label11.Text = "Credit Limit";
            this.label11.Visible = false;
            // 
            // Rb_new
            // 
            this.Rb_new.AutoSize = true;
            this.Rb_new.Checked = true;
            this.Rb_new.Location = new System.Drawing.Point(34, 17);
            this.Rb_new.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rb_new.Name = "Rb_new";
            this.Rb_new.Size = new System.Drawing.Size(52, 21);
            this.Rb_new.TabIndex = 2;
            this.Rb_new.TabStop = true;
            this.Rb_new.Text = "New";
            this.Rb_new.UseVisualStyleBackColor = true;
            this.Rb_new.CheckedChanged += new System.EventHandler(this.Rb_new_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "Code";
            // 
            // txt_tinno
            // 
            this.txt_tinno.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tinno.Location = new System.Drawing.Point(65, 230);
            this.txt_tinno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tinno.MaxLength = 20;
            this.txt_tinno.Name = "txt_tinno";
            this.txt_tinno.Size = new System.Drawing.Size(201, 24);
            this.txt_tinno.TabIndex = 4;
            // 
            // txt_custCode
            // 
            this.txt_custCode.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_custCode.Location = new System.Drawing.Point(65, 162);
            this.txt_custCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_custCode.Name = "txt_custCode";
            this.txt_custCode.Size = new System.Drawing.Size(201, 24);
            this.txt_custCode.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "TIN No";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(521, 199);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 17);
            this.label17.TabIndex = 45;
            this.label17.Text = "Months";
            this.label17.Visible = false;
            // 
            // txt_CreditPeriod
            // 
            this.txt_CreditPeriod.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CreditPeriod.Location = new System.Drawing.Point(373, 196);
            this.txt_CreditPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CreditPeriod.MaxLength = 2;
            this.txt_CreditPeriod.Name = "txt_CreditPeriod";
            this.txt_CreditPeriod.Size = new System.Drawing.Size(142, 24);
            this.txt_CreditPeriod.TabIndex = 7;
            this.txt_CreditPeriod.Text = "0";
            this.txt_CreditPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_CreditPeriod.Visible = false;
            this.txt_CreditPeriod.TextChanged += new System.EventHandler(this.txt_CreditPeriod_TextChanged);
            this.txt_CreditPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CreditPeriod_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(283, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Credit Period";
            this.label8.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::BisCarePosEdition.Properties.Resources.delete6;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(177, 283);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "  Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_custname
            // 
            this.cmb_custname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_custname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_custname.CausesValidation = false;
            this.cmb_custname.DropDownWidth = 300;
            this.cmb_custname.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_custname.FormattingEnabled = true;
            this.cmb_custname.Location = new System.Drawing.Point(65, 95);
            this.cmb_custname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_custname.Name = "cmb_custname";
            this.cmb_custname.Size = new System.Drawing.Size(201, 24);
            this.cmb_custname.TabIndex = 0;
            this.cmb_custname.SelectedIndexChanged += new System.EventHandler(this.cmb_custname_SelectedIndexChanged);
            this.cmb_custname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_custname_KeyDown);
            this.cmb_custname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_custname_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.txtCreditAmount);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_tinno);
            this.groupBox1.Controls.Add(this.txt_custCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txt_CreditPeriod);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmb_custname);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_customername);
            this.groupBox1.Controls.Add(this.txt_phno);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(581, 330);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rb_edit);
            this.groupBox2.Controls.Add(this.Rb_new);
            this.groupBox2.Location = new System.Drawing.Point(190, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(200, 47);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(409, 283);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 32);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "   Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(61, 283);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(110, 32);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = " Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(373, 94);
            this.txt_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(201, 58);
            this.txt_address.TabIndex = 5;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(373, 162);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(201, 24);
            this.txt_email.TabIndex = 6;
            // 
            // txt_customername
            // 
            this.txt_customername.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customername.Location = new System.Drawing.Point(65, 128);
            this.txt_customername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(201, 24);
            this.txt_customername.TabIndex = 1;
            // 
            // txt_phno
            // 
            this.txt_phno.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phno.Location = new System.Drawing.Point(65, 196);
            this.txt_phno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_phno.MaxLength = 12;
            this.txt_phno.Name = "txt_phno";
            this.txt_phno.Size = new System.Drawing.Size(201, 24);
            this.txt_phno.TabIndex = 3;
            this.txt_phno.TextChanged += new System.EventHandler(this.txt_phno_TextChanged);
            this.txt_phno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_phno_KeyDown);
            this.txt_phno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phno_KeyPress);
            this.txt_phno.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt_phno_MouseDoubleClick);
            this.txt_phno.Validating += new System.ComponentModel.CancelEventHandler(this.txt_phno_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(383, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "CST No";
            this.label6.Visible = false;
            // 
            // rd_English
            // 
            this.rd_English.AutoSize = true;
            this.rd_English.Checked = true;
            this.rd_English.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_English.Location = new System.Drawing.Point(25, 27);
            this.rd_English.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_English.Name = "rd_English";
            this.rd_English.Size = new System.Drawing.Size(68, 21);
            this.rd_English.TabIndex = 0;
            this.rd_English.TabStop = true;
            this.rd_English.Text = "English";
            this.rd_English.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Opening Balance";
            this.label7.Visible = false;
            // 
            // rd_Arabic
            // 
            this.rd_Arabic.AutoSize = true;
            this.rd_Arabic.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Arabic.Location = new System.Drawing.Point(162, 27);
            this.rd_Arabic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_Arabic.Name = "rd_Arabic";
            this.rd_Arabic.Size = new System.Drawing.Size(63, 21);
            this.rd_Arabic.TabIndex = 1;
            this.rd_Arabic.TabStop = true;
            this.rd_Arabic.Text = "Arabic";
            this.rd_Arabic.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rd_Arabic);
            this.groupBox3.Controls.Add(this.rd_English);
            this.groupBox3.Controls.Add(this.txt_openingbal);
            this.groupBox3.Controls.Add(this.txt_cstno);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(156, 408);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(269, 64);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Input Language";
            this.groupBox3.Visible = false;
            // 
            // txt_openingbal
            // 
            this.txt_openingbal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_openingbal.Location = new System.Drawing.Point(174, 14);
            this.txt_openingbal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_openingbal.MaxLength = 8;
            this.txt_openingbal.Name = "txt_openingbal";
            this.txt_openingbal.Size = new System.Drawing.Size(103, 24);
            this.txt_openingbal.TabIndex = 11;
            this.txt_openingbal.Text = "0";
            this.txt_openingbal.Visible = false;
            // 
            // txt_cstno
            // 
            this.txt_cstno.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cstno.Location = new System.Drawing.Point(201, 0);
            this.txt_cstno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_cstno.MaxLength = 20;
            this.txt_cstno.Name = "txt_cstno";
            this.txt_cstno.Size = new System.Drawing.Size(201, 24);
            this.txt_cstno.TabIndex = 7;
            this.txt_cstno.Visible = false;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 344);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton Rb_edit;
        private System.Windows.Forms.TextBox txtCreditAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton Rb_new;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_tinno;
        private System.Windows.Forms.TextBox txt_custCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_CreditPeriod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_custname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.TextBox txt_phno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rd_English;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rd_Arabic;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_openingbal;
        private System.Windows.Forms.TextBox txt_cstno;
    }
}