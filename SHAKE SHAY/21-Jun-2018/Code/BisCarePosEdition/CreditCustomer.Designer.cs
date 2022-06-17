namespace BisCarePosEdition
{
    partial class CreditCustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_payable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_recevable = new System.Windows.Forms.Label();
            this.Lbl_credit = new System.Windows.Forms.Label();
            this.txt_paidamnt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_custname = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_staff = new System.Windows.Forms.RadioButton();
            this.rd_credit = new System.Windows.Forms.RadioButton();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_balance);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_payable);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_recevable);
            this.groupBox1.Controls.Add(this.Lbl_credit);
            this.groupBox1.Controls.Add(this.txt_paidamnt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_custname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(5, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_balance
            // 
            this.txt_balance.Enabled = false;
            this.txt_balance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_balance.Location = new System.Drawing.Point(135, 344);
            this.txt_balance.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_balance.MaxLength = 50;
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(289, 27);
            this.txt_balance.TabIndex = 29;
            this.txt_balance.Text = "0.00";
            this.txt_balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_balance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_balance_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Balance Amount";
            // 
            // txt_payable
            // 
            this.txt_payable.Enabled = false;
            this.txt_payable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payable.Location = new System.Drawing.Point(135, 236);
            this.txt_payable.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_payable.MaxLength = 50;
            this.txt_payable.Name = "txt_payable";
            this.txt_payable.Size = new System.Drawing.Size(289, 27);
            this.txt_payable.TabIndex = 27;
            this.txt_payable.Text = "0.00";
            this.txt_payable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_payable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_payable_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Payable Amount";
            // 
            // lbl_recevable
            // 
            this.lbl_recevable.AutoSize = true;
            this.lbl_recevable.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recevable.Location = new System.Drawing.Point(135, 192);
            this.lbl_recevable.Name = "lbl_recevable";
            this.lbl_recevable.Size = new System.Drawing.Size(36, 17);
            this.lbl_recevable.TabIndex = 26;
            this.lbl_recevable.Text = "0.00";
            // 
            // Lbl_credit
            // 
            this.Lbl_credit.AutoSize = true;
            this.Lbl_credit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_credit.Location = new System.Drawing.Point(135, 148);
            this.Lbl_credit.Name = "Lbl_credit";
            this.Lbl_credit.Size = new System.Drawing.Size(36, 17);
            this.Lbl_credit.TabIndex = 25;
            this.Lbl_credit.Text = "0.00";
            this.Lbl_credit.Click += new System.EventHandler(this.Lbl_credit_Click);
            // 
            // txt_paidamnt
            // 
            this.txt_paidamnt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paidamnt.Location = new System.Drawing.Point(135, 290);
            this.txt_paidamnt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_paidamnt.MaxLength = 50;
            this.txt_paidamnt.Name = "txt_paidamnt";
            this.txt_paidamnt.Size = new System.Drawing.Size(289, 27);
            this.txt_paidamnt.TabIndex = 23;
            this.txt_paidamnt.Text = "0.00";
            this.txt_paidamnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_paidamnt.TextChanged += new System.EventHandler(this.txt_paidamnt_TextChanged);
            this.txt_paidamnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_paidamnt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Paid Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Receivable Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Credit Limit";
            // 
            // cmb_custname
            // 
            this.cmb_custname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_custname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_custname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_custname.FormattingEnabled = true;
            this.cmb_custname.Location = new System.Drawing.Point(135, 94);
            this.cmb_custname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_custname.Name = "cmb_custname";
            this.cmb_custname.Size = new System.Drawing.Size(259, 27);
            this.cmb_custname.TabIndex = 17;
            this.cmb_custname.SelectedIndexChanged += new System.EventHandler(this.cmb_custname_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rd_staff);
            this.groupBox2.Controls.Add(this.rd_credit);
            this.groupBox2.Location = new System.Drawing.Point(117, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Size = new System.Drawing.Size(277, 50);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // rd_staff
            // 
            this.rd_staff.AutoSize = true;
            this.rd_staff.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_staff.Location = new System.Drawing.Point(166, 18);
            this.rd_staff.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rd_staff.Name = "rd_staff";
            this.rd_staff.Size = new System.Drawing.Size(54, 21);
            this.rd_staff.TabIndex = 1;
            this.rd_staff.Text = "Staff";
            this.rd_staff.UseVisualStyleBackColor = true;
            this.rd_staff.CheckedChanged += new System.EventHandler(this.rd_staff_CheckedChanged);
            // 
            // rd_credit
            // 
            this.rd_credit.AutoSize = true;
            this.rd_credit.Checked = true;
            this.rd_credit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_credit.Location = new System.Drawing.Point(56, 18);
            this.rd_credit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rd_credit.Name = "rd_credit";
            this.rd_credit.Size = new System.Drawing.Size(86, 21);
            this.rd_credit.TabIndex = 0;
            this.rd_credit.TabStop = true;
            this.rd_credit.Text = "Customer";
            this.rd_credit.UseVisualStyleBackColor = true;
            this.rd_credit.CheckedChanged += new System.EventHandler(this.rd_credit_CheckedChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(229, 404);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 32);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(113, 404);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(110, 32);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "ok";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // CreditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 445);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreditCustomer";
            this.Text = "Credit Customer";
            this.Load += new System.EventHandler(this.CreditCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rd_staff;
        private System.Windows.Forms.RadioButton rd_credit;
        private System.Windows.Forms.ComboBox cmb_custname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_paidamnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_payable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_recevable;
        private System.Windows.Forms.Label Lbl_credit;
    }
}