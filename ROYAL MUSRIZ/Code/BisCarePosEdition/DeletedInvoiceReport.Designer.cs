namespace BisCarePosEdition
{
    partial class DeletedInvoiceReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletedInvoiceReport));
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_viewreport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rd_weekly = new System.Windows.Forms.RadioButton();
            this.rd_custom = new System.Windows.Forms.RadioButton();
            this.rd_monthly = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rd_no = new System.Windows.Forms.RadioButton();
            this.rd_yes = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(280, 169);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(140, 39);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseEnter += new System.EventHandler(this.btn_cancel_MouseEnter);
            this.btn_cancel.MouseLeave += new System.EventHandler(this.btn_cancel_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Date ";
            // 
            // btn_viewreport
            // 
            this.btn_viewreport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_viewreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewreport.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewreport.Image = global::BisCarePosEdition.Properties.Resources.Reportnew;
            this.btn_viewreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viewreport.Location = new System.Drawing.Point(113, 169);
            this.btn_viewreport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_viewreport.Name = "btn_viewreport";
            this.btn_viewreport.Size = new System.Drawing.Size(163, 39);
            this.btn_viewreport.TabIndex = 1;
            this.btn_viewreport.Text = "View Report";
            this.btn_viewreport.UseVisualStyleBackColor = false;
            this.btn_viewreport.Click += new System.EventHandler(this.btn_viewreport_Click);
            this.btn_viewreport.MouseEnter += new System.EventHandler(this.btn_cancel_MouseEnter);
            this.btn_viewreport.MouseLeave += new System.EventHandler(this.btn_cancel_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_start);
            this.groupBox2.Controls.Add(this.dtp_end);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 56);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(266, 103);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Date";
            // 
            // dtp_start
            // 
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start.Location = new System.Drawing.Point(79, 26);
            this.dtp_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(165, 23);
            this.dtp_start.TabIndex = 0;
            this.dtp_start.ValueChanged += new System.EventHandler(this.dtp_start_ValueChanged);
            // 
            // dtp_end
            // 
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(80, 67);
            this.dtp_end.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(164, 23);
            this.dtp_end.TabIndex = 1;
            this.dtp_end.ValueChanged += new System.EventHandler(this.dtp_end_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_viewreport);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(10, -2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(503, 214);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rd_weekly);
            this.groupBox4.Controls.Add(this.rd_custom);
            this.groupBox4.Controls.Add(this.rd_monthly);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(274, 44);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            // 
            // rd_weekly
            // 
            this.rd_weekly.AutoSize = true;
            this.rd_weekly.Location = new System.Drawing.Point(175, 19);
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
            this.rd_monthly.Location = new System.Drawing.Point(79, 18);
            this.rd_monthly.Name = "rd_monthly";
            this.rd_monthly.Size = new System.Drawing.Size(99, 22);
            this.rd_monthly.TabIndex = 6;
            this.rd_monthly.Text = "This Month";
            this.rd_monthly.UseVisualStyleBackColor = true;
            this.rd_monthly.CheckedChanged += new System.EventHandler(this.rd_monthly_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rd_no);
            this.groupBox3.Controls.Add(this.rd_yes);
            this.groupBox3.Location = new System.Drawing.Point(294, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 94);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Complimentary";
            // 
            // rd_no
            // 
            this.rd_no.AutoSize = true;
            this.rd_no.Location = new System.Drawing.Point(127, 49);
            this.rd_no.Name = "rd_no";
            this.rd_no.Size = new System.Drawing.Size(43, 21);
            this.rd_no.TabIndex = 1;
            this.rd_no.TabStop = true;
            this.rd_no.Text = "No";
            this.rd_no.UseVisualStyleBackColor = true;
            // 
            // rd_yes
            // 
            this.rd_yes.AutoSize = true;
            this.rd_yes.Location = new System.Drawing.Point(44, 49);
            this.rd_yes.Name = "rd_yes";
            this.rd_yes.Size = new System.Drawing.Size(47, 21);
            this.rd_yes.TabIndex = 0;
            this.rd_yes.TabStop = true;
            this.rd_yes.Text = "Yes";
            this.rd_yes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(91, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Print Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeletedInvoiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(524, 216);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeletedInvoiceReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deleted Invoice Report Detailed";
            this.Load += new System.EventHandler(this.DeletedInvoiceReport_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_viewreport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rd_no;
        private System.Windows.Forms.RadioButton rd_yes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rd_weekly;
        private System.Windows.Forms.RadioButton rd_custom;
        private System.Windows.Forms.RadioButton rd_monthly;
    }
}