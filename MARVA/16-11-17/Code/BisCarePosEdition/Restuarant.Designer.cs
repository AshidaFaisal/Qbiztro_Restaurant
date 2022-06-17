namespace BisCarePosEdition
{
    partial class Restuarant
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
            this.bttn_save = new System.Windows.Forms.Button();
            this.bttn_cancel = new System.Windows.Forms.Button();
            this.OFDLogo = new System.Windows.Forms.OpenFileDialog();
            this.OFDInvoiceHeader = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_companyname = new System.Windows.Forms.TextBox();
            this.txt_legalname = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_telephone = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_website = new System.Windows.Forms.TextBox();
            this.txt_currency = new System.Windows.Forms.TextBox();
            this.txt_subcurrency = new System.Windows.Forms.TextBox();
            this.Pb_logo = new System.Windows.Forms.PictureBox();
            this.pbInvoice = new System.Windows.Forms.PictureBox();
            this.bttn_logobrse = new System.Windows.Forms.Button();
            this.bttn_logoclr = new System.Windows.Forms.Button();
            this.bttn_invcbrse = new System.Windows.Forms.Button();
            this.bttn_invcclr = new System.Windows.Forms.Button();
            this.lbl_openingbal = new System.Windows.Forms.Label();
            this.txt_openingbal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkdepartwise = new System.Windows.Forms.CheckBox();
            this.grp_emp = new System.Windows.Forms.GroupBox();
            this.rd_autoEmp = new System.Windows.Forms.RadioButton();
            this.rd_ManualEmp = new System.Windows.Forms.RadioButton();
            this.txt_empprefix = new System.Windows.Forms.TextBox();
            this.txt_empstarting = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.grp_Inv = new System.Windows.Forms.GroupBox();
            this.rd_autoInv = new System.Windows.Forms.RadioButton();
            this.rd_manualInv = new System.Windows.Forms.RadioButton();
            this.txt_inPr = new System.Windows.Forms.TextBox();
            this.lbl_prIN = new System.Windows.Forms.Label();
            this.lbl_stCust = new System.Windows.Forms.Label();
            this.txt_Inst = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grp_dealer = new System.Windows.Forms.GroupBox();
            this.rd_AutoDealer = new System.Windows.Forms.RadioButton();
            this.rd_ManualDealer = new System.Windows.Forms.RadioButton();
            this.txt_DealerPrefix = new System.Windows.Forms.TextBox();
            this.txt_dealerStarting = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.grp_cust = new System.Windows.Forms.GroupBox();
            this.rd_AutoCust = new System.Windows.Forms.RadioButton();
            this.rd_ManualCust = new System.Windows.Forms.RadioButton();
            this.txt_custPrefix = new System.Windows.Forms.TextBox();
            this.txt_CustStarting = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInvoice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grp_emp.SuspendLayout();
            this.grp_Inv.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grp_dealer.SuspendLayout();
            this.grp_cust.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttn_save
            // 
            this.bttn_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_save.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.bttn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_save.Location = new System.Drawing.Point(445, 552);
            this.bttn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(110, 32);
            this.bttn_save.TabIndex = 1;
            this.bttn_save.Text = "   Save";
            this.bttn_save.UseVisualStyleBackColor = false;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            this.bttn_save.MouseEnter += new System.EventHandler(this.bttn_logobrse_MouseEnter);
            this.bttn_save.MouseLeave += new System.EventHandler(this.bttn_logobrse_MouseLeave);
            // 
            // bttn_cancel
            // 
            this.bttn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_cancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.bttn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_cancel.Location = new System.Drawing.Point(561, 552);
            this.bttn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttn_cancel.Name = "bttn_cancel";
            this.bttn_cancel.Size = new System.Drawing.Size(110, 32);
            this.bttn_cancel.TabIndex = 2;
            this.bttn_cancel.Text = "    Close";
            this.bttn_cancel.UseVisualStyleBackColor = false;
            this.bttn_cancel.Click += new System.EventHandler(this.bttn_cancel_Click);
            this.bttn_cancel.MouseEnter += new System.EventHandler(this.bttn_logobrse_MouseEnter);
            this.bttn_cancel.MouseLeave += new System.EventHandler(this.bttn_logobrse_MouseLeave);
            // 
            // OFDLogo
            // 
            this.OFDLogo.FileName = "NoFile";
            // 
            // OFDInvoiceHeader
            // 
            this.OFDInvoiceHeader.FileName = "NoFile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Legal Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telephone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(414, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Website";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Logo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(351, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Invoice Header";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(388, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Currency";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(362, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Sub currency";
            // 
            // txt_companyname
            // 
            this.txt_companyname.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_companyname.Location = new System.Drawing.Point(123, 34);
            this.txt_companyname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_companyname.MaxLength = 100;
            this.txt_companyname.Name = "txt_companyname";
            this.txt_companyname.Size = new System.Drawing.Size(206, 24);
            this.txt_companyname.TabIndex = 0;
            this.txt_companyname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_companyname_KeyDown);
            // 
            // txt_legalname
            // 
            this.txt_legalname.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_legalname.Location = new System.Drawing.Point(123, 72);
            this.txt_legalname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_legalname.MaxLength = 100;
            this.txt_legalname.Name = "txt_legalname";
            this.txt_legalname.Size = new System.Drawing.Size(206, 24);
            this.txt_legalname.TabIndex = 1;
            this.txt_legalname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_legalname_KeyDown);
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(123, 112);
            this.txt_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(206, 77);
            this.txt_address.TabIndex = 2;
            this.txt_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_address_KeyDown);
            // 
            // txt_telephone
            // 
            this.txt_telephone.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telephone.Location = new System.Drawing.Point(123, 217);
            this.txt_telephone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_telephone.MaxLength = 100;
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(206, 24);
            this.txt_telephone.TabIndex = 3;
            this.txt_telephone.TextChanged += new System.EventHandler(this.txt_telephone_TextChanged);
            this.txt_telephone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_telephone_KeyDown);
            this.txt_telephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telephone_KeyPress);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(461, 79);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email.MaxLength = 50;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(206, 24);
            this.txt_email.TabIndex = 5;
            this.txt_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_email_KeyDown);
            // 
            // txt_website
            // 
            this.txt_website.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_website.Location = new System.Drawing.Point(461, 34);
            this.txt_website.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_website.Name = "txt_website";
            this.txt_website.Size = new System.Drawing.Size(206, 24);
            this.txt_website.TabIndex = 4;
            this.txt_website.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_website_KeyDown);
            // 
            // txt_currency
            // 
            this.txt_currency.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currency.Location = new System.Drawing.Point(461, 124);
            this.txt_currency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_currency.MaxLength = 50;
            this.txt_currency.Name = "txt_currency";
            this.txt_currency.Size = new System.Drawing.Size(206, 24);
            this.txt_currency.TabIndex = 6;
            this.txt_currency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_currency_KeyDown);
            // 
            // txt_subcurrency
            // 
            this.txt_subcurrency.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subcurrency.Location = new System.Drawing.Point(461, 169);
            this.txt_subcurrency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_subcurrency.MaxLength = 50;
            this.txt_subcurrency.Name = "txt_subcurrency";
            this.txt_subcurrency.Size = new System.Drawing.Size(206, 24);
            this.txt_subcurrency.TabIndex = 7;
            this.txt_subcurrency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_subcurrency_KeyDown);
            // 
            // Pb_logo
            // 
            this.Pb_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pb_logo.Location = new System.Drawing.Point(123, 316);
            this.Pb_logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pb_logo.Name = "Pb_logo";
            this.Pb_logo.Size = new System.Drawing.Size(206, 113);
            this.Pb_logo.TabIndex = 28;
            this.Pb_logo.TabStop = false;
            // 
            // pbInvoice
            // 
            this.pbInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbInvoice.Location = new System.Drawing.Point(461, 316);
            this.pbInvoice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbInvoice.Name = "pbInvoice";
            this.pbInvoice.Size = new System.Drawing.Size(206, 113);
            this.pbInvoice.TabIndex = 29;
            this.pbInvoice.TabStop = false;
            // 
            // bttn_logobrse
            // 
            this.bttn_logobrse.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttn_logobrse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_logobrse.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_logobrse.Image = global::BisCarePosEdition.Properties.Resources.Browse2;
            this.bttn_logobrse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_logobrse.Location = new System.Drawing.Point(123, 437);
            this.bttn_logobrse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttn_logobrse.Name = "bttn_logobrse";
            this.bttn_logobrse.Size = new System.Drawing.Size(100, 32);
            this.bttn_logobrse.TabIndex = 10;
            this.bttn_logobrse.Text = "     Browse";
            this.bttn_logobrse.UseVisualStyleBackColor = false;
            this.bttn_logobrse.Click += new System.EventHandler(this.bttn_logobrse_Click);
            this.bttn_logobrse.MouseEnter += new System.EventHandler(this.bttn_logobrse_MouseEnter);
            this.bttn_logobrse.MouseLeave += new System.EventHandler(this.bttn_logobrse_MouseLeave);
            // 
            // bttn_logoclr
            // 
            this.bttn_logoclr.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttn_logoclr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_logoclr.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_logoclr.Image = global::BisCarePosEdition.Properties.Resources.Clearbtn;
            this.bttn_logoclr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_logoclr.Location = new System.Drawing.Point(229, 437);
            this.bttn_logoclr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttn_logoclr.Name = "bttn_logoclr";
            this.bttn_logoclr.Size = new System.Drawing.Size(100, 32);
            this.bttn_logoclr.TabIndex = 11;
            this.bttn_logoclr.Text = "  Clear";
            this.bttn_logoclr.UseVisualStyleBackColor = false;
            this.bttn_logoclr.Click += new System.EventHandler(this.bttn_logoclr_Click);
            this.bttn_logoclr.MouseEnter += new System.EventHandler(this.bttn_logobrse_MouseEnter);
            this.bttn_logoclr.MouseLeave += new System.EventHandler(this.bttn_logobrse_MouseLeave);
            // 
            // bttn_invcbrse
            // 
            this.bttn_invcbrse.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttn_invcbrse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_invcbrse.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_invcbrse.Image = global::BisCarePosEdition.Properties.Resources.Browse2;
            this.bttn_invcbrse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_invcbrse.Location = new System.Drawing.Point(461, 437);
            this.bttn_invcbrse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttn_invcbrse.Name = "bttn_invcbrse";
            this.bttn_invcbrse.Size = new System.Drawing.Size(100, 32);
            this.bttn_invcbrse.TabIndex = 12;
            this.bttn_invcbrse.Text = "      Browse";
            this.bttn_invcbrse.UseVisualStyleBackColor = false;
            this.bttn_invcbrse.Click += new System.EventHandler(this.bttn_invcbrse_Click);
            this.bttn_invcbrse.MouseEnter += new System.EventHandler(this.bttn_logobrse_MouseEnter);
            this.bttn_invcbrse.MouseLeave += new System.EventHandler(this.bttn_logobrse_MouseLeave);
            // 
            // bttn_invcclr
            // 
            this.bttn_invcclr.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttn_invcclr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_invcclr.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_invcclr.Image = global::BisCarePosEdition.Properties.Resources.Clearbtn;
            this.bttn_invcclr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_invcclr.Location = new System.Drawing.Point(567, 437);
            this.bttn_invcclr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttn_invcclr.Name = "bttn_invcclr";
            this.bttn_invcclr.Size = new System.Drawing.Size(100, 32);
            this.bttn_invcclr.TabIndex = 13;
            this.bttn_invcclr.Text = "  Clear";
            this.bttn_invcclr.UseVisualStyleBackColor = false;
            this.bttn_invcclr.Click += new System.EventHandler(this.bttn_invcclr_Click);
            this.bttn_invcclr.MouseEnter += new System.EventHandler(this.bttn_logobrse_MouseEnter);
            this.bttn_invcclr.MouseLeave += new System.EventHandler(this.bttn_logobrse_MouseLeave);
            // 
            // lbl_openingbal
            // 
            this.lbl_openingbal.AutoSize = true;
            this.lbl_openingbal.Location = new System.Drawing.Point(344, 217);
            this.lbl_openingbal.Name = "lbl_openingbal";
            this.lbl_openingbal.Size = new System.Drawing.Size(109, 17);
            this.lbl_openingbal.TabIndex = 34;
            this.lbl_openingbal.Text = "Opening Balance";
            // 
            // txt_openingbal
            // 
            this.txt_openingbal.Location = new System.Drawing.Point(461, 214);
            this.txt_openingbal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_openingbal.MaxLength = 8;
            this.txt_openingbal.Name = "txt_openingbal";
            this.txt_openingbal.Size = new System.Drawing.Size(206, 24);
            this.txt_openingbal.TabIndex = 8;
            this.txt_openingbal.Text = "0";
            this.txt_openingbal.TextChanged += new System.EventHandler(this.txt_openingbal_TextChanged);
            this.txt_openingbal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_openingbal_KeyDown);
            this.txt_openingbal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_openingbal_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chkdepartwise);
            this.groupBox1.Controls.Add(this.txt_openingbal);
            this.groupBox1.Controls.Add(this.lbl_openingbal);
            this.groupBox1.Controls.Add(this.bttn_invcclr);
            this.groupBox1.Controls.Add(this.bttn_invcbrse);
            this.groupBox1.Controls.Add(this.bttn_logoclr);
            this.groupBox1.Controls.Add(this.bttn_logobrse);
            this.groupBox1.Controls.Add(this.pbInvoice);
            this.groupBox1.Controls.Add(this.Pb_logo);
            this.groupBox1.Controls.Add(this.txt_subcurrency);
            this.groupBox1.Controls.Add(this.txt_currency);
            this.groupBox1.Controls.Add(this.txt_website);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_telephone);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.txt_legalname);
            this.groupBox1.Controls.Add(this.txt_companyname);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(681, 525);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkdepartwise
            // 
            this.chkdepartwise.AutoSize = true;
            this.chkdepartwise.Enabled = false;
            this.chkdepartwise.Location = new System.Drawing.Point(461, 497);
            this.chkdepartwise.Name = "chkdepartwise";
            this.chkdepartwise.Size = new System.Drawing.Size(124, 21);
            this.chkdepartwise.TabIndex = 4;
            this.chkdepartwise.Text = "departmentwise";
            this.chkdepartwise.UseVisualStyleBackColor = true;
            this.chkdepartwise.Visible = false;
            // 
            // grp_emp
            // 
            this.grp_emp.Controls.Add(this.rd_autoEmp);
            this.grp_emp.Controls.Add(this.rd_ManualEmp);
            this.grp_emp.Controls.Add(this.txt_empprefix);
            this.grp_emp.Controls.Add(this.txt_empstarting);
            this.grp_emp.Controls.Add(this.label18);
            this.grp_emp.Controls.Add(this.label19);
            this.grp_emp.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_emp.Location = new System.Drawing.Point(19, 141);
            this.grp_emp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_emp.Name = "grp_emp";
            this.grp_emp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_emp.Size = new System.Drawing.Size(369, 105);
            this.grp_emp.TabIndex = 35;
            this.grp_emp.TabStop = false;
            this.grp_emp.Text = "Employye No";
            // 
            // rd_autoEmp
            // 
            this.rd_autoEmp.AutoSize = true;
            this.rd_autoEmp.Location = new System.Drawing.Point(143, 22);
            this.rd_autoEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_autoEmp.Name = "rd_autoEmp";
            this.rd_autoEmp.Size = new System.Drawing.Size(88, 21);
            this.rd_autoEmp.TabIndex = 0;
            this.rd_autoEmp.Text = "Automatic";
            this.rd_autoEmp.UseVisualStyleBackColor = true;
            this.rd_autoEmp.CheckedChanged += new System.EventHandler(this.rd_autoEmp_CheckedChanged);
            // 
            // rd_ManualEmp
            // 
            this.rd_ManualEmp.AutoSize = true;
            this.rd_ManualEmp.Checked = true;
            this.rd_ManualEmp.Location = new System.Drawing.Point(57, 22);
            this.rd_ManualEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_ManualEmp.Name = "rd_ManualEmp";
            this.rd_ManualEmp.Size = new System.Drawing.Size(68, 21);
            this.rd_ManualEmp.TabIndex = 1;
            this.rd_ManualEmp.TabStop = true;
            this.rd_ManualEmp.Text = "Manual";
            this.rd_ManualEmp.UseVisualStyleBackColor = true;
            this.rd_ManualEmp.CheckedChanged += new System.EventHandler(this.rd_ManualEmp_CheckedChanged);
            // 
            // txt_empprefix
            // 
            this.txt_empprefix.Enabled = false;
            this.txt_empprefix.Location = new System.Drawing.Point(57, 60);
            this.txt_empprefix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_empprefix.Name = "txt_empprefix";
            this.txt_empprefix.Size = new System.Drawing.Size(102, 24);
            this.txt_empprefix.TabIndex = 2;
            // 
            // txt_empstarting
            // 
            this.txt_empstarting.Enabled = false;
            this.txt_empstarting.Location = new System.Drawing.Point(268, 60);
            this.txt_empstarting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_empstarting.MaxLength = 10;
            this.txt_empstarting.Name = "txt_empstarting";
            this.txt_empstarting.Size = new System.Drawing.Size(81, 24);
            this.txt_empstarting.TabIndex = 3;
            this.txt_empstarting.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Enabled = false;
            this.label18.Location = new System.Drawing.Point(9, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 17);
            this.label18.TabIndex = 11;
            this.label18.Text = "Prefix";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Enabled = false;
            this.label19.Location = new System.Drawing.Point(186, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 17);
            this.label19.TabIndex = 12;
            this.label19.Text = "starting No";
            // 
            // grp_Inv
            // 
            this.grp_Inv.Controls.Add(this.rd_autoInv);
            this.grp_Inv.Controls.Add(this.rd_manualInv);
            this.grp_Inv.Controls.Add(this.txt_inPr);
            this.grp_Inv.Controls.Add(this.lbl_prIN);
            this.grp_Inv.Controls.Add(this.lbl_stCust);
            this.grp_Inv.Controls.Add(this.txt_Inst);
            this.grp_Inv.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Inv.Location = new System.Drawing.Point(19, 10);
            this.grp_Inv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_Inv.Name = "grp_Inv";
            this.grp_Inv.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_Inv.Size = new System.Drawing.Size(369, 105);
            this.grp_Inv.TabIndex = 9;
            this.grp_Inv.TabStop = false;
            this.grp_Inv.Text = "Invoice No";
            // 
            // rd_autoInv
            // 
            this.rd_autoInv.AutoSize = true;
            this.rd_autoInv.Location = new System.Drawing.Point(143, 20);
            this.rd_autoInv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_autoInv.Name = "rd_autoInv";
            this.rd_autoInv.Size = new System.Drawing.Size(88, 21);
            this.rd_autoInv.TabIndex = 1;
            this.rd_autoInv.Text = "Automatic";
            this.rd_autoInv.UseVisualStyleBackColor = true;
            this.rd_autoInv.CheckedChanged += new System.EventHandler(this.rd_autoInv_CheckedChanged);
            // 
            // rd_manualInv
            // 
            this.rd_manualInv.AutoSize = true;
            this.rd_manualInv.Checked = true;
            this.rd_manualInv.Location = new System.Drawing.Point(57, 20);
            this.rd_manualInv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_manualInv.Name = "rd_manualInv";
            this.rd_manualInv.Size = new System.Drawing.Size(68, 21);
            this.rd_manualInv.TabIndex = 0;
            this.rd_manualInv.TabStop = true;
            this.rd_manualInv.Text = "Manual";
            this.rd_manualInv.UseVisualStyleBackColor = true;
            this.rd_manualInv.CheckedChanged += new System.EventHandler(this.rd_manualInv_CheckedChanged);
            // 
            // txt_inPr
            // 
            this.txt_inPr.Location = new System.Drawing.Point(57, 53);
            this.txt_inPr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_inPr.Name = "txt_inPr";
            this.txt_inPr.Size = new System.Drawing.Size(102, 24);
            this.txt_inPr.TabIndex = 2;
            // 
            // lbl_prIN
            // 
            this.lbl_prIN.AutoSize = true;
            this.lbl_prIN.Location = new System.Drawing.Point(9, 60);
            this.lbl_prIN.Name = "lbl_prIN";
            this.lbl_prIN.Size = new System.Drawing.Size(42, 17);
            this.lbl_prIN.TabIndex = 14;
            this.lbl_prIN.Text = "Prefix";
            // 
            // lbl_stCust
            // 
            this.lbl_stCust.AutoSize = true;
            this.lbl_stCust.Location = new System.Drawing.Point(186, 60);
            this.lbl_stCust.Name = "lbl_stCust";
            this.lbl_stCust.Size = new System.Drawing.Size(75, 17);
            this.lbl_stCust.TabIndex = 15;
            this.lbl_stCust.Text = "starting No";
            // 
            // txt_Inst
            // 
            this.txt_Inst.Location = new System.Drawing.Point(268, 53);
            this.txt_Inst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Inst.MaxLength = 10;
            this.txt_Inst.Name = "txt_Inst";
            this.txt_Inst.Size = new System.Drawing.Size(87, 24);
            this.txt_Inst.TabIndex = 3;
            this.txt_Inst.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grp_Inv);
            this.groupBox2.Controls.Add(this.grp_dealer);
            this.groupBox2.Controls.Add(this.grp_cust);
            this.groupBox2.Controls.Add(this.grp_emp);
            this.groupBox2.Location = new System.Drawing.Point(699, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 524);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // grp_dealer
            // 
            this.grp_dealer.Controls.Add(this.rd_AutoDealer);
            this.grp_dealer.Controls.Add(this.rd_ManualDealer);
            this.grp_dealer.Controls.Add(this.txt_DealerPrefix);
            this.grp_dealer.Controls.Add(this.txt_dealerStarting);
            this.grp_dealer.Controls.Add(this.label13);
            this.grp_dealer.Controls.Add(this.label14);
            this.grp_dealer.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_dealer.Location = new System.Drawing.Point(19, 403);
            this.grp_dealer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_dealer.Name = "grp_dealer";
            this.grp_dealer.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_dealer.Size = new System.Drawing.Size(369, 105);
            this.grp_dealer.TabIndex = 37;
            this.grp_dealer.TabStop = false;
            this.grp_dealer.Text = "Dealer Code";
            // 
            // rd_AutoDealer
            // 
            this.rd_AutoDealer.AutoSize = true;
            this.rd_AutoDealer.Location = new System.Drawing.Point(143, 21);
            this.rd_AutoDealer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_AutoDealer.Name = "rd_AutoDealer";
            this.rd_AutoDealer.Size = new System.Drawing.Size(88, 21);
            this.rd_AutoDealer.TabIndex = 0;
            this.rd_AutoDealer.Text = "Automatic";
            this.rd_AutoDealer.UseVisualStyleBackColor = true;
            this.rd_AutoDealer.CheckedChanged += new System.EventHandler(this.rd_AutoDealer_CheckedChanged);
            // 
            // rd_ManualDealer
            // 
            this.rd_ManualDealer.AutoSize = true;
            this.rd_ManualDealer.Checked = true;
            this.rd_ManualDealer.Location = new System.Drawing.Point(57, 21);
            this.rd_ManualDealer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_ManualDealer.Name = "rd_ManualDealer";
            this.rd_ManualDealer.Size = new System.Drawing.Size(68, 21);
            this.rd_ManualDealer.TabIndex = 1;
            this.rd_ManualDealer.TabStop = true;
            this.rd_ManualDealer.Text = "Manual";
            this.rd_ManualDealer.UseVisualStyleBackColor = true;
            this.rd_ManualDealer.CheckedChanged += new System.EventHandler(this.rd_ManualDealer_CheckedChanged);
            // 
            // txt_DealerPrefix
            // 
            this.txt_DealerPrefix.Enabled = false;
            this.txt_DealerPrefix.Location = new System.Drawing.Point(57, 57);
            this.txt_DealerPrefix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DealerPrefix.Name = "txt_DealerPrefix";
            this.txt_DealerPrefix.Size = new System.Drawing.Size(102, 24);
            this.txt_DealerPrefix.TabIndex = 2;
            // 
            // txt_dealerStarting
            // 
            this.txt_dealerStarting.Enabled = false;
            this.txt_dealerStarting.Location = new System.Drawing.Point(268, 57);
            this.txt_dealerStarting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_dealerStarting.MaxLength = 10;
            this.txt_dealerStarting.Name = "txt_dealerStarting";
            this.txt_dealerStarting.Size = new System.Drawing.Size(81, 24);
            this.txt_dealerStarting.TabIndex = 3;
            this.txt_dealerStarting.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Location = new System.Drawing.Point(9, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Prefix";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Location = new System.Drawing.Point(186, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "starting No";
            // 
            // grp_cust
            // 
            this.grp_cust.Controls.Add(this.rd_AutoCust);
            this.grp_cust.Controls.Add(this.rd_ManualCust);
            this.grp_cust.Controls.Add(this.txt_custPrefix);
            this.grp_cust.Controls.Add(this.txt_CustStarting);
            this.grp_cust.Controls.Add(this.label7);
            this.grp_cust.Controls.Add(this.label8);
            this.grp_cust.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_cust.Location = new System.Drawing.Point(19, 272);
            this.grp_cust.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_cust.Name = "grp_cust";
            this.grp_cust.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_cust.Size = new System.Drawing.Size(369, 105);
            this.grp_cust.TabIndex = 36;
            this.grp_cust.TabStop = false;
            this.grp_cust.Text = "Customer Code";
            // 
            // rd_AutoCust
            // 
            this.rd_AutoCust.AutoSize = true;
            this.rd_AutoCust.Location = new System.Drawing.Point(143, 16);
            this.rd_AutoCust.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_AutoCust.Name = "rd_AutoCust";
            this.rd_AutoCust.Size = new System.Drawing.Size(88, 21);
            this.rd_AutoCust.TabIndex = 0;
            this.rd_AutoCust.Text = "Automatic";
            this.rd_AutoCust.UseVisualStyleBackColor = true;
            this.rd_AutoCust.CheckedChanged += new System.EventHandler(this.rd_AutoCust_CheckedChanged);
            // 
            // rd_ManualCust
            // 
            this.rd_ManualCust.AutoSize = true;
            this.rd_ManualCust.Checked = true;
            this.rd_ManualCust.Location = new System.Drawing.Point(57, 16);
            this.rd_ManualCust.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_ManualCust.Name = "rd_ManualCust";
            this.rd_ManualCust.Size = new System.Drawing.Size(68, 21);
            this.rd_ManualCust.TabIndex = 1;
            this.rd_ManualCust.TabStop = true;
            this.rd_ManualCust.Text = "Manual";
            this.rd_ManualCust.UseVisualStyleBackColor = true;
            this.rd_ManualCust.CheckedChanged += new System.EventHandler(this.rd_ManualCust_CheckedChanged);
            // 
            // txt_custPrefix
            // 
            this.txt_custPrefix.Enabled = false;
            this.txt_custPrefix.Location = new System.Drawing.Point(57, 54);
            this.txt_custPrefix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_custPrefix.Name = "txt_custPrefix";
            this.txt_custPrefix.Size = new System.Drawing.Size(102, 24);
            this.txt_custPrefix.TabIndex = 2;
            // 
            // txt_CustStarting
            // 
            this.txt_CustStarting.Enabled = false;
            this.txt_CustStarting.Location = new System.Drawing.Point(268, 50);
            this.txt_CustStarting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CustStarting.MaxLength = 10;
            this.txt_CustStarting.Name = "txt_CustStarting";
            this.txt_CustStarting.Size = new System.Drawing.Size(81, 24);
            this.txt_CustStarting.TabIndex = 3;
            this.txt_CustStarting.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(9, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Prefix";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(186, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "starting No";
            // 
            // Restuarant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1116, 609);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.bttn_cancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Restuarant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant";
            this.Load += new System.EventHandler(this.Restuarant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInvoice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_emp.ResumeLayout(false);
            this.grp_emp.PerformLayout();
            this.grp_Inv.ResumeLayout(false);
            this.grp_Inv.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grp_dealer.ResumeLayout(false);
            this.grp_dealer.PerformLayout();
            this.grp_cust.ResumeLayout(false);
            this.grp_cust.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.Button bttn_cancel;
        private System.Windows.Forms.OpenFileDialog OFDLogo;
        private System.Windows.Forms.OpenFileDialog OFDInvoiceHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_companyname;
        private System.Windows.Forms.TextBox txt_legalname;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_telephone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_website;
        private System.Windows.Forms.TextBox txt_currency;
        private System.Windows.Forms.TextBox txt_subcurrency;
        private System.Windows.Forms.PictureBox Pb_logo;
        private System.Windows.Forms.PictureBox pbInvoice;
        private System.Windows.Forms.Button bttn_logobrse;
        private System.Windows.Forms.Button bttn_logoclr;
        private System.Windows.Forms.Button bttn_invcbrse;
        private System.Windows.Forms.Button bttn_invcclr;
        private System.Windows.Forms.Label lbl_openingbal;
        private System.Windows.Forms.TextBox txt_openingbal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grp_Inv;
        private System.Windows.Forms.RadioButton rd_autoInv;
        private System.Windows.Forms.RadioButton rd_manualInv;
        private System.Windows.Forms.TextBox txt_inPr;
        private System.Windows.Forms.Label lbl_prIN;
        private System.Windows.Forms.Label lbl_stCust;
        private System.Windows.Forms.TextBox txt_Inst;
        private System.Windows.Forms.GroupBox grp_emp;
        private System.Windows.Forms.RadioButton rd_autoEmp;
        private System.Windows.Forms.RadioButton rd_ManualEmp;
        private System.Windows.Forms.TextBox txt_empprefix;
        private System.Windows.Forms.TextBox txt_empstarting;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grp_dealer;
        private System.Windows.Forms.RadioButton rd_AutoDealer;
        private System.Windows.Forms.RadioButton rd_ManualDealer;
        private System.Windows.Forms.TextBox txt_DealerPrefix;
        private System.Windows.Forms.TextBox txt_dealerStarting;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox grp_cust;
        private System.Windows.Forms.RadioButton rd_AutoCust;
        private System.Windows.Forms.RadioButton rd_ManualCust;
        private System.Windows.Forms.TextBox txt_custPrefix;
        private System.Windows.Forms.TextBox txt_CustStarting;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkdepartwise;
    }
}