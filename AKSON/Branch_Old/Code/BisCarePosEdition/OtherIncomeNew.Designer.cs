namespace BisCarePosEdition
{
    partial class OtherIncomeNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherIncomeNew));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bttn_newcategory = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.bttn_delete = new System.Windows.Forms.Button();
            this.bttn_cancel = new System.Windows.Forms.Button();
            this.bttn_save = new System.Windows.Forms.Button();
            this.dtp_newdate = new System.Windows.Forms.DateTimePicker();
            this.cmb_newtype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttn_search = new System.Windows.Forms.Button();
            this.gv_search = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtp_enddate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_startdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_edittype = new System.Windows.Forms.ComboBox();
            this.cbox_date = new System.Windows.Forms.CheckBox();
            this.cbox_type = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_search)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 405);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bttn_newcategory);
            this.groupBox4.Controls.Add(this.btn_reset);
            this.groupBox4.Controls.Add(this.bttn_delete);
            this.groupBox4.Controls.Add(this.bttn_cancel);
            this.groupBox4.Controls.Add(this.bttn_save);
            this.groupBox4.Controls.Add(this.dtp_newdate);
            this.groupBox4.Controls.Add(this.cmb_newtype);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txt_amount);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txt_description);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(5, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(270, 378);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "New / Edit";
            // 
            // bttn_newcategory
            // 
            this.bttn_newcategory.BackColor = System.Drawing.Color.Transparent;
            this.bttn_newcategory.FlatAppearance.BorderSize = 0;
            this.bttn_newcategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bttn_newcategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttn_newcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_newcategory.Image = ((System.Drawing.Image)(resources.GetObject("bttn_newcategory.Image")));
            this.bttn_newcategory.Location = new System.Drawing.Point(236, 82);
            this.bttn_newcategory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bttn_newcategory.Name = "bttn_newcategory";
            this.bttn_newcategory.Size = new System.Drawing.Size(25, 25);
            this.bttn_newcategory.TabIndex = 9;
            this.bttn_newcategory.UseVisualStyleBackColor = false;
            this.bttn_newcategory.Click += new System.EventHandler(this.bttn_newcategory_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Image = global::BisCarePosEdition.Properties.Resources.reset1;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(11, 329);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(110, 32);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            this.btn_reset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_reset_KeyDown);
            this.btn_reset.MouseEnter += new System.EventHandler(this.bttn_save_MouseEnter);
            this.btn_reset.MouseLeave += new System.EventHandler(this.bttn_save_MouseLeave);
            // 
            // bttn_delete
            // 
            this.bttn_delete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_delete.Image = global::BisCarePosEdition.Properties.Resources.delete6;
            this.bttn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_delete.Location = new System.Drawing.Point(126, 279);
            this.bttn_delete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttn_delete.Name = "bttn_delete";
            this.bttn_delete.Size = new System.Drawing.Size(110, 32);
            this.bttn_delete.TabIndex = 6;
            this.bttn_delete.Text = "Delete";
            this.bttn_delete.UseVisualStyleBackColor = false;
            this.bttn_delete.Click += new System.EventHandler(this.bttn_delete_Click);
            this.bttn_delete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bttn_delete_KeyDown);
            this.bttn_delete.MouseEnter += new System.EventHandler(this.bttn_save_MouseEnter);
            this.bttn_delete.MouseLeave += new System.EventHandler(this.bttn_save_MouseLeave);
            // 
            // bttn_cancel
            // 
            this.bttn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.bttn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_cancel.Location = new System.Drawing.Point(125, 329);
            this.bttn_cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttn_cancel.Name = "bttn_cancel";
            this.bttn_cancel.Size = new System.Drawing.Size(110, 32);
            this.bttn_cancel.TabIndex = 7;
            this.bttn_cancel.Text = "Close";
            this.bttn_cancel.UseVisualStyleBackColor = false;
            this.bttn_cancel.Click += new System.EventHandler(this.bttn_cancel_Click);
            this.bttn_cancel.MouseEnter += new System.EventHandler(this.bttn_save_MouseEnter);
            this.bttn_cancel.MouseLeave += new System.EventHandler(this.bttn_save_MouseLeave);
            // 
            // bttn_save
            // 
            this.bttn_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.bttn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_save.Location = new System.Drawing.Point(11, 279);
            this.bttn_save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(110, 32);
            this.bttn_save.TabIndex = 4;
            this.bttn_save.Text = "Save";
            this.bttn_save.UseVisualStyleBackColor = false;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            this.bttn_save.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bttn_save_KeyDown);
            this.bttn_save.MouseEnter += new System.EventHandler(this.bttn_save_MouseEnter);
            this.bttn_save.MouseLeave += new System.EventHandler(this.bttn_save_MouseLeave);
            this.bttn_save.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bttn_save_MouseMove);
            // 
            // dtp_newdate
            // 
            this.dtp_newdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_newdate.Location = new System.Drawing.Point(88, 34);
            this.dtp_newdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtp_newdate.Name = "dtp_newdate";
            this.dtp_newdate.Size = new System.Drawing.Size(143, 23);
            this.dtp_newdate.TabIndex = 0;
            this.dtp_newdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_newdate_KeyDown);
            // 
            // cmb_newtype
            // 
            this.cmb_newtype.FormattingEnabled = true;
            this.cmb_newtype.Location = new System.Drawing.Point(88, 81);
            this.cmb_newtype.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_newtype.Name = "cmb_newtype";
            this.cmb_newtype.Size = new System.Drawing.Size(143, 24);
            this.cmb_newtype.TabIndex = 1;
            this.cmb_newtype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_newtype_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date ";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(88, 213);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_amount.MaxLength = 8;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(143, 23);
            this.txt_amount.TabIndex = 3;
            this.txt_amount.Text = "0";
            this.txt_amount.TextChanged += new System.EventHandler(this.txt_amount_TextChanged);
            this.txt_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_amount_KeyDown);
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type ";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(88, 127);
            this.txt_description.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(143, 64);
            this.txt_description.TabIndex = 2;
            this.txt_description.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_description_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttn_search);
            this.groupBox2.Controls.Add(this.gv_search);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(269, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(475, 378);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // bttn_search
            // 
            this.bttn_search.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_search.Image = global::BisCarePosEdition.Properties.Resources.search4;
            this.bttn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_search.Location = new System.Drawing.Point(353, 169);
            this.bttn_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttn_search.Name = "bttn_search";
            this.bttn_search.Size = new System.Drawing.Size(110, 32);
            this.bttn_search.TabIndex = 0;
            this.bttn_search.Text = "       Search";
            this.bttn_search.UseVisualStyleBackColor = false;
            this.bttn_search.Click += new System.EventHandler(this.bttn_search_Click);
            this.bttn_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bttn_search_KeyDown);
            this.bttn_search.MouseEnter += new System.EventHandler(this.bttn_save_MouseEnter);
            this.bttn_search.MouseLeave += new System.EventHandler(this.bttn_save_MouseLeave);
            // 
            // gv_search
            // 
            this.gv_search.AllowUserToAddRows = false;
            this.gv_search.AllowUserToDeleteRows = false;
            this.gv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column1});
            this.gv_search.Location = new System.Drawing.Point(21, 207);
            this.gv_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gv_search.Name = "gv_search";
            this.gv_search.ReadOnly = true;
            this.gv_search.Size = new System.Drawing.Size(442, 160);
            this.gv_search.TabIndex = 1;
            this.gv_search.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_search_CellDoubleClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "SlNO";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Type";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 140;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Amount";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp_enddate);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dtp_startdate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmb_edittype);
            this.groupBox3.Controls.Add(this.cbox_date);
            this.groupBox3.Controls.Add(this.cbox_type);
            this.groupBox3.Location = new System.Drawing.Point(10, 22);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(453, 133);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // dtp_enddate
            // 
            this.dtp_enddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_enddate.Location = new System.Drawing.Point(209, 100);
            this.dtp_enddate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtp_enddate.Name = "dtp_enddate";
            this.dtp_enddate.Size = new System.Drawing.Size(207, 24);
            this.dtp_enddate.TabIndex = 4;
            this.dtp_enddate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_enddate_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "End Date ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Start Date ";
            // 
            // dtp_startdate
            // 
            this.dtp_startdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_startdate.Location = new System.Drawing.Point(209, 60);
            this.dtp_startdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtp_startdate.Name = "dtp_startdate";
            this.dtp_startdate.Size = new System.Drawing.Size(207, 24);
            this.dtp_startdate.TabIndex = 3;
            this.dtp_startdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_startdate_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type ";
            // 
            // cmb_edittype
            // 
            this.cmb_edittype.FormattingEnabled = true;
            this.cmb_edittype.Location = new System.Drawing.Point(207, 23);
            this.cmb_edittype.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_edittype.Name = "cmb_edittype";
            this.cmb_edittype.Size = new System.Drawing.Size(209, 24);
            this.cmb_edittype.TabIndex = 1;
            this.cmb_edittype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_edittype_KeyDown);
            // 
            // cbox_date
            // 
            this.cbox_date.AutoSize = true;
            this.cbox_date.Checked = true;
            this.cbox_date.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbox_date.Location = new System.Drawing.Point(16, 64);
            this.cbox_date.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbox_date.Name = "cbox_date";
            this.cbox_date.Size = new System.Drawing.Size(75, 21);
            this.cbox_date.TabIndex = 2;
            this.cbox_date.Text = "By Date";
            this.cbox_date.UseVisualStyleBackColor = true;
            this.cbox_date.CheckedChanged += new System.EventHandler(this.cbox_date_CheckedChanged);
            // 
            // cbox_type
            // 
            this.cbox_type.AutoSize = true;
            this.cbox_type.Location = new System.Drawing.Point(16, 27);
            this.cbox_type.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbox_type.Name = "cbox_type";
            this.cbox_type.Size = new System.Drawing.Size(76, 21);
            this.cbox_type.TabIndex = 0;
            this.cbox_type.Text = "By Type";
            this.cbox_type.UseVisualStyleBackColor = true;
            this.cbox_type.CheckedChanged += new System.EventHandler(this.cbox_type_CheckedChanged);
            // 
            // OtherIncomeNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(765, 418);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OtherIncomeNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Other Income";
            this.Load += new System.EventHandler(this.OtherIncomeNew_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_search)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button bttn_delete;
        private System.Windows.Forms.Button bttn_cancel;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.DateTimePicker dtp_newdate;
        private System.Windows.Forms.ComboBox cmb_newtype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bttn_search;
        private System.Windows.Forms.DataGridView gv_search;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtp_enddate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_startdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_edittype;
        private System.Windows.Forms.CheckBox cbox_date;
        private System.Windows.Forms.CheckBox cbox_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button bttn_newcategory;
    }
}