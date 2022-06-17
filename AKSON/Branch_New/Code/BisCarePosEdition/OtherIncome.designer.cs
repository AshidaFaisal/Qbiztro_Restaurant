namespace BisCarePosEdition
{
    partial class OtherIncome
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
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_discription = new System.Windows.Forms.TextBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_income = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_income = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttn_search = new System.Windows.Forms.Button();
            this.gv_search = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtp_enddate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_startdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_edittype = new System.Windows.Forms.ComboBox();
            this.cbox_date = new System.Windows.Forms.CheckBox();
            this.cbox_type = new System.Windows.Forms.CheckBox();
            this.gbCategory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_search)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.groupBox1);
            this.gbCategory.Controls.Add(this.label4);
            this.gbCategory.Controls.Add(this.Btn_Delete);
            this.gbCategory.Controls.Add(this.label3);
            this.gbCategory.Controls.Add(this.btn_save);
            this.gbCategory.Controls.Add(this.btn_cancel);
            this.gbCategory.Controls.Add(this.txt_discription);
            this.gbCategory.Controls.Add(this.dtp_date);
            this.gbCategory.Controls.Add(this.txt_amount);
            this.gbCategory.Controls.Add(this.label2);
            this.gbCategory.Controls.Add(this.txt_income);
            this.gbCategory.Controls.Add(this.label1);
            this.gbCategory.Controls.Add(this.cmb_income);
            this.gbCategory.Controls.Add(this.label7);
            this.gbCategory.Location = new System.Drawing.Point(3, -2);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(899, 420);
            this.gbCategory.TabIndex = 2;
            this.gbCategory.TabStop = false;
            this.gbCategory.Enter += new System.EventHandler(this.gbCategory_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "Date";
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Image = global::BisCarePosEdition.Properties.Resources.delete6;
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Delete.Location = new System.Drawing.Point(150, 316);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(110, 32);
            this.Btn_Delete.TabIndex = 7;
            this.Btn_Delete.Text = "   Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            this.Btn_Delete.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_save_Paint);
            this.Btn_Delete.MouseEnter += new System.EventHandler(this.btn_save_MouseEnter);
            this.Btn_Delete.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Description";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(34, 316);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(110, 32);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_save_Paint);
            this.btn_save.MouseEnter += new System.EventHandler(this.btn_save_MouseEnter);
            this.btn_save.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(266, 316);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 32);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_save_Paint);
            this.btn_cancel.MouseEnter += new System.EventHandler(this.btn_save_MouseEnter);
            this.btn_cancel.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            // 
            // txt_discription
            // 
            this.txt_discription.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discription.Location = new System.Drawing.Point(130, 257);
            this.txt_discription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_discription.Multiline = true;
            this.txt_discription.Name = "txt_discription";
            this.txt_discription.Size = new System.Drawing.Size(267, 42);
            this.txt_discription.TabIndex = 5;
            this.txt_discription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_discription_KeyDown);
            this.txt_discription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_discription_KeyPress);
            // 
            // dtp_date
            // 
            this.dtp_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Location = new System.Drawing.Point(130, 218);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(267, 22);
            this.dtp_date.TabIndex = 4;
            this.dtp_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_date_KeyDown);
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(130, 175);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_amount.MaxLength = 6;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(267, 24);
            this.txt_amount.TabIndex = 3;
            this.txt_amount.Text = "0";
            this.txt_amount.TextChanged += new System.EventHandler(this.txt_amount_TextChanged);
            this.txt_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_amount_KeyDown);
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Amount";
            // 
            // txt_income
            // 
            this.txt_income.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_income.Location = new System.Drawing.Point(130, 131);
            this.txt_income.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_income.Name = "txt_income";
            this.txt_income.Size = new System.Drawing.Size(267, 24);
            this.txt_income.TabIndex = 2;
            this.txt_income.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_income_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Income";
            // 
            // cmb_income
            // 
            this.cmb_income.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_income.Enabled = false;
            this.cmb_income.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_income.FormattingEnabled = true;
            this.cmb_income.Location = new System.Drawing.Point(130, 88);
            this.cmb_income.Name = "cmb_income";
            this.cmb_income.Size = new System.Drawing.Size(267, 24);
            this.cmb_income.TabIndex = 1;
            this.cmb_income.SelectedIndexChanged += new System.EventHandler(this.cmb_income_SelectedIndexChanged);
            this.cmb_income.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Rb_new_KeyDown);
            this.cmb_income.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_income_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Select Income";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttn_search);
            this.groupBox1.Controls.Add(this.gv_search);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(402, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(475, 378);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // bttn_search
            // 
            this.bttn_search.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_search.Location = new System.Drawing.Point(353, 169);
            this.bttn_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttn_search.Name = "bttn_search";
            this.bttn_search.Size = new System.Drawing.Size(110, 32);
            this.bttn_search.TabIndex = 12;
            this.bttn_search.Text = "       Search";
            this.bttn_search.UseVisualStyleBackColor = false;
            // 
            // gv_search
            // 
            this.gv_search.AllowUserToAddRows = false;
            this.gv_search.AllowUserToDeleteRows = false;
            this.gv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gv_search.Location = new System.Drawing.Point(21, 207);
            this.gv_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gv_search.Name = "gv_search";
            this.gv_search.ReadOnly = true;
            this.gv_search.Size = new System.Drawing.Size(442, 160);
            this.gv_search.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
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
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Amount";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp_enddate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dtp_startdate);
            this.groupBox3.Controls.Add(this.label6);
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
            this.dtp_enddate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "End Date ";
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
            this.dtp_startdate.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Type ";
            // 
            // cmb_edittype
            // 
            this.cmb_edittype.FormattingEnabled = true;
            this.cmb_edittype.Location = new System.Drawing.Point(207, 23);
            this.cmb_edittype.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_edittype.Name = "cmb_edittype";
            this.cmb_edittype.Size = new System.Drawing.Size(209, 24);
            this.cmb_edittype.TabIndex = 2;
            // 
            // cbox_date
            // 
            this.cbox_date.AutoSize = true;
            this.cbox_date.Location = new System.Drawing.Point(16, 64);
            this.cbox_date.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbox_date.Name = "cbox_date";
            this.cbox_date.Size = new System.Drawing.Size(76, 21);
            this.cbox_date.TabIndex = 1;
            this.cbox_date.Text = "By Date";
            this.cbox_date.UseVisualStyleBackColor = true;
            // 
            // cbox_type
            // 
            this.cbox_type.AutoSize = true;
            this.cbox_type.Location = new System.Drawing.Point(16, 27);
            this.cbox_type.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbox_type.Name = "cbox_type";
            this.cbox_type.Size = new System.Drawing.Size(78, 21);
            this.cbox_type.TabIndex = 0;
            this.cbox_type.Text = "By Type";
            this.cbox_type.UseVisualStyleBackColor = true;
            // 
            // OtherIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(909, 453);
            this.Controls.Add(this.gbCategory);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OtherIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Other Income";
            this.Load += new System.EventHandler(this.OtherIncome_Load);
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_search)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_income;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_income;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_discription;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttn_search;
        private System.Windows.Forms.DataGridView gv_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtp_enddate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_startdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_edittype;
        private System.Windows.Forms.CheckBox cbox_date;
        private System.Windows.Forms.CheckBox cbox_type;
    }
}