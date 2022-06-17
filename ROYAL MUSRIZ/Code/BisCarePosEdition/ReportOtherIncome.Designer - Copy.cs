namespace BisCarePosEdition
{
    partial class ReportOtherIncome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportOtherIncome));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmb_newtype = new System.Windows.Forms.ComboBox();
            this.Cbox_type = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_viewreport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.ch_date = new System.Windows.Forms.CheckBox();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_viewreport);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 166);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmb_newtype);
            this.groupBox3.Controls.Add(this.Cbox_type);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(254, 21);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(266, 87);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "By Type";
            // 
            // cmb_newtype
            // 
            this.cmb_newtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_newtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_newtype.FormattingEnabled = true;
            this.cmb_newtype.Location = new System.Drawing.Point(51, 51);
            this.cmb_newtype.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_newtype.Name = "cmb_newtype";
            this.cmb_newtype.Size = new System.Drawing.Size(202, 24);
            this.cmb_newtype.TabIndex = 2;
            // 
            // Cbox_type
            // 
            this.Cbox_type.AutoSize = true;
            this.Cbox_type.Location = new System.Drawing.Point(11, 20);
            this.Cbox_type.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Cbox_type.Name = "Cbox_type";
            this.Cbox_type.Size = new System.Drawing.Size(59, 21);
            this.Cbox_type.TabIndex = 1;
            this.Cbox_type.Text = "Type";
            this.Cbox_type.UseVisualStyleBackColor = true;
            this.Cbox_type.CheckedChanged += new System.EventHandler(this.Cbox_type_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 54);
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
            this.btn_cancel.Location = new System.Drawing.Point(400, 118);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(120, 32);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_viewreport_Paint);
            this.btn_cancel.MouseEnter += new System.EventHandler(this.btn_viewreport_MouseEnter);
            this.btn_cancel.MouseLeave += new System.EventHandler(this.btn_viewreport_MouseLeave);
            // 
            // btn_viewreport
            // 
            this.btn_viewreport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_viewreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewreport.Image = ((System.Drawing.Image)(resources.GetObject("btn_viewreport.Image")));
            this.btn_viewreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viewreport.Location = new System.Drawing.Point(254, 118);
            this.btn_viewreport.Name = "btn_viewreport";
            this.btn_viewreport.Size = new System.Drawing.Size(140, 32);
            this.btn_viewreport.TabIndex = 1;
            this.btn_viewreport.Text = "View Report";
            this.btn_viewreport.UseVisualStyleBackColor = false;
            this.btn_viewreport.Click += new System.EventHandler(this.btn_viewreport_Click);
            this.btn_viewreport.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_viewreport_Paint);
            this.btn_viewreport.MouseEnter += new System.EventHandler(this.btn_viewreport_MouseEnter);
            this.btn_viewreport.MouseLeave += new System.EventHandler(this.btn_viewreport_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_start);
            this.groupBox2.Controls.Add(this.ch_date);
            this.groupBox2.Controls.Add(this.dtp_end);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 131);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Date";
            // 
            // dtp_start
            // 
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start.Location = new System.Drawing.Point(89, 50);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(136, 23);
            this.dtp_start.TabIndex = 0;
            // 
            // ch_date
            // 
            this.ch_date.AutoSize = true;
            this.ch_date.Checked = true;
            this.ch_date.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_date.Location = new System.Drawing.Point(18, 20);
            this.ch_date.Name = "ch_date";
            this.ch_date.Size = new System.Drawing.Size(106, 21);
            this.ch_date.TabIndex = 5;
            this.ch_date.Text = "Include Date";
            this.ch_date.UseVisualStyleBackColor = true;
            this.ch_date.CheckedChanged += new System.EventHandler(this.ch_date_CheckedChanged);
            // 
            // dtp_end
            // 
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(89, 86);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(136, 23);
            this.dtp_end.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Date ";
            // 
            // ReportOtherIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(537, 172);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportOtherIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Other Income Report";
            this.Load += new System.EventHandler(this.ReportOtherIncome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_viewreport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ch_date;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_newtype;
        private System.Windows.Forms.CheckBox Cbox_type;
        private System.Windows.Forms.Label label2;
    }
}