namespace BisCarePosEdition
{
    partial class ReportPayableRecievable
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnRecievable = new System.Windows.Forms.RadioButton();
            this.rbtnPayable = new System.Windows.Forms.RadioButton();
            this.chkbxDate = new System.Windows.Forms.CheckBox();
            this.Lbl_Customer = new System.Windows.Forms.Label();
            this.grp_date = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.rd_weekly = new System.Windows.Forms.RadioButton();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.rd_custom = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rd_monthly = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Dealer = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboxCust = new System.Windows.Forms.ComboBox();
            this.chkbxCustomer = new System.Windows.Forms.CheckBox();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grp_date.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.chkbxDate);
            this.groupBox1.Controls.Add(this.Lbl_Customer);
            this.groupBox1.Controls.Add(this.grp_date);
            this.groupBox1.Controls.Add(this.Lbl_Dealer);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.cboxCust);
            this.groupBox1.Controls.Add(this.chkbxCustomer);
            this.groupBox1.Controls.Add(this.btnViewReport);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnRecievable);
            this.groupBox2.Controls.Add(this.rbtnPayable);
            this.groupBox2.Location = new System.Drawing.Point(11, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 54);
            this.groupBox2.TabIndex = 96;
            this.groupBox2.TabStop = false;
            // 
            // rbtnRecievable
            // 
            this.rbtnRecievable.AutoSize = true;
            this.rbtnRecievable.Location = new System.Drawing.Point(31, 24);
            this.rbtnRecievable.Name = "rbtnRecievable";
            this.rbtnRecievable.Size = new System.Drawing.Size(90, 21);
            this.rbtnRecievable.TabIndex = 1;
            this.rbtnRecievable.Text = "Recievable";
            this.rbtnRecievable.UseVisualStyleBackColor = true;
            this.rbtnRecievable.CheckedChanged += new System.EventHandler(this.rbtnRecievable_CheckedChanged);
            // 
            // rbtnPayable
            // 
            this.rbtnPayable.AutoSize = true;
            this.rbtnPayable.Checked = true;
            this.rbtnPayable.Location = new System.Drawing.Point(164, 24);
            this.rbtnPayable.Name = "rbtnPayable";
            this.rbtnPayable.Size = new System.Drawing.Size(73, 21);
            this.rbtnPayable.TabIndex = 0;
            this.rbtnPayable.TabStop = true;
            this.rbtnPayable.Text = "Payable";
            this.rbtnPayable.UseVisualStyleBackColor = true;
            this.rbtnPayable.CheckedChanged += new System.EventHandler(this.rbtnPayable_CheckedChanged);
            // 
            // chkbxDate
            // 
            this.chkbxDate.AutoSize = true;
            this.chkbxDate.Location = new System.Drawing.Point(311, 120);
            this.chkbxDate.Name = "chkbxDate";
            this.chkbxDate.Size = new System.Drawing.Size(199, 21);
            this.chkbxDate.TabIndex = 105;
            this.chkbxDate.Text = "Include Date with Customer";
            this.chkbxDate.UseVisualStyleBackColor = true;
            this.chkbxDate.CheckedChanged += new System.EventHandler(this.chkbxDate_CheckedChanged);
            // 
            // Lbl_Customer
            // 
            this.Lbl_Customer.AutoSize = true;
            this.Lbl_Customer.Location = new System.Drawing.Point(290, 71);
            this.Lbl_Customer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Customer.Name = "Lbl_Customer";
            this.Lbl_Customer.Size = new System.Drawing.Size(111, 17);
            this.Lbl_Customer.TabIndex = 106;
            this.Lbl_Customer.Text = "Customer Name ";
            this.Lbl_Customer.Visible = false;
            // 
            // grp_date
            // 
            this.grp_date.Controls.Add(this.dtpEndDate);
            this.grp_date.Controls.Add(this.rd_weekly);
            this.grp_date.Controls.Add(this.dtpStartDate);
            this.grp_date.Controls.Add(this.rd_custom);
            this.grp_date.Controls.Add(this.label1);
            this.grp_date.Controls.Add(this.rd_monthly);
            this.grp_date.Controls.Add(this.label2);
            this.grp_date.Location = new System.Drawing.Point(6, 68);
            this.grp_date.Name = "grp_date";
            this.grp_date.Size = new System.Drawing.Size(269, 127);
            this.grp_date.TabIndex = 111;
            this.grp_date.TabStop = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(94, 87);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(162, 24);
            this.dtpEndDate.TabIndex = 99;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // rd_weekly
            // 
            this.rd_weekly.AutoSize = true;
            this.rd_weekly.Location = new System.Drawing.Point(178, 19);
            this.rd_weekly.Name = "rd_weekly";
            this.rd_weekly.Size = new System.Drawing.Size(89, 21);
            this.rd_weekly.TabIndex = 110;
            this.rd_weekly.Text = "This Week";
            this.rd_weekly.UseVisualStyleBackColor = true;
            this.rd_weekly.CheckedChanged += new System.EventHandler(this.rd_weekly_CheckedChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(94, 52);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(162, 24);
            this.dtpStartDate.TabIndex = 97;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // rd_custom
            // 
            this.rd_custom.AutoSize = true;
            this.rd_custom.Checked = true;
            this.rd_custom.Location = new System.Drawing.Point(5, 18);
            this.rd_custom.Name = "rd_custom";
            this.rd_custom.Size = new System.Drawing.Size(74, 21);
            this.rd_custom.TabIndex = 108;
            this.rd_custom.TabStop = true;
            this.rd_custom.Text = "Custom";
            this.rd_custom.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 98;
            this.label1.Text = "Start Date ";
            // 
            // rd_monthly
            // 
            this.rd_monthly.AutoSize = true;
            this.rd_monthly.Location = new System.Drawing.Point(80, 18);
            this.rd_monthly.Name = "rd_monthly";
            this.rd_monthly.Size = new System.Drawing.Size(94, 21);
            this.rd_monthly.TabIndex = 109;
            this.rd_monthly.Text = "This Month";
            this.rd_monthly.UseVisualStyleBackColor = true;
            this.rd_monthly.CheckedChanged += new System.EventHandler(this.rd_monthly_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 100;
            this.label2.Text = "End Date ";
            // 
            // Lbl_Dealer
            // 
            this.Lbl_Dealer.AutoSize = true;
            this.Lbl_Dealer.Location = new System.Drawing.Point(290, 67);
            this.Lbl_Dealer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Dealer.Name = "Lbl_Dealer";
            this.Lbl_Dealer.Size = new System.Drawing.Size(86, 17);
            this.Lbl_Dealer.TabIndex = 107;
            this.Lbl_Dealer.Text = "Dealer Name";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(457, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 32);
            this.btnCancel.TabIndex = 104;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboxCust
            // 
            this.cboxCust.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxCust.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxCust.CausesValidation = false;
            this.cboxCust.FormattingEnabled = true;
            this.cboxCust.Location = new System.Drawing.Point(406, 64);
            this.cboxCust.Name = "cboxCust";
            this.cboxCust.Size = new System.Drawing.Size(172, 24);
            this.cboxCust.TabIndex = 102;
            this.cboxCust.SelectedIndexChanged += new System.EventHandler(this.cboxCust_SelectedIndexChanged);
            this.cboxCust.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboxCust_MouseClick);
            // 
            // chkbxCustomer
            // 
            this.chkbxCustomer.AutoSize = true;
            this.chkbxCustomer.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxCustomer.Location = new System.Drawing.Point(309, 23);
            this.chkbxCustomer.Name = "chkbxCustomer";
            this.chkbxCustomer.Size = new System.Drawing.Size(122, 22);
            this.chkbxCustomer.TabIndex = 101;
            this.chkbxCustomer.Text = "Include Dealer";
            this.chkbxCustomer.UseVisualStyleBackColor = true;
            this.chkbxCustomer.CheckedChanged += new System.EventHandler(this.chkbxCustomer_CheckedChanged);
            // 
            // btnViewReport
            // 
            this.btnViewReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btnViewReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReport.Image = global::BisCarePosEdition.Properties.Resources.Report_common;
            this.btnViewReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewReport.Location = new System.Drawing.Point(293, 150);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(158, 32);
            this.btnViewReport.TabIndex = 103;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = false;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // ReportPayableRecievable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 250);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportPayableRecievable";
            this.Text = "Payable Report";
            this.Load += new System.EventHandler(this.ReportPayableRecievable_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grp_date.ResumeLayout(false);
            this.grp_date.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grp_date;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.RadioButton rd_weekly;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.RadioButton rd_custom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rd_monthly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Dealer;
        private System.Windows.Forms.Label Lbl_Customer;
        private System.Windows.Forms.CheckBox chkbxDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboxCust;
        private System.Windows.Forms.CheckBox chkbxCustomer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnRecievable;
        private System.Windows.Forms.RadioButton rbtnPayable;
        private System.Windows.Forms.Button btnViewReport;

    }
}