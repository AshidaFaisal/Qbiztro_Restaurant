namespace BisCarePosEdition
{
    partial class Paymode
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
            this.grp_cheque = new System.Windows.Forms.GroupBox();
            this.btnNewCust = new System.Windows.Forms.Button();
            this.cbox_check = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCheque = new System.Windows.Forms.TextBox();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.dtChequeDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grp_card = new System.Windows.Forms.GroupBox();
            this.txt_card = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_paymode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxInvoice = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Save1 = new System.Windows.Forms.Button();
            this.btn_cancel1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grp_cheque.SuspendLayout();
            this.grp_card.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cancel1);
            this.groupBox1.Controls.Add(this.btn_Save1);
            this.groupBox1.Controls.Add(this.cboxInvoice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_paymode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.grp_card);
            this.groupBox1.Controls.Add(this.grp_cheque);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 437);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // grp_cheque
            // 
            this.grp_cheque.Controls.Add(this.btnNewCust);
            this.grp_cheque.Controls.Add(this.cbox_check);
            this.grp_cheque.Controls.Add(this.label13);
            this.grp_cheque.Controls.Add(this.txtCheque);
            this.grp_cheque.Controls.Add(this.cmbBank);
            this.grp_cheque.Controls.Add(this.dtChequeDate);
            this.grp_cheque.Controls.Add(this.label15);
            this.grp_cheque.Controls.Add(this.label12);
            this.grp_cheque.Controls.Add(this.label11);
            this.grp_cheque.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_cheque.Location = new System.Drawing.Point(6, 126);
            this.grp_cheque.Name = "grp_cheque";
            this.grp_cheque.Size = new System.Drawing.Size(370, 172);
            this.grp_cheque.TabIndex = 0;
            this.grp_cheque.TabStop = false;
            this.grp_cheque.Text = "Cheque";
            // 
            // btnNewCust
            // 
            this.btnNewCust.BackColor = System.Drawing.Color.Transparent;
            this.btnNewCust.FlatAppearance.BorderSize = 0;
            this.btnNewCust.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNewCust.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNewCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCust.Image = global::BisCarePosEdition.Properties.Resources.Add_;
            this.btnNewCust.Location = new System.Drawing.Point(325, 57);
            this.btnNewCust.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNewCust.Name = "btnNewCust";
            this.btnNewCust.Size = new System.Drawing.Size(25, 25);
            this.btnNewCust.TabIndex = 28;
            this.btnNewCust.UseVisualStyleBackColor = false;
            // 
            // cbox_check
            // 
            this.cbox_check.AutoSize = true;
            this.cbox_check.Checked = true;
            this.cbox_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbox_check.Location = new System.Drawing.Point(84, 144);
            this.cbox_check.Name = "cbox_check";
            this.cbox_check.Size = new System.Drawing.Size(67, 18);
            this.cbox_check.TabIndex = 30;
            this.cbox_check.Text = "Verified";
            this.cbox_check.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 14);
            this.label13.TabIndex = 34;
            this.label13.Text = "Realized :";
            // 
            // txtCheque
            // 
            this.txtCheque.Location = new System.Drawing.Point(84, 20);
            this.txtCheque.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheque.Name = "txtCheque";
            this.txtCheque.Size = new System.Drawing.Size(266, 22);
            this.txtCheque.TabIndex = 26;
            // 
            // cmbBank
            // 
            this.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(84, 59);
            this.cmbBank.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(234, 22);
            this.cmbBank.TabIndex = 27;
            // 
            // dtChequeDate
            // 
            this.dtChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtChequeDate.Location = new System.Drawing.Point(84, 98);
            this.dtChequeDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtChequeDate.Name = "dtChequeDate";
            this.dtChequeDate.Size = new System.Drawing.Size(91, 22);
            this.dtChequeDate.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 102);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 14);
            this.label15.TabIndex = 33;
            this.label15.Text = "ChequeDate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 63);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 14);
            this.label12.TabIndex = 32;
            this.label12.Text = "Bank ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 14);
            this.label11.TabIndex = 31;
            this.label11.Text = "ChequeNo ";
            // 
            // grp_card
            // 
            this.grp_card.Controls.Add(this.txt_card);
            this.grp_card.Controls.Add(this.label1);
            this.grp_card.Location = new System.Drawing.Point(6, 304);
            this.grp_card.Name = "grp_card";
            this.grp_card.Size = new System.Drawing.Size(370, 78);
            this.grp_card.TabIndex = 1;
            this.grp_card.TabStop = false;
            this.grp_card.Text = "Card";
            // 
            // txt_card
            // 
            this.txt_card.Location = new System.Drawing.Point(84, 33);
            this.txt_card.Margin = new System.Windows.Forms.Padding(4);
            this.txt_card.Name = "txt_card";
            this.txt_card.Size = new System.Drawing.Size(266, 22);
            this.txt_card.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 14);
            this.label1.TabIndex = 33;
            this.label1.Text = "ChequeNo ";
            // 
            // cmb_paymode
            // 
            this.cmb_paymode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_paymode.FormattingEnabled = true;
            this.cmb_paymode.Items.AddRange(new object[] {
            "--Select One--",
            "Cash",
            "Cheque",
            "Card"});
            this.cmb_paymode.Location = new System.Drawing.Point(90, 87);
            this.cmb_paymode.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_paymode.Name = "cmb_paymode";
            this.cmb_paymode.Size = new System.Drawing.Size(266, 22);
            this.cmb_paymode.TabIndex = 33;
            this.cmb_paymode.SelectedIndexChanged += new System.EventHandler(this.cmb_paymode_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 34;
            this.label2.Text = "Paymode";
            // 
            // cboxInvoice
            // 
            this.cboxInvoice.FormattingEnabled = true;
            this.cboxInvoice.Location = new System.Drawing.Point(90, 43);
            this.cboxInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.cboxInvoice.Name = "cboxInvoice";
            this.cboxInvoice.Size = new System.Drawing.Size(266, 22);
            this.cboxInvoice.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 14);
            this.label3.TabIndex = 36;
            this.label3.Text = "Invoice No";
            // 
            // btn_Save1
            // 
            this.btn_Save1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btn_Save1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Save1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save1.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.btn_Save1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save1.Location = new System.Drawing.Point(79, 395);
            this.btn_Save1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save1.Name = "btn_Save1";
            this.btn_Save1.Size = new System.Drawing.Size(110, 32);
            this.btn_Save1.TabIndex = 37;
            this.btn_Save1.Text = "    Save";
            this.btn_Save1.UseVisualStyleBackColor = false;
            this.btn_Save1.Click += new System.EventHandler(this.btn_Save1_Click);
            // 
            // btn_cancel1
            // 
            this.btn_cancel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btn_cancel1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_cancel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel1.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel1.Location = new System.Drawing.Point(197, 395);
            this.btn_cancel1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel1.Name = "btn_cancel1";
            this.btn_cancel1.Size = new System.Drawing.Size(110, 32);
            this.btn_cancel1.TabIndex = 39;
            this.btn_cancel1.Text = "   Close";
            this.btn_cancel1.UseVisualStyleBackColor = false;
            this.btn_cancel1.Click += new System.EventHandler(this.btn_cancel1_Click);
            // 
            // Paymode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 446);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Paymode";
            this.Text = "Paymode";
            this.Load += new System.EventHandler(this.Paymode_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_cheque.ResumeLayout(false);
            this.grp_cheque.PerformLayout();
            this.grp_card.ResumeLayout(false);
            this.grp_card.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grp_cheque;
        private System.Windows.Forms.GroupBox grp_card;
        private System.Windows.Forms.TextBox txt_card;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewCust;
        private System.Windows.Forms.CheckBox cbox_check;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCheque;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.DateTimePicker dtChequeDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboxInvoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_paymode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Save1;
        private System.Windows.Forms.Button btn_cancel1;
    }
}