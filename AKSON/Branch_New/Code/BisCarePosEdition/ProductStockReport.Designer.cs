namespace BisCarePosEdition
{
    partial class ProductStockReport
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
            this.grp_Item = new System.Windows.Forms.GroupBox();
            this.cmb_item = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ch_item = new System.Windows.Forms.CheckBox();
            this.grpCat = new System.Windows.Forms.GroupBox();
            this.cmb_Cat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ch_Cat = new System.Windows.Forms.CheckBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_viewreport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rd_weekly = new System.Windows.Forms.RadioButton();
            this.rd_custom = new System.Windows.Forms.RadioButton();
            this.rd_monthly = new System.Windows.Forms.RadioButton();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ch_Date = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.grp_Item.SuspendLayout();
            this.grpCat.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ch_Date);
            this.groupBox1.Controls.Add(this.grp_Item);
            this.groupBox1.Controls.Add(this.ch_item);
            this.groupBox1.Controls.Add(this.grpCat);
            this.groupBox1.Controls.Add(this.ch_Cat);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_viewreport);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // grp_Item
            // 
            this.grp_Item.Controls.Add(this.cmb_item);
            this.grp_Item.Controls.Add(this.label2);
            this.grp_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Item.Location = new System.Drawing.Point(12, 182);
            this.grp_Item.Name = "grp_Item";
            this.grp_Item.Size = new System.Drawing.Size(324, 96);
            this.grp_Item.TabIndex = 44;
            this.grp_Item.TabStop = false;
            this.grp_Item.Text = "Select Item";
            // 
            // cmb_item
            // 
            this.cmb_item.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_item.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_item.FormattingEnabled = true;
            this.cmb_item.Location = new System.Drawing.Point(61, 44);
            this.cmb_item.Name = "cmb_item";
            this.cmb_item.Size = new System.Drawing.Size(219, 24);
            this.cmb_item.TabIndex = 0;
            this.cmb_item.SelectedIndexChanged += new System.EventHandler(this.cmb_item_SelectedIndexChanged);
            this.cmb_item.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_item_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item ";
            // 
            // ch_item
            // 
            this.ch_item.AutoSize = true;
            this.ch_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_item.Location = new System.Drawing.Point(12, 139);
            this.ch_item.Name = "ch_item";
            this.ch_item.Size = new System.Drawing.Size(98, 20);
            this.ch_item.TabIndex = 3;
            this.ch_item.Text = "Include Item";
            this.ch_item.UseVisualStyleBackColor = true;
            this.ch_item.CheckedChanged += new System.EventHandler(this.ch_item_CheckedChanged);
            // 
            // grpCat
            // 
            this.grpCat.Controls.Add(this.cmb_Cat);
            this.grpCat.Controls.Add(this.label5);
            this.grpCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCat.Location = new System.Drawing.Point(358, 182);
            this.grpCat.Name = "grpCat";
            this.grpCat.Size = new System.Drawing.Size(308, 96);
            this.grpCat.TabIndex = 39;
            this.grpCat.TabStop = false;
            this.grpCat.Text = "Select Category";
            // 
            // cmb_Cat
            // 
            this.cmb_Cat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Cat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Cat.FormattingEnabled = true;
            this.cmb_Cat.Location = new System.Drawing.Point(83, 44);
            this.cmb_Cat.Name = "cmb_Cat";
            this.cmb_Cat.Size = new System.Drawing.Size(219, 24);
            this.cmb_Cat.TabIndex = 0;
            this.cmb_Cat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Cat_KeyDown);
            this.cmb_Cat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Cat_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Category";
            // 
            // ch_Cat
            // 
            this.ch_Cat.AutoSize = true;
            this.ch_Cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_Cat.Location = new System.Drawing.Point(358, 139);
            this.ch_Cat.Name = "ch_Cat";
            this.ch_Cat.Size = new System.Drawing.Size(128, 20);
            this.ch_Cat.TabIndex = 2;
            this.ch_Cat.Text = "Include Category";
            this.ch_Cat.UseVisualStyleBackColor = true;
            this.ch_Cat.CheckedChanged += new System.EventHandler(this.ch_Cat_CheckedChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(320, 311);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(128, 34);
            this.btn_cancel.TabIndex = 41;
            this.btn_cancel.Text = "Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseEnter += new System.EventHandler(this.btn_viewreport_MouseEnter);
            this.btn_cancel.MouseLeave += new System.EventHandler(this.btn_viewreport_MouseLeave);
            // 
            // btn_viewreport
            // 
            this.btn_viewreport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_viewreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewreport.Image = global::BisCarePosEdition.Properties.Resources.Reportnew;
            this.btn_viewreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viewreport.Location = new System.Drawing.Point(151, 311);
            this.btn_viewreport.Name = "btn_viewreport";
            this.btn_viewreport.Size = new System.Drawing.Size(163, 34);
            this.btn_viewreport.TabIndex = 40;
            this.btn_viewreport.Text = "View Report";
            this.btn_viewreport.UseVisualStyleBackColor = false;
            this.btn_viewreport.Click += new System.EventHandler(this.btn_viewreport_Click);
            this.btn_viewreport.MouseEnter += new System.EventHandler(this.btn_viewreport_MouseEnter);
            this.btn_viewreport.MouseLeave += new System.EventHandler(this.btn_viewreport_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dtp_start);
            this.groupBox2.Controls.Add(this.dtp_end);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 115);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rd_weekly);
            this.groupBox3.Controls.Add(this.rd_custom);
            this.groupBox3.Controls.Add(this.rd_monthly);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 47);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            // 
            // rd_weekly
            // 
            this.rd_weekly.AutoSize = true;
            this.rd_weekly.Location = new System.Drawing.Point(211, 19);
            this.rd_weekly.Name = "rd_weekly";
            this.rd_weekly.Size = new System.Drawing.Size(91, 20);
            this.rd_weekly.TabIndex = 7;
            this.rd_weekly.TabStop = true;
            this.rd_weekly.Text = "This Week";
            this.rd_weekly.UseVisualStyleBackColor = true;
            this.rd_weekly.CheckedChanged += new System.EventHandler(this.rd_weekly_CheckedChanged);
            // 
            // rd_custom
            // 
            this.rd_custom.AutoSize = true;
            this.rd_custom.Location = new System.Drawing.Point(7, 19);
            this.rd_custom.Name = "rd_custom";
            this.rd_custom.Size = new System.Drawing.Size(71, 20);
            this.rd_custom.TabIndex = 5;
            this.rd_custom.TabStop = true;
            this.rd_custom.Text = "Custom";
            this.rd_custom.UseVisualStyleBackColor = true;
            // 
            // rd_monthly
            // 
            this.rd_monthly.AutoSize = true;
            this.rd_monthly.Location = new System.Drawing.Point(98, 19);
            this.rd_monthly.Name = "rd_monthly";
            this.rd_monthly.Size = new System.Drawing.Size(91, 20);
            this.rd_monthly.TabIndex = 6;
            this.rd_monthly.TabStop = true;
            this.rd_monthly.Text = "This Month";
            this.rd_monthly.UseVisualStyleBackColor = true;
            this.rd_monthly.CheckedChanged += new System.EventHandler(this.rd_monthly_CheckedChanged);
            // 
            // dtp_start
            // 
            this.dtp_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start.Location = new System.Drawing.Point(96, 51);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(179, 22);
            this.dtp_start.TabIndex = 0;
            this.dtp_start.ValueChanged += new System.EventHandler(this.dtp_start_ValueChanged);
            this.dtp_start.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_start_KeyDown);
            // 
            // dtp_end
            // 
            this.dtp_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(94, 83);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(179, 22);
            this.dtp_end.TabIndex = 1;
            this.dtp_end.ValueChanged += new System.EventHandler(this.dtp_end_ValueChanged);
            this.dtp_end.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_end_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Date ";
            // 
            // ch_Date
            // 
            this.ch_Date.AutoSize = true;
            this.ch_Date.Checked = true;
            this.ch_Date.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_Date.Location = new System.Drawing.Point(364, 27);
            this.ch_Date.Name = "ch_Date";
            this.ch_Date.Size = new System.Drawing.Size(102, 20);
            this.ch_Date.TabIndex = 45;
            this.ch_Date.Text = "Include Date";
            this.ch_Date.UseVisualStyleBackColor = true;
            this.ch_Date.CheckedChanged += new System.EventHandler(this.ch_Date_CheckedChanged);
            // 
            // ProductStockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(706, 380);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductStockReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Stock Report";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_Item.ResumeLayout(false);
            this.grp_Item.PerformLayout();
            this.grpCat.ResumeLayout(false);
            this.grpCat.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpCat;
        private System.Windows.Forms.ComboBox cmb_Cat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ch_Cat;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_viewreport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grp_Item;
        private System.Windows.Forms.ComboBox cmb_item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ch_item;
        private System.Windows.Forms.RadioButton rd_weekly;
        private System.Windows.Forms.RadioButton rd_monthly;
        private System.Windows.Forms.RadioButton rd_custom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ch_Date;
    }
}