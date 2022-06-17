namespace BisCarePosEdition
{
    partial class OtherExpence
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_discription = new System.Windows.Forms.TextBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_expence = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_expence = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rb_edit = new System.Windows.Forms.RadioButton();
            this.Rb_new = new System.Windows.Forms.RadioButton();
            this.gbCategory.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.btn_cancel);
            this.gbCategory.Controls.Add(this.Btn_Delete);
            this.gbCategory.Controls.Add(this.label4);
            this.gbCategory.Controls.Add(this.btn_save);
            this.gbCategory.Controls.Add(this.label3);
            this.gbCategory.Controls.Add(this.txt_discription);
            this.gbCategory.Controls.Add(this.dtp_date);
            this.gbCategory.Controls.Add(this.txt_amount);
            this.gbCategory.Controls.Add(this.label2);
            this.gbCategory.Controls.Add(this.txt_expence);
            this.gbCategory.Controls.Add(this.label1);
            this.gbCategory.Controls.Add(this.cmb_expence);
            this.gbCategory.Controls.Add(this.label7);
            this.gbCategory.Controls.Add(this.groupBox2);
            this.gbCategory.Location = new System.Drawing.Point(6, -2);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(393, 354);
            this.gbCategory.TabIndex = 0;
            this.gbCategory.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(265, 300);
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
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Image = global::BisCarePosEdition.Properties.Resources.delete6;
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Delete.Location = new System.Drawing.Point(149, 300);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "Date";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(33, 300);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Discription";
            // 
            // txt_discription
            // 
            this.txt_discription.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discription.Location = new System.Drawing.Point(121, 261);
            this.txt_discription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_discription.Multiline = true;
            this.txt_discription.Name = "txt_discription";
            this.txt_discription.Size = new System.Drawing.Size(267, 20);
            this.txt_discription.TabIndex = 5;
            this.txt_discription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_discription_KeyDown);
            // 
            // dtp_date
            // 
            this.dtp_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Location = new System.Drawing.Point(121, 218);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(267, 22);
            this.dtp_date.TabIndex = 4;
            this.dtp_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_date_KeyDown);
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(121, 175);
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
            this.label2.Location = new System.Drawing.Point(55, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Amount";
            // 
            // txt_expence
            // 
            this.txt_expence.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_expence.Location = new System.Drawing.Point(121, 131);
            this.txt_expence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_expence.Name = "txt_expence";
            this.txt_expence.Size = new System.Drawing.Size(267, 24);
            this.txt_expence.TabIndex = 2;
            this.txt_expence.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_expence_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Expence";
            // 
            // cmb_expence
            // 
            this.cmb_expence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_expence.Enabled = false;
            this.cmb_expence.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_expence.FormattingEnabled = true;
            this.cmb_expence.Location = new System.Drawing.Point(121, 88);
            this.cmb_expence.Name = "cmb_expence";
            this.cmb_expence.Size = new System.Drawing.Size(267, 24);
            this.cmb_expence.TabIndex = 1;
            this.cmb_expence.SelectedIndexChanged += new System.EventHandler(this.cmb_expence_SelectedIndexChanged);
            this.cmb_expence.TextChanged += new System.EventHandler(this.cmb_expence_TextChanged);
            this.cmb_expence.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Rb_new_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Select Expence";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rb_edit);
            this.groupBox2.Controls.Add(this.Rb_new);
            this.groupBox2.Location = new System.Drawing.Point(54, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(234, 59);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // Rb_edit
            // 
            this.Rb_edit.AutoSize = true;
            this.Rb_edit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_edit.Location = new System.Drawing.Point(127, 22);
            this.Rb_edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rb_edit.Name = "Rb_edit";
            this.Rb_edit.Size = new System.Drawing.Size(49, 21);
            this.Rb_edit.TabIndex = 1;
            this.Rb_edit.Text = "Edit";
            this.Rb_edit.UseVisualStyleBackColor = true;
            this.Rb_edit.CheckedChanged += new System.EventHandler(this.Rb_edit_CheckedChanged);
            // 
            // Rb_new
            // 
            this.Rb_new.AutoSize = true;
            this.Rb_new.Checked = true;
            this.Rb_new.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_new.Location = new System.Drawing.Point(19, 22);
            this.Rb_new.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rb_new.Name = "Rb_new";
            this.Rb_new.Size = new System.Drawing.Size(52, 21);
            this.Rb_new.TabIndex = 0;
            this.Rb_new.TabStop = true;
            this.Rb_new.Text = "New";
            this.Rb_new.UseVisualStyleBackColor = true;
            this.Rb_new.CheckedChanged += new System.EventHandler(this.Rb_new_CheckedChanged);
            this.Rb_new.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Rb_new_KeyDown);
            // 
            // OtherExpence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(411, 356);
            this.Controls.Add(this.gbCategory);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OtherExpence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Other Expence";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.OtherExpence_Load);
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_discription;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_expence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_expence;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Rb_edit;
        private System.Windows.Forms.RadioButton Rb_new;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}