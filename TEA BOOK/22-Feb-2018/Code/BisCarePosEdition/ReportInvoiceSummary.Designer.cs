namespace BisCarePosEdition
{
    partial class ReportInvoiceSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportInvoiceSummary));
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rd_weekly = new System.Windows.Forms.RadioButton();
            this.rd_custom = new System.Windows.Forms.RadioButton();
            this.rd_monthly = new System.Windows.Forms.RadioButton();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_newtype = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cbox_type = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_viewreport = new System.Windows.Forms.Button();
            this.ch_date = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_end
            // 
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(89, 97);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(174, 23);
            this.dtp_end.TabIndex = 2;
            this.dtp_end.ValueChanged += new System.EventHandler(this.dtp_end_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.dtp_start);
            this.groupBox2.Controls.Add(this.dtp_end);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 137);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rd_weekly);
            this.groupBox4.Controls.Add(this.rd_custom);
            this.groupBox4.Controls.Add(this.rd_monthly);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(9, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 44);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            // 
            // rd_weekly
            // 
            this.rd_weekly.AutoSize = true;
            this.rd_weekly.Location = new System.Drawing.Point(188, 19);
            this.rd_weekly.Name = "rd_weekly";
            this.rd_weekly.Size = new System.Drawing.Size(95, 22);
            this.rd_weekly.TabIndex = 7;
            this.rd_weekly.Text = "This Week";
            this.rd_weekly.UseVisualStyleBackColor = true;
            this.rd_weekly.CheckedChanged += new System.EventHandler(this.rd_weekly_CheckedChanged);
            // 
            // rd_custom
            // 
            this.rd_custom.AutoSize = true;
            this.rd_custom.Checked = true;
            this.rd_custom.Location = new System.Drawing.Point(2, 18);
            this.rd_custom.Name = "rd_custom";
            this.rd_custom.Size = new System.Drawing.Size(76, 22);
            this.rd_custom.TabIndex = 5;
            this.rd_custom.TabStop = true;
            this.rd_custom.Text = "Custom";
            this.rd_custom.UseVisualStyleBackColor = true;
            // 
            // rd_monthly
            // 
            this.rd_monthly.AutoSize = true;
            this.rd_monthly.Location = new System.Drawing.Point(78, 18);
            this.rd_monthly.Name = "rd_monthly";
            this.rd_monthly.Size = new System.Drawing.Size(99, 22);
            this.rd_monthly.TabIndex = 6;
            this.rd_monthly.Text = "This Month";
            this.rd_monthly.UseVisualStyleBackColor = true;
            this.rd_monthly.CheckedChanged += new System.EventHandler(this.rd_monthly_CheckedChanged);
            // 
            // dtp_start
            // 
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start.Location = new System.Drawing.Point(89, 67);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(174, 23);
            this.dtp_start.TabIndex = 1;
            this.dtp_start.ValueChanged += new System.EventHandler(this.dtp_start_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Date ";
            // 
            // cmb_newtype
            // 
            this.cmb_newtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_newtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_newtype.FormattingEnabled = true;
            this.cmb_newtype.Location = new System.Drawing.Point(50, 56);
            this.cmb_newtype.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_newtype.Name = "cmb_newtype";
            this.cmb_newtype.Size = new System.Drawing.Size(316, 24);
            this.cmb_newtype.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_viewreport);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 218);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(360, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "       Print Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmb_newtype);
            this.groupBox3.Controls.Add(this.Cbox_type);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(348, 220);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(383, 87);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "By Type";
            this.groupBox3.Visible = false;
            // 
            // Cbox_type
            // 
            this.Cbox_type.AutoSize = true;
            this.Cbox_type.Location = new System.Drawing.Point(10, 30);
            this.Cbox_type.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Cbox_type.Name = "Cbox_type";
            this.Cbox_type.Size = new System.Drawing.Size(59, 21);
            this.Cbox_type.TabIndex = 0;
            this.Cbox_type.Text = "Type";
            this.Cbox_type.UseVisualStyleBackColor = true;
            this.Cbox_type.CheckedChanged += new System.EventHandler(this.Cbox_type_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Type ";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(209, 164);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 32);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_viewreport
            // 
            this.btn_viewreport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_viewreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewreport.Image = ((System.Drawing.Image)(resources.GetObject("btn_viewreport.Image")));
            this.btn_viewreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viewreport.Location = new System.Drawing.Point(71, 164);
            this.btn_viewreport.Name = "btn_viewreport";
            this.btn_viewreport.Size = new System.Drawing.Size(132, 32);
            this.btn_viewreport.TabIndex = 2;
            this.btn_viewreport.Text = "     View Report";
            this.btn_viewreport.UseVisualStyleBackColor = false;
            this.btn_viewreport.Click += new System.EventHandler(this.btn_viewreport_Click);
            // 
            // ch_date
            // 
            this.ch_date.AutoSize = true;
            this.ch_date.Checked = true;
            this.ch_date.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_date.Location = new System.Drawing.Point(13, 2);
            this.ch_date.Name = "ch_date";
            this.ch_date.Size = new System.Drawing.Size(106, 21);
            this.ch_date.TabIndex = 7;
            this.ch_date.Text = "Include Date";
            this.ch_date.UseVisualStyleBackColor = true;
            this.ch_date.CheckedChanged += new System.EventHandler(this.ch_date_CheckedChanged);
            // 
            // ReportInvoiceSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 250);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ch_date);
            this.Name = "ReportInvoiceSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportInvoiceSummary";
            this.Load += new System.EventHandler(this.ReportInvoiceSummary_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rd_weekly;
        private System.Windows.Forms.RadioButton rd_custom;
        private System.Windows.Forms.RadioButton rd_monthly;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_newtype;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox Cbox_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_viewreport;
        private System.Windows.Forms.CheckBox ch_date;
    }
}