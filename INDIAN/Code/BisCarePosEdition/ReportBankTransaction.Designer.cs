namespace BisCarePosEdition
{
    partial class ReportBankTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportBankTransaction));
            this.Cbox_Type = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_weekly = new System.Windows.Forms.RadioButton();
            this.rd_custom = new System.Windows.Forms.RadioButton();
            this.rd_monthly = new System.Windows.Forms.RadioButton();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.bttn_search = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Rb_withdrawal = new System.Windows.Forms.RadioButton();
            this.Rb_Deposit = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cbox_Bank = new System.Windows.Forms.CheckBox();
            this.cmb_bankname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Dtp_End = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbox_Date = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cbox_Type
            // 
            this.Cbox_Type.AutoSize = true;
            this.Cbox_Type.Location = new System.Drawing.Point(26, 22);
            this.Cbox_Type.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Cbox_Type.Name = "Cbox_Type";
            this.Cbox_Type.Size = new System.Drawing.Size(57, 21);
            this.Cbox_Type.TabIndex = 2;
            this.Cbox_Type.Text = "Type";
            this.Cbox_Type.UseVisualStyleBackColor = true;
            this.Cbox_Type.CheckedChanged += new System.EventHandler(this.Cbox_Type_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_weekly);
            this.groupBox1.Controls.Add(this.rd_custom);
            this.groupBox1.Controls.Add(this.rd_monthly);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.bttn_search);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(562, 225);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bank Transaction";
            // 
            // rd_weekly
            // 
            this.rd_weekly.AutoSize = true;
            this.rd_weekly.Location = new System.Drawing.Point(197, 32);
            this.rd_weekly.Name = "rd_weekly";
            this.rd_weekly.Size = new System.Drawing.Size(89, 21);
            this.rd_weekly.TabIndex = 59;
            this.rd_weekly.Text = "This Week";
            this.rd_weekly.UseVisualStyleBackColor = true;
            this.rd_weekly.CheckedChanged += new System.EventHandler(this.rd_weekly_CheckedChanged);
            // 
            // rd_custom
            // 
            this.rd_custom.AutoSize = true;
            this.rd_custom.Checked = true;
            this.rd_custom.Location = new System.Drawing.Point(12, 31);
            this.rd_custom.Name = "rd_custom";
            this.rd_custom.Size = new System.Drawing.Size(74, 21);
            this.rd_custom.TabIndex = 57;
            this.rd_custom.TabStop = true;
            this.rd_custom.Text = "Custom";
            this.rd_custom.UseVisualStyleBackColor = true;
            // 
            // rd_monthly
            // 
            this.rd_monthly.AutoSize = true;
            this.rd_monthly.Location = new System.Drawing.Point(92, 32);
            this.rd_monthly.Name = "rd_monthly";
            this.rd_monthly.Size = new System.Drawing.Size(94, 21);
            this.rd_monthly.TabIndex = 58;
            this.rd_monthly.Text = "This Month";
            this.rd_monthly.UseVisualStyleBackColor = true;
            this.rd_monthly.CheckedChanged += new System.EventHandler(this.rd_monthly_CheckedChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(299, 187);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 32);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // bttn_search
            // 
            this.bttn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.bttn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_search.Image = ((System.Drawing.Image)(resources.GetObject("bttn_search.Image")));
            this.bttn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_search.Location = new System.Drawing.Point(153, 187);
            this.bttn_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttn_search.Name = "bttn_search";
            this.bttn_search.Size = new System.Drawing.Size(140, 32);
            this.bttn_search.TabIndex = 6;
            this.bttn_search.Text = "View Report";
            this.bttn_search.UseVisualStyleBackColor = false;
            this.bttn_search.Click += new System.EventHandler(this.bttn_search_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Cbox_Type);
            this.groupBox4.Controls.Add(this.Rb_withdrawal);
            this.groupBox4.Controls.Add(this.Rb_Deposit);
            this.groupBox4.Location = new System.Drawing.Point(299, 103);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(256, 71);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "By Type";
            // 
            // Rb_withdrawal
            // 
            this.Rb_withdrawal.AutoSize = true;
            this.Rb_withdrawal.Enabled = false;
            this.Rb_withdrawal.Location = new System.Drawing.Point(125, 47);
            this.Rb_withdrawal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Rb_withdrawal.Name = "Rb_withdrawal";
            this.Rb_withdrawal.Size = new System.Drawing.Size(95, 21);
            this.Rb_withdrawal.TabIndex = 1;
            this.Rb_withdrawal.Text = "Withdrawal";
            this.Rb_withdrawal.UseVisualStyleBackColor = true;
            // 
            // Rb_Deposit
            // 
            this.Rb_Deposit.AutoSize = true;
            this.Rb_Deposit.Checked = true;
            this.Rb_Deposit.Enabled = false;
            this.Rb_Deposit.Location = new System.Drawing.Point(26, 47);
            this.Rb_Deposit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Rb_Deposit.Name = "Rb_Deposit";
            this.Rb_Deposit.Size = new System.Drawing.Size(73, 21);
            this.Rb_Deposit.TabIndex = 0;
            this.Rb_Deposit.TabStop = true;
            this.Rb_Deposit.Text = "Deposit";
            this.Rb_Deposit.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Cbox_Bank);
            this.groupBox3.Controls.Add(this.cmb_bankname);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(300, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(255, 81);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "By Bank";
            // 
            // Cbox_Bank
            // 
            this.Cbox_Bank.AutoSize = true;
            this.Cbox_Bank.Location = new System.Drawing.Point(7, 22);
            this.Cbox_Bank.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Cbox_Bank.Name = "Cbox_Bank";
            this.Cbox_Bank.Size = new System.Drawing.Size(57, 21);
            this.Cbox_Bank.TabIndex = 1;
            this.Cbox_Bank.Text = "Bank";
            this.Cbox_Bank.UseVisualStyleBackColor = true;
            this.Cbox_Bank.CheckedChanged += new System.EventHandler(this.Cbox_Bank_CheckedChanged);
            // 
            // cmb_bankname
            // 
            this.cmb_bankname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bankname.DropDownWidth = 250;
            this.cmb_bankname.Enabled = false;
            this.cmb_bankname.FormattingEnabled = true;
            this.cmb_bankname.Location = new System.Drawing.Point(93, 47);
            this.cmb_bankname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_bankname.Name = "cmb_bankname";
            this.cmb_bankname.Size = new System.Drawing.Size(146, 24);
            this.cmb_bankname.TabIndex = 1;
            this.cmb_bankname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_bankname_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bank Name ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Dtp_End);
            this.groupBox2.Controls.Add(this.Dtp_Start);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 66);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(274, 108);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // Dtp_End
            // 
            this.Dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_End.Location = new System.Drawing.Point(96, 64);
            this.Dtp_End.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Dtp_End.Name = "Dtp_End";
            this.Dtp_End.Size = new System.Drawing.Size(156, 24);
            this.Dtp_End.TabIndex = 3;
            this.Dtp_End.ValueChanged += new System.EventHandler(this.Dtp_End_ValueChanged);
            // 
            // Dtp_Start
            // 
            this.Dtp_Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Start.Location = new System.Drawing.Point(96, 26);
            this.Dtp_Start.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Dtp_Start.Name = "Dtp_Start";
            this.Dtp_Start.Size = new System.Drawing.Size(156, 24);
            this.Dtp_Start.TabIndex = 2;
            this.Dtp_Start.ValueChanged += new System.EventHandler(this.Dtp_Start_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Date ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date ";
            // 
            // Cbox_Date
            // 
            this.Cbox_Date.AutoSize = true;
            this.Cbox_Date.Checked = true;
            this.Cbox_Date.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cbox_Date.Location = new System.Drawing.Point(159, 285);
            this.Cbox_Date.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Cbox_Date.Name = "Cbox_Date";
            this.Cbox_Date.Size = new System.Drawing.Size(49, 17);
            this.Cbox_Date.TabIndex = 6;
            this.Cbox_Date.Text = "Date";
            this.Cbox_Date.UseVisualStyleBackColor = true;
            this.Cbox_Date.Visible = false;
            this.Cbox_Date.CheckedChanged += new System.EventHandler(this.Cbox_Date_CheckedChanged);
            // 
            // ReportBankTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 249);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cbox_Date);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportBankTransaction";
            this.Text = "Bank Transaction Report";
            this.Load += new System.EventHandler(this.ReportBankTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Cbox_Type;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_weekly;
        private System.Windows.Forms.RadioButton rd_custom;
        private System.Windows.Forms.RadioButton rd_monthly;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button bttn_search;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton Rb_withdrawal;
        private System.Windows.Forms.RadioButton Rb_Deposit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox Cbox_Bank;
        private System.Windows.Forms.ComboBox cmb_bankname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker Dtp_End;
        private System.Windows.Forms.DateTimePicker Dtp_Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Cbox_Date;
    }
}