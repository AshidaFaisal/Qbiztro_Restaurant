namespace BisCarePosEdition
{
    partial class Payment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_invoice = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnload = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_pt = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_swiping = new System.Windows.Forms.Label();
            this.btn_NewUnit = new System.Windows.Forms.Button();
            this.dgvswipemasters = new System.Windows.Forms.DataGridView();
            this.SwipeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_change = new System.Windows.Forms.TextBox();
            this.txt_paid = new System.Windows.Forms.TextBox();
            this.txt_card = new System.Windows.Forms.TextBox();
            this.txt_cash = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_payable = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_credit = new System.Windows.Forms.Button();
            this.btn_cash = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvswipemasters)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_invoice);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnload);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btn_close);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_credit);
            this.groupBox1.Controls.Add(this.btn_cash);
            this.groupBox1.Controls.Add(this.btn_submit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1136, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_invoice
            // 
            this.lbl_invoice.AutoSize = true;
            this.lbl_invoice.Location = new System.Drawing.Point(837, 14);
            this.lbl_invoice.Name = "lbl_invoice";
            this.lbl_invoice.Size = new System.Drawing.Size(0, 13);
            this.lbl_invoice.TabIndex = 13;
            this.lbl_invoice.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(3, 109);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 5;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(322, 329);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cl
            // 
            this.cl.HeaderText = "Sl No :";
            this.cl.Name = "cl";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Bill No";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Amount";
            this.Column2.Name = "Column2";
            this.Column2.Width = 118;
            // 
            // btnload
            // 
            this.btnload.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.Location = new System.Drawing.Point(175, 35);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(88, 35);
            this.btnload.TabIndex = 11;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Snow;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(3, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Pending Cash Receipts     :";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox4.Controls.Add(this.txtInvoiceNumber);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(7, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(162, 60);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bill No";
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInvoiceNumber.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNumber.Location = new System.Drawing.Point(7, 19);
            this.txtInvoiceNumber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtInvoiceNumber.MaxLength = 15;
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(135, 30);
            this.txtInvoiceNumber.TabIndex = 0;
            this.txtInvoiceNumber.Click += new System.EventHandler(this.txtInvoiceNumber_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.67742F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.32258F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.Controls.Add(this.btn_1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_0, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_pt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_delete, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_8, 1, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(329, 109);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(212, 272);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(3, 3);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(59, 60);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_numeric_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(68, 3);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(59, 60);
            this.btn_2.TabIndex = 0;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_numeric_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(3, 69);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(59, 60);
            this.btn_4.TabIndex = 0;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_numeric_Click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(68, 69);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(59, 60);
            this.btn_5.TabIndex = 0;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_numeric_Click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(133, 69);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(62, 60);
            this.btn_6.TabIndex = 0;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_numeric_Click);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(3, 135);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(59, 64);
            this.btn_7.TabIndex = 0;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_numeric_Click);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(133, 135);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(62, 64);
            this.btn_9.TabIndex = 0;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_numeric_Click);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(3, 205);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(59, 64);
            this.btn_0.TabIndex = 0;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_numeric_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(133, 3);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(62, 60);
            this.btn_3.TabIndex = 0;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_numeric_Click);
            // 
            // btn_pt
            // 
            this.btn_pt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pt.Location = new System.Drawing.Point(68, 205);
            this.btn_pt.Name = "btn_pt";
            this.btn_pt.Size = new System.Drawing.Size(59, 64);
            this.btn_pt.TabIndex = 0;
            this.btn_pt.Text = ".";
            this.btn_pt.UseVisualStyleBackColor = true;
            this.btn_pt.Click += new System.EventHandler(this.btn_numeric_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(133, 205);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(62, 64);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(68, 135);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(59, 64);
            this.btn_8.TabIndex = 0;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_numeric_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_swiping);
            this.panel1.Controls.Add(this.btn_NewUnit);
            this.panel1.Controls.Add(this.dgvswipemasters);
            this.panel1.Controls.Add(this.txt_change);
            this.panel1.Controls.Add(this.txt_paid);
            this.panel1.Controls.Add(this.txt_card);
            this.panel1.Controls.Add(this.txt_cash);
            this.panel1.Controls.Add(this.txt_amount);
            this.panel1.Controls.Add(this.txt_payable);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(545, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 332);
            this.panel1.TabIndex = 3;
            // 
            // lbl_swiping
            // 
            this.lbl_swiping.AutoSize = true;
            this.lbl_swiping.Location = new System.Drawing.Point(359, 20);
            this.lbl_swiping.Name = "lbl_swiping";
            this.lbl_swiping.Size = new System.Drawing.Size(35, 13);
            this.lbl_swiping.TabIndex = 10;
            this.lbl_swiping.Text = "label9";
            // 
            // btn_NewUnit
            // 
            this.btn_NewUnit.BackColor = System.Drawing.Color.Transparent;
            this.btn_NewUnit.FlatAppearance.BorderSize = 0;
            this.btn_NewUnit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_NewUnit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_NewUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewUnit.Image = ((System.Drawing.Image)(resources.GetObject("btn_NewUnit.Image")));
            this.btn_NewUnit.Location = new System.Drawing.Point(557, 38);
            this.btn_NewUnit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_NewUnit.Name = "btn_NewUnit";
            this.btn_NewUnit.Size = new System.Drawing.Size(25, 25);
            this.btn_NewUnit.TabIndex = 9;
            this.btn_NewUnit.UseVisualStyleBackColor = false;
            this.btn_NewUnit.Click += new System.EventHandler(this.btn_NewUnit_Click);
            // 
            // dgvswipemasters
            // 
            this.dgvswipemasters.AllowUserToAddRows = false;
            this.dgvswipemasters.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvswipemasters.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvswipemasters.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvswipemasters.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvswipemasters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvswipemasters.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.NullValue = null;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvswipemasters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvswipemasters.ColumnHeadersHeight = 40;
            this.dgvswipemasters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SwipeName});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvswipemasters.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvswipemasters.Location = new System.Drawing.Point(260, 36);
            this.dgvswipemasters.Name = "dgvswipemasters";
            this.dgvswipemasters.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvswipemasters.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.dgvswipemasters.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvswipemasters.RowTemplate.Height = 40;
            this.dgvswipemasters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvswipemasters.Size = new System.Drawing.Size(296, 293);
            this.dgvswipemasters.TabIndex = 3;
            this.dgvswipemasters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvswipemasters_CellClick);
            this.dgvswipemasters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvswipemasters_CellContentClick);
            this.dgvswipemasters.SelectionChanged += new System.EventHandler(this.dgvswipemasters_SelectionChanged);
            // 
            // SwipeName
            // 
            this.SwipeName.HeaderText = "SwipeName";
            this.SwipeName.Name = "SwipeName";
            this.SwipeName.ReadOnly = true;
            this.SwipeName.Width = 253;
            // 
            // txt_change
            // 
            this.txt_change.Enabled = false;
            this.txt_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_change.Location = new System.Drawing.Point(100, 157);
            this.txt_change.Name = "txt_change";
            this.txt_change.Size = new System.Drawing.Size(151, 30);
            this.txt_change.TabIndex = 1;
            // 
            // txt_paid
            // 
            this.txt_paid.Enabled = false;
            this.txt_paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paid.Location = new System.Drawing.Point(100, 113);
            this.txt_paid.Name = "txt_paid";
            this.txt_paid.Size = new System.Drawing.Size(151, 30);
            this.txt_paid.TabIndex = 1;
            // 
            // txt_card
            // 
            this.txt_card.Enabled = false;
            this.txt_card.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_card.Location = new System.Drawing.Point(4, 275);
            this.txt_card.Name = "txt_card";
            this.txt_card.Size = new System.Drawing.Size(246, 30);
            this.txt_card.TabIndex = 1;
            this.txt_card.TextChanged += new System.EventHandler(this.txt_card_TextChanged);
            // 
            // txt_cash
            // 
            this.txt_cash.Enabled = false;
            this.txt_cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cash.Location = new System.Drawing.Point(3, 225);
            this.txt_cash.Name = "txt_cash";
            this.txt_cash.Size = new System.Drawing.Size(248, 30);
            this.txt_cash.TabIndex = 1;
            this.txt_cash.TextChanged += new System.EventHandler(this.txt_cash_TextChanged);
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(100, 65);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(151, 30);
            this.txt_amount.TabIndex = 0;
            this.txt_amount.Click += new System.EventHandler(this.txt_amount_Click);
            this.txt_amount.TextChanged += new System.EventHandler(this.txt_amount_TextChanged);
            // 
            // txt_payable
            // 
            this.txt_payable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payable.Location = new System.Drawing.Point(100, 16);
            this.txt_payable.Name = "txt_payable";
            this.txt_payable.Size = new System.Drawing.Size(151, 30);
            this.txt_payable.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(257, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Swipe Master:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(2, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Card:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(3, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cash:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(2, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Change:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(3, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Paid:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Payable Amt:";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Maroon;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_close.Location = new System.Drawing.Point(1041, 39);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(77, 44);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "CLOSE";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Maroon;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reset.Location = new System.Drawing.Point(957, 39);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(77, 44);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_credit
            // 
            this.btn_credit.BackColor = System.Drawing.Color.Maroon;
            this.btn_credit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_credit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_credit.Location = new System.Drawing.Point(628, 39);
            this.btn_credit.Name = "btn_credit";
            this.btn_credit.Size = new System.Drawing.Size(157, 44);
            this.btn_credit.TabIndex = 1;
            this.btn_credit.Text = "CARD";
            this.btn_credit.UseVisualStyleBackColor = false;
            this.btn_credit.Click += new System.EventHandler(this.btn_credit_Click);
            // 
            // btn_cash
            // 
            this.btn_cash.BackColor = System.Drawing.Color.Maroon;
            this.btn_cash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cash.Location = new System.Drawing.Point(475, 39);
            this.btn_cash.Name = "btn_cash";
            this.btn_cash.Size = new System.Drawing.Size(151, 44);
            this.btn_cash.TabIndex = 1;
            this.btn_cash.Text = "CASH";
            this.btn_cash.UseVisualStyleBackColor = false;
            this.btn_cash.Click += new System.EventHandler(this.btn_cash_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(363, 384);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(135, 45);
            this.btn_submit.TabIndex = 0;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(352, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paymode:";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1149, 474);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "Payment";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Payment_FormClosed);
            this.Load += new System.EventHandler(this.Payment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvswipemasters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_credit;
        private System.Windows.Forms.Button btn_cash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_payable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_change;
        private System.Windows.Forms.TextBox txt_paid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_pt;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.DataGridView dgvswipemasters;
        private System.Windows.Forms.TextBox txt_card;
        private System.Windows.Forms.TextBox txt_cash;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_NewUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SwipeName;
        private System.Windows.Forms.Label lbl_swiping;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label lbl_invoice;
    }
}