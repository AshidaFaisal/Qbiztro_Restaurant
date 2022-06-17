namespace BisCarePosEdition
{
    partial class ReportGoodsRec
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
            this.rd_weekly = new System.Windows.Forms.RadioButton();
            this.btndetailreport = new System.Windows.Forms.Button();
            this.rd_monthly = new System.Windows.Forms.RadioButton();
            this.grpDealer = new System.Windows.Forms.GroupBox();
            this.cboxCust = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.rd_custom = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpbxDate = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkbxCust = new System.Windows.Forms.CheckBox();
            this.ch_date = new System.Windows.Forms.CheckBox();
            this.grpitem = new System.Windows.Forms.GroupBox();
            this.cbox_ItemCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkitem = new System.Windows.Forms.CheckBox();
            this.grpDealer.SuspendLayout();
            this.grpbxDate.SuspendLayout();
            this.grpitem.SuspendLayout();
            this.SuspendLayout();
            // 
            // rd_weekly
            // 
            this.rd_weekly.AutoSize = true;
            this.rd_weekly.Location = new System.Drawing.Point(200, 37);
            this.rd_weekly.Name = "rd_weekly";
            this.rd_weekly.Size = new System.Drawing.Size(89, 21);
            this.rd_weekly.TabIndex = 37;
            this.rd_weekly.Text = "This Week";
            this.rd_weekly.UseVisualStyleBackColor = true;
            // 
            // btndetailreport
            // 
            this.btndetailreport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btndetailreport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btndetailreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndetailreport.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetailreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndetailreport.Location = new System.Drawing.Point(592, 49);
            this.btndetailreport.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btndetailreport.Name = "btndetailreport";
            this.btndetailreport.Size = new System.Drawing.Size(122, 32);
            this.btndetailreport.TabIndex = 59;
            this.btndetailreport.Text = "Detailed Report";
            this.btndetailreport.UseVisualStyleBackColor = false;
            this.btndetailreport.Click += new System.EventHandler(this.button1_Click);
            // 
            // rd_monthly
            // 
            this.rd_monthly.AutoSize = true;
            this.rd_monthly.Location = new System.Drawing.Point(91, 37);
            this.rd_monthly.Name = "rd_monthly";
            this.rd_monthly.Size = new System.Drawing.Size(93, 21);
            this.rd_monthly.TabIndex = 36;
            this.rd_monthly.Text = "This Month";
            this.rd_monthly.UseVisualStyleBackColor = true;
            this.rd_monthly.CheckedChanged += new System.EventHandler(this.rd_monthly_CheckedChanged);
            // 
            // grpDealer
            // 
            this.grpDealer.Controls.Add(this.cboxCust);
            this.grpDealer.Controls.Add(this.label3);
            this.grpDealer.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDealer.Location = new System.Drawing.Point(327, 36);
            this.grpDealer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDealer.Name = "grpDealer";
            this.grpDealer.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDealer.Size = new System.Drawing.Size(247, 69);
            this.grpDealer.TabIndex = 58;
            this.grpDealer.TabStop = false;
            this.grpDealer.Text = "Select Dealer";
            // 
            // cboxCust
            // 
            this.cboxCust.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxCust.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxCust.FormattingEnabled = true;
            this.cboxCust.Location = new System.Drawing.Point(56, 28);
            this.cboxCust.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cboxCust.Name = "cboxCust";
            this.cboxCust.Size = new System.Drawing.Size(184, 24);
            this.cboxCust.TabIndex = 37;
            this.cboxCust.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboxCust_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Dealer";
            // 
            // btnViewReport
            // 
            this.btnViewReport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnViewReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReport.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewReport.Location = new System.Drawing.Point(592, 72);
            this.btnViewReport.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(122, 32);
            this.btnViewReport.TabIndex = 54;
            this.btnViewReport.Text = "Brief Report";
            this.btnViewReport.UseVisualStyleBackColor = false;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // rd_custom
            // 
            this.rd_custom.AutoSize = true;
            this.rd_custom.Checked = true;
            this.rd_custom.Location = new System.Drawing.Point(2, 37);
            this.rd_custom.Name = "rd_custom";
            this.rd_custom.Size = new System.Drawing.Size(74, 21);
            this.rd_custom.TabIndex = 35;
            this.rd_custom.TabStop = true;
            this.rd_custom.Text = "Custom";
            this.rd_custom.UseVisualStyleBackColor = true;
            this.rd_custom.CheckedChanged += new System.EventHandler(this.rd_custom_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(592, 175);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 32);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpbxDate
            // 
            this.grpbxDate.Controls.Add(this.rd_weekly);
            this.grpbxDate.Controls.Add(this.rd_custom);
            this.grpbxDate.Controls.Add(this.rd_monthly);
            this.grpbxDate.Controls.Add(this.dtpEndDate);
            this.grpbxDate.Controls.Add(this.dtpStartDate);
            this.grpbxDate.Controls.Add(this.label1);
            this.grpbxDate.Controls.Add(this.label2);
            this.grpbxDate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxDate.Location = new System.Drawing.Point(7, 27);
            this.grpbxDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpbxDate.Name = "grpbxDate";
            this.grpbxDate.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpbxDate.Size = new System.Drawing.Size(294, 200);
            this.grpbxDate.TabIndex = 56;
            this.grpbxDate.TabStop = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(114, 118);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(162, 24);
            this.dtpEndDate.TabIndex = 9;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(114, 75);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(162, 24);
            this.dtpStartDate.TabIndex = 7;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "End Date";
            // 
            // chkbxCust
            // 
            this.chkbxCust.AutoSize = true;
            this.chkbxCust.Font = new System.Drawing.Font("Tahoma", 11F);
            this.chkbxCust.Location = new System.Drawing.Point(327, 5);
            this.chkbxCust.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chkbxCust.Name = "chkbxCust";
            this.chkbxCust.Size = new System.Drawing.Size(120, 22);
            this.chkbxCust.TabIndex = 57;
            this.chkbxCust.Text = "Include Dealer";
            this.chkbxCust.UseVisualStyleBackColor = true;
            this.chkbxCust.CheckedChanged += new System.EventHandler(this.chkbxCust_CheckedChanged);
            // 
            // ch_date
            // 
            this.ch_date.AutoSize = true;
            this.ch_date.Checked = true;
            this.ch_date.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_date.Enabled = false;
            this.ch_date.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ch_date.Location = new System.Drawing.Point(29, 5);
            this.ch_date.Name = "ch_date";
            this.ch_date.Size = new System.Drawing.Size(110, 22);
            this.ch_date.TabIndex = 53;
            this.ch_date.Text = "Include Date";
            this.ch_date.UseVisualStyleBackColor = true;
            this.ch_date.CheckedChanged += new System.EventHandler(this.ch_date_CheckedChanged);
            // 
            // grpitem
            // 
            this.grpitem.Controls.Add(this.cbox_ItemCode);
            this.grpitem.Controls.Add(this.label4);
            this.grpitem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpitem.Location = new System.Drawing.Point(327, 158);
            this.grpitem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpitem.Name = "grpitem";
            this.grpitem.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpitem.Size = new System.Drawing.Size(247, 69);
            this.grpitem.TabIndex = 61;
            this.grpitem.TabStop = false;
            this.grpitem.Text = "Select Item";
            // 
            // cbox_ItemCode
            // 
            this.cbox_ItemCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbox_ItemCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_ItemCode.FormattingEnabled = true;
            this.cbox_ItemCode.Location = new System.Drawing.Point(56, 28);
            this.cbox_ItemCode.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbox_ItemCode.Name = "cbox_ItemCode";
            this.cbox_ItemCode.Size = new System.Drawing.Size(184, 24);
            this.cbox_ItemCode.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Item";
            // 
            // checkitem
            // 
            this.checkitem.AutoSize = true;
            this.checkitem.Font = new System.Drawing.Font("Tahoma", 11F);
            this.checkitem.Location = new System.Drawing.Point(327, 127);
            this.checkitem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkitem.Name = "checkitem";
            this.checkitem.Size = new System.Drawing.Size(111, 22);
            this.checkitem.TabIndex = 60;
            this.checkitem.Text = "Include Item";
            this.checkitem.UseVisualStyleBackColor = true;
            this.checkitem.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ReportGoodsRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(737, 234);
            this.Controls.Add(this.grpitem);
            this.Controls.Add(this.checkitem);
            this.Controls.Add(this.btndetailreport);
            this.Controls.Add(this.grpDealer);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpbxDate);
            this.Controls.Add(this.chkbxCust);
            this.Controls.Add(this.ch_date);
            this.Name = "ReportGoodsRec";
            this.Text = "Report Goods Receipt";
            this.Load += new System.EventHandler(this.ReportGoodsRec_Load);
            this.grpDealer.ResumeLayout(false);
            this.grpDealer.PerformLayout();
            this.grpbxDate.ResumeLayout(false);
            this.grpbxDate.PerformLayout();
            this.grpitem.ResumeLayout(false);
            this.grpitem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rd_weekly;
        private System.Windows.Forms.Button btndetailreport;
        private System.Windows.Forms.RadioButton rd_monthly;
        private System.Windows.Forms.GroupBox grpDealer;
        private System.Windows.Forms.ComboBox cboxCust;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.RadioButton rd_custom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpbxDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkbxCust;
        private System.Windows.Forms.CheckBox ch_date;
        private System.Windows.Forms.GroupBox grpitem;
        private System.Windows.Forms.ComboBox cbox_ItemCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkitem;
    }
}